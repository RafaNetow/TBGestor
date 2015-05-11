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
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Table1");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Table", new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aSasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trigerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procedureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.ButtomUserImage = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aSasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(809, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "Option";
            // 
            // aSasToolStripMenuItem
            // 
            this.aSasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.aSasToolStripMenuItem.Name = "aSasToolStripMenuItem";
            this.aSasToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.aSasToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tableToolStripMenuItem,
            this.trigerToolStripMenuItem,
            this.procedureToolStripMenuItem});
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // procedureToolStripMenuItem
            // 
            this.procedureToolStripMenuItem.Name = "procedureToolStripMenuItem";
            this.procedureToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.procedureToolStripMenuItem.Text = "Procedure";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(142, 129);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(485, 233);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // ButtomUserImage
            // 
            this.ButtomUserImage.Location = new System.Drawing.Point(0, 62);
            this.ButtomUserImage.Name = "ButtomUserImage";
            this.ButtomUserImage.Size = new System.Drawing.Size(82, 61);
            this.ButtomUserImage.TabIndex = 3;
            this.ButtomUserImage.Text = "UserImage";
            this.ButtomUserImage.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(0, 129);
            this.treeView1.Name = "treeView1";
            treeNode3.Name = "NodeTableUser";
            treeNode3.Text = "Table1";
            treeNode4.Name = "nodeTable";
            treeNode4.Text = "Table";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4});
            this.treeView1.Size = new System.Drawing.Size(121, 183);
            this.treeView1.TabIndex = 7;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // ManagerTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 484);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.ButtomUserImage);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ManagerTool";
            this.Text = "ManagerTool";
            this.Load += new System.EventHandler(this.ManagerTool_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aSasToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trigerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procedureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button ButtomUserImage;
        private System.Windows.Forms.TreeView treeView1;
    }
}