namespace ManagerTool.View
{
    partial class NewTrigger
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
            this.textBoxTrigger = new System.Windows.Forms.TextBox();
            this.buttonCrearTrigger = new System.Windows.Forms.Button();
            this.listBoxEventos = new System.Windows.Forms.ListBox();
            this.textBoxTabla = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.n = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBoxTrigger
            // 
            this.textBoxTrigger.Location = new System.Drawing.Point(79, 57);
            this.textBoxTrigger.Name = "textBoxTrigger";
            this.textBoxTrigger.Size = new System.Drawing.Size(100, 20);
            this.textBoxTrigger.TabIndex = 0;
            // 
            // buttonCrearTrigger
            // 
            this.buttonCrearTrigger.Location = new System.Drawing.Point(282, 222);
            this.buttonCrearTrigger.Name = "buttonCrearTrigger";
            this.buttonCrearTrigger.Size = new System.Drawing.Size(75, 23);
            this.buttonCrearTrigger.TabIndex = 1;
            this.buttonCrearTrigger.Text = "Crear";
            this.buttonCrearTrigger.UseVisualStyleBackColor = true;
            this.buttonCrearTrigger.Click += new System.EventHandler(this.buttonCrearTrigger_Click);
            // 
            // listBoxEventos
            // 
            this.listBoxEventos.FormattingEnabled = true;
            this.listBoxEventos.Items.AddRange(new object[] {
            "Before",
            "After"});
            this.listBoxEventos.Location = new System.Drawing.Point(79, 105);
            this.listBoxEventos.Name = "listBoxEventos";
            this.listBoxEventos.Size = new System.Drawing.Size(120, 43);
            this.listBoxEventos.TabIndex = 3;
            // 
            // textBoxTabla
            // 
            this.textBoxTabla.Location = new System.Drawing.Point(79, 176);
            this.textBoxTabla.Name = "textBoxTabla";
            this.textBoxTabla.Size = new System.Drawing.Size(100, 20);
            this.textBoxTabla.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre de Triiger";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Evento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tabla";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(265, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Evento";
            // 
            // n
            // 
            this.n.FormattingEnabled = true;
            this.n.Items.AddRange(new object[] {
            "Delete",
            "Update",
            "Create"});
            this.n.Location = new System.Drawing.Point(268, 57);
            this.n.Name = "n";
            this.n.Size = new System.Drawing.Size(120, 95);
            this.n.TabIndex = 8;
            // 
            // NewTrigger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 272);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.n);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTabla);
            this.Controls.Add(this.listBoxEventos);
            this.Controls.Add(this.buttonCrearTrigger);
            this.Controls.Add(this.textBoxTrigger);
            this.Name = "NewTrigger";
            this.Text = "NewTrigger";
            this.Load += new System.EventHandler(this.NewTrigger_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTrigger;
        private System.Windows.Forms.Button buttonCrearTrigger;
        private System.Windows.Forms.ListBox listBoxEventos;
        private System.Windows.Forms.TextBox textBoxTabla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox n;
    }
}