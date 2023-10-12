using DoAn_CuoiKy.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.Remoting.Contexts;
using System.Data.SqlTypes;

namespace DoAn_CuoiKy
{
    public partial class NhapHD : Form
    {
        public NhapHD()
        {
            InitializeComponent();   

        }
             QuanLyPhongTroContextDB context = new QuanLyPhongTroContextDB();
            List<MALOAIPHONG> MALOAIPHONGs = new List<MALOAIPHONG>();

        private void textBoxloaiphong_TextChanged(object sender, EventArgs e)
        {

        }


        private void textBoxgiaphong_TextChanged(object sender, EventArgs e)
        {


        }
        private void themDVvaoDGV(List<DICHVU> listDichvu, List<CT_DICHVU> listCTDV)
        {
            dataGridViewDSdichvu.Rows.Clear();
            foreach (var d in listDichvu)
            {
                int i = dataGridViewDSdichvu.Rows.Add();
                dataGridViewDSdichvu.Rows[i].Cells[0].Value = d.Gia;
                
                dataGridViewDSdichvu.Rows[i].Cells[2].Value = d.TenDV;
              //  dataGridViewDSdichvu.Rows[i].Cells[3].Value = "false";
                CT_DICHVU CTDV = listCTDV.FirstOrDefault(b => b.MaDV == d.MaDV);
               if(CTDV != null)
                {
                    dataGridViewDSdichvu.Rows[i].Cells[1].Value = CTDV.NgayDung;
                    
                }
            }
        }
      
        private bool uncheckedall = true;
        private CheckBox checkboxHearder;
        private void NhapHD_Load(object sender, EventArgs e)
        {
            try
            {
                  context = new QuanLyPhongTroContextDB();
                //truy vấn ds từ cở sở dữ liệu = khoas
                 MALOAIPHONGs = context.MALOAIPHONGs.ToList();
                themloaiphongcombobox();// điền dữ liệu từ listkhoa và combobox.
                List<PHONG> pHONGs = context.PHONGs.ToList();
                themphongvaocombobox(pHONGs);
                List<DICHVU> DV =context.DICHVUs.ToList();
                List<CT_DICHVU> CT_DV = context.CT_DICHVU.ToList();
                themDVvaoDGV(DV,CT_DV);
               
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            checkBoxColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDSdichvu.Columns.Insert(0, checkBoxColumn);
            //add checkbox header.
            Rectangle rect = dataGridViewDSdichvu.GetCellDisplayRectangle(0,-1, false);
            //set checkbox header to center of header cell. +1 oixel to position corectly.
            rect.X = rect.Location.X+ (rect.Width/2);
            rect.Y = rect.Location.Y+ (rect.Height/4);
            checkboxHearder = new CheckBox();
            checkboxHearder.Name = "checkboxHeader";
            checkboxHearder.Size = new Size(18,18);
            checkboxHearder.Location = rect.Location;
            checkBoxColumn.ReadOnly = false;
            //checked changed event
            checkboxHearder.CheckedChanged += new EventHandler(checkboxHearder_CheckedChanged);
            dataGridViewDSdichvu.Controls.Add(checkboxHearder);
            textBoxtongtienDV.Text = TongtienDV().ToString();

        }
        private void checkboxHearder_CheckedChanged(object sender, EventArgs e)
        {
            if(checkboxHearder.Checked )//if hearder checkbox checked
            {
                for(int i = 0;i< dataGridViewDSdichvu.RowCount; i++)
                {
                    dataGridViewDSdichvu[0, i].Value = true;
                }
            }
            else
            {
                if(uncheckedall)//if hearder itself checked.{
                {
                    for(int i = 0;i< dataGridViewDSdichvu.RowCount; i++)
                    {
                        dataGridViewDSdichvu[0, i].Value = false;
                    }
                }    
            }
            uncheckedall = true;// reset variable is trú when ever checked state change
        }
        
        //datagridview cell click event.
        

        private void textBoxchisotieuthudien_TextChanged(object sender, EventArgs e)
        {



        }
        private void capnhat(int ID)
        {
            CT_DICHVU capnhat = context.CT_DICHVU.FirstOrDefault(x => x.MaDV == ID);
            if (capnhat != null)
            {

                capnhat.NgayDung = dateTimePickerDangki.Value;
                context.SaveChanges();
            }
          
        }

        private void buttonluuvatieptuc_Click(object sender, EventArgs e)
        {


            int tieuthudien = 0;
            if (textBoxchisodiencu.Text != "" && textBoxchisodienmoi.Text != "" && Convert.ToInt32(textBoxchisodienmoi.Text) > Convert.ToInt32(textBoxchisodiencu.Text))
            {
                tieuthudien = Convert.ToInt32(textBoxchisodienmoi.Text) - Convert.ToInt32(textBoxchisodiencu.Text);
                textBoxchisotieuthudien.Text = tieuthudien.ToString();
            }
            int tongtiendien = tieuthudien * 1500;
            textBoxTongtiendien.Text = tongtiendien.ToString();

            int tieuthunuoc = 0;
            if (textBoxchisonuoccu.Text != "" && textBoxchisonuocmoi.Text != "" && Convert.ToInt32(textBoxchisonuocmoi.Text) > Convert.ToInt32(textBoxchisonuoccu.Text))
            {
                tieuthunuoc = Convert.ToInt32(textBoxchisonuocmoi.Text) - Convert.ToInt32(textBoxchisonuoccu.Text);
                textboxchisotieuthunuoc.Text = tieuthunuoc.ToString();
            }
            int tongtiennuoc = tieuthunuoc * 3000;
            textBoxTongtiennuoc.Text = tongtiennuoc.ToString();
            int rowIndex = dataGridViewDSdichvu.CurrentRow.Index; // Lấy chỉ số hàng đang được chọn
            DateTime newDate = DateTime.Parse(dateTimePickerDangki.Text);
            dataGridViewDSdichvu.Rows[rowIndex].Cells[1].Value = newDate;
            //cập nhật giá trị ngày đki vào cột " ngày đăng kí"
            int c = Convert.ToInt32(dataGridViewDSdichvu.Rows[rowIndex].Cells["MaDV"].Value);
            capnhat(c);
            checkboxHearder_CheckedChanged(this, EventArgs.Empty);
            context.SaveChanges();
           
          

            // Cập nhật giá trị ngày đăng kí vào cột "NgayDangKi"
        }
          




        
     
        decimal TongtienDV()
        {
            decimal tongTien = 0;

            foreach (DataGridViewRow row in dataGridViewDSdichvu.Rows)
            {
                DataGridViewCheckBoxCell checkBoxCell = row.Cells[0]as DataGridViewCheckBoxCell;
                if (checkBoxCell != null && Convert.ToBoolean(checkBoxCell.Value) == true)
                {
                    decimal giaDV = Convert.ToDecimal(row.Cells[1].Value);
                   
                    tongTien += giaDV ;
                }
            }

            return tongTien;
        }

       // decimal total = TongtienDV();
       
        private void themloaiphongcombobox()
        {
            //tham chiếu đến danh sach dữ liệu combobox.
            this.cbbloaiphong.DataSource = MALOAIPHONGs;
            //chỉ định tên của của khoa ở trong list 
            this.cbbloaiphong.ValueMember = "TenLoaiPhong";
            // lấy giá trị của mã khoa = valuemenber
            this.cbbloaiphong.DisplayMember = "MaLoaiphong";
            //Lấy giá trị của đơn giá.
           

        }
        private void themphongvaocombobox(List<PHONG> PHONGs)
        {
            this.comboBoxtang.DataSource = PHONGs;
            this.comboBoxtang.ValueMember = "Tang";
            this.comboBoxphong.DataSource = PHONGs;
            this.comboBoxphong.ValueMember = "MaPhong";
        }




        private void buttonHuy_Click(object sender, EventArgs e)
        {
            
        }

       

        private void cbbloaiphong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbloaiphong.SelectedItem != null)
            {
                MALOAIPHONG selectedLoaiPhong = (MALOAIPHONG)cbbloaiphong.SelectedItem;
                // Lấy giá trị của thuộc tính DonGia từ đối tượng selectedLoaiPhong
                string donGia = selectedLoaiPhong.DonGia.ToString();
                // Gán giá trị của thuộc tính DonGia vào textBoxgiaphong
                textBoxgiaphong.Text = donGia;

            }
        }


        

       

