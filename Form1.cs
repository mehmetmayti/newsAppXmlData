using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace newsAppXmlData
{
    public partial class Form1 : Form
    {
        Services servic = new Services();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var list =servic.getAllLastNews();
            pictureBox3.ImageLocation = list[0].imageUrl;
            lblTitle.Text = list[0].newstitle;
            lblDate.Text = list[0].newsPubDate.ToString();
            linkLabel1.AccessibleDescription = list[0].newsLink;
            linkLabel1.LinkClicked += LinkLabel1_LinkClicked;

        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var link = sender as LinkLabel;
            Process.Start(link.AccessibleDescription);
        }

        
    }
}
