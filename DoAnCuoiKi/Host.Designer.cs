namespace DoAnCuoiKi
{
    partial class Host
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblCauHoi = new System.Windows.Forms.Label();
            this.lblDapAn = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnQuanLyCauHoi = new System.Windows.Forms.Button();
            this.btnQuanLyLichPhat = new System.Windows.Forms.Button();
            this.ucCauTraLoi1 = new DoAnCuoiKi.ucCauTraLoi();
            this.ucCauTraLoi2 = new DoAnCuoiKi.ucCauTraLoi();
            this.ucCauTraLoi3 = new DoAnCuoiKi.ucCauTraLoi();
            this.ucCauTraLoi4 = new DoAnCuoiKi.ucCauTraLoi();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCountDown = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThongKeKQ = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(28, 220);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(546, 146);
            this.textBox1.TabIndex = 0;
            // 
            // lblCauHoi
            // 
            this.lblCauHoi.AutoSize = true;
            this.lblCauHoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCauHoi.Location = new System.Drawing.Point(23, 192);
            this.lblCauHoi.Name = "lblCauHoi";
            this.lblCauHoi.Size = new System.Drawing.Size(97, 25);
            this.lblCauHoi.TabIndex = 1;
            this.lblCauHoi.Text = "Câu Hỏi:";
            // 
            // lblDapAn
            // 
            this.lblDapAn.AutoSize = true;
            this.lblDapAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDapAn.Location = new System.Drawing.Point(23, 374);
            this.lblDapAn.Name = "lblDapAn";
            this.lblDapAn.Size = new System.Drawing.Size(91, 25);
            this.lblDapAn.TabIndex = 2;
            this.lblDapAn.Text = "Đáp Án:";
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.Turquoise;
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(691, 485);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(210, 63);
            this.btnSend.TabIndex = 7;
            this.btnSend.Text = "Gởi câu hỏi";
            this.btnSend.UseVisualStyleBackColor = false;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Turquoise;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(946, 485);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(222, 63);
            this.btnNext.TabIndex = 8;
            this.btnNext.Text = "Chuyển câu hỏi";
            this.btnNext.UseVisualStyleBackColor = false;
            // 
            // btnQuanLyCauHoi
            // 
            this.btnQuanLyCauHoi.BackColor = System.Drawing.Color.YellowGreen;
            this.btnQuanLyCauHoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyCauHoi.Location = new System.Drawing.Point(94, 109);
            this.btnQuanLyCauHoi.Name = "btnQuanLyCauHoi";
            this.btnQuanLyCauHoi.Size = new System.Drawing.Size(384, 63);
            this.btnQuanLyCauHoi.TabIndex = 9;
            this.btnQuanLyCauHoi.Text = "Quản Lý Câu Hỏi";
            this.btnQuanLyCauHoi.UseVisualStyleBackColor = false;
            // 
            // btnQuanLyLichPhat
            // 
            this.btnQuanLyLichPhat.BackColor = System.Drawing.Color.YellowGreen;
            this.btnQuanLyLichPhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyLichPhat.Location = new System.Drawing.Point(739, 109);
            this.btnQuanLyLichPhat.Name = "btnQuanLyLichPhat";
            this.btnQuanLyLichPhat.Size = new System.Drawing.Size(384, 63);
            this.btnQuanLyLichPhat.TabIndex = 10;
            this.btnQuanLyLichPhat.Text = "Quản Lý Lịch Phát GameShow";
            this.btnQuanLyLichPhat.UseVisualStyleBackColor = false;
            // 
            // ucCauTraLoi1
            // 
            this.ucCauTraLoi1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ucCauTraLoi1.LaCauTraLoi = false;
            this.ucCauTraLoi1.Location = new System.Drawing.Point(28, 402);
            this.ucCauTraLoi1.Name = "ucCauTraLoi1";
            this.ucCauTraLoi1.NoiDung = "";
            this.ucCauTraLoi1.Size = new System.Drawing.Size(540, 70);
            this.ucCauTraLoi1.TabIndex = 11;
            this.ucCauTraLoi1.TieuDe = "A";
            // 
            // ucCauTraLoi2
            // 
            this.ucCauTraLoi2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ucCauTraLoi2.LaCauTraLoi = false;
            this.ucCauTraLoi2.Location = new System.Drawing.Point(28, 478);
            this.ucCauTraLoi2.Name = "ucCauTraLoi2";
            this.ucCauTraLoi2.NoiDung = "";
            this.ucCauTraLoi2.Size = new System.Drawing.Size(540, 70);
            this.ucCauTraLoi2.TabIndex = 12;
            this.ucCauTraLoi2.TieuDe = "B";
            // 
            // ucCauTraLoi3
            // 
            this.ucCauTraLoi3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ucCauTraLoi3.LaCauTraLoi = false;
            this.ucCauTraLoi3.Location = new System.Drawing.Point(28, 554);
            this.ucCauTraLoi3.Name = "ucCauTraLoi3";
            this.ucCauTraLoi3.NoiDung = "";
            this.ucCauTraLoi3.Size = new System.Drawing.Size(540, 70);
            this.ucCauTraLoi3.TabIndex = 13;
            this.ucCauTraLoi3.TieuDe = "C";
            // 
            // ucCauTraLoi4
            // 
            this.ucCauTraLoi4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ucCauTraLoi4.LaCauTraLoi = false;
            this.ucCauTraLoi4.Location = new System.Drawing.Point(28, 630);
            this.ucCauTraLoi4.Name = "ucCauTraLoi4";
            this.ucCauTraLoi4.NoiDung = "";
            this.ucCauTraLoi4.Size = new System.Drawing.Size(540, 70);
            this.ucCauTraLoi4.TabIndex = 14;
            this.ucCauTraLoi4.TieuDe = "D";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Salmon;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(374, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(477, 67);
            this.button1.TabIndex = 15;
            this.button1.Text = "Khởi động Server";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(612, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Lịch phát sóng:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(617, 220);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(609, 146);
            this.dataGridView1.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1154, 374);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "#Time";
            // 
            // txtCountDown
            // 
            this.txtCountDown.Location = new System.Drawing.Point(809, 417);
            this.txtCountDown.Multiline = true;
            this.txtCountDown.Name = "txtCountDown";
            this.txtCountDown.Size = new System.Drawing.Size(279, 45);
            this.txtCountDown.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(813, 428);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(266, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "#Thời gian chuyển câu hỏi";
            // 
            // btnThongKeKQ
            // 
            this.btnThongKeKQ.BackColor = System.Drawing.Color.SteelBlue;
            this.btnThongKeKQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKeKQ.Location = new System.Drawing.Point(739, 594);
            this.btnThongKeKQ.Name = "btnThongKeKQ";
            this.btnThongKeKQ.Size = new System.Drawing.Size(384, 77);
            this.btnThongKeKQ.TabIndex = 21;
            this.btnThongKeKQ.Text = "Thống kê kết quả";
            this.btnThongKeKQ.UseVisualStyleBackColor = false;
            // 
            // Host
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 725);
            this.Controls.Add(this.btnThongKeKQ);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCountDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ucCauTraLoi4);
            this.Controls.Add(this.ucCauTraLoi3);
            this.Controls.Add(this.ucCauTraLoi2);
            this.Controls.Add(this.ucCauTraLoi1);
            this.Controls.Add(this.btnQuanLyLichPhat);
            this.Controls.Add(this.btnQuanLyCauHoi);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.lblDapAn);
            this.Controls.Add(this.lblCauHoi);
            this.Controls.Add(this.textBox1);
            this.Name = "Host";
            this.Text = "Host: Ai Là Triệu Phú";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblCauHoi;
        private System.Windows.Forms.Label lblDapAn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnQuanLyCauHoi;
        private System.Windows.Forms.Button btnQuanLyLichPhat;
        private ucCauTraLoi ucCauTraLoi1;
        private ucCauTraLoi ucCauTraLoi2;
        private ucCauTraLoi ucCauTraLoi3;
        private ucCauTraLoi ucCauTraLoi4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCountDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnThongKeKQ;
    }
}