
namespace LP3_Examen2_Angie
{
    partial class Servicio
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
            this.label2 = new System.Windows.Forms.Label();
            this.cbbservicio = new System.Windows.Forms.ComboBox();
            this.btngenerar = new System.Windows.Forms.Button();
            this.lbldispositivo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbdispositivo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(310, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Servicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(126, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo de servicio";
            // 
            // cbbservicio
            // 
            this.cbbservicio.FormattingEnabled = true;
            this.cbbservicio.Items.AddRange(new object[] {
            "Reparacion",
            "Mantenimiento"});
            this.cbbservicio.Location = new System.Drawing.Point(370, 173);
            this.cbbservicio.Name = "cbbservicio";
            this.cbbservicio.Size = new System.Drawing.Size(186, 21);
            this.cbbservicio.TabIndex = 2;
            // 
            // btngenerar
            // 
            this.btngenerar.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngenerar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btngenerar.Location = new System.Drawing.Point(246, 297);
            this.btngenerar.Name = "btngenerar";
            this.btngenerar.Size = new System.Drawing.Size(213, 90);
            this.btngenerar.TabIndex = 3;
            this.btngenerar.Text = "Generar Ticket";
            this.btngenerar.UseVisualStyleBackColor = true;
            // 
            // lbldispositivo
            // 
            this.lbldispositivo.AutoSize = true;
            this.lbldispositivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lbldispositivo.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldispositivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbldispositivo.Location = new System.Drawing.Point(170, 224);
            this.lbldispositivo.Name = "lbldispositivo";
            this.lbldispositivo.Size = new System.Drawing.Size(130, 28);
            this.lbldispositivo.TabIndex = 4;
            this.lbldispositivo.Text = "Dispositivo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label4.Location = new System.Drawing.Point(383, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 28);
            this.label4.TabIndex = 5;
            // 
            // txtbdispositivo
            // 
            this.txtbdispositivo.Location = new System.Drawing.Point(370, 232);
            this.txtbdispositivo.Name = "txtbdispositivo";
            this.txtbdispositivo.Size = new System.Drawing.Size(186, 20);
            this.txtbdispositivo.TabIndex = 6;
            // 
            // Servicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtbdispositivo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbldispositivo);
            this.Controls.Add(this.btngenerar);
            this.Controls.Add(this.cbbservicio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Servicio";
            this.Text = "Servicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbservicio;
        private System.Windows.Forms.Button btngenerar;
        private System.Windows.Forms.Label lbldispositivo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbdispositivo;
    }
}