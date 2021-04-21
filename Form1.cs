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

            foreach (var item in list)
            {
                Component comp = new Component(item);
                comp.cahngeComp();
                Panel panel = comp.getComp();

                flowLayoutPanel1.Controls.Add(panel);
            }

        }

        
    }
}
