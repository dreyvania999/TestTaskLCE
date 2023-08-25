using System;
using System.Collections.Generic;

class MainQuestionSolver
{
    /// <summary>
    /// Метод для решения главного вопроса в жизни и вселенной
    /// </summary>
    /// <param name="arr">Список входных данных</param>
    /// <returns>Ответ на главный вопрос вселенной</returns>
    static int SolveMainQuestion(List<int> arr)
    {
        int result = 0;  // Переменная для хранения результата вычислений
        int index = 0;   // Индекс текущего элемента в списке

       
        while (index < arr.Count)
        {
            int currentNumber = arr[index];  // Текущий элемент списка

            // Если текущий элемент равен 1
            if (currentNumber == 1)
            {
                int nextNumber = arr[index + 1];        
                int nextNextNumber = arr[index + 2];    
                result += nextNumber + nextNextNumber;  // Добавляем сумму двух следующих чисел к результату
                index += 3;                             
            }
            // Если текущий элемент равен 2
            else if (currentNumber == 2)
            {
                int nextNumber = arr[index + 1];        
                int nextNextNumber = arr[index + 2];    
                result += nextNumber * nextNextNumber;  // Добавляем произведение двух следующих чисел к результату
                index += 3;                            
            }
            // Если текущий элемент равен 99
            else if (currentNumber == 99)
            {
                break;
            }
        }

        return result;
    }

    static void Main(string[] args)
    {
        List<int> arr = new List<int> { 1, 2, 4, 2, 3, 3, 2, 9, 3, 99, 2, 1, 24 };
        int answer = SolveMainQuestion(arr);  // Вызываем функцию решения вопроса
        Console.WriteLine("Ответ на вопрос: " + answer);  // Выводим ответ на экран
    }
}
