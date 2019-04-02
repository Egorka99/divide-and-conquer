using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq; 
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ClassLibraryDaC; 

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";

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
            PointId[] arr = new PointId[5]; 

            Random rnd = new Random();
             
            int id = 0;  

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new PointId()  
                {
                    x = rnd.Next(-10, 10),    
                    y = rnd.Next(-10, 10),  
                    id = id
                }; 
                id++;

            }
             
            ClosestPointPair points = new ClosestPointPair(arr);

            PointId[] AnswerXY = points.NearestPair();

            for (int i = 0; i < arr.Length; i++) 
            {
                chartPoints.Series[0].Points.AddXY(arr[i].y, arr[i].x); 
                for (int j = 0; j < AnswerXY.Length; j++)
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

        PointId[] ConvertToPointId(string filename)
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

            return output.ToArray();    

        }  

        private void buttonFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
             
            string filename = openFileDialog1.FileName;
             
            PointId[] input = ConvertToPointId(filename);

            ClosestPointPair points = new ClosestPointPair(input); 

            PointId[] AnswerXY = points.NearestPair();
             
            textBoxF1point.Text = "(" + AnswerXY[0].x + "," + AnswerXY[0].y + ")";
            textBoxF2point.Text = "(" + AnswerXY[1].x + "," + AnswerXY[1].y + ")";
            textBoxFDist.Text = points.MinDistance().ToString();
            labelError.Text = filename; 

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
    }     
}   
   