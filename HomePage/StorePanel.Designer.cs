namespace HomePage
{
    partial class StorePanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StorePanel));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOMPANYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cLINTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mANAGEUSERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.stockToolStripMenuItem,
            this.cOMPANYToolStripMenuItem,
            this.cLINTToolStripMenuItem,
            this.mANAGEUSERToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1284, 34);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(72, 30);
            this.homeToolStripMenuItem.Text = "HOME";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(140, 30);
            this.logOutToolStripMenuItem.Text = "LogOut";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(140, 30);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(77, 30);
            this.stockToolStripMenuItem.Text = "STOCK";
            this.stockToolStripMenuItem.Click += new System.EventHandler(this.stockToolStripMenuItem_Click);
            // 
            // cOMPANYToolStripMenuItem
            // 
            this.cOMPANYToolStripMenuItem.Name = "cOMPANYToolStripMenuItem";
            this.cOMPANYToolStripMenuItem.Size = new System.Drawing.Size(103, 30);
            this.cOMPANYToolStripMenuItem.Text = "COMPANY";
            this.cOMPANYToolStripMenuItem.Click += new System.EventHandler(this.cOMPANYToolStripMenuItem_Click);
            // 
            // cLINTToolStripMenuItem
            // 
            this.cLINTToolStripMenuItem.Name = "cLINTToolStripMenuItem";
            this.cLINTToolStripMenuItem.Size = new System.Drawing.Size(90, 30);
            this.cLINTToolStripMenuItem.Text = "CLIENTS";
            this.cLINTToolStripMenuItem.Click += new System.EventHandler(this.cLINTToolStripMenuItem_Click);
            // 
            // mANAGEUSERToolStripMenuItem
            // 
            this.mANAGEUSERToolStripMenuItem.Name = "mANAGEUSERToolStripMenuItem";
            this.mANAGEUSERToolStripMenuItem.Size = new System.Drawing.Size(140, 30);
            this.mANAGEUSERToolStripMenuItem.Text = "MANAGE USER";
            this.mANAGEUSERToolStripMenuItem.Click += new System.EventHandler(this.mANAGEUSERToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Demi", 39.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(318, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(675, 66);
            this.label1.TabIndex = 7;
            this.label1.Text = "Medical Store Management";
            // 
            // StorePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(1284, 749);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "StorePanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StorePanel";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cOMPANYToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cLINTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mANAGEUSERToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}