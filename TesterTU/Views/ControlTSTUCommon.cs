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
    public delegate void DelegateUpdateValue(object sender, PropertyChangedEventArgs e);
    public  partial  class ControlTSTUCommon : UserControl
    {
        public string NumberDevice
        {
            get
            {
                return labelNumberDevice.Text;
            }
            set
            {
                labelNumberDevice.Text = value;
            }
        }

        public string ValueMK0
        {
            get
            {
                return kevValueControlcsMK0.ValueText;
            }
            set
            {
                kevValueControlcsMK0.ValueText = value;
            }
        }

        public string ValueMK1
        {
            get
            {
                return kevValueControlcsMK1.ValueText;
            }
            set
            {
                kevValueControlcsMK1.ValueText = value;
            }
        }

        public string ValueMK2
        {
            get
            {
                return kevValueControlcsMK2.ValueText;
            }
            set
            {
                kevValueControlcsMK2.ValueText = value;
            }
        }

        public ControlTSTUCommon()
        {
            InitializeComponent();
        }

        public void BindModel(ModelDevice model)
        {
            foreach (var mk in model.MKs)
                mk.PropertyChanged += PropertyChanged;
        }

        private void PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (InvokeRequired == false)
                UpdateValue(sender, e);
            else
            {
                var delegateUpdateValue = new DelegateUpdateValue(UpdateValue);
                BeginInvoke(delegateUpdateValue, new object[] { sender, e });
            }
        }

        private void UpdateValue(object sender, PropertyChangedEventArgs e)
        {
            var model = (sender as ModelMK);
            switch (e.PropertyName)
            {
                case "Attempts":
                    {
                        if (model.NumberMK == 1)
                            tableDiagnostControl1.ValueMK1 = model.Attempts.ToString();
                        else
                            tableDiagnostControl1.ValueMK2 = model.Attempts.ToString();
                    }
                    break;
                case "Sessions":
                    {
                        if (model.NumberMK == 1)
                            tableDiagnostControl2.ValueMK1 = model.Sessions.ToString();
                        else
                            tableDiagnostControl2.ValueMK2 = model.Sessions.ToString();
                    }
                    break;
                case "Errors":
                    {
                        if (model.NumberMK == 1)
                            tableDiagnostControl3.ValueMK1 = model.Errors.ToString();
                        else
                            tableDiagnostControl3.ValueMK2 = model.Errors.ToString();
                    }
                    break;
            }
        }
    }
}
