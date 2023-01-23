using System;

namespace Money_transfer
{
    class program
    {
        static void Main(string[] args)
        {
            List<money> arr = new List<money>();
            Read.read(ref arr);
            double transfer;
            foreach (var item in arr)
            {
                if (!(item.rub == 0 && item.kop == 0))
                {
                    transfer = item.rub + (item.kop / 100) * 0.017;
                    item.dol = transfer;

                    transfer = item.rub + (item.kop / 100) * 0.018;
                    item.euro = transfer;

                    transfer = item.rub + (item.kop / 100) * 0.016;
                    item.pound = transfer;

                    transfer = item.rub + (item.kop / 100) * 7.10;
                    item.dram = transfer;

                    transfer = item.rub + (item.kop / 100) * 2.48;
                    item.yen = transfer;
                }
                else
                {
                    if()
                }
                Console.WriteLine($"{item.rub} {item.kop} {item.dol} {item.euro} {item.pound} {item.dram} {item.yen}");
            }
        }

        public struct money
        {
            public double rub;
            public double kop;
            public double dol;
            public double euro;
            public double pound;
            public double dram;
            public double yen;
        }
    }
}