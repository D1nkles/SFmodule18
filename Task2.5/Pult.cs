class Pult
{
    GateOpenAction _action;
    public void SetAction(GateOpenAction action) 
    {
        _action = action;
    }

    public void OpenButton() 
    {
        _action.Run();
    }
    public void CloseButton()
    {
        _action.Cancel();
    }
}

