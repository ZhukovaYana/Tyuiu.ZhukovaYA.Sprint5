using Tyuiu.ZhukovaYA.Sprint5.Task6.V5.Lib;
namespace Tyuiu.ZhukovaYA.Sprint5.Task6.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Жукова Яна Андреевна | ИИПБ-24-1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Обработка текстовых файлов                                              *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #5                                                            *");
            Console.WriteLine("* Выполнил: Жукова Яна Андреевна | ИИПБ-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *"); 
            
            Console.WriteLine("*Дан файл С:\\DataSprint5\\InPutDataFileTask6V5.txt (файл взять из архива со*");
            Console.WriteLine("*огласно вашему варианту. Создать папку в ручную С:\\DataSprint5\\ и скопиро*");
            Console.WriteLine("*овать в неё файл) в котором есть набор символьных данных. Найти количеств*");
            Console.WriteLine("*во заглавных латинских букв в заданной строке.                           *");

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
            double res = ds.LoadFromDataFile(@"C:\DataSprint5\InPutDataFileTask6V5.txt");

            Console.WriteLine("Кол-во = " + res);
            Console.ReadKey();
        }
    }
}