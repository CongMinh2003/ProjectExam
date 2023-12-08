using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLiNhaHang
{
    class BanDTO
    {
        private string maBan;
        private string tenMon;
        private int soLuongNguoi;
        private bool trangThai;

        protected string MaBan { get => maBan; set => maBan = value; }
        public string TenMon { get => tenMon; set => tenMon = value; }
        protected int SoLuongNguoi { get => soLuongNguoi; set => soLuongNguoi = value; }
        protected bool TrangThai { get => trangThai; set => trangThai = value; }       

        public BanDTO()
        {
            MaBan = "";
            TenMon = "";
            SoLuongNguoi = 0;
            TrangThai = true;
        }

        public BanDTO( string maBan, string tenMon, int soLuongNguoi, bool trangThai)
        {
            this.MaBan = maBan;
            this.TenMon = tenMon;
            this.SoLuongNguoi = soLuongNguoi;
            this.TrangThai = trangThai;
        }
    }
}
