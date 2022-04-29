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
            this.tlp_main.SuspendLayout();
            this.tlp_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp_main
            // 
            this.tlp_main.ColumnCount = 1;
            this.tlp_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_main.Controls.Add(this.tlp_menu, 0, 1);
            this.tlp_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_main.Location = new System.Drawing.Point(0, 0);
            this.tlp_main.Name = "tlp_main";
            this.tlp_main.RowCount = 3;
            this.tlp_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tlp_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tlp_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_main.Size = new System.Drawing.Size(800, 450);
            this.tlp_main.TabIndex = 0;
            // 
            // tlp_menu
            // 
            this.tlp_menu.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tlp_menu.ColumnCount = 3;
            this.tlp_menu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tlp_menu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_menu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tlp_menu.Controls.Add(this.panel_menu, 1, 0);
            this.tlp_menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_menu.Location = new System.Drawing.Point(3, 123);
            this.tlp_menu.Name = "tlp_menu";
            this.tlp_menu.RowCount = 1;
            this.tlp_menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_menu.Size = new System.Drawing.Size(794, 42);
            this.tlp_menu.TabIndex = 0;
            // 
            // panel_menu
            // 
            this.panel_menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_menu.Location = new System.Drawing.Point(45, 3);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(704, 36);
            this.panel_menu.TabIndex = 0;
            // 
            // FormControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tlp_main);
            this.Name = "FormControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Computer Store";
            this.Load += new System.EventHandler(this.FormControl_Load);
            this.Resize += new System.EventHandler(this.FormControl_Resize);
            this.tlp_main.ResumeLayout(false);
            this.tlp_menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_main;
        private System.Windows.Forms.TableLayoutPanel tlp_menu;
        private System.Windows.Forms.Panel panel_menu;
    }
}

