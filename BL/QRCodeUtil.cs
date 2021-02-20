using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QRCodeDecoderLibrary;

namespace BL
{
    public class QRCodeUtil
    {
        public static QRDecoder Decoder = new QRDecoder();
        public static string getQRCode(string path)
        {
            try
            {

                // create QR Code decoder object
                QRDecoder Decoder = new QRDecoder();
                Bitmap image = (Bitmap)Image.FromFile(path, true);

                // call image decoder methos with <code>Bitmap</code> image of QRCode barcode
                byte[][] DataByteArray = Decoder.ImageDecoder(image);

                // get the ECI Assignment value
                //var ECIValue = Decoder.ECIAssignValue;
                //ECIValue = Decoder.ECIAssignValue;
                //if (ECIValue == -1)
                //{
                //    // Assignment value not defined
                //}
                //else
                //{
                //    // Assignment value between 0 to 999999
                //}
                string Result = ByteArrayToStr(DataByteArray[0]);
                return Result;
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        // The QRDecoder converts byte array to text string the class using this conversion
        public static string ByteArrayToStr(byte[] byteArray)
        {
            return System.Text.Encoding.UTF8.GetString(byteArray);

        }
    }
}
