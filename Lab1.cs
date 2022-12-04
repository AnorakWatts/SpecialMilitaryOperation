using System;
class Lab1
{
    public static void Simple_torrent(double lambd)
    {
        var P0= Math.Exp(-lambd);
        var P1=P0*lambd;
        var P_rest=1-P0;
        Console.WriteLine("нас никто не любит: "+ P0*100);
        Console.WriteLine("кто-то один нас любит: "+ P1*100);
        Console.WriteLine("как минимум кто-то один нас любит: "+ P1*100);

    } 
}