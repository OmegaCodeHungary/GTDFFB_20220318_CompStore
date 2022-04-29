using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GTDFFB_20220318_CompStore
{
    public partial class UserControlRadioButton : UserControl
    {
        private String last = "Összes";

        public UserControlRadioButton()
        {
            InitializeComponent();
        }

        private void radioButton_osszes_CheckedChanged(object sender, EventArgs e)
        {
            if (last != "Összes")
            {
                last = "Összes";
                //this.radioButton_osszes.Checked = true;
                this.radioButton_monitor.Checked = false;
                this.radioButton_szamitogep.Checked = false;
                this.radioButton_tablet.Checked = false;

                Global.formControl.ChangeHandler("Összes");

                this.Refresh();
            }
        }

        private void radioButton_monitor_CheckedChanged(object sender, EventArgs e)
        {
            if (last != "Monitor")
            {
                last = "Monitor";
                this.radioButton_osszes.Checked = false;
                //this.radioButton_monitor.Checked = true;
                this.radioButton_szamitogep.Checked = false;
                this.radioButton_tablet.Checked = false;

                Global.formControl.ChangeHandler("Monitor");

                this.Refresh();
            }
        }

        private void radioButton_szamitogep_CheckedChanged(object sender, EventArgs e)
        {
            if (last != "Számítógép")
            {
                last = "Számítógép";
                this.radioButton_osszes.Checked = false;
                this.radioButton_monitor.Checked = false;
                //this.radioButton_szamitogep.Checked = true;
                this.radioButton_tablet.Checked = false;

                Global.formControl.ChangeHandler("Számítógép");

                this.Refresh();
            }
        }

        private void radioButton_tablet_CheckedChanged(object sender, EventArgs e)
        {
            if (last != "Tablet")
            {
                last = "Tablet";
                this.radioButton_osszes.Checked = false;
                this.radioButton_monitor.Checked = false;
                this.radioButton_szamitogep.Checked = false;
                //this.radioButton_tablet.Checked = true;

                Global.formControl.ChangeHandler("Tablet");

                this.Refresh();
            }
        }

        private void UserControlRadioButton_Resize(object sender, EventArgs e)
        {
            if (Global.itemType != last)
            {
                if (Global.itemType == "Összes")
                {
                    this.radioButton_osszes.Checked = true;
                }
                else if (Global.itemType == "Monitor")
                {
                    this.radioButton_monitor.Checked = true;
                }
                else if (Global.itemType == "Számítógép")
                {
                    this.radioButton_szamitogep.Checked = true;
                }
                else if (Global.itemType == "Tablet")
                {
                    this.radioButton_tablet.Checked = true;
                }
            }
        }
    }
}
