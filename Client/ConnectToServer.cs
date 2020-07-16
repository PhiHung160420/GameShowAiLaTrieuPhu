﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class ConnectToServer : Form
    {
        public ConnectToServer()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Player player = new Player();
            player.ShowDialog();
            this.Close();
        }
    }
}
