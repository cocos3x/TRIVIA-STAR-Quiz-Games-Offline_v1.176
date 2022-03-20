using UnityEngine;
private sealed class WFOMysteryChestDisplay.<>c__DisplayClass97_0
{
    // Fields
    public WordForest.FtuxId ftuxId;
    public WordForest.WFOMysteryChestDisplay <>4__this;
    public WordForest.WFOPlayer player;
    public UnityEngine.Events.UnityAction <>9__1;
    public UnityEngine.Events.UnityAction <>9__2;
    public UnityEngine.Events.UnityAction <>9__3;
    
    // Methods
    public WFOMysteryChestDisplay.<>c__DisplayClass97_0()
    {
    
    }
    internal void <ShowFtux>b__0()
    {
        WordForest.WFOMysteryChestDisplay val_19;
        WordForest.WFOPlayer val_20;
        int val_21;
        UnityEngine.Events.UnityAction val_26;
        var val_29;
        var val_30;
        WordForest.FtuxId val_19 = this.ftuxId;
        val_19 = val_19 - 8;
        if(val_19 > 3)
        {
                return;
        }
        
        var val_1 = 14109888 + (14109888 + ((this.ftuxId - 8)) << 2);
        if(val_19 == 3)
        {
                14109888 + ((this.ftuxId - 8)) << 2 = (14109888 + ((this.ftuxId - 8)) << 2) & ((14109888 + ((this.ftuxId - 8)) << 2) << (14109888 + ((this.ftuxId - 8)) << 2));
            14109888 + ((this.ftuxId - 8)) << 2 = (14109888 + ((this.ftuxId - 8)) << 2) & (((int)R8) >> 2);
            14109888 + ((this.ftuxId - 8)) << 2 = (14109888 + ((this.ftuxId - 8)) << 2) & 82016348;
            14109888 + ((this.ftuxId - 8)) << 2 = (14109888 + ((this.ftuxId - 8)) << 2) & ((R8) >> 14109888);
        }
        
        val_19 = this.<>4__this;
        if((this.<>4__this) != 0)
        {
            goto label_2;
        }
        
        val_19 = this.<>4__this;
        if(val_19 == 0)
        {
            goto label_72;
        }
        
        label_2:
        if(val_19 == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        UnityEngine.Vector3 val_2 = position;
        UnityEngine.Vector2 val_3 = new UnityEngine.Vector2(x:  val_2.x, y:  val_2.y);
        this.<>4__this.ftuxTooltip.Reposition(worldPos:  new UnityEngine.Vector3(), anchoredOffset:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y});
        this.<>4__this.ftuxTooltip.SetText(description:  327922960);
        val_20 = this.player;
        if(val_20 != 0)
        {
                val_21 = MonoExtensions.SetBit(value:  this.player.tutorialCompleted, bit:  8);
        }
        else
        {
                val_20 = 312;
            val_21 = MonoExtensions.SetBit(value:  132, bit:  8);
        }
        
        mem[312] = val_21;
        val_26 = this.<>9__2;
        if(val_26 == 0)
        {
                val_26 = null;
            val_26 = new UnityEngine.Events.UnityAction(object:  328065392, method:  new IntPtr(327987120));
            this.<>9__2 = val_26;
        }
        
        this.<>4__this.ftuxTooltip.SetupButton(text:  86399904, action:  162246656);
        UnityEngine.Transform val_15 = this.<>4__this.ftuxRoot.transform;
        if((this.<>4__this.ftuxRoot) == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        this.<>4__this.ftuxRoot.parent = 2621443;
        UnityEngine.Transform val_16 = this.<>4__this.ftuxTooltip.transform;
        val_29 = this.<>4__this.ftuxTooltip;
        if((this.<>4__this.ftuxTooltip) == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_30 = 2621443;
        val_29.parent = 2621443;
        UnityEngine.Transform val_17 = this.<>4__this.ftuxRoot.transform;
        this.<>4__this.ftuxRoot.SetAsFirstSibling();
        UnityEngine.Transform val_18 = this.<>4__this.ftuxTooltip.transform;
        this.<>4__this.ftuxTooltip.SetAsLastSibling();
        return;
        label_72:
    }
    internal void <ShowFtux>b__1()
    {
        UnityEngine.Transform val_1 = this.<>4__this.ftuxRoot.transform;
        UnityEngine.Transform val_2 = this.<>4__this.transform;
        this.<>4__this.ftuxRoot.parent = this.<>4__this;
        UnityEngine.Transform val_3 = this.<>4__this.ftuxTooltip.transform;
        UnityEngine.Transform val_4 = this.<>4__this.ftuxRoot.transform;
        this.<>4__this.ftuxTooltip.parent = this.<>4__this.ftuxRoot;
        this.<>4__this.ftuxRoot.SetActive(value:  false);
        this.<>4__this.ToggleTapToOpenLabel(isVisible:  true);
        RaidAttackScreenUI.ShowAttackScreen();
    }
    internal void <ShowFtux>b__2()
    {
        UnityEngine.Transform val_1 = this.<>4__this.ftuxRoot.transform;
        UnityEngine.Transform val_2 = this.<>4__this.transform;
        this.<>4__this.ftuxRoot.parent = this.<>4__this;
        UnityEngine.Transform val_3 = this.<>4__this.ftuxTooltip.transform;
        UnityEngine.Transform val_4 = this.<>4__this.ftuxRoot.transform;
        this.<>4__this.ftuxTooltip.parent = this.<>4__this.ftuxRoot;
        this.<>4__this.ftuxRoot.SetActive(value:  false);
        this.<>4__this.ToggleTapToOpenLabel(isVisible:  true);
        this.<>4__this.OnFtuxButtonClicked();
    }
    internal void <ShowFtux>b__3()
    {
        UnityEngine.Transform val_1 = this.<>4__this.ftuxRoot.transform;
        UnityEngine.Transform val_2 = this.<>4__this.transform;
        this.<>4__this.ftuxRoot.parent = this.<>4__this;
        UnityEngine.Transform val_3 = this.<>4__this.ftuxTooltip.transform;
        UnityEngine.Transform val_4 = this.<>4__this.ftuxRoot.transform;
        this.<>4__this.ftuxTooltip.parent = this.<>4__this.ftuxRoot;
        this.<>4__this.ftuxRoot.SetActive(value:  false);
        this.<>4__this.ToggleTapToOpenLabel(isVisible:  true);
        RaidAttackScreenUI.ShowRaidScreen();
    }

}
