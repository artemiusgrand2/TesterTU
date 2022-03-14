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
            foreach(var device in _model.Devices)
            {
                var newDevice = GetControlTSTU(device);
                newDevice.Location = new Point(5, panelDevices.Controls.Count * (newDevice.Height + 5) + 5);
                panelDevices.Controls.Add(newDevice);
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
                _model.SetConnectionStr(0, settingsPanelMK1.NameComPort, settingsPanelMK1.BoudComPort);
                _model.SetConnectionStr(1, settingsPanelMK2.NameComPort, settingsPanelMK2.BoudComPort);
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
