﻿namespace UI
{
    partial class INHOADONCONGTY
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
            this.label2 = new System.Windows.Forms.Label();
            this.yes_btn = new System.Windows.Forms.Button();
            this.no_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "In hóa đơn cho công ty";
            // 
            // yes_btn
            // 
            this.yes_btn.Location = new System.Drawing.Point(50, 62);
            this.yes_btn.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.yes_btn.Name = "yes_btn";
            this.yes_btn.Size = new System.Drawing.Size(79, 39);
            this.yes_btn.TabIndex = 19;
            this.yes_btn.Text = "Có";
            this.yes_btn.UseVisualStyleBackColor = true;
            this.yes_btn.Click += new System.EventHandler(this.yes_btn_Click);
            // 
            // no_btn
            // 
            this.no_btn.Location = new System.Drawing.Point(154, 62);
            this.no_btn.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.no_btn.Name = "no_btn";
            this.no_btn.Size = new System.Drawing.Size(79, 39);
            this.no_btn.TabIndex = 20;
            this.no_btn.Text = "Không";
            this.no_btn.UseVisualStyleBackColor = true;
            this.no_btn.Click += new System.EventHandler(this.no_btn_Click);
            // 
            // INHOADONCONGTY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 132);
            this.Controls.Add(this.no_btn);
            this.Controls.Add(this.yes_btn);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "INHOADONCONGTY";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LỰA CHỌN IN";
            this.Load += new System.EventHandler(this.INHOADONCONGTY_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button yes_btn;
        private System.Windows.Forms.Button no_btn;
    }
}