using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

using System.IO.Ports;
using TesterTU.Enums;

namespace TesterTU.Views
{
    public partial class SettingsPanel : UserControl
    {
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

        public string ConnectionStr
        {
            get
            {
                return (_view == ViewSource.comPort)?$"{comboBoxNamePort.Text}:{comboBoxBoudRoute.Text}": $"{textBoxIp.Text}:{numericUpDownPort.Text}";
            }
        }

        public ViewSource View
        {
            get
            {
                return _view;
            }
        }

        private string patternIp = @"^([0-9]+).([0-9]+).([0-9]+).([0-9]+)$";

        private IDictionary<string, ViewSource> _dicViewSourceToStr = new Dictionary<string, ViewSource>() { { "COM", ViewSource.comPort }, { "TCP", ViewSource.tcp } };

        private ViewSource _view;

        public SettingsPanel()
        {
            InitializeComponent();
            comboBoxNamePort.DataSource = SerialPort.GetPortNames().OrderBy(x => x).ToList();
            comboBoxBoudRoute.DataSource = new List<string>() { "115200" };
            comboBoxTypeChannel.DataSource = _dicViewSourceToStr.Select(x => x.Key).ToList();
        }

        private void comboBoxTypeChannel_SelectedIndexChanged(object sender, EventArgs e)
        {
            _view = _dicViewSourceToStr[comboBoxTypeChannel.Text];
            switch (_view)
            {
                case ViewSource.comPort:
                    {
                        labelParametr1.Text = "COM порт:";
                        labelParametr2.Text = "Скорость:";
                        //
                        comboBoxNamePort.Visible = true;
                        comboBoxBoudRoute.Visible = true;
                        textBoxIp.Visible = false;
                        numericUpDownPort.Visible = false;
                    }
                    break;
                case ViewSource.tcp:
                    {
                        labelParametr1.Text = "IP адрес:";
                        labelParametr2.Text = "TCP порт:";
                        //
                        comboBoxNamePort.Visible = false;
                        comboBoxBoudRoute.Visible = false;
                        textBoxIp.Visible = true;
                        numericUpDownPort.Visible = true;
                    }
                    break;
            }
        }

        private void textBoxIp_TextChanged(object sender, EventArgs e)
        {
            textBoxIp.BackColor = Regex.IsMatch(textBoxIp.Text, patternIp) ? Color.LightGreen : Color.OrangeRed;
        }
    }
}
