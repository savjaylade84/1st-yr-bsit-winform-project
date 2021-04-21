namespace Main
{
    partial class MainPage
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
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salaryInfoEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salaryInfoAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pOSSTAFFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pOSADMINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.payrollToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.payrollSTAFFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.payrollADMINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arrangeIconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeToolStripMenuItem,
            this.pOSToolStripMenuItem,
            this.payrollToolStripMenuItem,
            this.windowToolStripMenuItem,
            this.aboutUsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1381, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salaryInfoEmployeeToolStripMenuItem,
            this.salaryInfoAdminToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.employeeToolStripMenuItem.Text = "Employee";
            // 
            // salaryInfoEmployeeToolStripMenuItem
            // 
            this.salaryInfoEmployeeToolStripMenuItem.Name = "salaryInfoEmployeeToolStripMenuItem";
            this.salaryInfoEmployeeToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.salaryInfoEmployeeToolStripMenuItem.Text = "Information (Employee)";
            this.salaryInfoEmployeeToolStripMenuItem.Click += new System.EventHandler(this.salaryInfoEmployeeToolStripMenuItem_Click);
            // 
            // salaryInfoAdminToolStripMenuItem
            // 
            this.salaryInfoAdminToolStripMenuItem.Name = "salaryInfoAdminToolStripMenuItem";
            this.salaryInfoAdminToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.salaryInfoAdminToolStripMenuItem.Text = "Information (Admin)";
            this.salaryInfoAdminToolStripMenuItem.Click += new System.EventHandler(this.salaryInfoAdminToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // pOSToolStripMenuItem
            // 
            this.pOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pOSSTAFFToolStripMenuItem,
            this.pOSADMINToolStripMenuItem});
            this.pOSToolStripMenuItem.Name = "pOSToolStripMenuItem";
            this.pOSToolStripMenuItem.Size = new System.Drawing.Size(48, 24);
            this.pOSToolStripMenuItem.Text = "POS";
            // 
            // pOSSTAFFToolStripMenuItem
            // 
            this.pOSSTAFFToolStripMenuItem.Name = "pOSSTAFFToolStripMenuItem";
            this.pOSSTAFFToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.pOSSTAFFToolStripMenuItem.Text = "POS (STAFF)";
            this.pOSSTAFFToolStripMenuItem.Click += new System.EventHandler(this.pOSSTAFFToolStripMenuItem_Click);
            // 
            // pOSADMINToolStripMenuItem
            // 
            this.pOSADMINToolStripMenuItem.Name = "pOSADMINToolStripMenuItem";
            this.pOSADMINToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.pOSADMINToolStripMenuItem.Text = "POS (ADMIN)";
            this.pOSADMINToolStripMenuItem.Click += new System.EventHandler(this.pOSADMINToolStripMenuItem_Click);
            // 
            // payrollToolStripMenuItem
            // 
            this.payrollToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.payrollSTAFFToolStripMenuItem,
            this.payrollADMINToolStripMenuItem});
            this.payrollToolStripMenuItem.Name = "payrollToolStripMenuItem";
            this.payrollToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.payrollToolStripMenuItem.Text = "Payroll";
            // 
            // payrollSTAFFToolStripMenuItem
            // 
            this.payrollSTAFFToolStripMenuItem.Name = "payrollSTAFFToolStripMenuItem";
            this.payrollSTAFFToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.payrollSTAFFToolStripMenuItem.Text = "Payroll(STAFF)";
            this.payrollSTAFFToolStripMenuItem.Click += new System.EventHandler(this.payrollSTAFFToolStripMenuItem_Click);
            // 
            // payrollADMINToolStripMenuItem
            // 
            this.payrollADMINToolStripMenuItem.Name = "payrollADMINToolStripMenuItem";
            this.payrollADMINToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.payrollADMINToolStripMenuItem.Text = "Payroll(ADMIN)";
            this.payrollADMINToolStripMenuItem.Click += new System.EventHandler(this.payrollADMINToolStripMenuItem_Click);
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arrangeIconsToolStripMenuItem,
            this.cascadeToolStripMenuItem,
            this.tileHorizontalToolStripMenuItem,
            this.tileVerticalToolStripMenuItem});
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.windowToolStripMenuItem.Text = "Window";
            // 
            // arrangeIconsToolStripMenuItem
            // 
            this.arrangeIconsToolStripMenuItem.Name = "arrangeIconsToolStripMenuItem";
            this.arrangeIconsToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.arrangeIconsToolStripMenuItem.Text = "ArrangeIcons";
            this.arrangeIconsToolStripMenuItem.Click += new System.EventHandler(this.arrangeIconsToolStripMenuItem_Click);
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.cascadeToolStripMenuItem.Text = "Cascade";
            this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.cascadeToolStripMenuItem_Click);
            // 
            // tileHorizontalToolStripMenuItem
            // 
            this.tileHorizontalToolStripMenuItem.Name = "tileHorizontalToolStripMenuItem";
            this.tileHorizontalToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.tileHorizontalToolStripMenuItem.Text = "TileHorizontal";
            this.tileHorizontalToolStripMenuItem.Click += new System.EventHandler(this.tileHorizontalToolStripMenuItem_Click);
            // 
            // tileVerticalToolStripMenuItem
            // 
            this.tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
            this.tileVerticalToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.tileVerticalToolStripMenuItem.Text = "  TileVertical";
            this.tileVerticalToolStripMenuItem.Click += new System.EventHandler(this.tileVerticalToolStripMenuItem_Click);
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.aboutUsToolStripMenuItem.Text = "About Us ";
            this.aboutUsToolStripMenuItem.Click += new System.EventHandler(this.aboutUsToolStripMenuItem_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1381, 749);
            this.Controls.Add(this.menuStrip1);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainPage";
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salaryInfoEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salaryInfoAdminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pOSSTAFFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pOSADMINToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem payrollToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem payrollSTAFFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem payrollADMINToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arrangeIconsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
    }
}

