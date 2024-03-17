public class User
{
    private String name;
    private int id;
    private int age;
    private double balance;

    public User(String name, int id, int age, double balance)
    {
        this.name = name;
        this.id = id;
        this.age = age;
        this.balance = balance;

    }
    public User()
    {
    }
    public String GetName()
    {
        return this.name;
    }

    public void SetName(String name)
    {
        this.name = name;
    }

    public int GetId()
    {
        return this.id;
    }

    public void SetId(int id)
    {
        this.id = id;
    }

    public int GetAge()
    {
        return this.age;
    }

    public void SetAge(int age)
    {
        this.age = age;
    }

    public double GetBalance()
    {
        return this.balance;
    }

    public void SetBalance(double balance)
    {
        this.balance = balance;
    }



}