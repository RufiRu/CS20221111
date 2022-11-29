// Счетчик. Флаг
int n=int.Parse(Console.ReadLine());
int k=0;//счетчик
bool flag=false;//флаг
for(int i=0;i<n;i++)
{
    int a=int.Parse(Console.ReadLine());
    if (a<5) k++;
    if (a==10) flag=true;
}
System.Console.WriteLine(k);
if (flag) System.Console.WriteLine("YES");else System.Console.WriteLine("NO");
