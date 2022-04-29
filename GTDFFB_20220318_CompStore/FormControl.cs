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
    public partial class FormControl : Form
    {
        private UserControlComboBox uccb = new UserControlComboBox();

        private UserControlRadioButton ucrb = new UserControlRadioButton();

        private String valsztott_tipus = String.Empty;

        public void ChangeHandler(String tipus)
        {
            Global.itemType = tipus;
            //MessageBox.Show(tipus);
        }

        public FormControl()
        {
            InitializeComponent();

            // Form kezdeti mérete
            this.Width = 1200;
            this.Height = 640;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void FormControl_Load(object sender, EventArgs e)
        {
            // Hozzáadjuk a combobox panelt a menühöz
            uccb.Dock = DockStyle.Fill;
            this.panel_menu.Controls.Add(this.uccb);
            this.uccb.Visible = false;

            // Hozzáadjuk a radiobutton panelt a menühöz
            ucrb.Dock = DockStyle.Fill;
            this.panel_menu.Controls.Add(this.ucrb);
            this.ucrb.Visible = true;
        }

        private void FormControl_Resize(object sender, EventArgs e)
        {
            if (this.Width > 800)
            {
                this.uccb.Visible = false;
                this.ucrb.Visible = true;
            }
            else
            {
                this.uccb.Visible = true;
                this.ucrb.Visible = false;
            }
        }
    }
}
