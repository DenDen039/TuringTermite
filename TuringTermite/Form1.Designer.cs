namespace TuringTermite
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Play_button = new System.Windows.Forms.Button();
            this.Stop_Button = new System.Windows.Forms.Button();
            this.Load_Button = new System.Windows.Forms.Button();
            this.Step_Button = new System.Windows.Forms.Button();
            this.SimulationBox = new System.Windows.Forms.PictureBox();
            this.Export_Button = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SimulationBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Play_button
            // 
            this.Play_button.Location = new System.Drawing.Point(36, 196);
            this.Play_button.Name = "Play_button";
            this.Play_button.Size = new System.Drawing.Size(127, 52);
            this.Play_button.TabIndex = 0;
            this.Play_button.Text = "Play";
            this.Play_button.UseVisualStyleBackColor = true;
            this.Play_button.Click += new System.EventHandler(this.Play_button_Click);
            // 
            // Stop_Button
            // 
            this.Stop_Button.Location = new System.Drawing.Point(36, 254);
            this.Stop_Button.Name = "Stop_Button";
            this.Stop_Button.Size = new System.Drawing.Size(127, 52);
            this.Stop_Button.TabIndex = 2;
            this.Stop_Button.Text = "Stop";
            this.Stop_Button.UseVisualStyleBackColor = true;
            this.Stop_Button.Click += new System.EventHandler(this.Stop_Button_Click);
            // 
            // Load_Button
            // 
            this.Load_Button.Location = new System.Drawing.Point(36, 370);
            this.Load_Button.Name = "Load_Button";
            this.Load_Button.Size = new System.Drawing.Size(127, 52);
            this.Load_Button.TabIndex = 3;
            this.Load_Button.Text = "Load Rules";
            this.Load_Button.UseVisualStyleBackColor = true;
            this.Load_Button.Click += new System.EventHandler(this.Load_Button_Click);
            // 
            // Step_Button
            // 
            this.Step_Button.Location = new System.Drawing.Point(36, 312);
            this.Step_Button.Name = "Step_Button";
            this.Step_Button.Size = new System.Drawing.Size(127, 52);
            this.Step_Button.TabIndex = 4;
            this.Step_Button.Text = "Go by 1000 steps";
            this.Step_Button.UseVisualStyleBackColor = true;
            this.Step_Button.Click += new System.EventHandler(this.Step_Button_Click);
            // 
            // SimulationBox
            // 
            this.SimulationBox.Location = new System.Drawing.Point(203, 34);
            this.SimulationBox.Margin = new System.Windows.Forms.Padding(5);
            this.SimulationBox.Name = "SimulationBox";
            this.SimulationBox.Size = new System.Drawing.Size(550, 550);
            this.SimulationBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.SimulationBox.TabIndex = 5;
            this.SimulationBox.TabStop = false;
            // 
            // Export_Button
            // 
            this.Export_Button.Location = new System.Drawing.Point(36, 428);
            this.Export_Button.Name = "Export_Button";
            this.Export_Button.Size = new System.Drawing.Size(127, 52);
            this.Export_Button.TabIndex = 6;
            this.Export_Button.Text = "Export Image";
            this.Export_Button.UseVisualStyleBackColor = true;
            this.Export_Button.Click += new System.EventHandler(this.Export_Button_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(30, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(30, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "Generation:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(843, 633);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Export_Button);
            this.Controls.Add(this.SimulationBox);
            this.Controls.Add(this.Step_Button);
            this.Controls.Add(this.Load_Button);
            this.Controls.Add(this.Stop_Button);
            this.Controls.Add(this.Play_button);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Termite simulation";
            ((System.ComponentModel.ISupportInitialize)(this.SimulationBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Play_button;
        private System.Windows.Forms.Button Stop_Button;
        private System.Windows.Forms.Button Load_Button;
        private System.Windows.Forms.Button Step_Button;
        private System.Windows.Forms.PictureBox SimulationBox;
        private System.Windows.Forms.Button Export_Button;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

