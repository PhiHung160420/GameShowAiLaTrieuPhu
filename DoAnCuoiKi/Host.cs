using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKi
{
    public partial class Host : Form
    {
        public Host()
        {
            InitializeComponent();
        }

        private void btnQuanLyCauHoi_Click(object sender, EventArgs e)
        {
            QuanLyCauHoi QLCH = new QuanLyCauHoi();
            QLCH.Show();
        }

        private void btnQuanLyLichPhat_Click(object sender, EventArgs e)
        {
            QuanLyGameShow QLgameshow = new QuanLyGameShow();
            QLgameshow.Show();
        }

        private void Host_Load(object sender, EventArgs e)
        {

        }
    }
}
