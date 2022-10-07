namespace Oefening2
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
            this.CheckBox_koe = new System.Windows.Forms.CheckBox();
            this.CheckBox_slang = new System.Windows.Forms.CheckBox();
            this.CheckBox_varken = new System.Windows.Forms.CheckBox();
            this.button_LaatHoren = new System.Windows.Forms.Button();
            this.label_Uitspraak_Koe = new System.Windows.Forms.Label();
            this.label_Uitspraak_slang = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CheckBox_koe
            // 
            this.CheckBox_koe.AutoSize = true;
            this.CheckBox_koe.Location = new System.Drawing.Point(113, 46);
            this.CheckBox_koe.Name = "CheckBox_koe";
            this.CheckBox_koe.Size = new System.Drawing.Size(45, 19);
            this.CheckBox_koe.TabIndex = 0;
            this.CheckBox_koe.Text = "koe";
            this.CheckBox_koe.UseVisualStyleBackColor = true;
            // 
            // CheckBox_slang
            // 
            this.CheckBox_slang.AutoSize = true;
            this.CheckBox_slang.Location = new System.Drawing.Point(113, 71);
            this.CheckBox_slang.Name = "CheckBox_slang";
            this.CheckBox_slang.Size = new System.Drawing.Size(54, 19);
            this.CheckBox_slang.TabIndex = 1;
            this.CheckBox_slang.Text = "slang";
            this.CheckBox_slang.UseVisualStyleBackColor = true;
            // 
            // CheckBox_varken
            // 
            this.CheckBox_varken.AutoSize = true;
            this.CheckBox_varken.Location = new System.Drawing.Point(113, 96);
            this.CheckBox_varken.Name = "CheckBox_varken";
            this.CheckBox_varken.Size = new System.Drawing.Size(61, 19);
            this.CheckBox_varken.TabIndex = 2;
            this.CheckBox_varken.Text = "varken";
            this.CheckBox_varken.UseVisualStyleBackColor = true;
            // 
            // button_LaatHoren
            // 
            this.button_LaatHoren.Location = new System.Drawing.Point(113, 167);
            this.button_LaatHoren.Name = "button_LaatHoren";
            this.button_LaatHoren.Size = new System.Drawing.Size(75, 23);
            this.button_LaatHoren.TabIndex = 3;
            this.button_LaatHoren.Text = "Laat Horen";
            this.button_LaatHoren.UseVisualStyleBackColor = true;
            this.button_LaatHoren.Click += new System.EventHandler(this.button_LaatHoren_Click);
            // 
            // label_Uitspraak_Koe
            // 
            this.label_Uitspraak_Koe.AutoSize = true;
            this.label_Uitspraak_Koe.Location = new System.Drawing.Point(194, 127);
            this.label_Uitspraak_Koe.Name = "label_Uitspraak_Koe";
            this.label_Uitspraak_Koe.Size = new System.Drawing.Size(56, 15);
            this.label_Uitspraak_Koe.TabIndex = 4;
            this.label_Uitspraak_Koe.Text = "Uitspraak";
            this.label_Uitspraak_Koe.Click += new System.EventHandler(this.label_Uitspraak_Click);
            // 
            // label_Uitspraak_slang
            // 
            this.label_Uitspraak_slang.AutoSize = true;
            this.label_Uitspraak_slang.Location = new System.Drawing.Point(194, 142);
            this.label_Uitspraak_slang.Name = "label_Uitspraak_slang";
            this.label_Uitspraak_slang.Size = new System.Drawing.Size(38, 15);
            this.label_Uitspraak_slang.TabIndex = 5;
            this.label_Uitspraak_slang.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_Uitspraak_slang);
            this.Controls.Add(this.label_Uitspraak_Koe);
            this.Controls.Add(this.button_LaatHoren);
            this.Controls.Add(this.CheckBox_varken);
            this.Controls.Add(this.CheckBox_slang);
            this.Controls.Add(this.CheckBox_koe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox CheckBox_koe;
        private CheckBox CheckBox_slang;
        private CheckBox CheckBox_varken;
        private Button button_LaatHoren;
        private Label label_Uitspraak_Koe;
        private Label label_Uitspraak_slang;
        private Label label2;
    }
}