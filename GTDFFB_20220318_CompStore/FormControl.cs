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
        private List<Item> items = new List<Item>();

        private UserControlComboBox uccb = new UserControlComboBox();

        private UserControlRadioButton ucrb = new UserControlRadioButton();

        private String valsztott_tipus = String.Empty;

        public void ChangeHandler(String tipus)
        {
            Global.itemType = tipus;

            ShowItems();
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

            // Panel AutoScroll
            this.panel_items.AutoScroll = true;

            // Create Items
            CreateItems();

            // Show Items
            ShowItems();
        }

        private void CreateItems()
        {
            items.Clear();

            // Monitorok
            items.Add(new Item()
            {
                Id = 1,
                Name = "HP monitor 15",
                Category = Enums.CategoryEnum.Monitor,
                Image = GTDFFB_20220318_CompStore.Properties.Resources.monitor,
                Price = 44000.0
            });
            items.Add(new Item()
            {
                Id = 2,
                Name = "Dell monitor 17",
                Category = Enums.CategoryEnum.Monitor,
                Image = GTDFFB_20220318_CompStore.Properties.Resources.monitor,
                Price = 54000.0
            });

            // Számítógépek
            items.Add(new Item()
            {
                Id = 3,
                Name = "Intel I9, RAM 16 Gb, GPU NVidia 3090 8 Gb",
                Category = Enums.CategoryEnum.Computer,
                Image = GTDFFB_20220318_CompStore.Properties.Resources.computer,
                Price = 274000.0
            });
            items.Add(new Item()
            {
                Id = 4,
                Name = "Intel I10, RAM 32 Gb, GPU NVidia 3090 12 Gb",
                Category = Enums.CategoryEnum.Computer,
                Image = GTDFFB_20220318_CompStore.Properties.Resources.computer,
                Price = 454000.0
            });

            // Tablet
            items.Add(new Item()
            {
                Id = 5,
                Name = "Apple Ipad",
                Category = Enums.CategoryEnum.Tablet,
                Image = GTDFFB_20220318_CompStore.Properties.Resources.tablet,
                Price = 242000.0
            });
            items.Add(new Item()
            {
                Id = 6,
                Name = "Samsung Galaxy Tab",
                Category = Enums.CategoryEnum.Tablet,
                Image = GTDFFB_20220318_CompStore.Properties.Resources.tablet,
                Price = 182000.0
            });
        }

        private void ShowItems()
        {
            this.panel_items.Controls.Clear();

            List<Item> actualItems = new List<Item>();

            if (Global.itemType == "Összes")
            {
                actualItems.AddRange(items.ToList());
            }
            else if (Global.itemType == "Monitor")
            {
                actualItems.AddRange(items.Where(w => w.Category == Enums.CategoryEnum.Monitor).Select(s => s).ToList());
            }
            else if (Global.itemType == "Számítógép")
            {
                actualItems.AddRange(items.Where(w => w.Category == Enums.CategoryEnum.Computer).Select(s => s).ToList());
            }
            else if (Global.itemType == "Tablet")
            {
                actualItems.AddRange(items.Where(w => w.Category == Enums.CategoryEnum.Tablet).Select(s => s).ToList());
            }

            int i = 0;
            foreach (Item item in actualItems)
            {
                UserControlItem controlItem = new UserControlItem(item);

                // Egy sorban hány darab fér el
                int count_row = this.Width / 505;

                // Az aktuálus item melyik sorban és oszlopban helyezkedik el
                int w = (i / count_row);
                int h = (i % count_row);

                // Az item pozícójához igazítjuk
                controlItem.Location = new Point((h * 505), (w * 185));

                this.panel_items.Controls.Add(controlItem);

                i++;
            }
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

            ShowItems();
        }

        private void button_cart_Click(object sender, EventArgs e)
        {
            Global.formCart = new FormCart();
            Global.formCart.ShowDialog();
        }
    }
}
