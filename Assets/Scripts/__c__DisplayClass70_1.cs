using UnityEngine;
private sealed class RaidMadnessEventHandler.<>c__DisplayClass70_1
{
    // Fields
    public UnityEngine.UI.Image icon;
    public DG.Tweening.Sequence seq;
    public RaidMadnessEventHandler.<>c__DisplayClass70_0 CS$<>8__locals1;
    
    // Methods
    public RaidMadnessEventHandler.<>c__DisplayClass70_1()
    {
    
    }
    internal void <DoLevelCompleteEventProgressAnimation>b__1()
    {
        RaidMadnessEventHandler.<>c__DisplayClass70_0 val_4;
        this.CS$<>8__locals1.<>4__this.<ProgressDisplayPoints>k__BackingField = 0;
        val_4 = this.CS$<>8__locals1;
        if((this.CS$<>8__locals1) != 0)
        {
            goto label_3;
        }
        
        val_4 = this.CS$<>8__locals1;
        if(val_4 == 0)
        {
            goto label_4;
        }
        
        label_3:
        this.CS$<>8__locals1.<>4__this.<EventButtonDisplayPoints>k__BackingField = this.CS$<>8__locals1.<>4__this;
        DG.Tweening.Tweener val_1 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.CS$<>8__locals1.eventProgressUI.canvasGroup, endValue:  null, duration:  null);
        this.CS$<>8__locals1.<>4__this.UpdateProgress();
        UnityEngine.GameObject val_2 = this.CS$<>8__locals1.eventButton.efxUpdate.gameObject;
        this.CS$<>8__locals1.eventButton.efxUpdate.SetActive(value:  true);
        this.CS$<>8__locals1.eventButton.efxUpdate.Play();
        UnityEngine.GameObject val_3 = this.icon.gameObject;
        UnityEngine.Object.Destroy(obj:  this.icon);
        return;
        label_4:
    }
    internal bool <DoLevelCompleteEventProgressAnimation>b__2()
    {
        if(this.seq != 0)
        {
                return false;
        }
        
        return false;
    }

}
