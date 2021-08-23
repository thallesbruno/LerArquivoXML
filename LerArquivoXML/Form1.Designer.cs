
namespace LerArquivoXML
{
    partial class Form1
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
            this.txtCaminhoXML = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lstXML = new System.Windows.Forms.ListBox();
            this.btnLerTag = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informe o nome e o caminho do arquivo XML";
            // 
            // txtCaminhoXML
            // 
            this.txtCaminhoXML.Location = new System.Drawing.Point(12, 42);
            this.txtCaminhoXML.Name = "txtCaminhoXML";
            this.txtCaminhoXML.Size = new System.Drawing.Size(363, 20);
            this.txtCaminhoXML.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "Acessar e ler o arquivo XML";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstXML
            // 
            this.lstXML.FormattingEnabled = true;
            this.lstXML.Location = new System.Drawing.Point(16, 106);
            this.lstXML.Name = "lstXML";
            this.lstXML.Size = new System.Drawing.Size(359, 329);
            this.lstXML.TabIndex = 3;
            // 
            // btnLerTag
            // 
            this.btnLerTag.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnLerTag.FlatAppearance.BorderSize = 2;
            this.btnLerTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLerTag.Location = new System.Drawing.Point(215, 68);
            this.btnLerTag.Name = "btnLerTag";
            this.btnLerTag.Size = new System.Drawing.Size(160, 31);
            this.btnLerTag.TabIndex = 4;
            this.btnLerTag.Text = "Ler tags específicas";
            this.btnLerTag.UseVisualStyleBackColor = true;
            this.btnLerTag.Click += new System.EventHandler(this.btnLerTag_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 450);
            this.Controls.Add(this.btnLerTag);
            this.Controls.Add(this.lstXML);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtCaminhoXML);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lendo XML";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCaminhoXML;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lstXML;
        private System.Windows.Forms.Button btnLerTag;
    }
}

