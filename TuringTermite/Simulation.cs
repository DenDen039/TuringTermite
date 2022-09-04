using System;
using System.Windows.Forms;
using System.Collections.Generic;
namespace TuringTermite
{
    internal class Rule
    {
        public string end_state;
        public int new_color, direction;
        public Rule (string end_state, int new_color, int direction)
        {
            this.end_state = end_state;
            this.new_color = new_color;
            this.direction = direction;
        }
    }

    internal class Simulation
    {

        private int[,] directions = new int[4, 2] { { 0, -1 }, {-1, 0 }, { 0, 1 }, { 1, 0 } };

        public int previous_change_row=0, previous_change_col=0;
        private int width, height, termite_col, termite_row, cur_direction, generation, cellsSize;
        private string state;
        private bool rules_loaded;
        private int[,] grid;
        private Dictionary<(string, int), Rule> rules;

        public int CellsSize
        {
            get { return cellsSize; }
            set { if (value > 0) cellsSize = value; }
        }
        public int[,] Grid { get { return grid; } }
        public int Generation { get { return generation; } }
        public int Width { get { return width; } }
        public int Height { get { return height; } }
        public bool RulesLoaded { get { return rules_loaded; } }

        public Simulation(int picture_width, int picture_height, int cells_size)
        {
            this.rules_loaded = false;
            this.width = picture_width / cells_size;
            this.height = picture_height / cells_size;
            this.grid = new int[this.height, this.width];
            this.termite_row = (this.height) / 2;
            this.termite_col = (this.width) / 2;
            this.generation = 0;
            this.cellsSize = cells_size;
            this.cur_direction = 2;
            this.state = "A";

            for (int i = 0; i < this.height; i++)
            {
                for (int j = 0; j < this.width; j++)
                    this.grid[i, j] = 0;
            }

        }
        private void Turn(int direction)
        {
            this.cur_direction = (cur_direction + direction);
            if (this.cur_direction >= 4)
                this.cur_direction %= 4;
            else if (this.cur_direction < 0)
                this.cur_direction += 4;
        }
        public void NextGeneration()
        {
            generation++;
            var rule = rules[(state, grid[termite_row, termite_col])];
            if (rule == null)
                throw new Exception("Wrong rules");

            grid[termite_row, termite_col] = rule.new_color;
            previous_change_col = termite_col;
            previous_change_row = termite_row;
            state = rule.end_state;
            Turn(rule.direction);
            termite_row = (termite_row + directions[cur_direction, 0]) % height;
            if (termite_row < 0)
                termite_row = height - 1;
            termite_col = (termite_col + directions[cur_direction, 1]) % width;
            if (termite_col < 0)
                termite_col = width - 1;
        }

        public bool LoadRules(string rules)
        {
            if (rules.Length == 0 || rules.IndexOf('A') ==-1)
                return false;

            string[] rules_strings = rules.Split('\n');
            this.rules = new Dictionary<(string,int), Rule>();
            Char[] seps = new Char[2] { ' ', '\r' };

            try
            {
                foreach (string s in rules_strings)
                {
                    string[] options = s.Split(seps);

                    if (!int.TryParse(options[1], out _) || !int.TryParse(options[2], out _) || !int.TryParse(options[3], out _))
                        throw new Exception("Invalid args");
                    if (options[0].Length != 1 || options[4].Length != 1)
                        throw new Exception("Invalid args");
                    this.rules[(options[0], Int32.Parse(options[1]))] = new Rule(options[4], Int32.Parse(options[2]), Int32.Parse(options[3]));
                }
            }
            catch
            {
                return false;
            }

            this.rules_loaded = true;
            return this.rules_loaded;
        }


    }
}
