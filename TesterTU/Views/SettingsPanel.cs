using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.IO.Ports;

namespace TesterTU.Views
{
    public partial class SettingsPanel : UserControl
    {
        public string NameComPort
        {
            get
            {
                return comboBoxNamePort.Text;
            }
        }

        public string BoudComPort
        {
            get
            {
                return comboBoxBoudRoute.Text;
            }
        }

        public string TextPanel
        {
            get
            {
                return groupBoxSettings.Text;
            }
            set
            {
                groupBoxSettings.Text = value;
            }
        }

        public SettingsPanel()
        {
            InitializeComponent();
            comboBoxNamePort.DataSource = SerialPort.GetPortNames();
            comboBoxBoudRoute.DataSource = new List<string>() { "9600", "14400", "19200", "38400", "57600", "115200"};
        }
    }
}
