namespace DoAnCuoiKi
{
    partial class ListPlayercs
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
            this.dgvListPlayer = new System.Windows.Forms.DataGridView();
            this.nguoiChoiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguoiChoiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListPlayer
            // 
            this.dgvListPlayer.AutoGenerateColumns = false;
            this.dgvListPlayer.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvListPlayer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListPlayer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dgvListPlayer.DataSource = this.nguoiChoiBindingSource;
            this.dgvListPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListPlayer.Location = new System.Drawing.Point(0, 0);
            this.dgvListPlayer.Name = "dgvListPlayer";
            this.dgvListPlayer.RowHeadersWidth = 62;
            this.dgvListPlayer.RowTemplate.Height = 28;
            this.dgvListPlayer.Size = new System.Drawing.Size(1030, 450);
            this.dgvListPlayer.TabIndex = 0;
            // 
            // nguoiChoiBindingSource
            // 
            this.nguoiChoiBindingSource.DataSource = typeof(DTOpoj.NguoiChoi);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
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
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // ListPlayercs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 450);
            this.Controls.Add(this.dgvListPlayer);
            this.Name = "ListPlayercs";
            this.Text = "ListPlayercs";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguoiChoiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListPlayer;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource nguoiChoiBindingSource;
    }
}