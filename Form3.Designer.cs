namespace WindowsFormsApp2
{
    partial class Form3
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.фильмыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сеансыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.билетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.фильмыToolStripMenuItem,
            this.билетыToolStripMenuItem,
            this.сеансыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(11, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(847, 35);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // фильмыToolStripMenuItem
            // 
            this.фильмыToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.фильмыToolStripMenuItem.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.фильмыToolStripMenuItem.Name = "фильмыToolStripMenuItem";
            this.фильмыToolStripMenuItem.Size = new System.Drawing.Size(94, 27);
            this.фильмыToolStripMenuItem.Text = "Фильмы";
            // 
            // сеансыToolStripMenuItem
            // 
            this.сеансыToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.сеансыToolStripMenuItem.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.сеансыToolStripMenuItem.Name = "сеансыToolStripMenuItem";
            this.сеансыToolStripMenuItem.Size = new System.Drawing.Size(87, 27);
            this.сеансыToolStripMenuItem.Text = "Сеансы";
            // 
            // билетыToolStripMenuItem
            // 
            this.билетыToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.билетыToolStripMenuItem.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.билетыToolStripMenuItem.Name = "билетыToolStripMenuItem";
            this.билетыToolStripMenuItem.Size = new System.Drawing.Size(88, 27);
            this.билетыToolStripMenuItem.Text = "Билеты";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(847, 793);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Личный кабинет";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem фильмыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem билетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сеансыToolStripMenuItem;
    }
}