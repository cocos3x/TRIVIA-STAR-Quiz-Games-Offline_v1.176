using UnityEngine;
public class WGGameSceneFlyoutProxy : MonoBehaviour
{
    // Fields
    private System.Action onShowCallback;
    
    // Methods
    public void setCallback(System.Action theCallback)
    {
        this.onShowCallback = theCallback;
    }
    private void OnEnable()
    {
        if(this.onShowCallback == 0)
        {
                return;
        }
        
        this.onShowCallback.Invoke();
    }
    public void Close()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        this.SetActive(value:  false);
    }
    public WGGameSceneFlyoutProxy()
    {
    
    }

}
