/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Nama : Nurul hikmawati");
            Console.WriteLine("NIM  : 19.11.2766");
            Console.WriteLine("");

            Karyawan karyawan1 = new Karyawan();
            Karyawan karyawan2 = new Karyawan();
            Karyawan karyawan3 = new Karyawan();

            karyawan1.No = 1;
            karyawan1.Nik = 19112766;
            karyawan1.Nama = "Nurul hikmawati";
            karyawan1.Gaji = 3000000;

            karyawan2.No = 2;
            karyawan2.Nik = 19222977;
            karyawan2.Nama = "Lala ";
            karyawan2.Gaji = 1000000;

            karyawan3.No = 3;
            karyawan3.Nik = 1935671;
            karyawan3.Nama = "Bagas";
            karyawan3.Gaji = -100;

            Console.WriteLine("No /   NIK/Nama/Gaji     ");
            Console.WriteLine("----------------------------------------");
            karyawan1.InfoKaryawan();
            karyawan2.InfoKaryawan();
            karyawan3.InfoKaryawan();
            Console.WriteLine("");
            Console.WriteLine("Mantap dapat kenaikan gaji 10%");
            Console.WriteLine("");
            Console.WriteLine("No /   NIK/Nama/Gaji     ");
            Console.WriteLine("----------------------------------------");
            karyawan1.BonusGaji();
            karyawan2.BonusGaji();
            karyawan3.BonusGaji();
	}
	public class Karyawan
    {
        public int No { get; set; }
        public int Nik { get; set; }
        public string Nama { get; set; }
        public int Gaji { get; set; }

       

        public void InfoKaryawan()
        {
            if (Gaji < 0)
            {
                Gaji = 0;
            }