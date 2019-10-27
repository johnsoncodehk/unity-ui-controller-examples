public class UIControllerExample : UIController
{
    public void Play()
    {
        if (!gameObject.activeSelf)
            Show();
        else
            Hide();
    }
}
