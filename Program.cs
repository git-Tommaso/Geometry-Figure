using FormeGeometriche_EX;

char scelta = ' ';
try
{
    Console.WriteLine("insert your decision: ");
    Console.WriteLine("1: circe\n2:rectangle:\n3:triangle\n");
    scelta = Convert.ToChar(Console.ReadLine());
}
catch (Exception e)
{
    throw new Exception(e.Message);
}

try
{
    switch (scelta)
    {
        case '1':
            Console.Write("insert the radius: ");
            int raggio = Convert.ToInt32(Console.ReadLine());
            if (raggio < 0) raggio *= -1;

            var cerchio = new Cerchio(raggio);
            break;
        case '2':
            Console.Write("inserisci la base: ");
            int BASE = Convert.ToInt32(Console.ReadLine());

            Console.Write("inserici l'altezza: ");
            int altezza = Convert.ToInt32(Console.ReadLine());

            if (BASE < 0) BASE *= -1;
            if (altezza < 0) altezza *= -1;

            var rettangolo = new Rettangolo(BASE, altezza);
            break;
        case '3':
            Console.Write("inserisci la base: ");
            int BASE2 = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("inserici l'altezza: ");
            int altezza2 = Convert.ToInt32(Console.ReadLine());

            if (BASE2 < 0) BASE2 *= -1;
            if (altezza2 < 0) altezza2 *= -1;

            var rettangolo2 = new Triangolo(BASE2, altezza2);
            break;
        default:
            Console.WriteLine("valore inserito non corrisponde a nessun'opzione");
            break;
    }
}
catch (Exception e)
{
    throw new Exception(e.Message);
}