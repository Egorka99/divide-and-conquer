using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryDaC; 

namespace UnitTestProject
{
    [TestClass]
    public class Distance  
    {
        [TestMethod]
        public void TestMethod1()  
        {

            PointId[] Arr = new PointId[] {

                 new PointId() { x = -4, y = 3, id = 0 },
                 new PointId() { x = -4, y = -3, id = 1 },
                 new PointId() { x = 0, y = 0, id = 2 },
                 new PointId() { x = 1, y = -1, id = 3 },
                 new PointId() { x = 1, y = 3, id = 4 },
                 new PointId() { x = 5, y = -3, id = 5 },
            };
             
            ClosestPointPair points = new ClosestPointPair(Arr);

            double MinDist = points.MinDistance(); 
             
            Assert.AreEqual(1.414, MinDist);  
        }

        [TestMethod]
        public void TestMethod2()
        {

            PointId[] Arr = new PointId[] {

                 new PointId() { x = -4, y = 3, id = 0 },
                 new PointId() { x = -4, y = -3, id = 1 },
                 new PointId() { x = 0, y = 0, id = 2 },
                 new PointId() { x = 1, y = -1, id = 3 },
                 new PointId() { x = 1, y = 3, id = 4 },
                 new PointId() { x = 5, y = -3, id = 5 },
            };

            ClosestPointPair points = new ClosestPointPair(Arr);

            double MinDist = points.MinDistance();

            Assert.AreEqual(1.414, MinDist);
        }

        [TestMethod]
        public void TestMethod3()
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
                 new PointId() { x = 0, y = 4, id = 8 }, 
 
            };

            ClosestPointPair points = new ClosestPointPair(Arr);

            double MinDist = points.MinDistance();

            Assert.AreEqual(1, MinDist); 
        }


    }
}     
