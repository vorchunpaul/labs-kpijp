using System;
class MyClass
{
    public int number;
    public char symbol;
    public void show()
    {
        Console.WriteLine("Целочисленное поле: " + number);
        Console.WriteLine("Символьное поле: " + symbol);
    } 
}

class UsingObjsDemol
{ // Главный метод:  
    static void Main()
    {
        MyClass A = new MyClass(); // Объектная переменная: 
        MyClass B; // Второй объект: 
        B = new MyClass();
        // Присваивание значений полям первого объекта: 
        A.number=123; 
        A.symbol='А'; 
        // Присваивание значений полям второго объекта: 
        B.number = 321;
        B.symbol = 'B'; // Вызов методов: 
        Console.WriteLine("Первый объект");
        A.show();
        Console.WriteLine("Второй объект");
        B.show();

        Console.ReadKey(true);
    }
}
