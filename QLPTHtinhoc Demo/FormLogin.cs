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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        static string passinsert = "";
        static int idd;
        static string uer;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                //string insert;
                //insert = tbPass.Text;
                //int k;
                //k = insert.Length;
                //if (insert.Length > passinsert.Length)
                //{
                //    tbPass.Text = "";
                //    for (int i = 0; i < k; i++)
                //    {
                //        if (insert[i].ToString() != "*")
                //        {
                //            passinsert = passinsert + insert[i].ToString();
                //        }
                //    }
                //}

                string usrinsert = tbUser.Text;
                passinsert = tbPass.Text;

                if (usrinsert == "" || passinsert == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ tài khoàn và mật khẩu");
                }
                else
                {
                    QuanliphongtinDataContext db = new QuanliphongtinDataContext();

                    List<User> user = new List<User>();
                    user = db.Users.Select(d => d).ToList();


                    bool kt = false;

                    foreach (var item in user)
                    {
                        if ((item.IDLogin == usrinsert) && (item.Password == passinsert))
                        {
                            kt = true;
                        }
                    }
                    
                    if (kt == true)
                    {
                        foreach(var it in user)
                        {
                            if (it.IDLogin == usrinsert)
                            {
                                idd = int.Parse(it.Level.ToString());
                                uer = tbUser.Text; 
                            }
                        }
                        Desktop md = new Desktop(idd, uer);
                        md.Show();
                        //this.Close();
                        panel1.Enabled = false;
                        tbPass.Text = "**************";

                    }
                    else MessageBox.Show("Tên tài khoản hoặc mật khẩu không chính xác. Vui lòng kiểm tra lại", "Lỗi đăng nhập");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Server has been easy. Try again later" + ex);
            }

        }

        private void tbPass_KeyPress(object sender, KeyPressEventArgs e)
        {

            //string insert;
            //insert = tbPass.Text;
            //int k;
            //k = insert.Length;
            //if (insert.Length > passinsert.Length)
            //{
            //    tbPass.Text = "";
            //    for (int i = 0; i < k; i++)
            //    {
            //        if (insert[i].ToString() != "*")
            //        {
            //            passinsert = passinsert + insert[i].ToString();
            //        }
            //    }
            //    insert = "";
            //    for (int j = 0; j <= k; j++)
            //    {
            //        insert = insert + "*";
            //    }
            //    tbPass.Text = insert;
            //}
            //else
            //{

            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Desktop dt = new Desktop();
            dt.Show();
//            this.Enabled = false;
        }
    }
}
