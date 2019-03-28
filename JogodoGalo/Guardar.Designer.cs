namespace JogodoGalo
{
    partial class Guardar
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
            this.bsave = new System.Windows.Forms.Button();
            this.bcancel = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bsave
            // 
            this.bsave.Location = new System.Drawing.Point(115, 140);
            this.bsave.Name = "bsave";
            this.bsave.Size = new System.Drawing.Size(75, 23);
            this.bsave.TabIndex = 0;
            this.bsave.Text = "Guardar";
            this.bsave.UseVisualStyleBackColor = true;
            this.bsave.Click += new System.EventHandler(this.bsave_Click);
            // 
            // bcancel
            // 
            this.bcancel.Location = new System.Drawing.Point(349, 140);
            this.bcancel.Name = "bcancel";
            this.bcancel.Size = new System.Drawing.Size(75, 23);
            this.bcancel.TabIndex = 1;
            this.bcancel.Text = "Cancel";
            this.bcancel.UseVisualStyleBackColor = true;
            this.bcancel.Click += new System.EventHandler(this.bcancel_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(115, 85);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(309, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome de Jogador: ";
            // 
            // Guardar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 201);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bcancel);
            this.Controls.Add(this.bsave);
            this.Name = "Guardar";
            this.Text = "Guardar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bsave;
        private System.Windows.Forms.Button bcancel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}