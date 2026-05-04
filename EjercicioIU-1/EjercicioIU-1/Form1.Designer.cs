namespace EjercicioIU_1;

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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        RegisterNum1 = new System.Windows.Forms.Button();
        RegisterNum2 = new System.Windows.Forms.Button();
        Sum = new System.Windows.Forms.Button();
        Dividir = new System.Windows.Forms.Button();
        Subtract = new System.Windows.Forms.Button();
        Multiply = new System.Windows.Forms.Button();
        Num1 = new System.Windows.Forms.TextBox();
        Num2 = new System.Windows.Forms.TextBox();
        Result = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // RegisterNum1
        // 
        RegisterNum1.Location = new System.Drawing.Point(596, 22);
        RegisterNum1.Name = "RegisterNum1";
        RegisterNum1.Size = new System.Drawing.Size(157, 63);
        RegisterNum1.TabIndex = 0;
        RegisterNum1.Text = "Register";
        RegisterNum1.UseVisualStyleBackColor = true;
        RegisterNum1.Click += RegisterNum1_Click;
        // 
        // RegisterNum2
        // 
        RegisterNum2.Location = new System.Drawing.Point(596, 108);
        RegisterNum2.Name = "RegisterNum2";
        RegisterNum2.Size = new System.Drawing.Size(157, 63);
        RegisterNum2.TabIndex = 2;
        RegisterNum2.Text = "Register";
        RegisterNum2.UseVisualStyleBackColor = true;
        RegisterNum2.Click += RegisterNum2_Click;
        // 
        // Sum
        // 
        Sum.Location = new System.Drawing.Point(152, 224);
        Sum.Name = "Sum";
        Sum.Size = new System.Drawing.Size(189, 171);
        Sum.TabIndex = 3;
        Sum.Text = "+";
        Sum.UseVisualStyleBackColor = true;
        Sum.Click += Sum_Click;
        // 
        // Dividir
        // 
        Dividir.Location = new System.Drawing.Point(400, 224);
        Dividir.Name = "Dividir";
        Dividir.Size = new System.Drawing.Size(189, 171);
        Dividir.TabIndex = 4;
        Dividir.Text = "/";
        Dividir.UseVisualStyleBackColor = true;
        Dividir.Click += Dividir_Click;
        // 
        // Subtract
        // 
        Subtract.Location = new System.Drawing.Point(152, 436);
        Subtract.Name = "Subtract";
        Subtract.Size = new System.Drawing.Size(189, 171);
        Subtract.TabIndex = 5;
        Subtract.Text = "-";
        Subtract.UseVisualStyleBackColor = true;
        Subtract.Click += Subtract_Click;
        // 
        // Multiply
        // 
        Multiply.Location = new System.Drawing.Point(400, 436);
        Multiply.Name = "Multiply";
        Multiply.Size = new System.Drawing.Size(189, 171);
        Multiply.TabIndex = 6;
        Multiply.Text = "* ";
        Multiply.UseVisualStyleBackColor = true;
        Multiply.Click += Multiply_Click;
        // 
        // Num1
        // 
        Num1.Location = new System.Drawing.Point(164, 40);
        Num1.Name = "Num1";
        Num1.Size = new System.Drawing.Size(415, 27);
        Num1.TabIndex = 7;
        Num1.Text = "0";
        // 
        // Num2
        // 
        Num2.Location = new System.Drawing.Point(164, 126);
        Num2.Name = "Num2";
        Num2.Size = new System.Drawing.Size(415, 27);
        Num2.TabIndex = 8;
        Num2.Text = "0";
        // 
        // Result
        // 
        Result.Location = new System.Drawing.Point(92, 671);
        Result.Name = "Result";
        Result.Size = new System.Drawing.Size(271, 39);
        Result.TabIndex = 9;
        Result.Text = "Result";
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 731);
        Controls.Add(Result);
        Controls.Add(Num2);
        Controls.Add(Num1);
        Controls.Add(Multiply);
        Controls.Add(Subtract);
        Controls.Add(Dividir);
        Controls.Add(Sum);
        Controls.Add(RegisterNum2);
        Controls.Add(RegisterNum1);
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button Subtract;
    private System.Windows.Forms.Button Multiply;
    private System.Windows.Forms.TextBox Num1;
    private System.Windows.Forms.TextBox Num2;
    private System.Windows.Forms.Label Result;

    private System.Windows.Forms.Button Sum;
    private System.Windows.Forms.Button RegisterNum2;
    private System.Windows.Forms.Button Dividir;

    private System.Windows.Forms.Button RegisterNum1;

    #endregion
}