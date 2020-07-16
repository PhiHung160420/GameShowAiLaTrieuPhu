namespace DoAnCuoiKi
{
    partial class QuanLyCauHoi
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
            this.gbQuestion = new System.Windows.Forms.GroupBox();
            this.tbxQuestion = new System.Windows.Forms.TextBox();
            this.gbTraLoi = new System.Windows.Forms.GroupBox();
            this.tbxAnswer = new System.Windows.Forms.TextBox();
            this.lblDapAn = new System.Windows.Forms.Label();
            this.tbxAnswerD = new System.Windows.Forms.TextBox();
            this.tbxAnswerC = new System.Windows.Forms.TextBox();
            this.tbxAnswerB = new System.Windows.Forms.TextBox();
            this.tbxAnswerA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.dgvQuanLy = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.answerADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.answerBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.answerCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.answerDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.answerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbChucNang.SuspendLayout();
            this.gbQuestion.SuspendLayout();
            this.gbTraLoi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionBindingSource)).BeginInit();
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
            this.gbChucNang.Location = new System.Drawing.Point(12, 247);
            this.gbChucNang.Name = "gbChucNang";
            this.gbChucNang.Size = new System.Drawing.Size(1203, 109);
            this.gbChucNang.TabIndex = 0;
            this.gbChucNang.TabStop = false;
            this.gbChucNang.Text = "Chức Năng";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1042, 40);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 45);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnNotSave
            // 
            this.btnNotSave.Location = new System.Drawing.Point(876, 40);
            this.btnNotSave.Name = "btnNotSave";
            this.btnNotSave.Size = new System.Drawing.Size(112, 45);
            this.btnNotSave.TabIndex = 4;
            this.btnNotSave.Text = "K.Lưu";
            this.btnNotSave.UseVisualStyleBackColor = true;
            this.btnNotSave.Click += new System.EventHandler(this.btnNotSave_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(705, 40);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 45);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(348, 40);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 45);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(174, 40);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(133, 45);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Cập Nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(23, 40);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 45);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gbQuestion
            // 
            this.gbQuestion.Controls.Add(this.tbxQuestion);
            this.gbQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbQuestion.Location = new System.Drawing.Point(12, 382);
            this.gbQuestion.Name = "gbQuestion";
            this.gbQuestion.Size = new System.Drawing.Size(572, 288);
            this.gbQuestion.TabIndex = 1;
            this.gbQuestion.TabStop = false;
            this.gbQuestion.Text = "Câu Hỏi";
            // 
            // tbxQuestion
            // 
            this.tbxQuestion.Location = new System.Drawing.Point(6, 54);
            this.tbxQuestion.Multiline = true;
            this.tbxQuestion.Name = "tbxQuestion";
            this.tbxQuestion.Size = new System.Drawing.Size(545, 215);
            this.tbxQuestion.TabIndex = 2;
            // 
            // gbTraLoi
            // 
            this.gbTraLoi.Controls.Add(this.tbxAnswer);
            this.gbTraLoi.Controls.Add(this.lblDapAn);
            this.gbTraLoi.Controls.Add(this.tbxAnswerD);
            this.gbTraLoi.Controls.Add(this.tbxAnswerC);
            this.gbTraLoi.Controls.Add(this.tbxAnswerB);
            this.gbTraLoi.Controls.Add(this.tbxAnswerA);
            this.gbTraLoi.Controls.Add(this.label3);
            this.gbTraLoi.Controls.Add(this.label2);
            this.gbTraLoi.Controls.Add(this.label1);
            this.gbTraLoi.Controls.Add(this.lblA);
            this.gbTraLoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTraLoi.Location = new System.Drawing.Point(689, 382);
            this.gbTraLoi.Name = "gbTraLoi";
            this.gbTraLoi.Size = new System.Drawing.Size(526, 288);
            this.gbTraLoi.TabIndex = 2;
            this.gbTraLoi.TabStop = false;
            this.gbTraLoi.Text = "Trả Lời";
            // 
            // tbxAnswer
            // 
            this.tbxAnswer.Location = new System.Drawing.Point(105, 225);
            this.tbxAnswer.Name = "tbxAnswer";
            this.tbxAnswer.Size = new System.Drawing.Size(355, 30);
            this.tbxAnswer.TabIndex = 9;
            // 
            // lblDapAn
            // 
            this.lblDapAn.AutoSize = true;
            this.lblDapAn.Location = new System.Drawing.Point(15, 228);
            this.lblDapAn.Name = "lblDapAn";
            this.lblDapAn.Size = new System.Drawing.Size(84, 25);
            this.lblDapAn.TabIndex = 8;
            this.lblDapAn.Text = "Đáp Án";
            // 
            // tbxAnswerD
            // 
            this.tbxAnswerD.Location = new System.Drawing.Point(105, 173);
            this.tbxAnswerD.Name = "tbxAnswerD";
            this.tbxAnswerD.Size = new System.Drawing.Size(355, 30);
            this.tbxAnswerD.TabIndex = 7;
            // 
            // tbxAnswerC
            // 
            this.tbxAnswerC.Location = new System.Drawing.Point(105, 130);
            this.tbxAnswerC.Name = "tbxAnswerC";
            this.tbxAnswerC.Size = new System.Drawing.Size(355, 30);
            this.tbxAnswerC.TabIndex = 6;
            // 
            // tbxAnswerB
            // 
            this.tbxAnswerB.Location = new System.Drawing.Point(105, 85);
            this.tbxAnswerB.Name = "tbxAnswerB";
            this.tbxAnswerB.Size = new System.Drawing.Size(355, 30);
            this.tbxAnswerB.TabIndex = 5;
            // 
            // tbxAnswerA
            // 
            this.tbxAnswerA.Location = new System.Drawing.Point(105, 38);
            this.tbxAnswerA.Name = "tbxAnswerA";
            this.tbxAnswerA.Size = new System.Drawing.Size(355, 30);
            this.tbxAnswerA.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "D";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "C";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "B";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(32, 43);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(27, 25);
            this.lblA.TabIndex = 0;
            this.lblA.Text = "A";
            // 
            // dgvQuanLy
            // 
            this.dgvQuanLy.AutoGenerateColumns = false;
            this.dgvQuanLy.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvQuanLy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuanLy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.contentDataGridViewTextBoxColumn,
            this.answerADataGridViewTextBoxColumn,
            this.answerBDataGridViewTextBoxColumn,
            this.answerCDataGridViewTextBoxColumn,
            this.answerDDataGridViewTextBoxColumn,
            this.answerDataGridViewTextBoxColumn});
            this.dgvQuanLy.DataSource = this.questionBindingSource;
            this.dgvQuanLy.Location = new System.Drawing.Point(12, 2);
            this.dgvQuanLy.Name = "dgvQuanLy";
            this.dgvQuanLy.RowHeadersWidth = 62;
            this.dgvQuanLy.RowTemplate.Height = 28;
            this.dgvQuanLy.Size = new System.Drawing.Size(1203, 239);
            this.dgvQuanLy.TabIndex = 3;
            this.dgvQuanLy.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuanLy_CellClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 50;
            // 
            // contentDataGridViewTextBoxColumn
            // 
            this.contentDataGridViewTextBoxColumn.DataPropertyName = "Content";
            this.contentDataGridViewTextBoxColumn.HeaderText = "Content";
            this.contentDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.contentDataGridViewTextBoxColumn.Name = "contentDataGridViewTextBoxColumn";
            this.contentDataGridViewTextBoxColumn.Width = 300;
            // 
            // answerADataGridViewTextBoxColumn
            // 
            this.answerADataGridViewTextBoxColumn.DataPropertyName = "AnswerA";
            this.answerADataGridViewTextBoxColumn.HeaderText = "AnswerA";
            this.answerADataGridViewTextBoxColumn.MinimumWidth = 8;
            this.answerADataGridViewTextBoxColumn.Name = "answerADataGridViewTextBoxColumn";
            this.answerADataGridViewTextBoxColumn.Width = 150;
            // 
            // answerBDataGridViewTextBoxColumn
            // 
            this.answerBDataGridViewTextBoxColumn.DataPropertyName = "AnswerB";
            this.answerBDataGridViewTextBoxColumn.HeaderText = "AnswerB";
            this.answerBDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.answerBDataGridViewTextBoxColumn.Name = "answerBDataGridViewTextBoxColumn";
            this.answerBDataGridViewTextBoxColumn.Width = 150;
            // 
            // answerCDataGridViewTextBoxColumn
            // 
            this.answerCDataGridViewTextBoxColumn.DataPropertyName = "AnswerC";
            this.answerCDataGridViewTextBoxColumn.HeaderText = "AnswerC";
            this.answerCDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.answerCDataGridViewTextBoxColumn.Name = "answerCDataGridViewTextBoxColumn";
            this.answerCDataGridViewTextBoxColumn.Width = 150;
            // 
            // answerDDataGridViewTextBoxColumn
            // 
            this.answerDDataGridViewTextBoxColumn.DataPropertyName = "AnswerD";
            this.answerDDataGridViewTextBoxColumn.HeaderText = "AnswerD";
            this.answerDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.answerDDataGridViewTextBoxColumn.Name = "answerDDataGridViewTextBoxColumn";
            this.answerDDataGridViewTextBoxColumn.Width = 150;
            // 
            // answerDataGridViewTextBoxColumn
            // 
            this.answerDataGridViewTextBoxColumn.DataPropertyName = "Answer";
            this.answerDataGridViewTextBoxColumn.HeaderText = "Answer";
            this.answerDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.answerDataGridViewTextBoxColumn.Name = "answerDataGridViewTextBoxColumn";
            this.answerDataGridViewTextBoxColumn.Width = 150;
            // 
            // questionBindingSource
            // 
            this.questionBindingSource.DataSource = typeof(DoAnCuoiKi.Question);
            // 
            // QuanLyCauHoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 682);
            this.Controls.Add(this.dgvQuanLy);
            this.Controls.Add(this.gbTraLoi);
            this.Controls.Add(this.gbQuestion);
            this.Controls.Add(this.gbChucNang);
            this.Name = "QuanLyCauHoi";
            this.Text = "QuanLyCauHoi";
            this.Load += new System.EventHandler(this.QuanLyCauHoi_Load);
            this.gbChucNang.ResumeLayout(false);
            this.gbQuestion.ResumeLayout(false);
            this.gbQuestion.PerformLayout();
            this.gbTraLoi.ResumeLayout(false);
            this.gbTraLoi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionBindingSource)).EndInit();
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
        private System.Windows.Forms.GroupBox gbQuestion;
        private System.Windows.Forms.TextBox tbxQuestion;
        private System.Windows.Forms.GroupBox gbTraLoi;
        private System.Windows.Forms.TextBox tbxAnswer;
        private System.Windows.Forms.Label lblDapAn;
        private System.Windows.Forms.TextBox tbxAnswerD;
        private System.Windows.Forms.TextBox tbxAnswerC;
        private System.Windows.Forms.TextBox tbxAnswerB;
        private System.Windows.Forms.TextBox tbxAnswerA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.DataGridView dgvQuanLy;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn answerADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn answerBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn answerCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn answerDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn answerDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource questionBindingSource;
    }
}