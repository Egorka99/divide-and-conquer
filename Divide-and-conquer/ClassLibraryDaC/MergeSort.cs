using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryDaC
{     

     


    public class MergeSort 
    {
        /// <summary> 
        ////Сортировка массива слиянием
        /// </summary>
        /// <param name="array">Сортируемый массив</param>
        /// <returns></returns> 
        public static int[] RecSort(int[] array) 
        { 
            if (array.Length == 1)
                return array; 
            int mid_point = array.Length / 2;
            return Merge(RecSort(array.Take(mid_point).ToArray()), RecSort(array.Skip(mid_point).ToArray()));
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

        /// <summary>
        /// Разделение и сортировка двух массивов 
        /// </summary>
        /// <param name="a">Сортируемый массив</param>
        /// <param name="l">Левая граница массива</param>
        /// <param name="m">Середина массива</param> 
        /// <param name="r">Правая граница массива</param>
        void Merge(int[] a, int l, int m, int r) 
        { 
            int i, j;
            int[] aux = new int[20]; 
            for (i = m + 1; i > l; i--) aux[i - 1] = a[i - 1];
            for (j = m; j < r; j++) aux[r + m - j] = a[j + 1];
            for (int k = l; k <= r; k++)
                if (aux[j] < aux[i]) 
                    a[k] = aux[j--];
                else
                    a[k] = aux[i++];
        }  
         

        /// <summary>
        /// Восходящая сортировка слиянием 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="l"></param>
        /// <param name="r"></param>
        void IterSort(int[] a, int l, int r)  
        { 
            for (int m = 1; m <= r - l; m = m + m)
                for (int i = l; i <= r - m; i += m + m)
                    Merge(a, i, i + m - 1, Math.Min(i + m + m - 1, r));
        }
    } 
     

} 
