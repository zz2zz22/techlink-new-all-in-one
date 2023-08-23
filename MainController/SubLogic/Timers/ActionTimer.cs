using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using techlink_new_all_in_one.View.CustomUI;

namespace techlink_new_all_in_one.MainController.SubLogic
{
    public class ActionTimer
    {
        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }
        public void switchActionTimer(XanderUI.XUISwitch xUISwitch)
        {
            CountDownTimer countDownTimer = new CountDownTimer();
            countDownTimer.SetTime(0, 1);
            if (countDownTimer == null || !countDownTimer.IsRunning)
            {
                countDownTimer.Start();
                xUISwitch.Enabled = false;
                countDownTimer.CountDownFinished += () => finishSwitchActionTimer(countDownTimer, xUISwitch);
                countDownTimer.StepMs = 50;
            }
        }
        private void finishSwitchActionTimer(CountDownTimer countDownTimer, XanderUI.XUISwitch xUISwitch)
        {
            xUISwitch.Enabled = true;
            countDownTimer.Delete();
            countDownTimer.Dispose();
        }
    }
}
