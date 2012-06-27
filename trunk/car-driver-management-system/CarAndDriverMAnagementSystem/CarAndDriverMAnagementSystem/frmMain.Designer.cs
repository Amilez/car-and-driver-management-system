namespace CarAndDriverMAnagementSystem
{
    partial class frmMain
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
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.managerCarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managerDriverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.menuToolStripMenuItem1,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(603, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Image = global::CarAndDriverMAnagementSystem.Properties.Resources.promotion;
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.menuToolStripMenuItem.Text = "System";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Image = global::CarAndDriverMAnagementSystem.Properties.Resources._lock;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::CarAndDriverMAnagementSystem.Properties.Resources.Back;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // menuToolStripMenuItem1
            // 
            this.menuToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.managerCarToolStripMenuItem,
            this.managerDriverToolStripMenuItem});
            this.menuToolStripMenuItem1.Image = global::CarAndDriverMAnagementSystem.Properties.Resources.heart;
            this.menuToolStripMenuItem1.Name = "menuToolStripMenuItem1";
            this.menuToolStripMenuItem1.Size = new System.Drawing.Size(66, 20);
            this.menuToolStripMenuItem1.Text = "Menu";
            // 
            // managerCarToolStripMenuItem
            // 
            this.managerCarToolStripMenuItem.Image = global::CarAndDriverMAnagementSystem.Properties.Resources.Car;
            this.managerCarToolStripMenuItem.Name = "managerCarToolStripMenuItem";
            this.managerCarToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.managerCarToolStripMenuItem.Text = "Manager Car";
            this.managerCarToolStripMenuItem.Click += new System.EventHandler(this.managerCarToolStripMenuItem_Click);
            // 
            // managerDriverToolStripMenuItem
            // 
            this.managerDriverToolStripMenuItem.Image = global::CarAndDriverMAnagementSystem.Properties.Resources.users;
            this.managerDriverToolStripMenuItem.Name = "managerDriverToolStripMenuItem";
            this.managerDriverToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.managerDriverToolStripMenuItem.Text = "Manager Driver";
            this.managerDriverToolStripMenuItem.Click += new System.EventHandler(this.managerDriverToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.backUpToolStripMenuItem});
            this.helpToolStripMenuItem.Image = global::CarAndDriverMAnagementSystem.Properties.Resources.rss;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::CarAndDriverMAnagementSystem.Properties.Resources.About;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // backUpToolStripMenuItem
            // 
            this.backUpToolStripMenuItem.Image = global::CarAndDriverMAnagementSystem.Properties.Resources.Database;
            this.backUpToolStripMenuItem.Name = "backUpToolStripMenuItem";
            this.backUpToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.backUpToolStripMenuItem.Text = "BackUp";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::CarAndDriverMAnagementSystem.Properties.Resources.c1273_scalextric_start_disney_pixar_cars_24;
            this.ClientSize = new System.Drawing.Size(603, 401);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Black;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Main";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem managerCarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managerDriverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backUpToolStripMenuItem;
    }
}

