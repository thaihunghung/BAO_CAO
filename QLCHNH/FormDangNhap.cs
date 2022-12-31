using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCHNH
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }
        classketnoi ketnoi = new classketnoi();
        DataTable dt = new DataTable();
      /*  private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                tbTaiKhoan.ForeColor = Color.White;
            }
            catch { }
        }

        private void tbMK_TextChanged(object sender, EventArgs e)
        {
            try
            {
                tbMK.ForeColor = Color.White;
            }
            catch { }
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            tbTaiKhoan.SelectAll();
        }

        private void tbMK_Click(object sender, EventArgs e)
        {
           tbMK. SelectAll();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Black;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Green;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(tbTaiKhoan.Text =="")
            
        }
      */
        private void btthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tbTaiKhoan_TextChanged(object sender, EventArgs e)
        {
            try
            {
                tbTaiKhoan.ForeColor = Color.White;
            }
            catch { }
        }

        private void tbMK_TextChanged(object sender, EventArgs e)
        {
            try
            {
                tbMK.ForeColor = Color.White;
            }
            catch { }
        }
        int demsolan =0;
        private void btLogin_Click(object sender, EventArgs e)
        {
            ketnoi = new classketnoi();
            string sql = "select MANVIEN, TenDangNhap , MatKhau ,QUYEN from NHANVIEN WHERE TenDangNhap =N'"+tbTaiKhoan.Text+"' AND MatKhau = N'"+tbMK.Text+"'";
            dt = ketnoi.load_du_lieu(sql);
            if(dt.Rows.Count >0)
            {
                string Quyen =dt.Rows[0][3].ToString();             
                string MaNV = dt.Rows[0][0].ToString();
                quyen.manhanvien = MaNV;
                quyen.quyentruycap = Quyen;  
                

                this.Hide();
                Form1 f = new Form1();
                f.Show();
            }
            else
            {
                MessageBox.Show("thong tin sai");
                demsolan++;
                if(demsolan == 5)
                {
                    MessageBox.Show("Quá 5 lần đăng nhập sai ,VUI LÒNG KHỞI ĐỘNG LẠI");
                    Application.Exit();
                }    
            }
        }

        private void btLogin_MouseEnter(object sender, EventArgs e)
        {
            btLogin.ForeColor = Color.Black;
        }

        private void btLogin_MouseLeave(object sender, EventArgs e)
        {
            btLogin.ForeColor = Color.Green;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
