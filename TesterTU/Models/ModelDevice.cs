using System;
using System.Collections.Generic;
using TesterTU.Enums;

namespace TesterTU.Models
{
    public class ModelDevice
    {
        public int NumberDevice { get; private set; }
        public ViewDevice View { get; private set; }

        public ushort AdressMK0 { get; private set; }

        public ushort AdressMK1 { get; private set; }

        public ushort AdressMK2 { get; private set; }

        public IList<ModelMK> MKs { get; } = new List<ModelMK>();

        public ModelDevice(int number, ViewDevice view, ushort mk0, ushort mk1, ushort mk2)
        {
            NumberDevice = number;
            View = view;
            AdressMK0 = mk0;
            AdressMK1 = mk1;
            AdressMK2 = mk2;
            //
            MKs.Add(new ModelMK(this, 1));
            MKs.Add(new ModelMK(this, 2));
        }
    }
}
