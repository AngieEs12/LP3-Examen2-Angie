
namespace LP3_Examen2_Angie
{
    partial class Menucs
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
            this.btnservicio = new System.Windows.Forms.Button();
            this.btnticket = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(314, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu";
            // 
            // btnservicio
            // 
            this.btnservicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnservicio.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnservicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnservicio.Location = new System.Drawing.Point(154, 194);
            this.btnservicio.Name = "btnservicio";
            this.btnservicio.Size = new System.Drawing.Size(169, 76);
            this.btnservicio.TabIndex = 1;
            this.btnservicio.Text = "Servicio";
            this.btnservicio.UseVisualStyleBackColor = false;
            this.btnservicio.Click += new System.EventHandler(this.btnservicio_Click);
            // 
            // btnticket
            // 
            this.btnticket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnticket.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnticket.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnticket.Location = new System.Drawing.Point(412, 194);
            this.btnticket.Name = "btnticket";
            this.btnticket.Size = new System.Drawing.Size(154, 76);
            this.btnticket.TabIndex = 2;
            this.btnticket.Text = "Tickets";
            this.btnticket.UseVisualStyleBackColor = false;
            this.btnticket.Click += new System.EventHandler(this.btnticket_Click);
            // 
            // Menucs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(629, 361);
            this.Controls.Add(this.btnticket);
            this.Controls.Add(this.btnservicio);
            this.Controls.Add(this.label1);
            this.Name = "Menucs";
            this.Text = "Menucs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnservicio;
        private System.Windows.Forms.Button btnticket;
    }
}