//For loop print 
Console.WriteLine("For loop use to 1 to 10");

for (int i = 1; i <= 10; i++)
{
       Console.WriteLine(i);
}

//For loop use to 10 to 1

Console.WriteLine("For loop use to 10 to 1");

for (int i = 10; i >= 1; i--)
{
       Console.WriteLine(i);
}


//While loop print 1 to 10
Console.WriteLine("While loop use to 1 to 10");
int j = 1;

while (j <= 10)
{
    Console.WriteLine(j);
    j++;
}

//While loop print 10 to 1
Console.WriteLine("While loop use to 10 to 1");

int k = 10;
while (k >= 1)
{
    Console.WriteLine(k);
    k--;
}

//Do while loop print 1 to 10
Console.WriteLine("Do while loop use to 1 to 10");
int m = 1;
do
{
    Console.WriteLine(m);
    m++;
} while (m <= 10);


//Do while loop print 10 to 1
Console.WriteLine("Do while loop use to 10 to 1");
int n = 10;
do
{
    Console.WriteLine(n);
    n--;
} while (n >= 1);

Console.WriteLine();
//Sum of 1 to 10 using for loop

int sum = 0;
for( int i = 1; i <= 10; i++)
{
    sum += i;
}
Console.WriteLine("Sum of 1 to 10 using for loop: " + sum);

Console.WriteLine();
//Sum of 1 to 10 using while loop
int sum2 = 0;
int p = 1;
while (p <= 10)
{
    sum2 += p;
    p++;
}
Console.WriteLine("Sum of 1 to 10 using while loop: " + sum2);