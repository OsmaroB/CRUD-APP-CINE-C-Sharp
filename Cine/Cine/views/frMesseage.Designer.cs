namespace Cine.views
{
    partial class frMesseage
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
            this.button4 = new System.Windows.Forms.Button();
            this.lbTexto = new System.Windows.Forms.Label();
            this.lbEncabezado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(226)))), ((int)(((byte)(208)))));
            this.button4.Location = new System.Drawing.Point(751, 1);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(48, 51);
            this.button4.TabIndex = 110;
            this.button4.Text = "X";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // lbTexto
            // 
            this.lbTexto.BackColor = System.Drawing.Color.Transparent;
            this.lbTexto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTexto.ForeColor = System.Drawing.Color.White;
            this.lbTexto.Location = new System.Drawing.Point(1, 114);
            this.lbTexto.Name = "lbTexto";
            this.lbTexto.Size = new System.Drawing.Size(798, 52);
            this.lbTexto.TabIndex = 109;
            this.lbTexto.Text = "No podras recuperarlo otra vez";
            this.lbTexto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbEncabezado
            // 
            this.lbEncabezado.BackColor = System.Drawing.Color.Transparent;
            this.lbEncabezado.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEncabezado.ForeColor = System.Drawing.Color.White;
            this.lbEncabezado.Location = new System.Drawing.Point(5, 34);
            this.lbEncabezado.Name = "lbEncabezado";
            this.lbEncabezado.Size = new System.Drawing.Size(794, 32);
            this.lbEncabezado.TabIndex = 108;
            this.lbEncabezado.Text = "¿Seguro quieres eliminar este elemento ?";
            this.lbEncabezado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frMesseage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(800, 252);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.lbTexto);
            this.Controls.Add(this.lbEncabezado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frMesseage";
            this.Text = "frMesseage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lbTexto;
        private System.Windows.Forms.Label lbEncabezado;
    }
}