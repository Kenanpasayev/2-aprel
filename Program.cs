namespace ConsoleApp12
{
  
    internal class Program
    {
        static void Main(string[] args)
        {
           bool exit = false;
            Weapon weapon = new Weapon(30,10,false);
            bool run = false;
            do
            {
                Console.WriteLine("0:Informasiya almaq ucun");
                Console.WriteLine("1:Ates acmaq ucun");
                Console.WriteLine("2:Getremainbulletcount metodu ucun");
                Console.WriteLine("3:reload metodu ucun");
                Console.WriteLine("4:changefire metodu ucun");
                Console.WriteLine("5:proqrami dayandir");
                string input= Console.ReadLine();
               
                switch (input) 
                {
                    case "0":
                        Console.WriteLine($"CurrentBullet: {weapon.Currentbullet}");
                      
                        break;
                    case "1":
                            break; 
                    case "2":
                        Console.WriteLine("Getremainbulletcount");
                        weapon.GetRemainBulletCount();

                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    case "5":
                        exit = true;
                        break;

                }
            } while (exit!=false);
        }
    }
}