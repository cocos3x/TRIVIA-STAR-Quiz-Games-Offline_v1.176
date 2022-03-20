using UnityEngine;
public class SpinKingEventButtonTag : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Image obtained_ring;
    private UnityEngine.GameObject no_new_spins_ring;
    private UnityEngine.GameObject max_tag;
    
    // Methods
    private void Awake()
    {
        PluginExtension.SetColorAlpha(graphic:  this.obtained_ring, a:  null);
    }
    public void ShowObtainedRing()
    {
        PluginExtension.SetColorAlpha(graphic:  this.obtained_ring, a:  null);
        DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
        DG.Tweening.Tweener val_2 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.obtained_ring, endValue:  null, duration:  null);
        DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.obtained_ring);
        DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  0, interval:  null);
        DG.Tweening.Tweener val_5 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.obtained_ring, endValue:  null, duration:  null);
        DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.obtained_ring);
    }
    public void ShowNoNewSpinsRing(bool show)
    {
        this.no_new_spins_ring.SetActive(value:  show);
    }
    public void ShowMaxTag(bool show)
    {
        this.max_tag.SetActive(value:  show);
    }
    public SpinKingEventButtonTag()
    {
    
    }

}
