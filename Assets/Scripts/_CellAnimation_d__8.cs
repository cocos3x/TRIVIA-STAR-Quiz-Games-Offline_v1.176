using UnityEngine;
private sealed class WGMegaHintController.<CellAnimation>d__8 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public WGMegaHintController <>4__this;
    public Cell chosenCell;
    private UnityEngine.Transform <letter>5__2;
    private UnityEngine.Vector3 <startPos>5__3;
    private UnityEngine.Vector3 <randomVec>5__4;
    private float <growDuration>5__5;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WGMegaHintController.<CellAnimation>d__8(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_34;
        float val_35;
        var val_36;
        float val_38;
        float val_39;
        float val_40;
        WGMegaHintController val_48;
        int val_49;
        var val_50;
        float val_51;
        float val_52;
        var val_53;
        float val_54;
        float val_55;
        var val_56;
        float val_57;
        UnityEngine.Vector3 val_58;
        float val_59;
        float val_60;
        float val_61;
        float val_62;
        object val_63;
        float val_64;
        float val_65;
        var val_67;
        float val_68;
        val_48 = this.<>4__this;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        val_49 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool)val_49;
        }
        
        this.<>1__state = 0;
        this.<>4__this.timeProgress = 0f;
        UnityEngine.Transform val_1 = this.chosenCell.letterGroup.transform;
        this.<letter>5__2 = this.chosenCell.letterGroup;
        UnityEngine.Transform val_2 = this.chosenCell.letterGroup.transform;
        UnityEngine.Vector3 val_3 = position;
        UnityEngine.Vector3 val_4 = UnityEngine.Random.insideUnitSphere;
        this.<randomVec>5__4.Normalize();
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = -3.720315E+28f, y = mem[this.<randomVec>5__4 + (0)], z = mem[this.<randomVec>5__4 + (4)]}, d:  val_4.x);
        val_50 = 0;
        UnityEngine.Transform val_8 = this.<letter>5__2.transform;
        UnityEngine.Vector3 val_9 = position;
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = -3.72031E+28f}, b:  new UnityEngine.Vector3() {y = this.<randomVec>5__4, z = mem[this.<randomVec>5__4 + (8)]});
        this.<letter>5__2.position = new UnityEngine.Vector3();
        UnityEngine.GameObject val_11 = this.<letter>5__2.gameObject;
        this.<letter>5__2.SetActive(value:  true);
        goto label_16;
        label_1:
        this.<>1__state = 0;
        if(val_48 == 0)
        {
            goto label_17;
        }
        
        val_52 = this.<>4__this.timeProgress;
        float val_12 = UnityEngine.Time.deltaTime;
        val_53 = 0;
        val_54 = this.<>4__this.timeProgress;
        goto label_18;
        label_2:
        this.<>1__state = 0;
        if(val_48 != 0)
        {
                val_55 = this.<>4__this.timeProgress;
            float val_13 = UnityEngine.Time.deltaTime;
            val_56 = 0;
            val_57 = this.<>4__this.timeProgress;
        }
        else
        {
                val_57 = 32;
            val_55 = 1.171481E-37f;
            float val_14 = UnityEngine.Time.deltaTime;
            val_56 = 0;
        }
        
        float val_15 = val_56 + val_55;
        mem[32] = val_15;
        UnityEngine.Transform val_16 = this.<letter>5__2.transform;
        val_58 = this.<startPos>5__3;
        if(val_48 != 0)
        {
                val_62 = mem[32];
        }
        else
        {
                val_62 = mem[32];
            val_61 = mem[this.<randomVec>5__4 + (8)];
            val_60 = mem[this.<randomVec>5__4 + (4)];
            val_59 = mem[this.<randomVec>5__4 + (0)];
        }
        
        val_61 = val_61;
        val_60 = val_60;
        val_59 = val_59;
        val_15 = val_62 / (this.<>4__this.TimePerAnim);
        UnityEngine.Vector3 val_17 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = -3.720317E+28f, y = val_59, z = val_60}, b:  new UnityEngine.Vector3() {x = val_61, y = val_58}, t:  val_15);
        this.<letter>5__2.position = new UnityEngine.Vector3();
        label_16:
        if((this.<letter>5__2) < 0)
        {
            goto label_27;
        }
        
        val_58 = 0f;
        UnityEngine.Transform val_18 = this.<letter>5__2.transform;
        val_64 = mem[this.<startPos>5__3 + (4)];
        this.<letter>5__2.position = new UnityEngine.Vector3() {x = mem[this.<startPos>5__3 + (0)], y = val_64, z = mem[this.<startPos>5__3 + (8)]};
        this.<>4__this.timeProgress = val_58;
        this.<growDuration>5__5 = 0.3f;
        goto label_30;
        label_27:
        UnityEngine.WaitForEndOfFrame val_19 = null;
        val_63 = val_19;
        val_19 = new UnityEngine.WaitForEndOfFrame();
        val_49 = 1;
        this.<>1__state = val_49;
        this.<>2__current = val_63;
        return (bool)val_49;
        label_17:
        val_54 = 32;
        val_52 = mem[32];
        float val_20 = UnityEngine.Time.deltaTime;
        val_53 = 0;
        label_18:
        val_58 = val_48;
        mem[32] = val_53 + val_52;
        UnityEngine.Transform val_22 = this.chosenCell.transform;
        UnityEngine.Vector3 val_23 = UnityEngine.Random.insideUnitSphere;
        UnityEngine.Vector3 val_24 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = -3.720318E+28f}, d:  val_23.x);
        UnityEngine.Vector3 val_25 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = -3.720315E+28f, y = mem[this.<startPos>5__3 + (0)], z = mem[this.<startPos>5__3 + (4)]}, b:  new UnityEngine.Vector3() {x = mem[this.<startPos>5__3 + (8)]});
        this.chosenCell.position = new UnityEngine.Vector3();
        val_48 = val_58;
        if(val_58 != 0)
        {
                val_65 = this.<>4__this.TimePerAnim;
        }
        else
        {
                val_65 = 0f;
        }
        
        val_65 = val_65 / (this.<>4__this.timePerSecondary);
        UnityEngine.Transform val_26 = this.chosenCell.transform;
        if(this.chosenCell < 0)
        {
                val_50 = 0;
            UnityEngine.Vector3 val_28 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_29 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_30 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = -3.720315E+28f}, d:  val_29.x);
            val_67 = val_54;
            val_68 = (this.<>4__this.timePerSecondary) * (this.<growDuration>5__5);
        }
        else
        {
                val_50 = 0;
            UnityEngine.Vector3 val_31 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_32 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = -3.720318E+28f}, d:  val_31.x);
            UnityEngine.Vector3 val_33 = UnityEngine.Vector3.one;
            val_67 = val_54;
            val_68 = this.<>4__this.timePerSecondary;
        }
        
        val_68 = val_67 / val_68;
        val_51 = val_34;
        val_63 = val_36;
        UnityEngine.Vector3 val_37 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = -3.720312E+28f}, b:  new UnityEngine.Vector3() {y = val_35, z = val_51}, t:  val_68);
        val_64 = val_39;
        this.chosenCell.localScale = new UnityEngine.Vector3() {x = val_38, y = val_64, z = val_40};
        label_30:
        if(this.chosenCell >= 0)
        {
                UnityEngine.Transform val_41 = this.chosenCell.transform;
            UnityEngine.Vector3 val_42 = UnityEngine.Vector3.zero;
            this.chosenCell.eulerAngles = new UnityEngine.Vector3();
            val_58 = 0;
            UnityEngine.Transform val_43 = this.chosenCell.transform;
            this.chosenCell.position = new UnityEngine.Vector3() {x = mem[this.<startPos>5__3 + (0)], y = mem[this.<startPos>5__3 + (4)], z = mem[this.<startPos>5__3 + (8)]};
            UnityEngine.Transform val_44 = this.chosenCell.transform;
            UnityEngine.Vector3 val_45 = UnityEngine.Vector3.one;
            this.chosenCell.localScale = new UnityEngine.Vector3();
            val_49 = 0f;
            UnityEngine.Transform val_46 = this.<letter>5__2.transform;
            val_51 = this.<startPos>5__3;
            val_63 = this.<letter>5__2;
            val_63.position = new UnityEngine.Vector3() {x = val_51, y = mem[this.<startPos>5__3 + (8)], z = -3.723167E+28f};
            this.<>4__this.timeProgress = val_49;
            return (bool)val_49;
        }
        
        this.<>1__state = 2;
        this.<>2__current = new UnityEngine.WaitForEndOfFrame();
        val_49 = 1;
        return (bool)val_49;
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
