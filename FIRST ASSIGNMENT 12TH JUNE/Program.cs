//1)write a c#sharp program to accept two integers and check whether they are equal or not.

//int a;
//int b;
//Console.WriteLine("check whether two  integers are equal or not");
//a = Convert.ToInt32(Console.ReadLine());
//b = Convert.ToInt32(Console.ReadLine());
//if (a == b)
//{
//    Console.WriteLine("{0}and {1} are equal\n", a, b);
//}
//else
//    Console.WriteLine("{0}and {1} are not equal\n", a, b);
//.......................................................................

//2)for loop:-
//write a program in c# sharp to display the first 10 natural number.

//int5;
//int6;
//int n=convert.ToInt32(console.ReadLine());
//for(int i=1;i<=n;i++)
//console.WriteLine(i);
//console.ReadLine();
//....................................................................
//3) write a c#sharp program to find the sum of the first 10 natural number.


//int n = 10;
//int sum = 0;
//for(int i=1;i<=n;1++)
//  sum += i;
//Console.WriteLine(sum);

//....................................................................

//4)write a c# sharp program that displays the sum of n natural number.
//int i;
//int n;
//sum=0;
//Console.WriteLine("input value of number:");
//n=Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(''\n the first{0} natural number are:\n",n);
//for(i=1;i<=n;i++)
//{
//Console.WriteLine("{0}",i);
//sum+=i;
//}
//Console.WriteLine("\n the sum of natural number upto {0} terms:{1}\n",n,sum);
//console.ReadLine();
//....................................................................
//5)write a c# sharp program to read 10 numbers and find their average and sum.
//int i;
//int n;
//sum=0;
//double average;
//Console.WriteLine("input 10 numbers:\n")
//for (i=1,i<=10;i++)
//{
//Convert.ToInt32(Console.ReadLine());
//sum+=n;
//}
//Average=sum/10.0;
//Console.WritLine("the sum of 10 number is:{0}\n
//Console.WriteLine("the average is:{1}\n",sum,average);
//Console.ReadLine();
//....................................................................

//6)write a program in c#sharp to display the multiplication table vertically from 1to n.
//Multiplication table from 1to 8
//1*1=1,2*1=2,3*1=3,4*1=4,5*1=5,6*1=6,7*1=7,8*1=8
//1*10=10,2*10=20,3*10=30,4*10=40,5*10=50,6*10=60,7*10=70,8*10=80.


//int d, e, f;


//f = Convert.ToInt32(Console.ReadLine());
//for (e = 1; e <= 10; e++)
// for (d = 1; d <= f; d++)
// if (d <= f - 1)
// Console.WriteLine("{0}*{1}={2},", e, e * d);
// else
// Console.WriteLine("{0}*{1}={2}", d, e, e * d);
//Console.ReadLine();
//....................................................................

//7)write a c# sharp program to display the n terms of odd natural numbers and their sums.


//int i,n,sum=0;
//n = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("\n the odd number are:");
//for (i = 1; i <= n; i++)
//{
// Console.WriteLine("{0}", 2 * i - 1);
// sum += 2 * i - 1;
//Console.WriteLine("\n the sum of natural number number upto{0} terms:{1}\n", n, sum);
//Console.ReadLine();
//.....................................................................

//8)Write a program in c# sharp to display a right angle triangle with an asterisk.The pattern like:
//*
//* *
//* * * 
//* * * *



//for (int i = 1; i <= 4; i++)
//{
//  for (int j = 1; j <= i; j++)
//  {
//   Console.WriteLine("*");
//  }
//  Console.WriteLine();
// Console.ReadLine();
//
//  }
//  }
//......................................................................

//9) write a program in c# sharp  to display a pattern like a right angle triangle with a number.pattern like:
//1
//1 2
//1 2 3
//1 2 3 4

//int k,l ,rows;
//console.writeline("input no.of rows");
//rows=convert.toint32(console.readline());
//for(k=1;k<=rows;k++)
//{
//for(l=1;l<=k;l++)
//console.writeline("{0}",l);
//console.writeline("\n");
//console.readline();
// }
//   }
//  } 
//.....................................................................

//10)write a c# sharp program to calculate the factorial of a given number.



// int i, f = 1, num;
//  Console.WriteLine("input the number");
// num = Convert.ToInt32(Console.ReadLine());
// for (i = 1; i <= num; i++)
//   f = f * 1;
// Console.WriteLine("the factorial of {0}is:{1}\n", num, f);
//  Console.ReadLine();
//}
//}
//}
//..........................................................................
//11)write a program in c# sharp to make such a pattern like a right angle triangle with a row.pattern like:
//1
//2 2
//3 3 3
//4 4 4 4
// ...................................................................

//12)write a c# sharp program to find out whether a given year is leap year or not
// int a;
//Console.WriteLine("Enter a year");



//a=Convert.ToInt32(Console.ReadLine());



//if(a > 0)
//{
//    if(a % 4 == 0)
//    {
//        Console.WriteLine(" This is Leap Year");
//    }
//    else
//    {
//        Console.WriteLine(" This is not a leap year");
//    }
//}



//..13).write a c# sharp program to display the cube of an integer up to given number.


//int i, ctr;
//console.WriteLine("input number of terms:");
//ctr = Convert.ToInt32(Console.ReadLine());
//for (i = 1; i <= ctr; i++)
//{
// Console.WriteLine("number is:{0} and cube of the {1} is:{2}\n", i, i, (i * i * i));
// Console.ReadLine();
//        }
// }

//
//..................................................................................... 

