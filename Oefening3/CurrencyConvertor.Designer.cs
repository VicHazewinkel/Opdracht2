namespace Oefening3
{
    partial class CurrencyConvertor
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
            this.label_Amount = new System.Windows.Forms.Label();
            this.label_From = new System.Windows.Forms.Label();
            this.label_To = new System.Windows.Forms.Label();
            this.comboBox_To = new System.Windows.Forms.ComboBox();
            this.comboBox_From = new System.Windows.Forms.ComboBox();
            this.textBox_Converted = new System.Windows.Forms.TextBox();
            this.textBox_Amount = new System.Windows.Forms.TextBox();
            this.button_Convert = new System.Windows.Forms.Button();
            this.label_Converted = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_Amount
            // 
            this.label_Amount.AutoSize = true;
            this.label_Amount.Location = new System.Drawing.Point(62, 44);
            this.label_Amount.Name = "label_Amount";
            this.label_Amount.Size = new System.Drawing.Size(51, 15);
            this.label_Amount.TabIndex = 0;
            this.label_Amount.Text = "Amount";
            // 
            // label_From
            // 
            this.label_From.AutoSize = true;
            this.label_From.Location = new System.Drawing.Point(168, 44);
            this.label_From.Name = "label_From";
            this.label_From.Size = new System.Drawing.Size(35, 15);
            this.label_From.TabIndex = 1;
            this.label_From.Text = "From";
            // 
            // label_To
            // 
            this.label_To.AutoSize = true;
            this.label_To.Location = new System.Drawing.Point(295, 44);
            this.label_To.Name = "label_To";
            this.label_To.Size = new System.Drawing.Size(19, 15);
            this.label_To.TabIndex = 2;
            this.label_To.Text = "To";
            // 
            // comboBox_To
            // 
            this.comboBox_To.FormattingEnabled = true;
            this.comboBox_To.Items.AddRange(new object[] {
            "USD"});
            this.comboBox_To.Location = new System.Drawing.Point(295, 62);
            this.comboBox_To.Name = "comboBox_To";
            this.comboBox_To.Size = new System.Drawing.Size(121, 23);
            this.comboBox_To.TabIndex = 3;
            // 
            // comboBox_From
            // 
            this.comboBox_From.FormattingEnabled = true;
            this.comboBox_From.Items.AddRange(new object[] {
            "Euro",
            "British_Pound",
            "Japanse_Yen",
            "Indiaase_Rupees",
            "Zwitserse_Franken"});
            this.comboBox_From.Location = new System.Drawing.Point(168, 62);
            this.comboBox_From.Name = "comboBox_From";
            this.comboBox_From.Size = new System.Drawing.Size(121, 23);
            this.comboBox_From.TabIndex = 4;
            // 
            // textBox_Converted
            // 
            this.textBox_Converted.Location = new System.Drawing.Point(62, 152);
            this.textBox_Converted.Name = "textBox_Converted";
            this.textBox_Converted.Size = new System.Drawing.Size(100, 23);
            this.textBox_Converted.TabIndex = 5;
            this.textBox_Converted.TextChanged += new System.EventHandler(this.textBox_Converted_TextChanged);
            // 
            // textBox_Amount
            // 
            this.textBox_Amount.Location = new System.Drawing.Point(62, 62);
            this.textBox_Amount.Name = "textBox_Amount";
            this.textBox_Amount.Size = new System.Drawing.Size(100, 23);
            this.textBox_Amount.TabIndex = 6;
            // 
            // button_Convert
            // 
            this.button_Convert.Location = new System.Drawing.Point(62, 91);
            this.button_Convert.Name = "button_Convert";
            this.button_Convert.Size = new System.Drawing.Size(75, 23);
            this.button_Convert.TabIndex = 7;
            this.button_Convert.Text = "Convert";
            this.button_Convert.UseVisualStyleBackColor = true;
            this.button_Convert.Click += new System.EventHandler(this.button_Convert_Click);
            // 
            // label_Converted
            // 
            this.label_Converted.AutoSize = true;
            this.label_Converted.Location = new System.Drawing.Point(62, 134);
            this.label_Converted.Name = "label_Converted";
            this.label_Converted.Size = new System.Drawing.Size(68, 15);
            this.label_Converted.TabIndex = 8;
            this.label_Converted.Text = "Converted: ";
            // 
            // CurrencyConvertor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_Converted);
            this.Controls.Add(this.button_Convert);
            this.Controls.Add(this.textBox_Amount);
            this.Controls.Add(this.textBox_Converted);
            this.Controls.Add(this.comboBox_From);
            this.Controls.Add(this.comboBox_To);
            this.Controls.Add(this.label_To);
            this.Controls.Add(this.label_From);
            this.Controls.Add(this.label_Amount);
            this.Name = "CurrencyConvertor";
            this.Text = "CurrencyConvertor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_Amount;
        private Label label_From;
        private Label label_To;
        private ComboBox comboBox_To;
        private ComboBox comboBox_From;
        private TextBox textBox_Converted;
        private TextBox textBox_Amount;
        private Button button_Convert;
        private Label label_Converted;
    }
}