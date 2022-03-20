using UnityEngine;
private sealed class RESRaidScreenMain.<ShowPickedRaidSpots>d__57 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public RestaurantRivals.RESRaidScreenMain <>4__this;
    private int <i>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public RESRaidScreenMain.<ShowPickedRaidSpots>d__57(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_11;
        RestaurantRivals.RESRaidScreenMain val_12;
        object val_13;
        System.Collections.Generic.List<UnityEngine.UI.Image> val_14;
        int val_15;
        val_11 = 0;
        val_12 = this.<>4__this;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        if((this.<>1__state) != 0)
        {
                return (bool)val_11;
        }
        
        this.<>1__state = 0;
        UnityEngine.WaitForSeconds val_1 = null;
        val_13 = val_1;
        val_1 = new UnityEngine.WaitForSeconds(seconds:  null);
        val_11 = 1;
        this.<>1__state = val_11;
        goto label_4;
        label_1:
        this.<>1__state = 0;
        if(0 <= (this.<i>5__2))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_2 = R1 + ((this.<i>5__2) << 2);
        System.Action<twelvegigs.storage.JsonDictionary> val_3 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  val_12, method:  new IntPtr(614698992));
        (R1 + (this.<i>5__2) << 2) + 16.Initialize(id:  this.<i>5__2, onClicked:  7401472);
        if(((R1 + (this.<i>5__2) << 2) + 16) <= (this.<i>5__2))
        {
                var val_10 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_10 = val_10 + ((this.<i>5__2) << 2);
        UnityEngine.GameObject val_4 = (0 + (this.<i>5__2) << 2) + 16.gameObject;
        (0 + (this.<i>5__2) << 2) + 16.SetActive(value:  true);
        if(((0 + (this.<i>5__2) << 2) + 16) <= (this.<i>5__2))
        {
                var val_11 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_11 = val_11 + ((this.<i>5__2) << 2);
        UnityEngine.Transform val_5 = (0 + (this.<i>5__2) << 2) + 16.transform;
        DG.Tweening.Tweener val_6 = DG.Tweening.ShortcutExtensions.DOScale(target:  (0 + (this.<i>5__2) << 2) + 16, endValue:  null, duration:  null);
        object val_7 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  (0 + (this.<i>5__2) << 2) + 16, animCurve:  this.<>4__this.curve);
        val_14 = this.<>4__this.pickerIconList;
        if((this.<i>5__2) < ((0 + (this.<i>5__2) << 2) + 16))
        {
                val_14 = this.<>4__this.pickerIconList;
            if(((0 + (this.<i>5__2) << 2) + 16) <= (this.<i>5__2))
        {
                var val_12 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_12 = val_12 + ((this.<i>5__2) << 2);
            UnityEngine.GameObject val_8 = (0 + (this.<i>5__2) << 2) + 16.gameObject;
            (0 + (this.<i>5__2) << 2) + 16.SetActive(value:  true);
        }
        
        val_15 = (this.<i>5__2) + 1;
        this.<i>5__2 = val_15;
        goto label_23;
        label_2:
        val_15 = 0;
        this.<i>5__2 = val_15;
        this.<>1__state = 0;
        label_23:
        val_12 = this.<>4__this.pickedRaidSpots;
        if(val_15 >= 0)
        {
                return (bool)val_11;
        }
        
        UnityEngine.WaitForSeconds val_9 = null;
        val_13 = val_9;
        val_9 = new UnityEngine.WaitForSeconds(seconds:  null);
        val_11 = 1;
        this.<>1__state = 2;
        label_4:
        this.<>2__current = val_13;
        return (bool)val_11;
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
