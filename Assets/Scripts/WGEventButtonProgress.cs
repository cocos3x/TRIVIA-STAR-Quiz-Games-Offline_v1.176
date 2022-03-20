using UnityEngine;
public class WGEventButtonProgress : WGEventButtonV2
{
    // Methods
    public override void Refresh()
    {
        if(this == 0)
        {
                return;
        }
        
        if(R4 == 0)
        {
            
        }
    
    }
    public override void ShowIntroAnimation()
    {
        R5.alpha = null;
        DG.Tweening.Tweener val_1 = DG.Tweening.ShortcutExtensions46.DOFade(target:  R5, endValue:  null, duration:  null);
    }
    public WGEventButtonProgress()
    {
        val_1 = new UnityEngine.MonoBehaviour();
    }

}
