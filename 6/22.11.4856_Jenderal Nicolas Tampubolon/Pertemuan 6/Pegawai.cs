using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pertemuan6
{
	internal class Pegawai
	{
		//Fields
		public string nama;
		public string asal;
		public string devisi;
		public int umur;
		public string ID;

		//Constructor
		public Pegawai(string nama, string asal, string devisi, int umur, string ID)
		{
			this.nama = nama;
			this.asal = asal;
			this.devisi = devisi;
			this.umur = umur;
			this.ID = ID;	
		}
		public Pegawai()
		{

		}

		//Method
		public void SetDataDiri(string nama, int umur, string asal)
		{
			this.nama = nama;
			this.umur = umur;
			this.asal = asal;
			Console.WriteLine("Nama Pegawai : {0}", this.nama);
			Console.WriteLine("Umur Pegawai : {0}", this.umur);
			Console.WriteLine("Asal Kota    : {0}", this.asal); 
		}
        public void SetDataPekerja(string devisi, string ID)
        {
            this.devisi = devisi;
            this.ID = ID;
            Console.WriteLine("Devisi     : {0}", this.devisi);
            Console.WriteLine("ID Pegawai : {0}", this.ID);
			Console.ReadKey();
        }
    }
}
