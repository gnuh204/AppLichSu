namespace AppLichSu.formadmin
{
    partial class QLTK
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
<<<<<<< HEAD
            SuspendLayout();
            // 
            // QLTK
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Name = "QLTK";
            Text = "QLTK";
=======
            panel1 = new Panel();
            button8 = new Button();
            button4 = new Button();
            button3 = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 192, 192);
            panel1.Controls.Add(button8);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(219, 788);
            panel1.TabIndex = 0;
            // 
            // button8
            // 
            button8.Location = new Point(23, 245);
            button8.Name = "button8";
            button8.Size = new Size(163, 29);
            button8.TabIndex = 4;
            button8.Text = "Đăng xuất";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button4
            // 
            button4.Location = new Point(23, 173);
            button4.Name = "button4";
            button4.Size = new Size(163, 29);
            button4.TabIndex = 3;
            button4.Text = "Thống kê và báo cáo";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(23, 106);
            button3.Name = "button3";
            button3.Size = new Size(163, 29);
            button3.TabIndex = 2;
            button3.Text = "Quản lý người dùng";
            button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(12, 44);
            button1.Name = "button1";
            button1.Size = new Size(174, 29);
            button1.TabIndex = 0;
            button1.Text = "Tổng quan";
            button1.UseVisualStyleBackColor = true;
            // 
            // QLTK
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1334, 788);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "QLTK";
            Text = "QLTK";
            Load += QLTK_Load;
            panel1.ResumeLayout(false);
>>>>>>> 08f89de51940a8d47f2b28b0fe68859108a98aa4
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button3;
        private Button button1;
        private Button button4;
        private Button button8;
    }
}