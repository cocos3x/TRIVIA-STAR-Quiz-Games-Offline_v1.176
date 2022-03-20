using UnityEngine;
private sealed class WPTLetterTile.<>c__DisplayClass46_1
{
    // Fields
    public float durationFadeOut;
    public UnityEngine.UI.Image outgoingImage;
    public WordPets.WPTLetterTile.<>c__DisplayClass46_0 CS$<>8__locals1;
    
    // Methods
    public WPTLetterTile.<>c__DisplayClass46_1()
    {
    
    }
    internal void <ToggleSelection>b__0()
    {
        float val_2;
        if((this.CS$<>8__locals1) != 0)
        {
            goto label_2;
        }
        
        this.CS$<>8__locals1 = this.CS$<>8__locals1;
        if((this.CS$<>8__locals1) == 0)
        {
            goto label_3;
        }
        
        label_2:
        if((this.CS$<>8__locals1.isSelected) == false)
        {
                80 = 72;
        }
        
        this.CS$<>8__locals1.<>4__this.balloonText.font = this.CS$<>8__locals1.<>4__this.normalFontRegular;
        UnityEngine.Color val_1 = UnityEngine.Color.white;
        float val_4 = 0.5f;
        val_4 = this.durationFadeOut * val_4;
        DG.Tweening.Tweener val_3 = DG.Tweening.ShortcutExtensions46.DOColor(target:  this.CS$<>8__locals1.<>4__this.balloonText, endValue:  new UnityEngine.Color() {a = val_2}, duration:  val_4);
        return;
        label_3:
    }
    internal void <ToggleSelection>b__1()
    {
        this.outgoingImage.enabled = false;
    }

}
