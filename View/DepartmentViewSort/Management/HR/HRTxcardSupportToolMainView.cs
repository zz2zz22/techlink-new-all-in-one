using com.sun.org.apache.bcel.@internal.generic;
using javax.net.ssl;
using Org.BouncyCastle.Utilities.Zlib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using techlink_new_all_in_one.MainController.SubLogic;
using techlink_new_all_in_one.MainModel;
using ClosedXML.Excel;

namespace techlink_new_all_in_one
{
    public partial class HRTxcardSupportToolMainView : Form
    {
        SqlHR sqlHR = new SqlHR();
        private string _selectedFilePath = string.Empty;

        public HRTxcardSupportToolMainView()
        {
            InitializeComponent();
        }

        private void btnAddMonth_Click(object sender, EventArgs e)
        {
            StringBuilder query = new StringBuilder();
            query.Append("Declare @n Int\r\n" +
                "Declare @nDate DateTime\r\n" +
                "SEt @nDate =(Select Max(Date0 ) from S_Session)\r\n" +
                "Set @n =1\r\n" +
                "While @n <= " + nudMonthAdd.Value +
                "begin\r\n" +
                "   Insert into S_Session (Date0,Date1 ,isEnd)\r\n" +
                "   Select DateAdd (Month, @n,@nDate ),DateAdd( Day,-1 ,DateAdd( Month,@n +1, @nDate)),0\r\n" +
                "   Set @n=@n +1\r\n" +
                "end\r\n" +
                "--==更新年份，季度，月份等信息\r\n" +
                "Update S_Session Set AllDays=DateDiff (Day, Date0,Date1 )+1,\r\n" +
                "Memo=Cast (Datepart( Year,Date0 ) as Varchar( 4))+'年'+( Case when Datepart(Month ,Date0)< 10 then '0' else '' end)\r\n" +
                "+Cast( Datepart(Month ,Date0) as Varchar(2 ))+'月'\r\n" +
                "where isnull(Memo,'')=''");
            sqlHR.sqlExecuteNonQuery(query.ToString(), "Thêm thành công", "Lỗi");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string checkData = "select Name from ZlEmployee where code like '" + txbEmployeeCode.Texts.Trim().ToUpper() + "'";
            string emp = sqlHR.sqlExecuteScalarString(checkData);
            string empCode = txbEmployeeCode.Texts.Trim().ToUpper();
            if (String.IsNullOrEmpty(emp))
            {
                CTMessageBox.Show("Không thể tìm thấy nhân viên vừa nhập trên hệ thống, vui lòng kiểm tra lại mã nhân viên!");
            }
            else
            {
                StringBuilder query = new StringBuilder();
                query.Append("update ZlEmployee set \r\n" +
                    "  ZzDate = '" + txbDateIn.Texts.Trim() + " 00:00:00.000',\r\n" +
                    "  State = 0,\r\n" +
                    "  LzDate = NULL,\r\n" +
                    "  LzCause = NULL,\r\n" +
                    "  LzTc = NULL\r\n" +
                    "  where Code like '" + empCode + "' and State = 9");
                sqlHR.sqlExecuteNonQuery(query.ToString(), "Thêm thành công", "Lỗi");
            }
        }

        private void txbDateIn__TextChanged(object sender, EventArgs e)
        {

        }

        // ── 1. Open file dialog & let user pick a sheet ──────────────────────────
        /// <summary>
        /// Opens a file-picker, lets the user choose an Excel file,
        /// then prompts for a sheet selection. Returns the loaded DataTable
        /// or null if the user cancelled at any point.
        /// </summary>
        public DataTable OpenAndReadExcel()
        {
            OpenFileDialog dlg = new OpenFileDialog
            {
                Title = "Chọn file Excel",
                Filter = "Excel Files (*.xlsx;*.xlsm)|*.xlsx;*.xlsm|All Files (*.*)|*.*",
                FilterIndex = 1,
                RestoreDirectory = true
            };

            using (dlg)
            {
                if (dlg.ShowDialog() != DialogResult.OK)
                    return null;

                _selectedFilePath = dlg.FileName;
            }

            // ── 2. Read sheet names and let user pick one ────────────────────────
            string sheetName = PickSheet(_selectedFilePath);
            if (sheetName == null)
                return null;

            // ── 3. Parse the sheet into a DataTable ──────────────────────────────
            return ReadSheetToDataTable(_selectedFilePath, sheetName);
        }

