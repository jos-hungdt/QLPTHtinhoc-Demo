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
    public partial class EditPass : Form
    {
        public EditPass()
        {
            InitializeComponent();
        }
        static int getid;
        static string _getuser;
        public EditPass(int gid,string getuser) : this()
        {
            getid = gid;
            _getuser = getuser;
        }
        static string pass;
        private void button1_Click(object sender, EventArgs e)
        {
            QuanliphongtinDataContext db = new QuanliphongtinDataContext();
           
            List<User> user = new List<User>();
            user = db.Users.Where(d => d.IDLogin == _getuser).ToList();
            foreach (var it in user)
            {
                pass = it.Password;
            }
            if(textBox1.Text != pass)
            {
                MessageBox.Show("Mật khẩu cũ không chính xác. Vui lòng kiểm tra lại");
                textBox1.Text = "";
            }
            else if (textBox3.Text != textBox2.Text)
            {
                MessageBox.Show("Nhập lại mật khẩu mới");
                textBox3.Text = "";
                textBox2.Text = "";
            }
            else
            {
                User edit = db.Users.Where(d => d.IDLogin == _getuser).SingleOrDefault();
                edit.Password = textBox3.Text;

                db.SubmitChanges();
                this.Close();
            }
        }

        private void EditPass_Load(object sender, EventArgs e)
        {

        }
    }
}
