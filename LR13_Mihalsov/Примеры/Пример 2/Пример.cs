using System;
namespace DelgateForNotes
{
    public class Program
    {
        public class BubbleSortClass
        {
            static public void Sort(object[] sortArray, CompareDelegate gtMethod)
            {
                for (int i = 0; i < sortArray.Length; i++)
                {
                    for (int j = 0; j < sortArray.Length; j++)
                    {
                        if (gtMethod(sortArray[j], sortArray[i]))
                        {
                            object temp = sortArray[i];
                            sortArray[i] = sortArray[j];
                            sortArray[j] = temp;
                        }
                    }
                }
            }
        }
        class Student
        {
            private string name;
            private int rollno;
            private int marks;
            // Инициализация объекта класса
            public Student(string name, int rollno, int marks)
            {
                this.name = name;
                this.rollno = rollno;
                this.marks = marks;
            }
            // Переопределение метода для вывода результата
            public override string ToString()
            {
                return string.Format("Name => {0}, RollNumber => {1}, Marks => {2} ", name,
               rollno, marks);
            }
            // Пользовательская функция сравнение, возвращающая булевое значение
            public static bool RhsIsGreater(object lhs, object rhs)
            {
                Student stdLhs = (Student)lhs;
                Student stdRhs = (Student)rhs;
                return stdRhs.marks > stdLhs.marks;
            }
        }

        // Объявление делегата, ссылающегося на функцию
        // с двумя параметрами и выводом булевого типа
        public delegate bool CompareDelegate(object lhs, object rhs);
        static void Main(string[] args)
        {
            // Создание массива объектов класса Student.cs
            Student[] students = {
                 new Student("Mark", 1, 799),
                 new Student("David", 2, 545),
                 new Student("Lavish", 3, 999),
                 new Student("Voora", 4, 228),
                 new Student("Boll", 5, 768),
                 new Student("Donna", 6, 367),
                 new Student("Adam", 7, 799),
                 new Student("Steve", 8, 867),
                 new Student("Ricky", 9, 978),
                 new Student("Brett", 10, 567)
            };
            // Создание делегата с передачей
            // статического метода класса Student в качестве аргумента
            CompareDelegate StudentCompareOp = new CompareDelegate(Student.RhsIsGreater);
            // Вызов статического метода класса BubbleSortClass,
            // передача массива объектов и делегата
            BubbleSortClass.Sort(students, StudentCompareOp);
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(students[i].ToString());
            }
            Console.Read();
        }
    }
}
