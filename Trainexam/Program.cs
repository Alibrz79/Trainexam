



//void mm2(String number)
//{

//    string Reza = "hello";


//    Console.WriteLine("d");

//  }




using System.Runtime.InteropServices;

for (; ; )
{
    //    tsds();
    //    void tsds()
    //{
    //    string input = Console.ReadLine();

    //    switch (input)
    //    {
    //        case "one":
    //            Console.WriteLine("1");
    //            break;
    //        case "two":
    //            Console.WriteLine("2");
    //            break;
    //        case "three":
    //            Console.WriteLine("3");
    //            break;
    //        case "four":
    //            Console.WriteLine("4");
    //            break;
    //        case "five":
    //            Console.WriteLine("5");
    //            break;
    //        default:
    //            Console.WriteLine("no data");
    //            break;



    //    }}
    //Console.WriteLine("Number 1");
    //int num1 = int.Parse(Console.ReadLine());
    ////Console.WriteLine("Number 2");
    ////int num2 = int.Parse(Console.ReadLine());

    //sum(num1);

    //void sum(int a)
    //{
    //    if (a % 5 == 0)
    //    {
    //        Console.WriteLine("baksh pazrin");
    //    }
    //    else
    //    {
    //        Console.WriteLine("baksh pazrin nist");

    //    }

    ////}
    //Console.WriteLine("enter number");
    //int inputs = int.Parse(Console.ReadLine());
    ////string output = inputs switch
    ////{
    ////    1 => "one",
    ////    2 => "two",
    ////    3 => "three",
    ////    4 => "four",
    ////    5 => "five",
    ////    _=> "byby kiri"
    ////};
    ////Console.WriteLine(output);
    //int sum = 1;
    //for (int i = 1; i <= inputs; i++)
    //{
        
    //    sum = sum * i;
    //    Console.WriteLine(sum);
    //}
    //string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
    //foreach (string car in cars)
    //{
    //    Console.WriteLine(car);
    //}
    Console.WriteLine("Enter your lenght ");
    int[] io=new int[int.Parse(Console.ReadLine())];
    Console.WriteLine("Enter your numbers ");

    for (int i = 0; i < io.Length; i++) {
        int inpute = int.Parse(Console.ReadLine());
        io[i] = inpute; }
      
    int max = int.MinValue;
    int min= int.MaxValue;

    for (int i = 0; i < io.Length; i++)
    {
        if (io[i] > max) { 
            max = io[i];
        } 
        if (io[i] < min) { 
            min = io[i];
        }
      

    }
      Console.WriteLine("min add is:" + min);
        Console.WriteLine("max add is:" + max);
      
    
    
    
    
    }














//class Program
//{
//    class stydent
//    {

//    }
//    static void Main()
//    {  stydent s = new stydent();



//    }
//}

