using System;

namespace Matematik
{
    class Program
    {
        static void Main(string[] args)
        {
            DortIslem dortIslem = new DortIslem();
            dortIslem.Topla(5, 6);

            dortIslem.Cıkarma(6, 5);

            dortIslem.Carpma(6, 5);

            dortIslem.Bolme(5, 10);
        }
    }
}
