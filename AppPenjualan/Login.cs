using System.Data.SqlClient;

namespace AppPenjualan
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-Q0AKOSQ;Initial Catalog=appPenjualan;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            string query = "SELECT COUNT(*) FROM auth WHERE username=@username AND password=@password";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@username", txt_username.Text);
            cmd.Parameters.AddWithValue("@password", txt_password.Text);
            int count = (int)cmd.ExecuteScalar();
            con.Close();
            if (count > 0)
            {
                MessageBox.Show("Login Success", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
                this.Hide();
                txt_username.Clear();
                txt_password.Clear();
            }
            else
            {
                MessageBox.Show("Error Login");
                txt_username.Clear();
                txt_password.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Yakin Ingin Keluar Aplikasi?", "Warning!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialogResult == DialogResult.No)
            {
                DialogResult dialogResult2 = MessageBox.Show("Apakah kamu ingin membersihkan kolom text?", "Warning!", MessageBoxButtons.YesNo);
                if (dialogResult2 == DialogResult.Yes)
                {
                    txt_username.Clear();
                    txt_password.Clear();
                }
            }
        }

        private void cb_showPassword_CheckedChanged(object sender, EventArgs e)
        {
            txt_password.PasswordChar = cb_showPassword.Checked ? '\0' : '*';
        }
    }
}