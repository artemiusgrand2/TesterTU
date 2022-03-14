using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

using TesterTU.Models;
using TesterTU.Enums;

namespace TesterTU.Controllers
{
    public class ControllerHelper
    {
        public static IList<ModelDevice> GetDevices(string path)
        {
            var result = new List<ModelDevice>();
            if (File.Exists(path))
            {
                foreach (var record in File.ReadAllLines(path))
                {
                    var cells = record.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                    if (cells.Length >= 4)
                    {
                        var cellViewDevice = cells[0].ToUpper().Trim();
                        var viewDevice = (cellViewDevice == "ТС") ? ViewDevice.ts : (cellViewDevice == "ТУ") ? ViewDevice.tu : ViewDevice.none;
                        if (viewDevice == ViewDevice.none)
                            continue;
                        //
                        ushort mk0, mk1, mk2;
                        if (ushort.TryParse(cells[1], out mk0) && ushort.TryParse(cells[2], out mk1) && ushort.TryParse(cells[3], out mk2))
                            result.Add(new ModelDevice(result.Count + 1, viewDevice, mk0, mk1, mk2));
                    }
                }
            }
            //   
            return result;
        }

        public static Color GetColorOutPut(byte value)
        {
            switch (value)
            {
                case 1:
                    return Color.Yellow;
                case 2:
                    return Color.Green;
                case 3:
                    return Color.Black;
                default:
                    return Color.White;
            }
        }

        public static byte GetByteFromBitArray(BitArray bits)
        {
            if (bits.Count != 8)
                return 0;

            byte[] bytes = new byte[1];
            bits.CopyTo(bytes, 0);
            return bytes[0];
        }

        public static byte GetCRC8(byte [] data)
        {
            //var bitsGenerating = new BitArray(new bool[] {true, false, false, false, true, true, false, false, true });
            //var bitsData = new BitArray(data);
            //bitsData.Xor(bitsGenerating)
            return 0;
        }

    }
}
