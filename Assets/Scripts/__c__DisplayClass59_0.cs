using UnityEngine;
private sealed class RESRaidScreenMain.<>c__DisplayClass59_0
{
    // Fields
    public UnityEngine.ParticleSystem coinSpringEfx;
    public RestaurantRivals.RESRaidScreenMain <>4__this;
    public DG.Tweening.TweenCallback <>9__8;
    public DG.Tweening.TweenCallback <>9__9;
    public DG.Tweening.TweenCallback <>9__10;
    
    // Methods
    public RESRaidScreenMain.<>c__DisplayClass59_0()
    {
    
    }
    internal void <OnRaidXSpotClicked>b__0()
    {
        this.coinSpringEfx.Play();
    }
    internal void <OnRaidXSpotClicked>b__1()
    {
        UnityEngine.GameObject val_1 = this.<>4__this.raidSpotResult.gameObject;
        this.<>4__this.raidSpotResult.SetActive(value:  true);
        object val_2 = this.<>4__this.raidSpotResult.GetComponent<System.Object>();
        this.<>4__this.raidSpotResult.alpha = null;
        UnityEngine.Transform val_3 = this.<>4__this.raidSpotResult.transform;
        this.<>4__this.raidSpotResult.localPosition = new UnityEngine.Vector3() {x = mem[this.<>4__this.raidSpotResultOriginalPosition + (0)], y = mem[this.<>4__this.raidSpotResultOriginalPosition + (4)], z = mem[this.<>4__this.raidSpotResultOriginalPosition + (8)]};
    }
    internal void <OnRaidXSpotClicked>b__2()
    {
        this.<>4__this.ToggleRaidXButtonsActive(active:  true);
    }
    internal void <OnRaidXSpotClicked>b__3()
    {
        DG.Tweening.TweenCallback val_8;
        UnityEngine.GameObject val_1 = this.<>4__this.raidSpotResult.gameObject;
        if((this.<>4__this.raidSpotResult.activeSelf) == false)
        {
                return;
        }
        
        if((this.<>4__this.raidSpotResultScalTween) != 0)
        {
                return;
        }
        
        UnityEngine.Transform val_3 = R4 + 12 + 76.transform;
        DG.Tweening.Tweener val_4 = DG.Tweening.ShortcutExtensions.DOScale(target:  R4 + 12 + 76, endValue:  null, duration:  null);
        val_8 = mem[R4 + 16];
        val_8 = R4 + 16;
        if(val_8 == 0)
        {
                val_8 = null;
            val_8 = new DG.Tweening.TweenCallback(object:  R4, method:  new IntPtr(615761904));
            mem2[0] = val_8;
        }
        
        object val_6 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  R4 + 12 + 76, action:  190734336);
        mem2[0] = R4 + 12 + 76;
    }
    internal void <OnRaidXSpotClicked>b__8()
    {
        this.<>4__this.raidSpotResultScalTween = 0;
    }
    internal void <OnRaidXSpotClicked>b__4()
    {
        DG.Tweening.TweenCallback val_8;
        UnityEngine.GameObject val_1 = this.<>4__this.raidSpotResult.gameObject;
        if((this.<>4__this.raidSpotResult.activeSelf) == false)
        {
                return;
        }
        
        if((this.<>4__this.raidSpotResultMoveTween) != 0)
        {
                return;
        }
        
        UnityEngine.Transform val_3 = this.<>4__this.raidSpotResult.transform;
        UnityEngine.Vector3 val_4 = position;
        DG.Tweening.Tweener val_5 = DG.Tweening.ShortcutExtensions.DOMove(target:  this.<>4__this.raidSpotResult, endValue:  new UnityEngine.Vector3(), duration:  val_4.x, snapping:  true);
        val_8 = this.<>9__9;
        if(val_8 == 0)
        {
                val_8 = null;
            val_8 = new DG.Tweening.TweenCallback(object:  616073392, method:  new IntPtr(616048368));
            this.<>9__9 = val_8;
        }
        
        object val_7 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  this.<>4__this.raidSpotResult, action:  190734336);
        this.<>4__this.raidSpotResultMoveTween = this.<>4__this.raidSpotResult;
    }
    internal void <OnRaidXSpotClicked>b__9()
    {
        this.<>4__this.raidSpotResultMoveTween = 0;
    }
    internal void <OnRaidXSpotClicked>b__5()
    {
        DG.Tweening.TweenCallback val_8;
        UnityEngine.GameObject val_1 = this.<>4__this.raidSpotResult.gameObject;
        if((this.<>4__this.raidSpotResult.activeSelf) == false)
        {
                return;
        }
        
        if((this.<>4__this.raidSpotResultAlphaTween) != 0)
        {
                return;
        }
        
        object val_3 = R4 + 12 + 76.GetComponent<System.Object>();
        DG.Tweening.Tweener val_4 = DG.Tweening.ShortcutExtensions46.DOFade(target:  R4 + 12 + 76, endValue:  null, duration:  null);
        val_8 = mem[R4 + 24];
        val_8 = R4 + 24;
        if(val_8 == 0)
        {
                val_8 = null;
            val_8 = new DG.Tweening.TweenCallback(object:  R4, method:  new IntPtr(616334832));
            mem2[0] = val_8;
        }
        
        object val_6 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  R4 + 12 + 76, action:  190734336);
        mem2[0] = R4 + 12 + 76;
    }
    internal void <OnRaidXSpotClicked>b__10()
    {
        this.<>4__this.raidSpotResultAlphaTween = 0;
    }
    internal void <OnRaidXSpotClicked>b__6()
    {
        this.<>4__this.raidSeq = 0;
        this.<>4__this.RefreshSubtitle();
    }
    internal void <OnRaidXSpotClicked>b__7()
    {
        this.<>4__this.raidSeq = 0;
    }

}
