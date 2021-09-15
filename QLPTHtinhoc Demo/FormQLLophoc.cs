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
    public partial class FormQLLophoc : Form
    {
        public FormQLLophoc()
        {
            InitializeComponent();
        }
        
        QuanliphongtinDataContext db = new QuanliphongtinDataContext();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                CLASS ent = new CLASS();

                ent.KHOI = tbkhoi.Text;
                ent.GVCN = tbgvcn.Text;
                ent.GHICHU = tbghichu.Text;
                ent.SOHOCSINH = int.Parse(tbsiso.Text);
                ent.TENLOP = tbName.Text;

                db.CLASSes.InsertOnSubmit(ent);
                db.SubmitChanges();

                dtgvData.DataSource = db.CLASSes.Select(u => u);

                tbName.Text = "";
                tbkhoi.Text = "";
                tbgvcn.Text = "";
                tbsiso.Text = "";
                tbghichu.Text = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi dữ liệu nhập vào");
            }
        }

        private void dtgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormQLLophoc_Load(object sender, EventArgs e)
        {
            dtgvData.DataSource = db.CLASSes.Select(d => d);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                QuanliphongtinDataContext dj = new QuanliphongtinDataContext();
                int id = int.Parse(tbID.Text);
                CLASS ent = dj.CLASSes.Where(d => d.MALOP.Equals(id)).SingleOrDefault();

                ent.KHOI = tbkhoi.Text;
                ent.GVCN = tbgvcn.Text;
                ent.SOHOCSINH = int.Parse(tbsiso.Text);
                ent.TENLOP = tbName.Text;
                ent.GHICHU = tbghichu.Text;

                dj.SubmitChanges();
                dtgvData.DataSource = dj.CLASSes.Select(d => d);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi Server");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(tbID.Text);
                CLASS ent = db.CLASSes.Where(d => d.MALOP.Equals(id)).SingleOrDefault();

                ent.KHOI = tbkhoi.Text;
                ent.GVCN = tbgvcn.Text;
                ent.SOHOCSINH = int.Parse(tbsiso.Text);
                ent.TENLOP = tbName.Text;
                ent.GHICHU = tbghichu.Text;

                db.CLASSes.DeleteOnSubmit(ent);
                db.SubmitChanges();
                dtgvData.DataSource = db.CLASSes.Select(d => d);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Server");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Desktop dt = new Desktop();
            dt.Show();

            //tbID.Text = "1";
            //int id = int.Parse(tbID.Text);
            //CLASS ent = db.CLASSes.Where(d => d.MALOP.Equals(id)).SingleOrDefault();
            //tbName.Text = "Lớp 12A1";
            //tbgvcn.Text = "Nguyễn Đình Trưng";
            //tbsiso.Text = "33";
            //tbkhoi.Text = "";
            //tbghichu.Text = "";

            //ent.KHOI = tbkhoi.Text;
            //ent.GVCN = tbgvcn.Text;
            //ent.SOHOCSINH = int.Parse(tbsiso.Text);
            //ent.TENLOP = tbName.Text;
            //ent.GHICHU = tbghichu.Text;

            //db.CLASSes.DeleteOnSubmit(ent);
            //db.SubmitChanges();
        }

        private void dtgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string id = dtgvData.SelectedCells[0].OwningRow.Cells["MALOP"].Value.ToString();
                string name = dtgvData.SelectedCells[0].OwningRow.Cells["TENLOP"].Value.ToString();
                string siso = dtgvData.SelectedCells[0].OwningRow.Cells["SOHOCSINH"].Value.ToString();
                string gvcns = dtgvData.SelectedCells[0].OwningRow.Cells["GVCN"].Value.ToString();
                string khoi = dtgvData.SelectedCells[0].OwningRow.Cells["KHOI"].Value.ToString();
                string note = dtgvData.SelectedCells[0].OwningRow.Cells["GHICHU"].Value.ToString();

                tbID.Text = id;
                tbName.Text = name;
                tbgvcn.Text = gvcns;
                tbsiso.Text = siso;
                tbkhoi.Text = khoi;
                tbghichu.Text = note;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Has an error!");
            }

        }


    }
}
