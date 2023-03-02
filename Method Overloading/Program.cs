
namespace Method_Overloading // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;

            Console.WriteLine("Please pick your bundle: \n"); 
            Console.WriteLine("1 - MedioCore \n");
            Console.WriteLine("2 - Single \n");
            Console.WriteLine("3 - LoFi-Nights \n");
            Console.WriteLine("4 - Groove \n");
            Console.WriteLine("5 - BigSmoke \n");
            choice = Convert.ToInt32(Console.ReadLine());
            

            if (choice == 1)
            {
                C1("Burger", "Fries", "Coke");
            }

            else if (choice == 2)
            {
                C1("Coffee", "2x Garlic Breads");
            }

            else if (choice == 3)
            {
                C1("Any Coffee of Choice + free 2 pcs of donut of choice");
            }

            else if (choice == 4)
            {
                C1("Chicken Nuggies","Large Fries" , "Coke Negative 0" , "3 slices of Pizza");
            }

            else if (choice == 5)
            {
                C1("2 Burgers", "2 Big Burgers", "Two Extra Large tacos + extra dip", "4 Large Soda of Choice");
            }

        }

        static void C1(String a, String b, String c)
        {
            Console.Clear();
            Console.WriteLine("Your Order is the MedioCore bundle: \n");
            Console.WriteLine(a + "\n"); 
            Console.WriteLine(b + "\n");
            Console.WriteLine(c + "\n");
            Console.WriteLine("Order Completed!, You can now take your sit or Rerun the Program to Order again!.");
            Console.ReadKey();
        }

        static void C1(String a, String b)
        {
            Console.Clear();
            Console.WriteLine("Your Order is the Single bundle: \n");
            Console.WriteLine(a + "\n");
            Console.WriteLine(b + "\n");
            Console.WriteLine("Order Completed!, You can now take your sit or Rerun the Program to Order again!.");
            Console.ReadKey();
        }

        static void C1(String a)
        {
            Console.Clear();
            Console.WriteLine("Your Order is the LoFi-Nights bundle: \n");
            Console.WriteLine(a + "\n");
            Console.WriteLine("Order Completed!, Take your Receipt and Talk to the waiter for your custom Order!.");
            Console.ReadKey();
        }

        static void C1(String a, String b, String c, String d)
        {
            Console.Clear();
            Console.WriteLine("Your Order is the Groove bundle: \n");
            Console.WriteLine(a + "\n");
            Console.WriteLine(b + "\n");
            Console.WriteLine(c + "\n");
            Console.WriteLine(d + "\n");
            Console.WriteLine("Order Completed!, You can now take your sit or Rerun the Program to Order again!.");
            Console.ReadKey();
        }

        static void C1(String a, String b, String c, String d, String e)
        {
            Console.Clear();
            Console.WriteLine("Your Order is the BigSmoke bundle: \n");
            Console.WriteLine(a + "\n");
            Console.WriteLine(b + "\n");
            Console.WriteLine(c + "\n");
            Console.WriteLine(d + "\n");
            Console.WriteLine(e + "\n");
            Console.WriteLine("Order Completed!, You can now take your sit or Rerun the Program to Order again!.");
            Console.ReadKey();
        }

    }

}