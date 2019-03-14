using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryDaC
{
    public class ClosestPointPair
    {
        /// <summary>
        /// Минимальная дистанция между двумя точками
        /// </summary>
        double MinDist;

        /// <summary>
        /// Номер первой точки с минимальной дистанцией 
        /// </summary>
        int AnswerA;

        /// <summary>
        /// Номер второй точки с минимальной дистанцией 
        /// </summary>
        int AnswerB; 

        /// <summary>
        /// Структура точки: координаты x,y и ее номер 
        /// </summary>
        public struct PointId
        { 
            public int x, y, id;  
        }  
          
        /// <summary>
        /// Наибольший x двух точек
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        private static bool Cmp_x(PointId a, PointId b)
        {
            return a.x < b.x || a.x == b.x && a.y < b.y;  
        }  

        /// <summary> 
        /// Наибольший y двух точек 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        private static bool Cmp_y(PointId a, PointId b)
        {
            return a.y < b.y; 
        }

    }
     

    public class MergeSort 
    {
        /// <summary> 
        ////Сортировка массива слиянием
        /// </summary>
        /// <param name="array">Сортируемый массив</param>
        /// <returns></returns> 
        public static int[] Sort(int[] array)
        { 
            if (array.Length == 1)
                return array;
            int mid_point = array.Length / 2;
            return Merge(Sort(array.Take(mid_point).ToArray()), Sort(array.Skip(mid_point).ToArray()));
        }

        /// <summary>
        /// Разделение и сортировка двух массивов 
        /// </summary>
        /// <param name="mass1"></param> 
        /// <param name="mass2"></param> 
        /// <returns></returns>
        private static int[] Merge(int[] mass1, int[] mass2)
        {
            int a = 0, b = 0;
            int[] merged = new int[mass1.Length + mass2.Length];
            for (int i = 0; i < mass1.Length + mass2.Length; i++)
            {
                if (b < mass2.Length && a < mass1.Length)
                    if (mass1[a] > mass2[b] && b < mass2.Length)
                        merged[i] = mass2[b++];
                    else
                        merged[i] = mass1[a++]; 
                else
                    if (b < mass2.Length)
                    merged[i] = mass2[b++];
                else
                    merged[i] = mass1[a++];
            }
            return merged;
        } 
    }


} 
