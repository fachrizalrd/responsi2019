using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrog2248
{
    class Program
    {
        static void Main(string[] args)
        {

            Karyawan karGus = new Karyawan("21232", "Agus", 3000000);
            Karyawan karTri = new Karyawan("25232", "Tri", 2000000);

            Console.WriteLine("No\tNIK\tNama\t\tGajiBulanan\t");
            Console.WriteLine("1.\t{0}\t{1}\t\t{2}", karGus.NIK, karGus.Nama, karGus.GajiBulanan);
            Console.WriteLine("2.\t{0}\t{1}\t\t{2}", karTri.NIK, karTri.Nama, karTri.GajiBulanan);
            Console.ReadKey();

            karGus.GajiBulanan = karGus.GajiBulanan + (karGus.GajiBulanan * 10 / 100);
            karTri.GajiBulanan = karTri.GajiBulanan + (karTri.GajiBulanan * 10 / 100);

            Console.WriteLine("Naik Gaji cuyyyy!!! 10%");
            Console.WriteLine("No\tNIK\tNama\t\tGajiBulanan\t");
            Console.WriteLine("1.\t{0}\t{1}\t\t{2}", karGus.NIK, karGus.Nama, karGus.GajiBulanan);
            Console.WriteLine("2.\t{0}\t{1}\t\t{2}", karTri.NIK, karTri.Nama, karTri.GajiBulanan);

            Console.ReadKey();
        }

       
    }
}
