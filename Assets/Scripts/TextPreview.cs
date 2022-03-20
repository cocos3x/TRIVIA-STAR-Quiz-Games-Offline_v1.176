using UnityEngine;
public class TextPreview : MonoBehaviour
{
    // Fields
    public const string ON_DRAG_BEGIN = "OnDragBegin";
    public const string ON_FADE_OUT_BEGIN = "OnFadeOutBegin";
    public const string ON_FADE_OUT_COMPLETE = "OnFadeOutComplete";
    public const string ON_FADE_IN_BEGIN = "OnFadeInBegin";
    public UnityEngine.GameObject content;
    public UnityEngine.RectTransform backgroundRT;
    public UnityEngine.RectTransform textRT;
    public float extraBackgroundWidth;
    public System.Collections.Generic.List<string> tileStrings;
    public UnityEngine.UI.Text text;
    private bool useColors;
    private UnityEngine.Color answerColor;
    private UnityEngine.Color validColor;
    private UnityEngine.Color wrongColor;
    private UnityEngine.Color existColor;
    private UnityEngine.Color defaultColor;
    private bool useSprites;
    private UnityEngine.Sprite answerSprite;
    private UnityEngine.Sprite validSprite;
    private UnityEngine.Sprite wrongSprite;
    private UnityEngine.Sprite existSprite;
    private UnityEngine.Sprite defaultSprite;
    private UnityEngine.GameObject submitButton;
    private UnityEngine.GameObject denyButton;
    public static TextPreview instance;
    private UnityEngine.CanvasGroup canvasGroup;
    private UnityEngine.UI.Image backgroundImage;
    private bool isFading;
    
