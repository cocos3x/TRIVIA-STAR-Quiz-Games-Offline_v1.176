using UnityEngine;
private sealed class ShapeInfo.<>c__DisplayClass90_0
{
    // Fields
    public BlockPuzzleMagic.ShapeInfo <>4__this;
    public System.Action onComplete;
    
    // Methods
    public ShapeInfo.<>c__DisplayClass90_0()
    {
    
    }
    internal void <SnapBackAndReset>b__0()
    {
        this.<>4__this.ToggleSortingOrder(bringToFront:  false);
        UnityEngine.GameObject val_1 = this.<>4__this.gameObject;
        UnityEngine.Transform val_2 = this.<>4__this.transform;
        this.<>4__this.position = new UnityEngine.Vector3() {x = this.<>4__this.neutralWorldPosition, y = R7, z = this.<>4__this};
        if(this.onComplete == 0)
        {
                return;
        }
        
        this.onComplete.Invoke();
    }

}
