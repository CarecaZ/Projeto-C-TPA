﻿
namespace exerclooping
{
    partial class frmsete
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtc = new System.Windows.Forms.TextBox();
            this.txtf = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(113, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 63);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(329, 330);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 63);
            this.button2.TabIndex = 1;
            this.button2.Text = "Limpar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(555, 330);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 63);
            this.button3.TabIndex = 2;
            this.button3.Text = "Voltar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Digite o valor em Celsius C°";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fahrenheint 10 em 10";
            // 
            // txtc
            // 
            this.txtc.Location = new System.Drawing.Point(221, 72);
            this.txtc.Name = "txtc";
            this.txtc.Size = new System.Drawing.Size(100, 20);
            this.txtc.TabIndex = 6;
            // 
            // txtf
            // 
            this.txtf.Location = new System.Drawing.Point(202, 120);
            this.txtf.Multiline = true;
            this.txtf.Name = "txtf";
            this.txtf.Size = new System.Drawing.Size(119, 156);
            this.txtf.TabIndex = 7;
            // 
            // frmsete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::exerclooping.Properties.Resources.vino;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtf);
            this.Controls.Add(this.txtc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "frmsete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversão (Para)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtc;
        private System.Windows.Forms.TextBox txtf;
    }
}