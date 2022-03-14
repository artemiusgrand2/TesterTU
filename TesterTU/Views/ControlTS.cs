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
    public partial class ControlTS : ControlTSTUCommon
    {
        public ControlTS(ModelDevice model)
        {
            InitializeComponent();
            this.NumberDevice = model.NumberDevice.ToString();
            this.ValueMK0 = model.AdressMK0.ToString();
            this.ValueMK1 = model.AdressMK1.ToString();
            this.ValueMK2 = model.AdressMK2.ToString();
            //
            tsPanel1.BindModel(model.MKs[0].Outputs);
            tsPanel2.BindModel(model.MKs[1].Outputs);
            BindModel(model);
        }
    }
}
