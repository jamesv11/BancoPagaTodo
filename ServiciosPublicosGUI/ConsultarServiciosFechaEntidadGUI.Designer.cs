namespace ServiciosPublicosGUI
{
    partial class ConsultarServiciosFechaEntidadGUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.TablaDgv = new System.Windows.Forms.DataGridView();
            this.BuscarBtn = new System.Windows.Forms.Button();
            this.ExportarBtn = new System.Windows.Forms.Button();
            this.Cuantos = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CuantosTxt = new System.Windows.Forms.TextBox();
            this.ValorTotalTxt = new System.Windows.Forms.TextBox();
            this.EntidadCmb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.FechaDtp = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.TablaDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Entidad";
            // 
            // TablaDgv
            // 
            this.TablaDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaDgv.Location = new System.Drawing.Point(97, 78);
            this.TablaDgv.Name = "TablaDgv";
            this.TablaDgv.Size = new System.Drawing.Size(543, 158);
            this.TablaDgv.TabIndex = 2;
            // 
            // BuscarBtn
            // 
            this.BuscarBtn.Location = new System.Drawing.Point(505, 32);
            this.BuscarBtn.Name = "BuscarBtn";
            this.BuscarBtn.Size = new System.Drawing.Size(75, 23);
            this.BuscarBtn.TabIndex = 3;
            this.BuscarBtn.Text = "Buscar";
            this.BuscarBtn.UseVisualStyleBackColor = true;
            this.BuscarBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // ExportarBtn
            // 
            this.ExportarBtn.Location = new System.Drawing.Point(300, 310);
            this.ExportarBtn.Name = "ExportarBtn";
            this.ExportarBtn.Size = new System.Drawing.Size(75, 23);
            this.ExportarBtn.TabIndex = 4;
            this.ExportarBtn.Text = "Exportar";
            this.ExportarBtn.UseVisualStyleBackColor = true;
            this.ExportarBtn.Click += new System.EventHandler(this.ExportarBtn_Click);
            // 
            // Cuantos
            // 
            this.Cuantos.AutoSize = true;
            this.Cuantos.Location = new System.Drawing.Point(210, 246);
            this.Cuantos.Name = "Cuantos";
            this.Cuantos.Size = new System.Drawing.Size(46, 13);
            this.Cuantos.TabIndex = 5;
            this.Cuantos.Text = "Cuantos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "ValorTotal";
            // 
            // CuantosTxt
            // 
            this.CuantosTxt.Enabled = false;
            this.CuantosTxt.Location = new System.Drawing.Point(294, 243);
            this.CuantosTxt.Name = "CuantosTxt";
            this.CuantosTxt.Size = new System.Drawing.Size(100, 20);
            this.CuantosTxt.TabIndex = 7;
            // 
            // ValorTotalTxt
            // 
            this.ValorTotalTxt.Enabled = false;
            this.ValorTotalTxt.Location = new System.Drawing.Point(294, 270);
            this.ValorTotalTxt.Name = "ValorTotalTxt";
            this.ValorTotalTxt.Size = new System.Drawing.Size(100, 20);
            this.ValorTotalTxt.TabIndex = 8;
            // 
            // EntidadCmb
            // 
            this.EntidadCmb.FormattingEnabled = true;
            this.EntidadCmb.Items.AddRange(new object[] {
            "Emdupar",
            "GasCaribe",
            "Electricaribe"});
            this.EntidadCmb.Location = new System.Drawing.Point(188, 34);
            this.EntidadCmb.Name = "EntidadCmb";
            this.EntidadCmb.Size = new System.Drawing.Size(121, 21);
            this.EntidadCmb.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(338, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Fecha";
            // 
            // FechaDtp
            // 
            this.FechaDtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaDtp.Location = new System.Drawing.Point(381, 35);
            this.FechaDtp.Name = "FechaDtp";
            this.FechaDtp.Size = new System.Drawing.Size(93, 20);
            this.FechaDtp.TabIndex = 11;
            // 
            // ConsultarServiciosFechaEntidadGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 345);
            this.Controls.Add(this.FechaDtp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EntidadCmb);
            this.Controls.Add(this.ValorTotalTxt);
            this.Controls.Add(this.CuantosTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Cuantos);
            this.Controls.Add(this.ExportarBtn);
            this.Controls.Add(this.BuscarBtn);
            this.Controls.Add(this.TablaDgv);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ConsultarServiciosFechaEntidadGUI";
            this.Text = "ConsultarServiciosFechaEntidadGUI";
            ((System.ComponentModel.ISupportInitialize)(this.TablaDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView TablaDgv;
        private System.Windows.Forms.Button BuscarBtn;
        private System.Windows.Forms.Button ExportarBtn;
        private System.Windows.Forms.Label Cuantos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CuantosTxt;
        private System.Windows.Forms.TextBox ValorTotalTxt;
        private System.Windows.Forms.ComboBox EntidadCmb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker FechaDtp;
    }
}