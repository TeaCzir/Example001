//Массивы.
int[] array = { 15, 56, 32, 4, 56, 46, 67, 56, 39 };

int n = array.Length;
int find = 56;

int index = 0;

while (index < n)
{

   if (array[index] == find)
   {
      Console.WriteLine(index);
      break;
   }
   //index = index + 1;
   index++;
}