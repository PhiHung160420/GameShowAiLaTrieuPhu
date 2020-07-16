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
    public partial class QuanLyGameShow : Form
    {
        string Path = "D:\\DanhSachLichPhatGameShow.txt";

        int Year, Month, Day, Hour, Minute, Second;

        int YearBD, MonthBD, DayBD, HourBD, MinuteBD, SecondBD;

        int YearKT, MonthKT, DayKT, HourKT, MinuteKT, SecondKT;

        //kiểm tra thời gian bắt đầu và kết thúc khi sửa và xóa
        string KTYearBD, KTMonthBD, KTDayBD, KTHourBD, KTMinuteBD, KTSecondBD;

        string KTYearKT, KTMonthKT, KTDayKT, KTHourKT, KTMinuteKT, KTSecondKT;

        bool IsAdd = false;
        private void btnDelete_Click(object sender, EventArgs e)
        {
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
                            if (!s.Equals("@" + txtName.Tag) && !s.Equals("yyyy" + KTYearBD) && !s.Equals("mm" + KTMonthBD) && !s.Equals("dd" + KTDayBD) && !s.Equals("hh" + KTHourBD) && !s.Equals("mm" + KTMinuteBD) && !s.Equals("ss" + KTSecondBD)
                                && !s.Equals("yyyy" + KTYearKT) && !s.Equals("mm" + KTMonthKT) && !s.Equals("dd" + KTDayKT) && !s.Equals("hh" + KTHourKT) && !s.Equals("mm" + KTMinuteKT) && !s.Equals("ss" + KTSecondKT))
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
            }
        }       
        private GameShow GetInFoGameShow()
        {
            GameShow gameshow = new GameShow();

            gameshow.Name = tbxName.Text;

            //Lấy thời gian bắt đầu
            YearBD = int.Parse(tbxNamBD.Text);
            MonthBD = int.Parse(tbxThangBD.Text);
            DayBD = int.Parse(tbxNgayBD.Text);
            HourBD = int.Parse(tbxGioBD.Text);
            MinuteBD = int.Parse(tbxPhutBD.Text);
            SecondBD = int.Parse(tbxGiayBD.Text);

            //Lấy thời gian kết thúc
            YearKT = int.Parse(tbxNamKT.Text);
            MonthKT = int.Parse(tbxThangKT.Text);
            DayKT = int.Parse(tbxNgayKT.Text);
            HourKT = int.Parse(tbxGioKT.Text);
            MinuteKT = int.Parse(tbxPhutKT.Text);
            SecondKT = int.Parse(tbxGiayKT.Text);

            //Lấy thời gian kết thúc
            return gameshow;
        }
        private bool SaveToFlie(GameShow gameshow)
        {
            using (FileStream fs = new FileStream(Path, FileMode.Append))
            {
                using (StreamWriter sw = new StreamWriter(fs, Encoding.Unicode))
                {
                    sw.WriteLine(Environment.NewLine + "@" + gameshow.Name);

                    //ghi thời gian bắt đầu
                    sw.WriteLine("&");
                    sw.WriteLine("yyyy" + YearBD);
                    sw.WriteLine("mm" + MonthBD);
                    sw.WriteLine("dd" + DayBD);
                    sw.WriteLine("hh" + HourBD);
                    sw.WriteLine("mm" + MinuteBD);
                    sw.WriteLine("ss" + SecondBD);

                    //Ghi thời gian kết thúc
                    sw.WriteLine("#");
                    sw.WriteLine("yyyy" + YearKT);
                    sw.WriteLine("mm" + MonthKT);
                    sw.WriteLine("dd" + DayKT);
                    sw.WriteLine("hh" + HourKT);
                    sw.WriteLine("mm" + MinuteKT);
                    sw.WriteLine("ss" + SecondKT);

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
                    }
                }
                else
                {
                    MessageBox.Show("Bạn hãy điền đầy đủ thông tin");
                }    
                tbxName.Clear();
                tbxNamBD.Clear();
                tbxNamKT.Clear();
                tbxThangBD.Clear();
                tbxThangKT.Clear();
                tbxNgayBD.Clear();
                tbxNgayKT.Clear();
                tbxGioBD.Clear();
                tbxGioKT.Clear();
                tbxPhutBD.Clear();
                tbxPhutKT.Clear();
                tbxGiayBD.Clear();
                tbxGiayKT.Clear();
                IsAdd = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            gbAddInfo.Show();
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
                string TGBD = tbxStartTime.Tag.ToString();

                ////Lấy ngày bắt đầu
                KTMonthBD = TGBD.Substring(0,1);
                KTDayBD = TGBD.Substring(2,2);
                KTYearBD = TGBD.Substring(5,4);

                //Lấy giờ bắt đầu
                KTHourBD = TGBD.Substring(10,1);
                KTMinuteBD = TGBD.Substring(12,2);
                KTSecondBD = TGBD.Substring(15, 2);

                //Lấy thời gian kết thúc
                tbxEndTime.Text = row.Cells[3].Value.ToString();
                tbxEndTime.Tag = row.Cells[3].Value.ToString();

                string TGKT = tbxEndTime.Tag.ToString();

                ////Lấy ngày kết thúc
                KTMonthKT = TGKT.Substring(0, 1);
                KTDayKT = TGKT.Substring(2, 2);
                KTYearKT = TGKT.Substring(5, 4);

                //Lấy giờ kết thúc
                KTHourKT = TGKT.Substring(10, 1);
                KTMinuteKT = TGKT.Substring(12, 2);
                KTSecondKT = TGKT.Substring(15, 2);

                //Bật các button lên

            }
        }

        private void QuanLyGameShow_Load(object sender, EventArgs e)
        {
            LoadListGameShow();
            gbAddInfo.Hide();
        }

        public QuanLyGameShow()
        {
            InitializeComponent();
        }
        private void LoadListGameShow()
        {
            StreamReader sr = new StreamReader(Path);

            List<GameShow> lstGameShow = new List<GameShow>();

            DateTime Start_Time;

            DateTime End_Time;

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
                    string temp = sr.ReadLine();
                    if (temp.StartsWith("yyyy"))
                    {
                        Year = int.Parse(temp.Substring(4));
                    }
                    temp = sr.ReadLine();
                    if (temp.StartsWith("mm"))
                    {
                        Month = int.Parse(temp.Substring(2));
                    }
                    temp = sr.ReadLine();
                    if (temp.StartsWith("dd"))
                    {
                        Day = int.Parse(temp.Substring(2));
                    }
                    temp = sr.ReadLine();
                    if (temp.StartsWith("hh"))
                    {
                        Hour = int.Parse(temp.Substring(2));
                    }
                    temp = sr.ReadLine();
                    if (temp.StartsWith("mm"))
                    {
                        Minute = int.Parse(temp.Substring(2));
                    }
                    temp = sr.ReadLine();
                    if (temp.StartsWith("ss"))
                    {
                        Second = int.Parse(temp.Substring(2));
                    }
                    Start_Time = new DateTime(Year, Month, Day, Hour, Minute, Second);
                    gameshow.StartDate = Start_Time;
                }
                if (line.StartsWith("#"))
                {
                    string temp = sr.ReadLine();
                    if (temp.StartsWith("yyyy"))
                    {
                        Year = int.Parse(temp.Substring(4));
                    }
                    temp = sr.ReadLine();
                    if (temp.StartsWith("mm"))
                    {
                        Month = int.Parse(temp.Substring(2));
                    }
                    temp = sr.ReadLine();
                    if (temp.StartsWith("dd"))
                    {
                        Day = int.Parse(temp.Substring(2));
                    }
                    temp = sr.ReadLine();
                    if (temp.StartsWith("hh"))
                    {
                        Hour = int.Parse(temp.Substring(2));
                    }
                    temp = sr.ReadLine();
                    if (temp.StartsWith("mm"))
                    {
                        Minute = int.Parse(temp.Substring(2));
                    }
                    temp = sr.ReadLine();
                    if (temp.StartsWith("ss"))
                    {
                        Second = int.Parse(temp.Substring(2));
                    }
                    End_Time = new DateTime(Year, Month, Day, Hour, Minute, Second);
                    gameshow.EndDate = End_Time;

                    lstGameShow.Add(gameshow);
                    i++;
                }
            }
            
            dgvQLGameShow.DataSource = lstGameShow;
            sr.Close();
        }
    }
}
