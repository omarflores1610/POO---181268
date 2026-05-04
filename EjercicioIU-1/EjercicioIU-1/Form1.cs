namespace EjercicioIU_1;

public partial class Form1 : Form
{
    private Calculator calculator1 = new Calculator();
    public Form1()
    {
        InitializeComponent();
    }

    private void RegisterNum1_Click(object sender, EventArgs e)
    {
        calculator1.SetNumOne(float.Parse(Num1.Text));
    }

    private void RegisterNum2_Click(object sender, EventArgs e)
    {
        calculator1.SetNumTwo(float.Parse(Num2.Text));
    }

    private void Sum_Click(object sender, EventArgs e)
    {
        Result.Text = calculator1.Sum();
    }
    
    private void Dividir_Click(object sender, EventArgs e)
    {
        Result.Text = calculator1.Divide();
    }


    private void Subtract_Click(object sender, EventArgs e)
    {
        calculator1.Subtract();
    }


    private void Multiply_Click(object sender, EventArgs e)
    {
        calculator1.Multiply();
    }
    
}
