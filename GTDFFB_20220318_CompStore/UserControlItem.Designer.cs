namespace GTDFFB_20220318_CompStore
{
    partial class UserControlItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlItem));
            this.tlp_main = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox_image = new System.Windows.Forms.PictureBox();
            this.tlp_controls = new System.Windows.Forms.TableLayoutPanel();
            this.label_price = new System.Windows.Forms.Label();
            this.label_category = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.button_add_cart = new System.Windows.Forms.Button();
            this.tlp_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_image)).BeginInit();
            this.tlp_controls.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp_main
            // 
            this.tlp_main.ColumnCount = 2;
            this.tlp_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tlp_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tlp_main.Controls.Add(this.pictureBox_image, 0, 0);
            this.tlp_main.Controls.Add(this.tlp_controls, 1, 0);
            this.tlp_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_main.Location = new System.Drawing.Point(0, 0);
            this.tlp_main.Name = "tlp_main";
            this.tlp_main.RowCount = 1;
            this.tlp_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_main.Size = new System.Drawing.Size(500, 180);
            this.tlp_main.TabIndex = 0;
            // 
            // pictureBox_image
            // 
            this.pictureBox_image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox_image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_image.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_image.Location = new System.Drawing.Point(3, 3);
            this.pictureBox_image.Name = "pictureBox_image";
            this.pictureBox_image.Size = new System.Drawing.Size(169, 174);
            this.pictureBox_image.TabIndex = 0;
            this.pictureBox_image.TabStop = false;
            // 
            // tlp_controls
            // 
            this.tlp_controls.ColumnCount = 1;
            this.tlp_controls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_controls.Controls.Add(this.label_price, 0, 2);
            this.tlp_controls.Controls.Add(this.label_category, 0, 1);
            this.tlp_controls.Controls.Add(this.label_name, 0, 0);
            this.tlp_controls.Controls.Add(this.button_add_cart, 0, 3);
            this.tlp_controls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_controls.Location = new System.Drawing.Point(178, 3);
            this.tlp_controls.Name = "tlp_controls";
            this.tlp_controls.RowCount = 4;
            this.tlp_controls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_controls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp_controls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlp_controls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlp_controls.Size = new System.Drawing.Size(319, 174);
            this.tlp_controls.TabIndex = 1;
            // 
            // label_price
            // 
            this.label_price.AutoSize = true;
            this.label_price.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_price.ForeColor = System.Drawing.Color.ForestGreen;
            this.label_price.Location = new System.Drawing.Point(3, 77);
            this.label_price.Margin = new System.Windows.Forms.Padding(3);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(313, 44);
            this.label_price.TabIndex = 0;
            this.label_price.Text = "Price";
            this.label_price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_category
            // 
            this.label_category.AutoSize = true;
            this.label_category.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_category.Location = new System.Drawing.Point(3, 47);
            this.label_category.Margin = new System.Windows.Forms.Padding(3);
            this.label_category.Name = "label_category";
            this.label_category.Size = new System.Drawing.Size(313, 24);
            this.label_category.TabIndex = 1;
            this.label_category.Text = "Category";
            this.label_category.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_name.Location = new System.Drawing.Point(3, 3);
            this.label_name.Margin = new System.Windows.Forms.Padding(3);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(313, 38);
            this.label_name.TabIndex = 2;
            this.label_name.Text = "Name";
            this.label_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_add_cart
            // 
            this.button_add_cart.BackColor = System.Drawing.Color.LightYellow;
            this.button_add_cart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_add_cart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add_cart.Image = ((System.Drawing.Image)(resources.GetObject("button_add_cart.Image")));
            this.button_add_cart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_add_cart.Location = new System.Drawing.Point(85, 127);
            this.button_add_cart.Margin = new System.Windows.Forms.Padding(85, 3, 85, 3);
            this.button_add_cart.Name = "button_add_cart";
            this.button_add_cart.Size = new System.Drawing.Size(149, 44);
            this.button_add_cart.TabIndex = 3;
            this.button_add_cart.Text = "Add Shopping Cart";
            this.button_add_cart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_add_cart.UseVisualStyleBackColor = false;
            this.button_add_cart.Click += new System.EventHandler(this.button_add_cart_Click);
            // 
            // UserControlItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tlp_main);
            this.Name = "UserControlItem";
            this.Size = new System.Drawing.Size(500, 180);
            this.tlp_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_image)).EndInit();
            this.tlp_controls.ResumeLayout(false);
            this.tlp_controls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_main;
        private System.Windows.Forms.PictureBox pictureBox_image;
        private System.Windows.Forms.TableLayoutPanel tlp_controls;
        private System.Windows.Forms.Label label_price;
        private System.Windows.Forms.Label label_category;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Button button_add_cart;
    }
}
