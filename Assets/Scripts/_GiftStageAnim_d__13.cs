using UnityEngine;
private sealed class WADMysteryGiftPopup.<GiftStageAnim>d__13 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public WADMysteryGiftPopup <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WADMysteryGiftPopup.<GiftStageAnim>d__13(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_31;
        WADMysteryGiftPopup val_32;
        object val_33;
        val_31 = 0;
        if((this.<>1__state) > 7)
        {
                return (bool);
        }
        
        val_32 = this.<>4__this;
        var val_1 = 7698080 + (7698080 + (this.<>1__state) << 2);
        if((this.<>1__state) == 7)
        {
                7698080 + (this.<>1__state) << 2 = (7698080 + (this.<>1__state) << 2) & ((7698080 + (this.<>1__state) << 2) >> 32);
            7698080 + (this.<>1__state) << 2 = (7698080 + (this.<>1__state) << 2) & (this >> (7698080 + (this.<>1__state) << 2));
            7698080 + (this.<>1__state) << 2 = (7698080 + (this.<>1__state) << 2) & ((R8) >> R2);
            7698080 + (this.<>1__state) << 2 = (7698080 + (this.<>1__state) << 2) & (((int)R8) >> 5);
            mem2[0] = ((((7698080 + (this.<>1__state) << 2 & (7698080 + (this.<>1__state) << 2) >> 32) & ((int)this) >> (7698080 + (this.<>1__state) << 2 & (7698080 + (this.<>1__state) << 2) >> 32)) & (R8) >> R2) & ((int)R + ((((7698080 + (this.<>1__state) << 2 & (7698080 + (this.<>1__state) << 2) >> 32) & ((int)this) >> (7698080 + (this.<>1__state) << 2 & (7698080 + (this.<>1__state) << 2) >> 32)) & (R8) >> R2) & ((int)R;
            (((((7698080 + (this.<>1__state) << 2 & (7698080 + (this.<>1__state) << 2) >> 32) & ((int)this) >> (7698080 + (this.<>1__state) << 2 & (7698080 + (this.<>1__state) << 2) >> 32)) & (R8) >> R2) & ((int)R + ((((7698080 + (this.<>1__state) << 2 & (7698080 + (this.<>1__state) << 2) >> 32) & ((int)this) >> (7698080 + (this.<>1__state) << 2 & (7698080 + (this.<>1__state) << 2) >> 32)) & (R8) >> R2) & ((int)R) & 3145845232 = ((((((7698080 + (this.<>1__state) << 2 & (7698080 + (this.<>1__state) << 2) >> 32) & ((int)this) >> (7698080 + (this.<>1__state) << 2 & (7698080 + (this.<>1__state) << 2) >> 32)) & (R8) >> R2) & ((int)R + ((((7698080 + (this.<>1__state) << 2 & (7698080 + (this.<>1__state) << 2) >> 32) & ((int)this) >> (7698080 + (this.<>1__state) << 2 & (7698080 + (this.<>1__state) << 2) >> 32)) & (R8) >> R2) & ((int)R) & 3145845232) & (-128073500);
            (((((7698080 + (this.<>1__state) << 2 & (7698080 + (this.<>1__state) << 2) >> 32) & ((int)this) >> (7698080 + (this.<>1__state) << 2 & (7698080 + (this.<>1__state) << 2) >> 32)) & (R8) >> R2) & ((int)R + ((((7698080 + (this.<>1__state) << 2 & (7698080 + (this.<>1__state) << 2) >> 32) & ((int)this) >> (7698080 + (this.<>1__state) << 2 & (7698080 + (this.<>1__state) << 2) >> 32)) & (R8) >> R2) & ((int)R) & 3145845232 = ((((((7698080 + (this.<>1__state) << 2 & (7698080 + (this.<>1__state) << 2) >> 32) & ((int)this) >> (7698080 + (this.<>1__state) << 2 & (7698080 + (this.<>1__state) << 2) >> 32)) & (R8) >> R2) & ((int)R + ((((7698080 + (this.<>1__state) << 2 & (7698080 + (this.<>1__state) << 2) >> 32) & ((int)this) >> (7698080 + (this.<>1__state) << 2 & (7698080 + (this.<>1__state) << 2) >> 32)) & (R8) >> R2) & ((int)R) & 3145845232) * val_31;
        }
        
        this.<>1__state = 0;
        UnityEngine.WaitForSeconds val_2 = null;
        val_33 = val_2;
        val_2 = new UnityEngine.WaitForSeconds(seconds:  null);
        val_31 = 1;
        this.<>1__state = val_31;
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
