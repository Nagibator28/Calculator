using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Calculator
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Addition = new Button();
            this.Subtraction = new Button();
            this.Multiplication = new Button();
            this.Division = new Button();
            this.Result = new TextBox();
            this.SecondArgument = new TextBox();
            this.FirstArgument = new TextBox();
            this.Sinus = new Button();
            this.Module = new Button();
            this.Cosinus = new Button();
            this.Factorial = new Button();
            this.button1 = new Button();
            this.Radical = new Button();
            this.SuspendLayout();
            // 
            // Addition
            // 
            this.Addition.Location = new Point(12, 60);
            this.Addition.Name = "Addition";
            this.Addition.Size = new Size(60, 36);
            this.Addition.TabIndex = 0;
            this.Addition.Text = "+";
            this.Addition.UseVisualStyleBackColor = true;
            this.Addition.Click += new EventHandler(this.CalculateTwoArgument);
            // 
            // Subtraction
            // 
            this.Subtraction.Location = new Point(78, 60);
            this.Subtraction.Name = "Subtraction";
            this.Subtraction.Size = new Size(60, 37);
            this.Subtraction.TabIndex = 1;
            this.Subtraction.Text = "-";
            this.Subtraction.UseVisualStyleBackColor = true;
            this.Subtraction.Click += new EventHandler(this.CalculateTwoArgument);
            // 
            // Multiplication
            // 
            this.Multiplication.Location = new Point(12, 102);
            this.Multiplication.Name = "Multiplication";
            this.Multiplication.Size = new Size(60, 37);
            this.Multiplication.TabIndex = 2;
            this.Multiplication.Text = "*";
            this.Multiplication.UseVisualStyleBackColor = true;
            this.Multiplication.Click += new EventHandler(this.CalculateTwoArgument);
            // 
            // Division
            // 
            this.Division.Location = new Point(144, 60);
            this.Division.Name = "Division";
            this.Division.Size = new Size(60, 37);
            this.Division.TabIndex = 3;
            this.Division.Text = "/";
            this.Division.UseVisualStyleBackColor = true;
            this.Division.Click += new EventHandler(this.CalculateTwoArgument);
            // 
            // Result
            // 
            this.Result.Location = new Point(339, 12);
            this.Result.Multiline = true;
            this.Result.Name = "Result";
            this.Result.Size = new Size(82, 129);
            this.Result.TabIndex = 4;
            // 
            // SecondArgument
            // 
            this.SecondArgument.Location = new Point(170, 12);
            this.SecondArgument.Multiline = true;
            this.SecondArgument.Name = "SecondArgument";
            this.SecondArgument.Size = new Size(152, 41);
            this.SecondArgument.TabIndex = 5;
            // 
            // FirstArgument
            // 
            this.FirstArgument.Location = new Point(12, 12);
            this.FirstArgument.Multiline = true;
            this.FirstArgument.Name = "FirstArgument";
            this.FirstArgument.Size = new Size(152, 41);
            this.FirstArgument.TabIndex = 6;
            // 
            // Sinus
            // 
            this.Sinus.Location = new Point(78, 102);
            this.Sinus.Name = "Sinus";
            this.Sinus.Size = new Size(60, 36);
            this.Sinus.TabIndex = 7;
            this.Sinus.Text = "Sin";
            this.Sinus.UseVisualStyleBackColor = true;
            this.Sinus.Click += new EventHandler(this.CalculateOneArgument);
            // 
            // Module
            // 
            this.Module.Location = new Point(144, 102);
            this.Module.Name = "Module";
            this.Module.Size = new Size(60, 36);
            this.Module.TabIndex = 8;
            this.Module.Text = "|Module|";
            this.Module.UseVisualStyleBackColor = true;
            this.Module.Click += new EventHandler(this.CalculateOneArgument);
            // 
            // Cosinus
            // 
            this.Cosinus.Location = new Point(210, 60);
            this.Cosinus.Name = "Cosinus";
            this.Cosinus.Size = new Size(60, 37);
            this.Cosinus.TabIndex = 9;
            this.Cosinus.Text = "Cos";
            this.Cosinus.UseVisualStyleBackColor = true;
            this.Cosinus.Click += new EventHandler(this.CalculateOneArgument);
            // 
            // Factorial
            // 
            this.Factorial.Location = new Point(210, 102);
            this.Factorial.Name = "Factorial";
            this.Factorial.Size = new Size(60, 36);
            this.Factorial.TabIndex = 10;
            this.Factorial.Text = "n!";
            this.Factorial.UseVisualStyleBackColor = true;
            this.Factorial.Click += new EventHandler(this.CalculateOneArgument);
            // 
            // button1
            // 
            this.button1.Location = new Point(276, 61);
            this.button1.Name = "button1";
            this.button1.Size = new Size(60, 36);
            this.button1.TabIndex = 11;
            this.button1.Text = "Pow";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new EventHandler(this.CalculateTwoArgument);
            // 
            // Radical
            // 
            this.Radical.Location = new Point(276, 102);
            this.Radical.Name = "Radical";
            this.Radical.Size = new Size(60, 36);
            this.Radical.TabIndex = 12;
            this.Radical.Text = "Sqrt";
            this.Radical.UseVisualStyleBackColor = true;
            this.Radical.Click += new EventHandler(this.CalculateOneArgument);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(430, 153);
            this.Controls.Add(this.Radical);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Factorial);
            this.Controls.Add(this.Cosinus);
            this.Controls.Add(this.Module);
            this.Controls.Add(this.Sinus);
            this.Controls.Add(this.FirstArgument);
            this.Controls.Add(this.SecondArgument);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Division);
            this.Controls.Add(this.Multiplication);
            this.Controls.Add(this.Subtraction);
            this.Controls.Add(this.Addition);
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Addition;
        private Button Subtraction;
        private Button Multiplication;
        private Button Division;
        private TextBox Result;
        private TextBox SecondArgument;
        private TextBox FirstArgument;
        private Button Sinus;
        private Button Module;
        private Button Cosinus;
        private Button Factorial;
        private Button button1;
        private Button Radical;
    }
}

