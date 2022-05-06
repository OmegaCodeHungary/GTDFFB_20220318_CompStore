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
    public partial class UserControlCartItem : UserControl
    {
        private Item getItem = null;

        public UserControlCartItem(Item item)
        {
            InitializeComponent();

            getItem = item;

            this.pictureBox_image.BackgroundImage = item.Image;

            this.label_name.Text = item.Name;
            this.label_category.Text = item.Category.ToString();
            this.label_pieces.Text = item.Pieces.ToString() + " db";
            this.label_price.Text = item.Price.ToString("C0");
            this.label_sum.Text = (item.Pieces * item.Price).ToString("C0");
        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            try
            {
                // Első körben megnézzük, hogy létezik-e már ez az item a kosárban
                Item item = Global.shoppingCart.Where(x => x.Id == getItem.Id).FirstOrDefault();
                if (item != null)
                {
                    if (item.Pieces >= 2)
                    {
                        // Ha igen, akkor az értékét csökkentjük eggyel
                        item.Pieces = item.Pieces - 1;
                    }
                    else
                    {
                        // Amennyiben nem létezik, vagy az utolsó darab, akkor töröljük
                        Global.shoppingCart.Remove(getItem);
                    }

                    Global.formCart.ChangeHandler();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            try
            {
                // Első körben megnézzük, hogy létezik-e már ez az item a kosárban
                Item item = Global.shoppingCart.Where(x => x.Id == getItem.Id).FirstOrDefault();
                if (item != null)
                {
                    // Ha igen, akkor az értékét növeljük eggyel
                    item.Pieces = item.Pieces + 1;

                    Global.formCart.ChangeHandler();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
