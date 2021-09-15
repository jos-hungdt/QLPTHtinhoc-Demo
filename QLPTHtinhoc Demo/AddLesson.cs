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
    public partial class AddLesson : Form
    {
        public AddLesson()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                QuanliphongtinDataContext db = new QuanliphongtinDataContext();
                string idmon = cbbmamon.SelectedItem.ToString();
                string idgiaovien = cbbGiaovien.SelectedItem.ToString();
                string idphong = cbbMaphong.SelectedItem.ToString();
                string idlop = cbbLop.SelectedItem.ToString();

                TIETHOC add = new TIETHOC();
                add.MAMON = int.Parse(getid(idmon));
                add.MAPHONG = int.Parse(getid(idphong));
                add.MAGV = int.Parse(getid(idgiaovien));
                add.MALOP = int.Parse(getid(idlop));
                add.THOIGIAN = datetimepi.Value;
                add.TIET = int.Parse(cbtiet.SelectedItem.ToString());
                add.TIETPPCT = int.Parse(tbppct.Text);
                add.GHICHU = cbbStatus.SelectedItem.ToString();
                add.TENBAI = tbBaihoc.Text;

                db.TIETHOCs.InsertOnSubmit(add);
                db.SubmitChanges();
                this.Close();
            }
            catch
            {
                MessageBox.Show("Syntax error");
            }
        }

        private void AddLesson_Load(object sender, EventArgs e)
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

                List<string> tiets = new List<string>();
                tiets.Add("1");
                tiets.Add("2");
                tiets.Add("3");
                tiets.Add("4");
                tiets.Add("5");
                cbtiet.DataSource = tiets;
            }
            catch
            {

            }
        }

        public string getid(string s)
        {
            string str = "";
            for(int i = 0; i< s.Length; i++)
            {
                if(s[0].ToString() != " " )
                {
                    str = str + s[0].ToString();
                    break;
                }
            }
            return str;
        }
    }
}
