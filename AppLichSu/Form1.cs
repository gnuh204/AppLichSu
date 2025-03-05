namespace AppLichSu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customizeDesing();
        }
        private void customizeDesing()
        {
            panel4.Visible = false;
        }

        private void hidemenu()
        {
            if (panel4.Visible == true)
                panel4.Visible = false;
        }

        private void showmenu(Panel menu)
        {
            if (menu.Visible == false)
            {
                hidemenu();
                menu.Visible = true;
            }
            else
                menu.Visible = false;
        }

        private void btn_GiaiDoan_Click(object sender, EventArgs e)
        {
            showmenu(panel4);
        }

        private void btn_GD_hb_Click(object sender, EventArgs e)
        {
            hidemenu();
        }

        private void btn_GD_1000_Click(object sender, EventArgs e)
        {
            hidemenu();
        }

        private void btn_GD_nd_Click(object sender, EventArgs e)
        {
            hidemenu();
        }

        private void btn_GD_nl_Click(object sender, EventArgs e)
        {
            hidemenu();
        }
    }
}
