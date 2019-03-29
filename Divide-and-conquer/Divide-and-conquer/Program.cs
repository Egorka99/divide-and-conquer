using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryDaC; 

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {


            PointId[] Arr = new PointId[] {

                 new PointId() { x = 3, y = 6, id = 0 },
                 new PointId() { x = -5, y = 5, id = 1 },
                 new PointId() { x = 3, y = 3, id = 2 },
                 new PointId() { x = -5, y = -3, id = 3 }, 
                 new PointId() { x = -3, y = 2, id = 4 },
                 new PointId() { x = -1, y = 4, id = 5 },
                 new PointId() { x = 3, y = 2, id = 6 },
                 new PointId() { x = 6, y = 3, id = 7 },
                 new PointId() { x = 0, y = 4, id = 8 } 

            }; 

            //PointId[] Arr = new PointId[] { 

            //     new PointId() { x = -4, y = 3, id = 0 },
            //     new PointId() { x = -4, y = -3, id = 1 },
            //     new PointId() { x = 0, y = 0, id = 2 },
            //     new PointId() { x = 1, y = -1, id = 3 },
            //     new PointId() { x = 1, y = 3, id = 4 },
            //     new PointId() { x = 5, y = -3, id = 5 },
            //};

            // PointId[] Arr = new PointId[] {

            // new PointId() { x = -4, y = 2, id = 0 },
            //     new PointId() { x = -3, y = 2, id = 1 }, 
            //     new PointId() { x = 3, y = 3, id = 2 },
            //     new PointId() { x = 3, y = -3, id = 3 }
            //};

            // PointId[] Arr = new PointId[] {

            //     new PointId() { x = 0, y = 0, id = 0 },
            //     new PointId() { x = 1, y = -1, id = 1 }, 
            //     new PointId() { x = 1, y = 3, id = 2 } 
            //};

            ClosestPointPair pointPair = new ClosestPointPair(Arr); 

            PointId[] TwoNearestPoints = pointPair.NearestPair();

            for (int i = 0; i < TwoNearestPoints.Length; i++)
            {
                Console.WriteLine("x = " + TwoNearestPoints[i].x + " y = " + TwoNearestPoints[i].y);
            }
                  
            Console.ReadLine();   
             
        }    
    }
}
 