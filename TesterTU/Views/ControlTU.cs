using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using TesterTU.Models;

namespace TesterTU.Views
{
    public partial class ControlTU : ControlTSTUCommon
    {
        ModelDevice _model;
        public ControlTU(ModelDevice model)
        {
            InitializeComponent();
            _model = model;
            this.NumberDevice = model.NumberDevice.ToString();
            this.ValueMK0 = model.AdressMK0.ToString();
            this.ValueMK1 = model.AdressMK1.ToString();
            this.ValueMK2 = model.AdressMK2.ToString();

            tuPanel1.BindModel(_model.MKs[0].Outputs);
            tuPanel2.BindModel(_model.MKs[1].Outputs);
            BindModel(model);
        }
    }
}
