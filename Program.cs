using AutoMotors;

Makina audi = new Makina("Audi", "A7", 2014, "Nafte", 3.0, 75, 75, 0.047);
Makina bmw = new Makina("BMW", "M4 Competition", 2008, "Benzine", 3.6, 57, 57, 0.096);
Makina mercedes = new Makina("Mercedes-Benz", "W204", 2012, "Benzine", 6.3, 66, 66, 0.134);

Console.WriteLine("Mire se vini ne AUTO Motors");
Console.WriteLine("Ju lutem zgjidhni nje makine:");

Console.WriteLine($"1. {audi.Marka} {audi.Modeli}           2. {bmw.Marka} {bmw.Modeli}         3.{mercedes.Marka} {mercedes.Modeli}");
int opsioni = Convert.ToInt32(Console.ReadLine());

if (opsioni == 1)
{
    audi.Specifikimi(audi);

    while (true)
    {
        audi.ShfaqOpsionet();

        int op = Convert.ToInt32(Console.ReadLine());

        if (op == 1)
        {

            audi.Xhiro(audi);


        }

        else if (op == 2)
        {
            audi.Laje();
            continue;
        }
        else if (op == 3)
        {
            audi.Parko();
            continue;
        }
        else if (op == 4)
        {
            audi.Furnizo(audi);
        }
        else if (op == 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Zgjedhje eshte e gabuar!");
            continue;
        }
    }

}
else if (opsioni == 2)
{
    bmw.Specifikimi(bmw);
    Console.WriteLine($"Ju zgjodhet {bmw.Marka} {bmw.Modeli}. Parametrat e makines jane keto:");
    Console.WriteLine($"Viti i Prodhimit: {bmw.Viti}");
    Console.WriteLine($"Lloji i Karburantit: {audi.Konsumi}");
    Console.WriteLine($"Motorri: {bmw.Motorri}");

    while (true)
    {
        Console.WriteLine("1. Bej Xhiro     2. Laj Makinen      3. Parko        4. Furnizo          0. Dil");
        int op = Convert.ToInt32(Console.ReadLine());

        if (op == 1)
        {
            Random rnd = new Random();
            int km = rnd.Next(1, 200);

            bmw.Xhiro();

            // BMW harxhon 9.6l - 100 km => 0.096l - 1km
            // Cmimi aktual i benzines = 179 LEK / l

            double l = km * 0.096;
            double cmimi = 179 * l;

            Console.WriteLine($"Ke bere {km} kilometra dhe jane kosumuar {Math.Round(l, 2)} litra nafte!");
            Console.WriteLine($"Per kete udhetim jane shpenzuar {Math.Round(cmimi, 2)} LEK");

            continue;
        }
        else if (op == 2)
        {
            bmw.Laje();
            continue;
        }
        else if (op == 3)
        {
            bmw.Parko();
            continue;
        }
        else if (op == 4)
        {
            bmw.Furnizo();
            continue;
        }
        else if (op == 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Zgjedhje eshte e gabuar!");
            continue;
        }
    }
}
else if (opsioni == 3)
{
    Console.WriteLine($"Ju zgjodhet {mercedes.Marka} {mercedes.Modeli}. Parametrat e makines jane keto:");
    Console.WriteLine($"Viti i Prodhimit: {mercedes.Viti}");
    Console.WriteLine($"Lloji i Karburantit: {mercedes.Konsumi}");
    Console.WriteLine($"Motorri: {mercedes.Motorri}");

    while (true)
    {
        Console.WriteLine("1. Bej Xhiro     2. Laj Makinen      3. Parko        4. Furnizo          0. Dil");
        int op = Convert.ToInt32(Console.ReadLine());

        if (op == 1)
        {
            Random rnd = new Random();
            int km = rnd.Next(1, 200);

            mercedes.Xhiro();

            // Mercedes harxhon 13.4l - 100 km => 0.134l - 1km
            // Cmimi aktual i benzines = 179 LEK / l

            double l = km * 0.134;
            double cmimi = 179 * l;

            Console.WriteLine($"Ke bere {km} kilometra dhe jane kosumuar {Math.Round(l, 2)} litra nafte!");
            Console.WriteLine($"Per kete udhetim jane shpenzuar {Math.Round(cmimi, 2)} LEK");

            continue;
        }
        else if (op == 2)
        {
            mercedes.Laje();
            continue;
        }
        else if (op == 3)
        {
            mercedes.Parko();
            continue;
        }
        else if (op == 4)
        {
            mercedes.Furnizo();
            continue;
        }
        else if (op == 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Zgjedhje eshte e gabuar!");
            continue;
        }
    }
}
else
{
    Console.WriteLine("Zgjedhja eshte e gabuar!");
}