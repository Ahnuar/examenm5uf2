namespace GITHUB
{
    partial class Frmain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.bt1 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.btMenjar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt1
            // 
            this.bt1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.bt1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt1.Location = new System.Drawing.Point(118, 67);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(75, 23);
            this.bt1.TabIndex = 0;
            this.bt1.Text = "animal";
            this.bt1.UseVisualStyleBackColor = false;
            // 
            // bt2
            // 
            this.bt2.Location = new System.Drawing.Point(328, 67);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(75, 23);
            this.bt2.TabIndex = 1;
            this.bt2.Text = "viatge";
            this.bt2.UseVisualStyleBackColor = true;
            // 
            // btMenjar
            // 
            this.btMenjar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btMenjar.Location = new System.Drawing.Point(140, 168);
            this.btMenjar.Name = "btMenjar";
            this.btMenjar.Size = new System.Drawing.Size(75, 23);
            this.btMenjar.TabIndex = 2;
            this.btMenjar.Text = "menjar";
            this.btMenjar.UseVisualStyleBackColor = false;
            // 
            // Frmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btMenjar);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt1);
            this.Name = "Frmain";
            this.Text = "frmain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button btMenjar;
    }
}

