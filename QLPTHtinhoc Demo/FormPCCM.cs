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
    public partial class FormPCCM : Form
    {
        public FormPCCM()
        {
            InitializeComponent();
        }

        QuanliphongtinDataContext db = new QuanliphongtinDataContext();
        private void FormPCCM_Load(object sender, EventArgs e)
        {
            try
            {
                dgvShow.DataSource = db.PCCPs.Select(d => d);

                cbbIDClass.DataSource = db.CLASSes.Select(d => d.MALOP + " - " + d.TENLOP);

                cbbIDGV.DataSource = db.GIAOVIENs.Select(h => h.MAGV + " - " + h.NAME);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Server has been easy. Try again later");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                PCCP ent = new PCCP();
                string idgv = cbbIDGV.SelectedItem.ToString();
                string idlop = cbbIDClass.SelectedItem.ToString();
                ent.MAGV = int.Parse(tbidgv.Text);
                ent.MALOP = int.Parse(tbidlop.Text);

                db.PCCPs.InsertOnSubmit(ent);
                db.SubmitChanges();
                dgvShow.DataSource = db.PCCPs.Select(d => d);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi nhập dữ liệu");
            }
        }
        
        private void dgvShow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string id = dgvShow.SelectedCells[0].OwningRow.Cells["ID"].Value.ToString();
                string idgv = dgvShow.SelectedCells[0].OwningRow.Cells["MAGV"].Value.ToString();
                string idlop = dgvShow.SelectedCells[0].OwningRow.Cells["MALOP"].Value.ToString();

                textBox1.Text = id;
                tbidgv.Text = idgv;
                tbidlop.Text = idlop;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Has an Error");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                QuanliphongtinDataContext dj = new QuanliphongtinDataContext();
                int id = int.Parse(textBox1.Text);
                PCCP edit = dj.PCCPs.Where(d => d.ID.Equals(id)).SingleOrDefault();

                edit.MAGV = int.Parse(tbidgv.Text);
                edit.MALOP = int.Parse(tbidlop.Text);

                dj.SubmitChanges();

                dgvShow.DataSource = dj.PCCPs.Select(d => d);
                tbidlop.Text = "";
                tbidgv.Text = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi!");
            }
        }

        private void cbbIDGV_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                string idgv = cbbIDGV.SelectedItem.ToString();
                string nidgv = "";
                string idlop = cbbIDClass.SelectedItem.ToString();
                string nidlop = "";
                for (int i = 0; i <= idgv.Length; i++)
                {
                    if (idgv[i].ToString() == " ") break;
                    else nidgv += idgv[i];
                }
                for (int i = 0; i <= idlop.Length; i++)
                {
                    if (idlop[i].ToString() == " ") break;
                    else nidlop += idlop[i];
                }
                tbidgv.Text = nidgv;
                tbidlop.Text = nidlop;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Has an Error");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Desktop dt = new Desktop();
            dt.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi này không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    int id = int.Parse(textBox1.Text);
                    PCCP ent = db.PCCPs.Where(d => d.ID.Equals(id)).SingleOrDefault();

                    ent.MAGV = int.Parse(tbidgv.Text);
                    ent.MALOP = int.Parse(tbidlop.Text);

                    db.PCCPs.DeleteOnSubmit(ent);
                    db.SubmitChanges();

                    dgvShow.DataSource = db.PCCPs.Select(d => d);
                    tbidlop.Text = "";
                    tbidgv.Text = "";
                }
                else db.PCCPs.Select(d => d);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Can't delete");
            }
        }

        private void cbbIDClass_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                string idgv = cbbIDGV.SelectedItem.ToString();
                string nidgv = "";
                string idlop = cbbIDClass.SelectedItem.ToString();
                string nidlop = "";
                for (int i = 0; i <= idgv.Length; i++)
                {
                    if (idgv[i].ToString() == " ") break;
                    else nidgv += idgv[i];
                }
                for (int i = 0; i <= idlop.Length; i++)
                {
                    if (idlop[i].ToString() == " ") break;
                    else nidlop += idlop[i];
                }
                tbidgv.Text = nidgv;
                tbidlop.Text = nidlop;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Has an Error");
            }
        }

    }
}
