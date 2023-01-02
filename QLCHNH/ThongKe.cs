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
    public partial class ThongKe : Form
    {
        public ThongKe()
        {
            InitializeComponent();
        }
        classketnoi kn = new classketnoi();
        DataTable dt = new DataTable();
        string sql;
        private void hienthidulieuNgay()
        {
            sql = "select MAHOADON,NGAYLAPHD,TONGTIEN from HOADON WHERE NGAYLAPHD='" + time.Value + "'";
            dt = kn.load_du_lieu(sql);
            dgvhoadon.DataSource = dt;
            dgvhoadon.Columns[0].HeaderText = "Mã Hóa Đơn"
;
            dgvhoadon.Columns[1].HeaderText = "Ngày Lập";
            dgvhoadon.Columns[2].HeaderText = "Tổng Tiền";
            dgvhoadon.AllowUserToAddRows = false;
            dgvhoadon.EditMode = DataGridViewEditMode.EditProgrammatically;
            sql = "select MAPHIEUNHAP,NGAYNHAP,TONGTIEN from PHIEUNHAP WHERE NGAYNHAP='" + time.Value + "'";
            dt = kn.load_du_lieu(sql);
            dgvphieunhap.DataSource = dt;
            dgvphieunhap.Columns[0].HeaderText = "Mã Phiếu Nhập"
;
            dgvphieunhap.Columns[1].HeaderText = "Ngày Nhập";
            dgvphieunhap.Columns[2].HeaderText = "Tổng Tiền";
            dgvphieunhap.AllowUserToAddRows = false;
            dgvphieunhap.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void hienthidulieuThang()
        {
            sql = "select MAHOADON,NGAYLAPHD,TONGTIEN from HOADON where NGAYLAPHD > '" + time1.Value + "' and NGAYLAPHD < '" + time2.Value + "'";
            dt = kn.load_du_lieu(sql);
            dgvhoadon.DataSource = dt;
            dgvhoadon.Columns[0].HeaderText = "Mã Hóa Đơn"
;
            dgvhoadon.Columns[1].HeaderText = "Ngày Lập";
            dgvhoadon.Columns[2].HeaderText = "Tổng Tiền";
            dgvhoadon.AllowUserToAddRows = false;
            dgvhoadon.EditMode = DataGridViewEditMode.EditProgrammatically; 

            sql = "select MAPHIEUNHAP,NGAYNHAP,TONGTIEN from PHIEUNHAP where NGAYNHAP > '" + time1.Value + "' and NGAYNHAP < '" + time2.Value + "'";
            dt = kn.load_du_lieu(sql);
            dgvphieunhap.DataSource = dt;
            dgvphieunhap.Columns[0].HeaderText = "Mã Phiếu Nhập"
;
            dgvphieunhap.Columns[1].HeaderText = "Ngày Nhập";
            dgvphieunhap.Columns[2].HeaderText = "Tổng Tiền";
            dgvphieunhap.AllowUserToAddRows = false;
            dgvphieunhap.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void hienthidulieuNam()
        {
            sql = "select MAHOADON,NGAYLAPHD,TONGTIEN from HOADON ";
            dt = kn.load_du_lieu(sql);
            dgvhoadon.DataSource = dt;
            dgvhoadon.Columns[0].HeaderText = "Mã Hóa Đơn"
;
            dgvhoadon.Columns[1].HeaderText = "Ngày Lập";
            dgvhoadon.Columns[2].HeaderText = "Tổng Tiền";
            dgvhoadon.AllowUserToAddRows = false;
            dgvhoadon.EditMode = DataGridViewEditMode.EditProgrammatically;

            sql = "select MAPHIEUNHAP,NGAYNHAP,TONGTIEN from PHIEUNHAP ";
            dt = kn.load_du_lieu(sql);
            dgvphieunhap.DataSource = dt;
            dgvphieunhap.Columns[0].HeaderText = "Mã Phiếu Nhập"
;
            dgvphieunhap.Columns[1].HeaderText = "Ngày Nhập";
            dgvphieunhap.Columns[2].HeaderText = "Tổng Tiền";
            dgvphieunhap.AllowUserToAddRows = false;
            dgvphieunhap.EditMode = DataGridViewEditMode.EditProgrammatically;

        }
        private void dgvhoadon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;


            DataGridViewRow row = dgvhoadon.Rows[e.RowIndex];
            string ma;
            ma = row.Cells[0].Value.ToString();

            sql = "select a.MANUOCHOA ,b.TENNUOCHOA , a.SLNUOCHOABAN , b.GIABANDEXUAT , a.GiamGia , a.ThanhTien from CHITIETHOADON as a, NUOCHOA as b WHERE a.MAHOADON = N'" + ma + "'AND a.MANUOCHOA = b.MANUOCHOA ";
            dt = kn.load_du_lieu(sql);
            dgvchitiethoadon.DataSource = dt;
            
            dgvchitiethoadon.Columns[0].HeaderText = "Mã Nước Hoa";
            dgvchitiethoadon.Columns[1].HeaderText = "Tên Nước Hoa ";
            dgvchitiethoadon.Columns[2].HeaderText = "Số Lượng ";
            dgvchitiethoadon.Columns[3].HeaderText = "Đơn Giá ";
            dgvchitiethoadon.Columns[4].HeaderText = "Giảm giá % ";
            dgvchitiethoadon.Columns[5].HeaderText = "Thành Tiền ";

            dgvchitiethoadon.AllowUserToAddRows = false;
            dgvchitiethoadon.EditMode = DataGridViewEditMode.EditProgrammatically;

            lbketquahoadon.Text = "Chi Tiết Nước Hoa Của Lô Hàng Đã Nhập " + ma;
        }



        private void dgvphieunhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;


            DataGridViewRow row = dgvphieunhap.Rows[e.RowIndex];
            string ma;
            ma = row.Cells[0].Value.ToString();


            // sql = "select a.MANUOCHOA ,b.TENNUOCHOA , a.SLNUOCHOABAN , b.GIABANDEXUAT , a.GiamGia , a.ThanhTien from CHITIETHOADON as a, NUOCHOA as b WHERE a.MAHOADON = N'" + ma + "'AND a.MANUOCHOA = b.MANUOCHOA ";
            string sql = "select b.MANUOCHOA , a.TENNUOCHOA ,b.SLNUOCHOANHAP , b.MACHIETKHAU ,b.DONGIANHAP , b.THANHTIENNHAP FROM NUOCHOA AS a, CHITIETNHAP AS b Where b.MAPHIEUNHAP ='" + ma + "' AND a.MANUOCHOA = b.MANUOCHOA ";

            dt = kn.load_du_lieu(sql);
            dgvchitietphieunhap.DataSource = dt;
            dgvchitietphieunhap.Columns[0].HeaderText = "Mã Nước Hoa";
            dgvchitietphieunhap.Columns[1].HeaderText = "Tên Nước Hoa ";
            dgvchitietphieunhap.Columns[2].HeaderText = "Số Lượng ";
            dgvchitietphieunhap.Columns[3].HeaderText = "Giá Bán";
            dgvchitietphieunhap.Columns[4].HeaderText = "Giảm giá % ";
            dgvchitietphieunhap.Columns[5].HeaderText = "Thành Tiền ";

            dgvchitietphieunhap.AllowUserToAddRows = false;
            dgvchitietphieunhap.EditMode = DataGridViewEditMode.EditProgrammatically;

            labelnhap.Text = "Chi Tiết Các Nước Hoa Đã Bán Của Hóa Đơn Đã Chọn " + ma;
        }


        private void btthongke_Click(object sender, EventArgs e)
        {


            if (checkNgay.Checked == true)
            {
                
                hienthidulieuNgay();
                sql = "select * from HOADON WHERE NGAYLAPHD='" + time.Value + "'";
                DataTable hung = kn.load_du_lieu(sql);
                float tongcong = 0;
                for (int hang = 0; hang <= hung.Rows.Count - 1; hang++)
                {
                    sql = "select TONGTIEN FROM HOADON WHERE MAHOADON ='" + hung.Rows[hang][0].ToString() + "'";
                    float tong = float.Parse(kn.GetValues(sql));

                    tongcong = tongcong + tong;

                }
                bttonghoadonkhongchietkhau.Text = tongcong.ToString();


                sql = "select * from PHIEUNHAP WHERE NGAYNHAP='" + time.Value + "'";
                DataTable hung1 = kn.load_du_lieu(sql);
                float tongnhap = 0;
                for (int hang = 0; hang <= hung1.Rows.Count - 1; hang++)
                {
                    sql = "select TONGTIEN FROM PHIEUNHAP WHERE MAPHIEUNHAP ='" + hung1.Rows[hang][0].ToString() + "'";
                    float nhap = float.Parse(kn.GetValues(sql));

                    tongnhap = tongnhap + nhap;

                }
                tbnhap.Text = tongnhap.ToString();



            }
            else if (checkThang.Checked == true)
            {
                hienthidulieuThang();
                sql = "select * from HOADON where NGAYLAPHD > '" + time1.Value + "' and NGAYLAPHD < '" + time2.Value + "'";
                DataTable hung = kn.load_du_lieu(sql);
                float tongcong = 0;
                for (int hang = 0; hang <= hung.Rows.Count - 1; hang++)
                {
                    sql = "select TONGTIEN FROM HOADON WHERE MAHOADON ='" + hung.Rows[hang][0].ToString() + "'";
                    float tong = float.Parse(kn.GetValues(sql));

                    tongcong = tongcong + tong;

                }
                bttonghoadonkhongchietkhau.Text = tongcong.ToString();

                sql = "select * from PHIEUNHAP WHERE NGAYNHAP > '" + time1.Value + "' and NGAYNHAP < '" + time2.Value + "'";
                DataTable hung1 = kn.load_du_lieu(sql);
                float tongnhap = 0;
                for (int hang = 0; hang <= hung1.Rows.Count - 1; hang++)
                {
                    sql = "select TONGTIEN FROM PHIEUNHAP WHERE MAPHIEUNHAP ='" + hung1.Rows[hang][0].ToString() + "'";
                    float nhap = float.Parse(kn.GetValues(sql));

                    tongnhap = tongnhap + nhap;

                }
                tbnhap.Text = tongnhap.ToString();
            }
            else
            {
                hienthidulieuNam();
                sql = "select * from HOADON ";
               // string sql2;
               // sql2="select a.SLNUOCHOABAN , b.GIABANDEXUAT from CHITIETHOADON as a, NUOCHOA as b WHERE a.MAHOADON = N'" + ma + "'AND a.MANUOCHOA = b.MANUOCHOA ";
                DataTable hung = kn.load_du_lieu(sql);
                
                float tongcong = 0;
                for (int hang = 0; hang <= hung.Rows.Count - 1; hang++)
                {
                    sql = "select TONGTIEN FROM HOADON WHERE MAHOADON ='" + hung.Rows[hang][0].ToString() + "'";
                    float tong = float.Parse(kn.GetValues(sql));

                    tongcong = tongcong + tong;
                  
                }
                bttonghoadonkhongchietkhau.Text = tongcong.ToString();


                sql = "select * from PHIEUNHAP";
                DataTable hung1 = kn.load_du_lieu(sql);
                float tongnhap = 0;
                for (int hang = 0; hang <= hung1.Rows.Count - 1; hang++)
                {
                    sql = "select TONGTIEN FROM PHIEUNHAP WHERE MAPHIEUNHAP ='" + hung1.Rows[hang][0].ToString() + "'";
                    float nhap = float.Parse(kn.GetValues(sql));

                    tongnhap = tongnhap + nhap;

                }
                tbnhap.Text = tongnhap.ToString();
            }
            double ketqua = double.Parse(tbnhap.Text) - double.Parse(bttonghoadonkhongchietkhau.Text);
           if(double.Parse(bttonghoadonkhongchietkhau.Text)==0)
           {
                tbdoanhthu.Text = "-" + ketqua.ToString();
               
           }
           else
                tbdoanhthu.Text = ketqua.ToString();

        }

      

       
        private void checkNgay_CheckedChanged(object sender, EventArgs e)
        {
            checkThang.Checked = false;
            checkNam.Checked = false;

        }

        private void checkThang_CheckedChanged(object sender, EventArgs e)
        {
            checkNam.Checked = false;
            checkNgay.Checked = false;
        }

        private void checkNam_CheckedChanged(object sender, EventArgs e)
        {
            checkNgay.Checked = false;
            checkThang.Checked = false;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        private void ThongKe_Load(object sender, EventArgs e)
        {

        }

        private void tbnhap_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
/*using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reportCryto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        classketnoi kn = new classketnoi();
        DataTable dt = new DataTable();
        private void btnThongke_Click(object sender, EventArgs e)
        {
            kn = new classketnoi();
            string sql;
            if(rdbHDB.Checked == false && rdbHDN.Checked == false)
            {
                MessageBox.Show("Chọn đối tượng");
            }
            else
            {
                if (rdbHDB.Checked == true)
                {
                   
                    sql = "select * from HOADON where NGAYLAPHD = '" + dateTimePicker1.Value + "'";
                    dt = kn.load_du_lieu(sql);

                    dgvTimkiem.DataSource = dt;
                }
                if (rdbHDN.Checked == true)
                {
                    
                    sql = "select * from PHIEUNHAP where NGAYNHAP= '" + dateTimePicker1.Value + "'";
                    dt = kn.load_du_lieu(sql);

                    dgvTimkiem.DataSource = dt;

                }
            }
        }

        private void btthang_Click(object sender, EventArgs e)
        {
            string sql;
            if (rdbHDB.Checked == false && rdbHDN.Checked == false)
            {
                MessageBox.Show("Chọn đối tượng");
            }
            else
            {
                if (rdbHDB.Checked == true)
                {

                   
                    sql = "select * from HOADON where NGAYLAPHD > '" + tungay.Value + "' and NGAYLAPHD < '" + denngay.Value + "'";
                    dt = kn.load_du_lieu(sql);

                    dgvTimkiem.DataSource = dt;
                }
                if (rdbHDN.Checked == true)
                {
                    
                    sql = "select * from PHIEUNHAP where NGAYNHAP > '" + tungay.Value + "' and NGAYNHAP < '" + denngay.Value + "'";

                    dt = kn.load_du_lieu(sql);

                    dgvTimkiem.DataSource = dt;
                }
            }
        }

        private void tong_Click(object sender, EventArgs e)
        {
            int sl = int.Parse(dgvTimkiem.RowCount.ToString());
            int sl2 = sl - 1;
            tong.Text = sl2.ToString();
        }

        private void bttong_Click(object sender, EventArgs e)
        {
            if (dgvTimkiem.Rows.Count != 0)
            {
                int sl = int.Parse(dgvTimkiem.RowCount.ToString());
                int sl2 = sl - 1;
                tong.Text = sl2.ToString();
            }
        }

        private void btnam_Click(object sender, EventArgs e)
        {
            string sql;
            if (mtbnam.Text != "")
            {
                if (rdbHDB.Checked == false && rdbHDN.Checked == false)
                {
                    MessageBox.Show("Chọn loại hóa đơn");
                }
                else
                {
                    if (mtbnam.Text == "2022")
                    {
                        if (rdbHDB.Checked == true)
                        {


                            sql = "select * from HOADON ";
                            dt = kn.load_du_lieu(sql);

                            dgvTimkiem.DataSource = dt;
                        }
                        if (rdbHDN.Checked == true)
                        {

                            sql = "select * from PHIEUNHAP ";
                            dt = kn.load_du_lieu(sql);

                            dgvTimkiem.DataSource = dt;
                        }
                    }
                    else
                    {

                        sql = "select * from HOADON where NGAYLAPHD = '" + datahide.Value + "'";
                        dt = kn.load_du_lieu(sql);

                        dgvTimkiem.DataSource = dt;
                    }
                }
            }
            else
            {
                MessageBox.Show("Nhập năm !");
            }
            }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvTimkiem.Rows.Count != 0)
            {
                int sc = dgvTimkiem.Rows.Count;
                double thanhtien = 0;
                for (int i = 0; i < sc - 1; i++)
                {
                    thanhtien += float.Parse(dgvTimkiem.Rows[i].Cells["TONGTIEN"].Value.ToString());
                    txtdoanhthu.Text = thanhtien.ToString();
                }
            }
            else { txtdoanhthu.Text = "0"; }
        }
    }
}

 */
