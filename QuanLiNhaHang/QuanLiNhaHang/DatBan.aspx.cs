using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BUS_QuanLiNhaHang;
using DTO_QuanLiNhaHang;

namespace QuanLiNhaHang
{
    public partial class WebForm4 : System.Web.UI.Page

        
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        busDatBan DB = new busDatBan();

        protected void btnDatBan_Click(object sender, EventArgs e)
        {
            DatBanDTO us = LayDuLieuTuForm();

            //UserDAO userDAO = new UserDAO();

            //bool exist = userDAO.CheckUser(us.UserName);
            //if (exist)
            //{
            //    lblMessage.Text = "Username đã tồn tại";
            //}
            //else
            //{
            //    bool result = userDAO.Insert(us);

            //    UploadAvatar(us.AvatarFileName);

            //    if (result)
            //    {
            //        lblMessage.Text = "Đăng ký thành công!";
            //        LayDuLieuVaoGridView();
            //    }
            //    else
            //    {
            //        lblMessage.Text = "Có lỗi. Vui lòng thử lại sau";
            //    }
            //}
        }

        public DatBanDTO LayDuLieuTuForm()
        {
            DatBanDTO db = new DatBanDTO
            {
                MaDatBan = txtMaDatBan.Text,
                MaBan = cbxMaban.Text,
                MaKhachHang = txtMaKhachHang.Text,
                TenKhachHang = txtTenKhachHang.Text,
                SoLuongNguoi = int.Parse(txtSoLuong.Text),
                TrangThai = cbxTrangThai.Text
            };

            return db;
        }
    }
}