using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pertemuan6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Program Data Pegawai KPWS ");
            Console.WriteLine("===========================");

           Pegawai Pegawai1 = new Pegawai();
           Pegawai Pegawai2 = new Pegawai();
           Pegawai Pegawai3 = new Pegawai();

            Pegawai1.SetDataDiri("Gugun Wahid", 23, "Semarang");
            Pegawai1.SetDataPekerja("Marketing", "M1882672");
            Console.WriteLine();

            Pegawai2.SetDataDiri("Indah Pertiwi", 25, "Yogyakarta");
            Pegawai2.SetDataPekerja("Admin", "A1882322");
            Console.WriteLine();

            Pegawai3.SetDataDiri("Regar Hangkasa", 31, "Medan");
            Pegawai3.SetDataPekerja("HRD", "HRD00001");
            Console.WriteLine();
        }
    }
}
