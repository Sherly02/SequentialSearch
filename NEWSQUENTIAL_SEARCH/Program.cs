using System;
namespace NEWSQUENTIAL_SEARCH
{
    class Program
    {
        static void Main()
        {
            string[] Nm = { "DANI", "DINA", "NADI", "DIAN", "ANDI",
                            "RONI", "ORIN", "NIRO", "IRNO", "NORI",
                            "MIRA", "ARMI", "IRMA", "IMAR", "RIMA",
                            "RISA", "SARI", "IRSA", "ARIS", "ASRI",
                            "ARDI", "DIRA", "RADI", "IRDA", "DIAR",};
            int Z, N = 30, P = 0;

            for (int I = 0; I < N; I++)
            { Console.Write(" {0}  ", Nm[I]); }

            Console.Write("\n\n Cari = "); string Cari = Console.ReadLine();

            for (Z = 0; Z < N - 1; Z++)
                if (Cari == Nm[Z]) { P = Z + 1; break; }

            if (P > 0) Console.Write("\n {0} di posisi ke : {1}", Cari, P);
            else Console.Write("\n {0} tidak ada...", Cari);
            Console.ReadKey();
        }
    }
}
