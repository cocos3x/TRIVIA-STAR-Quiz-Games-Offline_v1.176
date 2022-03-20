using UnityEngine;
private sealed class GoalDisplayIcon.<>c__DisplayClass25_0
{
    // Fields
    public BlockPuzzleMagic.GoalDisplayIcon <>4__this;
    public int currentDisplayValue;
    
    // Methods
    public GoalDisplayIcon.<>c__DisplayClass25_0()
    {
    
    }
    internal void <RefreshUI>b__0()
    {
        string val_1 = this.currentDisplayValue.ToString();
        if(this.currentDisplayValue >= 1)
        {
                UnityEngine.Transform val_2 = this.<>4__this.label.transform;
            DG.Tweening.Tweener val_3 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.<>4__this.label, endValue:  null, duration:  null);
            return;
        }
        
        UnityEngine.GameObject val_4 = this.<>4__this.label.gameObject;
        this.<>4__this.label.SetActive(value:  false);
        UnityEngine.GameObject val_5 = this.<>4__this.checkmarkIcon.gameObject;
        this.<>4__this.checkmarkIcon.SetActive(value:  true);
        UnityEngine.Transform val_6 = this.<>4__this.checkmarkIcon.transform;
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.zero;
        this.<>4__this.checkmarkIcon.localScale = new UnityEngine.Vector3();
        UnityEngine.Transform val_8 = this.<>4__this.checkmarkIcon.transform;
        DG.Tweening.Tweener val_9 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.<>4__this.checkmarkIcon, endValue:  val_7.x, duration:  val_7.y);
        object val_10 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.<>4__this.checkmarkIcon, ease:  27);
    }

}
