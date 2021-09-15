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
    public partial class Desktop : Form
    {
        public Desktop()
        {
            InitializeComponent();
        }
        static int getid;
        static string getuser;
        public Desktop(int iddk, string _getuser) : this()
        {
            getid = iddk;
            getuser = _getuser;
            if(iddk != 1)
            {
                btnLophoc.Enabled = false;
                btnPhongMay.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                btn_user.Enabled = false;
            }
        }
        private void btnPhongMay_Click(object sender, EventArgs e)
        {
            FormPhongMay pm = new FormPhongMay();
            this.Close();
            pm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormTietHoc th = new FormTietHoc();
            th.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormMonHoc mh = new FormMonHoc();
            mh.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormGiaoVien gv = new FormGiaoVien();
            gv.Show();
            this.Close();
        }

        private void btnLophoc_Click(object sender, EventArgs e)
        {
            FormQLLophoc lh = new FormQLLophoc();
            lh.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormThongke tk = new FormThongke(getid, getuser);
            tk.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormPCCM pp = new FormPCCM();
            pp.Show();
            this.Close();
        }

        private void Desktop_Load(object sender, EventArgs e)
        {

            lbchao.Text = "Xin chào " + getuser;
        }

        private void btn_user_Click(object sender, EventArgs e)
        {
            FormUser er = new FormUser();
            er.Show();
            this.Close();
        }

        private void bt_Editpass_Click(object sender, EventArgs e)
        {
            EditPass ed = new EditPass(getid, getuser);
            ed.Show();
        }

    }
}
