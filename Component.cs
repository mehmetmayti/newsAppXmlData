using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace newsAppXmlData
{
    class Component
    {
        DataModel data = new DataModel();

        public Component(DataModel data)
        {
            this.data = data;
        }

        Panel panel = new Panel();
        PictureBox pictureBox = new PictureBox();
        FlowLayoutPanel layoutPanel = new FlowLayoutPanel();
        Label title = new Label();
        Label date = new Label();
        LinkLabel linkLabel = new LinkLabel();


        public void cahngeComp()
        {
            //Panel
            this.panel.BackColor= System.Drawing.SystemColors.ControlLight;
            this.panel.Location = new System.Drawing.Point(20, 20);
            this.panel.Margin = new System.Windows.Forms.Padding(20);
            this.panel.Name = "panel2";
            this.panel.Padding = new System.Windows.Forms.Padding(10);
            this.panel.Size = new System.Drawing.Size(339, 429);
            this.panel.TabIndex = 0;
            this.panel.Controls.Add(this.pictureBox);
            this.panel.Controls.Add(this.layoutPanel);
            this.panel.Controls.Add(this.linkLabel);
            this.panel.Controls.Add(this.date);

            //Linklabel
            this.linkLabel.AccessibleDescription = data.newsLink;
            this.linkLabel.AutoSize = true;
            this.linkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel.Location = new System.Drawing.Point(262, 402);
            this.linkLabel.Name = "linkLabel1";
            this.linkLabel.Size = new System.Drawing.Size(67, 17);
            this.linkLabel.TabIndex = 3;
            this.linkLabel.TabStop = true;
            this.linkLabel.Text = "Devamı...";
            this.linkLabel.LinkClicked += LinkLabel_LinkClicked;

            //Date
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.date.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.date.Location = new System.Drawing.Point(10, 402);
            this.date.Name = "lblDate";
            this.date.Size = new System.Drawing.Size(38, 17);
            this.date.TabIndex = 2;
            this.date.Text = data.newsPubDate.ToShortDateString();

            //LayoutPanel
            this.layoutPanel.Controls.Add(this.title);
            this.layoutPanel.Location = new System.Drawing.Point(13, 251);
            this.layoutPanel.Name = "flowLayoutPanel2";
            this.layoutPanel.Size = new System.Drawing.Size(316, 132);
            this.layoutPanel.TabIndex = 4;

            //Title
            
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.title.Location = new System.Drawing.Point(3, 10);
            this.title.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.title.Name = "lblTitle";
            this.title.Size = new System.Drawing.Size(46, 20);
            this.title.TabIndex = 0;
            this.title.Text = data.newstitle;

            // PictureBox
            
            this.pictureBox.Location = new System.Drawing.Point(13, 13);
            this.pictureBox.Name = "pictureBox3";
            this.pictureBox.Size = new System.Drawing.Size(316, 232);
            this.pictureBox.TabIndex = 5;
            this.pictureBox.TabStop = false;
            this.pictureBox.ImageLocation = data.imageUrl;
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;


        }

        private void LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var linklabel = sender as LinkLabel;
            Process.Start(linklabel.AccessibleDescription);
        }

        public Panel getComp()
        {
            return panel;
        }



    }
}
