internal abstract class BaseClass : IObject
{
    public int id;
    public abstract BaseClass Clone();
    
    public void GetId()
    {
        Console.WriteLine("Создан объект с Id: " + id);
    }
}

