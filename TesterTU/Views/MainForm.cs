using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

using TesterTU.Models;
using TesterTU.Controllers;

namespace TesterTU.Views
{
    public partial class MainForm : Form
    {
        ModelCommon _model;
        ControllerMain _controller;
        public MainForm(ModelCommon model, ControllerMain controller)
        {
            _model = model;
            _controller = controller;
            InitializeComponent();
            this.FormClosed += MainForm_FormClosed;
            //
            var numberDevice = 1;
            foreach(var device in _model.Devices)
            {
                var newDevice = GetControlTSTU(device);
                newDevice.Location = new Point(5 + (numberDevice %2 == 0? (newDevice.Width + 5) : 0), (panelDevices.Controls.Count / 2) * (newDevice.Height + 5) + 5);
                panelDevices.Controls.Add(newDevice);
                numberDevice++;
            }
            //
            _controller.Stop();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _controller.Stop();
        }

        private ControlTSTUCommon GetControlTSTU(ModelDevice device)
        {
            if (device.View == Enums.ViewDevice.ts)
                return new ControlTS(device);
            else
                return new ControlTU(device);
        }

        private void buttonStartStop_Click(object sender, EventArgs e)
        {
            if (!_controller.IsStart)
            {
                _model.SetConnectionStr(0, settingsPanelMK1.ConnectionStr, settingsPanelMK1.View);
                _model.SetConnectionStr(1, settingsPanelMK2.ConnectionStr, settingsPanelMK2.View);
                settingsPanelMK1.Enabled = false;
                settingsPanelMK2.Enabled = false;
                _controller.Start();
                buttonStartStop.Text = "Стоп";
            }
            else
            {
                settingsPanelMK1.Enabled = true;
                settingsPanelMK2.Enabled = true;
                _controller.Stop();
                buttonStartStop.Text = "Старт";
            }
        }

    }
}
