internal class ImplementationOne : BaseClass
{
    public ImplementationOne(int id) 
    {
        this.id = id;
    }

    public override BaseClass Clone()
    {
        return new ImplementationOne(id);
    }
}

