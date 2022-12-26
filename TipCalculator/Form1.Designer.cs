namespace TipCalculator
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
            this.Dashboard = new System.Windows.Forms.Panel();
            this.PeopleCountError = new System.Windows.Forms.Label();
            this.TipError = new System.Windows.Forms.Label();
            this.BillError = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.Total_Output = new System.Windows.Forms.Label();
            this.PeopleCount_Input = new System.Windows.Forms.NumericUpDown();
            this.Tip_Output = new System.Windows.Forms.Label();
            this.PerPersonLabel2 = new System.Windows.Forms.Label();
            this.TipLabel = new System.Windows.Forms.Label();
            this.PeopleCountLabel = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.Tip_Input = new System.Windows.Forms.NumericUpDown();
            this.PerPersonLabel1 = new System.Windows.Forms.Label();
            this.TipPercentLabel = new System.Windows.Forms.Label();
            this.Bill_Input = new System.Windows.Forms.TextBox();
            this.BillLabel = new System.Windows.Forms.Label();
            this.Error1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Error2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Error3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Dashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PeopleCount_Input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tip_Input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error3)).BeginInit();
            this.SuspendLayout();
            // 
            // Dashboard
            // 
            this.Dashboard.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Dashboard.Controls.Add(this.PeopleCountError);
            this.Dashboard.Controls.Add(this.TipError);
            this.Dashboard.Controls.Add(this.BillError);
            this.Dashboard.Controls.Add(this.CalculateButton);
            this.Dashboard.Controls.Add(this.Total_Output);
            this.Dashboard.Controls.Add(this.PeopleCount_Input);
            this.Dashboard.Controls.Add(this.Tip_Output);
            this.Dashboard.Controls.Add(this.PerPersonLabel2);
            this.Dashboard.Controls.Add(this.TipLabel);
            this.Dashboard.Controls.Add(this.PeopleCountLabel);
            this.Dashboard.Controls.Add(this.TotalLabel);
            this.Dashboard.Controls.Add(this.Tip_Input);
            this.Dashboard.Controls.Add(this.PerPersonLabel1);
            this.Dashboard.Controls.Add(this.TipPercentLabel);
            this.Dashboard.Controls.Add(this.Bill_Input);
            this.Dashboard.Controls.Add(this.BillLabel);
            this.Dashboard.Dock = System.Windows.Forms.DockStyle.Right;
            this.Dashboard.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dashboard.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Dashboard.Location = new System.Drawing.Point(474, 0);
            this.Dashboard.Margin = new System.Windows.Forms.Padding(0);
            this.Dashboard.Name = "Dashboard";
            this.Dashboard.Padding = new System.Windows.Forms.Padding(1);
            this.Dashboard.Size = new System.Drawing.Size(308, 403);
            this.Dashboard.TabIndex = 0;
            // 
            // PeopleCountError
            // 
            this.PeopleCountError.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PeopleCountError.ForeColor = System.Drawing.Color.Red;
            this.PeopleCountError.Location = new System.Drawing.Point(26, 248);
            this.PeopleCountError.Name = "PeopleCountError";
            this.PeopleCountError.Size = new System.Drawing.Size(257, 16);
            this.PeopleCountError.TabIndex = 16;
            this.PeopleCountError.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TipError
            // 
            this.TipError.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TipError.ForeColor = System.Drawing.Color.Red;
            this.TipError.Location = new System.Drawing.Point(26, 161);
            this.TipError.Name = "TipError";
            this.TipError.Size = new System.Drawing.Size(257, 16);
            this.TipError.TabIndex = 15;
            this.TipError.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BillError
            // 
            this.BillError.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillError.ForeColor = System.Drawing.Color.Red;
            this.BillError.Location = new System.Drawing.Point(26, 76);
            this.BillError.Name = "BillError";
            this.BillError.Size = new System.Drawing.Size(257, 16);
            this.BillError.TabIndex = 14;
            this.BillError.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateButton.Location = new System.Drawing.Point(101, 267);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(96, 38);
            this.CalculateButton.TabIndex = 13;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // Total_Output
            // 
            this.Total_Output.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Total_Output.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_Output.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Total_Output.Location = new System.Drawing.Point(85, 358);
            this.Total_Output.Name = "Total_Output";
            this.Total_Output.Size = new System.Drawing.Size(209, 36);
            this.Total_Output.TabIndex = 12;
            this.Total_Output.Text = "$";
            this.Total_Output.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PeopleCount_Input
            // 
            this.PeopleCount_Input.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PeopleCount_Input.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PeopleCount_Input.Location = new System.Drawing.Point(26, 219);
            this.PeopleCount_Input.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.PeopleCount_Input.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PeopleCount_Input.Name = "PeopleCount_Input";
            this.PeopleCount_Input.Size = new System.Drawing.Size(268, 27);
            this.PeopleCount_Input.TabIndex = 6;
            this.PeopleCount_Input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PeopleCount_Input.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PeopleCount_Input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PeopleCount_Input_KeyDown);
            this.PeopleCount_Input.Leave += new System.EventHandler(this.PeopleCount_Input_Leave);
            // 
            // Tip_Output
            // 
            this.Tip_Output.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tip_Output.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tip_Output.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Tip_Output.Location = new System.Drawing.Point(81, 308);
            this.Tip_Output.Name = "Tip_Output";
            this.Tip_Output.Size = new System.Drawing.Size(213, 31);
            this.Tip_Output.TabIndex = 11;
            this.Tip_Output.Text = "$";
            this.Tip_Output.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PerPersonLabel2
            // 
            this.PerPersonLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PerPersonLabel2.AutoSize = true;
            this.PerPersonLabel2.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PerPersonLabel2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PerPersonLabel2.Location = new System.Drawing.Point(24, 382);
            this.PerPersonLabel2.Name = "PerPersonLabel2";
            this.PerPersonLabel2.Size = new System.Drawing.Size(58, 12);
            this.PerPersonLabel2.TabIndex = 10;
            this.PerPersonLabel2.Text = "per person";
            
            // 
            // TipLabel
            // 
            this.TipLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TipLabel.AutoSize = true;
            this.TipLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TipLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TipLabel.Location = new System.Drawing.Point(22, 308);
            this.TipLabel.Name = "TipLabel";
            this.TipLabel.Size = new System.Drawing.Size(33, 19);
            this.TipLabel.TabIndex = 7;
            this.TipLabel.Text = "Tip";
            
            // 
            // PeopleCountLabel
            // 
            this.PeopleCountLabel.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PeopleCountLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PeopleCountLabel.Location = new System.Drawing.Point(23, 182);
            this.PeopleCountLabel.Name = "PeopleCountLabel";
            this.PeopleCountLabel.Size = new System.Drawing.Size(278, 23);
            this.PeopleCountLabel.TabIndex = 5;
            this.PeopleCountLabel.Text = "No. of people";
            
            // 
            // TotalLabel
            // 
            this.TotalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TotalLabel.Location = new System.Drawing.Point(22, 358);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(57, 24);
            this.TotalLabel.TabIndex = 9;
            this.TotalLabel.Text = "Total";
          
            // 
            // Tip_Input
            // 
            this.Tip_Input.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tip_Input.DecimalPlaces = 2;
            this.Tip_Input.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tip_Input.Location = new System.Drawing.Point(26, 131);
            this.Tip_Input.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.Tip_Input.Name = "Tip_Input";
            this.Tip_Input.Size = new System.Drawing.Size(268, 27);
            this.Tip_Input.TabIndex = 4;
            this.Tip_Input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Tip_Input.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Tip_Input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Tip_Input_KeyDown);
            this.Tip_Input.Leave += new System.EventHandler(this.Tip_Input_Leave);
            // 
            // PerPersonLabel1
            // 
            this.PerPersonLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PerPersonLabel1.AutoSize = true;
            this.PerPersonLabel1.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PerPersonLabel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PerPersonLabel1.Location = new System.Drawing.Point(24, 327);
            this.PerPersonLabel1.Name = "PerPersonLabel1";
            this.PerPersonLabel1.Size = new System.Drawing.Size(58, 12);
            this.PerPersonLabel1.TabIndex = 8;
            this.PerPersonLabel1.Text = "per person";
            
            // 
            // TipPercentLabel
            // 
            this.TipPercentLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TipPercentLabel.AutoSize = true;
            this.TipPercentLabel.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TipPercentLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TipPercentLabel.Location = new System.Drawing.Point(23, 95);
            this.TipPercentLabel.Name = "TipPercentLabel";
            this.TipPercentLabel.Size = new System.Drawing.Size(42, 16);
            this.TipPercentLabel.TabIndex = 2;
            this.TipPercentLabel.Text = "Tip %";
            
            // 
            // Bill_Input
            // 
            this.Bill_Input.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Bill_Input.BackColor = System.Drawing.SystemColors.Window;
            this.Bill_Input.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bill_Input.Location = new System.Drawing.Point(26, 46);
            this.Bill_Input.Name = "Bill_Input";
            this.Bill_Input.Size = new System.Drawing.Size(268, 27);
            this.Bill_Input.TabIndex = 1;
            this.Bill_Input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Bill_Input.TextChanged += new System.EventHandler(this.Bill_Input_TextChanged);
            this.Bill_Input.Leave += new System.EventHandler(this.Bill_Input_Leave);
            // 
            // BillLabel
            // 
            this.BillLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BillLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BillLabel.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BillLabel.Location = new System.Drawing.Point(23, 19);
            this.BillLabel.Margin = new System.Windows.Forms.Padding(10);
            this.BillLabel.Name = "BillLabel";
            this.BillLabel.Size = new System.Drawing.Size(102, 34);
            this.BillLabel.TabIndex = 0;
            this.BillLabel.Text = "Bill";
           
            // 
            // Error1
            // 
            this.Error1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.Error1.ContainerControl = this;
            // 
            // Error2
            // 
            this.Error2.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.Error2.ContainerControl = this;
            // 
            // Error3
            // 
            this.Error3.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.Error3.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TipCalculator.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(782, 403);
            this.Controls.Add(this.Dashboard);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 450);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "Form1";
            this.Text = "Tip Calculator";
            this.Dashboard.ResumeLayout(false);
            this.Dashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PeopleCount_Input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tip_Input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Dashboard;
        private System.Windows.Forms.NumericUpDown Tip_Input;
        private System.Windows.Forms.Label TipPercentLabel;
        private System.Windows.Forms.TextBox Bill_Input;
        private System.Windows.Forms.Label BillLabel;
        private System.Windows.Forms.NumericUpDown PeopleCount_Input;
        private System.Windows.Forms.Label PeopleCountLabel;
        private System.Windows.Forms.Label PerPersonLabel1;
        private System.Windows.Forms.Label TipLabel;
        private System.Windows.Forms.Label Total_Output;
        private System.Windows.Forms.Label Tip_Output;
        private System.Windows.Forms.Label PerPersonLabel2;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Label BillError;
        private System.Windows.Forms.ErrorProvider Error1;
        private System.Windows.Forms.Label PeopleCountError;
        private System.Windows.Forms.Label TipError;
        private System.Windows.Forms.ErrorProvider Error2;
        private System.Windows.Forms.ErrorProvider Error3;
    }
}

