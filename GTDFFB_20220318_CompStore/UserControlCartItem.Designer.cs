namespace GTDFFB_20220318_CompStore
{
    partial class UserControlCartItem
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
            this.tlp_main = new System.Windows.Forms.TableLayoutPanel();
            this.label_price = new System.Windows.Forms.Label();
            this.tlp_controls = new System.Windows.Forms.TableLayoutPanel();
            this.label_category = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.button_remove = new System.Windows.Forms.Button();
            this.pictureBox_image = new System.Windows.Forms.PictureBox();
            this.tlp_main.SuspendLayout();
            this.tlp_controls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_image)).BeginInit();
            this.SuspendLayout();
            // 
            // tlp_main
            // 
            this.tlp_main.ColumnCount = 4;
            this.tlp_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tlp_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.tlp_main.Controls.Add(this.label_price, 2, 0);
            this.tlp_main.Controls.Add(this.pictureBox_image, 0, 0);
            this.tlp_main.Controls.Add(this.tlp_controls, 1, 0);
            this.tlp_main.Controls.Add(this.button_remove, 3, 0);
            this.tlp_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_main.Location = new System.Drawing.Point(0, 0);
            this.tlp_main.Name = "tlp_main";
            this.tlp_main.RowCount = 1;
            this.tlp_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_main.Size = new System.Drawing.Size(598, 98);
            this.tlp_main.TabIndex = 1;
            // 
            // label_price
            // 
            this.label_price.AutoSize = true;
            this.label_price.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_price.ForeColor = System.Drawing.Color.ForestGreen;
            this.label_price.Location = new System.Drawing.Point(374, 3);
            this.label_price.Margin = new System.Windows.Forms.Padding(3);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(118, 92);
            this.label_price.TabIndex = 2;
            this.label_price.Text = "Price";
            this.label_price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlp_controls
            // 
            this.tlp_controls.ColumnCount = 1;
            this.tlp_controls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_controls.Controls.Add(this.label_category, 0, 1);
            this.tlp_controls.Controls.Add(this.label_name, 0, 0);
            this.tlp_controls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_controls.Location = new System.Drawing.Point(102, 3);
            this.tlp_controls.Name = "tlp_controls";
            this.tlp_controls.RowCount = 2;
            this.tlp_controls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_controls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp_controls.Size = new System.Drawing.Size(266, 92);
            this.tlp_controls.TabIndex = 1;
            // 
            // label_category
            // 
            this.label_category.AutoSize = true;
            this.label_category.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_category.Location = new System.Drawing.Point(3, 65);
            this.label_category.Margin = new System.Windows.Forms.Padding(3);
            this.label_category.Name = "label_category";
            this.label_category.Size = new System.Drawing.Size(260, 24);
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
            this.label_name.Size = new System.Drawing.Size(260, 56);
            this.label_name.TabIndex = 2;
            this.label_name.Text = "Name";
            this.label_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_remove
            // 
            this.button_remove.BackgroundImage = global::GTDFFB_20220318_CompStore.Properties.Resources.remove;
            this.button_remove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_remove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_remove.Location = new System.Drawing.Point(520, 25);
            this.button_remove.Margin = new System.Windows.Forms.Padding(25);
            this.button_remove.Name = "button_remove";
            this.button_remove.Size = new System.Drawing.Size(53, 48);
            this.button_remove.TabIndex = 3;
            this.button_remove.UseVisualStyleBackColor = true;
            this.button_remove.Click += new System.EventHandler(this.button_remove_Click);
            // 
            // pictureBox_image
            // 
            this.pictureBox_image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox_image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_image.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_image.Location = new System.Drawing.Point(3, 3);
            this.pictureBox_image.Name = "pictureBox_image";
            this.pictureBox_image.Size = new System.Drawing.Size(93, 92);
            this.pictureBox_image.TabIndex = 0;
            this.pictureBox_image.TabStop = false;
            // 
            // UserControlCartItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tlp_main);
            this.Name = "UserControlCartItem";
            this.Size = new System.Drawing.Size(598, 98);
            this.tlp_main.ResumeLayout(false);
            this.tlp_main.PerformLayout();
            this.tlp_controls.ResumeLayout(false);
            this.tlp_controls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_main;
        private System.Windows.Forms.PictureBox pictureBox_image;
        private System.Windows.Forms.TableLayoutPanel tlp_controls;
        private System.Windows.Forms.Label label_category;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_price;
        private System.Windows.Forms.Button button_remove;
    }
}
