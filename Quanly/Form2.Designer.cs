
namespace ManageStudent
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnfindcode = new System.Windows.Forms.Button();
            this.txtfindcode = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mssv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rdcode = new System.Windows.Forms.RadioButton();
            this.rdclass = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MScontrol = new System.Windows.Forms.ToolStripMenuItem();
            this.MSadd = new System.Windows.Forms.ToolStripMenuItem();
            this.MSsave = new System.Windows.Forms.ToolStripMenuItem();
            this.btnreset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(313, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản Lý Thông Tin Sinh Viên";
            // 
            // btnfindcode
            // 
            this.btnfindcode.Location = new System.Drawing.Point(622, 56);
            this.btnfindcode.Name = "btnfindcode";
            this.btnfindcode.Size = new System.Drawing.Size(75, 23);
            this.btnfindcode.TabIndex = 4;
            this.btnfindcode.Text = "Tìm kiếm";
            this.btnfindcode.UseVisualStyleBackColor = true;
            this.btnfindcode.Click += new System.EventHandler(this.btnfindcode_Click);
            // 
            // txtfindcode
            // 
            this.txtfindcode.Location = new System.Drawing.Point(323, 70);
            this.txtfindcode.Name = "txtfindcode";
            this.txtfindcode.Size = new System.Drawing.Size(283, 23);
            this.txtfindcode.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mssv,
            this.ho,
            this.ten,
            this.lop,
            this.ngaysinh,
            this.gioitinh,
            this.diachi});
            this.dataGridView1.Location = new System.Drawing.Point(0, 167);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1025, 385);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.Click += new System.EventHandler(this.Form2_click);
            // 
            // mssv
            // 
            this.mssv.DataPropertyName = "Code";
            this.mssv.HeaderText = "Mã Sinh Viên";
            this.mssv.Name = "mssv";
            this.mssv.Width = 150;
            // 
            // ho
            // 
            this.ho.DataPropertyName = "Last";
            this.ho.HeaderText = "Họ Sinh Viên";
            this.ho.Name = "ho";
            this.ho.Width = 130;
            // 
            // ten
            // 
            this.ten.DataPropertyName = "First";
            this.ten.HeaderText = "Tên Sinh Viên";
            this.ten.Name = "ten";
            this.ten.Width = 130;
            // 
            // lop
            // 
            this.lop.DataPropertyName = "Class";
            this.lop.HeaderText = "Lớp";
            this.lop.Name = "lop";
            // 
            // ngaysinh
            // 
            this.ngaysinh.DataPropertyName = "BirthDay";
            this.ngaysinh.HeaderText = "Ngày Sinh";
            this.ngaysinh.Name = "ngaysinh";
            this.ngaysinh.Width = 130;
            // 
            // gioitinh
            // 
            this.gioitinh.DataPropertyName = "Gen";
            this.gioitinh.HeaderText = "Giới Tính";
            this.gioitinh.Name = "gioitinh";
            // 
            // diachi
            // 
            this.diachi.DataPropertyName = "Address";
            this.diachi.HeaderText = "Địa Chỉ";
            this.diachi.Name = "diachi";
            this.diachi.Width = 250;
            // 
            // rdcode
            // 
            this.rdcode.AutoSize = true;
            this.rdcode.Checked = true;
            this.rdcode.Location = new System.Drawing.Point(758, 58);
            this.rdcode.Name = "rdcode";
            this.rdcode.Size = new System.Drawing.Size(92, 19);
            this.rdcode.TabIndex = 21;
            this.rdcode.TabStop = true;
            this.rdcode.Text = "Tìm theo mã";
            this.rdcode.UseVisualStyleBackColor = true;
            // 
            // rdclass
            // 
            this.rdclass.AutoSize = true;
            this.rdclass.Location = new System.Drawing.Point(758, 83);
            this.rdclass.Name = "rdclass";
            this.rdclass.Size = new System.Drawing.Size(92, 19);
            this.rdclass.TabIndex = 22;
            this.rdclass.Text = "Tìm theo lớp";
            this.rdclass.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MScontrol});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1025, 24);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MScontrol
            // 
            this.MScontrol.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MSadd,
            this.MSsave});
            this.MScontrol.Name = "MScontrol";
            this.MScontrol.Size = new System.Drawing.Size(79, 20);
            this.MScontrol.Text = "Chức Năng";
            // 
            // MSadd
            // 
            this.MSadd.Name = "MSadd";
            this.MSadd.Size = new System.Drawing.Size(104, 22);
            this.MSadd.Text = "Thêm";
            this.MSadd.Click += new System.EventHandler(this.MSadd_Click_1);
            // 
            // MSsave
            // 
            this.MSsave.Name = "MSsave";
            this.MSsave.Size = new System.Drawing.Size(104, 22);
            this.MSsave.Text = "Lưu";
            this.MSsave.Click += new System.EventHandler(this.MSsave_Click);
            // 
            // btnreset
            // 
            this.btnreset.Location = new System.Drawing.Point(622, 85);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(75, 23);
            this.btnreset.TabIndex = 24;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 552);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.rdclass);
            this.Controls.Add(this.rdcode);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtfindcode);
            this.Controls.Add(this.btnfindcode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnfindcode;
        private System.Windows.Forms.TextBox txtfindcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn mssv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ho;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn lop;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton rdcode;
        private System.Windows.Forms.RadioButton rdclass;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MScontrol;
        private System.Windows.Forms.ToolStripMenuItem MSadd;
        private System.Windows.Forms.ToolStripMenuItem MSsave;
        private System.Windows.Forms.Button btnreset;
    }
}