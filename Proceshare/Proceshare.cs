using System;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections.Generic;

namespace Proceshare
{
    public partial class ProceshareForm : Form
    {

        BackgroundWorker backgroundWorker = new BackgroundWorker();

        public ProceshareForm()
        {
            InitializeComponent();
            InitializeBackgroundWorker();
            backgroundWorker.WorkerReportsProgress = true;
            backgroundWorker.WorkerSupportsCancellation = true;
        }

        private void InitializeBackgroundWorker()
        {
            backgroundWorker.DoWork += new DoWorkEventHandler(BackgroundWorker_DoWork);
        }

        private void ProceshareForm_Load(object sender, EventArgs e)
        {
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            (sender as Button).Enabled = false;
            if (backgroundWorker.IsBusy != true)
            {
                backgroundWorker.RunWorkerAsync();
            }
        }

        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            while (true)
            {
                Tuple<List<int>, string> Result = Calculator.Calculate();
                float RewardResult = ProcessDone.GetReward(Result);
                if (RewardResult > 0) {
                    TextBox.CheckForIllegalCrossThreadCalls = false;
                    this.LabelRewardCount.Text = "" + RewardResult;
                }
                if (worker.CancellationPending == true)
                {
                    e.Cancel = true;
                    break;
                }
            }
        }

        private void EndCalculate_Click(object sender, EventArgs e)
        {
            if (backgroundWorker.WorkerSupportsCancellation == true)
            {
                backgroundWorker.CancelAsync();
                this.calculate.Enabled = true;
            }
        }
    }
}
