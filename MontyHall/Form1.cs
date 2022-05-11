using MontyHall.Game;

namespace MontyHall
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Start_Click(object sender, EventArgs e)
        {
            resultBox.Text = String.Empty;
            var monty = new MontyGame();
            ChangeControlsStates(false);
            var result = Task.Factory.StartNew(() => monty.Run(this.SimulationNumberBox.Value, this.OpenCloseCb.Checked));
            await result;
            ChangeControlsStates(true);
            var reportTxt = ReportGenerator.MontyReport(result.Result.TrueGuess, result.Result.WrongGuess, SimulationNumberBox.Value);
            resultBox.Text = reportTxt;
        }

        private void OpenCloseCb_CheckedChanged(object sender, EventArgs e)
        {
            resultBox.Text = String.Empty;
        }

        private void SimulationNumberBox_ValueChanged(object sender, EventArgs e)
        {
            resultBox.Text = String.Empty;
        }
        private void ChangeControlsStates(bool enabled)
        {
            this.OpenCloseCb.Enabled = enabled;
            this.SimulationNumberBox.Enabled = enabled;
            this.Start.Enabled = enabled;
        }
    }
}