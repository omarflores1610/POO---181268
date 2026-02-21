namespace erkhaoerhgetoil;

public class Employee
{
    private string name;
    private string category;
    private int id;
    private float salary;
    
    public Employee(
        string name,
        string category,
        int id,
        float salary
        )
        {
        this.name = name;
        this.category = category;
        this.id = id;
        this.salary = salary;
        }

    public string GetName()
    {
        return this.name;
    }
}