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
    public partial class FormKhachHang : Form
    {
        public FormKhachHang()
        {
            InitializeComponent();
        }
        classketnoi ketnoi = new classketnoi();
        DataTable dt = new DataTable();
       
        private void hienthidulieu()
        {
          /*  string sql = "select * from KHACHHANG";
            dt = ketnoi.load_du_lieu(sql);
            dgv.DataSource = dt;
            dgvKhachHang.Columns[0].HeaderText = "Mã Khách Hàng";
            dgvKhachHang.Columns[1].HeaderText = "Tên Khách Hàng";
            dgvKhachHang.Columns[2].HeaderText = "Giới Tính";
            dgvKhachHang.Columns[3].HeaderText = "SĐT";
            dgvKhachHang.Columns[4].HeaderText = "Địa Chỉ";

            dgvKhachHang.AllowUserToAddRows = false;
            dgvKhachHang.EditMode = DataGridViewEditMode.EditProgrammatically;
          */        }
   /*   private void hienthidoituong()
       {
            
         string makh = this.tbmakh.Text;
         string tenkh = this.tbtenkh.Text;


         string gioitinhkh = (RDNAM.Checked ?this. RDNAM.Text :this.RDNU.Text);

         string sdtkh =this.tbsdtkh.Text;


         string diachikh = this.tbdiachikh.Text;
            kh = new KHACHHANG(makh,tenkh,gioitinhkh,sdtkh,diachikh);
       }*/
        
        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            hienthidulieu();
        }

        private void btthem_Click(object sender, EventArgs e)
        {

           /* hienthidoituong();
            if (ketnoi.insertdoituong(kh))
            {
                dt.Clear();
                hienthidulieu();
            }
            else
                MessageBox.Show("loi them");
           */
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            /*hienthidoituong();
            if (ketnoi.updatedoituong(kh))
            {
                dt.Clear();
                hienthidulieu();
            }
            else
            {
                MessageBox.Show("loi sua");
            }*/
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
           // string ma = dgvKhachHang.SelectedRows[0].Cells[0].Value.ToString();
            
            
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          /*  int vitri = e.RowIndex;
            if(vitri >=0)
            {
                tbmakh.Text = dt.Rows[vitri][0].ToString();
                tbtenkh.Text = dt.Rows[vitri][1].ToString();

                if (dt.Rows[vitri][2].ToString() == "NAM")
                    RDNAM.Checked = true;
                else
                    RDNU.Checked = true;
                tbsdtkh.Text = dt.Rows[vitri][3].ToString();
                tbdiachikh.Text = dt.Rows[vitri][4].ToString();
            }
            tbmakh.ReadOnly = true;
          */
        }
    }
}
