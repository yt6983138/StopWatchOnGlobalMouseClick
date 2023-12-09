using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StopWatchOnGlobalMouseClick
{
    public partial class Form1 : Form
    {
        private volatile bool DetectingStarted = false;
        private volatile Stopwatch MyStopwatch;
        private Thread worker;
        public Form1()
        {
            MyStopwatch = new Stopwatch();
            InitializeComponent();
            worker = new Thread(new ThreadStart(CheckMouseDownAllTheTime));
            worker.Start();
        }


        private void StartOrStop_Click(object sender, EventArgs e)
        {
            this.DetectingStarted = !DetectingStarted;
            if (this.DetectingStarted)
            { // stop
                StartOrStopDetecting.Text = "Stop Detect";
                Thread.Sleep(50);
                lock (this.MyStopwatch)
                {
                    this.MyStopwatch.Stop();
                }
            }
            else
            { // start
                StartOrStopDetecting.Text = "Start Detect";
            }
        }
        private void CheckMouseDownAllTheTime()
        {
            Thread.Sleep(500);
            while (true)
            {
                Thread.Sleep(20);
                //Console.WriteLine(GetAsyncKeyState(0x01));
                if (!this.DetectingStarted)
                {
                    lock (this.MyStopwatch)
                    {
                        this.MyStopwatch.Stop();
                    }
                }
                if (this.DetectingStarted && GetAsyncKeyState(0x01) == -32767)
                {
                    lock (this.MyStopwatch)
                    {
                        if (this.MyStopwatch.IsRunning)
                        {
                            this.MyStopwatch.Stop();
                        }
                        else
                        {
                            this.MyStopwatch.Start();
                        }
                    }
                }
                this.TimeTextBox.Invoke((MethodInvoker)delegate
                {
                    this.TimeTextBox.Text = this.MyStopwatch.Elapsed.ToString("c");
                });
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            lock (this.MyStopwatch)
            {
                this.MyStopwatch.Reset();
            }
        }
        [DllImport("user32.dll")]
        private static extern short GetAsyncKeyState(int VirtualKeyPressed);

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.worker.Abort();
        }
    }
}
