using UnityEngine;
private sealed class TRVPickerGameButton.<doReveal>d__14 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public TRVPickerGameButton <>4__this;
    public bool selected;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public TRVPickerGameButton.<doReveal>d__14(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        TRVPickerGameButton val_8;
        int val_9;
        object val_10;
        var val_11;
        UnityEngine.UI.Image val_12;
        val_8 = this.<>4__this;
        if((this.<>1__state) != 1)
        {
                val_9 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_9;
        }
        
            this.<>1__state = 0;
            UnityEngine.Transform val_1 = this.<>4__this.myImage.transform;
            DG.Tweening.Tweener val_2 = DG.Tweening.ShortcutExtensions.DOScaleX(target:  this.<>4__this.myImage, endValue:  null, duration:  null);
            UnityEngine.WaitForSeconds val_3 = null;
            val_10 = val_3;
            val_3 = new UnityEngine.WaitForSeconds(seconds:  null);
            val_9 = 1;
            this.<>1__state = val_9;
            this.<>2__current = val_10;
            return (bool)val_9;
        }
        
        this.<>1__state = 0;
        if(val_8 != 0)
        {
                val_11 = val_8;
            val_12 = this.<>4__this.myImage;
        }
        else
        {
                val_11 = 12;
            val_12 = 0;
        }
        
        val_12.sprite = this.<>4__this.specificSprite;
        UnityEngine.GameObject val_4 = this.<>4__this.chosenOutline.gameObject;
        if(this.selected == true)
        {
                val_8 = 1;
        }
        
        val_9 = 0;
        this.<>4__this.chosenOutline.SetActive(value:  true);
        UnityEngine.Transform val_5 = val_11.transform;
        DG.Tweening.Tweener val_6 = DG.Tweening.ShortcutExtensions.DOScale(target:  0, endValue:  null, duration:  null);
        if(this.selected == true)
        {
                return (bool)val_9;
        }
        
        val_9 = 0;
        UnityEngine.Color val_7 = UnityEngine.Color.gray;
        return (bool)val_9;
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
