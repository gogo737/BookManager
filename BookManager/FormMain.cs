using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManager
{
    public partial class FormMain : Form
    {

        enum enumBook
        {
            Isbn, BookName
        }

        enum enumUser
        {
            UserId, UserName
        }

        public FormMain()
        {
            InitializeComponent();
            FormHome fh = new FormHome();
            AddControlsToPanel(fh);
            timerTime.Start();
            
        }
        private void moveSidePanel(Control btn)
        {
            panelSide.Top = btn.Top;
            panelSide.Height = btn.Height;
        }

        private void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelControls.Controls.Clear();
            panelControls.Controls.Add(c);
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnBooks);
            FormBooks bs = new FormBooks();
            AddControlsToPanel(bs);
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnUsers);
            FormUsers us = new FormUsers();
            AddControlsToPanel(us);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnHome);
            FormHome He = new FormHome();
            AddControlsToPanel(He);
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            labelTime.Text = dt.ToString("HH:MM:ss");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
