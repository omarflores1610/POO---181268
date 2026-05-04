namespace EjercicioIU_1;

public class Calculator
{
    private float numOne;
    private float numTwo;

    public float Sum()
    {
        return numOne + numTwo;
    }
    
    public float Subtract()
    {
        return numOne - numTwo;
    }

    public float Multiply()
    {
        return numOne * numTwo;
    }

    public float Divide()
    {
        return numOne / numTwo;
    }

    public void SetNumOne(float numOne)
    {
        this.numOne = numOne;
    }

    public void SetNumTwo(float numTwo)
    {
        this.numTwo = numTwo;
    }
}