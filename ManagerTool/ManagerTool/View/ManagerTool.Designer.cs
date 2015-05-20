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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Table1");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Table", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aSasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trigerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procedureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paquetesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procedimientosAlmacenadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.secuenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tablesspaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.richTextBoxSQL = new System.Windows.Forms.RichTextBox();
            this.ButtomUserImage = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.buttonGo = new System.Windows.Forms.Button();
            this.ButtonClean = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonExit = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.procedureToolStripMenuItem,
            this.paquetesToolStripMenuItem,
            this.procedimientosAlmacenadosToolStripMenuItem,
            this.secuenciaToolStripMenuItem,
            this.indiceToolStripMenuItem,
            this.tablesspaceToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // tableToolStripMenuItem
            // 
            this.tableToolStripMenuItem.Name = "tableToolStripMenuItem";
            this.tableToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.tableToolStripMenuItem.Text = "Table";
            // 
            // trigerToolStripMenuItem
            // 
            this.trigerToolStripMenuItem.Name = "trigerToolStripMenuItem";
            this.trigerToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.trigerToolStripMenuItem.Text = "Triger";
            // 
            // procedureToolStripMenuItem
            // 
            this.procedureToolStripMenuItem.Name = "procedureToolStripMenuItem";
            this.procedureToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.procedureToolStripMenuItem.Text = "Procedure";
            // 
            // paquetesToolStripMenuItem
            // 
            this.paquetesToolStripMenuItem.Name = "paquetesToolStripMenuItem";
            this.paquetesToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.paquetesToolStripMenuItem.Text = "Paquetes";
            // 
            // procedimientosAlmacenadosToolStripMenuItem
            // 
            this.procedimientosAlmacenadosToolStripMenuItem.Name = "procedimientosAlmacenadosToolStripMenuItem";
            this.procedimientosAlmacenadosToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.procedimientosAlmacenadosToolStripMenuItem.Text = "Procedimientos Almacenados";
            // 
            // secuenciaToolStripMenuItem
            // 
            this.secuenciaToolStripMenuItem.Name = "secuenciaToolStripMenuItem";
            this.secuenciaToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.secuenciaToolStripMenuItem.Text = "Secuencia";
            // 
            // indiceToolStripMenuItem
            // 
            this.indiceToolStripMenuItem.Name = "indiceToolStripMenuItem";
            this.indiceToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.indiceToolStripMenuItem.Text = "Indice";
            // 
            // tablesspaceToolStripMenuItem
            // 
            this.tablesspaceToolStripMenuItem.Name = "tablesspaceToolStripMenuItem";
            this.tablesspaceToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.tablesspaceToolStripMenuItem.Text = "Tablesspace";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // richTextBoxSQL
            // 
            this.richTextBoxSQL.Location = new System.Drawing.Point(139, 84);
            this.richTextBoxSQL.Name = "richTextBoxSQL";
            this.richTextBoxSQL.Size = new System.Drawing.Size(485, 183);
            this.richTextBoxSQL.TabIndex = 2;
            this.richTextBoxSQL.Text = "";
            // 
            // ButtomUserImage
            // 
            this.ButtomUserImage.Location = new System.Drawing.Point(673, 291);
            this.ButtomUserImage.Name = "ButtomUserImage";
            this.ButtomUserImage.Size = new System.Drawing.Size(82, 61);
            this.ButtomUserImage.TabIndex = 3;
            this.ButtomUserImage.Text = "UserImage";
            this.ButtomUserImage.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 84);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "NodeTableUser";
            treeNode1.Text = "Table1";
            treeNode2.Name = "nodeTable";
            treeNode2.Text = "Table";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.treeView1.Size = new System.Drawing.Size(121, 183);
            this.treeView1.TabIndex = 7;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // buttonGo
            // 
            this.buttonGo.Location = new System.Drawing.Point(645, 129);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(75, 35);
            this.buttonGo.TabIndex = 8;
            this.buttonGo.Text = "Go";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // ButtonClean
            // 
            this.ButtonClean.Location = new System.Drawing.Point(645, 193);
            this.ButtonClean.Name = "ButtonClean";
            this.ButtonClean.Size = new System.Drawing.Size(75, 35);
            this.ButtonClean.TabIndex = 9;
            this.ButtonClean.Text = "Clean";
            this.ButtonClean.UseVisualStyleBackColor = true;
            this.ButtonClean.Click += new System.EventHandler(this.ButtonClean_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(139, 275);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(485, 197);
            this.dataGridView1.TabIndex = 10;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(645, 234);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 11;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // ManagerTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 484);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ButtonClean);
            this.Controls.Add(this.buttonGo);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.ButtomUserImage);
            this.Controls.Add(this.richTextBoxSQL);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ManagerTool";
            this.Text = "ManagerTool";
            this.Load += new System.EventHandler(this.ManagerTool_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.RichTextBox richTextBoxSQL;
        private System.Windows.Forms.Button ButtomUserImage;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.Button ButtonClean;
        private System.Windows.Forms.ToolStripMenuItem paquetesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procedimientosAlmacenadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem secuenciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tablesspaceToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonExit;
    }
}