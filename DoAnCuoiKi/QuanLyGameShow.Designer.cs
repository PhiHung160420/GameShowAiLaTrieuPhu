namespace DoAnCuoiKi
{
    partial class QuanLyGameShow
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
            this.components = new System.ComponentModel.Container();
            this.gbChucNang = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnNotSave = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvQLGameShow = new System.Windows.Forms.DataGridView();
            this.gbThongTin = new System.Windows.Forms.GroupBox();
            this.tbxEndTime = new System.Windows.Forms.TextBox();
            this.tbxStartTime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gameShowBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLGameShow)).BeginInit();
            this.gbThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameShowBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gbChucNang
            // 
            this.gbChucNang.Controls.Add(this.btnExit);
            this.gbChucNang.Controls.Add(this.btnNotSave);
            this.gbChucNang.Controls.Add(this.btnSave);
            this.gbChucNang.Controls.Add(this.btnDelete);
            this.gbChucNang.Controls.Add(this.btnUpdate);
            this.gbChucNang.Controls.Add(this.btnAdd);
            this.gbChucNang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbChucNang.Location = new System.Drawing.Point(12, 262);
            this.gbChucNang.Name = "gbChucNang";
            this.gbChucNang.Size = new System.Drawing.Size(1178, 109);
            this.gbChucNang.TabIndex = 1;
            this.gbChucNang.TabStop = false;
            this.gbChucNang.Text = "Chức Năng";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1042, 29);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 56);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnNotSave
            // 
            this.btnNotSave.Location = new System.Drawing.Point(876, 29);
            this.btnNotSave.Name = "btnNotSave";
            this.btnNotSave.Size = new System.Drawing.Size(112, 56);
            this.btnNotSave.TabIndex = 4;
            this.btnNotSave.Text = "K.Lưu";
            this.btnNotSave.UseVisualStyleBackColor = true;
            this.btnNotSave.Click += new System.EventHandler(this.btnNotSave_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(705, 29);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 56);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(367, 29);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 56);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(174, 29);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(146, 56);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Cập Nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(23, 29);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 56);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvQLGameShow
            // 
            this.dgvQLGameShow.AutoGenerateColumns = false;
            this.dgvQLGameShow.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvQLGameShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQLGameShow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.endDateDataGridViewTextBoxColumn});
            this.dgvQLGameShow.DataSource = this.gameShowBindingSource;
            this.dgvQLGameShow.Location = new System.Drawing.Point(12, 12);
            this.dgvQLGameShow.Name = "dgvQLGameShow";
            this.dgvQLGameShow.RowHeadersWidth = 62;
            this.dgvQLGameShow.RowTemplate.Height = 28;
            this.dgvQLGameShow.Size = new System.Drawing.Size(1178, 244);
            this.dgvQLGameShow.TabIndex = 2;
            this.dgvQLGameShow.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQLGameShow_CellClick);
            // 
            // gbThongTin
            // 
            this.gbThongTin.Controls.Add(this.label5);
            this.gbThongTin.Controls.Add(this.label1);
            this.gbThongTin.Controls.Add(this.tbxEndTime);
            this.gbThongTin.Controls.Add(this.tbxStartTime);
            this.gbThongTin.Controls.Add(this.label4);
            this.gbThongTin.Controls.Add(this.label3);
            this.gbThongTin.Controls.Add(this.txtName);
            this.gbThongTin.Controls.Add(this.label2);
            this.gbThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbThongTin.Location = new System.Drawing.Point(326, 387);
            this.gbThongTin.Name = "gbThongTin";
            this.gbThongTin.Size = new System.Drawing.Size(529, 267);
            this.gbThongTin.TabIndex = 3;
            this.gbThongTin.TabStop = false;
            this.gbThongTin.Text = "Thông tin";
            // 
            // tbxEndTime
            // 
            this.tbxEndTime.Location = new System.Drawing.Point(153, 188);
            this.tbxEndTime.Multiline = true;
            this.tbxEndTime.Name = "tbxEndTime";
            this.tbxEndTime.Size = new System.Drawing.Size(357, 38);
            this.tbxEndTime.TabIndex = 33;
            // 
            // tbxStartTime
            // 
            this.tbxStartTime.Location = new System.Drawing.Point(153, 103);
            this.tbxStartTime.Multiline = true;
            this.tbxStartTime.Name = "tbxStartTime";
            this.tbxStartTime.Size = new System.Drawing.Size(357, 39);
            this.tbxStartTime.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "End Time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Start Time:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(153, 34);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(357, 43);
            this.txtName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 29);
            this.label1.TabIndex = 34;
            this.label1.Text = "MM/dd/YYYY hh:mm:ss";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(148, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(286, 29);
            this.label5.TabIndex = 35;
            this.label5.Text = "MM/dd/YYYY hh:mm:ss";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 150;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 200;
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "StartDate";
            this.startDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            this.startDateDataGridViewTextBoxColumn.Width = 200;
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            this.endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
            this.endDateDataGridViewTextBoxColumn.HeaderText = "EndDate";
            this.endDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            this.endDateDataGridViewTextBoxColumn.Width = 200;
            // 
            // gameShowBindingSource
            // 
            this.gameShowBindingSource.DataSource = typeof(DoAnCuoiKi.GameShow);
            // 
            // QuanLyGameShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 666);
            this.Controls.Add(this.gbThongTin);
            this.Controls.Add(this.dgvQLGameShow);
            this.Controls.Add(this.gbChucNang);
            this.Name = "QuanLyGameShow";
            this.Text = "Quản Lý Lịch Phát GameShow";
            this.Load += new System.EventHandler(this.QuanLyGameShow_Load);
            this.gbChucNang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLGameShow)).EndInit();
            this.gbThongTin.ResumeLayout(false);
            this.gbThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameShowBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbChucNang;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnNotSave;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvQLGameShow;
        private System.Windows.Forms.GroupBox gbThongTin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource gameShowBindingSource;
        private System.Windows.Forms.TextBox tbxEndTime;
        private System.Windows.Forms.TextBox tbxStartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
    }
}