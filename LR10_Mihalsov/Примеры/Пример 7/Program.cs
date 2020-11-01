// Реализуем класс содержащий информацию о шрифтах 
// и использующий виртуальные методы, свойства и индексаторы 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    // Базовый класс     
    class Font
    {
        string TypeFont; short FontSize; public Font()
        {
            TypeFont = "Arial";
            FontSize = 12;
        }

        public Font(string TypeFont, short FontSize)
        {
            this.TypeFont = TypeFont; this.FontSize = FontSize;
        }

        public string typeFont
        {
            get
            {
                return TypeFont;
            }
            set
            {
                TypeFont = value;
            }
        }

        public short fontSize
        {
            get
            {
                return FontSize;
            }
            set
            {
                FontSize = value;
            }
        }

        // Создаем виртуальный метод         
        public virtual string FontInfo(Font obj)
        {
            string s = "Информация о шрифте: \n------------------\n\n" +
                "Тип шрифта: " + typeFont +
                "\nРазмер шрифта: " + fontSize + "\n"; return s;
        }
    }

    // Производный класс 1 уровня     
    class ColorFont : Font
    {
        byte Color;

        public ColorFont(byte Color, string TypeFont, short FontSize) : base(TypeFont, FontSize)
        {
            this.Color = Color;
        }

        // Переопределение для виртуального метода         
        public override string FontInfo(Font obj)
        {
            // Используется ссылка на метод, определенный в базовом классе Font             
            return base.FontInfo(obj) + "Цвет шрифта: " + Color + "\n";
        }

        // Создадим виртуальное свойство         
        public virtual byte color
        {
            set
            {
                Color = value;
            }
            get
            {
                return Color;
            }
        }
    }

    // Производный класс 2 уровня     
    class GradientColorFont : ColorFont
    {
        char TypeGradient;

        public GradientColorFont(char TypeGradient, byte Color, string TypeFont, short FontSize) :
                base(Color, TypeFont, FontSize)
        {
            this.TypeGradient = TypeGradient;
        }

        // Опять переопределяем виртуальный метод         
        public override string FontInfo(Font obj)
        {
            // Используется ссылка на метод определенный в производном классе FontColor             
            return base.FontInfo(obj) + "Тип градиента: " + TypeGradient + "\n\n";
        }

        // Переопределим виртуальное свойство         
        public override byte color
        {
            get
            {
                return base.color;
            }
            set
            {
                if (value < 10) base.color = 0;
                else
                    base.color = (byte)(value - 0x0A);
            }
        }
    }

    // Еще один производный класс 1 уровня     
    class FontStyle : Font
    {
        string style;

        public FontStyle(string style, string TypeFont, short FontSize) : base(TypeFont, FontSize)
        {
            this.style = style;
        }

        // Данный класс не переопределяет виртуальный метод 
        // поэтому при вызове метода FontInfo () 
        // вызывается метод созданный в базовом классе 
    }

    class Program
    {
        static void Main()
        {
            ColorFont font1 = new ColorFont(Color: 0xCF, TypeFont: "MS Trebuchet", FontSize: 16);

            Console.WriteLine(font1.FontInfo(font1));

            GradientColorFont font2 = new GradientColorFont(Color: 0xFF, TypeFont: "Times New Roman", FontSize: 10, TypeGradient: 'R');
            Console.WriteLine(font2.FontInfo(font2));

            font2.color = 0x2F;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Видоизмененный цвет font2");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(font2.FontInfo(font2));

            FontStyle font3 = new FontStyle(style: "oblique", TypeFont: "Calibri", FontSize: 16);
            Console.WriteLine(font3.FontInfo(font3));

            Console.ReadLine();
        }
    }
}
