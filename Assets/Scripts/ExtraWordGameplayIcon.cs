using UnityEngine;
public class ExtraWordGameplayIcon : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Text wordCountLabel;
    private UnityEngine.UI.Text descriptionLabel;
    private bool isWordCountDisplayed;
    
    // Methods
    private void Start()
    {
        var val_3;
        System.Action<System.Int32> val_1 = new System.Action<System.Int32>(object:  -2091722432, method:  new IntPtr(2203219840));
        System.Delegate val_2 = System.Delegate.Combine(a:  ExtraWord.GAMETYPE_CATEGORY_LEVELS + 84, b:  7401472);
        val_3 = ExtraWord.GAMETYPE_CATEGORY_LEVELS + 84;
        if(val_3 != 0)
        {
                if(val_3 == null)
        {
            goto label_4;
        }
        
        }
        
        val_3 = 0;
        label_4:
        ExtraWord.GAMETYPE_CATEGORY_LEVELS.__unknownFiledOffset_54 = val_3;
        this.OnExtraWordAdded(totalCount:  ExtraWord.GAMETYPE_CATEGORY_LEVELS + 16 + 12);
    }
    public void SetLabel(string str)
    {
        if((str.Equals(value:  1254115712)) == false)
        {
                "" = str;
        }
        
        if(this.wordCountLabel == 0)
        {
            
        }
    
    }
    private void OnExtraWordAdded(int totalCount)
    {
        float val_17;
        float val_18;
        float val_19;
        UnityEngine.UI.Text val_20;
        bool val_21;
        float val_22;
        val_20 = 35639148;
        if(totalCount >= 1)
        {
                string val_1 = totalCount.ToString();
            this.SetLabel(str:  -2091461320);
            if(this.isWordCountDisplayed != true)
        {
                return;
        }
        
            DG.Tweening.Sequence val_2 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Tweener val_3 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.descriptionLabel, endValue:  null, duration:  null);
            val_21 = true;
            val_22 = 1152921509932985248;
            object val_4 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.descriptionLabel, ease:  1);
            DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.Insert(s:  0, atPosition:  null, t:  0);
            DG.Tweening.Tweener val_6 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.wordCountLabel, endValue:  null, duration:  null);
            object val_7 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.wordCountLabel, ease:  1);
            DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.Insert(s:  0, atPosition:  null, t:  1049247089);
            val_20 = this.wordCountLabel;
            UnityEngine.Transform val_9 = val_20.transform;
            DG.Tweening.Tweener val_10 = DG.Tweening.ShortcutExtensions.DOScale(target:  val_20, endValue:  null, duration:  null);
            object val_11 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  val_20, ease:  1);
            DG.Tweening.Sequence val_12 = DG.Tweening.TweenSettingsExtensions.Insert(s:  0, atPosition:  null, t:  1052266988);
            this.isWordCountDisplayed = val_21;
            return;
        }
        
        UnityEngine.Color val_13 = color;
        this.wordCountLabel.color = new UnityEngine.Color() {r = R8, g = SB, b = SL, a = 0f};
        UnityEngine.Transform val_14 = this.wordCountLabel.transform;
        UnityEngine.Vector3 val_15 = new UnityEngine.Vector3(x:  val_13.r, y:  val_13.g, z:  val_13.b);
        this.wordCountLabel.localScale = new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z};
        UnityEngine.Color val_16 = color;
        val_21 = val_17;
        val_22 = val_19;
        this.descriptionLabel.color = new UnityEngine.Color() {r = val_21, g = val_18, b = val_22, a = 1f};
        this.isWordCountDisplayed = false;
    }
    public ExtraWordGameplayIcon()
    {
    
    }

}
