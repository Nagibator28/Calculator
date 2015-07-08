namespace Calculator
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.Addition = new System.Windows.Forms.Button();
            this.Subtraction = new System.Windows.Forms.Button();
            this.Multiplication = new System.Windows.Forms.Button();
            this.Division = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.TextBox();
            this.SecondArgument = new System.Windows.Forms.TextBox();
            this.FirstArgument = new System.Windows.Forms.TextBox();
            this.Sinus = new System.Windows.Forms.Button();
            this.Module = new System.Windows.Forms.Button();
            this.Cosinus = new System.Windows.Forms.Button();
            this.Factorial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Addition
            // 
            this.Addition.Location = new System.Drawing.Point(12, 60);
            this.Addition.Name = "Addition";
            this.Addition.Size = new System.Drawing.Size(60, 36);
            this.Addition.TabIndex = 0;
            this.Addition.Text = "+";
            this.Addition.UseVisualStyleBackColor = true;
            this.Addition.Click += new System.EventHandler(this.CalculateTwoArgument);
            // 
            // Subtraction
            // 
            this.Subtraction.Location = new System.Drawing.Point(78, 60);
            this.Subtraction.Name = "Subtraction";
            this.Subtraction.Size = new System.Drawing.Size(60, 37);
            this.Subtraction.TabIndex = 1;
            this.Subtraction.Text = "-";
            this.Subtraction.UseVisualStyleBackColor = true;
            this.Subtraction.Click += new System.EventHandler(this.CalculateTwoArgument);
            // 
            // Multiplication
            // 
            this.Multiplication.Location = new System.Drawing.Point(12, 102);
            this.Multiplication.Name = "Multiplication";
            this.Multiplication.Size = new System.Drawing.Size(60, 37);
            this.Multiplication.TabIndex = 2;
            this.Multiplication.Text = "*";
            this.Multiplication.UseVisualStyleBackColor = true;
            this.Multiplication.Click += new System.EventHandler(this.CalculateTwoArgument);
            // 
            // Division
            // 
            this.Division.Location = new System.Drawing.Point(144, 60);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(60, 37);
            this.Division.TabIndex = 3;
            this.Division.Text = "/";
            this.Division.UseVisualStyleBackColor = true;
            this.Division.Click += new System.EventHandler(this.CalculateTwoArgument);
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(334, 12);
            this.Result.Multiline = true;
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(87, 127);
            this.Result.TabIndex = 4;
            // 
            // SecondArgument
            // 
            this.SecondArgument.Location = new System.Drawing.Point(170, 12);
            this.SecondArgument.Multiline = true;
            this.SecondArgument.Name = "SecondArgument";
            this.SecondArgument.Size = new System.Drawing.Size(152, 41);
            this.SecondArgument.TabIndex = 5;
            // 
            // FirstArgument
            // 
            this.FirstArgument.Location = new System.Drawing.Point(12, 12);
            this.FirstArgument.Multiline = true;
            this.FirstArgument.Name = "FirstArgument";
            this.FirstArgument.Size = new System.Drawing.Size(152, 41);
            this.FirstArgument.TabIndex = 6;
            // 
            // Sinus
            // 
            this.Sinus.Location = new System.Drawing.Point(78, 102);
            this.Sinus.Name = "Sinus";
            this.Sinus.Size = new System.Drawing.Size(60, 36);
            this.Sinus.TabIndex = 7;
            this.Sinus.Text = "Sin";
            this.Sinus.UseVisualStyleBackColor = true;
            this.Sinus.Click += new System.EventHandler(this.CalculateOneArgument);
            // 
            // Module
            // 
            this.Module.Location = new System.Drawing.Point(144, 102);
            this.Module.Name = "Module";
            this.Module.Size = new System.Drawing.Size(60, 36);
            this.Module.TabIndex = 8;
            this.Module.Text = "|Module|";
            this.Module.UseVisualStyleBackColor = true;
            this.Module.Click += new System.EventHandler(this.CalculateOneArgument);
            // 
            // Cosinus
            // 
            this.Cosinus.Location = new System.Drawing.Point(210, 60);
            this.Cosinus.Name = "Cosinus";
            this.Cosinus.Size = new System.Drawing.Size(60, 37);
            this.Cosinus.TabIndex = 9;
            this.Cosinus.Text = "Cos";
            this.Cosinus.UseVisualStyleBackColor = true;
            this.Cosinus.Click += new System.EventHandler(this.CalculateOneArgument);
            // 
            // Factorial
            // 
            this.Factorial.Location = new System.Drawing.Point(210, 102);
            this.Factorial.Name = "Factorial";
            this.Factorial.Size = new System.Drawing.Size(60, 36);
            this.Factorial.TabIndex = 10;
            this.Factorial.Text = "n!";
            this.Factorial.UseVisualStyleBackColor = true;
            this.Factorial.Click += new System.EventHandler(this.CalculateOneArgument);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 153);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Addition;
        private System.Windows.Forms.Button Subtraction;
        private System.Windows.Forms.Button Multiplication;
        private System.Windows.Forms.Button Division;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.TextBox SecondArgument;
        private System.Windows.Forms.TextBox FirstArgument;
        private System.Windows.Forms.Button Sinus;
        private System.Windows.Forms.Button Module;
        private System.Windows.Forms.Button Cosinus;
        private System.Windows.Forms.Button Factorial;
    }
}

