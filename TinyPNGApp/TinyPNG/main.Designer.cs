namespace TinyPNG
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.image = new System.Windows.Forms.PictureBox();
            this.label = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.apiKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apiKeyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // image
            // 
            this.image.BackColor = System.Drawing.Color.Transparent;
            this.image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.image.Image = global::TinyPNG.Properties.Resources.panda;
            this.image.Location = new System.Drawing.Point(156, 12);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(88, 92);
            this.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.image.TabIndex = 0;
            this.image.TabStop = false;
            this.image.Visible = false;
            // 
            // label
            // 
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(12, 126);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(367, 23);
            this.label.TabIndex = 1;
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.apiKeyToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(391, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // apiKeyToolStripMenuItem
            // 
            this.apiKeyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.apiKeyToolStripMenuItem1});
            this.apiKeyToolStripMenuItem.Name = "apiKeyToolStripMenuItem";
            this.apiKeyToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.apiKeyToolStripMenuItem.Text = "Settings";
            // 
            // apiKeyToolStripMenuItem1
            // 
            this.apiKeyToolStripMenuItem1.Name = "apiKeyToolStripMenuItem1";
            this.apiKeyToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.apiKeyToolStripMenuItem1.Text = "Api Key";
            this.apiKeyToolStripMenuItem1.Click += new System.EventHandler(this.apiKeyToolStripMenuItem1_Click);
            // 
            // Main
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TinyPNG.Properties.Resources.drag;
            this.ClientSize = new System.Drawing.Size(391, 173);
            this.Controls.Add(this.label);
            this.Controls.Add(this.image);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Text = "Tiny PNG";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Main_Load);
            this.Click += new System.EventHandler(this.Main_Click);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Main_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Main_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox image;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem apiKeyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apiKeyToolStripMenuItem1;
    }
}

