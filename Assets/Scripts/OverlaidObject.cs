using UnityEngine;
public struct OverlaidObject
{
    // Fields
    public UnityEngine.Transform transform;
    public UnityEngine.Transform parent;
    public int siblingIndex;
    
    // Methods
    public OverlaidObject(UnityEngine.Transform _transform, UnityEngine.Transform _parent, int _siblingIndex)
    {
    
    }
    public void Restore()
    {
        this.Restore(_siblingIndex:  this.siblingIndex);
    }
    public void Restore(int _siblingIndex)
    {
        UnityEngine.Transform val_5;
        if(374972416 != 0)
        {
                val_5 = this.parent;
            if(val_5 != 0)
        {
                val_5.SetParent(p:  val_5);
            1152921504981819392.SetSiblingIndex(index:  _siblingIndex);
            return;
        }
        
        }
        
        if(374972416 == 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_4 = 1152921504981819392.gameObject;
        UnityEngine.Object.Destroy(obj:  374972416);
    }

}
