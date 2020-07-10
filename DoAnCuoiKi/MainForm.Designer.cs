namespace DoAnCuoiKi
{
    partial class MainForm
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
            this.tbxQuestion = new System.Windows.Forms.TextBox();
            this.ucCauTraLoi1 = new DoAnCuoiKi.ucCauTraLoi();
            this.ucCauTraLoi2 = new DoAnCuoiKi.ucCauTraLoi();
            this.ucCauTraLoi3 = new DoAnCuoiKi.ucCauTraLoi();
            this.ucCauTraLoi4 = new DoAnCuoiKi.ucCauTraLoi();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGoiNguoiThan = new System.Windows.Forms.Button();
            this.btnToTuVan = new System.Windows.Forms.Button();
            this.btnHoiKhanGia = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxQuestion
            // 
            this.tbxQuestion.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbxQuestion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxQuestion.Location = new System.Drawing.Point(64, 412);
            this.tbxQuestion.Multiline = true;
            this.tbxQuestion.Name = "tbxQuestion";
            this.tbxQuestion.Size = new System.Drawing.Size(1123, 115);
            this.tbxQuestion.TabIndex = 0;
            // 
            // ucCauTraLoi1
            // 
            this.ucCauTraLoi1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ucCauTraLoi1.LaCauTraLoi = false;
            this.ucCauTraLoi1.Location = new System.Drawing.Point(64, 533);
            this.ucCauTraLoi1.Name = "ucCauTraLoi1";
            this.ucCauTraLoi1.NoiDung = "";
            this.ucCauTraLoi1.Size = new System.Drawing.Size(540, 70);
            this.ucCauTraLoi1.TabIndex = 1;
            this.ucCauTraLoi1.TieuDe = "A";
            // 
            // ucCauTraLoi2
            // 
            this.ucCauTraLoi2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ucCauTraLoi2.LaCauTraLoi = false;
            this.ucCauTraLoi2.Location = new System.Drawing.Point(647, 533);
            this.ucCauTraLoi2.Name = "ucCauTraLoi2";
            this.ucCauTraLoi2.NoiDung = "";
            this.ucCauTraLoi2.Size = new System.Drawing.Size(540, 70);
            this.ucCauTraLoi2.TabIndex = 2;
            this.ucCauTraLoi2.TieuDe = "B";
            // 
            // ucCauTraLoi3
            // 
            this.ucCauTraLoi3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ucCauTraLoi3.LaCauTraLoi = false;
            this.ucCauTraLoi3.Location = new System.Drawing.Point(64, 609);
            this.ucCauTraLoi3.Name = "ucCauTraLoi3";
            this.ucCauTraLoi3.NoiDung = "";
            this.ucCauTraLoi3.Size = new System.Drawing.Size(540, 70);
            this.ucCauTraLoi3.TabIndex = 3;
            this.ucCauTraLoi3.TieuDe = "C";
            // 
            // ucCauTraLoi4
            // 
            this.ucCauTraLoi4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ucCauTraLoi4.LaCauTraLoi = false;
            this.ucCauTraLoi4.Location = new System.Drawing.Point(647, 609);
            this.ucCauTraLoi4.Name = "ucCauTraLoi4";
            this.ucCauTraLoi4.NoiDung = "";
            this.ucCauTraLoi4.Size = new System.Drawing.Size(540, 70);
            this.ucCauTraLoi4.TabIndex = 4;
            this.ucCauTraLoi4.TieuDe = "D";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(104, 427);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(0, 20);
            this.lblQuestion.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnToTuVan);
            this.groupBox1.Controls.Add(this.btnHoiKhanGia);
            this.groupBox1.Controls.Add(this.btnGoiNguoiThan);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(907, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 103);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quyền trợ giúp";
            // 
            // btnGoiNguoiThan
            // 
            this.btnGoiNguoiThan.BackgroundImage = global::DoAnCuoiKi.Properties.Resources.Goi_Nguoi_Than;
            this.btnGoiNguoiThan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGoiNguoiThan.Location = new System.Drawing.Point(16, 29);
            this.btnGoiNguoiThan.Name = "btnGoiNguoiThan";
            this.btnGoiNguoiThan.Size = new System.Drawing.Size(87, 62);
            this.btnGoiNguoiThan.TabIndex = 7;
            this.btnGoiNguoiThan.UseVisualStyleBackColor = true;
            // 
            // btnToTuVan
            // 
            this.btnToTuVan.BackgroundImage = global::DoAnCuoiKi.Properties.Resources.Tu_Van_TC;
            this.btnToTuVan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnToTuVan.Location = new System.Drawing.Point(202, 29);
            this.btnToTuVan.Name = "btnToTuVan";
            this.btnToTuVan.Size = new System.Drawing.Size(87, 62);
            this.btnToTuVan.TabIndex = 8;
            this.btnToTuVan.UseVisualStyleBackColor = true;
            // 
            // btnHoiKhanGia
            // 
            this.btnHoiKhanGia.BackgroundImage = global::DoAnCuoiKi.Properties.Resources.Y_Kien_K_Gia;
            this.btnHoiKhanGia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHoiKhanGia.Location = new System.Drawing.Point(109, 29);
            this.btnHoiKhanGia.Name = "btnHoiKhanGia";
            this.btnHoiKhanGia.Size = new System.Drawing.Size(87, 62);
            this.btnHoiKhanGia.TabIndex = 9;
            this.btnHoiKhanGia.UseVisualStyleBackColor = true;
            // 
            // Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DoAnCuoiKi.Properties.Resources.lai_van_sam_ai_la_trieu_phu_1_1621_phunutoday;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1212, 718);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.ucCauTraLoi4);
            this.Controls.Add(this.ucCauTraLoi3);
            this.Controls.Add(this.ucCauTraLoi2);
            this.Controls.Add(this.ucCauTraLoi1);
            this.Controls.Add(this.tbxQuestion);
            this.DoubleBuffered = true;
            this.Name = "Player";
            this.Text = "Player: Ai Là Triệu Phú";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxQuestion;
        private ucCauTraLoi ucCauTraLoi1;
        private ucCauTraLoi ucCauTraLoi2;
        private ucCauTraLoi ucCauTraLoi3;
        private ucCauTraLoi ucCauTraLoi4;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnToTuVan;
        private System.Windows.Forms.Button btnHoiKhanGia;
        private System.Windows.Forms.Button btnGoiNguoiThan;
    }
}