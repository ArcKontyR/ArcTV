using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArcTV
{
    public partial class TV : Form
    {
        //public bool switchOn = false;
        Television TelVis = new Television();
        public TV()
        {
            InitializeComponent();
            
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbSwitch_Click(object sender, EventArgs e)
        {
            if (TelVis.switchOn == false && TelVis.currentChannel != 0)
            {
                TelVis.TVOnOff();
                tbChannelSelect.Enabled = true;
                pbSwitch.Image = Properties.Resources.on;
                pbTV.Image = Properties.Resources.TVOn;
                lblChannel.BackColor = Color.White;
                lblChannel.ForeColor = Color.Black;
                lblChannel.Text = TelVis.ChannelSelect(TelVis.currentChannel);
                lblNext.Enabled = true;
                lblPrevious.Enabled = true;
                tbChannelSelect_TextChanged(sender, e);
            } else
            if (TelVis.switchOn == true)
            {
                TelVis.TVOnOff();
                tbChannelSelect.Enabled = false;
                pbSwitch.Image = Properties.Resources.off;
                pbTV.Image = Properties.Resources.TVOff;
                lblChannel.BackColor = Color.Black;
                lblChannel.ForeColor = Color.Black;
                lblChannel.Text = TelVis.ChannelSelect(TelVis.currentChannel);
                lblNext.Enabled = false;
                lblPrevious.Enabled = false;
            }
        }

        private void lblNext_Click(object sender, EventArgs e)
        {
            TelVis.NextChannel();
            lblChannel.Text = TelVis.ChannelSelect(TelVis.currentChannel);
            tbChannelSelect.Text = TelVis.currentChannel.ToString();
        }

        private void lblPrevious_Click(object sender, EventArgs e)
        {
            TelVis.PreviousChannel();
            lblChannel.Text = TelVis.ChannelSelect(TelVis.currentChannel);
            tbChannelSelect.Text = TelVis.currentChannel.ToString();
        }

        private void tbChannelSelect_TextChanged(object sender, EventArgs e)
        {
            if (tbChannelSelect.Text == "0")
            {
                pbSwitch_Click(sender, e);
            }

            if (tbChannelSelect.Text == "")
            {
                TelVis.currentChannel = 1;
            }
            else
            {
                TelVis.currentChannel = Convert.ToInt32(tbChannelSelect.Text);
            }
            
            if (tbChannelSelect.Text == "666")
            {
                TelVis.currentChannel = 666;
                pbTV.Image = Properties.Resources.TVSatan;
                lblChannel.BackColor = Color.Black;
                lblChannel.ForeColor = Color.Red;
            } else
            if (tbChannelSelect.Text == "69")
            {
                TelVis.currentChannel = 69;
                pbTV.Image = Properties.Resources.TVGay;
                lblChannel.BackColor = Color.Transparent;
                lblChannel.ForeColor = Color.White;
            } else
            if (tbChannelSelect.Text == "0")
            {
                lblChannel.ForeColor = Color.Black;
                pbSwitch_Click(sender, e);
            } else
            {
                pbTV.Image = Properties.Resources.TVOn;
                lblChannel.BackColor = Color.White;
                lblChannel.ForeColor = Color.Black;
            }
            
            TelVis.ChannelSelect(TelVis.currentChannel);
            lblChannel.Text = TelVis.ChannelSelect(TelVis.currentChannel);
        }

        private void tbChannelSelect_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((number <= 47 || number>= 58) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }
    }

    class Television
    {
        public int currentChannel = 1;
        public bool switchOn;
        
        public void TVOff()
        {
            switchOn = false;
        }
        public void TVOnOff()
        {
            switchOn = !switchOn;
        }

        public string ChannelSelect(int channelNumber)
        {
            string channel = "Канал " + channelNumber.ToString();
            return channel;
        }

        public void NextChannel()
        {
            if (currentChannel + 1 <= 9999)
            {
                currentChannel++;
            }
            else currentChannel = 1;
        }

        public void PreviousChannel()
        {
            if (currentChannel - 1 >=1)
            {
                currentChannel--;
            }
            else currentChannel = 9999;
        }
    }
}
