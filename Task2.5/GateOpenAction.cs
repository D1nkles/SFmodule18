internal class GateOpenAction : IAction
{
    Gate _gate;
    public GateOpenAction(Gate gate) 
    {
        _gate = gate;
    }

    public void Run() 
    {
        _gate.Open();
    }

    public void Cancel() 
    {
        _gate.Close();
    }
}
