﻿
namespace Lab4_Exc4 {
    partial class Form1 {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.textBoxF1 = new System.Windows.Forms.TextBox();
            this.buttonF1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxF1
            // 
            this.textBoxF1.Location = new System.Drawing.Point(12, 39);
            this.textBoxF1.Name = "textBoxF1";
            this.textBoxF1.Size = new System.Drawing.Size(184, 20);
            this.textBoxF1.TabIndex = 0;
            // 
            // buttonF1
            // 
            this.buttonF1.Location = new System.Drawing.Point(45, 101);
            this.buttonF1.Name = "buttonF1";
            this.buttonF1.Size = new System.Drawing.Size(123, 23);
            this.buttonF1.TabIndex = 1;
            this.buttonF1.Text = "Открыть";
            this.buttonF1.UseVisualStyleBackColor = true;
            this.buttonF1.Click += new System.EventHandler(this.buttonF1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(208, 161);
            this.Controls.Add(this.buttonF1);
            this.Controls.Add(this.textBoxF1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxF1;
        private System.Windows.Forms.Button buttonF1;
    }
}
