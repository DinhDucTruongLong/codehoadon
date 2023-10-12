using DoAn_CuoiKy.model;
using DoAn_CuoiKy.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_CuoiKy
{
    public partial class DanhsachHD : Form
    {
        public DanhsachHD()
        {
            InitializeComponent();
        }
         QuanLyPhongTroContextDB context = new QuanLyPhongTroContextDB();
        // thêm thông tin CSDL vào dgvdanhdsach
        private void themlistSVvaogrid(List<PHONG> listPhong)
        {
            ////refesh truoc khi truyen du lieu tu list sinh vien.
            //dgvDanhsachHD.Rows.Clear();
            //// biến s sẽ lặp lại tất cả (ID, name, khoa , DTB) của danh sách sinh viên.
            //foreach (var S in listPhong)
            //{
            //    int index = dgvDanhsachHD.Rows.Add();// khoi tao gia tri de them sinh vien
            //    dgvDanhsachHD.Rows[index].Cells[0].Value = S.MaPhong;

            //}
        }
        //private void themlistloaiphong(List<MALOAIPHONG> listloaiPhong)
        //{
        //    ////refesh truoc khi truyen du lieu tu list sinh vien.
        //    //dgvDanhsachHD.Rows.Clear();
        //    //// biến s sẽ lặp lại tất cả (ID, name, khoa , DTB) của danh sách sinh viên.
        //    //foreach (var S in listloaiPhong)
        //    //{
        //    //    int index = dgvDanhsachHD.Rows.Add();// khoi tao gia tri de them sinh vien
        //    //    dgvDanhsachHD.Rows[index].Cells[3].Value = S.DonGia;
        //    //}
        //}
     


    }
}
     
