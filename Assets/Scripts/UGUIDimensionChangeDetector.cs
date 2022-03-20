using UnityEngine;
public class UGUIDimensionChangeDetector : UIBehaviour
{
    // Fields
    public System.Action OnDimensionChange;
    
    // Methods
    protected override void OnRectTransformDimensionsChange()
    {
        this.OnRectTransformDimensionsChange();
        if(this.OnDimensionChange == 0)
        {
                return;
        }
        
        this.OnDimensionChange.Invoke();
    }
    public UGUIDimensionChangeDetector()
    {
    
    }

}
