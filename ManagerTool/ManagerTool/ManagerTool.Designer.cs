namespace ManagerTool
{
    partial class ManagerTool
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aSasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asasToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.aSasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.asasToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trigerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aSasToolStripMenuItem,
            this.aSasToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(792, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "Option";
            // 
            // aSasToolStripMenuItem
            // 
            this.aSasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asasToolStripMenuItem2,
            this.newToolStripMenuItem});
            this.aSasToolStripMenuItem.Name = "aSasToolStripMenuItem";
            this.aSasToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.aSasToolStripMenuItem.Text = "File";
            // 
            // asasToolStripMenuItem2
            // 
            this.asasToolStripMenuItem2.Name = "asasToolStripMenuItem2";
            this.asasToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.asasToolStripMenuItem2.Text = "asas";
            // 
            // aSasToolStripMenuItem1
            // 
            this.aSasToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asasToolStripMenuItem3});
            this.aSasToolStripMenuItem1.Name = "aSasToolStripMenuItem1";
            this.aSasToolStripMenuItem1.Size = new System.Drawing.Size(44, 20);
            this.aSasToolStripMenuItem1.Text = "ASas";
            // 
            // asasToolStripMenuItem3
            // 
            this.asasToolStripMenuItem3.Name = "asasToolStripMenuItem3";
            this.asasToolStripMenuItem3.Size = new System.Drawing.Size(96, 22);
            this.asasToolStripMenuItem3.Text = "asas";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tableToolStripMenuItem,
            this.trigerToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // tableToolStripMenuItem
            // 
            this.tableToolStripMenuItem.Name = "tableToolStripMenuItem";
            this.tableToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tableToolStripMenuItem.Text = "Table";
            // 
            // trigerToolStripMenuItem
            // 
            this.trigerToolStripMenuItem.Name = "trigerToolStripMenuItem";
            this.trigerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.trigerToolStripMenuItem.Text = "Triger";
            // 
            // ManagerTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 403);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ManagerTool";
            this.Text = "ManagerTool";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aSasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aSasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem asasToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem asasToolStripMenuItem3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trigerToolStripMenuItem;
    }
}