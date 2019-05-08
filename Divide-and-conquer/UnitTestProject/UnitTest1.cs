using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryDaC;
using System.Collections.Generic; 

namespace UnitTestProject
{
    [TestClass]
    public class Distance  
    {
        [TestMethod]
        public void TestMethod1()  
        {

            List<PointId> Arr = new List<PointId> {

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

            List<PointId> Arr = new List<PointId> {

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

            List<PointId> Arr = new List<PointId> {

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

        [TestMethod]
        public void TestMethod4()
        { 

            List<PointId> Arr = new List<PointId> {

                 new PointId() { x = -3, y = -10, id = 0 },
                 new PointId() { x = -7, y = 4, id = 1 },
                 new PointId() { x = 6, y = 8, id = 2 },
                 new PointId() { x = -5, y = 5, id = 3 },
                 new PointId() { x = -8, y = -7, id = 4 }, 

            };

            ClosestPointPair points = new ClosestPointPair(Arr);

            double MinDist = points.MinDistance();

            Assert.AreEqual(2.263, MinDist);
        }

        [TestMethod]
        public void TestMethod5() 
        {

            List<PointId> Arr = new List<PointId> {

                 new PointId() { x = 2, y = 3, id = 0 },
                 new PointId() { x = 2, y = 2, id = 1 },
                 new PointId() { x = -3, y = 3, id = 2 },
                 new PointId() { x = 7, y = 1, id = 3 },  
                 new PointId() { x = 3, y = 3, id = 4 },

            };

            ClosestPointPair points = new ClosestPointPair(Arr);

            double MinDist = points.MinDistance();

            Assert.AreEqual(1, MinDist);
        }

        [TestMethod]
        public void TestMethod6()
        {

            List<PointId> Arr = new List<PointId>() {

                 new PointId() { x = 0, y = 0, id = 0 },
                 new PointId() { x = 0, y = 2, id = 1 },
                 new PointId() { x = 0, y = 3, id = 2 },
                 new PointId() { x = 0, y = 4, id = 3 },  

            };

            ClosestPointPair points = new ClosestPointPair(Arr);
             
            double MinDist = points.MinDistance();

            Assert.AreEqual(1, MinDist);
        } 
         
        [TestMethod] 
        public void TestMethod7()
        {

            List<PointId> Arr = new List<PointId> {

                 new PointId() { x = 1, y = -1, id = 0 },
                 new PointId() { x = -1, y = 3, id = 1 }, 
                 new PointId() { x = -6, y = 6, id = 2 },
                 new PointId() { x = 5, y = -6, id = 3 },
                 new PointId() { x = 0, y = 1, id = 4 },

            }; 

            ClosestPointPair points = new ClosestPointPair(Arr);

            double MinDist = points.MinDistance();
             
            Assert.AreEqual(2.236, MinDist); 
        }

        [TestMethod]
        public void TestMethod8()   
        { 
              
            List<PointId> Arr = new List<PointId> { 

                 new PointId() { x = 0, y = -1, id = 1 },
                 new PointId() { x = -3, y = 5, id = 2 },
                 new PointId() { x = 1, y = 2, id = 3 },
                 new PointId() { x = 4, y = -3, id = 4 },

            }; 

            ClosestPointPair points = new ClosestPointPair(Arr);

            double MinDist = points.MinDistance();
             
            Assert.AreEqual(3.162, MinDist);
        }
          
        [TestMethod]
        public void TestMethod9()
        {

            List<PointId> Arr = new List<PointId> {

                 new PointId() { x = 0, y = 1, id = 0 },
                 new PointId() { x = 0, y = 2, id = 1 },
                 new PointId() { x = -1, y = 2, id = 2 },
                 new PointId() { x = 1, y = 2, id = 3 },

            };

            ClosestPointPair points = new ClosestPointPair(Arr);

            double MinDist = points.MinDistance();

            Assert.AreEqual(1, MinDist);
        }

        [TestMethod]
        public void TestMethod10() 
        {
              
            List<PointId> Arr = new List<PointId> {

                 new PointId() { x = 0, y = 3, id = 0 },
                 new PointId() { x = 1, y = 2, id = 1 },
                 new PointId() { x = -3, y = 6, id = 2 },
                 new PointId() { x = 4, y = 0, id = 3 },

            };

            ClosestPointPair points = new ClosestPointPair(Arr);

            double MinDist = points.MinDistance();

            Assert.AreEqual(1.414, MinDist);
        }




    }
}     
 