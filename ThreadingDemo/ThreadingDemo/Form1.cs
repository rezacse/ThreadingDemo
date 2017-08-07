using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadingDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private int ProcessingSomething()
        {
            Thread.Sleep(5000);
            return 1;
        }
        
        private void Starthread_OnClick(object sender, EventArgs e)
        {
            StartThreadButton.Enabled = false;
            var thread = new Thread(() =>
            {
                var count = ProcessingSomething();
                var action = new Action<int>(PrintResult);
                this.BeginInvoke(action, count);
            });

            thread.Start();
            ThreadResultLabel.Text = "Processing thread...";
        }

        private void PrintResult(int result)
        {
            ThreadResultLabel.Text = "Thread Result : " + result;
            StartThreadButton.Enabled = true;
        }
        
        private async void StartTask_OnClick(object sender, EventArgs e)
        {
            TaskStartButton.Enabled = false;
            var task  = new Task<int>(ProcessingSomething);
            task.Start();

            TaskResultLabel.Text = "Processing anync task...";

            var count = await task;

            TaskResultLabel.Text = "Task Result: " + count;
            TaskStartButton.Enabled = true;
        }
        
    }
}
