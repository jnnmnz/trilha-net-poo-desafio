using DesafioPOO.Models;

internal class Program
{
    private static void Main(string[] args)
    {

        Nokia testeNokia = new Nokia("91 9 8745-2514",
                                     "NK 91",
                                     "854412546989",
                                     64);

        Iphone testeIphone = new Iphone("72 9 5687-7421",
                                        "IPHONE 18",
                                        "5738745913",
                                        500);
                    
        testeNokia.InstalarAplicativo("Snapchat");
        testeIphone.InstalarAplicativo("Instagram");
    }
}