﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP.Forms
{
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void btnManagement_Click(object sender, EventArgs e)
        {
            AdminClubManagement aClubMenu = new AdminClubManagement();
            aClubMenu.ShowDialog();
        }
    }
}
