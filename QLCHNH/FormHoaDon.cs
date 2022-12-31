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
    public partial class FormHoaDon : Form
    {
        public FormHoaDon()
        {
            InitializeComponent();
        }
        classketnoi ketnoi = new classketnoi();
        DataTable dt = new DataTable();
        private void hienthiluoi()
        {
            //Select * from NHANVIEN
            // select * from HOADON
            string sql = "select * from HOADON";
            dt = ketnoi.load_du_lieu(sql);
            dgvhoadon.DataSource = dt;

         dgvhoadon.Columns[0].HeaderText = "Mã Hóa Đơn";
          dgvhoadon.Columns[1].HeaderText = "Mã Khách Hàng";
         dgvhoadon.Columns[2].HeaderText = "Mã Nhân Viên";
          dgvhoadon.Columns[3].HeaderText = "Ngày lập hóa đơn";
           dgvhoadon.Columns[4].HeaderText = "Thành tiền";
          dgvhoadon.Columns[5].HeaderText = "VAT";

            dgvhoadon.AllowUserToAddRows = false;
            dgvhoadon.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void hienthicombobox_makh()
        {
            string sql = "Select MAKH,TENKH from KHACHHANG";
            cbkhachhang.DataSource = ketnoi.load_du_lieu(sql);
            cbkhachhang.DisplayMember = "TENKH";
            cbkhachhang.ValueMember = "MAKH";

        }
        private void hienthi()
        {
            string sql = "Select MANVIEN , HOTEN from NHANVIEN";
            cbnhanvien.DataSource = ketnoi.load_du_lieu(sql);
            
            cbnhanvien.DisplayMember = "HOTEN";
            cbnhanvien.ValueMember = "MANVIEN";

        }


        private void FormHoaDon_Load(object sender, EventArgs e)
        {
            
            hienthiluoi();
            hienthicombobox_makh();
            hienthi();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FormKhachHang kh = new FormKhachHang();
            kh.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btthem_Click(object sender, EventArgs e)
        {

        }
    }
}
