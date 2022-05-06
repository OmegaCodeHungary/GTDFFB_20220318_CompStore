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
    public partial class UserControlItem : UserControl
    {
        private Item getItem = null;

        public UserControlItem(Item item)
        {
            InitializeComponent();

            getItem = item;

            this.pictureBox_image.BackgroundImage = item.Image;

            this.label_name.Text = item.Name;
            this.label_category.Text = item.Category.ToString();
            this.label_price.Text = item.Price.ToString("C0");
        }

        private void button_add_cart_Click(object sender, EventArgs e)
        {
            try
            {
                // Első körben megnézzük, hogy létezik-e már ez az item a kosárban
                Item item = Global.shoppingCart.Where(x => x.Id == getItem.Id).FirstOrDefault();
                if (item == null || item.Pieces == 0)
                {
                    // Amennyiben nem létezik, akkor hozzáadjuk
                    getItem.Pieces = 1;
                    Global.shoppingCart.Add(getItem);
                }
                else
                {
                    // Ha igen, akkor az értékét növeljük eggyel
                    item.Pieces = item.Pieces + 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
