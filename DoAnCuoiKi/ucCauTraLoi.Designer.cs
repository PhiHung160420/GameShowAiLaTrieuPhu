﻿namespace DoAnCuoiKi
{
    partial class ucCauTraLoi
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chkThuTu = new System.Windows.Forms.CheckBox();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // chkThuTu
            // 
            this.chkThuTu.AutoSize = true;
            this.chkThuTu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkThuTu.Location = new System.Drawing.Point(24, 16);
            this.chkThuTu.Name = "chkThuTu";
            this.chkThuTu.Size = new System.Drawing.Size(61, 36);
            this.chkThuTu.TabIndex = 0;
            this.chkThuTu.Text = "A";
            this.chkThuTu.UseVisualStyleBackColor = true;
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Location = new System.Drawing.Point(121, 0);
            this.txtNoiDung.Multiline = true;
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(418, 70);
            this.txtNoiDung.TabIndex = 1;
            // 
            // ucCauTraLoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.txtNoiDung);
            this.Controls.Add(this.chkThuTu);
            this.Name = "ucCauTraLoi";
            this.Size = new System.Drawing.Size(540, 70);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkThuTu;
        private System.Windows.Forms.TextBox txtNoiDung;
    }
}
