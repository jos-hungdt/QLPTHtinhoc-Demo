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
    public partial class FormUser : Form
    {
        public FormUser()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                tbtb.Text = "";
                QuanliphongtinDataContext db = new QuanliphongtinDataContext();
                User add = new User();
                bool kt = true;
                string us = tbID.Text;
                if (us.Length < 5) tbtb.Text = "Tên đăng nhập phải có ít nhất 5 kí tự.";
                for (int i = 0; i < us.Length; i++)
                {
                    if (us[i].ToString() == " ") tbtb.Text = "Sai định dạng tên đăng nhập";
                }
                if (tbpass.Text != tbrepass.Text) tbtb.Text = "Nhập lại mật khẩu";
                int lv = 2;
                if (cblevel.SelectedItem.ToString() == "Quản trị viên") lv = 1;
                else lv = 2;
                if (tbtb.Text == "")
                {
                    add.IDLogin = us;
                    add.Password = tbpass.Text;
                    add.Level = lv;

                    db.Users.InsertOnSubmit(add);
                    db.SubmitChanges();
                    dtgvData.DataSource = db.Users.Select(u => u);

                    tbID.Text = "";
                    tbpass.Text = "";
                    tbrepass.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            try
            {
                QuanliphongtinDataContext db = new QuanliphongtinDataContext();
                List<User> us = new List<User>();

                dtgvData.DataSource = db.Users.Select(d => d);
                List<string> dataa = new List<string>();
                dataa.Add("Người dùng");
                dataa.Add("Quản trị viên");
                cblevel.DataSource = dataa;
            }
            catch
            {
                MessageBox.Show("Server has been busy");
            }
        }
        static string passe;
        static string idk;
        static int le;
        private void dtgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try 
            {
                string id = dtgvData.SelectedCells[0].OwningRow.Cells["IDLogin"].Value.ToString();
                string pass = dtgvData.SelectedCells[0].OwningRow.Cells["Password"].Value.ToString();
                string level = dtgvData.SelectedCells[0].OwningRow.Cells["Level"].Value.ToString();

                tbID.Text = id;
                tbpass.Text = "************";
                tbrepass.Text = "************";
                passe = pass;
                idk = id;
                le = int.Parse(level);
            }
            catch
            {

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                tbtb.Text = "";
                string us = tbID.Text;
                QuanliphongtinDataContext db = new QuanliphongtinDataContext();
                User add = db.Users.Where(d => d.IDLogin == idk).SingleOrDefault();
                bool kt = true;
                if (us != idk) tbtb.Text = " Không được phép sử tên đăng nhập";
                int lv = 2;
                if (cblevel.SelectedItem.ToString() == "Quản trị viên") lv = 1;
                else lv = 2;
                if (tbtb.Text == "")
                {
                    add.Level = lv;

                    db.SubmitChanges();
                    dtgvData.DataSource = db.Users.Select(u => u);
                    tbID.Text = "";
                    tbpass.Text = "";
                    tbrepass.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                 DialogResult res=  MessageBox.Show("Bạn có chắc chắn muốn xoán tài khoản này khỏi hệ thống không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                 if (res == System.Windows.Forms.DialogResult.Yes)
                 {
                     QuanliphongtinDataContext db = new QuanliphongtinDataContext();
                     User del = db.Users.Where(d => d.IDLogin == idk).SingleOrDefault();

                     del.IDLogin = idk;
                     del.Password = passe;
                     del.Level = le;

                     db.Users.DeleteOnSubmit(del);
                     db.SubmitChanges();
                     dtgvData.DataSource = db.Users.Select(d => d);

                     tbID.Text = "";
                     tbpass.Text = "";
                     tbrepass.Text = "";
                 }                 
            }
            catch
            {

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Desktop dt = new Desktop();
            dt.Show();
        }
    }
}
