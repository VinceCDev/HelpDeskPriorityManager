using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace HelpDeskPriorityManager
{
    public partial class MainForm : Form
    {
        private SortedDictionary<int, Queue<HelpRequest>> helpRequests;

        public MainForm()
        {
            InitializeComponent();
            helpRequests = new SortedDictionary<int, Queue<HelpRequest>>();
            LoadHelpRequestsFromFile();
            DisplayHelpRequests();
        }

        private void LoadHelpRequestsFromFile()
        {
            string filePath = "C:\\Users\\DELL\\Documents\\HDPM.txt"; 
            List<string> lines = new List<string>();
            
            try
            {
                lines = File.ReadAllLines(filePath).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading file: " + ex.Message);
            }

            foreach (string line in lines)
            {
                string[] data = line.Split(',');
                if (data.Length == 3)
                {
                    int priority = int.Parse(data[0]);
                    string id = data[1];
                    TimeSpan time = TimeSpan.Parse(data[2]);
                    HelpRequest helpRequest = new HelpRequest(priority, id, time);

                    if (!helpRequests.ContainsKey(priority))
                    {
                        helpRequests[priority] = new Queue<HelpRequest>();
                    }
                    helpRequests[priority].Enqueue(helpRequest);
                }
            }
        }

        private void DisplayHelpRequests()
        {
            listBoxHelpRequests.Items.Clear();
            foreach (var priorityQueue in helpRequests.Values)
            {
                foreach (HelpRequest request in priorityQueue)
                {
                    listBoxHelpRequests.Items.Add(request.ToString());
                }
            }
        }

        private void SaveToFile()
        {
            string filePath = "C:\\Users\\DELL\\Documents\\HDPM.txt"; 
            List<string> linesToWrite = new List<string>();

            foreach (var priorityQueue in helpRequests.Values)
            {
                foreach (HelpRequest request in priorityQueue)
                {
                    linesToWrite.Add(request.Priority + "," + request.ID + "," + request.Time);
                }
            }

            try
            {
                File.WriteAllLines(filePath, linesToWrite);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error writing to file: " + ex.Message);
            }
        }

        private void BtnAddClick(object sender, EventArgs e)
		{
		    string id = textBox1.Text;
		    TimeSpan time = DateTime.Now.TimeOfDay; 

		    int priority = GeneratePriority();

		    time = TimeSpan.FromSeconds(Math.Floor(time.TotalSeconds));
		    
		    HelpRequest helpRequest = new HelpRequest(priority, id, time);
		    
		    if (!helpRequests.ContainsKey(priority))
		    {
		        helpRequests[priority] = new Queue<HelpRequest>();
		    }
		    
		    if (helpRequests.Values.Sum(queue => queue.Count) >= 5)
		    {
		        MessageBox.Show("Maximum request limit reached (5).");
		        return;
		    }
		    
		    helpRequests[priority].Enqueue(helpRequest);
		    
		    if (helpRequests.Values.Sum(queue => queue.Count) > 5)
		    {
		        var oldestPriority = helpRequests.Keys.Min();
		        helpRequests[oldestPriority].Dequeue();
		        if (helpRequests[oldestPriority].Count == 0)
		        {
		            helpRequests.Remove(oldestPriority);
		        }
		    }
		    
		    DisplayHelpRequests();
		    SaveToFile();
		}

        private int priorityCounter = 1; 

		private int GeneratePriority()
		{
		    int priority = priorityCounter;
		    priorityCounter = (priorityCounter % 5) + 1; 
		    return priority;
		}

        private void BtnRemoveClick(object sender, EventArgs e)
        {
		     if (helpRequests.Count > 0)
		   	{
		        var highestPriority = helpRequests.Keys.Min();
		        var removedRequest = helpRequests[highestPriority].Dequeue();
	
		    if (helpRequests[highestPriority].Count == 0)
		    {
		        helpRequests.Remove(highestPriority);
		    }
		
		        DisplayHelpRequests();
		        MessageBox.Show("Request removed: " + removedRequest); 
		        SaveToFile(); 
		    }
		    else
		    {
		        MessageBox.Show("No requests to remove."); 
		    }
		}
        
        private void Button1Click(object sender, EventArgs e)
        {
		     Start am = new Start();
			 am.Show();
			 this.Hide();
		}
    }

    public class HelpRequest
    {
        public int Priority { get; set; }
        public string ID { get; set; }
        public TimeSpan Time { get; set; }

        public HelpRequest(int priority, string id, TimeSpan time)
        {
            Priority = priority;
            ID = id;
            Time = time;
        }

        public override string ToString()
        {
            return "         " + Priority + "                            " + ID + "                         " + Time;
        }
    }
    
}

