string[] arr = {"test1", "test2", "test3", "test4" };
//Print method 1
Console.ForegroundColor = ConsoleColor.White;
Console.Write("\n(Foreach loop) Method 1: ");
foreach(string line in arr)
{
    Console.Write(line + " ");
}
//Print method 3
int k = 0;
Console.Write("\n(While loop)   Method 2: ");
while(k < arr.Length)
{
    Console.Write(arr[k] + " ");
    k++;
}
//Print method 3
Console.Write(("\n(For loop)     Method 3: "));
for(int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i] + " ");
}
Console.ReadLine();
