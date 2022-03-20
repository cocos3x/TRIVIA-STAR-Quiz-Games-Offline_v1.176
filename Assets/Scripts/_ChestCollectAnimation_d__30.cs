using UnityEngine;
private sealed class MPILevelCompletePopup.<ChestCollectAnimation>d__30 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public SLC.MatchyPics.MPILevelCompletePopup <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public MPILevelCompletePopup.<ChestCollectAnimation>d__30(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_13;
        var val_14;
        val_13 = 0;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
                return (bool)val_13;
        }
        
        this.<>1__state = 0;
        UnityEngine.GameObject val_1 = this.<>4__this.chestIconAnim.gameObject;
        this.<>4__this.chestIconAnim.SetActive(value:  true);
        UnityEngine.Transform val_2 = this.<>4__this.chestIconAnim.transform;
        UnityEngine.Transform val_3 = this.<>4__this.chestRewardsText.transform;
        UnityEngine.Transform val_4 = this.<>4__this.chestRewardsText.parent;
        this.<>4__this.chestIconAnim.SetParent(p:  this.<>4__this.chestRewardsText);
        UnityEngine.Transform val_5 = this.<>4__this.chestIconAnim.transform;
        UnityEngine.Transform val_6 = this.<>4__this.chestRewardsText.transform;
        UnityEngine.Vector3 val_7 = position;
        DG.Tweening.Tweener val_8 = DG.Tweening.ShortcutExtensions.DOMove(target:  this.<>4__this.chestIconAnim, endValue:  new UnityEngine.Vector3(), duration:  val_7.x, snapping:  true);
        object val_9 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.<>4__this.chestIconAnim, ease:  15);
        DG.Tweening.TweenCallback val_10 = new DG.Tweening.TweenCallback(object:  this.<>4__this, method:  new IntPtr(783842992));
        System.Delegate val_11 = System.Delegate.Combine(a:  this.<>4__this.chestRewardsText, b:  190734336);
        val_14 = this.<>4__this.chestRewardsText;
        if(val_14 != 0)
        {
                if(null == null)
        {
            goto label_16;
        }
        
        }
        
        val_14 = 0;
        label_16:
        mem2[0] = val_14;
        UnityEngine.WaitForSeconds val_12 = null;
        val_12 = new UnityEngine.WaitForSeconds(seconds:  val_7.x);
        val_13 = 1;
        this.<>1__state = val_13;
        this.<>2__current = val_12;
        return (bool)val_13;
        label_1:
        this.<>1__state = 0;
        this.<>4__this.SetupButtons();
        return (bool)val_13;
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
