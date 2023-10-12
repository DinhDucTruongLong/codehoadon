using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_CuoiKy
{
    public partial class frmHeThong : Form
    {
        public frmHeThong()
        {
            InitializeComponent();
        }
        

        private void tabQuanLyKhachPhong_Click(object sender, EventArgs e)
        {

        }

        private void tsbDanhSachHoaDon_Click(object sender, EventArgs e)
        {

            if (!CheckExitForm("DanhsachHD"))
            {
                DanhsachHD frm = new DanhsachHD();
                //frm.MdiParent = this;
                //frm.Name = "DanhsachHD";
                frm.ShowDialog();

            }
            else
            {
                ActiveChildfForm("DanhsachHD");
            }

        }
        private bool CheckExitForm(string name)
        {
            bool check = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }
        private void ActiveChildfForm(String name)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    frm.Activate();
                    break;
                }
            }
        }

        private void tsbNhapHoaDon_Click(object sender, EventArgs e)
        {

            if (!CheckExitForm("NhapHD"))
            {
                NhapHD frm = new NhapHD();
                //frm.MdiParent = this;
                //frm.Name = "NhapHD";
                frm.ShowDialog();

            }
            else
            {
                ActiveChildfForm("NhapHD");
            }
        }

        private void tsbDanhSachDichVu_Click(object sender, EventArgs e)
        {

            if (!CheckExitForm("DanhsachDV"))
            {
               DanhmucDV frm = new DanhmucDV();
                //frm.MdiParent = this;
                //frm.Name = "DanhsachDV";
                frm.ShowDialog();

            }
            else
            {
                ActiveChildfForm("DanhsachDV");
            }
        }

        private void tsbNhapHDDichVu_Click(object sender, EventArgs e)
        {

            if (!CheckExitForm("HDDichvu"))
            {
               HDdichvu frm = new HDdichvu();
                //frm.MdiParent = this;
                //frm.Name = "HDdichvu";
                frm.ShowDialog();

            }
            else
            {
                ActiveChildfForm("HDdichvu");
            }
        }
    }
}
