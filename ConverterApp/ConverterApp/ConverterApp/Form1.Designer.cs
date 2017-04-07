namespace ConverterApp
{
    partial class frm_Main
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
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lbDisplay = new System.Windows.Forms.ListBox();
            this.txtCmToInch = new System.Windows.Forms.TextBox();
            this.txtMetreToFeet = new System.Windows.Forms.TextBox();
            this.txtCelsiusToFahrenheit = new System.Windows.Forms.TextBox();
            this.txtCmToFeet = new System.Windows.Forms.TextBox();
            this.txtKiloToMiles = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(16, 246);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 0;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(230, 9);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lbDisplay
            // 
            this.lbDisplay.FormattingEnabled = true;
            this.lbDisplay.Location = new System.Drawing.Point(160, 57);
            this.lbDisplay.Name = "lbDisplay";
            this.lbDisplay.Size = new System.Drawing.Size(145, 212);
            this.lbDisplay.TabIndex = 2;
            // 
            // txtCmToInch
            // 
            this.txtCmToInch.Location = new System.Drawing.Point(16, 57);
            this.txtCmToInch.Name = "txtCmToInch";
            this.txtCmToInch.Size = new System.Drawing.Size(100, 20);
            this.txtCmToInch.TabIndex = 3;
            // 
            // txtMetreToFeet
            // 
            this.txtMetreToFeet.Location = new System.Drawing.Point(16, 96);
            this.txtMetreToFeet.Name = "txtMetreToFeet";
            this.txtMetreToFeet.Size = new System.Drawing.Size(100, 20);
            this.txtMetreToFeet.TabIndex = 4;
            // 
            // txtCelsiusToFahrenheit
            // 
            this.txtCelsiusToFahrenheit.Location = new System.Drawing.Point(16, 135);
            this.txtCelsiusToFahrenheit.Name = "txtCelsiusToFahrenheit";
            this.txtCelsiusToFahrenheit.Size = new System.Drawing.Size(100, 20);
            this.txtCelsiusToFahrenheit.TabIndex = 5;
            // 
            // txtCmToFeet
            // 
            this.txtCmToFeet.Location = new System.Drawing.Point(16, 175);
            this.txtCmToFeet.Name = "txtCmToFeet";
            this.txtCmToFeet.Size = new System.Drawing.Size(100, 20);
            this.txtCmToFeet.TabIndex = 6;
            // 
            // txtKiloToMiles
            // 
            this.txtKiloToMiles.Location = new System.Drawing.Point(16, 214);
            this.txtKiloToMiles.Name = "txtKiloToMiles";
            this.txtKiloToMiles.Size = new System.Drawing.Size(100, 20);
            this.txtKiloToMiles.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Units of conversion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Centimetres to Inches.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Metres to Feet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Celsius to Fahrenheit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Centimetres to Feet";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Kilometres to Miles";
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 284);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKiloToMiles);
            this.Controls.Add(this.txtCmToFeet);
            this.Controls.Add(this.txtCelsiusToFahrenheit);
            this.Controls.Add(this.txtMetreToFeet);
            this.Controls.Add(this.txtCmToInch);
            this.Controls.Add(this.lbDisplay);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnConvert);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_Main";
            this.Text = "ATCA Gas Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox lbDisplay;
        private System.Windows.Forms.TextBox txtCmToInch;
        private System.Windows.Forms.TextBox txtMetreToFeet;
        private System.Windows.Forms.TextBox txtCelsiusToFahrenheit;
        private System.Windows.Forms.TextBox txtCmToFeet;
        private System.Windows.Forms.TextBox txtKiloToMiles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

