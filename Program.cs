void PrintArray(string[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j]} ");
        }
        Console.WriteLine();        
        }
}

// Заполнение массива 4х4 по спирали

string[,] arr = new string[4,4];

string[] str = {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16"};

for(int i = 0; i < 4; i++)
    arr[0,i] = str[i];

for(int j = 0; j < 4; j++)
    arr[j,3] = str[j+3];

for(int k = 0; k < 3; k++)
    arr[3,2-k] = str[7+k];

for(int i1 = 0; i1 < 2; i1++)
    arr[2-i1,0] = str[10+i1];

for(int j1 = 0; j1 < 2; j1++)
    arr[1,1+j1] = str[12+j1];

for(int k1 = 0; k1 < 2; k1++)
    arr[2,2-k1] = str[14+k1];

PrintArray(arr);

