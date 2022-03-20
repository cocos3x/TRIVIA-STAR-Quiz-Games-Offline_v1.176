using UnityEngine;
public class FPHGameplayTile : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Text revealedLetter;
    private UnityEngine.UI.Image revealedTileBackground;
    
    // Methods
    public void InitTile(string letter)
    {
        UnityEngine.GameObject val_1 = this.revealedTileBackground.gameObject;
        this.revealedTileBackground.SetActive(value:  false);
        if(this.revealedLetter == 0)
        {
            
        }
    
    }
    public void RevealLetter()
    {
        twelvegigs.Autopilot.WUTAutopilotGameplay val_1 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<twelvegigs.Autopilot.WUTAutopilotGameplay>(child:  this.revealedTileBackground);
        this.revealedTileBackground.alpha = null;
        UnityEngine.GameObject val_2 = this.revealedTileBackground.gameObject;
        this.revealedTileBackground.SetActive(value:  true);
        object val_3 = this.revealedTileBackground.GetComponent<System.Object>();
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
        this.revealedTileBackground.localScale = new UnityEngine.Vector3();
        DG.Tweening.Tweener val_5 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.revealedTileBackground, endValue:  val_4.x, duration:  val_4.y);
        object val_6 = this.revealedTileBackground.GetComponent<System.Object>();
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.one;
        DG.Tweening.Tweener val_8 = DG.Tweening.ShortcutExtensions.DOPunchScale(target:  this.revealedTileBackground, punch:  new UnityEngine.Vector3(), duration:  val_7.x, vibrato:  1053609165, elasticity:  val_7.y);
    }
    public FPHGameplayTile()
    {
    
    }

}
