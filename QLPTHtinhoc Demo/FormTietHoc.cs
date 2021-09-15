using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLPTHtinhoc_Demo
{
    public partial class FormTietHoc : Form
    {
        public FormTietHoc()
        {
            InitializeComponent();
        }

        private void FormTietHoc_Load(object sender, EventArgs e)
        {
            QuanliphongtinDataContext db = new QuanliphongtinDataContext();
            dtgvData.DataSource = db.TIETHOCs.Select(d => d);
            //đổ và đặt dữ liêu cho combobox trạng thái
            List<string> status = new List<string>();
            status.Add("Chưa hoàn thành");
            status.Add("Đã hoàn thành");
            //cbbStatus.DataSource = status;
            //// Đổ dữ liệu cho cbbox mã giáo viên
            //var query = db.GIAOVIENs.Select(d => d.MAGV+" - "+d.NAME);
            //cbbGiaovien.DataSource = query.ToList();
            ////đổ dữ liệu cho combobox ID phòng học
            //var phonghoc = db.PHONGMAYs.Select(h => h.MAPHONG + " - " + h.NAME);
            //cbbMaphong.DataSource = phonghoc.ToList();
            ////đổ dữ liệu cho comboBox môn học
            //var monhoc = db.MONHOCs.Select(k => k.MAMON + " - " + k.NAMESUBJECT);
            //cbbmamon.DataSource = monhoc.ToList();
        }

        static int ide;
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Desktop dt = new Desktop();
            dt.Show();
        }
        QuanliphongtinDataContext db = new QuanliphongtinDataContext();
        private void dtgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string id = dtgvData.SelectedCells[0].OwningRow.Cells["ID"].Value.ToString();
                string mamon = dtgvData.SelectedCells[0].OwningRow.Cells["MAMON"].Value.ToString();
                string magv = dtgvData.SelectedCells[0].OwningRow.Cells["MAGV"].Value.ToString();
                string maphong = dtgvData.SelectedCells[0].OwningRow.Cells["MAPHONG"].Value.ToString();
                string tenbai = dtgvData.SelectedCells[0].OwningRow.Cells["TENBAI"].Value.ToString();
                string thoigian = dtgvData.SelectedCells[0].OwningRow.Cells["THOIGIAN"].Value.ToString();
                string tiet = dtgvData.SelectedCells[0].OwningRow.Cells["TIET"].Value.ToString();
                string ghichu = dtgvData.SelectedCells[0].OwningRow.Cells["GHICHU"].Value.ToString();

                ide = int.Parse(id);
            }
            catch
            {

            }
            //TbMaTiet.Text = id;
            //cbbmamon.SelectedItem = mamon;
            //cbbGiaovien.SelectedItem = magv;
            //cbbMaphong.SelectedItem = maphong;
            //if (ghichu == null) ghichu = "Chưa hoàn thành";
            //cbbStatus.SelectedItem = ghichu;
            //tbBaihoc.Text = tenbai;
            //tbTiet.Text = tiet;

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //int id = int.Parse(TbMaTiet.Text);
            //TIETHOC edit = db.TIETHOCs.Where(d => d.ID.Equals(id)).SingleOrDefault();

            //string idmon = cbbmamon.SelectedItem.ToString();
            //string idgiaovien = cbbGiaovien.SelectedItem.ToString();
            //string idphong = cbbMaphong.SelectedItem.ToString();

            //edit.MAMON = int.Parse(idmon[0].ToString());
            //edit.MAPHONG = int.Parse(idphong[0].ToString());
            //edit.MAGV = int.Parse(idgiaovien[0].ToString());
            //edit.THOIGIAN = datetimepi.Value;
            //edit.TIET = int.Parse(tbTiet.Text);
            //edit.GHICHU = cbbStatus.SelectedItem.ToString();
            //edit.TENBAI = tbBaihoc.Text;

            //db.SubmitChanges();
            //dtgvData.DataSource = db.TIETHOCs.Select(d => d);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //int id = int.Parse(TbMaTiet.Text);
            //TIETHOC edit = db.TIETHOCs.Where(d => d.ID.Equals(id)).SingleOrDefault();

            //string idmon = cbbmamon.SelectedItem.ToString();
            //string idgiaovien = cbbGiaovien.SelectedItem.ToString();
            //string idphong = cbbMaphong.SelectedItem.ToString();

            //edit.MAMON = int.Parse(idmon[0].ToString());
            //edit.MAPHONG = int.Parse(idphong[0].ToString());
            //edit.MAGV = int.Parse(idgiaovien[0].ToString());
            //edit.THOIGIAN = datetimepi.Value;
            //edit.TIET = int.Parse(tbTiet.Text);
            //edit.GHICHU = cbbStatus.SelectedItem.ToString();
            //edit.TENBAI = tbBaihoc.Text;

            //db.TIETHOCs.DeleteOnSubmit(edit);
            //db.SubmitChanges();
            //dtgvData.DataSource = db.TIETHOCs.Select(d => d);
        }

        private void btnlt_Click(object sender, EventArgs e)
        {

            QuanliphongtinDataContext db = new QuanliphongtinDataContext();
            dtgvData.DataSource = db.TIETHOCs.Select(d => d);
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            AddLesson ls = new AddLesson();
            ls.Show();
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            FEditLesson ed = new FEditLesson(ide);
            ed.Show();
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            FEditLesson ed = new FEditLesson(ide);
            ed.Show();
        }        
    }
}
