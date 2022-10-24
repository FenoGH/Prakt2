using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LibMas
{
    public static class LibMas1
    {
        /// <summary>
        /// Заполнение двумерного массива
        /// </summary>
        /// <param name="mas">Массив</param>
        public static void ZapolnMas(ref int[] mas)
        {
            Random rnd= new Random();
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 1; j < mas.GetLength(0+1); j++)
                {
                    mas[i] = rnd.Next(-4, 8);
                }
            }
               
            
        }
        /// <summary>
        /// Очистка массива
        /// </summary>
        /// <param name="mas>Массив</param>
        public static void OchistMas(ref int[] mas)
        {
            mas = new int[0];
        }
        /// <summary>
        /// Сохранение двумерного массива
        /// </summary>
        /// <param name="mas">Массив</param>
        /// <param name="path">Путь который выбрал пользователь</param>
        public static void SaveMas(int[] mas, string path)
        {
            StreamWriter file = new StreamWriter(path);
            file.WriteLine(mas.Length);
            for (int i = 0; i < mas.Length; i++)
            {
                file.WriteLine($"{mas[i]}");
            }
            file.Close();
        }
        /// <summary>
        /// Запись массива с файла
        /// </summary>
        /// <param name="mas">Массив</param>
        /// <param name="path">Путь который выбрал пользователь</param>
        public static void UploadMas(ref int[] mas, string path)
        {
            StreamReader read = new StreamReader(path);
            int.TryParse(read.ReadLine(), out int len);
            mas = new int[len];
            for (int i = 0; i < mas.Length; i++)
            {
                int.TryParse(read.ReadLine(), out int value);
                mas[i] = value;
            }
            read.Close();
        }

        public static void ZapolnMas(ref int[,] mas)
        {
            throw new NotImplementedException();
        }

        public static void OchistMas(ref int[,] mas)
        {
            throw new NotImplementedException();
        }

        public static void SaveMas(int[,] mas, string fileName)
        {
            throw new NotImplementedException();
        }

        public static void UploadMas(ref int[,] mas, string fileName)
        {
            throw new NotImplementedException();
        }
    }
}
