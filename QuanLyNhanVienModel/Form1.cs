using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanVienModel
{
    public partial class frmStaff : Form
    {
        Database desod = new Database();

        public frmStaff()
        {
            InitializeComponent();
        }
        private void frmStaff_Load(object sender, EventArgs e)
        {
            this.getDepartment();
            this.getStaff();

            staffGenM.Checked = true;
            staffGenF.Checked = false;

            staffCode.Focus();
        }

        private void getDepartment()
        {
            string[] selectWhat = { };
            DataTable getData = desod.read("DEPARTMENT", selectWhat);

            staffDepartment.DataSource = getData;
            staffDepartment.DisplayMember = "department";
            staffDepartment.ValueMember = "id";
        }
        private void getStaff()
        {
            string[] selectWhat = { };
            DataTable getData = desod.read("STAFF", selectWhat);

            staffList.DataSource = getData;
        }
        private string[] Keys()
        {
            string[] keys = {
                "id",
                "department_id",
                "first_name",
                "last_name",
                "full_name",
                "gender",
                "birthday",
                "home",
            };

            return keys;
        }

        private string[] Values()
        {
            string gender;

            if (staffGenM.Checked == true)
                gender = "Nam";
            else
                gender = "Nữ";

            string[] values = {
                "'" + staffCode.Text + "'",
                "'" + staffDepartment.SelectedValue.ToString() + "'",
                "N'" + staffFisrt.Text + "'",
                "N'" + staffLast.Text + "'",
                "N'" + staffFull.Text + "'",
                "N'" + gender + "'",
                "'" + staffBirthday.Value.Date.ToString("yyyy/MM/dd") + "'",
                "N'" + staffAddress.Text + "'",
            };

            return values;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string[] selectWhat = { };

            DataTable staff = desod.read("STAFF", selectWhat, "id", staffCode.Text);

            if (staff.Rows.Count == 0)
            {
                desod.store("STAFF", this.Keys(), this.Values());
                this.getStaff();
            }
            else
                MessageBox.Show("Mã nhân viên đã tồn tại !", "Có lỗi xuất hiện", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string[] selectWhat = { };

            DataTable staff = desod.read("STAFF", selectWhat, "id", staffCode.Text);

            if (staff.Rows.Count > 0)
            {
                desod.update("STAFF", this.Keys(), this.Values(), "id", staffCode.Text);
                this.getStaff();
            }
            else
                MessageBox.Show("Mã nhân viên không tồn tại !", "Có lỗi xuất hiện", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string[] selectWhat = { };

            DataTable staff = desod.read("STAFF", selectWhat, "id", staffCode.Text);

            if (staff.Rows.Count > 0)
            {
                desod.delete("STAFF", "id", staffCode.Text);
                this.getStaff();
            }
            else
                MessageBox.Show("Mã nhân viên không tồn tại !", "Có lỗi xuất hiện", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            staffCode.Clear();
            getDepartment();
            staffFisrt.Clear();
            staffLast.Clear();
            staffFull.Clear();
            staffGenM.Checked = true;
            staffGenF.Checked = false;
            staffAddress.Clear();
            staffCode.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult ok = new DialogResult();
            ok = MessageBox.Show("Bạn có muốn thoát?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (ok == DialogResult.Yes)
                Application.Exit();

        }

        private void staffList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var replace = staffList.Rows[e.RowIndex];

            string[] selectWhat = { };

            DataTable Department = desod.read("DEPARTMENT", selectWhat, "id", replace.Cells[1].Value.ToString());

            DataRow row = Department.Rows[0];

            staffCode.Text = replace.Cells[0].Value.ToString();
            staffDepartment.Text = row["department"].ToString();
            staffFisrt.Text = replace.Cells[2].Value.ToString();
            staffLast.Text = replace.Cells[3].Value.ToString();
            staffFull.Text = replace.Cells[4].Value.ToString();

            if(replace.Cells[5].Value.ToString() == "Nam")
                staffGenM.Checked = true;
            else if (replace.Cells[5].Value.ToString() == "Nữ")
                staffGenF.Checked = true;

            staffBirthday.Text = replace.Cells[6].Value.ToString();
            staffAddress.Text = replace.Cells[7].Value.ToString();
        }
    }
}