        private void dataGridViewDSdichvu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    int rowIndex = e.RowIndex;
                    int columnIndex = e.ColumnIndex;

                    // Kiểm tra chỉ mục của cột chứa giá trị thời gian
                    if (columnIndex == 1)
                    {
                        // Truy cập giá trị thời gian trong ô được nhấp chuột
                        if (dataGridViewDSdichvu.Rows[rowIndex].Cells[columnIndex].Value is DateTime thoiGian)
                        {
                            dateTimePickerDangki.Value = thoiGian;
                        }
                    }
                }
                if (e.RowIndex >= 0)
                {
                    if ((bool)dataGridViewDSdichvu[0,e.RowIndex].Value== true)
                    {
                        dataGridViewDSdichvu[0, e.RowIndex].Value = false;
                        foreach(DataGridViewRow r in dataGridViewDSdichvu.Rows)
                        {
                            uncheckedall = false;
                            break;
                        }    
                    }
                    checkboxHearder.Checked = false;
                }
                else
                {
                    dataGridViewDSdichvu[0, e.RowIndex].Value = true;
                    bool check = true;
                    foreach(DataGridViewRow r in dataGridViewDSdichvu.Rows)
                    {
                        //exit
                        if ((bool)r.Cells[0].Value == false)
                        {
                            check = false;

                            break;
                        }
                    }
                    // it has mean all rows are checked
                    if(check)
                    {
                        checkboxHearder.Checked = true;
                    }
                }


            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            



        }

        private void buttonDongHD_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //private void dataGridViewDSdichvu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
        //    checkBoxColumn.HeaderText = "Đã chọn";
        //    dataGridViewDSdichvu.Columns.Add(checkBoxColumn);
        //    dataGridViewDSdichvu.Rows.Add(false);
        //    dataGridViewDSdichvu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        //    dataGridViewDSdichvu.AllowUserToAddRows = false;
        // }

    }
}
