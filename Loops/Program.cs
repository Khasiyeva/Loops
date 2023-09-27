//Task1
//int n = 32;
//if (n == 1)
//{
//    Console.WriteLine("Yes");
//}
//for(int i = n; i > 1; i /= 2)
//{
//    if (i / 2 == 1)
//    {
//        Console.WriteLine("Yes");
//        break;
//    }
//    if (i % 2 == 1)
//    {
//        Console.WriteLine("No");
//        break;
//    }
//}



//Task2
int num = 11;
if (num == 0 || num == 1)
{
    Console.WriteLine(" It is not prime or complex number ");
}
else
{
    for (int i = 2; i <= num / 2; i++)
    {
        if (num % i == 0)
        {
            Console.WriteLine("It is not prime number");
            return;
        }

    }
    Console.WriteLine(" It is a prime number");
}