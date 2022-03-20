using UnityEngine;
private sealed class TRVCategorySelection.<CheckCrazyCategories>d__47 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public TRVCategorySelection <>4__this;
    private System.Collections.Generic.List.Enumerator<TRVCategoryButton> <>7__wrap1;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public TRVCategorySelection.<CheckCrazyCategories>d__47(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
        if((this.<>1__state) != 3)
        {
                return;
        }
        
        this.<>m__Finally1();
    }
    private bool MoveNext()
    {
        float val_5;
        float val_6;
        TRVCategorySelection.<CheckCrazyCategories>d__47 val_14;
        int val_15;
        TRVCategorySelection val_16;
        List.Enumerator<TRVCategoryButton> val_17;
        TRVCategorySelection val_18;
        val_14 = this;
        val_15 = 0;
        val_16 = this.<>4__this;
        if((this.<>1__state) != 1)
        {
                if((this.<>1__state) != 0)
        {
                return (bool)val_15;
        }
        
            this.<>1__state = 0;
            if(TRVCrazyCategoriesEventHandler.EVENT_TRACKING_ID == null)
        {
                return (bool)val_15;
        }
        
            val_15 = 0;
            if((System.String.IsNullOrEmpty(value:  TRVCrazyCategoriesEventHandler.EVENT_TRACKING_ID + 16)) == true)
        {
                return (bool)val_15;
        }
        
            List.Enumerator<T> val_2 = GetEnumerator();
            this.<>1__state = 2;
        }
        else
        {
                this.<>1__state = 2;
            UnityEngine.RectTransform val_3 = this.<>4__this.crazyCategoryImage.rectTransform;
            UnityEngine.Vector2 val_4 = UnityEngine.Vector2.zero;
            this.<>4__this.crazyCategoryImage.anchoredPosition = new UnityEngine.Vector2() {x = val_5, y = val_6};
            val_17 = this.<>7__wrap1;
        }
        
        val_18 = 35629739;
        label_22:
        if(val_17.MoveNext() == false)
        {
            goto label_14;
        }
        
        if(TRVCrazyCategoriesEventHandler.EVENT_TRACKING_ID == null)
        {
            goto label_22;
        }
        
        string val_8 = this.<>4__this.nextCategoryGroup.ToLower();
        string val_9 = TRVCrazyCategoriesEventHandler.EVENT_TRACKING_ID + 16.ToLower();
        val_14 = val_14;
        if((System.String.op_Equality(a:  this.<>4__this.nextCategoryGroup, b:  TRVCrazyCategoriesEventHandler.EVENT_TRACKING_ID + 16)) == false)
        {
            goto label_22;
        }
        
        val_18 = val_16;
        UnityEngine.Transform val_11 = this.<>4__this + 100.transform;
        UnityEngine.Transform val_12 = val_16.transform;
        this.<>4__this + 100.SetParent(p:  val_16);
        UnityEngine.GameObject val_13 = this.<>4__this + 100.gameObject;
        val_15 = 1;
        val_16 = 0;
        this.<>4__this + 100.SetActive(value:  true);
        this.<>1__state = val_15;
        mem[1152921512651531724] = val_16;
        return (bool)val_15;
        label_14:
        this.<>m__Finally1();
        val_15 = 0;
        return (bool)val_15;
    }
    private void <>m__Finally1()
    {
        this.<>1__state = 0;
        this.<>7__wrap1.Dispose();
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
