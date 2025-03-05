namespace AppLichSu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panelmenu = new Panel();
            button7 = new Button();
            panel4 = new Panel();
            btn_GD_nl = new Button();
            btn_GD_nd = new Button();
            btn_GD_1000 = new Button();
            btn_GD_hb = new Button();
            btn_GiaiDoan = new Button();
            btn_TrangChu = new Button();
            panel3 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelmenu.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1584, 68);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 28F, FontStyle.Bold);
            label1.Location = new Point(100, 14);
            label1.Name = "label1";
            label1.Size = new Size(547, 45);
            label1.TabIndex = 2;
            label1.Text = "Trang Chu | Lich su Viet Nam";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(78, 78);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panelmenu
            // 
            panelmenu.AutoScroll = true;
            panelmenu.BackColor = Color.Black;
            panelmenu.Controls.Add(button7);
            panelmenu.Controls.Add(panel4);
            panelmenu.Controls.Add(btn_GiaiDoan);
            panelmenu.Controls.Add(btn_TrangChu);
            panelmenu.Controls.Add(panel3);
            panelmenu.Dock = DockStyle.Left;
            panelmenu.Location = new Point(0, 68);
            panelmenu.Name = "panelmenu";
            panelmenu.Size = new Size(280, 793);
            panelmenu.TabIndex = 1;
            // 
            // button7
            // 
            button7.BackColor = Color.Black;
            button7.Dock = DockStyle.Top;
            button7.FlatAppearance.BorderColor = Color.Black;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.ForeColor = Color.White;
            button7.Location = new Point(0, 401);
            button7.Name = "button7";
            button7.Padding = new Padding(10, 0, 0, 0);
            button7.Size = new Size(280, 61);
            button7.TabIndex = 4;
            button7.Text = "Trắc nghiệm";
            button7.TextAlign = ContentAlignment.MiddleLeft;
            button7.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.AutoSize = true;
            panel4.BackColor = Color.FromArgb(64, 64, 64);
            panel4.Controls.Add(btn_GD_nl);
            panel4.Controls.Add(btn_GD_nd);
            panel4.Controls.Add(btn_GD_1000);
            panel4.Controls.Add(btn_GD_hb);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 201);
            panel4.Name = "panel4";
            panel4.Size = new Size(280, 200);
            panel4.TabIndex = 2;
            // 
            // btn_GD_nl
            // 
            btn_GD_nl.Dock = DockStyle.Top;
            btn_GD_nl.FlatAppearance.BorderSize = 0;
            btn_GD_nl.FlatStyle = FlatStyle.Flat;
            btn_GD_nl.Font = new Font("Times New Roman", 12F);
            btn_GD_nl.ForeColor = Color.White;
            btn_GD_nl.Location = new Point(0, 150);
            btn_GD_nl.Name = "btn_GD_nl";
            btn_GD_nl.Padding = new Padding(35, 0, 0, 0);
            btn_GD_nl.Size = new Size(280, 50);
            btn_GD_nl.TabIndex = 3;
            btn_GD_nl.Text = "Nhà Tiền Lê";
            btn_GD_nl.TextAlign = ContentAlignment.MiddleLeft;
            btn_GD_nl.UseVisualStyleBackColor = true;
            btn_GD_nl.Click += btn_GD_nl_Click;
            // 
            // btn_GD_nd
            // 
            btn_GD_nd.Dock = DockStyle.Top;
            btn_GD_nd.FlatAppearance.BorderSize = 0;
            btn_GD_nd.FlatStyle = FlatStyle.Flat;
            btn_GD_nd.Font = new Font("Times New Roman", 12F);
            btn_GD_nd.ForeColor = Color.White;
            btn_GD_nd.Location = new Point(0, 100);
            btn_GD_nd.Name = "btn_GD_nd";
            btn_GD_nd.Padding = new Padding(35, 0, 0, 0);
            btn_GD_nd.Size = new Size(280, 50);
            btn_GD_nd.TabIndex = 2;
            btn_GD_nd.Text = "Nhà Đinh";
            btn_GD_nd.TextAlign = ContentAlignment.MiddleLeft;
            btn_GD_nd.UseVisualStyleBackColor = true;
            btn_GD_nd.Click += btn_GD_nd_Click;
            // 
            // btn_GD_1000
            // 
            btn_GD_1000.Dock = DockStyle.Top;
            btn_GD_1000.FlatAppearance.BorderSize = 0;
            btn_GD_1000.FlatStyle = FlatStyle.Flat;
            btn_GD_1000.Font = new Font("Times New Roman", 12F);
            btn_GD_1000.ForeColor = Color.White;
            btn_GD_1000.Location = new Point(0, 50);
            btn_GD_1000.Name = "btn_GD_1000";
            btn_GD_1000.Padding = new Padding(35, 0, 0, 0);
            btn_GD_1000.Size = new Size(280, 50);
            btn_GD_1000.TabIndex = 1;
            btn_GD_1000.Text = "1000 năm Bắc thuộc";
            btn_GD_1000.TextAlign = ContentAlignment.MiddleLeft;
            btn_GD_1000.UseVisualStyleBackColor = true;
            btn_GD_1000.Click += btn_GD_1000_Click;
            // 
            // btn_GD_hb
            // 
            btn_GD_hb.Dock = DockStyle.Top;
            btn_GD_hb.FlatAppearance.BorderSize = 0;
            btn_GD_hb.FlatStyle = FlatStyle.Flat;
            btn_GD_hb.Font = new Font("Times New Roman", 12F);
            btn_GD_hb.ForeColor = Color.White;
            btn_GD_hb.Location = new Point(0, 0);
            btn_GD_hb.Name = "btn_GD_hb";
            btn_GD_hb.Padding = new Padding(35, 0, 0, 0);
            btn_GD_hb.Size = new Size(280, 50);
            btn_GD_hb.TabIndex = 0;
            btn_GD_hb.Text = "Thời Hồng Bàng";
            btn_GD_hb.TextAlign = ContentAlignment.MiddleLeft;
            btn_GD_hb.UseVisualStyleBackColor = true;
            btn_GD_hb.Click += btn_GD_hb_Click;
            // 
            // btn_GiaiDoan
            // 
            btn_GiaiDoan.BackColor = Color.Black;
            btn_GiaiDoan.Dock = DockStyle.Top;
            btn_GiaiDoan.FlatAppearance.BorderColor = Color.Black;
            btn_GiaiDoan.FlatAppearance.BorderSize = 0;
            btn_GiaiDoan.FlatStyle = FlatStyle.Flat;
            btn_GiaiDoan.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_GiaiDoan.ForeColor = Color.White;
            btn_GiaiDoan.Location = new Point(0, 140);
            btn_GiaiDoan.Name = "btn_GiaiDoan";
            btn_GiaiDoan.Size = new Size(280, 61);
            btn_GiaiDoan.TabIndex = 3;
            btn_GiaiDoan.Text = "  Giai đoạn";
            btn_GiaiDoan.TextAlign = ContentAlignment.MiddleLeft;
            btn_GiaiDoan.UseVisualStyleBackColor = false;
            btn_GiaiDoan.Click += btn_GiaiDoan_Click;
            // 
            // btn_TrangChu
            // 
            btn_TrangChu.BackColor = Color.Black;
            btn_TrangChu.Dock = DockStyle.Top;
            btn_TrangChu.FlatAppearance.BorderColor = Color.Black;
            btn_TrangChu.FlatAppearance.BorderSize = 0;
            btn_TrangChu.FlatStyle = FlatStyle.Flat;
            btn_TrangChu.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_TrangChu.ForeColor = Color.White;
            btn_TrangChu.Location = new Point(0, 80);
            btn_TrangChu.Name = "btn_TrangChu";
            btn_TrangChu.Size = new Size(280, 60);
            btn_TrangChu.TabIndex = 2;
            btn_TrangChu.Text = "  Trang chủ";
            btn_TrangChu.TextAlign = ContentAlignment.MiddleLeft;
            btn_TrangChu.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(280, 80);
            panel3.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1584, 861);
            Controls.Add(panelmenu);
            Controls.Add(panel1);
            MinimumSize = new Size(1600, 900);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelmenu.ResumeLayout(false);
            panelmenu.PerformLayout();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panelmenu;
        private Button btn_TrangChu;
        private Button btn_GiaiDoan;
        private Panel panel4;
        private Button btn_GD_nl;
        private Button btn_GD_nd;
        private Button btn_GD_1000;
        private Button btn_GD_hb;
        private Button button7;
        private Panel panel3;
    }
}
