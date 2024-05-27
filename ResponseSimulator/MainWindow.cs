using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResponseSimulator
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void HaltButton_Click(object sender, EventArgs e)
        {
            appStatusLabel.Text = "Status: HALTED";
            appStatusLabel.Refresh();
            System.Threading.Thread.Sleep((int)TimeoutSetBox.Value*1000);
            appStatusLabel.Text = "Status: RESPONDING";
        }

        private void InfoButton_Click(object sender, EventArgs e)
        {
            new InfoWindow().Show();
        }
    }
}
