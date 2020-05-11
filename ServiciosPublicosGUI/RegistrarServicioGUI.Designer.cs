namespace ServiciosPublicosGUI
{
    partial class RegistrarServicioGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarServicioGUI));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NumeroReciboTxt = new System.Windows.Forms.TextBox();
            this.ValorPagadotxt = new System.Windows.Forms.TextBox();
            this.FechaDtp = new System.Windows.Forms.DateTimePicker();
            this.RegistrarBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Entidad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "N° Recibo :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor Pagado:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(115, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha";
            // 
            // NumeroReciboTxt
            // 
            this.NumeroReciboTxt.Location = new System.Drawing.Point(176, 123);
            this.NumeroReciboTxt.Name = "NumeroReciboTxt";
            this.NumeroReciboTxt.Size = new System.Drawing.Size(100, 20);
            this.NumeroReciboTxt.TabIndex = 6;
            // 
            // ValorPagadotxt
            // 
            this.ValorPagadotxt.Location = new System.Drawing.Point(176, 187);
            this.ValorPagadotxt.Name = "ValorPagadotxt";
            this.ValorPagadotxt.Size = new System.Drawing.Size(100, 20);
            this.ValorPagadotxt.TabIndex = 7;
            // 
            // FechaDtp
            // 
            this.FechaDtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaDtp.Location = new System.Drawing.Point(176, 155);
            this.FechaDtp.Name = "FechaDtp";
            this.FechaDtp.Size = new System.Drawing.Size(100, 20);
            this.FechaDtp.TabIndex = 8;
            // 
            // RegistrarBtn
            // 
            this.RegistrarBtn.Location = new System.Drawing.Point(192, 267);
            this.RegistrarBtn.Name = "RegistrarBtn";
            this.RegistrarBtn.Size = new System.Drawing.Size(75, 23);
            this.RegistrarBtn.TabIndex = 9;
            this.RegistrarBtn.Text = "Registrar";
            this.RegistrarBtn.UseVisualStyleBackColor = true;
            this.RegistrarBtn.Click += new System.EventHandler(this.RegistrarBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(451, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 139);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Emdupar",
            "GasCaribe",
            "Electricaribe"});
            this.comboBox1.Location = new System.Drawing.Point(176, 91);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 11;
            // 
            // RegistrarServicioGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 345);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.RegistrarBtn);
            this.Controls.Add(this.FechaDtp);
            this.Controls.Add(this.ValorPagadotxt);
            this.Controls.Add(this.NumeroReciboTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RegistrarServicioGUI";
            this.Text = "RegistrarServicioGUI";
            this.Load += new System.EventHandler(this.RegistrarServicioGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NumeroReciboTxt;
        private System.Windows.Forms.TextBox ValorPagadotxt;
        private System.Windows.Forms.DateTimePicker FechaDtp;
        private System.Windows.Forms.Button RegistrarBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}