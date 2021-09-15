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
    public partial class FormGiaoVien : Form
    {
        public FormGiaoVien()
        {
            InitializeComponent();
        }

        private void FormGiaoVien_Load(object sender, EventArgs e)
        {
            try
            {
                QuanliphongtinDataContext db = new QuanliphongtinDataContext();
                dtgvData.DataSource = db.GIAOVIENs.Select(d => d);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Server has been easy");
            }

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (QuanliphongtinDataContext db = new QuanliphongtinDataContext())
                {
                    GIAOVIEN add = new GIAOVIEN();
                    add.NAME = tbname.Text;
                    add.CHUYENMON = tbChuyenmon.Text;
                    add.GHICHU = tbnote.Text;

                    db.GIAOVIENs.InsertOnSubmit(add);
                    db.SubmitChanges();

                    dtgvData.DataSource = db.GIAOVIENs.Select(d => d);
                    tbname.Text = "";
                    tbChuyenmon.Text = "";
                    tbnote.Text = "";
                }
            }
            catch(Exception ex )
            {
                MessageBox.Show("Lỗ định dạng dữ liệu");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Desktop dt = new Desktop();
            dt.Show();
        }

        private void dtgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string id = dtgvData.SelectedCells[0].OwningRow.Cells["MAGV"].Value.ToString();
                string name = dtgvData.SelectedCells[0].OwningRow.Cells["NAME"].Value.ToString();
                string chuyenmon = dtgvData.SelectedCells[0].OwningRow.Cells["CHUYENMON"].Value.ToString();
                string note = dtgvData.SelectedCells[0].OwningRow.Cells["GHICHU"].Value.ToString();

                tbID.Text = id;
                tbname.Text = name;
                tbChuyenmon.Text = chuyenmon;
                tbnote.Text = note;
            }
            catch(Exception ez)
            {
                MessageBox.Show("Server has been easy");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                QuanliphongtinDataContext db = new QuanliphongtinDataContext();
                int id = int.Parse(tbID.Text);
                if (id == null) lbError.Text = "Need a record to edit!!!";
                else
                {
                    GIAOVIEN edit = db.GIAOVIENs.Where(d => d.MAGV.Equals(id)).SingleOrDefault();

                    edit.NAME = tbname.Text;
                    edit.CHUYENMON = tbChuyenmon.Text;
                    edit.GHICHU = tbnote.Text;

                    db.SubmitChanges();
                    dtgvData.DataSource = db.GIAOVIENs.Select(d => d);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi");
            }
        }


        static int idd;
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                
                    QuanliphongtinDataContext db = new QuanliphongtinDataContext();
                DialogResult res = MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi này?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == System.Windows.Forms.DialogResult.Yes)
                {
                    string cid;
                    if (tbID.Text == "(value default)") cid = null;
                    else cid = tbID.Text;
                    if (cid == null) lbError.Text = "ID null!!";
                    else idd = int.Parse(cid);
                    if (idd == null) lbError.Text = "Please choose a record before click this button!!!";
                    else
                    {
                        GIAOVIEN delete = db.GIAOVIENs.Where(d => d.MAGV.Equals(idd)).SingleOrDefault();

                        delete.NAME = tbname.Text;
                        delete.CHUYENMON = tbChuyenmon.Text;
                        delete.GHICHU = tbnote.Text;

                        db.GIAOVIENs.DeleteOnSubmit(delete);

                        db.SubmitChanges();
                        dtgvData.DataSource = db.GIAOVIENs.Select(d => d);
                        tbID.Text = "(value default)";
                        tbname.Text = "";
                        tbChuyenmon.Text = "";
                        tbnote.Text = "";
                    }
                }
                else db.GIAOVIENs.Select(d => d);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Can't delete");
            }
        }
    }
}
