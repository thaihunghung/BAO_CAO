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
using COMExcel = Microsoft.Office.Interop.Excel;

namespace QLCHNH
{
    public partial class HOADON : Form
    {
        
        public HOADON()
        {
            InitializeComponent();
        }
        classketnoi ketnoi = new classketnoi();
        DataTable dt;

        private void HOADON_Load(object sender, EventArgs e)
        {
            
            btthem.Enabled = true;
            btluu.Enabled = false;
            bthuy.Enabled = false;
            btin.Enabled = false;
            tbma.ReadOnly = true;


            tbTenNv.ReadOnly = true;
            tbtenkh.ReadOnly = true;
            //tbdiachikh.ReadOnly = true;
          //  tbsdtkh.ReadOnly = true;


            tbtennuochoa.ReadOnly = true;
            tbdongia.ReadOnly = true;
            tbthanhtien.ReadOnly = true;
            tbtongtien.ReadOnly = true;

            tbgiamgia.Text = "0";
            tbtongtien.Text = "0";
            ketnoi.FILLComboBox("select * from KHACHHANG", cbkhachhang, "MAKH", "MAKH");
            cbkhachhang.SelectedIndex = -1;
            ketnoi.FILLComboBox("select MANVIEN , HOTEN from NHANVIEN", cbnhanvien, "MANVIEN", "MANVIEN");
            cbnhanvien.SelectedIndex = -1;
            ketnoi.FILLComboBox("select MANUOCHOA,TENNUOCHOA FROM NUOCHOA WHERE GIABANDEXUAT >0", cbmanuochoa, "MANUOCHOA", "TENNUOCHOA");
            cbmanuochoa.SelectedIndex = -1;
            if (tbma.Text != "")
            {
                LoadinfoHoadon();
                bthuy.Enabled = true;
                btin.Enabled = true;
            }

            loadDataGridView();
        }

