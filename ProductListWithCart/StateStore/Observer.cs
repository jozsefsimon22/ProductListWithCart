namespace ProductListWithCart.StateStore;

public class Observer
{
    protected Action? Listeners;

    public void Subscribe(Action listener)
    {
        if (Listeners != null)
            Listeners += listener;
    }

    public void Unsubscribe(Action listener)
    {
        if (Listeners != null)
            Listeners -= listener;
    }

    public void Notify()
    {
        Listeners?.Invoke();
    }
}