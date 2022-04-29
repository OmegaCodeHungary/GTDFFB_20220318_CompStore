namespace GTDFFB_20220318_CompStore
{
    partial class FormCart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tlp_main = new System.Windows.Forms.TableLayoutPanel();
            this.tlp_images = new System.Windows.Forms.TableLayoutPanel();
            this.panel_items = new System.Windows.Forms.Panel();
            this.tlp_menu = new System.Windows.Forms.TableLayoutPanel();
            this.label_cart = new System.Windows.Forms.Label();
            this.pictureBox_business = new System.Windows.Forms.PictureBox();
            this.tlp_price = new System.Windows.Forms.TableLayoutPanel();
            this.label_total_price = new System.Windows.Forms.Label();
            this.label_tprice = new System.Windows.Forms.Label();
            this.tlp_main.SuspendLayout();
            this.tlp_images.SuspendLayout();
            this.tlp_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_business)).BeginInit();
            this.tlp_price.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp_main
            // 
            this.tlp_main.ColumnCount = 1;
            this.tlp_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_main.Controls.Add(this.tlp_price, 0, 3);
            this.tlp_main.Controls.Add(this.tlp_menu, 0, 1);
            this.tlp_main.Controls.Add(this.tlp_images, 0, 0);
            this.tlp_main.Controls.Add(this.panel_items, 0, 2);
            this.tlp_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_main.Location = new System.Drawing.Point(0, 0);
            this.tlp_main.Margin = new System.Windows.Forms.Padding(2);
            this.tlp_main.Name = "tlp_main";
            this.tlp_main.RowCount = 4;
            this.tlp_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.tlp_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlp_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlp_main.Size = new System.Drawing.Size(604, 461);
            this.tlp_main.TabIndex = 1;
            // 
            // tlp_images
            // 
            this.tlp_images.ColumnCount = 3;
            this.tlp_images.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlp_images.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_images.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlp_images.Controls.Add(this.pictureBox_business, 1, 0);
            this.tlp_images.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_images.Location = new System.Drawing.Point(3, 3);
            this.tlp_images.Name = "tlp_images";
            this.tlp_images.RowCount = 1;
            this.tlp_images.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_images.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tlp_images.Size = new System.Drawing.Size(598, 72);
            this.tlp_images.TabIndex = 1;
            // 
            // panel_items
            // 
            this.panel_items.AutoScroll = true;
            this.panel_items.AutoSize = true;
            this.panel_items.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_items.Location = new System.Drawing.Point(3, 131);
            this.panel_items.Name = "panel_items";
            this.panel_items.Size = new System.Drawing.Size(598, 287);
            this.panel_items.TabIndex = 2;
            // 
            // tlp_menu
            // 
            this.tlp_menu.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tlp_menu.ColumnCount = 3;
            this.tlp_menu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlp_menu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_menu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlp_menu.Controls.Add(this.label_cart, 1, 0);
            this.tlp_menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_menu.Location = new System.Drawing.Point(2, 80);
            this.tlp_menu.Margin = new System.Windows.Forms.Padding(2);
            this.tlp_menu.Name = "tlp_menu";
            this.tlp_menu.RowCount = 1;
            this.tlp_menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_menu.Size = new System.Drawing.Size(600, 46);
            this.tlp_menu.TabIndex = 0;
            // 
            // label_cart
            // 
            this.label_cart.AutoSize = true;
            this.label_cart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_cart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_cart.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_cart.Location = new System.Drawing.Point(31, 3);
            this.label_cart.Margin = new System.Windows.Forms.Padding(3);
            this.label_cart.Name = "label_cart";
            this.label_cart.Size = new System.Drawing.Size(538, 40);
            this.label_cart.TabIndex = 0;
            this.label_cart.Text = "Shopping Cart";
            this.label_cart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox_business
            // 
            this.pictureBox_business.BackgroundImage = global::GTDFFB_20220318_CompStore.Properties.Resources.forbidden;
            this.pictureBox_business.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox_business.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_business.Location = new System.Drawing.Point(103, 3);
            this.pictureBox_business.Name = "pictureBox_business";
            this.pictureBox_business.Size = new System.Drawing.Size(392, 66);
            this.pictureBox_business.TabIndex = 0;
            this.pictureBox_business.TabStop = false;
            // 
            // tlp_price
            // 
            this.tlp_price.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tlp_price.ColumnCount = 3;
            this.tlp_price.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tlp_price.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_price.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tlp_price.Controls.Add(this.label_total_price, 1, 0);
            this.tlp_price.Controls.Add(this.label_tprice, 2, 0);
            this.tlp_price.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_price.Location = new System.Drawing.Point(2, 423);
            this.tlp_price.Margin = new System.Windows.Forms.Padding(2);
            this.tlp_price.Name = "tlp_price";
            this.tlp_price.RowCount = 1;
            this.tlp_price.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_price.Size = new System.Drawing.Size(600, 36);
            this.tlp_price.TabIndex = 3;
            // 
            // label_total_price
            // 
            this.label_total_price.AutoSize = true;
            this.label_total_price.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_total_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_total_price.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_total_price.Location = new System.Drawing.Point(153, 3);
            this.label_total_price.Margin = new System.Windows.Forms.Padding(3);
            this.label_total_price.Name = "label_total_price";
            this.label_total_price.Size = new System.Drawing.Size(294, 30);
            this.label_total_price.TabIndex = 0;
            this.label_total_price.Text = "Total price:";
            this.label_total_price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_tprice
            // 
            this.label_tprice.AutoSize = true;
            this.label_tprice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_tprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_tprice.ForeColor = System.Drawing.Color.DarkGreen;
            this.label_tprice.Location = new System.Drawing.Point(453, 3);
            this.label_tprice.Margin = new System.Windows.Forms.Padding(3);
            this.label_tprice.Name = "label_tprice";
            this.label_tprice.Size = new System.Drawing.Size(144, 30);
            this.label_tprice.TabIndex = 1;
            this.label_tprice.Text = "label_tprice";
            this.label_tprice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 461);
            this.Controls.Add(this.tlp_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCart";
            this.Load += new System.EventHandler(this.FormCart_Load);
            this.tlp_main.ResumeLayout(false);
            this.tlp_main.PerformLayout();
            this.tlp_images.ResumeLayout(false);
            this.tlp_menu.ResumeLayout(false);
            this.tlp_menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_business)).EndInit();
            this.tlp_price.ResumeLayout(false);
            this.tlp_price.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_main;
        private System.Windows.Forms.TableLayoutPanel tlp_images;
        private System.Windows.Forms.PictureBox pictureBox_business;
        private System.Windows.Forms.Panel panel_items;
        private System.Windows.Forms.TableLayoutPanel tlp_menu;
        private System.Windows.Forms.Label label_cart;
        private System.Windows.Forms.TableLayoutPanel tlp_price;
        private System.Windows.Forms.Label label_total_price;
        private System.Windows.Forms.Label label_tprice;
    }
}