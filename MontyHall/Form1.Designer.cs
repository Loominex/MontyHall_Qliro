namespace MontyHall
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Start = new System.Windows.Forms.Button();
            this.SimulationNoLbl = new System.Windows.Forms.Label();
            this.OpenCloseCb = new System.Windows.Forms.CheckBox();
            this.SimulationNumberBox = new System.Windows.Forms.NumericUpDown();
            this.resultBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.SimulationNumberBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(86, 131);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(119, 37);
            this.Start.TabIndex = 0;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // SimulationNoLbl
            // 
            this.SimulationNoLbl.AutoSize = true;
            this.SimulationNoLbl.Location = new System.Drawing.Point(94, 9);
            this.SimulationNoLbl.Name = "SimulationNoLbl";
            this.SimulationNoLbl.Size = new System.Drawing.Size(111, 15);
            this.SimulationNoLbl.TabIndex = 2;
            this.SimulationNoLbl.Text = "Simulation Number";
            // 
            // OpenCloseCb
            // 
            this.OpenCloseCb.AutoSize = true;
            this.OpenCloseCb.Location = new System.Drawing.Point(90, 79);
            this.OpenCloseCb.Name = "OpenCloseCb";
            this.OpenCloseCb.Size = new System.Drawing.Size(115, 19);
            this.OpenCloseCb.TabIndex = 3;
            this.OpenCloseCb.Text = "Change the door";
            this.OpenCloseCb.UseVisualStyleBackColor = true;
            this.OpenCloseCb.CheckedChanged += new System.EventHandler(this.OpenCloseCb_CheckedChanged);
            // 
            // SimulationNumberBox
            // 
            this.SimulationNumberBox.Location = new System.Drawing.Point(86, 37);
            this.SimulationNumberBox.Maximum = new decimal(new int[] {
            -1486618624,
            232830643,
            0,
            0});
            this.SimulationNumberBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SimulationNumberBox.Name = "SimulationNumberBox";
            this.SimulationNumberBox.Size = new System.Drawing.Size(123, 23);
            this.SimulationNumberBox.TabIndex = 4;
            this.SimulationNumberBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SimulationNumberBox.ValueChanged += new System.EventHandler(this.SimulationNumberBox_ValueChanged);
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(26, 202);
            this.resultBox.Name = "resultBox";
            this.resultBox.ReadOnly = true;
            this.resultBox.Size = new System.Drawing.Size(250, 225);
            this.resultBox.TabIndex = 5;
            this.resultBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 450);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.SimulationNumberBox);
            this.Controls.Add(this.OpenCloseCb);
            this.Controls.Add(this.SimulationNoLbl);
            this.Controls.Add(this.Start);
            this.Name = "Form1";
            this.Text = "MontyHall";
            ((System.ComponentModel.ISupportInitialize)(this.SimulationNumberBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Start;
        private Label SimulationNoLbl;
        private CheckBox OpenCloseCb;
        private NumericUpDown SimulationNumberBox;
        private RichTextBox resultBox;
    }
}