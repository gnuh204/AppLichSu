﻿namespace AppLichSu.formadmin
{
    partial class Tổng_quan
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(100, 50);
            label1.Name = "label1";
            label1.Size = new Size(115, 20);
            label1.TabIndex = 0;
            label1.Text = "Tổng số bài học";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(109, 120);
            label2.Name = "label2";
            label2.Size = new Size(143, 20);
            label2.TabIndex = 1;
            label2.Text = "Tổng số người dùng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(111, 172);
            label3.Name = "label3";
            label3.Size = new Size(159, 20);
            label3.TabIndex = 2;
            label3.Text = "Số bài kiểm tra đã làm";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(107, 214);
            label4.Name = "label4";
            label4.Size = new Size(186, 20);
            label4.TabIndex = 3;
            label4.Text = "thêm biểu đồ lượt truy cập";
            // 
            // Tổng_quan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Tổng_quan";
            Text = "Tổng_quan";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}