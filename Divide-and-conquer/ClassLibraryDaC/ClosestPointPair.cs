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
        PointId[] a = new PointId[MAXN];

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
        /// Наибольший игрек двух точек 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        private static bool Cmp_y(PointId a, PointId b)
        { 
            return a.y < b.y;
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
                 
                //sort(a + l, a + r + 1, &cmp_y);
                return;
            }

            PointId[] t = new PointId[MAXN]; //вспомогательный буфер  

            int mid = l + r / 2; // индекс середины массива
            int midx = a[mid].x;   // x-координата середины массива
            rec(l, mid);  
            rec(mid + 1, r); // рекурсивный обход правой и левой половины массива 

            //Для слияния двух множеств точек, полученных от рекурсивных вызовов, в одно(упорядоченное по y - координате),
            //мы используем стандартную функцию STL merge(), и создаём вспомогательный буфер t[](один на все рекурсивные вызовы).
            //merge(a + l, a + m + 1, a + m + 1, a + r + 1, t, &cmp_y); 
            //copy (t, t+r-l+1, a+l); 


            // не ебу че происходит надо разобраться 
            int tsz = 0;
            for (int i = l; i <= r; ++i)
            {
                if (Math.Abs(a[i].x - midx) < MinDist)
                {
                    for (int j = tsz - 1; j >= 0 && a[i].y - t[j].y < MinDist; --j)
                        CalculateDist(a[i], t[j]);
                    t[tsz++] = a[i];
                } 
            }
               
        }  



    } 
}
