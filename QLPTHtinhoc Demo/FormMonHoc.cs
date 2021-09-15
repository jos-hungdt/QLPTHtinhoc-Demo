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
    public partial class FormMonHoc : Form
    {
        public FormMonHoc()
        {
            InitializeComponent();
        }

        private void FormMonHoc_Load(object sender, EventArgs e)
        {
            try
            {
                QuanliphongtinDataContext db = new QuanliphongtinDataContext();
                dtgvData.DataSource = db.MONHOCs.Select(d => d);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Server has been easy");
            }
        }

        QuanliphongtinDataContext db = new QuanliphongtinDataContext();
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Desktop dt = new Desktop();
            dt.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                MONHOC add = new MONHOC();

                add.NAMESUBJECT = tbName.Text;
                add.GHICHU = tbghichu.Text;

                db.MONHOCs.InsertOnSubmit(add);
                db.SubmitChanges();

                dtgvData.DataSource = db.MONHOCs.Select(d => d);
                tbName.Text = "";
                tbghichu.Text = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi định dạng dữ liệu nhập vào");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(tbID.Text);

                MONHOC delete = db.MONHOCs.Where(d => d.MAMON.Equals(id)).SingleOrDefault();
                delete.NAMESUBJECT = tbName.Text;
                delete.GHICHU = tbghichu.Text;

                DialogResult result = MessageBox.Show("Are you sure wanna delete this record?", "caption", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    db.MONHOCs.DeleteOnSubmit(delete);
                    db.SubmitChanges();
                    dtgvData.DataSource = db.MONHOCs.Select(d => d);
                }
                else
                    db.MONHOCs.Select(d => d);
                tbID.Text = "(Default by System)";
                tbName.Text = "";
                tbghichu.Text = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show("Can't delete");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(tbID.Text);

                MONHOC edit = db.MONHOCs.Where(d => d.MAMON.Equals(id)).SingleOrDefault();
                edit.NAMESUBJECT = tbName.Text;
                edit.GHICHU = tbghichu.Text;

                db.SubmitChanges();
                dtgvData.DataSource = db.MONHOCs.Select(d => d);
                tbID.Text = "(Default by System)";
                tbName.Text = "";
                tbghichu.Text = "";

                db.SubmitChanges();
                db.MONHOCs.Select(d => d);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Server has been easy");
            }
        }
        private void dtgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string id = dtgvData.SelectedCells[0].OwningRow.Cells["MAMON"].Value.ToString();
                string name = dtgvData.SelectedCells[0].OwningRow.Cells["NAMESUBJECT"].Value.ToString();
                string note = dtgvData.SelectedCells[0].OwningRow.Cells["GHICHU"].Value.ToString();

                tbID.Text = id;
                tbName.Text = name;
                tbghichu.Text = note;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Has an Error");
            }
        }

    }
}
