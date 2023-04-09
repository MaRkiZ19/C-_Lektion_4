/*string [,] table = new string[2,5];
table[1,2] = "слово";


for (int rows = 0; rows < 2; rows++)
{
    for (int columns = 0; columns < 5; columns++)
    {
        System.Console.WriteLine($"-{table[rows, columns]}-");
    }
}*/

int[,] matrix = new int[3,4];


void PrintArray(int [,] matr)
{
for (int i = 0; i < 3; i++)   //вместо i<3 можно написать matrix.GetLength(0) где matrix название ранее заданного массива, а 0 посыл к количеству строк
{
    for (int j = 0; j < 4; j++)   //вместо j<4 можно написать matrix.GetLength(1) где matrix название ранее заданного массива, а 1 посыл к количеству столбцов
    {
        System.Console.Write($"{matrix[i,j]} "); 
    }
    System.Console.WriteLine();
}
}

void FillArray (int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matr[i,j]=new Random().Next(1,10);
        }
    }
}

PrintArray(matrix);
System.Console.WriteLine();
FillArray(matrix);
PrintArray(matrix);
