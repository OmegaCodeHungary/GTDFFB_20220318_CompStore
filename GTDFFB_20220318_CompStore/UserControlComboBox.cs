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
    public partial class UserControlComboBox : UserControl
    {
        private int last = 0;

        public UserControlComboBox()
        {
            InitializeComponent();

            this.comboBox_tipusok.Items.Add("Összes");
            this.comboBox_tipusok.Items.Add("Monitor");
            this.comboBox_tipusok.Items.Add("Számítógép");
            this.comboBox_tipusok.Items.Add("Tablet");

            this.comboBox_tipusok.SelectedText = Global.itemType.ToString();
        }

        private void comboBox_tipusok_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBox_tipusok.SelectedIndex > -1)
            {
                String kivalasztott_tipus = this.comboBox_tipusok.SelectedItem.ToString(); 

                Global.formControl.ChangeHandler(kivalasztott_tipus);
            }
        }

        private void UserControlComboBox_Resize(object sender, EventArgs e)
        {
            int index = this.comboBox_tipusok.FindString(Global.itemType);

            if (index > -1 && index != last)
            {
                last = index;
                this.comboBox_tipusok.SelectedIndex = index;
            }
        }
    }
}
