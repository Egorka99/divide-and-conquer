﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace ClassLibraryDaC
{

    /// <summary>
    /// Структура точки: координаты x,y и ее номер 
    /// </summary>
    public struct PointId
    {
        public int x, y, id;
    }

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
        /// Массив точек   
        /// </summary>   
        List<PointId> a; 

        public ClosestPointPair(List<PointId> A)
        {
            MinDist = 1e20;
  
            a = A; 
             
        }

        /// <summary>
        /// Нахождение двух ближайших пар точек  
        /// </summary>
        /// <returns></returns>
        public List<PointId> NearestPair()  
        { 
            List<PointId> NearestPair = new List<PointId>(); 

            SortByX(a, 0 ,a.Count - 1); 
            Rec(0, a.Count - 1);   

            for (int i = 0; i < a.Count; i++)
            {
                 if ((a[i].id == AnswerA) || (a[i].id == AnswerB))
                 {
                    NearestPair.Add(a[i]);
                 } 
            } 
             
            return NearestPair; 
        }

        /// <summary>
        /// Нахождение минимального расстояния между двумя точками 
        /// </summary>
        /// <returns></returns>
        public double MinDistance()  
        {
            SortByX(a, 0, a.Count - 1); 
            Rec(0, a.Count - 1); 
               
            return Math.Round(MinDist,3);
        }

        /// <summary>
        /// Нахождение минимального расстояния между двумя точками простым алгоритмом 
        /// </summary>
        /// <returns></returns>
        public double SimpleMinDistance()
        {

            for (int i = 0; i < a.Count; i++)
            {
                for (int j = 0; j < a.Count; j++)
                { 
                    if (a[i].id != a[j].id)
                        CalculateDist(a[i],a[j]);
                }
            }
             
            return Math.Round(MinDist, 3);
        } 

        /// <summary>
        /// Сортировка массива точек по x-координатам
        /// </summary>
        /// <param name="a"></param>
        /// <param name="first"></param> 
        /// <param name="last"></param> 
        /// <returns></returns>
        private static List<PointId> SortByX(List<PointId> a, int first, int last)
        {
            a.Skip(first).Take(last).OrderBy(arr => arr.x).Select(s => s);

            return a;     
        }

        /// <summary>
        /// Сортировка массива точек по y-координатам
        /// </summary>
        /// <param name="a"></param>  
        /// <param name="first"></param> 
        /// <param name="last"></param> 
        /// <returns></returns>
        private static List<PointId> SortByY(List<PointId> a, int first, int last)
        {
            a.Skip(first).Take(last).OrderBy(arr => arr.y).Select(s => s);

            return a;  
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
        private void Rec(int l , int r) 
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

            // PointId[] B = new PointId[MAXN]; // B = {Pi| |Xi - midx| < Mindist}
            List<PointId> B = new List<PointId>(); 
               
            int mid = l + r / 2; // индекс середины массива 
            int midx = a[mid].x;   // x-координата середины массива 
            Rec(l, mid);  
            Rec(mid + 1, r); // рекурсивный обход правой и левой половины массива 



            // заполняем B 
            for (int i = 0; i < a.Count; i++)
            {
                // множество точек B = {Pi| |Xi - midx| < Mindist} 
                if (Math.Abs(a[i].x - midx) < MinDist)
                { 
                    B.Add(a[i]); 
                }
            }
               
            // сортируем     
            SortByY(B, 0, B.Count);

            // сравниваем все точки B, каждую с каждой, выделяем множество С(Pi) для каждой точки, считаем расстояние 
            for (int i = 0; i < B.Count; i++)
            {
                for (int j = 0; j < B.Count; j++)
                {
                    // C(Pi) = {Pj | Pj (- B, Yi - Mindist < Yj <= Yi} 
                    if (B[i].y - MinDist < B[j].y && B[j].y <= B[i].y)
                    { 
                        if (B[i].id != B[j].id) // если точки не одинаковые(расстояние между ними 0)       
                            CalculateDist(B[i], B[j]);
                    } 
                } 
            } 
             
        }    
    } 

}  
