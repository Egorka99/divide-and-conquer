using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq; 

namespace ClassLibraryDaC
{ 

    public class ClosestPointPair
    {
        /// <summary> 
        /// Максимальное количество точек
        /// </summary>
        const int MAXN = 20; 

        /// <summary> 
        /// Минимальная дистанция между двумя точками
        /// </summary>
        static double MinDist;

        /// <summary>
        /// Номер первой точки с минимальной дистанцией 
        /// </summary>
        static int AnswerA;

        /// <summary>
        /// Номер второй точки с минимальной дистанцией 
        /// </summary>
        static int AnswerB;
         
        /// <summary>
        /// Структура точки: координаты x,y и ее номер 
        /// </summary>
        public struct PointId
        { 
            public int x, y, id;
        } 

        /// <summary>  
        /// Массив точек  
        /// </summary>  
        public PointId[] a = new PointId[MAXN];


        /// <summary>
        /// Сортировка массива точек по x-координатам
        /// </summary>
        /// <param name="a"></param>
        /// <param name="first"></param>
        /// <param name="last"></param>
        /// <returns></returns>
        protected static PointId[] SortByX(PointId[] a, int first, int last)
        {
            List<PointId> OrderedArr = new List<PointId>(); // список для сортировки 

            for (int i = first; i < last; i++) // заполняем список из входящего массива
            {  
                OrderedArr.Add(a[i]);    
            }

            OrderedArr = OrderedArr.OrderBy(arr => arr.x).ToList(); // сортируем 

            return OrderedArr.ToArray(); // преобразововаем в массив 
        } 

        /// <summary> 
        /// Сортировка массива точек по y-координатам 
        /// </summary> 
        /// <param name="a"></param>
        /// <param name="first"></param>
        /// <param name="last"></param>
        /// <returns></returns>
        protected static PointId[] SortByY(PointId[] a, int first, int last)
        {
            List<PointId> OrderedArr = new List<PointId>(); // список для сортировки 

            for (int i = first; i < last; i++) // заполняем список из входящего массива
            {
                OrderedArr.Add(a[i]); 
            }

            OrderedArr = OrderedArr.OrderBy(arr => arr.y).ToList(); // сортируем 

            return OrderedArr.ToArray(); // преобразововаем в массив
        }


        /// <summary>
        /// Вычисление расстояния между точками 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        private static void CalculateDist(PointId a, PointId b) 
        {
            double Dist = Math.Sqrt((a.x - b.x) * (a.x - b.x) + (a.y - b.y) * (a.y - b.y) + .0); // вычисляем расстояние

            // если это растояние меньше минимального: делаем его минимальным, добавляем точки в ответ 
            if (Dist < MinDist) 
            {
                MinDist = Dist; 
                AnswerA = a.id; 
                AnswerB = b.id;
            }
               
        }

        /// <summary>
        /// Рекурсивный алгоритм, работает с массивом a[l...r]
        /// </summary>
        /// <param name="l">Левая граница массива</param>
        /// <param name="r">Правая граница массива</param> 
        private void rec(int l , int r) 
        { 
            // Если расстояние между r и l слишком мало, то рекурсию надо остановить, 
            // и выполнить тривиальный алгоритм поиска ближайшей пары 
            // и затем отсортировать подмассив по y - координате
            if (r - l <= 3) 
            { 
                for (int i = l; i <= r; ++i) 
                    for (int j = i + 1; j <= r; ++j)    
                        CalculateDist(a[i], a[j]);
                 
                SortByY(a, l, r + 1); 
                return;
            }

            PointId[] t = new PointId[MAXN]; //вспомогательные буферы  
            List<PointId> b = new List<PointId>(); // B = {Pi| |Xi - midx| < Mindist}
            List<PointId> c = new List<PointId>(); // C(Pi) = {Pj | Pj (- B, Yi - Mindist < Yj <= Yi}
             

            int mid = l + r / 2; // индекс середины массива 
            int midx = a[mid].x;   // x-координата середины массива 
            rec(l, mid);  
            rec(mid + 1, r); // рекурсивный обход правой и левой половины массива 

             
            // заполняем B
            for (int i = 0; i < a.Length; i++)
            {
                // множество точек B = {Pi| |Xi - midx| < Mindist} 
                if (Math.Abs(a[i].x - midx) < MinDist)
                {
                    b.Add(a[i]);    
                }
            }

            PointId[] B = b.ToArray(); 
                 
            // сортируем     
            SortByY(B, 0, B.Length); 

            // Заполняем С  
            for (int i = 0; i < B.Length; i++) 
            {
                for (int j = 0; j < B.Length; j++) 
                {
                     if (B[i].y - MinDist < B[j].y  && B[j].y <= B[i].y)
                     {
                        c.Add(B[j]);   
                     }
                } 
            }

            PointId[] C = c.ToArray(); 

            //для каждой точки p_i \in B рассмотреть все точки p_j \in C(p_i), 
            //и каждой пары(p_i, p_j) посчитать расстояние и сравнить с текущим наилучшим расстоянием.
            for (int i = 0; i < B.Length; i++)
            {
                for (int j = 0; j < C.Length; j++)
                {
                    CalculateDist(B[i], C[j]);
                }
            }
             

            //// объединяем а1 и а2 в t и сортируем 
            //t = a1.Concat(a2).ToArray();
            //SortByY(t, 0, t.Length - 1);  

            ////Для слияния двух множеств точек, полученных от рекурсивных вызовов, в одно(упорядоченное по y - координате),
            ////мы используем стандартную функцию STL merge(), и создаём вспомогательный буфер t[](один на все рекурсивные вызовы).
            ////merge(a + l, a + m + 1, a + m + 1, a + r + 1, t, &cmp_y); 
            ////copy (t, t+r-l+1, a+l);  


            //// не ебу че происходит надо разобраться 
            //int tsz = 0; 
            //for (int i = l; i <= r; ++i) 
            //{
            //    if (Math.Abs(a[i].x - midx) < MinDist)
            //    {
            //        for (int j = tsz - 1; j >= 0 && a[i].y - t[j].y < MinDist; --j)
            //            CalculateDist(a[i], t[j]);
            //        t[tsz++] = a[i];
            //    } 
            //}

        }   



    } 
}
