namespace GTDFFB_20220318_CompStore
{
    partial class UserControlComboBox
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
            this.tlp_cb = new System.Windows.Forms.TableLayoutPanel();
            this.comboBox_tipusok = new System.Windows.Forms.ComboBox();
            this.tlp_cb.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp_cb
            // 
            this.tlp_cb.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tlp_cb.ColumnCount = 3;
            this.tlp_cb.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_cb.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 134F));
            this.tlp_cb.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_cb.Controls.Add(this.comboBox_tipusok, 1, 0);
            this.tlp_cb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_cb.Location = new System.Drawing.Point(0, 0);
            this.tlp_cb.Margin = new System.Windows.Forms.Padding(2);
            this.tlp_cb.Name = "tlp_cb";
            this.tlp_cb.RowCount = 1;
            this.tlp_cb.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_cb.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tlp_cb.Size = new System.Drawing.Size(490, 98);
            this.tlp_cb.TabIndex = 0;
            // 
            // comboBox_tipusok
            // 
            this.comboBox_tipusok.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_tipusok.FormattingEnabled = true;
            this.comboBox_tipusok.Location = new System.Drawing.Point(180, 2);
            this.comboBox_tipusok.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_tipusok.Name = "comboBox_tipusok";
            this.comboBox_tipusok.Size = new System.Drawing.Size(130, 21);
            this.comboBox_tipusok.TabIndex = 0;
            this.comboBox_tipusok.SelectedIndexChanged += new System.EventHandler(this.comboBox_tipusok_SelectedIndexChanged);
            // 
            // UserControlComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlp_cb);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserControlComboBox";
            this.Size = new System.Drawing.Size(490, 98);
            this.Resize += new System.EventHandler(this.UserControlComboBox_Resize);
            this.tlp_cb.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_cb;
        private System.Windows.Forms.ComboBox comboBox_tipusok;
    }
}
