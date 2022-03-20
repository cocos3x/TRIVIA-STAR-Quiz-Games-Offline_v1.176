using UnityEngine;
public class TRVScreenBlocker : MonoSingleton<TRVScreenBlocker>
{
    // Methods
    public void SetActive(bool active)
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        object val_2 = this.GetComponent<System.Object>();
        this.enabled = active;
    }
    public TRVScreenBlocker()
    {
    
    }

}
