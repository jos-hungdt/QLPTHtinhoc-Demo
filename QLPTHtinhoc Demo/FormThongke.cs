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
    public partial class FormThongke : Form
    {
        public FormThongke()
        {
            InitializeComponent();
        }

        static int _getid;
        static string _getu;
        public FormThongke(int idd, string getu) : this()
        {
            _getid = idd;
            _getu = getu;
        }
        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
            Desktop dt = new Desktop(_getid,_getu );
            dt.Show();
        }
        static string gvs; 
        static string phongs;
        private void button1_Click(object sender, EventArgs e)//thong ke  theo khoi
        {
            try
            {
                string getkhoi = cbKhoi.SelectedItem.ToString();
                QuanliphongtinDataContext db = new QuanliphongtinDataContext();
                List<CLASS> clas = new List<CLASS>();
                clas = db.CLASSes.Select(u => u).ToList();
                List<TIETHOC> tiet = new List<TIETHOC>();
                tiet = db.TIETHOCs.Select(d => d).ToList();
                List<GIAOVIEN> giaovien = new List<GIAOVIEN>();
                giaovien = db.GIAOVIENs.Select(q => q).ToList();
                List<PHONGMAY> phongmay = new List<PHONGMAY>();
                phongmay = db.PHONGMAYs.Select(r => r).ToList();
                List<CTKKhoi> tkk = new List<CTKKhoi>();

                int idkhoi;
                string lops;

                foreach(var it in clas)
                {
                    if(it.KHOI == getkhoi)
                    {
                        idkhoi = it.MALOP;
                        lops = it.TENLOP;
                        foreach(var item in tiet)
                        {
                            if(item.MALOP == idkhoi)
                            {
                                foreach(var k in giaovien)
                                {
                                    if (item.MAGV == k.MAGV) gvs = k.NAME;
                                }
                               foreach(var j in phongmay)
                               {
                                   if (item.MAPHONG == j.MAPHONG) phongs = j.NAME;
                               }
                               tkk.Add(new CTKKhoi { ID = item.ID, khois = getkhoi, lop = lops, GV = gvs, tenbai = item.TENBAI, tiet = int.Parse(item.TIET.ToString()), tietppct = int.Parse(item.TIETPPCT.ToString()), phong = phongs, ngay = (DateTime)item.THOIGIAN, Trangthai = item.GHICHU });
                            }
                        }
                    }
                }
                dtgvData.DataSource = tkk;
            }
            catch
            {
                MessageBox.Show("Lỗi khi truy vấn dữ liệu");
            }
        }

        private void FormThongke_Load(object sender, EventArgs e)
        {
            try
            {
                QuanliphongtinDataContext db = new QuanliphongtinDataContext();
                List<string> khoi = new List<string>();
                khoi.Add("Khối 10");
                khoi.Add("Khối 11");
                khoi.Add("Khối 12");
                cbKhoi.DataSource = khoi;

                cbGV.DataSource = db.GIAOVIENs.Select(d => d.NAME);
                cbLop.DataSource = db.CLASSes.Select(d => d.TENLOP);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật dữ liệu");
            }
        }

        private void btnLop_Click(object sender, EventArgs e)
        {
            try
            {
                string getlop = cbLop.SelectedItem.ToString(); 
                QuanliphongtinDataContext db = new QuanliphongtinDataContext();
                List<CLASS> clas = new List<CLASS>();
                clas = db.CLASSes.Select(u => u).ToList();
                List<TIETHOC> tiet = new List<TIETHOC>();
                tiet = db.TIETHOCs.Select(d => d).ToList();
                List<GIAOVIEN> giaovien = new List<GIAOVIEN>();
                giaovien = db.GIAOVIENs.Select(q => q).ToList();
                List<PHONGMAY> phongmay = new List<PHONGMAY>();
                phongmay = db.PHONGMAYs.Select(r => r).ToList();
                List<CTKKhoi> tkk = new List<CTKKhoi>();

                int idlop;
                string lops;

                foreach (var it in clas)
                {
                    if (it.TENLOP == getlop)
                    {
                        idlop = it.MALOP;
                        foreach (var item in tiet)
                        {
                            if (item.MALOP == idlop)
                            {
                                foreach (var k in giaovien)
                                {
                                    if (item.MAGV == k.MAGV) gvs = k.NAME;
                                }
                                foreach (var j in phongmay)
                                {
                                    if (item.MAPHONG == j.MAPHONG) phongs = j.NAME;
                                }
                                tkk.Add(new CTKKhoi { ID = item.ID, khois = it.KHOI, lop = getlop, GV = gvs, tenbai = item.TENBAI, tiet = int.Parse(item.TIET.ToString()), tietppct = int.Parse(item.TIETPPCT.ToString()), phong = phongs, ngay = (DateTime)item.THOIGIAN, Trangthai = item.GHICHU });
                            }
                        }
                    }
                }
                dtgvData.DataSource = tkk;
            }
            catch
            {
                MessageBox.Show("Lỗi khi truy vấn dữ liệu");
            }
        }
        static string lopss;
        static string kkhoi;
        private void btnGV_Click(object sender, EventArgs e)
        {
            try
            {
                string getGV = cbGV.SelectedItem.ToString(); 
                QuanliphongtinDataContext db = new QuanliphongtinDataContext();
                List<CLASS> clas = new List<CLASS>();
                clas = db.CLASSes.Select(u => u).ToList();
                List<TIETHOC> tiet = new List<TIETHOC>();
                tiet = db.TIETHOCs.Select(d => d).ToList();
                List<GIAOVIEN> giaovien = new List<GIAOVIEN>();
                giaovien = db.GIAOVIENs.Select(q => q).ToList();
                List<PHONGMAY> phongmay = new List<PHONGMAY>();
                phongmay = db.PHONGMAYs.Select(r => r).ToList();
                List<CTKKhoi> tkk = new List<CTKKhoi>();

                int idgv;
                
                foreach(var s in giaovien)
                {
                    if(s.NAME == getGV)
                    {
                        idgv = s.MAGV;

                        foreach(var it in tiet)
                        {
                            if(it.MAGV == idgv)
                            {
                                foreach(var k in phongmay)
                                {
                                    if (k.MAPHONG == it.MAPHONG) phongs = k.NAME;
                                }
                                foreach(var f in clas)
                                {
                                    if (f.MALOP == it.MALOP)
                                        lopss = f.TENLOP;   
                                        kkhoi = f.KHOI;
                                }
                                tkk.Add(new CTKKhoi { ID = it.ID, GV = getGV, lop = lopss, khois = kkhoi, tenbai = it.TENBAI, tiet = int.Parse(it.TIET.ToString()), tietppct = int.Parse(it.TIETPPCT.ToString()), phong = phongs, ngay = (DateTime)it.THOIGIAN, Trangthai = it.GHICHU });
                            }
                        }
                    }
                }
                
                dtgvData.DataSource = tkk;
            }
            catch
            {
                MessageBox.Show("Lỗi khi truy vấn dữ liệu");
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("This function isn't installed");
            }
            catch
            {
                MessageBox.Show("There was an Error");
            }
        }

        private void tbnTime_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime timebd = timestart.Value;
                DateTime timekt = timeEnd.Value;

                QuanliphongtinDataContext db = new QuanliphongtinDataContext();
                List<CLASS> clas = new List<CLASS>();
                clas = db.CLASSes.Select(u => u).ToList();
                List<TIETHOC> tiet = new List<TIETHOC>();
                tiet = db.TIETHOCs.Select(d => d).ToList();
                List<GIAOVIEN> giaovien = new List<GIAOVIEN>();
                giaovien = db.GIAOVIENs.Select(q => q).ToList();
                List<PHONGMAY> phongmay = new List<PHONGMAY>();
                phongmay = db.PHONGMAYs.Select(r => r).ToList();
                List<CTKKhoi> tkk = new List<CTKKhoi>();

                DateTime getd;
                foreach (var item in tiet)
                {
                    getd = (DateTime)item.THOIGIAN;
                    if ((DateTime.Compare(timebd, getd) == -1) && (DateTime.Compare(timekt, getd) == 1))
                    {
                        foreach (var k in giaovien)
                        {
                            if (k.MAGV == item.MAGV) gvs = k.NAME;
                        }
                        foreach (var j in phongmay)
                        {
                            if (j.MAPHONG == item.MAPHONG)
                                phongs = j.NAME;
                        }
                        foreach (var l in clas)
                        {
                            if (l.MALOP == item.MALOP)
                                lopss = l.TENLOP;
                            kkhoi = l.KHOI;
                        }
                        tkk.Add(new CTKKhoi { ID = item.ID, GV = gvs, khois = kkhoi, lop = lopss, tenbai = item.TENBAI, tiet = int.Parse(item.TIET.ToString()), tietppct = int.Parse(item.TIETPPCT.ToString()), phong = phongs, ngay = (DateTime)item.THOIGIAN });
                    }

                }
                dtgvData.DataSource = tkk;
            }
            catch
            {
                MessageBox.Show("Lỗi xử lí dữ liệu");
            }

        }

    }
}
