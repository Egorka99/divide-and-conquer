using ClassLibraryDaC;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
             
        } 

        private void Form1_Load(object sender, EventArgs e)
        {
            panelG.Show();
            panelF.Hide(); 
        }  

        int[] GenerateArray(int Length)  
        {
            int[] array = new int[Length];  
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++) 
                array[i] = rand.Next(); // [0 - 2^31)

            return array;   
        }
         
        void ChartOut()
        {
            List<PointId> arr = new List<PointId>(); 

            Random rnd = new Random(); 
             
            int id = 0;  

            for (int i = 0; i < 5; i++)
            {  
                arr.Add(new PointId()  
                {
                    x = rnd.Next(-10, 10),    
                    y = rnd.Next(-10, 10),  
                    id = id
                });   
                id++;

            }
             
            ClosestPointPair points = new ClosestPointPair(arr);

            List<PointId> AnswerXY = points.NearestPair(); 
             
            for (int i = 0; i < arr.Count; i++)   
            {
                chartPoints.Series[0].Points.AddXY(arr[i].y, arr[i].x); 
                for (int j = 0; j < AnswerXY.Count; j++)
                {
                    if (arr[i].x == AnswerXY[j].x && arr[i].y == AnswerXY[j].y)
                        chartPoints.Series[0].Points[i].Color = Color.Red;
                }     
            } 
             
            textBoxG1point.Text = "(" + AnswerXY[0].x + "," + AnswerXY[0].y + ")";
            textBoxG2point.Text = "(" + AnswerXY[1].x + "," + AnswerXY[1].y + ")";
            textBoxGDist.Text = points.MinDistance().ToString(); 

             
        }  
         
        string GetSortTime(int CountElements)
        { 
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start(); 

            MergeSort.Sort(GenerateArray(CountElements)); 

            stopwatch.Stop();

            long Time = stopwatch.ElapsedMilliseconds; 

            chartSort.Series[0].Points.AddXY(Time, CountElements); 
             
            return Time + "ms";   
        }

        string GetDQ_CPPTime(int CountCalculation,ClosestPointPair input)
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
             
            for (int i = 0; i < CountCalculation; i++)
            {
                input.MinDistance(); 
            }
              
            stopwatch.Stop();

            long Time = stopwatch.ElapsedMilliseconds; 

            return Time + "ms";
        }

        string GetSimple_CPPTime(int CountCalculation, ClosestPointPair input)
        {
            Stopwatch stopwatch = new Stopwatch();
             
            stopwatch.Start();  

            for (int i = 0; i < CountCalculation; i++)
            {
                input.SimpleMinDistance();   
            }

            stopwatch.Stop();

            long Time = stopwatch.ElapsedMilliseconds;

            return Time + "ms";
        }

        List<PointId> ConvertToPointId(string filename)
        {
            List<PointId> output = new List<PointId>(); 

            int FileLength = File.ReadAllLines(filename).Length; 

            StreamReader sr = new StreamReader(filename);

            int id = 0;  

            for (int i = 0; i < FileLength; i++)
            {
                string[] buffer = sr.ReadLine().Split(' ');

                output.Add(new PointId
                {
                    x = int.Parse(buffer[0]),
                    y = int.Parse(buffer[1]),
                    id = id
                });

                id++;
            } 

            sr.Close();   
           

            return output;    
              
        }  
          
        bool HasSamePoints(List<PointId> arr)
        {
            for (int i = 0; i < arr.Count; i++)
            {
                for (int j = 0; j < arr.Count; j++)
                {
                    if (arr[i].id != arr[j].id)
                        if (arr[i].x == arr[j].x && arr[i].y == arr[j].y)
                            return true;  
                }
            }
             
            return false;  
        } 
         
        

        private void buttonFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
             
            string filename = openFileDialog1.FileName;

            try 
            {
                List<PointId> input = ConvertToPointId(filename);

                ClosestPointPair points = new ClosestPointPair(input);    

                List<PointId> AnswerXY = points.NearestPair();

                if (HasSamePoints(input))
                    throw new Exception("В файле содержатся одинаковые точки "); 

                textBoxF1point.Text = "(" + AnswerXY[0].x + "," + AnswerXY[0].y + ")";
                textBoxF2point.Text = "(" + AnswerXY[1].x + "," + AnswerXY[1].y + ")";
                textBoxFDist.Text = points.SimpleMinDistance().ToString();
                labelError.Text = filename; 
                  
                //Подсчет времени  
                labelCPP1_Time1.Text = GetSimple_CPPTime(10000,points); 
                labelCPP1_Time2.Text = GetSimple_CPPTime(15000,points);   
                labelCPP1_Time3.Text = GetSimple_CPPTime(20000,points); 
                labelCPP1_Time4.Text = GetSimple_CPPTime(25000,points);
                 
                labelCPP2_Time1.Text = GetDQ_CPPTime(10000, points);
                labelCPP2_Time2.Text = GetDQ_CPPTime(15000, points);
                labelCPP2_Time3.Text = GetDQ_CPPTime(20000, points);
                labelCPP2_Time4.Text = GetDQ_CPPTime(25000, points);
                 

            } 
            catch (IndexOutOfRangeException)  
            { 
                labelError.Text = "Файл содержит неверные данные";
                labelError.ForeColor = Color.Red;
            }
            catch (Exception ex)    
            {  
                labelError.Text = ex.Message;
                labelError.ForeColor = Color.Red; 
            }
            
        } 



        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            chartSort.Series[0].Points.Clear(); 

            labelTime1.Text = GetSortTime(10000);
            labelTime2.Text = GetSortTime(15000);  
            labelTime3.Text = GetSortTime(20000);
            label1Time4.Text = GetSortTime(25000);

   
        } 

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            chartPoints.Series[0].Points.Clear();

            ChartOut();  
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            panelG.Visible = true;
            panelF.Visible = false;  
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            panelG.Visible = false;
            panelF.Visible = true;
        }

    }         
}   
   