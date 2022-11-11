using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace HomeWork
{
//1. Написать метод на входе два параметра типа string, на выходе string, который объединяет два входных параметра через разделитель |;
//2. Написать метод на входе параметр типа DateTime и параметр типа int, вернуть из метода параметр DateTime к которому будет прибавлено указанное количество секунд из второго входного параметра;
//3. Модернизация второго задания, добавить еще один параметр на входе, типа string, в котором будет указываться шаг, с которым необходимо сделать приращение даты(second, minute, hour, month, year) (Задание сделать через switch);
//4. Написать метод, на входе два int параметра, необходимо сделать массив от первого значения до второго с шагом 2, например, от 10 до 50;
//5. На основе задания 4 вернуть обратную сортировку массива;
//6. Написать метод, на входе два int параметра(первый задает начальное значение, второй задаёт кол-во элементов в массиве), необходимо сделать массив на основе этих данных;
//7. На основе задания 6, пройтись по всем элементам массива и написать в консоль какие значения четные, а какие нет(четное/нечетное);
//8. Написать метод, который вернет список дат(интервал в сутки), от двух входных параметров типа DateTime;
//9. Написать метод, на входе переменная типа string, метод должен вывести в консоль данную строку с перемешиванием символов.Например, указали строку test, вывелось tets;
//10. Написать простой калькулятор, который сможет производить операции сложения/вычитания/деления/умножения;
    public class _1
    {

        public void One()
        {
            string one = "any1";
            string two = "any2";
            string result = one + " | " + two;

            Console.WriteLine(result);
        }

        public void Two()
        {
            DateTime dateTime = DateTime.Now;
            int sec = 77;
            dateTime = dateTime.AddSeconds(sec);

            Console.WriteLine(dateTime);
        }

        public void Three()
        {
            DateTime dateTime = DateTime.Now;
            string add = "random";
            int addNum = 77;

            switch (add)
            {
                case "second":
                    dateTime.AddSeconds(addNum);
                    break;
                case "minute":
                    dateTime.AddMinutes(addNum);
                    break;
                case "hour":
                    dateTime.AddHours(addNum);
                    break;
                case "month":
                    dateTime.AddMonths(addNum);
                    break;
                case "year":
                    dateTime.AddYears(addNum);
                    break;
                default:
                    Console.WriteLine("Не введён шаг.");
                    break;
            }
            Console.WriteLine(dateTime);
        }
        
        public void Four()
        {
            int start = 10;
            int end = 50;

            int[] result = Enumerable.Range(start, end - start + 1).ToArray();

            for (int i = 0; i < result.Length; i+=2)
                Console.WriteLine(result[i]);
        }

        public void Five()
        {
            int start = 10;
            int end = 50;

            int[] result = Enumerable.Range(start, end - start + 1).ToArray();

            for (int i = result.Length - 1; i >= 0; i -= 2)
                Console.WriteLine(result[i]);
        }

        public void Six()
        {
            int start = 0;
            int end = 10;

            int[] result = Enumerable.Range(start, end).ToArray();

            for (int i = start; i < result.Length; i++)
                Console.WriteLine(result[i]);
        }

        public void Seven()
        {
            int start = 0;
            int end = 10;

            int[] result = Enumerable.Range(start, end).ToArray();

            for (int i = start; i < result.Length; i++)
            {
                if (i % 2 == 1)
                    Console.WriteLine($"{result[i]} - чётное");
                else
                    Console.WriteLine($"{result[i]} - нечётное");
            }
        }

        public void Eight()
        {
            DateTime dateStart = new DateTime(2000, 1, 1);
            DateTime dateEnd = new DateTime(2000, 1, 30);

            for (int i = 0; i < dateEnd.Day; i++)
                Console.WriteLine(dateStart.AddDays(i));
        }
        
        public void Nine()
        {
            string start = "test";
            Random rnd = new Random();
            char[] symbol = start.OrderBy(x => rnd.Next()).ToArray();

            Console.WriteLine(symbol);
        }

        public void Ten()
        {
            int one = 1;
            int two = 2;
            string symbol = "*";
            int result;

            switch (symbol)
            {
                case "+":
                    Console.WriteLine(one + two);
                    break;
                case "*":
                    Console.WriteLine(one * two);
                    break;
                case "-":
                    Console.WriteLine(one - two);
                    break;
                case "/":
                    Console.WriteLine(one / two);
                    break;
                default:
                    Console.WriteLine("Ввели не правильный символ");
                    break;
            }
        }
    }
}
