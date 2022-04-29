namespace GTDFFB_20220318_CompStore
{
    partial class UserControlRadioButton
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
            this.tlp_rb = new System.Windows.Forms.TableLayoutPanel();
            this.radioButton_osszes = new System.Windows.Forms.RadioButton();
            this.radioButton_monitor = new System.Windows.Forms.RadioButton();
            this.radioButton_szamitogep = new System.Windows.Forms.RadioButton();
            this.radioButton_tablet = new System.Windows.Forms.RadioButton();
            this.tlp_rb.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp_rb
            // 
            this.tlp_rb.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tlp_rb.ColumnCount = 6;
            this.tlp_rb.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_rb.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tlp_rb.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tlp_rb.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tlp_rb.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tlp_rb.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_rb.Controls.Add(this.radioButton_osszes, 1, 0);
            this.tlp_rb.Controls.Add(this.radioButton_monitor, 2, 0);
            this.tlp_rb.Controls.Add(this.radioButton_szamitogep, 3, 0);
            this.tlp_rb.Controls.Add(this.radioButton_tablet, 4, 0);
            this.tlp_rb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_rb.Location = new System.Drawing.Point(0, 0);
            this.tlp_rb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tlp_rb.Name = "tlp_rb";
            this.tlp_rb.RowCount = 1;
            this.tlp_rb.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_rb.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 152F));
            this.tlp_rb.Size = new System.Drawing.Size(863, 152);
            this.tlp_rb.TabIndex = 0;
            // 
            // radioButton_osszes
            // 
            this.radioButton_osszes.AutoSize = true;
            this.radioButton_osszes.Checked = true;
            this.radioButton_osszes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton_osszes.Location = new System.Drawing.Point(114, 2);
            this.radioButton_osszes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton_osszes.Name = "radioButton_osszes";
            this.radioButton_osszes.Size = new System.Drawing.Size(154, 148);
            this.radioButton_osszes.TabIndex = 0;
            this.radioButton_osszes.TabStop = true;
            this.radioButton_osszes.Text = "Összes";
            this.radioButton_osszes.UseVisualStyleBackColor = true;
            this.radioButton_osszes.CheckedChanged += new System.EventHandler(this.radioButton_osszes_CheckedChanged);
            // 
            // radioButton_monitor
            // 
            this.radioButton_monitor.AutoSize = true;
            this.radioButton_monitor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton_monitor.Location = new System.Drawing.Point(274, 2);
            this.radioButton_monitor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton_monitor.Name = "radioButton_monitor";
            this.radioButton_monitor.Size = new System.Drawing.Size(154, 148);
            this.radioButton_monitor.TabIndex = 1;
            this.radioButton_monitor.Text = "Monitor";
            this.radioButton_monitor.UseVisualStyleBackColor = true;
            this.radioButton_monitor.CheckedChanged += new System.EventHandler(this.radioButton_monitor_CheckedChanged);
            // 
            // radioButton_szamitogep
            // 
            this.radioButton_szamitogep.AutoSize = true;
            this.radioButton_szamitogep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton_szamitogep.Location = new System.Drawing.Point(434, 2);
            this.radioButton_szamitogep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton_szamitogep.Name = "radioButton_szamitogep";
            this.radioButton_szamitogep.Size = new System.Drawing.Size(154, 148);
            this.radioButton_szamitogep.TabIndex = 2;
            this.radioButton_szamitogep.Text = "Számítógép";
            this.radioButton_szamitogep.UseVisualStyleBackColor = true;
            this.radioButton_szamitogep.CheckedChanged += new System.EventHandler(this.radioButton_szamitogep_CheckedChanged);
            // 
            // radioButton_tablet
            // 
            this.radioButton_tablet.AutoSize = true;
            this.radioButton_tablet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton_tablet.Location = new System.Drawing.Point(594, 2);
            this.radioButton_tablet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton_tablet.Name = "radioButton_tablet";
            this.radioButton_tablet.Size = new System.Drawing.Size(154, 148);
            this.radioButton_tablet.TabIndex = 3;
            this.radioButton_tablet.Text = "Tablet";
            this.radioButton_tablet.UseVisualStyleBackColor = true;
            this.radioButton_tablet.CheckedChanged += new System.EventHandler(this.radioButton_tablet_CheckedChanged);
            // 
            // UserControlRadioButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlp_rb);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserControlRadioButton";
            this.Size = new System.Drawing.Size(863, 152);
            this.Resize += new System.EventHandler(this.UserControlRadioButton_Resize);
            this.tlp_rb.ResumeLayout(false);
            this.tlp_rb.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_rb;
        private System.Windows.Forms.RadioButton radioButton_osszes;
        private System.Windows.Forms.RadioButton radioButton_monitor;
        private System.Windows.Forms.RadioButton radioButton_szamitogep;
        private System.Windows.Forms.RadioButton radioButton_tablet;
    }
}
