using UnityEngine;
public class ObserveExample : MonoBehaviour
{
    // Fields
    public string hoge;
    public ObserveExample.Test test;
    
    // Methods
    public void Callback()
    {
        UnityEngine.Debug.Log(message:  1825220944);
    }
    private void Callback2()
    {
        UnityEngine.Debug.Log(message:  1825333024);
    }
    public ObserveExample()
    {
    
    }

}
