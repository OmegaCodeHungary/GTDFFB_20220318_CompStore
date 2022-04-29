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
            this.label_price.Text = item.Price.ToString("C0");
        }

        private void button_remove_Click(object sender, EventArgs e)
        {
            Global.shoppingCart.Remove(getItem);

            Global.formCart.ChangeHandler();
        }
    }
}