        private void loadDataGridView()
        {
            string sql;
            sql = "select a.MANUOCHOA ,b.TENNUOCHOA , a.SLNUOCHOABAN , b.GIABANDEXUAT , a.GiamGia , a.ThanhTien from CHITIETHOADON as a, NUOCHOA as b WHERE a.MAHOADON = N'" + tbma.Text + "'AND a.MANUOCHOA = b.MANUOCHOA ";
            dt = ketnoi.load_du_lieu(sql);
            dgvchitiethoadon.DataSource = dt;
            dgvchitiethoadon.Columns[0].HeaderText = "Mã Nước Hoa";
            dgvchitiethoadon.Columns[1].HeaderText = "Tên Nước Hoa ";
            dgvchitiethoadon.Columns[2].HeaderText = "Số Lượng ";
            dgvchitiethoadon.Columns[3].HeaderText = "Đơn Giá ";
            dgvchitiethoadon.Columns[4].HeaderText = "Giảm giá % ";
            dgvchitiethoadon.Columns[5].HeaderText = "Thành Tiền ";

            dgvchitiethoadon.AllowUserToAddRows = false;
            dgvchitiethoadon.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void LoadinfoHoadon()
        {
            string sql;
            sql = "select NGAYLAPHD FROM HOADON WHERE MAHOADON =N'" + tbma.Text + "'";
            timeNLAP.Value = DateTime.Parse(ketnoi.GetValues(sql));
            sql = "select MANVIEN FROM HOADON WHERE MAHOADON =N'" + tbma.Text + "'";
            cbnhanvien.SelectedValue = ketnoi.GetValues(sql);
            sql = "select MAKH FROM HOADON WHERE MAHOADON =N'" + tbma.Text + "'";
            cbkhachhang.SelectedValue = ketnoi.GetValues(sql);
            sql = "select TONGTIEN FROM HOADON WHERE MAHOADON =N'" + tbma.Text + "'";
            tbtongtien.Text = ketnoi.GetValues(sql);

          //  LBLBANGCHU.Text = "bang chu:" + ketnoi.ChuyenSoSangChuoi(Double.Parse(tbtongtien.Text));
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            bthuy.Enabled = false;
            btluu.Enabled = true;
            btin.Enabled = false;
            btthem.Enabled = false;
            resetVaLues();
            tbma.Text = ketnoi.CreateKey("HS");
            loadDataGridView();
        }
        private void resetVaLuesNuocHoa()
        {
            cbmanuochoa.Text = "";
            tbsl.Text = "";
            tbgiamgia.Text = "0";
            tbthanhtien.Text = "0";
        }
        private void resetVaLues()
        {
            tbma.Text = "";
            timeNLAP.Value = DateTime.Now;
            cbnhanvien.Text = "";
            cbkhachhang.Text = "";
            tbtongtien.Text = "0";
           // LBLBANGCHU.Text = "Bang chu : ";
            cbmanuochoa.Text = "";
            tbsl.Text = "";
            tbgiamgia.Text = "0";
            tbthanhtien.Text = "0";
        }

        private void btluu_Click(object sender, EventArgs e)
        {
            string sql;
            double sl, slcon, tong, tongmoi;

            sql = "select MAHOADON FROM HOADON WHERE MAHOADON='" + tbma.Text + "'";
            if (!ketnoi.CheckKey(sql))
            {
              /*  if (cbnhanvien.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập mã nhân viên ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbnhanvien.Focus();
                    return;
                }*/
                if (cbkhachhang.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập mã khách hàng ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbkhachhang.Focus();
                    return;
                }
                if (cbmanuochoa.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập mã nước hoa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbmanuochoa.Focus();
                    return;
                }
                sql = "INSERT INTO HOADON (MAHOADON,MAKH,MANVIEN,NGAYLAPHD,TONGTIEN)VALUES ('" + tbma.Text.Trim() + "','" + cbkhachhang.SelectedValue.ToString() + "','" + quyen.manhanvien + "','" + timeNLAP.Value + "'," + tbtongtien.Text + ")";
                ketnoi.thaotaclenh(sql);
            }
            if (cbmanuochoa.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nước hoa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbmanuochoa.Focus();
                return;
            }
            if ((tbsl.Text.Trim().Length == 0) || (tbsl.Text == "0"))
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbsl.Text = "";
                tbsl.Focus();
                return;
            }
            if (tbgiamgia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập giam gia ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                tbgiamgia.Focus();
                return;
            }


            sql = "SELECT MANUOCHOA FROM CHITIETHOADON WHERE MANUOCHOA = '" + cbmanuochoa.SelectedValue + "' AND MAHOADON='" + tbma.Text.Trim() + "'";
            if (ketnoi.CheckKey(sql))
            {
                MessageBox.Show("Mã hàng này đã có, bạn phải nhập mã hàng khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                resetVaLuesNuocHoa();
                cbmanuochoa.Focus();
                return;
            };
            sl = Convert.ToDouble(ketnoi.GetValues("SELECT SOLUONGTON FROM NUOCHOA WHERE MANUOCHOA =N'" + cbmanuochoa.SelectedValue.ToString() + "'"));

            if (Convert.ToDouble(tbsl.Text) > sl)
            {
                MessageBox.Show("Số Lượng mặt hàng này chỉ còn" + sl, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbsl.Text = "";
                tbsl.Focus();
                return;
            }
            sql = "INSERT INTO CHITIETHOADON(MANUOCHOA,MAHOADON , SLNUOCHOABAN ,DonGia , GiamGia ,ThanhTien) VALUES (N'" + cbmanuochoa.SelectedValue + "','" + tbma.Text.Trim() + "'," + tbsl.Text + "," + tbdongia.Text + "," + tbgiamgia.Text + "," + tbthanhtien.Text + ")";
            ketnoi.thaotaclenh(sql);

            loadDataGridView();

            // cap nhat lai so luong nuoc hoa bang hoa don

            slcon = sl - Convert.ToDouble(tbsl.Text);


            sql = "UPDATE NUOCHOA SET SOLUONGTON=" + slcon + " WHERE MANUOCHOA =N'" + cbmanuochoa.SelectedValue + "'";
            ketnoi.thaotaclenh(sql);

            // cap nhat lai tong tien cho hoa don ban
            tong = Convert.ToDouble(ketnoi.GetValues("SELECT TONGTIEN FROM HOADON WHERE MAHOADON = N'" + tbma.Text + "'"));

            tongmoi = tong + Convert.ToDouble(tbthanhtien.Text);

            sql = "UPDATE HOADON SET TONGTIEN =" + tongmoi + " WHERE MAHOADON =N'" + tbma.Text + "'";
            ketnoi.thaotaclenh(sql);

            tbtongtien.Text = tongmoi.ToString();
         //   LBLBANGCHU.Text = "BẰNG CHỮ: " + ketnoi.ChuyenSoSangChuoi(Double.Parse(tongmoi.ToString()));
            // kiem tra hang ton 

            // loadDataGridView();
            resetVaLuesNuocHoa();
            bthuy.Enabled = true;
            btthem.Enabled = true;
            btin.Enabled = true;
        }

        private void tbsl_TextChanged(object sender, EventArgs e)
        {
            double tt, sl, dg, gg;
            if (tbsl.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(tbsl.Text);

            if (tbgiamgia.Text == "")
                gg = 0;
            else
                gg = Convert.ToDouble(tbgiamgia.Text);

            if (tbdongia.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(tbdongia.Text);

            tt = sl * dg - sl * dg * gg / 100;
            tbthanhtien.Text = tt.ToString();
        }

        private void tbgiamgia_TextChanged(object sender, EventArgs e)
        {
            double tt, sl, dg, gg;
            if (tbsl.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(tbsl.Text);

            if (tbgiamgia.Text == "")
                gg = 0;
            else
                gg = Convert.ToDouble(tbgiamgia.Text);

            if (tbdongia.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(tbdongia.Text);

            tt = sl * dg - sl * dg * gg / 100;
            tbthanhtien.Text = tt.ToString();
        }

        private void btkiem_Click(object sender, EventArgs e)
        {
            if (cbtimkiem.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã hóa Đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbtimkiem.Focus();
                return;
            }
            tbma.Text = cbtimkiem.Text;
            LoadinfoHoadon();
            loadDataGridView();
            bthuy.Enabled = true;
            btluu.Enabled = true;
            btin.Enabled = true;
            cbtimkiem.SelectedIndex = -1;
        }

        private void cbtimkiem_DropDown(object sender, EventArgs e)
        {
            ketnoi.FILLComboBox("select MAHOADON from HOADON", cbtimkiem, "MAHOADON", "MAHOADON");
            cbtimkiem.SelectedIndex = -1;
        }

        private void btin_Click(object sender, EventArgs e)
        {
            ketnoi = new classketnoi();
            // Khởi động chương trình Excel
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook; //Trong 1 chương trình Excel có nhiều Workbook
            COMExcel.Worksheet exSheet; //Trong 1 Workbook có nhiều Worksheet
            COMExcel.Range exRange;
            string sql;
            int hang = 0, cot = 0;
            DataTable tblThongtinHD, tblThongtinHang;
            exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            exSheet = exBook.Worksheets[1];
            // Định dạng chung
            exRange = exSheet.Cells[1, 1];
            exRange.Range["A1:Z300"].Font.Name = "Times new roman"; //Font chữ
            exRange.Range["A1:B3"].Font.Size = 10;
            exRange.Range["A1:B3"].Font.Bold = true;
            exRange.Range["A1:B3"].Font.ColorIndex = 5; //Màu xanh da trời
            exRange.Range["A1:A1"].ColumnWidth = 7;
            exRange.Range["B1:B1"].ColumnWidth = 15;
            exRange.Range["A1:B1"].MergeCells = true;
            exRange.Range["A1:B1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A1:B1"].Value = "Shop H.S";
            exRange.Range["A2:B2"].MergeCells = true;
            exRange.Range["A2:B2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:B2"].Value = "Vinh Kim - Trà Vinh";
            exRange.Range["A3:B3"].MergeCells = true;
            exRange.Range["A3:B3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A3:B3"].Value = "Điện thoại: 0363215490";
            exRange.Range["C2:E2"].Font.Size = 16;
            exRange.Range["C2:E2"].Font.Bold = true;
            exRange.Range["C2:E2"].Font.ColorIndex = 3; //Màu đỏ
            exRange.Range["C2:E2"].MergeCells = true;
            exRange.Range["C2:E2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C2:E2"].Value = "HÓA ĐƠN BÁN";
            // Biểu diễn thông tin chung của hóa đơn bán
            sql = "SELECT a.MAHOADON, a.NGAYLAPHD, a.TONGTIEN, b.TENKH, b.DIACHIKH, b.SDTKH, c.HOTEN FROM HOADON AS a, KHACHHANG AS b, NHANVIEN AS c WHERE a.MAHOADON = N'" + tbma.Text + "' AND a.MAKH = b.MAKH AND a.MANVIEN = c.MANVIEN";
            tblThongtinHD = ketnoi.load_du_lieu(sql);
            exRange.Range["B6:C9"].Font.Size = 12;
            exRange.Range["B6:B6"].Value = "Mã hóa đơn:";
            exRange.Range["C6:E6"].MergeCells = true;
            exRange.Range["C6:E6"].Value = tblThongtinHD.Rows[0][0].ToString();
            exRange.Range["B7:B7"].Value = "Khách hàng:";
            exRange.Range["C7:E7"].MergeCells = true;
            exRange.Range["C7:E7"].Value = tblThongtinHD.Rows[0][3].ToString();
            exRange.Range["B8:B8"].Value = "Địa chỉ:";
            exRange.Range["C8:E8"].MergeCells = true;
            exRange.Range["C8:E8"].Value = tblThongtinHD.Rows[0][4].ToString();
            exRange.Range["B9:B9"].Value = "Điện thoại:";
            exRange.Range["C9:E9"].MergeCells = true;
            exRange.Range["C9:E9"].Value = tblThongtinHD.Rows[0][5].ToString();
            //Lấy thông tin các mặt hàng
            sql = "SELECT b.TENNUOCHOA, a.SLNUOCHOABAN, b.GIABANDEXUAT, a.GiamGia, a.ThanhTien " +
                  "FROM CHITIETHOADON AS a , NUOCHOA AS b WHERE a.MAHOADON = N'" +
                  tbma.Text + "' AND a.MANUOCHOA = b.MANUOCHOA";
            tblThongtinHang = ketnoi.load_du_lieu(sql);
            //Tạo dòng tiêu đề bảng
            exRange.Range["A11:F11"].Font.Bold = true;
            exRange.Range["A11:F11"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C11:F11"].ColumnWidth = 12;
            exRange.Range["A11:A11"].Value = "STT";
            exRange.Range["B11:B11"].Value = "Tên Nước Hoa";
            exRange.Range["C11:C11"].Value = "Số lượng";
            exRange.Range["D11:D11"].Value = "Đơn giá";
            exRange.Range["E11:E11"].Value = "Giảm giá";
            exRange.Range["F11:F11"].Value = "Thành tiền";
            for (hang = 0; hang < tblThongtinHang.Rows.Count; hang++)
            {
                //Điền số thứ tự vào cột 1 từ dòng 12
                exSheet.Cells[1][hang + 12] = hang + 1;
                for (cot = 0; cot < tblThongtinHang.Columns.Count; cot++)
                //Điền thông tin hàng từ cột thứ 2, dòng 12
                {
                    exSheet.Cells[cot + 2][hang + 12] = tblThongtinHang.Rows[hang][cot].ToString();
                    if (cot == 3) exSheet.Cells[cot + 2][hang + 12] = tblThongtinHang.Rows[hang][cot].ToString() + "%";
                }
            }
            exRange = exSheet.Cells[cot][hang + 14];
            exRange.Font.Bold = true;
            exRange.Value2 = "Tổng tiền:";
            exRange = exSheet.Cells[cot + 1][hang + 14];
            exRange.Font.Bold = true;
            exRange.Value2 = tblThongtinHD.Rows[0][2].ToString();
            exRange = exSheet.Cells[1][hang + 15]; //Ô A1 
            exRange.Range["A1:F1"].MergeCells = true;
            exRange.Range["A1:F1"].Font.Bold = true;
            exRange.Range["A1:F1"].Font.Italic = true;
            exRange.Range["A1:F1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignRight;
            exRange.Range["A1:F1"].Value = "Bằng chữ: " + ketnoi.ChuyenSoSangChuoi(Double.Parse(tblThongtinHD.Rows[0][2].ToString()));
            exRange = exSheet.Cells[4][hang + 17]; //Ô A1 
            exRange.Range["A1:C1"].MergeCells = true;
            exRange.Range["A1:C1"].Font.Italic = true;
            exRange.Range["A1:C1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            DateTime d = Convert.ToDateTime(tblThongtinHD.Rows[0][1]);
            exRange.Range["A1:C1"].Value = "Trà Vinh, ngày " + d.Day + " tháng " + d.Month + " năm " + d.Year;
            exRange.Range["A2:C2"].MergeCells = true;
            exRange.Range["A2:C2"].Font.Italic = true;
            exRange.Range["A2:C2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:C2"].Value = "Nhân viên bán hàng";
            exRange.Range["A6:C6"].MergeCells = true;
            exRange.Range["A6:C6"].Font.Italic = true;
            exRange.Range["A6:C6"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A6:C6"].Value = tblThongtinHD.Rows[0][6];
            exSheet.Name = "Hóa đơn nhập";
            exApp.Visible = true;
        }

        private void cbmanuochoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql;
            sql = "select TENNUOCHOA FROM NUOCHOA WHERE MANUOCHOA ='" + cbmanuochoa.SelectedValue + "'";
            tbtennuochoa.Text = ketnoi.GetValues(sql);
            sql = "select GIABANDEXUAT FROM NUOCHOA WHERE MANUOCHOA = '" + cbmanuochoa.SelectedValue + "'";
            tbdongia.Text = ketnoi.GetValues(sql);
        }

        private void cbnhanvien_SelectedIndexChanged(object sender, EventArgs e)
        {
           /* if (cbnhanvien.Text == "")
            {
                this.tbTenNv.Text = "";
            }
            string sql;
            sql = "select HOTEN FROM NHANVIEN WHERE MANVIEN ='" + cbnhanvien.SelectedValue + "'";
            tbTenNv.Text = ketnoi.GetValues(sql);*/
            
        }

        private void cbkhachhang_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql;
            sql = "select TENKH from KHACHHANG WHERE MAKH='" + cbkhachhang.SelectedValue + "'";
            tbtenkh.Text = ketnoi.GetValues(sql);
            
        }

        private void bthuy_Click(object sender, EventArgs e)
        {
            double sl, slcon, slxoa; string sql;
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                sql = "SELECT MANUOCHOA,SLNUOCHOABAN FROM CHITIETHOADON WHERE MAHOADON = N'" + tbma.Text + "'";
                DataTable tblHang = ketnoi.load_du_lieu(sql);
                //doc cai ma hang va so luong trong chitiethoadon where

                for (int hang = 0; hang <= tblHang.Rows.Count - 1; hang++)
                {
                    // Cập nhật lại số lượng cho các mặt hàng
                    sl = Convert.ToDouble(ketnoi.GetValues("SELECT SOLUONGTON FROM NUOCHOA WHERE MANUOCHOA = N'" + tblHang.Rows[hang][0].ToString() + "'"));
                    slxoa = Convert.ToDouble(tblHang.Rows[hang][1].ToString());
                    slcon = sl + slxoa;
                    sql = "UPDATE NUOCHOA SET SOLUONGTON =" + slcon + " WHERE MANUOCHOA= N'" + tblHang.Rows[hang][0].ToString() + "'";
                    ketnoi.thaotaclenh(sql);
                }

                //Xóa chi tiết hóa đơn
                sql = "DELETE CHITIETHOADON WHERE MAHOADON=N'" + tbma.Text + "'";
                ketnoi.thaotaclenh(sql);

                //Xóa hóa đơn
                sql = "DELETE HOADON WHERE MAHOADON=N'" + tbma.Text + "'";
                ketnoi.thaotaclenh(sql);
                resetVaLues();
                bthuy.Enabled = false;
                btin.Enabled = false;
                loadDataGridView();
              /*  ResetValues();
                LoadDataGridView();
                btnXoa.Enabled = false;
                btnInHoaDon.Enabled = false;
              */
            }
        }
        private void dgvchitiethoadon_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            /*"select a.MANUOCHOA ,b.TENNUOCHOA , a.SLNUOCHOABAN , b.GIABANDEXUAT , a.GiamGia , a.ThanhTien 
             * from CHITIETHOADON as a, NUOCHOA as b 
             * WHERE a.MAHOADON = N'" + tbma.Text + "'AND a.MANUOCHOA = b.MANUOCHOA ";*/

            string MaHangxoa,sql;
            Double ThanhTienxoa, SoLuongxoa, sl, slcon, tong, tongmoi;
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if ((MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                //Xóa hàng và cập nhật lại số lượng hàng 
                MaHangxoa = dgvchitiethoadon.CurrentRow.Cells["MANUOCHOA"].Value.ToString();
                SoLuongxoa = Convert.ToDouble(dgvchitiethoadon.CurrentRow.Cells["SLNUOCHOABAN"].Value.ToString());
                ThanhTienxoa = Convert.ToDouble(dgvchitiethoadon.CurrentRow.Cells["ThanhTien"].Value.ToString());
                sql = "DELETE CHITIETHOADON WHERE MAHOADON=N'" + tbma.Text + "' AND MANUOCHOA = N'" + MaHangxoa + "'";
                ketnoi.thaotaclenh(sql);
                // Cập nhật lại số lượng cho các mặt hàng
                sl = Convert.ToDouble(ketnoi.GetValues("SELECT SOLUONGTON FROM NUOCHOA WHERE MANUOCHOA = N'" + MaHangxoa + "'"));
                slcon = sl + SoLuongxoa;
                sql = "UPDATE NUOCHOA SET SOLUONGTON =" + slcon + " WHERE MANUOCHOA= N'" +  MaHangxoa + "'";
                ketnoi.thaotaclenh(sql);
                // Cập nhật lại tổng tiền cho hóa đơn bán
                tong = Convert.ToDouble(ketnoi.GetValues("SELECT TONGTIEN FROM HOADON WHERE MAHOADON = N'" + tbma.Text + "'"));
                tongmoi = tong - ThanhTienxoa;
                sql = "UPDATE HOADON SET TONGTIEN =" + tongmoi + " WHERE MAHOADON = N'" + tbma.Text + "'";
                ketnoi.thaotaclenh(sql);
                tbtongtien.Text = tongmoi.ToString();
                //lblBangChu.Text = "Bằng chữ: " + Functions.ChuyenSoSangChu(tongmoi.ToString());
                loadDataGridView();
            }

             
        }

        private void tbsl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else e.Handled = true;
        }
    }
    }

