using System;
// Camle Case standartini benimsedim

namespace BZ102_1030510142

{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] haritaMatris = new string[11, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {

                    haritaMatris[i, j] = "0";

                }

            }
            Random rastgele = new Random();
            int k = 9;
            int a = rastgele.Next(8);
            int b = rastgele.Next(10);
            int c = rastgele.Next(10);
            int d = rastgele.Next(10);
            int e = rastgele.Next(10);
            int f = rastgele.Next(10);
            while (a >= b || a >= c || b >= c)
            {
                b = rastgele.Next(10);
                c = rastgele.Next(10);
            }
            haritaMatris[10, a] = "1";
            haritaMatris[10, b] = "2";
            haritaMatris[10, c] = "3";
            while (d == e)
            {
                e = rastgele.Next(10);
            }
            string yol1 = haritaMatris[k, a] = "1";
            string yol2 = haritaMatris[k, b] = "1";
            string yol3 = haritaMatris[k, c] = "1";
            string hedef1 = haritaMatris[0, d] = "1";
            string hedef2 = haritaMatris[0, e] = "1";
            string hedef3 = haritaMatris[0, f] = "1";
            int yonKontrol1 = 0;

            int x = a;
            int y = b;
            int z = c;
            int yer1 = a;
            int yer2 = b;
            int yer3 = c;
            //Cikislarin ikisi ayni olabilir ama  ücü ayni olamaz 
            while (k != 0 || a != d)
            {
                int sayi = rastgele.Next(3);
                if (sayi == 0 && k != 0)//yukarı gitmesi icin//
                {
                    if (k == 1)
                    {
                        if (a < d)
                        {
                            haritaMatris[k, a + 1] = "1";
                            a = a + 1;


                        }
                        else if (a > d)
                        {
                            haritaMatris[k, a - 1] = "1";
                            a = a - 1;



                        }
                        else if (a == d)
                        {
                            haritaMatris[k - 1, a] = "1";
                            k = k - 1;
                        }
                    }
                    else
                    {
                        haritaMatris[k - 1, a] = "1";
                        k = k - 1;
                        yonKontrol1 = 0;
                    }

                }
                if (sayi == 1 && a != 9 && yonKontrol1 == 0)//sağa gitmesi icin//
                {
                    if (k == 1 && a == d)
                    {
                        haritaMatris[k - 1, a] = "1";
                        k = k - 1;
                    }

                    else if (k == 9)
                    {
                        haritaMatris[k - 1, a] = "1";
                        k = k - 1;
                    }
                    else
                    {
                        if (haritaMatris[k + 1, a + 1] == "1" && k > 1 && haritaMatris[k, a + 1] == "0")
                        {
                            haritaMatris[k - 1, a] = "1";
                            k = k - 1;
                            yonKontrol1 = 0;
                        }
                        else
                        {
                            haritaMatris[k, a + 1] = "1";
                            a = a + 1;
                            yonKontrol1 = 1;
                        }
                    }
                }
                if (sayi == 2 && a != 0 && yonKontrol1 == 0)//sola gitmesi icin//
                {
                    if (k == 1 && a == d)
                    {
                        haritaMatris[k - 1, a] = "1";
                        k = k - 1;

                    }
                    else if (k == 9)
                    {
                        haritaMatris[k - 1, a] = "1";
                        k = k - 1;

                    }
                    else
                    {
                        if (haritaMatris[k + 1, a - 1] == "1" && k > 1 && haritaMatris[k, a - 1] == "0")
                        {
                            haritaMatris[k - 1, a] = "1";
                            k = k - 1;
                            yonKontrol1 = 0;

                        }
                        else
                        {
                            haritaMatris[k, a - 1] = "1";
                            a = a - 1;
                            yonKontrol1 = 1;
                        }
                    }
                }

            }
            yonKontrol1 = 0;
            k = 9;
            while (k != 0 || b != f)
            {
                int sayi = rastgele.Next(3);
                if (sayi == 0 && k != 0)//yukarı gitmesi icin//
                {
                    if (k == 1)
                    {
                        if (b < f)
                        {
                            haritaMatris[k, b + 1] = "1";
                            b = b + 1;


                        }
                        else if (b > f)
                        {
                            haritaMatris[k, b - 1] = "1";
                            b = b - 1;



                        }
                        else if (b == f)
                        {
                            haritaMatris[k - 1, b] = "1";
                            k = k - 1;


                        }
                    }
                    else
                    {

                        haritaMatris[k - 1, b] = "1";
                        k = k - 1;
                        yonKontrol1 = 0;
                    }

                }
                if (sayi == 1 && b != 9 && yonKontrol1 == 0)//sağa gitmesi icin//
                {
                    if (k == 1 && b == f)
                    {
                        haritaMatris[k - 1, b] = "1";
                        k = k - 1;

                    }

                    else if (k == 9)
                    {
                        haritaMatris[k - 1, b] = "1";
                        k = k - 1;

                    }
                    else
                    {
                        if (haritaMatris[k + 1, b + 1] == "1" && k > 1 && haritaMatris[k, b + 1] == "0")
                        {
                            haritaMatris[k - 1, b] = "1";
                            k = k - 1;
                            yonKontrol1 = 0;

                        }
                        else
                        {
                            haritaMatris[k, b + 1] = "1";
                            b = b + 1;
                            yonKontrol1 = 1;
                        }
                    }
                }
                if (sayi == 2 && b != 0 && yonKontrol1 == 0)//sola gitmesi icin//
                {
                    if (k == 1 && b == f)
                    {
                        haritaMatris[k - 1, b] = "1";
                        k = k - 1;

                    }
                    else if (k == 9)
                    {
                        haritaMatris[k - 1, b] = "1";
                        k = k - 1;

                    }
                    else
                    {
                        if (haritaMatris[k + 1, b - 1] == "1" && k > 1 && haritaMatris[k, b - 1] == "0")
                        {
                            haritaMatris[k - 1, b] = "1";
                            k = k - 1;
                            yonKontrol1 = 0;

                        }
                        else
                        {
                            haritaMatris[k, b - 1] = "1";
                            b = b - 1;
                            yonKontrol1 = 1;
                        }
                    }
                }

            }
            yonKontrol1 = 0;
            k = 9;
            while (k != 0 || c != e)
            {
                int sayi = rastgele.Next(3);
                if (sayi == 0 && k != 0)//yukarı gitmesi icin//
                {
                    if (k == 1)
                    {
                        if (c < e)
                        {
                            haritaMatris[k, c + 1] = "1";
                            c = c + 1;


                        }
                        else if (c > e)
                        {
                            haritaMatris[k, c - 1] = "1";
                            c = c - 1;



                        }
                        else if (c == e)
                        {
                            haritaMatris[k - 1, c] = "1";
                            k = k - 1;


                        }
                    }
                    else
                    {

                        haritaMatris[k - 1, c] = "1";
                        k = k - 1;
                        yonKontrol1 = 0;
                    }

                }
                if (sayi == 1 && c != 9 && yonKontrol1 == 0)//sağa gitmesi icin//
                {
                    if (k == 1 && c == e)
                    {
                        haritaMatris[k - 1, c] = "1";
                        k = k - 1;

                    }

                    else if (k == 9)
                    {
                        haritaMatris[k - 1, c] = "1";
                        k = k - 1;

                    }
                    else
                    {
                        if (haritaMatris[k + 1, c + 1] == "1" && k > 1 && haritaMatris[k, c + 1] == "0")
                        {
                            haritaMatris[k - 1, c] = "1";
                            k = k - 1;
                            yonKontrol1 = 0;

                        }
                        else
                        {
                            haritaMatris[k, c + 1] = "1";
                            c = c + 1;
                            yonKontrol1 = 1;
                        }
                    }
                }
                if (sayi == 2 && c != 0 && yonKontrol1 == 0)//sola gitmesi icin//
                {
                    if (k == 1 && c == e)
                    {
                        haritaMatris[k - 1, c] = "1";
                        k = k - 1;

                    }
                    else if (k == 9)
                    {
                        haritaMatris[k - 1, c] = "1";
                        k = k - 1;

                    }
                    else
                    {
                        if (haritaMatris[k + 1, c - 1] == "1" && k > 1 && haritaMatris[k, c - 1] == "0")
                        {
                            haritaMatris[k - 1, c] = "1";
                            k = k - 1;
                            yonKontrol1 = 0;

                        }
                        else
                        {
                            haritaMatris[k, c - 1] = "1";
                            c = c - 1;
                            yonKontrol1 = 1;
                        }
                    }
                }

            }//Harita olusturma
            k = 9;
            int sayi1 = 0;
            int sayi2 = 0;
            int mayinSayisi0 = 0;

            while (mayinSayisi0 == 0)
            {
                sayi1 = rastgele.Next(2, 9);
                sayi2 = rastgele.Next(2, 9);
                if (haritaMatris[sayi1, sayi2] == "1" ) {
                    if ((
                        haritaMatris[sayi1 - 1, sayi2] == "0" && haritaMatris[sayi1, sayi2 - 1] == "0" &&
                        haritaMatris[sayi1, sayi2 + 1] == "1" && haritaMatris[sayi1 + 1, sayi2] == "1") ||
                        (haritaMatris[sayi1, sayi2] == "1" &&
                        haritaMatris[sayi1 + 1, sayi2] == "0" && haritaMatris[sayi1, sayi2 + 1] == "0" &&
                        haritaMatris[sayi1, sayi2 - 1] == "1" && haritaMatris[sayi1 - 1, sayi2] == "1") ||
                        (haritaMatris[sayi1, sayi2] == "1" &&
                        haritaMatris[sayi1 + 1, sayi2] == "1" && haritaMatris[sayi1, sayi2 + 1] == "1" &&
                        haritaMatris[sayi1 - 1, sayi2] == "0" && haritaMatris[sayi1, sayi2 - 1] == "0") ||
                        (haritaMatris[sayi1, sayi2] == "1" &&
                        haritaMatris[sayi1 - 1, sayi2] == "1" && haritaMatris[sayi1, sayi2 - 1] == "1" &&
                        haritaMatris[sayi1 + 1, sayi2] == "0" && haritaMatris[sayi1, sayi2 + 1] == "0")
                            )
                    {
                        haritaMatris[sayi1, sayi2] = "1";
                        mayinSayisi0++;
                    }
                }
            }
            int sayi3 = 0;
            int sayi4 = 0;
            int mayinSayisi1 = 0;
            while (mayinSayisi1 == 0)
            {
                sayi3 = rastgele.Next(2, 9);
                sayi4 = rastgele.Next(2, 9);
                if (haritaMatris[sayi3, sayi4] == "1")
                {
                    if ((
                        haritaMatris[sayi3 - 1, sayi4] == "0" && haritaMatris[sayi3, sayi4 - 1] == "0" &&
                        haritaMatris[sayi3, sayi4 + 1] == "1" && haritaMatris[sayi3 + 1, sayi4] == "1") || (
                        haritaMatris[sayi3, sayi4] == "1" &&
                        haritaMatris[sayi3 + 1, sayi4] == "0" && haritaMatris[sayi3, sayi4 + 1] == "0" &&
                        haritaMatris[sayi3, sayi4 - 1] == "1" && haritaMatris[sayi3 - 1, sayi4] == "1") || (
                        haritaMatris[sayi3, sayi4] == "1" &&
                        haritaMatris[sayi3 + 1, sayi4] == "1" && haritaMatris[sayi3, sayi4 + 1] == "1" &&
                        haritaMatris[sayi3 - 1, sayi4] == "0" && haritaMatris[sayi3, sayi4 - 1] == "0") || (
                        haritaMatris[sayi3, sayi4] == "1" &&
                        haritaMatris[sayi3 - 1, sayi4] == "1" && haritaMatris[sayi3, sayi4 - 1] == "1" &&
                        haritaMatris[sayi3 + 1, sayi4] == "0" && haritaMatris[sayi3, sayi4 + 1] == "0") ||
                        ((sayi1 != sayi3) && (sayi2 != sayi4))
                        )
                    {
                        haritaMatris[sayi3, sayi4] = "1";
                        mayinSayisi1++;
                    }
                }
            }//Mayın doseme 

            k = 9;
            double puanHesap = 0;
            bool oyunBaslama = false;
            bool oyunBittiMi = false;
            int yolSecim = 0;
            while (oyunBittiMi == false)
            {
                if (oyunBaslama == false)
                {
                    for (int i = 0; i < 11; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (haritaMatris[i, j] != "0" && haritaMatris[i, j] != "1" && haritaMatris[i, j] != "2" && haritaMatris[i, j] != "3" && haritaMatris[i, j] != "K")
                            {
                                Console.Write(" ");
                            }

                            Console.Write(haritaMatris[i, j] + " ");
                        }
                        Console.WriteLine("\t");
                    }

                    if (yolSecim == 0)
                    {


                        haritaMatris[10, yer1] = "1";
                        haritaMatris[10, yer2] = "2";
                        haritaMatris[10, yer3] = "3";
                        Console.WriteLine("Baslamak istediginiz noktayi 1,2,3 olarak secip 'ENTER'a basiniz!\n");
                        Console.WriteLine("Ileri gitmek icin w , Geri gitmek icin s, Saga gitmek icin d , Sola gitmek icin a tusuna basiniz.\n");
                        Console.WriteLine("Bombanın yerini görmek icin yolunuzu sectikten sonra G tusuna basiniz.\n");
                        Console.WriteLine("Tekrardan yol secmek icin yolları isaretleyen  sayilara geliniz (1,2,3)\n");
                        Console.WriteLine("Attiginiz her adim icin 1 puan kazancaksiniz , duvara her carpisiniz icin 1 puan kaybediceksiniz.\n");
                        Console.WriteLine("Haritanin disina cikmaya calismak puaninizi etkilemez.\n");
                        yolSecim = Convert.ToInt32(Console.ReadLine());

                    }
                    
                    if (yolSecim == 1)
                    {
                        x = yer1;
                        Console.Clear();
                        haritaMatris[k, x] = "K";
                        oyunBaslama = true;

                        for (int i = 0; i < 11; i++)
                        {
                            for (int j = 0; j < 10; j++)
                            {
                                if (haritaMatris[i, j] != "0" && haritaMatris[i, j] != "1" && haritaMatris[i, j] != "2" && haritaMatris[i, j] != "3" && haritaMatris[i, j] != "K")
                                {
                                    Console.Write(" ");
                                }

                                Console.Write(haritaMatris[i, j] + " ");
                            }
                            Console.WriteLine("\t");
                        }
                    }
                    if (yolSecim == 2)
                    {
                        Console.Clear();
                        haritaMatris[k, y] = "K";
                        oyunBaslama = true;
                        x = y;
                        for (int i = 0; i < 11; i++)
                        {
                            for (int j = 0; j < 10; j++)
                            {
                                if (haritaMatris[i, j] != "0" && haritaMatris[i, j] != "1" && haritaMatris[i, j] != "2" && haritaMatris[i, j] != "3" && haritaMatris[i, j] != "K")
                                {
                                    Console.Write(" ");
                                }

                                Console.Write(haritaMatris[i, j] + " ");
                            }
                            Console.WriteLine("\t");
                        }
                    }
                    if (yolSecim == 3)
                    {
                        Console.Clear();
                        haritaMatris[k, z] = "K";
                        oyunBaslama = true;
                        x = z;
                        for (int i = 0; i < 11; i++)
                        {
                            for (int j = 0; j < 10; j++)
                            {
                                if (haritaMatris[i, j] != "0" && haritaMatris[i, j] != "1" && haritaMatris[i, j] != "2" && haritaMatris[i, j] != "3" && haritaMatris[i, j] != "K")
                                {
                                    Console.Write(" ");
                                }

                                Console.Write(haritaMatris[i, j] + " ");
                            }
                            Console.WriteLine("\t");
                        }
                    }


                }
                ConsoleKeyInfo tus = new ConsoleKeyInfo();
                tus = Console.ReadKey(true);


                if (tus.Key == ConsoleKey.W)
                {
                    Console.Clear();
                    if (haritaMatris[k - 1, x] == "1")
                    {

                        haritaMatris[k, x] = "1";
                        haritaMatris[k - 1, x] = "K";
                        puanHesap++;


                    }
                    if (haritaMatris[k - 1, x] == "0")
                    {
                        Console.WriteLine("Duvardan gecemezsiniz, puanınız 1 eksildi.\n");
                        puanHesap--;

                    }
                    if (((k - 1 == sayi1) && (x == sayi2)) || ((k - 1 == sayi3) && (x == sayi4)))
                    {
                        Console.WriteLine("Mayina bastiniz oyun bitti");
                        if (haritaMatris[k - 1, x] == haritaMatris[sayi1, sayi2])
                        {
                            haritaMatris[k - 1, x] = "K";
                            haritaMatris[k, x] = "1";

                        }
                        puanHesap = 0;
                        oyunBittiMi = true;
                    }
                    for (int i = 0; i < 11; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (haritaMatris[i, j] != "0" && haritaMatris[i, j] != "1" && haritaMatris[i, j] != "2" && haritaMatris[i, j] != "3" && haritaMatris[i, j] != "K")
                            {
                                Console.Write(" ");
                            }

                            Console.Write(haritaMatris[i, j] + " ");
                        }
                        Console.WriteLine("\t");
                    }
                    if (haritaMatris[k - 1, x] == "K")
                    {
                        k = k - 1;
                        if (k == 0)
                        {

                            Console.WriteLine("Tebrikler Oyunu kazandınız\n Puanınız={0}", puanHesap);
                            oyunBittiMi = true;
                            continue;
                        }
                    }
                    Console.WriteLine("Puanınız={0}", puanHesap);
                }
                if (tus.Key == ConsoleKey.A)
                {
                    Console.Clear();
                    if (x == 0)
                    {
                        Console.WriteLine("Haritanin disina cikamazsiniz!\n");
                        for (int i = 0; i < 11; i++)
                        {
                            for (int j = 0; j < 10; j++)
                            {
                                if (haritaMatris[i, j] != "0" && haritaMatris[i, j] != "1" && haritaMatris[i, j] != "2" && haritaMatris[i, j] != "3" && haritaMatris[i, j] != "K")
                                {
                                    Console.Write(" ");
                                }

                                Console.Write(haritaMatris[i, j] + " ");
                            }
                            Console.WriteLine("\t");
                        }
                        continue;
                    }
                    if (haritaMatris[k, x - 1] == "1")
                    {

                        haritaMatris[k, x] = "1";
                        haritaMatris[k, x - 1] = "K";
                        puanHesap++;


                    }
                    if (haritaMatris[k, x - 1] == "0")
                    {
                        Console.WriteLine("Duvardan gecemezsiniz, puanınız 1 eksildi.\n");
                        puanHesap--;

                    }
                    if (((k == sayi1) && (x - 1 == sayi2)) || ((k == sayi3) && (x - 1 == sayi4)))
                    {
                        Console.WriteLine("Mayina bastiniz oyun bitti");
                        if (haritaMatris[k , x - 1] == haritaMatris[sayi1, sayi2])
                        {
                            haritaMatris[k, x - 1] = "K";
                            haritaMatris[k, x] = "1";

                        }
                        puanHesap = 0;
                        oyunBittiMi = true;
                    }
                    for (int i = 0; i < 11; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (haritaMatris[i, j] != "0" && haritaMatris[i, j] != "1" && haritaMatris[i, j] != "2" && haritaMatris[i, j] != "3" && haritaMatris[i, j] != "K")
                            {
                                Console.Write(" ");
                            }

                            Console.Write(haritaMatris[i, j] + " ");
                        }
                        Console.WriteLine("\t");
                    }
                    if (haritaMatris[k, x - 1] == "K")
                    {
                        x = x - 1;
                    }
                    Console.WriteLine("Puanınız={0}", puanHesap);
                }
                if (tus.Key == ConsoleKey.D)
                {
                    Console.Clear();
                    if (x == 9)
                    {
                        Console.WriteLine("Haritanin disina cikamazsiniz!\n");
                        for (int i = 0; i < 11; i++)
                        {
                            for (int j = 0; j < 10; j++)
                            {
                                if (haritaMatris[i, j] != "0" && haritaMatris[i, j] != "1" && haritaMatris[i, j] != "2" && haritaMatris[i, j] != "3" && haritaMatris[i, j] != "K")
                                {
                                    Console.Write(" ");
                                }

                                Console.Write(haritaMatris[i, j] + " ");
                            }
                            Console.WriteLine("\t");
                        }
                        continue;
                    }
                    if (haritaMatris[k, x + 1] == "1")
                    {

                        haritaMatris[k, x] = "1";
                        haritaMatris[k, x + 1] = "K";
                        puanHesap++;


                    }
                    if (haritaMatris[k, x + 1] == "0")
                    {
                        Console.WriteLine("Duvardan gecemezsiniz, puanınız 1 eksildi.\n");
                        puanHesap--;

                    }
                    if (((k == sayi1) && (x + 1 == sayi2)) || ((k == sayi3) && (x + 1 == sayi4)))
                    {
                        Console.WriteLine("Mayina bastiniz oyun bitti");
                        if (haritaMatris[k , x + 1] == haritaMatris[sayi1, sayi2])
                        {
                            haritaMatris[k, x + 1] = "K";
                            haritaMatris[k, x] = "1";

                        }
                        puanHesap = 0;
                        oyunBittiMi = true;
                    }
                    for (int i = 0; i < 11; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (haritaMatris[i, j] != "0" && haritaMatris[i, j] != "1" && haritaMatris[i, j] != "2" && haritaMatris[i, j] != "3" && haritaMatris[i, j] != "K")
                            {
                                Console.Write(" ");
                            }
                            Console.Write(haritaMatris[i, j] + " ");
                        }
                        Console.WriteLine("\t");
                    }
                    if (haritaMatris[k, x + 1] == "K")
                    {
                        x = x + 1;
                    }
                    Console.WriteLine("Puanınız={0}", puanHesap);
                }
                if (tus.Key == ConsoleKey.S)
                {
                    Console.Clear();
                    if (haritaMatris[k + 1, x] == "1" || haritaMatris[k + 1, x] == "2" || haritaMatris[k + 1, x] == "3")
                    {
                        haritaMatris[k, x] = "1";
                        haritaMatris[k + 1, x] = "K";
                        puanHesap++;
                    }
                    if (haritaMatris[k + 1, x] == "0")
                    {
                        Console.WriteLine("Duvardan gecemezsiniz, puanınız 1 eksildi.\n");
                        puanHesap--;
                    }
                    if (((k + 1 == sayi1) && (x == sayi2)) || ((k + 1 == sayi3) && (x == sayi4)))
                    {
                        Console.WriteLine("Mayina bastiniz oyun bitti");
                        if (haritaMatris[k + 1, x] == haritaMatris[sayi1, sayi2])
                        {
                            haritaMatris[k + 1, x] = "K";
                            haritaMatris[k, x] = "1";

                        }
                        puanHesap = 0;
                        oyunBittiMi = true;
                    }
                    for (int i = 0; i < 11; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (haritaMatris[i, j] != "0" && haritaMatris[i, j] != "1" && haritaMatris[i, j] != "2" && haritaMatris[i, j] != "3" && haritaMatris[i, j] != "K")
                            {
                                Console.Write(" ");
                            }
                            Console.Write(haritaMatris[i, j] + " ");
                        }
                        Console.WriteLine("\t");
                    }
                    if (haritaMatris[k + 1, x] == "K")
                    {
                        k = k + 1;
                        if (k == 10)
                        {
                            Console.Clear();
                            yolSecim = 0;
                            oyunBaslama = false;
                            puanHesap = 0;
                            k = 9;
                        }
                    }
                    Console.WriteLine("Puanınız={0}", puanHesap);
                }
                if (tus.Key == ConsoleKey.G)
                {
                    Console.Clear();
                    if (haritaMatris[sayi1, sayi2] == "1" && haritaMatris[sayi3, sayi4] == "1")
                    {
                        haritaMatris[sayi1, sayi2] = "2";
                        haritaMatris[sayi3, sayi4] = "2";
                        for (int i = 0; i < 11; i++)
                        {
                            for (int j = 0; j < 10; j++)
                            {
                                if (haritaMatris[i, j] != "0" && haritaMatris[i, j] != "1" && haritaMatris[i, j] != "2" && haritaMatris[i, j] != "3" && haritaMatris[i, j] != "K")
                                {
                                    Console.Write(" ");
                                }
                                Console.Write(haritaMatris[i, j] + " ");
                            }
                            Console.WriteLine("\t");
                        }
                        continue;
                    }
                    Console.Clear();
                    if (haritaMatris[sayi1, sayi2] == "2" && haritaMatris[sayi3, sayi4] == "2")
                    {
                        haritaMatris[sayi1, sayi2] = "1";
                        haritaMatris[sayi3, sayi4] = "1";
                        for (int i = 0; i < 11; i++)
                        {
                            for (int j = 0; j < 10; j++)
                            {
                                if (haritaMatris[i, j] != "0" && haritaMatris[i, j] != "1" && haritaMatris[i, j] != "2" && haritaMatris[i, j] != "3" && haritaMatris[i, j] != "K")
                                {
                                    Console.Write(" ");
                                }
                                Console.Write(haritaMatris[i, j] + " ");
                            }
                            Console.WriteLine("\t");
                        }
                        continue;
                    }
                }
            }
            Console.ReadKey();//Oynanış
        }
    }
}

