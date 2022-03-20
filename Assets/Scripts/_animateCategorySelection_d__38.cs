using UnityEngine;
private sealed class TRVCategorySelection.<animateCategorySelection>d__38 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public TRVCategorySelection <>4__this;
    public TRVCategorySelectionInfo selectedCat;
    public TRVCategoryButton thisCatButton;
    public System.Collections.Generic.List<string> incCats;
    private TRVCategorySelection.<>c__DisplayClass38_0 <>8__1;
    private System.Collections.Generic.List<string> <allCategories>5__2;
    private float <animationDuration>5__3;
    private System.DateTime <startTime>5__4;
    private UnityEngine.Sprite <chosenSprite>5__5;
    private UnityEngine.Sprite <eventSprite>5__6;
    private int <cat>5__7;
    private UnityEngine.Sprite <newCatSprite>5__8;
    private string <newCatCat>5__9;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public TRVCategorySelection.<animateCategorySelection>d__38(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_46;
        TRVCategorySelection val_47;
        int val_48;
        object val_51;
        val_46 = 0;
        if((this.<>1__state) > 9)
        {
                return (bool)val_46;
        }
        
        val_47 = this.<>4__this;
        var val_1 = 12254880 + (12254880 + (this.<>1__state) << 2);
        if((this.<>1__state) == 9)
        {
                val_46 = val_46 & (val_47 >> 32);
            val_46 = val_46 & 3202638208;
            val_46 = val_46 & (val_46 << 12254880);
            val_46 = val_46 & (((IP) << (32-5)) | ((IP) << 5));
            val_46 = val_46 & (-546164544);
            val_46 = val_46 & ((IP) >> 10);
            val_46 = val_46 & (val_46 << R6);
            val_46 = val_46 & (((IP) << (32-15)) | ((IP) << 15));
            val_46 = val_46 & (val_47 >> SB);
            val_46 = val_46 & ((IP) >> LR);
        }
        
        this.<>1__state = 0;
        this.<>8__1 = new System.Object();
        typeof(TRVCategorySelection.<>c__DisplayClass38_0).__il2cppRuntimeField_8 = this.<>4__this;
        this.<>8__1.selectedCat = this.selectedCat;
        val_48 = 1;
        val_51 = 0;
        val_46 = 1;
        this.<>2__current = ;
        this.<>1__state = ;
        return (bool)val_46;
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
