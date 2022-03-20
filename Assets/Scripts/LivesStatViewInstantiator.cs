using UnityEngine;
public class LivesStatViewInstantiator : MonoBehaviour
{
    // Fields
    private UnityEngine.GameObject livesStatViewPrefab;
    private UnityEngine.GameObject parentContainer;
    
    // Methods
    private void Start()
    {
        UnityEngine.GameObject val_5;
        if(this.parentContainer == 0)
        {
                UnityEngine.GameObject val_2 = this.gameObject;
            val_5 = this;
            this.parentContainer = this;
        }
        else
        {
                val_5 = this.parentContainer;
        }
        
        UnityEngine.Transform val_3 = val_5.transform;
        object val_4 = UnityEngine.Object.Instantiate<System.Object>(original:  this.livesStatViewPrefab, parent:  val_5);
    }
    public LivesStatViewInstantiator()
    {
    
    }

}
