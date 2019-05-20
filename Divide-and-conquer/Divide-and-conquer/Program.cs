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


            //List<PointId> Arr = new List<PointId> {

            //     new PointId() { x = 0, y = -1, id = 1 },
            //     new PointId() { x = -3, y = 5, id = 2 },
            //     new PointId() { x = 1, y = 2, id = 3 },
            //     new PointId() { x = 4, y = -3, id = 4 },

            //};  


            //List<PointId> Arr = new List<PointId> {

            // new PointId() { x = -4, y = 2, id = 0 },
            //     new PointId() { x = -3, y = 2, id = 1 },
            //     new PointId() { x = 3, y = 3, id = 2 },
            //     new PointId() { x = 3, y = -3, id = 3 }
            //}; 

            List<PointId> Arr = new List<PointId> {

                 new PointId() { x = 1, y = -1, id = 0 },
                 new PointId() { x = -1, y = 3, id = 1 },
                 new PointId() { x = -6, y = 6, id = 2 },
                 new PointId() { x = 5, y = -6, id = 3 },
                 new PointId() { x = 0, y = 1, id = 4 },
            }; 
             
            ClosestPointPair pointPair = new ClosestPointPair(Arr);

            Console.WriteLine(pointPair.MinDistance());
                  
            Console.ReadLine();   
             
        }    
    } 
}
  