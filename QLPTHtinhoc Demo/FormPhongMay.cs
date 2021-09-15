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
    public partial class FormPhongMay : Form
    {
        public FormPhongMay()
        {
            InitializeComponent();
        }

        private void FormPhongMay_Load(object sender, EventArgs e)
        {
            try
            {
                QuanliphongtinDataContext db = new QuanliphongtinDataContext();
                dgvShow.DataSource = db.PHONGMAYs.Select(d => d);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Server has been easy");
            }

        }
        QuanliphongtinDataContext db = new QuanliphongtinDataContext();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                PHONGMAY add = new PHONGMAY();
                add.NAME = tbName.Text;
                add.GHICHU = tbGhichu.Text;
                add.SOMAY = int.Parse(tbSomay.Text);
                add.STATUT = tbStatus.Text;

                db.PHONGMAYs.InsertOnSubmit(add);
                db.SubmitChanges();

                dgvShow.DataSource = db.PHONGMAYs.Select(d => d);
                tbStatus.Text = "";
                tbSomay.Text = "";
                tbName.Text = "";
                tbGhichu.Text = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi định dạng dữ liệu nhập vào");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(textBox1.Text);
                PHONGMAY edit = db.PHONGMAYs.Where(d => d.MAPHONG.Equals(id)).SingleOrDefault();

                edit.NAME = tbName.Text;
                edit.GHICHU = tbGhichu.Text;
                edit.SOMAY = int.Parse(tbSomay.Text);
                edit.STATUT = tbStatus.Text;

                db.SubmitChanges();
                dgvShow.DataSource = db.PHONGMAYs.Select(d => d);
                tbStatus.Text = "";
                tbSomay.Text = "";
                tbName.Text = "";
                tbGhichu.Text = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                
                    DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xóa bản ghi này chứ?", "Cảnh báo", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        int id = int.Parse(textBox1.Text);
                        PHONGMAY delete = db.PHONGMAYs.Where(d => d.MAPHONG.Equals(id)).SingleOrDefault();
                        delete.NAME = tbName.Text;
                        delete.SOMAY = int.Parse(tbSomay.Text);
                        delete.STATUT = tbStatus.Text;
                        delete.GHICHU = tbGhichu.Text;

                        db.PHONGMAYs.DeleteOnSubmit(delete);

                        db.SubmitChanges();
                        dgvShow.DataSource = db.PHONGMAYs.Select(d => d);
                    }
                    else dgvShow.DataSource = db.PHONGMAYs.Select(d => d);
                    tbStatus.Text = "";
                    tbSomay.Text = "";
                    tbName.Text = "";
                    tbGhichu.Text = "";
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Còn có các tiết học ở phòng này. Không thể Remove phòng học này");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Desktop dt = new Desktop();
            dt.Show();
        }

        private void dgvShow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string id = dgvShow.SelectedCells[0].OwningRow.Cells["MAPHONG"].Value.ToString();
                string name = dgvShow.SelectedCells[0].OwningRow.Cells["NAME"].Value.ToString();
                string somay = dgvShow.SelectedCells[0].OwningRow.Cells["SOMAY"].Value.ToString();
                string status = dgvShow.SelectedCells[0].OwningRow.Cells["STATUT"].Value.ToString();
                string ghichu = dgvShow.SelectedCells[0].OwningRow.Cells["GHICHU"].Value.ToString();

                tbGhichu.Text = ghichu;
                tbName.Text = name;
                tbSomay.Text = somay;
                tbStatus.Text = status;
                textBox1.Text = id;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Has an Error");
            }
        }

    }
}
