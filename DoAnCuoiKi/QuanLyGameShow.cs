using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKi
{    
    public partial class QuanLyGameShow : Form
    {
        string Path = "D:\\DanhSachLichPhatGameShow.txt";
     
        bool IsAdd = false;
        bool CheckInput = true;
        bool IsUpdate = false;
        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtName.Enabled = true;
            btnAdd.Enabled = false;
            btnUpdate.Enabled = false;
            string[] readText = File.ReadAllLines(Path);
            DialogResult rs = MessageBox.Show("Confirm", "Are you sure want to delete this file ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                using (FileStream fs = new FileStream(Path, FileMode.Truncate, FileAccess.Write))
                {
                    using (StreamWriter sw = new StreamWriter(fs, Encoding.Unicode))
                    {
                        foreach (string s in readText)
                        {
                            if (!s.Equals("&" + tbxStartTime.Tag) && !s.Equals("#" + tbxEndTime.Tag))
                            {
                                sw.WriteLine(s);
                            }
                        }
                        sw.Close();
                    }
                    fs.Close();
                }
                LoadListGameShow();
                dgvQLGameShow.Refresh();

                txtName.Clear();
                tbxStartTime.Clear();
                tbxEndTime.Clear();

                btnDelete.Enabled = false;
                btnAdd.Enabled = true;
            }
            else
            {
                btnUpdate.Enabled = true;
                btnDelete.Enabled = false;
                return;
            }
        }       
        private GameShow GetInFoGameShow()
        {
            GameShow gameshow = new GameShow();
            if (txtName.Text != "")
            {
                gameshow.Name = txtName.Text;
            }
            else
            {
                MessageBox.Show("Hay nhap vao ten gameshow");
                CheckInput = false;
            }    
            try
            {
                gameshow.StartDate = DateTime.Parse(tbxStartTime.Text);
            }
            catch
            {
                MessageBox.Show("thời gian phát sóng không hợp lệ");
                tbxStartTime.Clear();
                CheckInput = false;
            }
            try
            {
                gameshow.EndDate = DateTime.Parse(tbxEndTime.Text);
            }
            catch
            {
                MessageBox.Show("Thời gian ngắt phát sóng không hợp lệ");
                tbxEndTime.Clear();
                CheckInput = false;
            }
            return gameshow;
        }
        private bool SaveToFlie(GameShow gameshow)
        {
            using (FileStream fs = new FileStream(Path, FileMode.Append))
            {
                using (StreamWriter sw = new StreamWriter(fs, Encoding.Unicode))
                {
                    if (CheckInput)
                    {
                        sw.WriteLine(Environment.NewLine + "@" + gameshow.Name);
                    }
                    else
                    {
                        CheckInput = true;
                        return false;
                    }    
                    if(CheckInput)
                    {
                        string starttime = gameshow.StartDate.ToString("dd/MM/yyyy hh:mm:ss");
                        sw.WriteLine("&" + starttime);
                    }
                    else
                    {
                        CheckInput = true;
                        return false;
                    }    
                    if(CheckInput)
                    {
                        string endtime = gameshow.EndDate.ToString("dd/MM/yyyy hh:mm:ss");
                        sw.WriteLine("#" + endtime);
                    }
                    else
                    {
                        CheckInput = true;
                        return false;
                    }    
                    sw.Close();
                }
                fs.Close();
            }
            return true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            btnNotSave.Enabled = false;
            if (IsAdd)
            {
                GameShow gameshow = GetInFoGameShow();
                if (gameshow != null)
                {
                    bool SaveSuccess = SaveToFlie(gameshow);
                    if (SaveSuccess)
                    {
                        MessageBox.Show("Lưu thành công");
                        LoadListGameShow();
                        dgvQLGameShow.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("Lưu thất bại");
                        return;
                    }                  
                }
                txtName.Clear();
                tbxStartTime.Clear();
                tbxEndTime.Clear();
                IsAdd = false;
            }
            if (IsUpdate)
            {
                string[] readText = File.ReadAllLines(Path);

                using (FileStream fs = new FileStream(Path, FileMode.Truncate, FileAccess.Write))
                {
                    using (StreamWriter sw = new StreamWriter(fs, Encoding.Unicode))
                    {
                        foreach (string s in readText)
                        {
                            if (!s.Equals("@" + txtName.Tag) && !s.Equals("&" + tbxStartTime.Tag) && !s.Equals("#" + tbxEndTime.Tag))
                            {
                                sw.WriteLine(s);
                            }
                            if (s.Equals("@" + txtName.Tag))
                            {
                                sw.WriteLine("@" + txtName.Text);
                            }
                            if (s.Equals("&" + tbxStartTime.Tag))
                            {
                                sw.WriteLine("&" + tbxStartTime.Text);
                            }
                            if (s.Equals("#" + tbxEndTime.Tag))
                            {
                                sw.WriteLine("#" + tbxEndTime.Text);
                            }
                        }
                        sw.Close();
                    }
                    fs.Close();
                }
                LoadListGameShow();
                dgvQLGameShow.Refresh();
                txtName.Clear();
                tbxStartTime.Clear();
                tbxEndTime.Clear();
                IsUpdate = false;
            }
            btnSave.Enabled = false;
            btnAdd.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtName.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
            btnNotSave.Enabled = true;
            txtName.Clear();
            tbxStartTime.Clear();
            tbxEndTime.Clear();          
            IsAdd = true;
        }

        private void dgvQLGameShow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvQLGameShow.Rows[e.RowIndex];

                //Đưa dữ liệu vào textbox                
                txtName.Text = row.Cells[1].Value.ToString();
                txtName.Tag = row.Cells[1].Value.ToString();

                //Lấy thời gian bắt đầu
                tbxStartTime.Text = row.Cells[2].Value.ToString();
                tbxStartTime.Tag = row.Cells[2].Value.ToString();

                //Lấy thời gian kết thúc
                tbxEndTime.Text = row.Cells[3].Value.ToString();
                tbxEndTime.Tag = row.Cells[3].Value.ToString();

                //Bật các button lên
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;

                //Không cho phép sửa tên            
            }
        }

        private void QuanLyGameShow_Load(object sender, EventArgs e)
        {
            LoadListGameShow(); 
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = false;
            btnNotSave.Enabled = false;
        }

        public QuanLyGameShow()
        {
            InitializeComponent();
        }
        private void LoadListGameShow()
        {
            StreamReader sr = new StreamReader(Path);

            List<GameShow> lstGameShow = new List<GameShow>();

            string line = null;

            GameShow gameshow = null;

            int i = 1;

            while ((line = sr.ReadLine()) != null)
            {
                if (line.StartsWith("@"))
                {
                    gameshow = new GameShow();                  
                    gameshow.Id = i;
                    gameshow.Name = line.Substring(1);
                }
                if (line.StartsWith("&"))
                {                  
                    gameshow.StartDate = DateTime.Parse(line.Substring(1));                                    
                }
                if (line.StartsWith("#"))
                {                   
                    gameshow.EndDate = DateTime.Parse(line.Substring(1));
                    lstGameShow.Add(gameshow);
                    i++;
                }
            }        
            dgvQLGameShow.DataSource = lstGameShow;
            sr.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            txtName.Enabled = false;
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
            btnNotSave.Enabled = true;
            IsUpdate = true;
        }

        private void btnNotSave_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            tbxStartTime.Clear();
            tbxEndTime.Clear();
        }
    }
}
