
namespace QuanLyNhanVienModel
{
    partial class frmStaff
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.title = new System.Windows.Forms.Label();
            this.title_group = new System.Windows.Forms.GroupBox();
            this.staffDepartment = new System.Windows.Forms.ComboBox();
            this.staffBirthday = new System.Windows.Forms.DateTimePicker();
            this.staffGenF = new System.Windows.Forms.RadioButton();
            this.staffGenM = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.staffAddress = new System.Windows.Forms.TextBox();
            this.staffFull = new System.Windows.Forms.TextBox();
            this.staffLast = new System.Windows.Forms.TextBox();
            this.staffFisrt = new System.Windows.Forms.TextBox();
            this.staffCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnContinue = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.staffList = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.department_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.first_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.last_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.full_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.home = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title_group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffList)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(285, 8);
            this.title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(211, 25);
            this.title.TabIndex = 1;
            this.title.Text = "QUẢN LÝ NHÂN VIÊN";
            this.title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // title_group
            // 
            this.title_group.Controls.Add(this.staffDepartment);
            this.title_group.Controls.Add(this.staffBirthday);
            this.title_group.Controls.Add(this.staffGenF);
            this.title_group.Controls.Add(this.staffGenM);
            this.title_group.Controls.Add(this.label8);
            this.title_group.Controls.Add(this.label7);
            this.title_group.Controls.Add(this.label3);
            this.title_group.Controls.Add(this.staffAddress);
            this.title_group.Controls.Add(this.staffFull);
            this.title_group.Controls.Add(this.staffLast);
            this.title_group.Controls.Add(this.staffFisrt);
            this.title_group.Controls.Add(this.staffCode);
            this.title_group.Controls.Add(this.label6);
            this.title_group.Controls.Add(this.label5);
            this.title_group.Controls.Add(this.label4);
            this.title_group.Controls.Add(this.label2);
            this.title_group.Controls.Add(this.label1);
            this.title_group.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_group.Location = new System.Drawing.Point(12, 44);
            this.title_group.Name = "title_group";
            this.title_group.Size = new System.Drawing.Size(619, 441);
            this.title_group.TabIndex = 2;
            this.title_group.TabStop = false;
            this.title_group.Text = "Thông tin nhân viên";
            // 
            // staffDepartment
            // 
            this.staffDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffDepartment.FormattingEnabled = true;
            this.staffDepartment.Location = new System.Drawing.Point(219, 87);
            this.staffDepartment.Name = "staffDepartment";
            this.staffDepartment.Size = new System.Drawing.Size(392, 28);
            this.staffDepartment.TabIndex = 18;
            // 
            // staffBirthday
            // 
            this.staffBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffBirthday.Location = new System.Drawing.Point(219, 309);
            this.staffBirthday.Name = "staffBirthday";
            this.staffBirthday.Size = new System.Drawing.Size(285, 27);
            this.staffBirthday.TabIndex = 17;
            // 
            // staffGenF
            // 
            this.staffGenF.AutoSize = true;
            this.staffGenF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffGenF.Location = new System.Drawing.Point(300, 264);
            this.staffGenF.Name = "staffGenF";
            this.staffGenF.Size = new System.Drawing.Size(51, 24);
            this.staffGenF.TabIndex = 16;
            this.staffGenF.TabStop = true;
            this.staffGenF.Text = "Nữ";
            this.staffGenF.UseVisualStyleBackColor = true;
            // 
            // staffGenM
            // 
            this.staffGenM.AutoSize = true;
            this.staffGenM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffGenM.Location = new System.Drawing.Point(222, 264);
            this.staffGenM.Name = "staffGenM";
            this.staffGenM.Size = new System.Drawing.Size(65, 24);
            this.staffGenM.TabIndex = 15;
            this.staffGenM.TabStop = true;
            this.staffGenM.Text = "Nam";
            this.staffGenM.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(42, 264);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Giới tính";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(42, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Ngày sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Địa chỉ";
            // 
            // staffAddress
            // 
            this.staffAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffAddress.Location = new System.Drawing.Point(219, 354);
            this.staffAddress.Name = "staffAddress";
            this.staffAddress.Size = new System.Drawing.Size(392, 27);
            this.staffAddress.TabIndex = 10;
            // 
            // staffFull
            // 
            this.staffFull.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffFull.Location = new System.Drawing.Point(219, 222);
            this.staffFull.Name = "staffFull";
            this.staffFull.Size = new System.Drawing.Size(392, 27);
            this.staffFull.TabIndex = 9;
            // 
            // staffLast
            // 
            this.staffLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffLast.Location = new System.Drawing.Point(219, 176);
            this.staffLast.Name = "staffLast";
            this.staffLast.Size = new System.Drawing.Size(285, 27);
            this.staffLast.TabIndex = 8;
            // 
            // staffFisrt
            // 
            this.staffFisrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffFisrt.Location = new System.Drawing.Point(219, 129);
            this.staffFisrt.Name = "staffFisrt";
            this.staffFisrt.Size = new System.Drawing.Size(285, 27);
            this.staffFisrt.TabIndex = 7;
            // 
            // staffCode
            // 
            this.staffCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffCode.Location = new System.Drawing.Point(219, 45);
            this.staffCode.Name = "staffCode";
            this.staffCode.Size = new System.Drawing.Size(285, 27);
            this.staffCode.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(42, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tên đầy đủ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(42, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Họ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên phòng ban";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(637, 58);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(183, 51);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "Thêm mới";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(637, 129);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(183, 51);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(637, 205);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(183, 51);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnContinue
            // 
            this.btnContinue.Location = new System.Drawing.Point(637, 276);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(183, 51);
            this.btnContinue.TabIndex = 7;
            this.btnContinue.Text = "Nhập tiếp";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(637, 403);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(183, 51);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // staffList
            // 
            this.staffList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.staffList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.department_id,
            this.first_name,
            this.last_name,
            this.full_name,
            this.gender,
            this.birthday,
            this.home});
            this.staffList.Location = new System.Drawing.Point(10, 491);
            this.staffList.Name = "staffList";
            this.staffList.RowHeadersWidth = 51;
            this.staffList.RowTemplate.Height = 24;
            this.staffList.Size = new System.Drawing.Size(1133, 234);
            this.staffList.TabIndex = 10;
            this.staffList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.staffList_CellClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Mã nhân viên";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Width = 125;
            // 
            // department_id
            // 
            this.department_id.DataPropertyName = "department_id";
            this.department_id.HeaderText = "Mã phòng ban";
            this.department_id.MinimumWidth = 6;
            this.department_id.Name = "department_id";
            this.department_id.Width = 125;
            // 
            // first_name
            // 
            this.first_name.DataPropertyName = "first_name";
            this.first_name.HeaderText = "Họ";
            this.first_name.MinimumWidth = 6;
            this.first_name.Name = "first_name";
            this.first_name.Width = 125;
            // 
            // last_name
            // 
            this.last_name.DataPropertyName = "last_name";
            this.last_name.HeaderText = "Tên";
            this.last_name.MinimumWidth = 6;
            this.last_name.Name = "last_name";
            this.last_name.Width = 125;
            // 
            // full_name
            // 
            this.full_name.DataPropertyName = "full_name";
            this.full_name.HeaderText = "Tên đầy đủ";
            this.full_name.MinimumWidth = 6;
            this.full_name.Name = "full_name";
            this.full_name.Width = 125;
            // 
            // gender
            // 
            this.gender.DataPropertyName = "gender";
            this.gender.HeaderText = "Giới tính";
            this.gender.MinimumWidth = 6;
            this.gender.Name = "gender";
            this.gender.Width = 125;
            // 
            // birthday
            // 
            this.birthday.DataPropertyName = "birthday";
            this.birthday.HeaderText = "Ngày sinh";
            this.birthday.MinimumWidth = 6;
            this.birthday.Name = "birthday";
            this.birthday.Width = 125;
            // 
            // home
            // 
            this.home.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.home.DataPropertyName = "home";
            this.home.HeaderText = "Địa chỉ";
            this.home.MinimumWidth = 6;
            this.home.Name = "home";
            // 
            // frmStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 737);
            this.Controls.Add(this.staffList);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.title_group);
            this.Controls.Add(this.title);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmStaff";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmStaff_Load);
            this.title_group.ResumeLayout(false);
            this.title_group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.GroupBox title_group;
        private System.Windows.Forms.TextBox staffAddress;
        private System.Windows.Forms.TextBox staffFull;
        private System.Windows.Forms.TextBox staffLast;
        private System.Windows.Forms.TextBox staffFisrt;
        private System.Windows.Forms.TextBox staffCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton staffGenF;
        private System.Windows.Forms.RadioButton staffGenM;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker staffBirthday;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView staffList;
        private System.Windows.Forms.ComboBox staffDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn department_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn first_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn last_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn full_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn home;
    }
}

