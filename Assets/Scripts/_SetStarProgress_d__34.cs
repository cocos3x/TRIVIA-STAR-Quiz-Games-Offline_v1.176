using UnityEngine;
private sealed class MPILevelCompletePopup.<SetStarProgress>d__34 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public SLC.MatchyPics.MPILevelCompletePopup <>4__this;
    public UnityEngine.Transform starParent;
    public float progress;
    public int stars;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public MPILevelCompletePopup.<SetStarProgress>d__34(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_24;
        UnityEngine.Transform val_25;
        System.Delegate val_26;
        object val_27;
        val_24 = 0;
        if((this.<>1__state) > 3)
        {
                return (bool);
        }
        
        var val_1 = 12523764 + (12523764 + (this.<>1__state) << 2);
        if((this.<>1__state) == 3)
        {
                12523764 + (this.<>1__state) << 2 = (12523764 + (this.<>1__state) << 2) & ((12523764 + (this.<>1__state) << 2) << (12523764 + (this.<>1__state) << 2));
            12523764 + (this.<>1__state) << 2 = (12523764 + (this.<>1__state) << 2) & (((int)R8) >> 2);
            12523764 + (this.<>1__state) << 2 = (12523764 + (this.<>1__state) << 2) & ((IP) << 5);
            12523764 + (this.<>1__state) << 2 = (12523764 + (this.<>1__state) << 2) & (((R8) << (32-this)) | ((R8) << this));
        }
        
        this.<>1__state = 0;
        UnityEngine.GameObject val_2 = this.<>4__this.starIconAnim.gameObject;
        this.<>4__this.starIconAnim.SetActive(value:  true);
        UnityEngine.Transform val_3 = this.<>4__this.starIconAnim.transform;
        val_25 = this.starParent;
        val_26 = 0;
        UnityEngine.Vector3 val_4 = position;
        this.<>4__this.starIconAnim.position = new UnityEngine.Vector3();
        UnityEngine.Transform val_5 = this.<>4__this.starIconAnim.transform;
        UnityEngine.Transform val_6 = this.starParent.parent;
        this.<>4__this.starIconAnim.SetParent(p:  this.starParent);
        UnityEngine.WaitForEndOfFrame val_7 = null;
        val_27 = val_7;
        val_7 = new UnityEngine.WaitForEndOfFrame();
        val_24 = 1;
        this.<>1__state = val_24;
        this.<>2__current = ;
        return (bool);
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
    
    }
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
    
    }

}
