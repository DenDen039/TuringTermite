using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace TuringTermite
{
    public partial class Form1 : Form
    {
        private Simulation simulation;
        private int CellsSize = 2;
        private int StepSkip = 10000;
        public Form1()
        {
            InitializeComponent();
            this.Step_Button.Text = "Skip " + StepSkip.ToString() + " steps";

            this.simulation = new Simulation(this.SimulationBox.Size.Width, this.SimulationBox.Size.Height, CellsSize);
            this.simulation.NoRulesPresented+= new System.EventHandler(this.ErrorOfRules);
            DrawGrid();
        }
        private void ErrorOfRules(object sender, EventArgs e)
        {
            timer1.Stop();
            this.simulation = new Simulation(this.SimulationBox.Size.Width, this.SimulationBox.Size.Height, CellsSize);
            this.label1.Text = this.simulation.Generation.ToString();
            MessageBox.Show("There are no rules to continuer or simulation reached its end", "Error", MessageBoxButtons.OK);
        }

        private void Play_button_Click(object sender, EventArgs e)
        {
            if (!this.simulation.RulesLoaded)
            {
                MessageBox.Show("No rules for simulation loaded", "Info", MessageBoxButtons.OK);
                return;
            }
                
            if (timer1.Enabled)
                return;
            timer1.Start();
        }
        private Image DrawGrid()
        {
            this.SimulationBox.Image = new Bitmap(SimulationBox.Width, SimulationBox.Height);
            Graphics g = Graphics.FromImage(SimulationBox.Image);
            Pen p;
            SolidBrush brush;
            int[,] grid = this.simulation.Grid;
            

            for (int i = 0; i < this.simulation.Height; i++)
            {
                for (int j = 0; j < this.simulation.Width; j++)
                {
                    p = new Pen(Color.FromArgb((grid[i,j]*986895)-16777216));
                    brush = new SolidBrush(Color.FromArgb((grid[i, j] * 986895) - 16777216));
                    Rectangle rect = new Rectangle(i * this.simulation.CellsSize, j * this.simulation.CellsSize, simulation.CellsSize, simulation.CellsSize);
                    g.FillRectangle(brush, rect);
                    g.DrawRectangle(p, rect);
                }
            }
            return this.SimulationBox.Image;
        }

        private void Stop_Button_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
                return;
            timer1.Stop();
        }

        private void Load_Button_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
                return;
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                        fileContent = reader.ReadToEnd();
                }
                bool err = this.simulation.LoadRules(fileContent);
                if (filePath.Length == 0)
                    return;
                if (!err){
                    MessageBox.Show("Could not load rules", "Error", MessageBoxButtons.OK);
                }
                else
                {
                    this.simulation = new Simulation(this.SimulationBox.Size.Width, this.SimulationBox.Size.Height, CellsSize);
                    this.simulation.NoRulesPresented += new System.EventHandler(this.ErrorOfRules);
                    this.simulation.LoadRules(fileContent);
                }

            }

            

        }

        private void Step_Button_Click(object sender, EventArgs e)
        {
            if (!this.simulation.RulesLoaded)
            {
                MessageBox.Show("No rules for simulation loaded", "Info", MessageBoxButtons.OK);
                return;
            }
            for (int i = 0; i < StepSkip; i++)
            {
                this.simulation.NextGeneration();
            }
            this.label1.Text = this.simulation.Generation.ToString();
            this.DrawGrid();
        }

        private void Export_Button_Click(object sender, EventArgs e)
        {
            bool check = timer1.Enabled;
            timer1.Stop();

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "Images |*.jpg|*.bmp|*.jpeg";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.FileName = this.simulation.Generation.ToString()+"_generation";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK) DrawGrid().Save(saveFileDialog1.FileName, ImageFormat.Bmp);
            if (check) timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.simulation.NextGeneration();
            this.label1.Text = this.simulation.Generation.ToString();
            DrawGrid();
        }
    }
}
