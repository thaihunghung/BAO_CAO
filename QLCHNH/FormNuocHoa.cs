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
    public partial class FormNuocHoa : Form
    {
        public FormNuocHoa()
        {
            InitializeComponent();
        }

       

        classketnoi ketnoi = new classketnoi();
        DataTable dt = new DataTable();
     //   NuocHoa nuoc;
        private void hienthiluoi()
        {
            string sql = "select * from NUOCHOA";
            dt = ketnoi.load_du_lieu(sql);
            dgvNuocHoa.DataSource = dt;
            dgvNuocHoa.Columns[0].HeaderText = "Mã Nước Hoa";
            dgvNuocHoa.Columns[1].HeaderText = "Mã Loại";
            dgvNuocHoa.Columns[2].HeaderText = "Mã Thương Hiệu";
            dgvNuocHoa.Columns[3].HeaderText = "Tên Nước Hoa";
            dgvNuocHoa.Columns[4].HeaderText = "Số Lượng Tồn";
            dgvNuocHoa.Columns[5].HeaderText = "Gía Bán Đề Xuất";
            dgvNuocHoa.Columns[6].HeaderText = "Dung Tích";

            dgvNuocHoa.AllowUserToAddRows = false;
            dgvNuocHoa.EditMode = DataGridViewEditMode.EditProgrammatically;
        }      
        private void FormNuocHoa_Load(object sender, EventArgs e)
        {
            hienthiluoi();
            ketnoi.FILLComboBox("select * from THUONGHIEU",cbthuonghieu,"MATHUONGHIEU", "MATHUONGHIEU");
            ketnoi.FILLComboBox("select * from LOAI",cbloai, "MALOAI", "TENLOAI");
            cbloai.SelectedIndex = -1;
            cbthuonghieu.SelectedIndex = -1;           
        }

        private void btthem_Click(object sender, EventArgs e)
        {
           
                       
        }

        private void btsua_Click(object sender, EventArgs e)
        {
        
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
           
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvNuocHoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vitri = e.RowIndex;
            if(vitri >=0)
            {
                tbma.Text = dt.Rows[vitri][0].ToString();

                cbloai.SelectedValue = dt.Rows[vitri][1].ToString();

                cbthuonghieu.SelectedValue = dt.Rows[vitri][2].ToString();

                tbten.Text = dt.Rows[vitri][3].ToString();

                tbsoluong.Text = dt.Rows[vitri][4].ToString();

                tbgia.Text = dt.Rows[vitri][5].ToString();

                tbdung.Text = dt.Rows[vitri][6].ToString();
            }
            tbma.ReadOnly = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
