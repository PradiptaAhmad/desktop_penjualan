using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppPenjualan
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            cbx_pesanan.DropDownStyle = ComboBoxStyle.DropDownList;
            bind_data();
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-Q0AKOSQ;Initial Catalog=appPenjualan;Integrated Security=True");
        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bind_data()
        {
            SqlCommand cmd1 = new SqlCommand("Select idpelanggan,namapelanggan,pesanan,jumlahpesanan,toppings, ukuran,tanggalpemesanan from starbucks", conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd1;
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dgv_list_pesanan.DataSource = dt;
            dgv_list_pesanan.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 10, FontStyle.Bold);

            dgv_list_pesanan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            long id_pelanggan = Convert.ToInt64(txt_id_pelanggan.Text);
            string nama_pelanggan = txt_nama_pelanggan.Text;
            string pesanan = cbx_pesanan.SelectedItem.ToString();
            string jumlah_pesanan = nud_jumlah_pesanan.Value.ToString();
            List<string> extra_topping = new List<string>();
            string ukuran = "";
            string tanggal_pemesanan = dtp_tanggal_pemesanan.Value.ToString();

            if (cb_meses.Checked)
            {
                extra_topping.Add("Meses");
            }
            if (cb_soya.Checked)
            {
                extra_topping.Add("Susu Soya");
            }
            if (cb_whip_cream.Checked)
            {
                extra_topping.Add("Whipping Cream");
            }
            if (cb_sugar.Checked)
            {
                extra_topping.Add("Sugar");
            }
            if (cb_tidak.Checked)
            {
                extra_topping.Add("Tidak");
            }

            if (rb_kecil.Checked)
            {
                ukuran = "Kecil";
            }
            if (rb_besar.Checked)
            {
                ukuran = "Besar";
            }
            if (rb_sedang.Checked)
            {
                ukuran = "Sedang";
            }

            SqlCommand cmd2 = new SqlCommand("INSERT INTO starbucks(idpelanggan,namapelanggan,pesanan,jumlahpesanan,toppings, ukuran,tanggalpemesanan)Values(@idpelanggan,@namapelanggan,@pesanan,@jumlahpesanan,@toppings,@ukuran,@tanggalpemesanan)", conn);
            cmd2.Parameters.AddWithValue("idpelanggan", id_pelanggan);
            cmd2.Parameters.AddWithValue("namapelanggan", nama_pelanggan);
            cmd2.Parameters.AddWithValue("pesanan", pesanan);
            cmd2.Parameters.AddWithValue("jumlahpesanan", jumlah_pesanan);
            cmd2.Parameters.AddWithValue("toppings", string.Join(",", extra_topping));
            cmd2.Parameters.AddWithValue("ukuran", ukuran);
            cmd2.Parameters.AddWithValue("tanggalpemesanan", tanggal_pemesanan);
            conn.Open();
            cmd2.ExecuteNonQuery();
            conn.Close();
            bind_data();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_id_pelanggan.Clear();
            txt_id_pelanggan.ReadOnly = false;
            txt_nama_pelanggan.Clear();
            cbx_pesanan.SelectedIndex = -1;
            nud_jumlah_pesanan.Value = 0;
            cb_sugar.Checked = false;
            cb_whip_cream.Checked = false;
            cb_soya.Checked = false;
            cb_meses.Checked = false;
            rb_kecil.Checked = false;
            rb_sedang.Checked = false;
            rb_besar.Checked = false;
            dtp_tanggal_pemesanan.Value = DateTime.Now;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand cmd4 = new SqlCommand("Delete from starbucks where idpelanggan=@idpelanggan", conn);
            cmd4.Parameters.AddWithValue("idpelanggan", txt_id_pelanggan.Text);
            conn.Open();
            cmd4.ExecuteNonQuery();
            conn.Close();
            txt_id_pelanggan.ReadOnly = false;
            bind_data();
        }

        private void dgv_list_pesanan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index;
            index = e.RowIndex;
            DataGridViewRow selectedRow = dgv_list_pesanan.Rows[index];
            txt_id_pelanggan.Text = selectedRow.Cells[0].Value.ToString();
            txt_id_pelanggan.ReadOnly = true;
            txt_nama_pelanggan.Text = selectedRow.Cells[1].Value.ToString();
            cb_sugar.Checked = false;
            cb_whip_cream.Checked = false;
            cb_soya.Checked = false;
            cb_meses.Checked = false;
            cb_tidak.Checked = false;

            if (selectedRow.Cells.Count >= 7)
            {
                cbx_pesanan.SelectedItem = selectedRow.Cells[2].Value.ToString();
                nud_jumlah_pesanan.Value = Convert.ToDecimal(selectedRow.Cells[3].Value);

                string[] extra_topping = selectedRow.Cells[4].Value.ToString().Split(',');
                foreach (string item in extra_topping)
                {
                    if (item.Trim() == "Meses")
                    {
                        cb_meses.Checked = true;
                    }
                    if (item.Trim() == "Susu Soya")
                    {
                        cb_soya.Checked = true;
                    }
                    if (item.Trim() == "Whipping Cream")
                    {
                        cb_whip_cream.Checked = true;
                    }
                    if (item.Trim() == "Sugar")
                    {
                        cb_sugar.Checked = true;
                    }
                    if (item.Trim() == "Tidak")
                    {
                        cb_tidak.Checked = true;
                    }
                }

                if (selectedRow.Cells[5].Value.ToString() == "Kecil")
                {
                    rb_kecil.Checked = true;
                }
                if (selectedRow.Cells[5].Value.ToString() == "Sedang")
                {
                    rb_sedang.Checked = true;
                }
                if (selectedRow.Cells[5].Value.ToString() == "Besar")
                {
                    rb_besar.Checked = true;
                }
                dtp_tanggal_pemesanan.Value = Convert.ToDateTime(selectedRow.Cells[6].Value);
            }
        }

        private void cb_soya_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_soya.Checked)
            {
                cb_tidak.Checked = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            string keyword = txt_search.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {

                bind_data();
            }
            else
            {

                string query = "Select idpelanggan,namapelanggan,pesanan,jumlahpesanan,toppings, ukuran,tanggalpemesanan from starbucks WHERE idpelanggan LIKE @keyword OR namapelanggan LIKE @keyword";
                using (SqlCommand cmd = new SqlCommand(query, conn))



                {
                    cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgv_list_pesanan.DataSource = dt;
                }
            }
        }

        private void txt_id_pelanggan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // If not a digit or a control key, suppress the key press
                e.Handled = true;
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Yakin Ingin Keluar?", "Warning!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Login login = new Login();
                login.Show();
                this.Hide();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            long id_pelanggan = Convert.ToInt64(txt_id_pelanggan.Text);
            string nama_pelanggan = txt_nama_pelanggan.Text;
            string pesanan = cbx_pesanan.SelectedItem.ToString();
            string jumlah_pesanan = nud_jumlah_pesanan.Value.ToString();
            List<string> extra_topping = new List<string>();
            string ukuran = "";
            string tanggal_pemesanan = dtp_tanggal_pemesanan.Value.ToString();

            if (cb_meses.Checked)
            {
                extra_topping.Add("Meses");
            }
            if (cb_soya.Checked)
            {
                extra_topping.Add("Susu Soya");
            }
            if (cb_whip_cream.Checked)
            {
                extra_topping.Add("Whipping Cream");
            }
            if (cb_sugar.Checked)
            {
                extra_topping.Add("Sugar");
            }
            if (cb_tidak.Checked)
            {
                extra_topping.Add("Tidak");
            }

            if (rb_kecil.Checked)
            {
                ukuran = "Kecil";
            }
            if (rb_besar.Checked)
            {
                ukuran = "Besar";
            }
            if (rb_sedang.Checked)
            {
                ukuran = "Sedang";
            }

            SqlCommand cmd2 = new SqlCommand("Update starbucks Set idpelanggan=@idpelanggan, namapelanggan=@namapelanggan, pesanan=@pesanan, jumlahpesanan=@jumlahpesanan, toppings=@toppings, ukuran=@ukuran, tanggalpemesanan=@tanggalpemesanan where idpelanggan=@idpelanggan", conn);
            cmd2.Parameters.AddWithValue("idpelanggan", id_pelanggan);
            cmd2.Parameters.AddWithValue("namapelanggan", nama_pelanggan);
            cmd2.Parameters.AddWithValue("pesanan", pesanan);
            cmd2.Parameters.AddWithValue("jumlahpesanan", jumlah_pesanan);
            cmd2.Parameters.AddWithValue("toppings", string.Join(",", extra_topping));
            cmd2.Parameters.AddWithValue("ukuran", ukuran);
            cmd2.Parameters.AddWithValue("tanggalpemesanan", tanggal_pemesanan);
            conn.Open();
            cmd2.ExecuteNonQuery();
            conn.Close();
            bind_data();
        }



        private void dgv_list_pesanan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap imagebmp = new Bitmap(dgv_list_pesanan.Width, dgv_list_pesanan.Height);
            dgv_list_pesanan.DrawToBitmap(imagebmp, new Rectangle(0, 0, dgv_list_pesanan.Width, dgv_list_pesanan.Height));

            if (imagebmp.Width > e.PageBounds.Width || imagebmp.Height > e.PageBounds.Height)
            {
                float scale = Math.Min((float)e.PageBounds.Width / imagebmp.Width, (float)e.PageBounds.Height / imagebmp.Height);
                e.Graphics.DrawImage(imagebmp, 0, 0, (int)(imagebmp.Width * scale), (int)(imagebmp.Height * scale));
            }
            else
            {
                e.Graphics.DrawImage(imagebmp, 0, 0);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
        }

        private void cb_tidak_CheckedChanged(object sender, EventArgs e)
        {
            if(cb_tidak.Checked)
            {
                cb_sugar.Checked = false;
                cb_whip_cream.Checked = false;
                cb_soya.Checked = false;
                cb_meses.Checked = false;
            }
        }

        private void printDocument1_PrintPage_1(object sender, PrintPageEventArgs e)
        {
            Bitmap imagebmp = new Bitmap(dgv_list_pesanan.Width, dgv_list_pesanan.Height);
            dgv_list_pesanan.DrawToBitmap(imagebmp, new Rectangle(0, 0, dgv_list_pesanan.Width, dgv_list_pesanan.Height));

            if (imagebmp.Width > e.PageBounds.Width || imagebmp.Height > e.PageBounds.Height)
            {
                float scale = Math.Min((float)e.PageBounds.Width / imagebmp.Width, (float)e.PageBounds.Height / imagebmp.Height);
                e.Graphics.DrawImage(imagebmp, 0, 0, (int)(imagebmp.Width * scale), (int)(imagebmp.Height * scale));
            }
            else
            {
                e.Graphics.DrawImage(imagebmp, 0, 0);
            }
        }

        private void cb_whip_cream_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_whip_cream.Checked)
            {
                cb_tidak.Checked = false;
            }
        }

        private void cb_meses_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_meses.Checked)
            {
                cb_tidak.Checked = false;
            }
        }

        private void cb_sugar_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_sugar.Checked)
            {
                cb_tidak.Checked = false;
            }
        }
    }
}
