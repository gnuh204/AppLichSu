<<<<<<< HEAD
﻿namespace AppLichSu.formadmin
{
<<<<<<<< HEAD:AppLichSu/Login.Designer.cs
    partial class Login
========
    partial class Thống_kê_và_báo_cáo
>>>>>>>> 08f89de51940a8d47f2b28b0fe68859108a98aa4:AppLichSu/formadmin/Thongkevabaocao.Designer.cs
=======
﻿namespace AppLichSu
{
    partial class Login
>>>>>>> 08f89de51940a8d47f2b28b0fe68859108a98aa4
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
            label1 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(237, 127);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 0;
            label1.Text = "Biểu đồ";
            // 
            // Thống_kê_và_báo_cáo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Name = "Thống_kê_và_báo_cáo";
            Text = "Thống_kê_và_báo_cáo";
=======
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            lblquenmk = new Label();
            btndn = new Button();
            chkghinhomk = new CheckBox();
            txtTendn = new TextBox();
            txtmk = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(290, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(224, 172);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            //pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(166, 218);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(52, 38);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
           // pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(166, 287);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(52, 38);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
           // pictureBox3.Click += pictureBox2_Click;
            // 
            // lblquenmk
            // 
            lblquenmk.AutoSize = true;
            lblquenmk.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblquenmk.ForeColor = Color.Blue;
            lblquenmk.Location = new Point(188, 353);
            lblquenmk.Name = "lblquenmk";
            lblquenmk.Size = new Size(109, 20);
            lblquenmk.TabIndex = 5;
            lblquenmk.Text = "Quên mật khẩu";
            //lblquenmk.Click += lblquenmk_Click;
            // 
            // btndn
            // 
            btndn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btndn.ForeColor = Color.FromArgb(0, 0, 192);
            btndn.Location = new Point(313, 391);
            btndn.Name = "btndn";
            btndn.Size = new Size(122, 33);
            btndn.TabIndex = 6;
            btndn.Text = "Đăng nhập";
            btndn.UseVisualStyleBackColor = true;
            btndn.Click += btndn_Click;
            // 
            // chkghinhomk
            // 
            chkghinhomk.AutoSize = true;
            chkghinhomk.ForeColor = Color.Blue;
            chkghinhomk.Location = new Point(411, 348);
            chkghinhomk.Name = "chkghinhomk";
            chkghinhomk.Size = new Size(147, 24);
            chkghinhomk.TabIndex = 7;
            chkghinhomk.Text = "Ghi nhớ mật khẩu";
            chkghinhomk.UseVisualStyleBackColor = true;
            // 
            // txtTendn
            // 
            txtTendn.Location = new Point(267, 229);
            txtTendn.Name = "txtTendn";
            txtTendn.Size = new Size(237, 27);
            txtTendn.TabIndex = 8;
            // 
            // txtmk
            // 
            txtmk.Location = new Point(267, 298);
            txtmk.Name = "txtmk";
            txtmk.Size = new Size(247, 27);
            txtmk.TabIndex = 9;
            // 
            // Longin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(788, 462);
            Controls.Add(txtmk);
            Controls.Add(txtTendn);
            Controls.Add(chkghinhomk);
            Controls.Add(btndn);
            Controls.Add(lblquenmk);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Longin";
            Text = "Đăng nhập";
           //Load += this.Longin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
>>>>>>> 08f89de51940a8d47f2b28b0fe68859108a98aa4
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

<<<<<<< HEAD
        private Label label1;
=======
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label lblquenmk;
        private Button btndn;
        private CheckBox chkghinhomk;
        private TextBox txtTendn;
        private TextBox txtmk;
>>>>>>> 08f89de51940a8d47f2b28b0fe68859108a98aa4
    }
}