    // Methods
    private void Awake()
    {
        TextPreview.instance = this;
        object val_1 = this.content.GetComponent<System.Object>();
        this.canvasGroup = this.content;
        object val_2 = this.backgroundRT.GetComponent<System.Object>();
        this.backgroundImage = this.backgroundRT;
        if(this.submitButton != 0)
        {
                object val_4 = this.submitButton.GetComponent<System.Object>();
            UnityEngine.Events.UnityAction val_5 = new UnityEngine.Events.UnityAction(object:  -2069353536, method:  new IntPtr(2225579520));
            this.submitButton.AddListener(call:  162246656);
        }
        
        if(this.denyButton == 0)
        {
                return;
        }
        
        object val_7 = this.denyButton.GetComponent<System.Object>();
        UnityEngine.Events.UnityAction val_8 = new UnityEngine.Events.UnityAction(object:  -2069353536, method:  new IntPtr(2225588736));
        this.denyButton.AddListener(call:  162246656);
    }
    private void OnClick_SubmitButton()
    {
        if(LineDrawer.instance == 0)
        {
                return;
        }
        
        if(this.IsInvisibleOrFading() != false)
        {
                return;
        }
        
        LineDrawer.instance.EndDrag(checkAnswer:  true);
    }
    private void OnClick_DenyButton()
    {
        if(LineDrawer.instance == 0)
        {
                return;
        }
        
        if(this.IsInvisibleOrFading() != false)
        {
                return;
        }
        
        LineDrawer.instance.EndDrag(checkAnswer:  false);
    }
    private void Start()
    {
        this.canvasGroup.alpha = null;
        this.canvasGroup.blocksRaycasts = false;
        MainController val_1 = MainController.instance;
        UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  -2068979648, method:  new IntPtr(2225962624));
        4.AddListener(call:  162246656);
    }
    public void SetIndexes(System.Collections.Generic.List<int> indexes)
    {
        var val_4;
        System.Text.StringBuilder val_1 = new System.Text.StringBuilder();
        List.Enumerator<T> val_2 = GetEnumerator();
        label_7:
        bool val_3 = MoveNext();
        if(val_3 == false)
        {
            goto label_2;
        }
        
        if(val_3 <= val_4)
        {
                var val_12 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_12 = val_12 + (val_4 << 2);
        string val_5 = (0 + (val_4) << 2) + 16.ToUpper();
        System.Text.StringBuilder val_6 = Append(value:  (0 + (val_4) << 2) + 16);
        goto label_7;
        label_2:
        Dispose();
        object val_7 = this.textRT.GetComponent<System.Object>();
        UnityEngine.Vector2 val_8 = sizeDelta;
        UnityEngine.Vector2 val_11 = new UnityEngine.Vector2(x:  this.textRT + this.extraBackgroundWidth, y:  val_8.y);
        this.backgroundRT.sizeDelta = new UnityEngine.Vector2() {x = val_11.x, y = val_11.y};
    }
    public void SetActive(bool isActive, bool useButtons = False)
    {
        if(isActive != false)
        {
                if(this.text > 0)
        {
                0 = 1;
        }
        
        }
        
        this.content.SetActive(value:  true);
        if(this.submitButton != 0)
        {
                this.submitButton.SetActive(value:  isActive & useButtons);
        }
        
        if(this.denyButton == 0)
        {
                return;
        }
        
        this.denyButton.SetActive(value:  isActive & useButtons);
    }
    public void ClearText()
    {
        if(this.text == 0)
        {
            
        }
    
    }
    public void SetText(string textStr)
    {
        if(this.text == 0)
        {
            
        }
    
    }
    public string GetText()
    {
        if(this.text == 0)
        {
            
        }
    
    }
    public void SetAnswerColor()
    {
        if(this.useColors != false)
        {
                this.backgroundImage.color = new UnityEngine.Color() {r = mem[this.answerColor + (0)], g = mem[this.answerColor + (4)], b = mem[this.answerColor + (8)], a = ???};
        }
        
        if(this.useSprites == false)
        {
                return;
        }
        
        this.backgroundImage.sprite = this.answerSprite;
    }
    public void SetValidColor()
    {
        if(this.useColors != false)
        {
                this.backgroundImage.color = new UnityEngine.Color() {r = mem[this.validColor + (0)], g = mem[this.validColor + (4)], b = mem[this.validColor + (8)], a = ???};
        }
        
        if(this.useSprites == false)
        {
                return;
        }
        
        this.backgroundImage.sprite = this.validSprite;
    }
    public void SetWrongColor()
    {
        if(this.useColors != false)
        {
                this.backgroundImage.color = new UnityEngine.Color() {r = mem[this.wrongColor + (0)], g = mem[this.wrongColor + (4)], b = mem[this.wrongColor + (8)], a = ???};
        }
        
        if(this.useSprites == false)
        {
                return;
        }
        
        this.backgroundImage.sprite = this.wrongSprite;
    }
    public void SetDefaultColor()
    {
        if(this.useColors != false)
        {
                this.backgroundImage.color = new UnityEngine.Color() {r = mem[this.defaultColor + (0)], g = mem[this.defaultColor + (4)], b = mem[this.defaultColor + (8)], a = ???};
        }
        
        if(this.useSprites == false)
        {
                return;
        }
        
        this.backgroundImage.sprite = this.defaultSprite;
    }
    public void SetExistColor()
    {
        if(this.useColors != false)
        {
                this.backgroundImage.color = new UnityEngine.Color() {r = mem[this.existColor + (0)], g = mem[this.existColor + (4)], b = mem[this.existColor + (8)], a = ???};
        }
        
        if(this.useSprites == false)
        {
                return;
        }
        
        this.backgroundImage.sprite = this.existSprite;
    }
    public void FadeOut()
    {
        float val_1 = this.canvasGroup.alpha;
        if(this.canvasGroup == 0)
        {
                NotificationCenter val_2 = NotificationCenter.DefaultCenter;
            0.PostNotification(aSender:  0, aName:  -2067500288);
            NotificationCenter val_3 = NotificationCenter.DefaultCenter;
            0.PostNotification(aSender:  0, aName:  -2067500192);
            return;
        }
        
        this.isFading = true;
        this.canvasGroup.blocksRaycasts = false;
        NotificationCenter val_4 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  0, aName:  -2067500288);
        if(WordStreak.CurrentStreak > 1)
        {
                8326844 = 8326848;
        }
        
        DG.Tweening.Tweener val_6 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.canvasGroup, endValue:  this.canvasGroup, duration:  null);
        object val_7 = DG.Tweening.TweenSettingsExtensions.SetDelay<System.Object>(t:  this.canvasGroup, delay:  this.canvasGroup);
        DG.Tweening.TweenCallback val_8 = new DG.Tweening.TweenCallback(object:  -2067466864, method:  new IntPtr(2227475408));
        object val_9 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  this.canvasGroup, action:  190734336);
    }
    public void FadeIn()
    {
        this.isFading = false;
        int val_1 = DG.Tweening.DOTween.Kill(targetOrId:  this.canvasGroup, complete:  false);
        this.SetDefaultColor();
        this.canvasGroup.alpha = null;
        this.canvasGroup.blocksRaycasts = true;
        NotificationCenter val_2 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  0, aName:  -2067354288);
    }
    public bool IsInvisibleOrFading()
    {
        float val_1 = this.canvasGroup.alpha;
        if(this.canvasGroup == 0)
        {
                return true;
        }
        
        if(this.isFading == true)
        {
                this.isFading = 1;
        }
        
        return true;
    }
    private void OnLevelComplete()
    {
        this.SetActive(isActive:  false, useButtons:  false);
    }
    public TextPreview()
    {
        this.extraBackgroundWidth = 50f;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.tileStrings = null;
    }
    private void <FadeOut>b__42_0()
    {
        this.isFading = false;
        NotificationCenter val_1 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  0, aName:  -2067500192);
        this.ClearText();
    }

}
