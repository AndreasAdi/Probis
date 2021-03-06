﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Probis
{
    public partial class add_order : Form
    {
        private Form currentChildForm;
        public add_order()
        {
            InitializeComponent();
        }

        private void add_order_Load(object sender, EventArgs e)
        {
            OpenChildForm(new Coffee());
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void jFlatButton1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Coffee());
        }

        private void jFlatButton2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new beverage());
        }

        private void jFlatButton3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new desert());
        }

        private void jFlatButton4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new snack());
        }
    }
}
