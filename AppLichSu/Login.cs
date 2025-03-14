using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

<<<<<<< HEAD
namespace AppLichSu.formadmin
{
<<<<<<<< HEAD:AppLichSu/Login.cs
    public partial class Login : Form
    {
        public Login()
========
    public partial class Form1 : Form
    {
        public Form1()
>>>>>>>> 08f89de51940a8d47f2b28b0fe68859108a98aa4:AppLichSu/formadmin/Quanlytknguoidung.cs
        {
            InitializeComponent();
        }
    }
}
=======
namespace AppLichSu
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

      
        private void btndn_Click(object sender, EventArgs e)
        {
            string username = txtTendn.Text;
            string password = txtmk.Text;

            if (username == "admin" && password == "123456")
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
    

>>>>>>> 08f89de51940a8d47f2b28b0fe68859108a98aa4
