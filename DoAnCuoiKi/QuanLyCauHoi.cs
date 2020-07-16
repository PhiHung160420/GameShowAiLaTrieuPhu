using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKi
{
    public partial class QuanLyCauHoi : Form
    {
        string Path = "D:\\DanhSachCauHoi.txt";
        bool IsAdd = false;
        bool IsUpdate = false;
        public QuanLyCauHoi()
        {
            InitializeComponent();
        }
        private void LoadListQuestions()
        {
            StreamReader sr = new StreamReader(Path);

            List<Question> lstCauHoi = new List<Question>();

            List<string> ListAnswer = null;

            string line = null;

            Question cauHoi = null;

            int i = 1;

            while ((line = sr.ReadLine()) != null)
            {
                if (line.StartsWith("@"))
                {
                    cauHoi = new Question();
                    ListAnswer = new List<string>();
                    cauHoi.ID = i;
                    cauHoi.Content = line.Substring(1);
                }
                if (line.StartsWith("&"))
                {
                    ListAnswer.Add(line.Substring(1));
                }
                if (line.StartsWith("#"))
                {
                    //đáp án
                    cauHoi.Answer = line.Substring(1);

                    //Danh sách các câu trả lời
                    cauHoi.AnswerA = ListAnswer[0];
                    cauHoi.AnswerB = ListAnswer[1];
                    cauHoi.AnswerC = ListAnswer[2];
                    cauHoi.AnswerD = ListAnswer[3];
                 
                    lstCauHoi.Add(cauHoi);
                    i++;
                }
            }

            dgvQuanLy.DataSource = lstCauHoi;
            sr.Close();
        }

        private void QuanLyCauHoi_Load(object sender, EventArgs e)
        {
            LoadListQuestions();
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = false;
            btnNotSave.Enabled = false;
        }

        private void dgvQuanLy_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {               
                DataGridViewRow row = this.dgvQuanLy.Rows[e.RowIndex];

                //Đưa dữ liệu vào textbox
                tbxQuestion.Text = row.Cells[1].Value.ToString();
                tbxQuestion.Tag = row.Cells[1].Value.ToString();

                tbxAnswerA.Text = row.Cells[2].Value.ToString();
                tbxAnswerA.Tag = row.Cells[2].Value.ToString();

                tbxAnswerB.Text = row.Cells[3].Value.ToString();
                tbxAnswerB.Tag = row.Cells[3].Value.ToString();

                tbxAnswerC.Text = row.Cells[4].Value.ToString();
                tbxAnswerC.Tag = row.Cells[4].Value.ToString();

                tbxAnswerD.Text = row.Cells[5].Value.ToString();
                tbxAnswerD.Tag = row.Cells[5].Value.ToString();

                tbxAnswer.Text  = row.Cells[6].Value.ToString();
                tbxAnswer.Tag = row.Cells[6].Value.ToString();

                //Bật các button lên
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
            btnNotSave.Enabled = true;
            tbxQuestion.Clear();
            tbxAnswerA.Clear();
            tbxAnswerB.Clear();
            tbxAnswerC.Clear();
            tbxAnswerD.Clear();
            tbxAnswer.Clear();
            IsAdd = true;
        }

        private Question GetContentQuestion()
        {
            Question cauHoi = new Question();

            cauHoi.Content = tbxQuestion.Text;

            cauHoi.AnswerA = tbxAnswerA.Text;
            cauHoi.AnswerB = tbxAnswerB.Text;
            cauHoi.AnswerC = tbxAnswerC.Text;
            cauHoi.AnswerD = tbxAnswerD.Text;

            cauHoi.Answer = tbxAnswer.Text;

            return cauHoi;
        }
        private bool SaveToFlie(Question cauHoi)
        {
            List<string> ListAnswer = new List<string>();
            ListAnswer.Add(cauHoi.AnswerA);
            ListAnswer.Add(cauHoi.AnswerB);
            ListAnswer.Add(cauHoi.AnswerC);
            ListAnswer.Add(cauHoi.AnswerD);

            using (FileStream fs = new FileStream(Path, FileMode.Append))
            {
                using(StreamWriter sw = new StreamWriter(fs, Encoding.Unicode))
                {
                    sw.WriteLine("@" + cauHoi.Content);
                    foreach (string answer in ListAnswer)
                    {
                        sw.WriteLine("&" + answer);
                    }
                    sw.WriteLine("#" + cauHoi.Answer);

                    sw.Close();
                }
                fs.Close();
            }            
            return true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            btnNotSave.Enabled = false;
            if(IsAdd)
            {
                Question question = GetContentQuestion();
                if (question != null)
                {
                    bool SaveSuccess = SaveToFlie(question);
                    if (SaveSuccess)
                    {
                        MessageBox.Show("Lưu thành công");
                        LoadListQuestions();
                        dgvQuanLy.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("Lưu thất bại");
                    }    
                }
                tbxQuestion.Clear();
                tbxAnswerA.Clear();
                tbxAnswerB.Clear();
                tbxAnswerC.Clear();
                tbxAnswerD.Clear();
                tbxAnswer.Clear();
                IsAdd = false;
            } 
            if(IsUpdate)
            {
                string[] readText = File.ReadAllLines(Path);

                using(FileStream fs = new FileStream(Path, FileMode.Truncate, FileAccess.Write))
                {
                    using(StreamWriter sw = new StreamWriter(fs, Encoding.Unicode))
                    {
                        foreach (string s in readText)
                        {
                            if (!s.Equals("@" + tbxQuestion.Tag) && !s.Equals("&" + tbxAnswerA.Tag) && !s.Equals("&" + tbxAnswerB.Tag) && !s.Equals("&" + tbxAnswerC.Tag) && !s.Equals("&" + tbxAnswerD.Tag) && !s.Equals("#" + tbxAnswer.Tag))
                            {
                                sw.WriteLine(s);
                            }
                            if(s.Equals("@" + tbxQuestion.Tag))
                            {
                                sw.WriteLine("@" + tbxQuestion.Text);
                            }
                            if (s.Equals("&" + tbxAnswerA.Tag))
                            {
                                sw.WriteLine("&" + tbxAnswerA.Text);
                            }
                            if (s.Equals("&" + tbxAnswerB.Tag))
                            {
                                sw.WriteLine("&" + tbxAnswerB.Text);
                            }
                            if (s.Equals("&" + tbxAnswerC.Tag))
                            {
                                sw.WriteLine("&" + tbxAnswerC.Text);
                            }
                            if (s.Equals("&" + tbxAnswerD.Tag))
                            {
                                sw.WriteLine("&" + tbxAnswerD.Text);
                            }
                            if (s.Equals("#" + tbxAnswer.Tag))
                            {
                                sw.WriteLine("#" + tbxAnswer.Text);
                            }
                        }
                        sw.Close();
                    }
                    fs.Close();
                }
                LoadListQuestions();
                dgvQuanLy.Refresh();

                tbxQuestion.Clear();
                tbxAnswerA.Clear();
                tbxAnswerB.Clear();
                tbxAnswerC.Clear();
                tbxAnswerD.Clear();
                tbxAnswer.Clear();

                IsUpdate = false;
            }
            btnSave.Enabled = false;
            btnAdd.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
            btnNotSave.Enabled = true;
            IsUpdate = true;
        }

        private void btnNotSave_Click(object sender, EventArgs e)
        {
            tbxQuestion.Clear();
            tbxAnswerA.Clear();
            tbxAnswerB.Clear();
            tbxAnswerC.Clear();
            tbxAnswerD.Clear();
            tbxAnswer.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            btnUpdate.Enabled = false;
            string[] readText = File.ReadAllLines(Path);
            DialogResult rs = MessageBox.Show("Confirm", "Are you sure want to delete this file ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(rs == DialogResult.Yes)
            {
                using (FileStream fs = new FileStream(Path, FileMode.Truncate, FileAccess.Write))
                {
                    using (StreamWriter sw = new StreamWriter(fs, Encoding.Unicode))
                    {
                        foreach (string s in readText)
                        {
                            if (!s.Equals("@" + tbxQuestion.Tag) && !s.Equals("&" + tbxAnswerA.Tag) && !s.Equals("&" + tbxAnswerB.Tag) && !s.Equals("&" + tbxAnswerC.Tag) && !s.Equals("&" + tbxAnswerD.Tag) && !s.Equals("#" + tbxAnswer.Tag))
                            {
                                sw.WriteLine(s);
                            }
                        }
                        sw.Close();
                    }
                    fs.Close();
                }
                LoadListQuestions();
                dgvQuanLy.Refresh();

                tbxQuestion.Clear();
                tbxAnswerA.Clear();
                tbxAnswerB.Clear();
                tbxAnswerC.Clear();
                tbxAnswerD.Clear();
                tbxAnswer.Clear();

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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
