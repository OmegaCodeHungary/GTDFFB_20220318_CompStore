namespace GTDFFB_20220318_CompStore
{
    partial class FormControl
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
            this.tlp_menu = new System.Windows.Forms.TableLayoutPanel();
            this.panel_menu = new System.Windows.Forms.Panel();
            this.tlp_images = new System.Windows.Forms.TableLayoutPanel();
            this.panel_items = new System.Windows.Forms.Panel();
            this.pictureBox_business = new System.Windows.Forms.PictureBox();
            this.button_cart = new System.Windows.Forms.Button();
            this.tlp_main.SuspendLayout();
            this.tlp_menu.SuspendLayout();
            this.tlp_images.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_business)).BeginInit();
            this.SuspendLayout();
            // 
            // tlp_main
            // 
            this.tlp_main.ColumnCount = 1;
            this.tlp_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_main.Controls.Add(this.tlp_menu, 0, 1);
            this.tlp_main.Controls.Add(this.tlp_images, 0, 0);
            this.tlp_main.Controls.Add(this.panel_items, 0, 2);
            this.tlp_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_main.Location = new System.Drawing.Point(0, 0);
            this.tlp_main.Margin = new System.Windows.Forms.Padding(2);
            this.tlp_main.Name = "tlp_main";
            this.tlp_main.RowCount = 3;
            this.tlp_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.tlp_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tlp_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_main.Size = new System.Drawing.Size(1192, 506);
            this.tlp_main.TabIndex = 0;
            // 
            // tlp_menu
            // 
            this.tlp_menu.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tlp_menu.ColumnCount = 3;
            this.tlp_menu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlp_menu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_menu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlp_menu.Controls.Add(this.panel_menu, 1, 0);
            this.tlp_menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_menu.Location = new System.Drawing.Point(2, 80);
            this.tlp_menu.Margin = new System.Windows.Forms.Padding(2);
            this.tlp_menu.Name = "tlp_menu";
            this.tlp_menu.RowCount = 1;
            this.tlp_menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_menu.Size = new System.Drawing.Size(1188, 27);
            this.tlp_menu.TabIndex = 0;
            // 
            // panel_menu
            // 
            this.panel_menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_menu.Location = new System.Drawing.Point(30, 2);
            this.panel_menu.Margin = new System.Windows.Forms.Padding(2);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(1128, 23);
            this.panel_menu.TabIndex = 0;
            // 
            // tlp_images
            // 
            this.tlp_images.ColumnCount = 3;
            this.tlp_images.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlp_images.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_images.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlp_images.Controls.Add(this.pictureBox_business, 1, 0);
            this.tlp_images.Controls.Add(this.button_cart, 2, 0);
            this.tlp_images.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_images.Location = new System.Drawing.Point(3, 3);
            this.tlp_images.Name = "tlp_images";
            this.tlp_images.RowCount = 1;
            this.tlp_images.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_images.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tlp_images.Size = new System.Drawing.Size(1186, 72);
            this.tlp_images.TabIndex = 1;
            // 
            // panel_items
            // 
            this.panel_items.AutoScroll = true;
            this.panel_items.AutoSize = true;
            this.panel_items.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_items.Location = new System.Drawing.Point(3, 112);
            this.panel_items.Name = "panel_items";
            this.panel_items.Size = new System.Drawing.Size(1186, 391);
            this.panel_items.TabIndex = 2;
            // 
            // pictureBox_business
            // 
            this.pictureBox_business.BackgroundImage = global::GTDFFB_20220318_CompStore.Properties.Resources.forbidden;
            this.pictureBox_business.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox_business.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_business.Location = new System.Drawing.Point(103, 3);
            this.pictureBox_business.Name = "pictureBox_business";
            this.pictureBox_business.Size = new System.Drawing.Size(980, 66);
            this.pictureBox_business.TabIndex = 0;
            this.pictureBox_business.TabStop = false;
            // 
            // button_cart
            // 
            this.button_cart.BackgroundImage = global::GTDFFB_20220318_CompStore.Properties.Resources.shopping_cart;
            this.button_cart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_cart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_cart.Location = new System.Drawing.Point(1089, 3);
            this.button_cart.Name = "button_cart";
            this.button_cart.Size = new System.Drawing.Size(94, 66);
            this.button_cart.TabIndex = 1;
            this.button_cart.UseVisualStyleBackColor = true;
            this.button_cart.Click += new System.EventHandler(this.button_cart_Click);
            // 
            // FormControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1192, 506);
            this.Controls.Add(this.tlp_main);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Computer Store";
            this.Load += new System.EventHandler(this.FormControl_Load);
            this.Resize += new System.EventHandler(this.FormControl_Resize);
            this.tlp_main.ResumeLayout(false);
            this.tlp_main.PerformLayout();
            this.tlp_menu.ResumeLayout(false);
            this.tlp_images.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_business)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_main;
        private System.Windows.Forms.TableLayoutPanel tlp_menu;
        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.TableLayoutPanel tlp_images;
        private System.Windows.Forms.PictureBox pictureBox_business;
        private System.Windows.Forms.Button button_cart;
        private System.Windows.Forms.Panel panel_items;
    }
}

