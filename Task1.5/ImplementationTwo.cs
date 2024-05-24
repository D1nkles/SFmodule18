internal class ImplementationTwo : BaseClass
{
    public ImplementationTwo(int id)
    {
        this.id = id;
    }

    public override BaseClass Clone()
    {
        return new ImplementationOne(id);
    }
}