        // ── Helper: sheet picker dialog ──────────────────────────────────────────
        private string PickSheet(string filePath)
        {
            string[] sheetNames;

            try
            {
                using (var wb = new XLWorkbook(filePath))
                {
                    sheetNames = wb.Worksheets.Select(ws => ws.Name).ToArray();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể mở file:\n" + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            if (sheetNames.Length == 0)
            {
                MessageBox.Show("File không có sheet nào.", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            // Build a small picker form on-the-fly
            Form picker = new Form
            {
                Text = "Chọn Sheet",
                Width = 340,
                Height = 160,
                StartPosition = FormStartPosition.CenterParent,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false,
                MinimizeBox = false
            };

            Label lbl = new Label { Text = "Sheet:", Left = 12, Top = 16, Width = 50 };
            ComboBox cmb = new ComboBox
            {
                Left = 68,
                Top = 12,
                Width = 230,
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            cmb.Items.AddRange(sheetNames);
            cmb.SelectedIndex = 0;

            Button btnOk = new Button
            {
                Text = "OK",
                DialogResult = DialogResult.OK,
                Left = 148,
                Top = 60,
                Width = 75
            };
            Button btnCancel = new Button
            {
                Text = "Huỷ",
                DialogResult = DialogResult.Cancel,
                Left = 230,
                Top = 60,
                Width = 75
            };

            picker.Controls.AddRange(new Control[] { lbl, cmb, btnOk, btnCancel });
            picker.AcceptButton = btnOk;
            picker.CancelButton = btnCancel;

            using (picker)
            {
                return picker.ShowDialog() == DialogResult.OK
                    ? cmb.SelectedItem != null ? cmb.SelectedItem.ToString() : null
                    : null;
            }
        }

        // ── 2. Core reader ───────────────────────────────────────────────────────
        /// <summary>
        /// Reads the specified sheet and returns a DataTable containing only
        /// the mapped columns. Scans from the bottom upward and stops at the
        /// first row that has "R" in column K (only new rows without R are kept).
        /// </summary>
        public DataTable ReadSheetToDataTable(string filePath, string sheetName)
        {
            DataTable dt = BuildSchema();

            try
            {
                using (var wb = new XLWorkbook(filePath))
                {
                    IXLWorksheet ws;
                    if (!wb.TryGetWorksheet(sheetName, out ws))
                    {
                        MessageBox.Show("Không tìm thấy sheet \"" + sheetName + "\".", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return null;
                    }

                    int lastRow = ws.LastRowUsed() != null ? ws.LastRowUsed().RowNumber() : 1;
                    int firstDataRow = FindFirstDataRow(ws);

                    // Collect rows bottom-up, stop when we hit a row marked "R"
                    for (int r = lastRow; r >= firstDataRow; r--)
                    {
                        string txCard = CellStr(ws, r, 12); // column L

                        if (txCard.Equals("R", StringComparison.OrdinalIgnoreCase))
                            break; // hit the already-imported boundary → stop

                        if (IsRowEmpty(ws, r))
                            continue;

                        dt.Rows.InsertAt(MapRow(ws, r, dt), 0); // insert at top to keep order
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đọc file:\n" + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            return dt;
        }

        // ── Schema ───────────────────────────────────────────────────────────────
        private static DataTable BuildSchema()
        {
            DataTable dt = new DataTable("NewEmployees");
            dt.Columns.Add("Code", typeof(string));   // A  - MSNV / 工号
            dt.Columns.Add("FullName", typeof(string));   // B  - Họ và tên (diacritics)
            dt.Columns.Add("FullNameUnicode", typeof(string));   // C  - Họ và tên (no diacritics)
            dt.Columns.Add("IDCode", typeof(string));   // D  - CMND mới (long number)
            dt.Columns.Add("SeasonalCompany", typeof(string));   // E  - Seasonal Company Code (999-9)
            dt.Columns.Add("DateOfBirth", typeof(DateTime)); // F  - Ngày sinh
            dt.Columns.Add("HireDate", typeof(DateTime)); // G  - Ngày nhận việc
            dt.Columns.Add("Gender", typeof(int));      // H  - 0=Nam / 1=Nữ
            return dt;
        }

        // ── Map one worksheet row → DataRow ─────────────────────────────────────
        private static DataRow MapRow(IXLWorksheet ws, int r, DataTable dt)
        {
            DataRow row = dt.NewRow();

            row["Code"] = CellStr(ws, r, 2);  // B
            row["FullName"] = CellStr(ws, r, 3);  // C
            row["FullNameUnicode"] = CellStr(ws, r, 4);  // D
            row["IDCode"] = CellStr(ws, r, 5);  // E - long CMND number
            row["SeasonalCompany"] = CellStr(ws, r, 6);  // F - format 999-9

            // Date of Birth (G = col 7)
            row["DateOfBirth"] = ParseDate(ws.Cell(r, 7));

            // Hire Date (H = col 8)
            row["HireDate"] = ParseDate(ws.Cell(r, 8));

            // Gender (I = col 9): "Nam" → 0, anything else (Nữ) → 1
            string gender = CellStr(ws, r, 9).Trim();
            row["Gender"] = gender.Equals("Nam", StringComparison.OrdinalIgnoreCase) ? 0 : 1;

            return row;
        }

        // ── Utilities ────────────────────────────────────────────────────────────

        /// <summary>
        /// Detects the first actual data row by looking for a row whose column A
        /// starts with a company code prefix (contains "-" or starts with a digit).
        /// Falls back to row 3 if not found.
        /// </summary>
        private static int FindFirstDataRow(IXLWorksheet ws)
        {
            int last = ws.LastRowUsed() != null ? ws.LastRowUsed().RowNumber() : 1;
            for (int r = 1; r <= last; r++)
            {
                string val = CellStr(ws, r, 2); // check column B for code
                if (!string.IsNullOrWhiteSpace(val) &&
                    (val.Contains("-") || char.IsDigit(val[0])))
                    return r;
            }
            return 3; // safe fallback
        }

        private static string CellStr(IXLWorksheet ws, int row, int col)
        {
            string val = ws.Cell(row, col).GetValue<string>();
            return val != null ? val.Trim() : string.Empty;
        }

        private static object ParseDate(IXLCell cell)
        {
            try
            {
                if (cell.DataType == XLDataType.DateTime)
                    return cell.GetDateTime();

                string s = cell.GetValue<string>().Trim();
                DateTime d;
                if (DateTime.TryParseExact(s,
                        new[] { "yyyy/MM/dd", "yyyy-MM-dd", "dd/MM/yyyy", "MM/dd/yyyy" },
                        System.Globalization.CultureInfo.InvariantCulture,
                        System.Globalization.DateTimeStyles.None,
                        out d))
                    return d;
            }
            catch { /* fall through */ }

            return DBNull.Value;
        }

        private static bool IsRowEmpty(IXLWorksheet ws, int r)
        {
            for (int c = 2; c <= 12; c++) // B through L
                if (!string.IsNullOrWhiteSpace(CellStr(ws, r, c)))
                    return false;
            return true;
        }



        private void btnChooseHRDataFile_Click(object sender, EventArgs e)
        {
            dtgv_NewEmployeeData.DataSource = OpenAndReadExcel();
        }

        private void btnAddSelectedEmployee_Click(object sender, EventArgs e)
        {
            DataTable dt = GetSelectedRowsAsDataTable(dtgv_NewEmployeeData);
            if (dt != null)
            {
                SqlHR sqlHR = new SqlHR();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    try
                    {
                        StringBuilder query = new StringBuilder();
                        query.Append("insert into ZlEmployee (Dept, Code, CardNo, Name, Sfz, BornDate, Sex, PyDate, IfDaKa, State, cy)\r\n" +
                            "values ('" + dt.Rows[i]["SeasonalCompany"] + "', '" + dt.Rows[i]["Code"] + "', '', N'" + dt.Rows[i]["FullNameUnicode"] + "', '" + dt.Rows[i]["IDCode"] + "', \r\n" +
                            "'" + ((DateTime)dt.Rows[i]["DateOfBirth"]).ToString("yyyy-MM-dd") + "', " + dt.Rows[i]["Gender"].ToString() + ", '" + ((DateTime)dt.Rows[i]["HireDate"]).ToString("yyyy-MM-dd") + "', 1, 0, 0)");
                        sqlHR.sqlExecuteNonQuery(query.ToString(), "Thêm nhân viên " + dt.Rows[i]["Code"] + " thành công", "Lỗi khi thêm nhân viên " + dt.Rows[i]["Code"]);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi thêm nhân viên " + dt.Rows[i]["Code"] + ":\n" + ex.Message, "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private DataTable GetSelectedRowsAsDataTable(DataGridView dtgv)
        {
            if (dtgv.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một dòng.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }

            DataTable source = dtgv.DataSource as DataTable;
            if (source == null)
            {
                MessageBox.Show("Không có dữ liệu trong danh sách.", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            DataTable result = source.Clone();

            List<DataGridViewRow> sorted = new List<DataGridViewRow>();
            foreach (DataGridViewRow row in dtgv.SelectedRows)
            {
                if (!row.IsNewRow)
                    sorted.Add(row);
            }
            sorted.Sort((a, b) => a.Index.CompareTo(b.Index));

            foreach (DataGridViewRow gridRow in sorted)
            {
                DataRow sourceRow = (gridRow.DataBoundItem as DataRowView)?.Row;
                if (sourceRow != null)
                    result.ImportRow(sourceRow);
            }

            return result;
        }



        // ─────────────────────────────────────────────
        //  Column index constants (1-based, as in Excel)
        //  Sheet: CẮT NGHỈ VIỆC CÔNG NHÂN THỜI VỤ
        // ─────────────────────────────────────────────
        // B=2  Code MSNV (工号)
        // D=4  Ngày nghỉ việc  (ResignDate)
        // E=5  Cắt nghỉ việc   (DeleteDate) ← formula cell, read cached value
        // F=6  Giảm TX card    ← skip row when value == "R"
        // ─────────────────────────────────────────────

        /// <summary>
        /// Opens a file-picker, lets the user choose a sheet, then reads
        /// resign data into a DataTable. Rows with "R" in column F are skipped.
        /// </summary>
        public DataTable OpenAndReadResignExcel()
        {
            string filePath;

            OpenFileDialog dlg = new OpenFileDialog
            {
                Title = "Chọn file Excel cắt nghỉ việc",
                Filter = "Excel Files (*.xlsx;*.xlsm)|*.xlsx;*.xlsm|All Files (*.*)|*.*",
                FilterIndex = 1,
                RestoreDirectory = true
            };

            using (dlg)
            {
                if (dlg.ShowDialog() != DialogResult.OK)
                    return null;

                filePath = dlg.FileName;
            }

            string sheetName = PickSheet(filePath);
            if (sheetName == null)
                return null;

            return ReadResignSheetToDataTable(filePath, sheetName);
        }

        /// <summary>
        /// Reads the specified sheet and returns a DataTable with Code,
        /// ResignDate, and DeleteDate. Skips rows where column F == "R".
        /// Scans bottom-up and stops at the first "R" row (same logic as
        /// the employee import — everything above that line is already processed).
        /// </summary>
        public DataTable ReadResignSheetToDataTable(string filePath, string sheetName)
        {
            DataTable dt = BuildResignSchema();

            try
            {
                using (var wb = new XLWorkbook(filePath))
                {
                    IXLWorksheet ws;
                    if (!wb.TryGetWorksheet(sheetName, out ws))
                    {
                        MessageBox.Show("Không tìm thấy sheet \"" + sheetName + "\".", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return null;
                    }

                    int lastRow = ws.LastRowUsed() != null ? ws.LastRowUsed().RowNumber() : 1;
                    int firstDataRow = FindResignFirstDataRow(ws);

                    for (int r = lastRow; r >= firstDataRow; r--)
                    {
                        string giamTx = CellStr(ws, r, 6); // column F

                        // Hit the already-processed boundary → stop
                        if (giamTx.Equals("R", StringComparison.OrdinalIgnoreCase))
                            break;

                        if (IsResignRowEmpty(ws, r))
                            continue;

                        dt.Rows.InsertAt(MapResignRow(ws, r, dt), 0);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đọc file:\n" + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            return dt;
        }

        // ── Schema ───────────────────────────────────────────────────────────────────
        private static DataTable BuildResignSchema()
        {
            DataTable dt = new DataTable("ResignEmployees");
            dt.Columns.Add("Code", typeof(string));   // B - MSNV
            dt.Columns.Add("ResignDate", typeof(DateTime)); // D - Ngày nghỉ việc
            dt.Columns.Add("DeleteDate", typeof(DateTime)); // E - Cắt nghỉ việc (formula value)
            return dt;
        }

        // ── Map one row ───────────────────────────────────────────────────────────────
        private static DataRow MapResignRow(IXLWorksheet ws, int r, DataTable dt)
        {
            DataRow row = dt.NewRow();

            row["Code"] = CellStr(ws, r, 2); // B

            object resignDate = ParseResignDate(ws.Cell(r, 4)); // D
            row["ResignDate"] = resignDate;

            // DeleteDate = ResignDate + 1 day (column E is a formula, read it as ResignDate + 1)
            if (resignDate != DBNull.Value)
                row["DeleteDate"] = ((DateTime)resignDate).AddDays(1);
            else
                row["DeleteDate"] = DBNull.Value;

            return row;
        }

        // ── Detect first data row (look for "TV-" pattern in column B) ───────────────
        private static int FindResignFirstDataRow(IXLWorksheet ws)
        {
            int last = ws.LastRowUsed() != null ? ws.LastRowUsed().RowNumber() : 1;
            for (int r = 1; r <= last; r++)
            {
                string val = CellStr(ws, r, 2); // column B
                if (!string.IsNullOrWhiteSpace(val) &&
                    (val.Contains("-") || char.IsDigit(val[0])))
                    return r;
            }
            return 3; // safe fallback
        }

        // ── Utilities ─────────────────────────────────────────────────────────────────
        /// <summary>
        /// Reads a date cell. Handles normal date cells, formula cells (cached value),
        /// and OLE Automation date serials stored as numbers.
        /// </summary>
        private static object ParseResignDate(IXLCell cell)
        {
            try
            {
                // 1. Native DateTime type
                if (cell.DataType == XLDataType.DateTime)
                    return cell.GetDateTime();

                // 2. Formula cell — try reading cached numeric value as OLE date serial
                //    Excel stores dates as numbers (e.g. 46034 = 13/01/2026)
                if (cell.HasFormula)
                {
                    double serial;
                    if (double.TryParse(
                            cell.CachedValue.ToString(),
                            System.Globalization.NumberStyles.Any,
                            System.Globalization.CultureInfo.InvariantCulture,
                            out serial) && serial > 0)
                        return DateTime.FromOADate(serial);

                    // Also try GetValue as DateTime directly on formula cell
                    try
                    {
                        DateTime fdt = cell.GetValue<DateTime>();
                        if (fdt != default(DateTime))
                            return fdt;
                    }
                    catch { /* ignore */ }
                }

                // 3. Numeric cell (date stored as number without formula)
                if (cell.DataType == XLDataType.Number)
                {
                    double serial = cell.GetValue<double>();
                    if (serial > 0)
                        return DateTime.FromOADate(serial);
                }

                // 4. String fallback — try common date formats
                string s = cell.GetValue<string>().Trim();
                if (!string.IsNullOrEmpty(s))
                {
                    DateTime parsed;
                    if (DateTime.TryParseExact(s,
                            new[] { "dd/MM/yyyy", "yyyy-MM-dd", "yyyy/MM/dd", "MM/dd/yyyy", "d/M/yyyy" },
                            System.Globalization.CultureInfo.InvariantCulture,
                            System.Globalization.DateTimeStyles.None,
                            out parsed))
                        return parsed;

                    // Last resort — let .NET try any format
                    DateTime loose;
                    if (DateTime.TryParse(s, out loose))
                        return loose;
                }
            }
            catch { /* fall through */ }

            return DBNull.Value;
        }

        private static bool IsResignRowEmpty(IXLWorksheet ws, int r)
        {
            // Only check the columns we care about
            return string.IsNullOrWhiteSpace(CellStr(ws, r, 2)) &&
                   string.IsNullOrWhiteSpace(CellStr(ws, r, 4)) &&
                   string.IsNullOrWhiteSpace(CellStr(ws, r, 5));
        }

        private void btnChangeSelectedStatus_Click(object sender, EventArgs e)
        {
            DataTable dt = GetSelectedRowsAsDataTable(dtgv_ResignEmployeeData);
            if (dt != null)
            {
                SqlHR sqlHR = new SqlHR();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    try
                    {
                        StringBuilder query = new StringBuilder();
                        query.Append("update ZlEmployee set \r\n" +
                            "  State = 9,\r\n" +
                            "  LzDate = '" + ((DateTime)dt.Rows[i]["DeleteDate"]).ToString("yyyy-MM-dd") + " 00:00:00.000',\r\n" +
                            "  LzTc = 0 \r\n" +
                            "  where Code like '" + dt.Rows[i]["Code"] + "' and State = 0");
                        sqlHR.sqlExecuteNonQuery(query.ToString(), "Cập nhật nhân viên " + dt.Rows[i]["Code"] + " thành công", "Lỗi khi cập nhật nhân viên " + dt.Rows[i]["Code"]);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi cập nhật nhân viên " + dt.Rows[i]["Code"] + ":\n" + ex.Message, "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnChooseResignDataFile_Click(object sender, EventArgs e)
        {
            dtgv_ResignEmployeeData.DataSource = OpenAndReadResignExcel();
        }
    }
}
