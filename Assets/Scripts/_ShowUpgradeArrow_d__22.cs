using UnityEngine;
private sealed class WADPetProfile.<ShowUpgradeArrow>d__22 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public WADPetProfile <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WADPetProfile.<ShowUpgradeArrow>d__22(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_12;
        UnityEngine.Transform val_13;
        var val_14;
        object val_15;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        val_12 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool)val_12;
        }
        
        this.<>1__state = 0;
        UnityEngine.Transform val_1 = this.<>4__this.upgradeArrow.transform;
        UnityEngine.Transform val_2 = this.<>4__this.upgradeButton.transform;
        val_13 = 0;
        UnityEngine.Vector3 val_3 = position;
        this.<>4__this.upgradeArrow.position = new UnityEngine.Vector3();
        val_14 = 0;
        UnityEngine.Transform val_4 = this.<>4__this.upgradeArrow.transform;
        UnityEngine.Vector3 val_5 = new UnityEngine.Vector3(x:  val_3.x, y:  val_3.y, z:  val_3.z);
        this.<>4__this.upgradeArrow.localPosition = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
        UnityEngine.GameObject val_6 = this.<>4__this.upgradeArrow.gameObject;
        this.<>4__this.upgradeArrow.SetActive(value:  true);
        goto label_13;
        label_1:
        this.<>1__state = 0;
        label_13:
        UnityEngine.WaitForEndOfFrame val_7 = null;
        val_15 = val_7;
        val_7 = new UnityEngine.WaitForEndOfFrame();
        val_12 = 1;
        this.<>1__state = val_12;
        goto label_14;
        label_2:
        this.<>1__state = 0;
        if((this.<>4__this) != 0)
        {
                val_13 = this.<>4__this.upgradeArrow;
        }
        else
        {
                val_13 = 0;
        }
        
        UnityEngine.Transform val_8 = this.<>4__this.upgradeButton.transform;
        UnityEngine.Vector3 val_9 = position;
        val_14 = 18154;
        val_14 = 1189765120;
        DG.Tweening.Sequence val_10 = DG.Tweening.ShortcutExtensions.DOJump(target:  0, endValue:  new UnityEngine.Vector3(), jumpPower:  val_9.x, numJumps:  1045220557, duration:  val_9.y, snapping:  true);
        this.<>4__this.upgradeArrowSequence = val_13;
        UnityEngine.WaitForSeconds val_11 = null;
        val_15 = val_11;
        val_11 = new UnityEngine.WaitForSeconds(seconds:  val_9.x);
        this.<>1__state = 2;
        val_12 = 1;
        label_14:
        this.<>2__current = val_15;
        return (bool)val_12;
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
