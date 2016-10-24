using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            char jwb = 'y';
            while(jwb == 'y') { 
            Mahasiswa mhs = new Mahasiswa();
            Console.Write("Nama\t: ");
            mhs.Nama = Console.ReadLine();
            Console.Write("NIM\t: ");
            mhs.Nim = Console.ReadLine();
            Console.Write("Nilai\t: ");
            mhs.Nilai = Int16.Parse(Console.ReadLine());
                Console.ReadLine();
            if(mhs.Nilai > 75)
            {
                Console.WriteLine("LULUS");
            }
            else
            {
                Console.WriteLine("TIDAK LULUS");
            }
                Console.ReadLine();
                Console.Write("Apakah anda ingin mengulangi? (y/n) ");
                jwb = char.Parse(Console.ReadLine());
            }
        }
    }
}
