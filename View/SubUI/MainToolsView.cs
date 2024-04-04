using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using techlink_new_all_in_one.MainController.SubLogic;
using techlink_new_all_in_one.MainModel;
using techlink_new_all_in_one.MainModel.SaveVariables;
using techlink_new_all_in_one.View.CustomControl;
using techlink_new_all_in_one.View.SubUI.Component;

namespace techlink_new_all_in_one.View.SubUI
{
    public partial class MainToolsView : Form
    {
        private Type[] typelist;
        public MainToolsView()
        {
            InitializeComponent();
        }

        private void getMainToolInfo()
        {
            flpToolButtons.Controls.Clear();

            SqlSoft sqlSoft = new SqlSoft();
            DataTable dt = new DataTable();

            StringBuilder queryGetProgramInfo = new StringBuilder();
            queryGetProgramInfo.Append("select * from programs_info where program_type = 'main' order by program_name asc");
            sqlSoft.sqlDataAdapterFillDatatable(queryGetProgramInfo.ToString(), ref dt);

            if (dt.Rows.Count > 0)
            {
                ToolsItemButton[] listItems = new ToolsItemButton[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    listItems[i] = new ToolsItemButton();

                    if (!String.IsNullOrEmpty(dt.Rows[i]["image"].ToString()))
                    {
                        MemoryStream ms = new MemoryStream((byte[])dt.Rows[i]["image"]);
                        listItems[i].Icon = new Bitmap(ms);
                    }
                    listItems[i].Title = dt.Rows[i]["program_name"].ToString();
                    listItems[i].Name = dt.Rows[i]["program_name"].ToString();
                    listItems[i].FormName = dt.Rows[i]["program_main_form_name"].ToString();
                    listItems[i].Permission = dt.Rows[i]["program_permission"].ToString();
                    listItems[i].Status = dt.Rows[i]["program_status"].ToString();

                    flpToolButtons.Controls.Add(listItems[i]);

                    listItems[i].GlobalMouseClick += new GlobalMouseClickEventHander(this.MainToolsButton_Click);
                }
            }
        }
        private Type[] GetTypesInNamespace(Assembly assembly, string nameSpace)
        {
            return assembly.GetTypes().Where(t => String.Equals(t.Namespace, nameSpace, StringComparison.Ordinal)).ToArray();
        }
        private void MainToolsButton_Click(object sender, EventArgs e)
        {
            ToolsItemButton obj;
            if (sender is UserControl)
                obj = (ToolsItemButton)sender;
            else if (sender is PictureBox)
                obj = ((PictureBox)sender).Parent.Parent as ToolsItemButton;
            else
                obj = ((Control)sender).Parent as ToolsItemButton;

            for (int i = 0; i < typelist.Length; i++)
            {//Loop on them 
                if (typelist[i].BaseType == typeof(System.Windows.Forms.Form) && typelist[i].Name == obj.FormName)
                {//if windows form and the name is match
                    string[] permission = obj.Permission.Split(';');
                    if (permission.Contains(UserData.UserPermission))
                    {
                        if(obj.Status == "OK")
                        {
                            //Create Instance and show it
                            Form tmp = (Form)Activator.CreateInstance(typelist[i]);
                            MainDashboard.OpenChildForm(tmp, obj.Title);
                        }
                        else
                        {
                            CTMessageBox.Show("Công cụ đang được bảo trì hoặc phát triển!\r\n该工具正在维护或开发中！", "Cảnh báo 警报", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        CTMessageBox.Show("Bạn không có quyền hạn để thực hiện thao tác này!\r\n您无权执行此操作！", "Cảnh báo 警报", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void MainToolsView_Load(object sender, EventArgs e)
        {
            getMainToolInfo();
            typelist = GetTypesInNamespace(Assembly.GetExecutingAssembly(), "techlink_new_all_in_one");
        }

        private void btnAddTools_Click(object sender, EventArgs e)
        {
            if (UserData.UserPermission == "1")
            {
                AddProgramInfoView addProgramInfo = new AddProgramInfoView();
                addProgramInfo.FormClosed += addProgramInfoFormClosed;
                addProgramInfo.Show();
            }
            else
            {
                CTMessageBox.Show("Bạn không có quyền hạn để thực hiện thao tác này!\r\n您无权执行此操作！", "Cảnh báo 警报", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void addProgramInfoFormClosed(object sender, EventArgs e)
        {
            ((Form)sender).FormClosed -= addProgramInfoFormClosed;
            getMainToolInfo();
        }

        private void txbSearchTool_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                foreach (Control c in flpToolButtons.Controls)
                {
                    if (!c.Name.ToLower().Contains(txbSearchTool.Texts.ToLower()))
                    {
                        c.Hide();
                    }
                    else
                    {
                        c.Show();
                    }
                }
            }
        }

        private void txbSearchTool__TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbSearchTool.Texts.Trim()))
            {
                foreach (Control c in flpToolButtons.Controls)
                {
                    c.Show();
                }
            }
        }
    }
}
