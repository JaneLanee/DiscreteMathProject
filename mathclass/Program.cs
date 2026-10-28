namespace mathclass;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("HELLO INPUT 2 NUMBAS FOR GCD&LCM");
        string a = Console.ReadLine();
        string b = Console.ReadLine();
        int a1 = int.Parse(a);
        int a2 = int.Parse(b);//// pretty sure everything on this line and above can be condensed to ONE line
        GCDLCM.Init(a1,a2);
        GCDLCM.gcdmath(); // we NEED GCD BEFORE we can find the lcm in this case... maybe a poor solution
        GCDLCM.lcmmath();
    }

    public static class decide
    {
        static void decidestart()
        {
            
            
        }
    }

    public static class GCDLCM
    {
        public static int Var1 { get; set; }
        public static int Var2 { get; set; }
        
        private static int Var3 { get; set;}
        public static void Init(int var1, int var2)
        {
            Var1 = var1;
            Var2 = var2;
        }

        private static void init2(int var3)
        {
            Var3 = var3;
        }
        public static void gcdmath()
        {
            int varog1 = Var1;
            int varog2 = Var2;
            int r;
            while ((Var1 % Var2) > 0)
            {
                r = Var1 % Var2;
                Var1 = Var2;
                Var2 = r;
            }
            Console.WriteLine($"{Var2} is the GCD");
            init2(Var2);
            Init(varog1,varog2); // weird way of keeping original values.... poor solution
        }
        public static void lcmmath()
        {
            Console.WriteLine($"{Var1} times {Var2} divided by {Var3} = ");
            int var4 = Var1 * Var2 / Var3;
            Console.Write(var4);
        }
    }
}