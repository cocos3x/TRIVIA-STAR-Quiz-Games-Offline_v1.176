using UnityEngine;

namespace SLC.Wordlicious
{
    public class WOLTextPreview : MonoSingleton<SLC.Wordlicious.WOLTextPreview>
    {
        // Fields
        public const string ON_WOL_DRAG_BEGIN = "OnWolDragBegin";
        public UnityEngine.GameObject content;
        public UnityEngine.RectTransform backgroundRT;
        public UnityEngine.RectTransform textRT;
        public float extraBackgroundWidth;
        public System.Collections.Generic.List<string> tileStrings;
        public UnityEngine.UI.Text text;
        private UnityEngine.GameObject submitButton;
        private UnityEngine.GameObject denyButton;
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
        private UnityEngine.CanvasGroup canvasGroup;
        private UnityEngine.UI.Image backgroundImage;
        private bool isFading;
        private bool isHintActive;
        private string hintLetters;
        
        // Methods
        private void Start()
        {
            this.canvasGroup.alpha = null;
        }
        public override void InitMonoSingleton()
        {
            object val_1 = this.content.GetComponent<System.Object>();
            this.canvasGroup = this.content;
            object val_2 = this.backgroundRT.GetComponent<System.Object>();
            this.backgroundImage = this.backgroundRT;
            if(this.submitButton != 0)
            {
                    object val_4 = this.submitButton.GetComponent<System.Object>();
                UnityEngine.Events.UnityAction val_5 = new UnityEngine.Events.UnityAction(object:  722251136, method:  new IntPtr(722216896));
                this.submitButton.AddListener(call:  162246656);
            }
            
            if(this.denyButton == 0)
            {
                    return;
            }
            
            object val_7 = this.denyButton.GetComponent<System.Object>();
            UnityEngine.Events.UnityAction val_8 = new UnityEngine.Events.UnityAction(object:  722251136, method:  new IntPtr(722226112));
            this.denyButton.AddListener(call:  162246656);
        }
        private void OnClick_SubmitButton()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(722363712 == 0)
            {
                    return;
            }
            
            if(this.IsInvisibleOrFading() != false)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            EndDrag(checkAnswer:  true);
        }
        private void OnClick_DenyButton()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(722363712 == 0)
            {
                    return;
            }
            
            if(this.IsInvisibleOrFading() != false)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            EndDrag(checkAnswer:  false);
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
        public void SetIndexes(System.Collections.Generic.List<int> indexes)
        {
            var val_4;
            string val_14;
            List.Enumerator<T> val_2 = GetEnumerator();
            label_7:
            bool val_3 = MoveNext();
            if(val_3 == false)
            {
                goto label_2;
            }
            
            if(val_3 <= val_4)
            {
                    var val_14 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_14 = val_14 + (val_4 << 2);
            string val_5 = (0 + (val_4) << 2) + 16.ToUpper();
            System.Text.StringBuilder val_6 = Append(value:  (0 + (val_4) << 2) + 16);
            goto label_7;
            label_2:
            Dispose();
            val_14 = new System.Text.StringBuilder();
            if(this.isHintActive != false)
            {
                    if((this.hintLetters.StartsWith(value:  24121344)) == true)
            {
                    val_14 = this.hintLetters;
            }
            
            }
            
            object val_8 = this.textRT.GetComponent<System.Object>();
            UnityEngine.Vector2 val_9 = sizeDelta;
            UnityEngine.Vector2 val_12 = new UnityEngine.Vector2(x:  this.textRT + this.extraBackgroundWidth, y:  val_9.y);
            this.backgroundRT.sizeDelta = new UnityEngine.Vector2() {x = val_12.x, y = val_12.y};
            NotificationCenter val_13 = NotificationCenter.DefaultCenter;
            0.PostNotification(aSender:  722769792, aName:  701318400);
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
        public void SetHint(string hintLetters)
        {
            this.hintLetters = hintLetters;
            this.isHintActive = true;
            object val_1 = this.textRT.GetComponent<System.Object>();
            UnityEngine.Vector2 val_2 = sizeDelta;
            UnityEngine.Vector2 val_5 = new UnityEngine.Vector2(x:  this.textRT + this.extraBackgroundWidth, y:  val_2.y);
            this.backgroundRT.sizeDelta = new UnityEngine.Vector2() {x = val_5.x, y = val_5.y};
        }
        public void ClearHint()
        {
            this.isHintActive = false;
            this.hintLetters = System.String.alignConst;
            this.ClearText();
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
                    return;
            }
            
            if((SLC.Wordlicious.WOLExtraWordFtuxWindow.<ShowingCurrentWordUI>k__BackingField) != false)
            {
                    return;
            }
            
            mem2[0] = 1;
            DG.Tweening.Tweener val_2 = DG.Tweening.ShortcutExtensions46.DOFade(target:  R4 + 152, endValue:  this.canvasGroup, duration:  null);
            object val_3 = DG.Tweening.TweenSettingsExtensions.SetDelay<System.Object>(t:  R4 + 152, delay:  this.canvasGroup);
            DG.Tweening.TweenCallback val_4 = new DG.Tweening.TweenCallback(object:  R4, method:  new IntPtr(724376512));
            object val_5 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  R4 + 152, action:  190734336);
        }
        public void FadeIn()
        {
            float val_1 = this.canvasGroup.alpha;
            if(this.canvasGroup == 0)
            {
                    return;
            }
            
            mem2[0] = ???;
            int val_2 = DG.Tweening.DOTween.Kill(targetOrId:  R4 + 152, complete:  false);
            R4.SetDefaultColor();
            R4 + 152.alpha = 1f;
        }
        public WOLTextPreview()
        {
            this.extraBackgroundWidth = 50f;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.tileStrings = null;
        }
        private void <FadeOut>b__43_0()
        {
            this.isFading = false;
            this.ClearText();
            if(this.isHintActive == false)
            {
                    return;
            }
            
            this.SetHint(hintLetters:  this.hintLetters);
            this.SetDefaultColor();
            this.SetActive(isActive:  true, useButtons:  false);
            this.FadeIn();
        }
    
    }

}