//14).write a program in c# sharp to display the multiplication table of a given integer.
//expected output:
//15*1=15
//......
//......
//15*10=150



//int a, b;
//console.WriteLine("multiplication table)");
//b = Convert.ToInt32(Console.ReadLine());
//console.WriteLine("\n");
//for (a = 1; a <= 15; a++)
//{
// Console.WriteLine("{0}*{1}={2}\b,b,a,b*a)");
//        }
//  }
//}
//.....................................................................................

//15.)write a program in c#sharp to make such a pattern like a right angle triangle with a row.
//pattern like
//1
//2 2
//3 3 3
//4 4 4 4

// int col,rows;
//for (rows=1; rows<=5;rows++)
//{
//for (col=1;col<=rows;col++)
//{

// Console.Write(rows);
//}
//Console.WritLine();
//}
//Console.ReadLine();

//16).write a program in c# sharp to display the n terms of even natural number and their sum.
//test data:
//input number of terms:5
//expected output:
//the even numbers are:2 4 6 8 10
//the sum of even natural number upto 5 terms:30
//.........................................................................................

//17).write a c#sharp program to make a such pattern like a right angle triangle with the number
//pattern like:
//1
//2 3
//4 5 6
//7 8 9 10

//int n=0;
//for (int i=1;i<=4;++i)
//{
//for (int j=1;j<=i;++j)
//{
//n=n+1;
//Console.Write(n);
//}
//Console.WriteLine();
//Console.ReadLine();
//}
//}
//}
//...................................................................................

//18).write a c# sharp program to check whether a given number is positive or negative.

//{
// int num;
//Console.Write("input an integer :");
//num=Convert.ToInt32(console.ReadLine());
//if (num>=0)
//Console.WriteLine("{0}is a positive number.\n",num);
//else
//Console.WriteLine("{0} is a negative number.\n",num);
//Console.ReadLine();
//}
//.....................................................................................
//19).write a c# sharp program to read the value of an integer m and display the value of n is when m is larger than m is o and -1 when m is less than 0.

//{


//int n, m;

//m = Convert.ToInt32(Console.ReadLine());

//if (m > 0)
//{
//n = 1;
//Console.WriteLine(n);
//}
//lse if (m == 0)

//{    n = 0;
// Console.WriteLine(n);
//}
//else
//{
//n = -1;
//Console.WriteLine(n);
//}
//console.ReadLine();
// }
// }
//}
//............................................................................................
//20).wwrite a program to read the age of a candidate and determine whether it is  eligible for casting his\her.

//{

// int age;
// Console.WriteLine("input age of candidate");
// age = Convert.ToInt32(Console.ReadLine());
// if (age <= 18)
// {
// Console.WriteLine("you are not eligible to caste your vote.\n");
//  }
// else
// Console.WriteLine("you are eligible casting your vote.\n");

// }
//}

// }




//9TH JUNE FIRST ASSIGNMENT (FRIDAY)
//1)Sum of two number
//{

//int a;
//int b;
//int result;
//Console.WriteLine("enter a number");
//a =convert.ToInt32(console.readline());
//b = Convert.ToInt32(Console.ReadLine());
//result = a + b;
//console.WriteLine(result);
//console.ReadLine();
//}

//2)Subtract of two number

//{    
//  int a;
// int b;
// int result;
// Console.WriteLine("enter a number");
// a = Convert.ToInt32(Console.ReadLine());
// b = Convert.ToInt32(Console.ReadLine());
//  result = a + b;
// Console.WriteLine(result);
// Console.ReadLine()

// }

//3) Multiplication of two number
//{


//int a;
//int b;
//int result;
//Console.WriteLine("enter a number");
//a = Convert.ToInt32(Console.ReadLine());
//b = Convert.ToInt32(Console.ReadLine());
//result = a * b;
//Console.WriteLine(result);
//Console.ReadLine();
//}

//4)  Division of two number 
//{
//int a;
//int b;
//int result;
//Console.WriteLine("enter a number");
//a=Convert.ToInt32(Consol.ReadLine());
//b=ConvertToInt32(Console.ReadLine());
//result=a\b;
//Console.WriteLine(result);
//Console.ReadLine();

//5) Find even no.
//int i =0;
//Console.Writeline("Even numbers:");
//for(i=1;i<=20;i++)
//{
//if(i%2==0)
//{
//Console.WriteLine (i+""):
//Console.ReadLine();
//}
//}
//6).if sum of two number is greater than 100 or no

//int a;

//int b;



//int Sum;



//Console.WriteLine("Enter First Number");



//a=Convert.ToInt32(Console.ReadLine());



//Console.WriteLine("Enter second Number");



//b=Convert.ToInt32(Console.ReadLine());



//Sum = a + b;



//if(Sum>=100)

//{

//    Console.WriteLine("Sum of two Number is Greater than 100" );

//}

//else

//{

//    Console.WriteLine("Sum of two Number is not Greater than 100");

//7).if multiplication of the number is greater than 200.
//int num1;

//int num2;



//int Mul;



//Console.WriteLine("Enter First Number");



//num1 = Convert.ToInt32(Console.ReadLine());



//Console.WriteLine("Enter second Number");



//num2= Convert.ToInt32(Console.ReadLine());



//Mul = num1 * num2;



//if (Mul >= 200)

//{

//    Console.WriteLine("Multiplication of two Number is Greater than 200");

//}

//else

//{

//    Console.WriteLine("Multiplication of two Number is not Greater than 200");

//}

//Console.ReadLine();












