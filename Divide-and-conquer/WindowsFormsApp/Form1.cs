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

            if (HasSamePoints(arr))
                ;
             
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
          
        bool HasSamePoints(PointId[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
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
                PointId[] input = ConvertToPointId(filename);

                ClosestPointPair points = new ClosestPointPair(input); 

                PointId[] AnswerXY = points.NearestPair();

                if (HasSamePoints(input))
                    throw new Exception("В файле содержатся одинаковые точки "); 

                textBoxF1point.Text = "(" + AnswerXY[0].x + "," + AnswerXY[0].y + ")";
                textBoxF2point.Text = "(" + AnswerXY[1].x + "," + AnswerXY[1].y + ")";
                textBoxFDist.Text = points.MinDistance().ToString();
                labelError.Text = filename; 
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
            if (radioButton1.Checked)
            {
                chartPoints.Visible = true; 
                groupBox1.Visible = true;
                groupBox2.Visible = false;
            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            { 
                groupBox2.Visible = true;
                chartPoints.Visible = false;
                groupBox1.Visible = false;
            }
        }
    }      
}   
   