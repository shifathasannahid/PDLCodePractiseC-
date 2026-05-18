//One dimentional Array
//int[] nums = { 10, 20, 30, 40, 50 };

//for (int i = 0; i < nums.Length; i++)
//{
//    Console.WriteLine("Eelements at index "+ i +":"+ nums[i]);
//}


//Two dimentional Array

//int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };
//Console.WriteLine(numbers[1, 2]);

//Change Elements of a 2D Array
//int[,] number = { { 11, 12, 13 }, { 17, 18, 19 } };
//number[1, 2] = 20;
//Console.WriteLine(number[1, 2]);

//Use of 2 dimentional Array
int[,] matrix =
{
    {1, 2, 3 },
    {4, 5, 6},
    {7, 8, 9 }
};

for(int i = 0; i < matrix.GetLength(0); i++)
{
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write(matrix[i, j]+ " ");
    }
    Console.WriteLine();
}