// 4. По заданному с клавиатуры номеру дня недели вывести его название
int a;

string? s=Console.ReadLine ();
a=Convert.ToInt32 (s);

if(a==1) 
{
    System.Console.WriteLine ($"a со значением {a} является понедельник");
}
else if(a==2)
{
    System.Console.WriteLine ($"a со значением {a} является вторник");
}
else if(a==3)
{
    System.Console.WriteLine ($"a со значением {a} является среда");
}
else if(a==4)
{
    System.Console.WriteLine ($"a со значением {a} является четверг");
}
else if(a==5)
{
    System.Console.WriteLine ($"a со значением {a} является пятница");
}
else if(a==6)
{
    System.Console.WriteLine ($"a со значением {a} является суббота");
}
else if(a==7)
{
    System.Console.WriteLine ($"a со значением {a} является воскресенье");
}
else 
{
    System.Console.WriteLine ($"a со значением {a} не является днем недели");
}