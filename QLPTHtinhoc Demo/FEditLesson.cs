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
    public partial class FEditLesson : Form
    {
        public FEditLesson()
        {
            InitializeComponent();
        }
        public static int getid;
        public FEditLesson(int _getid) : this()
        {
            getid = _getid;
        }
        private void FEditLesson_Load(object sender, EventArgs e)
        {
            try
            {
                QuanliphongtinDataContext db = new QuanliphongtinDataContext();
                //đổ và đặt dữ liêu cho combobox trạng thái
                List<string> status = new List<string>();
                status.Add("Chưa hoàn thành");
                status.Add("Đã hoàn thành");
                cbbStatus.DataSource = status;
                // Đổ dữ liệu cho cbbox mã giáo viên
                var query = db.GIAOVIENs.Select(d => d.MAGV + " - " + d.NAME);
                cbbGiaovien.DataSource = query.ToList();
                //đổ dữ liệu cho combobox ID phòng học
                var phonghoc = db.PHONGMAYs.Select(h => h.MAPHONG + " - " + h.NAME);
                cbbMaphong.DataSource = phonghoc.ToList();
                //đổ dữ liệu cho comboBox môn học
                var monhoc = db.MONHOCs.Select(k => k.MAMON + " - " + k.NAMESUBJECT);
                cbbmamon.DataSource = monhoc.ToList();

                cbbLop.DataSource = db.CLASSes.Select(d => d.MALOP + " - " + d.TENLOP);

                List<TIETHOC> tiet = new List<TIETHOC>();
                tiet = db.TIETHOCs.Where(d => d.ID.Equals(getid)).ToList();
                foreach(var it in tiet)
                {
                    TbMaTiet.Text = it.ID.ToString();
                    tbBaihoc.Text = it.TENBAI;
                    tbidgv.Text = it.MAGV.ToString();
                    tbidlop.Text = it.MALOP.ToString();
                    tbidmon.Text = it.MAMON.ToString();
                    tbIDPhong.Text = it.MAPHONG.ToString();
                    tbppct.Text = it.TIETPPCT.ToString();
                    tbTiet.Text = it.TIET.ToString();
                    tbTime.Text = it.THOIGIAN.ToString();
                    

                }
                List<string> tiets = new List<string>();
                tiets.Add("1");
                tiets.Add("2");
                tiets.Add("3");
                tiets.Add("4");
                tiets.Add("5");
                cbtiets.DataSource = tiets;
            }
            catch
            {

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                QuanliphongtinDataContext db = new QuanliphongtinDataContext();
                TIETHOC ety = db.TIETHOCs.Where(d => d.ID.Equals(getid)).SingleOrDefault();


                ety.MAMON = int.Parse(getids(cbbmamon.SelectedItem.ToString()));
                ety.MAPHONG = int.Parse(getids(cbbMaphong.SelectedItem.ToString()));
                ety.MAGV = int.Parse(getids(cbbGiaovien.SelectedItem.ToString()));
                ety.MALOP = int.Parse(getids(cbbLop.SelectedItem.ToString()));
                ety.TENBAI = tbBaihoc.Text;
                ety.THOIGIAN = datetimepi.Value;
                ety.TIET = int.Parse(cbtiets.SelectedItem.ToString());
                ety.TIETPPCT = int.Parse(tbppct.Text);
                ety.GHICHU = cbbStatus.SelectedItem.ToString();

                db.SubmitChanges();
                this.Close();
            }
            catch
            {

            }
        }
        public string getids(string s)
        {
            string str = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (s[0].ToString() != " ")
                {
                    str = str + s[0].ToString();
                    break;
                }
            }
            return str;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult re = MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi này không?", "Cảnh báo xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (re == System.Windows.Forms.DialogResult.Yes)
                {
                    QuanliphongtinDataContext db = new QuanliphongtinDataContext();
                    TIETHOC ety = db.TIETHOCs.Where(d => d.ID.Equals(getid)).SingleOrDefault();


                    ety.MAMON = int.Parse(getids(cbbmamon.SelectedItem.ToString()));
                    ety.MAPHONG = int.Parse(getids(cbbMaphong.SelectedItem.ToString()));
                    ety.MAGV = int.Parse(getids(cbbGiaovien.SelectedItem.ToString()));
                    ety.MALOP = int.Parse(getids(cbbLop.SelectedItem.ToString()));
                    ety.TENBAI = tbBaihoc.Text;
                    ety.THOIGIAN = datetimepi.Value;
                    ety.TIET = int.Parse(tbTiet.Text);
                    ety.TIETPPCT = int.Parse(tbppct.Text);
                    ety.GHICHU = cbbStatus.SelectedItem.ToString();

                    db.TIETHOCs.DeleteOnSubmit(ety);
                    db.SubmitChanges();
                    this.Close();
                }
                else this.Close();
            }
            catch
            {

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
