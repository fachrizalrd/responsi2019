using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrog2248
{
    class Karyawan
    {
        public Karyawan()
        {
            nik = "Empty";
            nama = "Empty";
            gajiBulanan = 0;

        }

        public Karyawan (string nik,string nama,int gajiBulanan)
        {
            this.nik = nik;
            this.nama = nama;
            if (gajiBulanan < 0)
            {
                this.gajiBulanan = 0;
            }
            else
            {
                this.gajiBulanan = gajiBulanan;
            }
        }

        private string nik;
        private string nama;
        private int gajiBulanan;

        public string NIK 
        {
            get { return nik; }
            set { nik = value; }
        }
        public string Nama {
            get { return nama; }
            set { nama = value; }
        }
        public int GajiBulanan
        {
            get { return gajiBulanan; }
            set { gajiBulanan = value; }
        }
    }
}
