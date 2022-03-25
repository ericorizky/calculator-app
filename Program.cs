namespace kalkulatorApp1
{
    class Program
    {
        static int Penambahan(int a, int b)
        { return a + b; }
        static int Pengurangan(int a, int b)
        { return a - b; }
        static int Perkalian(int a, int b)
        { return a * b; }
        static int Pembagian(int a, int b)
        { return a / b; }


        static void Main(string[] args)
        {
            Console.Title = "Kalkulator";
        menu:
            Console.WriteLine("Aplikasi Kalkulator");
            Console.WriteLine();
            Console.WriteLine("1. Penjumlahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");
            Console.WriteLine();

            Console.Write("Pilih angka 1 - 4 : ");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (input == 1)
            {
                Console.Write("Input nilai a : ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Input nilai b : ");
                int b = int.Parse(Console.ReadLine());

                Console.WriteLine();

                Console.WriteLine("Hasil " + a + " + " + b + " = " + Penambahan(a, b));
            }

            if (input == 2)
            {
                Console.Write("Input nilai a : ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Input nilai b : ");
                int b = int.Parse(Console.ReadLine());

                Console.WriteLine();

                Console.WriteLine("Hasil " + a + " - " + b + " = " + Pengurangan(a, b));
            }

            if (input == 3)
            {
                Console.Write("Input nilai a : ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Input nilai b : ");
                int b = int.Parse(Console.ReadLine());

                Console.WriteLine();

                Console.WriteLine("Hasil " + a + " x " + b + " = " + Perkalian(a, b));
            }

            if (input == 4)
            {
                Console.Write("Input nilai a : ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Input nilai b : ");
                int b = int.Parse(Console.ReadLine());

                Console.WriteLine();

                Console.WriteLine("Hasil " + a + " : " + b + " = " + Pembagian(a, b));
            }
            else
            {
                Console.WriteLine("Nilai yang anda inputkan tidak ada");
            }
        }
    }
}
