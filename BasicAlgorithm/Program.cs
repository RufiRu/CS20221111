﻿// Обмен значениями двух переменных

//int a=5;
//int b=7;
//int temp;
//temp=a;
//a=b;
//b=temp;


int a=5;
int b=7; 
a=a^b;
b=a^b;
a=a^b;
System.Console.WriteLine($"a={a} b={b}");
