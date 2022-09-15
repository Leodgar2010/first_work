void PrintArray (string [] arr)
{
    string arrStr = string.Join(", ", arr);
    string result = string.Concat("[", arrStr, "]");
    Console.WriteLine (result);
}
// string [] array =  new string [] {"Hello", "2", "world", ":-)"};
// string [] array =  new string [] {"Russia", "Denmark", "Khazan"};
string [] array =  new string [] {"1234", "1567", "-2","computer science"};
int count = 0;
for (int i=0; i<array.Length; i++)
    if (array[i].Length<=3)count+=1;
string [] result = new string [count];
count = 0;
for (int i=0; i<array.Length; i++)
    if (array[i].Length<=3)
    {
        result[count]=array[i];
        count+=1;
    }
PrintArray (array);
PrintArray (result);

// сохранил закомментированные значения array для упрощения проверки