using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyRateGUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void textBoxDelay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                return;
            }
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (textBoxDelay.Text.Length > 3)
            {
                e.Handled = true;
            }
        }

        private void textBoxRepeat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                return;
            }
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (textBoxRepeat.Text.Length > 3)
            {
                e.Handled = true;
            }
        }

        private void buttonSet_Click(object sender, EventArgs e)
        {
            if (textBoxDelay.Text == string.Empty)
            {
                textBoxDelay.Text = "0";
            }
            if (textBoxRepeat.Text == string.Empty)
            {
                textBoxRepeat.Text = "0";
            }

            uint delay = Convert.ToUInt32(textBoxDelay.Text);
            uint repeat = Convert.ToUInt32(textBoxRepeat.Text);
            bool success = KeyRateController.SetFilterKeys(delay, repeat);
            if (success)
            {
                textBoxTest.Text = string.Empty;
                labelResult.ForeColor = Color.Green;
                labelResult.Text = "Keyrate set successfully!";
            }
            else
            {
                labelResult.ForeColor = Color.Red;
                labelResult.Text = "Syscall failed!";
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            bool success = KeyRateController.ResetFilterKeys();
            if (success)
            {
                textBoxTest.Text = string.Empty;
                labelResult.ForeColor = Color.Orange;
                labelResult.Text = "Keyrate reset!";
            }
            else
            {
                labelResult.ForeColor = Color.Red;
                labelResult.Text = "Syscall failed!";
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxTest.Text = string.Empty;
        }

        private void linkLabelSource_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabelSource.LinkVisited = true;
            var uri = "https://github.com/NumberPigeon/keyrateGUI";
            var psi = new System.Diagnostics.ProcessStartInfo
            {
                UseShellExecute = true,
                FileName = uri
            };
            System.Diagnostics.Process.Start(psi);
        }
    }
}
