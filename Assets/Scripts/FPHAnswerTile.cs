using UnityEngine;
public class FPHAnswerTile : MonoBehaviour
{
    // Fields
    private const float textTweenDuration = 0.3;
    private UnityEngine.UI.Text myText;
    private UnityEngine.UI.Image highlightBg;
    private char <myChar>k__BackingField;
    private bool displayingLetter;
    private DG.Tweening.Tween myTextTween;
    
    // Properties
    public char myChar { get; set; }
    
    // Methods
    public char get_myChar()
    {
        return (char)this.<myChar>k__BackingField;
    }
    private void set_myChar(char value)
    {
        this.<myChar>k__BackingField = value;
    }
    public void Setup(char myLetter, bool revealed = False)
    {
        int val_4;
        if(myLetter == ' ')
        {
                UnityEngine.GameObject val_1 = this.gameObject;
            UnityEngine.UI.LayoutElement val_2 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<UnityEngine.UI.LayoutElement>(gameObject:  -1656675104);
            this.alpha = null;
            return;
        }
        
        this.<myChar>k__BackingField = myLetter;
        if(revealed != false)
        {
                string val_3 = myLetter.ToString();
            val_4;
            return;
        }
        
        val_4 = System.String.alignConst;
    }
    public void DisplayLetter()
    {
        if(this.displayingLetter == true)
        {
                return;
        }
        
        this.displayingLetter = true;
        if(this.myTextTween != 0)
        {
                DG.Tweening.TweenExtensions.Kill(t:  this.myTextTween, complete:  false);
        }
        
        UnityEngine.Transform val_1 = this.myText.transform;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        this.myText.localScale = new UnityEngine.Vector3();
        UnityEngine.Transform val_3 = this.myText.transform;
        DG.Tweening.Tweener val_4 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.myText, endValue:  val_2.x, duration:  val_2.y);
        object val_5 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.myText, ease:  27);
        this.myTextTween = this.myText;
        string val_6 = this.<myChar>k__BackingField.ToString();
    }
    public void DisplayUnconfirmedLetter(char value)
    {
        var val_9;
        string val_1 = value.ToString();
        val_9 = 0;
        if((System.String.op_Equality(a:  this.myText, b:  -1656405786)) == true)
        {
                return;
        }
        
        if(this.myTextTween != 0)
        {
                val_9 = 0;
            DG.Tweening.TweenExtensions.Kill(t:  this.myTextTween, complete:  false);
        }
        
        UnityEngine.Transform val_3 = this.myText.transform;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
        this.myText.localScale = new UnityEngine.Vector3();
        UnityEngine.Transform val_5 = this.myText.transform;
        DG.Tweening.Tweener val_6 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.myText, endValue:  val_4.x, duration:  val_4.y);
        object val_7 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.myText, ease:  27);
        this.myTextTween = this.myText;
        string val_8 = value.ToString();
    }
    public void RemoveLetter()
    {
        this.displayingLetter = false;
        if(this.myTextTween != 0)
        {
                DG.Tweening.TweenExtensions.Kill(t:  this.myTextTween, complete:  false);
        }
        
        UnityEngine.Transform val_1 = this.myText.transform;
        DG.Tweening.Tweener val_2 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.myText, endValue:  null, duration:  null);
        DG.Tweening.TweenCallback val_3 = new DG.Tweening.TweenCallback(object:  -1656252064, method:  new IntPtr(2638690208));
        object val_4 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  this.myText, action:  190734336);
        this.myTextTween = this.myText;
    }
    public void Highlight(bool isVisible)
    {
        UnityEngine.GameObject val_1 = this.highlightBg.gameObject;
        this.highlightBg.SetActive(value:  isVisible);
    }
    public FPHAnswerTile()
    {
    
    }
    private void <RemoveLetter>b__12_0()
    {
        if(this.myText == 0)
        {
            
        }
    
    }

}
