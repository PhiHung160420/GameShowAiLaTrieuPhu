namespace DoAnCuoiKi
{
    partial class ThongKeKetQua
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
            this.lvThongKeKQ = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MaxScore = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AmoutPlay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvThongKeKQ
            // 
            this.lvThongKeKQ.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Name,
            this.MaxScore,
            this.AmoutPlay});
            this.lvThongKeKQ.Location = new System.Drawing.Point(12, 108);
            this.lvThongKeKQ.Name = "lvThongKeKQ";
            this.lvThongKeKQ.Size = new System.Drawing.Size(1188, 277);
            this.lvThongKeKQ.TabIndex = 0;
            this.lvThongKeKQ.UseCompatibleStateImageBehavior = false;
            this.lvThongKeKQ.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 214;
            // 
            // Name
            // 
            this.Name.Text = "Name";
            this.Name.Width = 267;
            // 
            // MaxScore
            // 
            this.MaxScore.Text = "Điểm cao nhất";
            this.MaxScore.Width = 275;
            // 
            // AmoutPlay
            // 
            this.AmoutPlay.Text = "Số lần chơi";
            this.AmoutPlay.Width = 414;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bảng thống kê kết quả:";
            // 
            // ThongKeKetQua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 506);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvThongKeKQ);
            this.Name = "ThongKeKetQua";
            this.Text = "ThongKeKetQua";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvThongKeKQ;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader MaxScore;
        private System.Windows.Forms.ColumnHeader AmoutPlay;
        private System.Windows.Forms.Label label1;
    }
}