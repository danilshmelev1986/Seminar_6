//Task #1


// int [] array  = new int [] {1,2,3,4,5,};

// void PrintArray()
// {
//     for (int i = 0; i<array.Length; i++)
//     {

//         System.Console.Write(array[i]+ " ");

//     }
// }

// void ReversArray()
// {
//     for (int i = 0; i<array.Length/2; i++)
//     {
//         int temp = array[i];
//         array[i]= array[array.Length-1-i];
//         array[array.Length-1-i]=temp;
//     }

// }

// ReversArray();
// PrintArray();

// Task #2

// Console.WriteLine ("give me a number");
// int a = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine ("give me a number");
// int b = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine ("give me a number");
// int c = Convert.ToInt32(Console.ReadLine());

// if (a<b+c && b<a+c && c<a+b)
// {
//    Console.WriteLine ("Yes"); 
// }
// else
// {
//    Console.WriteLine ("No");  
// }

// Task #3

// Console.WriteLine ("give me a number");
// int num = Convert.ToInt32(Console.ReadLine());

// string result = " ";

// while (num >0)
// {
//     result=num%2+result;
//     num/=2;
// }

// Console.WriteLine (result); 

//Task #4

// Console.WriteLine ("give me a number");
// int num = Convert.ToInt32(Console.ReadLine());

// int firstNum=0;
// int secondNum=1;

// Console.Write (firstNum + " ");
// Console.Write(secondNum + " ");

// for (int i = 2; i < num; i++)
// {
//     int nextNum = firstNum+secondNum;
//     Console.Write (nextNum + " ");
//     firstNum = secondNum;
//     secondNum = nextNum;
    
// }

//Task #5

int [] array = new int [] {12, 14, 14, 46};
int [] array2 = new int [array.Length];


void CopyArray()
{

for (int i =0; i<array2.Length; i++)
{
    array2[i]=array[i];
}

}

void PrintArray()
{
    for (int i =0; i<array2.Length; i++)
{
    Console.Write ($"{array2[i]} ");
}
}
CopyArray();
PrintArray();
