// See https://aka.ms/new-console-template for more information

//Atama ve İşlemli Atama

int x = 3;
int y = 3;
y = y +2;

Console.WriteLine(y);
y += 3;
Console.WriteLine(y);
y /= 2;
Console.WriteLine(y);


Console.WriteLine("***Mantıksal Operatörler***");
// Mantıksal Operatörler
// ||, &&, !

bool isSuccess = true;
bool isCompleted = false;

if(isSuccess  && isCompleted){
    Console.WriteLine("Perfect!");
}

if(isSuccess  || isCompleted){
    Console.WriteLine("Good enough!");
}

if(isSuccess  && !isCompleted){
    Console.WriteLine("Meh!");
}

Console.WriteLine("*** İlişkisel Operatörler***");
// İlişkisel Operatörler
// <, >, >=, <=, ==, !=

bool sonuc = x < y;

Console.WriteLine(sonuc);
sonuc = x > y;
Console.WriteLine(sonuc);
sonuc = x <= y;
Console.WriteLine(sonuc);
sonuc = x >= y;
Console.WriteLine(sonuc);
sonuc = x == y;
Console.WriteLine(sonuc);
sonuc = x != y;
Console.WriteLine(sonuc);


Console.WriteLine("***Aritmatik Operatörler***");
// Aritmatik Operatörler
// /, *, +,  -

int sayi1 = 10;
int sayi2 = 5;

int sonucAr = sayi1/sayi2;
Console.WriteLine(sonucAr);

sonucAr = sayi1*sayi2;
Console.WriteLine(sonucAr); sonucAr = sayi1+sayi2;
Console.WriteLine(sonucAr);

sonucAr = sayi1-sayi2;
Console.WriteLine(sonucAr);

sonucAr = sayi1++;
Console.WriteLine(sonucAr);
Console.WriteLine(sayi1);

int sonucMod = 20%3;
Console.WriteLine(sonucMod);