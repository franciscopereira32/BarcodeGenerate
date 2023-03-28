namespace Barcode
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.bntEncode = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pic = new System.Windows.Forms.PictureBox();
            this.textEncode = new System.Windows.Forms.TextBox();
            this.textDecode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDecode = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // bntEncode
            // 
            this.bntEncode.Location = new System.Drawing.Point(305, 258);
            this.bntEncode.Name = "bntEncode";
            this.bntEncode.Size = new System.Drawing.Size(75, 23);
            this.bntEncode.TabIndex = 0;
            this.bntEncode.Text = "Encode";
            this.bntEncode.UseVisualStyleBackColor = true;
            this.bntEncode.Click += new System.EventHandler(this.bntEncode_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Encode";
            // 
            // pic
            // 
            this.pic.Location = new System.Drawing.Point(34, 32);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(427, 153);
            this.pic.TabIndex = 2;
            this.pic.TabStop = false;
            // 
            // textEncode
            // 
            this.textEncode.Location = new System.Drawing.Point(81, 206);
            this.textEncode.Name = "textEncode";
            this.textEncode.Size = new System.Drawing.Size(380, 20);
            this.textEncode.TabIndex = 3;
            // 
            // textDecode
            // 
            this.textDecode.Location = new System.Drawing.Point(81, 232);
            this.textDecode.Name = "textDecode";
            this.textDecode.Size = new System.Drawing.Size(380, 20);
            this.textDecode.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Decode";
            // 
            // btnDecode
            // 
            this.btnDecode.Location = new System.Drawing.Point(386, 258);
            this.btnDecode.Name = "btnDecode";
            this.btnDecode.Size = new System.Drawing.Size(75, 23);
            this.btnDecode.TabIndex = 6;
            this.btnDecode.Text = "Decode";
            this.btnDecode.UseVisualStyleBackColor = true;
            this.btnDecode.Click += new System.EventHandler(this.btnDecode_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 307);
            this.Controls.Add(this.btnDecode);
            this.Controls.Add(this.textDecode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textEncode);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bntEncode);
            this.Name = "Form1";
            this.Text = "Barcode Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntEncode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.TextBox textEncode;
        private System.Windows.Forms.TextBox textDecode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDecode;
    }
}

