using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHNH
{
    internal class NuocHoa
    {
        classketnoi ketnoi;
        public NuocHoa()
        {
            ketnoi = new classketnoi();
        }
        public DataTable HienThiNuocHoaByID(string MaNuocHoa)
        {
            string sql = "select * from NUOCHOA WHERE MANUOCHOA = '"+MaNuocHoa+"'";
            Console.WriteLine(sql);
            DataTable dt = ketnoi.Execute(sql);
            return dt;
        }
        public DataTable HienThiKhachHangByID(string MaKhachHang)
        {
            string sql = "select * from KHACHHANG WHERE MAKH = '" + MaKhachHang + "'";
            Console.WriteLine(sql);
            DataTable dt = ketnoi.Execute(sql);
            return dt;
        }
        public DataTable HienThiNccByID(string MaNhaCC)
        {
            string sql = "select * from NHACUNGCAP WHERE MANHACC = '" + MaNhaCC + "'";
            Console.WriteLine(sql);
            DataTable dt = ketnoi.Execute(sql);
            return dt;
        }
    }
}

