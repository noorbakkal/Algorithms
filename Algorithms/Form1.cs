using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

namespace Algorithms
{
    public partial class Form1 : Form
    {
        private int Max { get; set; }
        private int Min { get; set; }
        private string alg1 { get; set; }
        private string alg2 { get; set; }
        private double time { get; set; }
        private List<int> arrayToSort { get; set; }
        private List<int> result1 { get; set; }
        private List<int> result2 { get; set; }

        public Form1()
        {
            InitializeComponent();
            foreach (var alg in Tools.ShowMethodNames())
            {
                this.AlgorithmListBox1.Items.Add(alg);
            }

        }

        private void Start_Click(object sender, EventArgs e)
        {
            getAllInformation();            
            pushAllInformation();
                       
        }
        
        private void getAllInformation() 
        {
           
            Max = Convert.ToInt32(textBox1.Text);
            Min = Convert.ToInt32(textBox2.Text);

            arrayToSort = Tools.CreateRandomNumbers(Max, Min);    
            int counter = 0;
            alg1 = "";
            alg2 = "";
            foreach (string item in AlgorithmListBox1.CheckedItems)
            {                 
                if(counter == 0) alg1 = item;
                if (counter == 1) alg2 = item;
                counter++;
            }

            if (counter > 0 && counter == 2)
            {
            }
            else
            {
                throw new ArgumentNullException("counter", "please pick two");
            }
        }

        private void pushAllInformation()
        {
            RandomResult.Items.Clear();
            for (int i = 0; i < arrayToSort.Count; i++)
            {
                RandomResult.Items.Add(arrayToSort[i]);
            }
            
            SortAlgorithms sortAlgorithms = new SortAlgorithms(arrayToSort, 5);
            SortAlgorithms sortAlgorithms2 = new SortAlgorithms(arrayToSort, 5);
            time = spBar.Value;
            ThreadStart ts = delegate ()
            {
                try
                {
                    SortAlgorithmList1.Items.Clear();
                    AlgorithmTime1.Text = "";
                    var stopWatch1 = Stopwatch.StartNew();
                    List<string> algorithmsMethods1 = new List<string>();
                    algorithmsMethods1 = Tools.ShowMethodNames();
                    // replace switch statment with this for loop
                    foreach (string item in algorithmsMethods1)
                    {
                        if (alg1 == item)
                        {
                            MethodInfo method = typeof(SortAlgorithms).GetMethod(item);
                            String[] param = method.GetParameters()
                              .Select(p => String.Format("{0} {1}", p.ParameterType.Name, p.Name))
                              .ToArray();
                            if (param.Length > 1)
                            {
                                result1 = (List<int>)method.Invoke(sortAlgorithms, new object[] { arrayToSort,0 , arrayToSort.Count - 1 });
                            }
                            else result1 = (List<int>)method.Invoke(sortAlgorithms, new object[] { arrayToSort });

                            for (int x = 0; x < result1.Count; x++)
                            {
                                System.Threading.Thread.Sleep(TimeSpan.FromMilliseconds(time));
                                SortAlgorithmList1.Items.Add(result1[x]);
                                Thread.Yield();
                            }
                        }
                    }                 
                    stopWatch1.Stop();                    
                    AlgorithmTime1.Text += stopWatch1.ElapsedMilliseconds - (time * (arrayToSort.Count - 1)) - time;
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            };
            ThreadStart ts2 = delegate ()
            {
               
                try
                {
                    SortAlgorithmList2.Items.Clear();
                    AlgorithmTime2.Text = "";
                    var stopWatch2 = Stopwatch.StartNew();
                    List<string> algorithmsMethods2 = new List<string>();
                    algorithmsMethods2 = Tools.ShowMethodNames();
                    // replace switch statment with this for loop
                    foreach (string item in algorithmsMethods2)
                    {
                        if (alg2 == item)
                        {
                            MethodInfo method = typeof(SortAlgorithms).GetMethod(item);
                            String[] param = method.GetParameters()
                              .Select(p => String.Format("{0} {1}", p.ParameterType.Name, p.Name))
                              .ToArray();
                            if (param.Length > 1)
                            {
                                result2 = (List<int>)method.Invoke(sortAlgorithms, new object[] { arrayToSort, 0, arrayToSort.Count - 1 });
                            }
                            else result2 = (List<int>)method.Invoke(sortAlgorithms, new object[] { arrayToSort });

                            for (int x = 0; x < result2.Count; x++)
                            {
                                System.Threading.Thread.Sleep(TimeSpan.FromMilliseconds(time));
                                SortAlgorithmList2.Items.Add(result2[x]); 
                                Thread.Yield();
                            }
                        }
                    }
                    stopWatch2.Stop();
                    AlgorithmTime2.Text += stopWatch2.ElapsedMilliseconds - (time * (arrayToSort.Count - 1)) - time; 
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            };

           
                Thread t = new Thread(ts);
                t.Start();
          
                Thread t2 = new Thread(ts2);
                t2.Start();
             

        }
        private void clearAllFields()
        {
            if (textBox1.Text != "Min") textBox1.Clear();
            if (textBox2.Text != "Min") textBox2.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AlgorithmListBox1_SelectedIndexChanged(object sender, ItemCheckEventArgs e)
        {
          

            if (e.NewValue == CheckState.Checked)
                for (int ix = 0; ix < AlgorithmListBox1.Items.Count; ++ix)
                {
                    if (e.Index != ix) AlgorithmListBox1.SetItemChecked(ix, false);
                }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {

        }
    }


    
 }
