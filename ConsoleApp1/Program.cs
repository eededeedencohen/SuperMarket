using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL;
using DAL;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            DriveAPI drive = new DriveAPI();
            var list = drive.files;

            string path = list[0].WebContentLink;
            Console.WriteLine(QRCodeUtil.getQRCode(path));
            Console.ReadKey();
        }
    }
}
