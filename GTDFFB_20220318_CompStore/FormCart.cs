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
    public partial class FormCart : Form
    {
        public FormCart()
        {
            InitializeComponent();
        }

        private void FormCart_Load(object sender, EventArgs e)
        {
            ShowItems();
        }

        private void ShowItems()
        {
            this.panel_items.Controls.Clear();

            if (Global.shoppingCart.Count > 0)
            {
                // 598
                if (this.panel_items.Height < (Global.shoppingCart.Count * 105))
                {
                    this.Width = 840;
                }
                else
                {
                    this.Width = 820;
                }

                this.Refresh();

                int i = 0;
                foreach (Item item in Global.shoppingCart)
                {
                    UserControlCartItem uci = new UserControlCartItem(item);

                    // Az item pozícójához igazítjuk
                    uci.Location = new Point(0, (i * 105));

                    this.panel_items.Controls.Add(uci);

                    i++;
                }

            }

            this.label_tprice.Text = Global.shoppingCart.Sum(s => (s.Pieces * s.Price)).ToString("C0");
        }

        public void ChangeHandler()
        {
            ShowItems();
        }
    }
}
