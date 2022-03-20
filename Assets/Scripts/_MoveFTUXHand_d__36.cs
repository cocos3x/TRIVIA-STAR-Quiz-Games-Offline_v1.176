using UnityEngine;
private sealed class EmojiMatchUIController.<MoveFTUXHand>d__36 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public SLC.Minigames.EmojiMatch.EmojiMatchUIController <>4__this;
    private SLC.Minigames.EmojiMatch.EmojiMatchCardDisplay <targetCard>5__2;
    private UnityEngine.Vector3 <targetPosition>5__3;
    private UnityEngine.Vector3 <emojiPosition>5__4;
    private float <progress>5__5;
    private float <timeToMove>5__6;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public EmojiMatchUIController.<MoveFTUXHand>d__36(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_15;
        float val_18;
        int val_43;
        float val_44;
        float val_46;
        float val_47;
        SLC.Minigames.EmojiMatch.EmojiMatchCardDisplay val_50;
        object val_52;
        int val_53;
        if((this.<>1__state) <= 3)
        {
                var val_1 = 13753028 + (13753028 + (this.<>1__state) << 2);
            if((this.<>1__state) == 3)
        {
                13753028 + (this.<>1__state) << 2 = (13753028 + (this.<>1__state) << 2) & ((13753028 + (this.<>1__state) << 2) << (13753028 + (this.<>1__state) << 2));
            13753028 + (this.<>1__state) << 2 = (13753028 + (this.<>1__state) << 2) & ((IP) >> 32);
            13753028 + (this.<>1__state) << 2 = (13753028 + (this.<>1__state) << 2) & ((13753028 + (this.<>1__state) << 2) >> 2);
            mem2[0] = (((13753028 + (this.<>1__state) << 2 & (13753028 + (this.<>1__state) << 2) << 13753028 + (this.<>1__state) << 2) & (IP) >> 32) & ((int)((13753028 + (this.<>1__state) << 2 & (13753028 + (this.<>1__stat + IP;
        }
        
            val_43 = 1;
            this.<>1__state = val_43;
            this.<>2__current = 0;
            return (bool)val_43;
        }
        
        val_43 = 0;
        return (bool)val_43;
        label_14:
        UnityEngine.Transform val_4 = SB + 28.GetChild(index:  0);
        object val_5 = SB + 28.GetComponent<System.Object>();
        if((SB + 28 + 32) == )
        {
            goto label_12;
        }
        
        val_44 = 1;
        val_47 = 0f;
        if(val_44 < (SB + 28.childCount))
        {
            goto label_14;
        }
        
        goto label_15;
        label_12:
        UnityEngine.Transform val_26 = SB + 28.GetChild(index:  0);
        val_47 = SB + 28;
        label_15:
        if(val_47 == 0)
        {
                val_43 = 0;
            UnityEngine.Debug.LogError(message:  1093714128);
            return (bool)val_43;
        }
        
        object val_28 = mem[this.<targetPosition>5__3 + (0)].GetComponent<System.Object>();
        UnityEngine.Vector3 val_29 = GetLinePosition();
        object val_30 = val_47.GetComponent<System.Object>();
        UnityEngine.Vector3 val_31 = GetLinePosition();
        UnityEngine.GameObject val_32 = SB + 64.gameObject;
        val_46 = 0f;
        UnityEngine.Transform val_33 = SB + 64.transform;
        SB + 64.position = new UnityEngine.Vector3() {x = mem[this.<targetPosition>5__3 + (0)], y = mem[this.<targetPosition>5__3 + (4)], z = mem[this.<targetPosition>5__3 + (8)]};
        this.<progress>5__5 = val_46;
        this.<timeToMove>5__6 = 2f;
        val_47 = mem[SB + 68];
        val_47 = SB + 68;
        val_47.SetPositions(positions:  533912224);
        UnityEngine.GameObject val_34 = SB + 68.gameObject;
        SB + 68.SetActive(value:  true);
        val_50 = mem[this.<targetPosition>5__3 + (4)];
        if((mem[this.<targetPosition>5__3 + (4)] + 40) != 0)
        {
                UnityEngine.GameObject val_35 = SB + 68.gameObject;
            SB + 68.SetActive(value:  false);
            val_43 = 0;
            UnityEngine.GameObject val_36 = SB + 64.gameObject;
            SB + 64.SetActive(value:  false);
            return (bool)val_43;
        }
        
        val_44 = this.<timeToMove>5__6;
        val_47 = this.<progress>5__5;
        if((mem[this.<targetPosition>5__3 + (4)] + 40) >= 0)
        {
                mem2[0] = 0;
            SB + 64.enabled = false;
            UnityEngine.WaitForSeconds val_37 = null;
            val_52 = val_37;
            val_37 = new UnityEngine.WaitForSeconds(seconds:  val_44);
            val_53 = 3;
        }
        else
        {
                UnityEngine.Material val_38 = SB + 68.material;
            UnityEngine.Vector2 val_39 = mainTextureOffset;
            float val_44 = System.Math.Abs(val_15);
            UnityEngine.Material val_40 = SB + 68.material;
            UnityEngine.Vector2 val_41 = UnityEngine.Vector2.zero;
            SB + 68.mainTextureOffset = new UnityEngine.Vector2() {x = val_15, y = val_18};
            UnityEngine.WaitForFixedUpdate val_42 = null;
            val_52 = val_42;
            val_42 = new UnityEngine.WaitForFixedUpdate();
            val_53 = 2;
        }
        
        this.<>1__state = val_53;
        this.<>2__current = val_52;
        val_43 = 1;
        return (bool)val_43;
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
