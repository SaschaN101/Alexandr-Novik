using ConsoleApp2;
using System;
using System.Drawing;


/*Person tom = new Person();  // создание объекта класса Person

// Получаем значение полей в переменные
string personName = tom.name;
int personAge = tom.age;
Console.WriteLine($"Имя: {personName}  Возраст {personAge}");   // Имя: Undefined  Возраст: 0

// устанавливаем новые значения полей
tom.name = "Tom";
tom.age = 37;

Person tana = new Person();
string tanaName = tana.name;
int tanaAge = tana.age;
tana.name = "Tana";
tana.age = 10;
tana.Print();

// обращаемся к методу Print
tom.Print();    // Имя: Tom  Возраст: 37

Person Nasta = new Person();
Nasta.age = 12;
Nasta.name = "Nastulik";
Nasta.Print();
Console.WriteLine();

Car bmv = new Car();
bmv.brend = "BMW";

bmv.type = "X5";
bmv.price= 30000;
bmv.Print();
Console.WriteLine();
Car volvo = new Car("Volvo", "Кроссовер", 60000);
volvo.Print();
Console.WriteLine();
Car tesla = new Car("Tesla", "Model X", 100000);
tesla.Print();
Car kia = new Car("KIA", "Cheed", 5000);
kia.Print();
Car wv = new Car();
wv.Print();*/
/*Book book1 = new Book("Незнайка","белого", 25);
//book1.Print();
Book book2 = new Book("Я - Программист", "черного", 600);
//book2.Print();
///
string title; string color; int page;
book1.Deconstruct(out title, out color, out page);
////
(string title1, string color1, int page1) = book1;
///
var(title2, color2, page2) = book2;

string brend; string type; double price;
tesla.Deconstruct(out brend, out type, out price);
Console.WriteLine(tesla.brend);
Console.WriteLine(tesla.price);*/
Person1 bob;
bob.name= "Bob";
bob.age = 21;
bob.Print1();
Console.WriteLine();
newBook petr1 = new newBook();
petr1.title = "Петр 1";
petr1.color = "blue";
petr1.page = 250;
petr1.Print();
Console.WriteLine();
Puple dima = new Puple();
dima.name = "Dima";
dima.age = 33;
dima.group= 33;
dima.Print2();