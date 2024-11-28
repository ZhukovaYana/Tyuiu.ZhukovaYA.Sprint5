using Tyuiu.ZhukovaYA.Sprint5.Task4.V10.Lib;
namespace Tyuiu.ZhukovaYA.Sprint5.Task4.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Жукова Яна Андреевна | ИИПБ-24-1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Чтение данных из текстового файла                                       *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнил: Жукова Яна Андреевна | ИИПБ-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *"); 
            
            Console.WriteLine("*Дан файл С:\\DataSprint5\\InPutDataFileTask4V0.txt (файл взять из архива со*");
            Console.WriteLine("*огласно вашему варианту. Создать папку в ручную С:\\DataSprint5\\ и скопиро*");
            Console.WriteLine("*овать в неё файл) в котором есть вещественное значение. Прочитать значени*");
            Console.WriteLine("*ие из файла и подставить вместо Х в формуле . Вычислить значение по форму*");
            Console.WriteLine("*уле (Полученное значение округлить до трёх знаков после запятой) и вернут*");
            Console.WriteLine("*ть полученный результат на консоль.                                      *");

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

            int x = 3;
            double res = ds.LoadFromDataFile(@"C:\DataSprint5\InPutDataFileTask4V10.txt");
            Console.WriteLine("Файл: " + @"C:\Users\Win\AppData\Local\Temp\OutPutFileTask0.txt");
            Console.WriteLine("Создан!");

            Console.WriteLine("Результат: "+ res);

            Console.ReadKey();
        }
    }
}