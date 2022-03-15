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
            byte crc8 = 0;
            foreach (var byteCur in new byte[] { 0xD1, 0x7C, 0x7F, 0x7C, 0x7E, 0x0F, 0x0F })
            {
                for (var numberBit = 0; numberBit < 8; numberBit++)
                {
                    var newBit = (byte)(~((byteCur >> numberBit) ^ crc8) & 1);
                    var bufferXor = new BitArray(new byte[] { (byte)((crc8 << 1) ^ crc8)});
                    var bufferNew = new BitArray(new byte[] { (byte)(crc8 << 1) });
                    bufferNew.Set(3, bufferXor[3]);
                    bufferNew.Set(4, bufferXor[4]);
                    bufferNew.Set(0, newBit == 1);
                    crc8 = GetByteFromBitArray(bufferNew);
                }

                //byteCur = (byte)(byteCur ^ crc8);
                //if ((byteCur & 1) == 1) dl = 0x80;
                ////
                //byteCur = (byte)(byteCur >> 1);
                //crc8 = byteCur;
            }
            //
            return crc8;
        }



    }
}
