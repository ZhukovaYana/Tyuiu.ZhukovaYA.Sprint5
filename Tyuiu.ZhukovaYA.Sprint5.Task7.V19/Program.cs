using Tyuiu.ZhukovaYA.Sprint5.Task7.V19.Lib;
namespace Tyuiu.ZhukovaYA.Sprint5.Task7.V19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Жукова Яна Андреевна | ИИПБ-24-1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Добавление к решению итоговых проектов по спринту                       *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #19                                                             *");
            Console.WriteLine("* Выполнил: Жукова Яна Андреевна | ИИПБ-24-1                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *"); 
            
            Console.WriteLine("*Дан файл С:\\DataSprint5\\InPutDataFileTask7V19.txt (файл взять из архива с*");
            Console.WriteLine("*согласно вашему варианту. Создать папку в ручную С:\\DataSprint5\\ и скопир*");
            Console.WriteLine("*ровать в неё файл) в котором есть набор символьных данных.Удалить все удв*");
            Console.WriteLine("*военные буквы сс из файла.Полученный результат сохранить в файл OutPutDDa*");
            Console.WriteLine("*taFileTask7V19.txt.                                                      *");

            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            string path = @"C:\DataSprint5\InPutDataFileTask7V19.txt";
            string res = ds.LoadDataAndSave(path);
            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");

            Console.ReadKey();
        }
    }
}