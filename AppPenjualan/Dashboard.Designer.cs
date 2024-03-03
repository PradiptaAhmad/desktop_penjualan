namespace AppPenjualan
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            dtp_tanggal_pemesanan = new DateTimePicker();
            txt_tanggal_pemesanan = new TextBox();
            lbl_tanggal_pemesanan = new Label();
            rb_kecil = new RadioButton();
            lbl_pedas = new Label();
            cb_sugar = new CheckBox();
            cb_tidak = new CheckBox();
            cb_soya = new CheckBox();
            cb_meses = new CheckBox();
            cb_whip_cream = new CheckBox();
            lbl_opsional = new Label();
            lbl_menu_tambahan = new Label();
            nud_jumlah_pesanan = new NumericUpDown();
            txt_jumlah_pesanan = new TextBox();
            lbl_jumlah_pesanan = new Label();
            cbx_pesanan = new ComboBox();
            txt_pesanan = new TextBox();
            lbl_pesanan = new Label();
            txt_nama_pelanggan = new TextBox();
            lbl_nama_pelanggan = new Label();
            txt_id_pelanggan = new TextBox();
            lbl_id_pelanggan = new Label();
            pnl_header = new Panel();
            pictureBox1 = new PictureBox();
            lbl_logout = new Label();
            pb_logout = new PictureBox();
            pb_slogan_gacoan = new PictureBox();
            pb_logo_dashboard = new PictureBox();
            rb_sedang = new RadioButton();
            rb_besar = new RadioButton();
            button1 = new Button();
            button2 = new Button();
            dgv_list_pesanan = new DataGridView();
            button3 = new Button();
            button4 = new Button();
            txt_search = new TextBox();
            button5 = new Button();
            button6 = new Button();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)nud_jumlah_pesanan).BeginInit();
            pnl_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_logout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_slogan_gacoan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_logo_dashboard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_list_pesanan).BeginInit();
            SuspendLayout();
            // 
            // dtp_tanggal_pemesanan
            // 
            dtp_tanggal_pemesanan.CalendarMonthBackground = Color.WhiteSmoke;
            dtp_tanggal_pemesanan.CalendarTitleBackColor = Color.SteelBlue;
            dtp_tanggal_pemesanan.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dtp_tanggal_pemesanan.Location = new Point(447, 290);
            dtp_tanggal_pemesanan.Margin = new Padding(3, 2, 3, 2);
            dtp_tanggal_pemesanan.Name = "dtp_tanggal_pemesanan";
            dtp_tanggal_pemesanan.Size = new Size(391, 24);
            dtp_tanggal_pemesanan.TabIndex = 53;
            // 
            // txt_tanggal_pemesanan
            // 
            txt_tanggal_pemesanan.BackColor = Color.WhiteSmoke;
            txt_tanggal_pemesanan.BorderStyle = BorderStyle.None;
            txt_tanggal_pemesanan.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txt_tanggal_pemesanan.Location = new Point(447, 285);
            txt_tanggal_pemesanan.Margin = new Padding(3, 2, 3, 2);
            txt_tanggal_pemesanan.Multiline = true;
            txt_tanggal_pemesanan.Name = "txt_tanggal_pemesanan";
            txt_tanggal_pemesanan.ReadOnly = true;
            txt_tanggal_pemesanan.Size = new Size(390, 32);
            txt_tanggal_pemesanan.TabIndex = 52;
            // 
            // lbl_tanggal_pemesanan
            // 
            lbl_tanggal_pemesanan.AutoSize = true;
            lbl_tanggal_pemesanan.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_tanggal_pemesanan.Location = new Point(447, 258);
            lbl_tanggal_pemesanan.Name = "lbl_tanggal_pemesanan";
            lbl_tanggal_pemesanan.Size = new Size(146, 17);
            lbl_tanggal_pemesanan.TabIndex = 51;
            lbl_tanggal_pemesanan.Text = "Tanggal Pemesanan";
            // 
            // rb_kecil
            // 
            rb_kecil.AutoSize = true;
            rb_kecil.Font = new Font("Century Gothic", 9.2F, FontStyle.Bold, GraphicsUnit.Point);
            rb_kecil.Location = new Point(447, 220);
            rb_kecil.Margin = new Padding(3, 2, 3, 2);
            rb_kecil.Name = "rb_kecil";
            rb_kecil.Size = new Size(57, 20);
            rb_kecil.TabIndex = 49;
            rb_kecil.TabStop = true;
            rb_kecil.Text = "Kecil";
            rb_kecil.UseVisualStyleBackColor = true;
            // 
            // lbl_pedas
            // 
            lbl_pedas.AutoSize = true;
            lbl_pedas.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_pedas.Location = new Point(445, 194);
            lbl_pedas.Name = "lbl_pedas";
            lbl_pedas.Size = new Size(54, 17);
            lbl_pedas.TabIndex = 48;
            lbl_pedas.Text = "Ukuran";
            // 
            // cb_sugar
            // 
            cb_sugar.AutoSize = true;
            cb_sugar.Font = new Font("Century Gothic", 9.2F, FontStyle.Bold, GraphicsUnit.Point);
            cb_sugar.Location = new Point(590, 152);
            cb_sugar.Margin = new Padding(3, 2, 3, 2);
            cb_sugar.Name = "cb_sugar";
            cb_sugar.Size = new Size(64, 20);
            cb_sugar.TabIndex = 47;
            cb_sugar.Text = "Sugar";
            cb_sugar.UseVisualStyleBackColor = true;
            cb_sugar.CheckedChanged += cb_sugar_CheckedChanged;
            // 
            // cb_tidak
            // 
            cb_tidak.AutoSize = true;
            cb_tidak.Font = new Font("Century Gothic", 9.2F, FontStyle.Bold, GraphicsUnit.Point);
            cb_tidak.ForeColor = Color.Red;
            cb_tidak.Location = new Point(660, 152);
            cb_tidak.Margin = new Padding(3, 2, 3, 2);
            cb_tidak.Name = "cb_tidak";
            cb_tidak.Size = new Size(62, 20);
            cb_tidak.TabIndex = 46;
            cb_tidak.Text = "Tidak";
            cb_tidak.UseVisualStyleBackColor = true;
            cb_tidak.CheckedChanged += cb_tidak_CheckedChanged;
            // 
            // cb_soya
            // 
            cb_soya.AutoSize = true;
            cb_soya.Font = new Font("Century Gothic", 9.2F, FontStyle.Bold, GraphicsUnit.Point);
            cb_soya.Location = new Point(447, 152);
            cb_soya.Margin = new Padding(3, 2, 3, 2);
            cb_soya.Name = "cb_soya";
            cb_soya.Size = new Size(91, 20);
            cb_soya.TabIndex = 45;
            cb_soya.Text = "Susu Soya";
            cb_soya.UseVisualStyleBackColor = true;
            cb_soya.CheckedChanged += cb_soya_CheckedChanged;
            // 
            // cb_meses
            // 
            cb_meses.AutoSize = true;
            cb_meses.Font = new Font("Century Gothic", 9.2F, FontStyle.Bold, GraphicsUnit.Point);
            cb_meses.Location = new Point(590, 126);
            cb_meses.Margin = new Padding(3, 2, 3, 2);
            cb_meses.Name = "cb_meses";
            cb_meses.Size = new Size(66, 20);
            cb_meses.TabIndex = 43;
            cb_meses.Text = "Meses";
            cb_meses.UseVisualStyleBackColor = true;
            cb_meses.CheckedChanged += cb_meses_CheckedChanged;
            // 
            // cb_whip_cream
            // 
            cb_whip_cream.AutoSize = true;
            cb_whip_cream.Font = new Font("Century Gothic", 9.2F, FontStyle.Bold, GraphicsUnit.Point);
            cb_whip_cream.Location = new Point(447, 126);
            cb_whip_cream.Margin = new Padding(3, 2, 3, 2);
            cb_whip_cream.Name = "cb_whip_cream";
            cb_whip_cream.Size = new Size(137, 20);
            cb_whip_cream.TabIndex = 42;
            cb_whip_cream.Text = "Whipping Cream";
            cb_whip_cream.UseVisualStyleBackColor = true;
            cb_whip_cream.CheckedChanged += cb_whip_cream_CheckedChanged;
            // 
            // lbl_opsional
            // 
            lbl_opsional.AutoSize = true;
            lbl_opsional.Font = new Font("Century Gothic", 8.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_opsional.ForeColor = Color.Red;
            lbl_opsional.Location = new Point(574, 98);
            lbl_opsional.Name = "lbl_opsional";
            lbl_opsional.Size = new Size(58, 15);
            lbl_opsional.TabIndex = 41;
            lbl_opsional.Text = "*opsional";
            // 
            // lbl_menu_tambahan
            // 
            lbl_menu_tambahan.AutoSize = true;
            lbl_menu_tambahan.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_menu_tambahan.Location = new Point(445, 98);
            lbl_menu_tambahan.Name = "lbl_menu_tambahan";
            lbl_menu_tambahan.Size = new Size(98, 17);
            lbl_menu_tambahan.TabIndex = 40;
            lbl_menu_tambahan.Text = "Extra Topping";
            // 
            // nud_jumlah_pesanan
            // 
            nud_jumlah_pesanan.BackColor = Color.WhiteSmoke;
            nud_jumlah_pesanan.BorderStyle = BorderStyle.None;
            nud_jumlah_pesanan.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            nud_jumlah_pesanan.Location = new Point(44, 331);
            nud_jumlah_pesanan.Margin = new Padding(3, 2, 3, 2);
            nud_jumlah_pesanan.Name = "nud_jumlah_pesanan";
            nud_jumlah_pesanan.Size = new Size(312, 20);
            nud_jumlah_pesanan.TabIndex = 39;
            // 
            // txt_jumlah_pesanan
            // 
            txt_jumlah_pesanan.BackColor = Color.WhiteSmoke;
            txt_jumlah_pesanan.BorderStyle = BorderStyle.None;
            txt_jumlah_pesanan.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txt_jumlah_pesanan.Location = new Point(34, 324);
            txt_jumlah_pesanan.Margin = new Padding(3, 2, 3, 2);
            txt_jumlah_pesanan.Multiline = true;
            txt_jumlah_pesanan.Name = "txt_jumlah_pesanan";
            txt_jumlah_pesanan.ReadOnly = true;
            txt_jumlah_pesanan.Size = new Size(332, 32);
            txt_jumlah_pesanan.TabIndex = 38;
            // 
            // lbl_jumlah_pesanan
            // 
            lbl_jumlah_pesanan.AutoSize = true;
            lbl_jumlah_pesanan.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_jumlah_pesanan.Location = new Point(32, 300);
            lbl_jumlah_pesanan.Name = "lbl_jumlah_pesanan";
            lbl_jumlah_pesanan.Size = new Size(119, 17);
            lbl_jumlah_pesanan.TabIndex = 37;
            lbl_jumlah_pesanan.Text = "Jumlah Pesanan";
            // 
            // cbx_pesanan
            // 
            cbx_pesanan.BackColor = Color.WhiteSmoke;
            cbx_pesanan.FlatStyle = FlatStyle.Popup;
            cbx_pesanan.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            cbx_pesanan.FormattingEnabled = true;
            cbx_pesanan.Items.AddRange(new object[] { "Kopi Original besar", "Kopi Original Kecil", "Kopi Rasa Coklat", "Kopi Caramel" });
            cbx_pesanan.Location = new Point(34, 262);
            cbx_pesanan.Margin = new Padding(3, 2, 3, 2);
            cbx_pesanan.Name = "cbx_pesanan";
            cbx_pesanan.Size = new Size(332, 25);
            cbx_pesanan.TabIndex = 36;
            // 
            // txt_pesanan
            // 
            txt_pesanan.BackColor = Color.WhiteSmoke;
            txt_pesanan.BorderStyle = BorderStyle.None;
            txt_pesanan.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txt_pesanan.Location = new Point(34, 257);
            txt_pesanan.Margin = new Padding(3, 2, 3, 2);
            txt_pesanan.Multiline = true;
            txt_pesanan.Name = "txt_pesanan";
            txt_pesanan.ReadOnly = true;
            txt_pesanan.Size = new Size(332, 32);
            txt_pesanan.TabIndex = 35;
            // 
            // lbl_pesanan
            // 
            lbl_pesanan.AutoSize = true;
            lbl_pesanan.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_pesanan.Location = new Point(32, 233);
            lbl_pesanan.Name = "lbl_pesanan";
            lbl_pesanan.Size = new Size(65, 17);
            lbl_pesanan.TabIndex = 34;
            lbl_pesanan.Text = "Pesanan";
            // 
            // txt_nama_pelanggan
            // 
            txt_nama_pelanggan.BackColor = Color.WhiteSmoke;
            txt_nama_pelanggan.BorderStyle = BorderStyle.None;
            txt_nama_pelanggan.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txt_nama_pelanggan.Location = new Point(34, 190);
            txt_nama_pelanggan.Margin = new Padding(3, 2, 3, 2);
            txt_nama_pelanggan.Multiline = true;
            txt_nama_pelanggan.Name = "txt_nama_pelanggan";
            txt_nama_pelanggan.Size = new Size(332, 32);
            txt_nama_pelanggan.TabIndex = 33;
            // 
            // lbl_nama_pelanggan
            // 
            lbl_nama_pelanggan.AutoSize = true;
            lbl_nama_pelanggan.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_nama_pelanggan.Location = new Point(32, 166);
            lbl_nama_pelanggan.Name = "lbl_nama_pelanggan";
            lbl_nama_pelanggan.Size = new Size(127, 17);
            lbl_nama_pelanggan.TabIndex = 32;
            lbl_nama_pelanggan.Text = "Nama Pelanggan";
            // 
            // txt_id_pelanggan
            // 
            txt_id_pelanggan.BackColor = Color.WhiteSmoke;
            txt_id_pelanggan.BorderStyle = BorderStyle.None;
            txt_id_pelanggan.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txt_id_pelanggan.Location = new Point(34, 122);
            txt_id_pelanggan.Margin = new Padding(3, 2, 3, 2);
            txt_id_pelanggan.Multiline = true;
            txt_id_pelanggan.Name = "txt_id_pelanggan";
            txt_id_pelanggan.Size = new Size(332, 32);
            txt_id_pelanggan.TabIndex = 31;
            txt_id_pelanggan.KeyPress += txt_id_pelanggan_KeyPress;
            // 
            // lbl_id_pelanggan
            // 
            lbl_id_pelanggan.AutoSize = true;
            lbl_id_pelanggan.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_id_pelanggan.Location = new Point(32, 98);
            lbl_id_pelanggan.Name = "lbl_id_pelanggan";
            lbl_id_pelanggan.Size = new Size(99, 17);
            lbl_id_pelanggan.TabIndex = 30;
            lbl_id_pelanggan.Text = "ID Pelanggan";
            // 
            // pnl_header
            // 
            pnl_header.BackColor = Color.ForestGreen;
            pnl_header.Controls.Add(pictureBox1);
            pnl_header.Controls.Add(lbl_logout);
            pnl_header.Controls.Add(pb_logout);
            pnl_header.Controls.Add(pb_slogan_gacoan);
            pnl_header.Controls.Add(pb_logo_dashboard);
            pnl_header.Dock = DockStyle.Top;
            pnl_header.Location = new Point(0, 0);
            pnl_header.Margin = new Padding(3, 2, 3, 2);
            pnl_header.Name = "pnl_header";
            pnl_header.Size = new Size(944, 88);
            pnl_header.TabIndex = 54;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(944, 88);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // lbl_logout
            // 
            lbl_logout.AutoSize = true;
            lbl_logout.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_logout.ForeColor = Color.White;
            lbl_logout.Location = new Point(1045, 37);
            lbl_logout.Name = "lbl_logout";
            lbl_logout.Size = new Size(53, 17);
            lbl_logout.TabIndex = 3;
            lbl_logout.Text = "Logout";
            // 
            // pb_logout
            // 
            pb_logout.Location = new Point(1007, 30);
            pb_logout.Margin = new Padding(3, 2, 3, 2);
            pb_logout.Name = "pb_logout";
            pb_logout.Size = new Size(32, 31);
            pb_logout.SizeMode = PictureBoxSizeMode.Zoom;
            pb_logout.TabIndex = 2;
            pb_logout.TabStop = false;
            // 
            // pb_slogan_gacoan
            // 
            pb_slogan_gacoan.Location = new Point(429, -14);
            pb_slogan_gacoan.Margin = new Padding(3, 2, 3, 2);
            pb_slogan_gacoan.Name = "pb_slogan_gacoan";
            pb_slogan_gacoan.Size = new Size(359, 118);
            pb_slogan_gacoan.SizeMode = PictureBoxSizeMode.Zoom;
            pb_slogan_gacoan.TabIndex = 1;
            pb_slogan_gacoan.TabStop = false;
            // 
            // pb_logo_dashboard
            // 
            pb_logo_dashboard.Location = new Point(32, -6);
            pb_logo_dashboard.Margin = new Padding(3, 2, 3, 2);
            pb_logo_dashboard.Name = "pb_logo_dashboard";
            pb_logo_dashboard.Size = new Size(143, 102);
            pb_logo_dashboard.SizeMode = PictureBoxSizeMode.Zoom;
            pb_logo_dashboard.TabIndex = 0;
            pb_logo_dashboard.TabStop = false;
            // 
            // rb_sedang
            // 
            rb_sedang.AutoSize = true;
            rb_sedang.Font = new Font("Century Gothic", 9.2F, FontStyle.Bold, GraphicsUnit.Point);
            rb_sedang.Location = new Point(553, 220);
            rb_sedang.Margin = new Padding(3, 2, 3, 2);
            rb_sedang.Name = "rb_sedang";
            rb_sedang.Size = new Size(79, 20);
            rb_sedang.TabIndex = 55;
            rb_sedang.TabStop = true;
            rb_sedang.Text = "Sedang ";
            rb_sedang.UseVisualStyleBackColor = true;
            // 
            // rb_besar
            // 
            rb_besar.AutoSize = true;
            rb_besar.Font = new Font("Century Gothic", 9.2F, FontStyle.Bold, GraphicsUnit.Point);
            rb_besar.Location = new Point(676, 220);
            rb_besar.Margin = new Padding(3, 2, 3, 2);
            rb_besar.Name = "rb_besar";
            rb_besar.Size = new Size(61, 20);
            rb_besar.TabIndex = 56;
            rb_besar.TabStop = true;
            rb_besar.Text = "Besar";
            rb_besar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.SeaGreen;
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(447, 333);
            button1.Name = "button1";
            button1.Size = new Size(91, 35);
            button1.TabIndex = 57;
            button1.Text = "Tambah";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.SeaGreen;
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(553, 333);
            button2.Name = "button2";
            button2.Size = new Size(91, 35);
            button2.TabIndex = 58;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // dgv_list_pesanan
            // 
            dgv_list_pesanan.BackgroundColor = Color.WhiteSmoke;
            dgv_list_pesanan.BorderStyle = BorderStyle.None;
            dgv_list_pesanan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_list_pesanan.Location = new Point(32, 416);
            dgv_list_pesanan.Margin = new Padding(3, 2, 3, 2);
            dgv_list_pesanan.Name = "dgv_list_pesanan";
            dgv_list_pesanan.RowHeadersWidth = 51;
            dgv_list_pesanan.RowTemplate.Height = 29;
            dgv_list_pesanan.Size = new Size(803, 206);
            dgv_list_pesanan.TabIndex = 59;
            dgv_list_pesanan.CellClick += dgv_list_pesanan_CellClick;
            dgv_list_pesanan.CellContentClick += dgv_list_pesanan_CellContentClick;
            // 
            // button3
            // 
            button3.BackColor = Color.SeaGreen;
            button3.ForeColor = SystemColors.ControlLightLight;
            button3.Location = new Point(843, 416);
            button3.Name = "button3";
            button3.Size = new Size(91, 35);
            button3.TabIndex = 60;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.SeaGreen;
            button4.ForeColor = SystemColors.ControlLightLight;
            button4.Location = new Point(843, 457);
            button4.Name = "button4";
            button4.Size = new Size(91, 35);
            button4.TabIndex = 61;
            button4.Text = "Delete";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // txt_search
            // 
            txt_search.BackColor = Color.WhiteSmoke;
            txt_search.BorderStyle = BorderStyle.None;
            txt_search.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txt_search.Location = new Point(34, 371);
            txt_search.Margin = new Padding(3, 2, 3, 2);
            txt_search.Multiline = true;
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(332, 32);
            txt_search.TabIndex = 62;
            txt_search.TextChanged += txt_search_TextChanged;
            // 
            // button5
            // 
            button5.BackColor = Color.SeaGreen;
            button5.ForeColor = SystemColors.ControlLightLight;
            button5.Location = new Point(843, 498);
            button5.Name = "button5";
            button5.Size = new Size(91, 35);
            button5.TabIndex = 63;
            button5.Text = "Logout";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click_1;
            // 
            // button6
            // 
            button6.BackColor = Color.SeaGreen;
            button6.ForeColor = SystemColors.ControlLightLight;
            button6.Location = new Point(843, 539);
            button6.Name = "button6";
            button6.Size = new Size(91, 35);
            button6.TabIndex = 64;
            button6.Text = "Print pdf";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage_1;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(944, 633);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(txt_search);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(dgv_list_pesanan);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(rb_besar);
            Controls.Add(rb_sedang);
            Controls.Add(pnl_header);
            Controls.Add(dtp_tanggal_pemesanan);
            Controls.Add(txt_tanggal_pemesanan);
            Controls.Add(lbl_tanggal_pemesanan);
            Controls.Add(rb_kecil);
            Controls.Add(lbl_pedas);
            Controls.Add(cb_sugar);
            Controls.Add(cb_tidak);
            Controls.Add(cb_soya);
            Controls.Add(cb_meses);
            Controls.Add(cb_whip_cream);
            Controls.Add(lbl_opsional);
            Controls.Add(lbl_menu_tambahan);
            Controls.Add(nud_jumlah_pesanan);
            Controls.Add(txt_jumlah_pesanan);
            Controls.Add(lbl_jumlah_pesanan);
            Controls.Add(cbx_pesanan);
            Controls.Add(txt_pesanan);
            Controls.Add(lbl_pesanan);
            Controls.Add(txt_nama_pelanggan);
            Controls.Add(lbl_nama_pelanggan);
            Controls.Add(txt_id_pelanggan);
            Controls.Add(lbl_id_pelanggan);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load;
            ((System.ComponentModel.ISupportInitialize)nud_jumlah_pesanan).EndInit();
            pnl_header.ResumeLayout(false);
            pnl_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_logout).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_slogan_gacoan).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_logo_dashboard).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_list_pesanan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtp_tanggal_pemesanan;
        private TextBox txt_tanggal_pemesanan;
        private Label lbl_tanggal_pemesanan;
        private RadioButton rb_kecil;
        private Label lbl_pedas;
        private CheckBox cb_sugar;
        private CheckBox cb_tidak;
        private CheckBox cb_soya;
        private CheckBox cb_meses;
        private CheckBox cb_whip_cream;
        private Label lbl_opsional;
        private Label lbl_menu_tambahan;
        private NumericUpDown nud_jumlah_pesanan;
        private TextBox txt_jumlah_pesanan;
        private Label lbl_jumlah_pesanan;
        private ComboBox cbx_pesanan;
        private TextBox txt_pesanan;
        private Label lbl_pesanan;
        private TextBox txt_nama_pelanggan;
        private Label lbl_nama_pelanggan;
        private TextBox txt_id_pelanggan;
        private Label lbl_id_pelanggan;
        private Panel pnl_header;
        private PictureBox pictureBox1;
        private Label lbl_logout;
        private PictureBox pb_logout;
        private PictureBox pb_slogan_gacoan;
        private PictureBox pb_logo_dashboard;
        private RadioButton rb_sedang;
        private RadioButton rb_besar;
        private Button button1;
        private Button button2;
        private DataGridView dgv_list_pesanan;
        private Button button3;
        private Button button4;
        private TextBox txt_search;
        private Button button5;
        private Button button6;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
    }
}