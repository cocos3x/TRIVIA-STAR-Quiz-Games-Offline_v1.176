using UnityEngine;

namespace SLC.Minigames.ImageQuiz
{
    public class ImageQuizDisplayLetter : MonoBehaviour
    {
        // Fields
        private UnityEngine.UI.Button button;
        private string _letter;
        private bool <IsAnimating>k__BackingField;
        private SLC.Minigames.ImageQuiz.ImageQuizDisplayLetter.TileStatus <CurrentTileStatus>k__BackingField;
        private UnityEngine.UI.Image backgroundImage;
        private UnityEngine.RectTransform tileContainer;
        private UnityEngine.GameObject unconfirmedTile;
        private UnityEngine.GameObject confirmedTile;
        private UnityEngine.UI.Text[] letterLabel;
        private int buttonIndex;
        private DG.Tweening.Sequence tileAnimationSequence;
        
        // Properties
        public string Letter { get; }
        public bool IsAnimating { get; set; }
        public bool Interactable { get; set; }
        public SLC.Minigames.ImageQuiz.ImageQuizDisplayLetter.TileStatus CurrentTileStatus { get; set; }
        
        // Methods
        public string get_Letter()
        {
        
        }
        private void set_IsAnimating(bool value)
        {
            this.<IsAnimating>k__BackingField = value;
        }
        public bool get_IsAnimating()
        {
            return (bool)this.<IsAnimating>k__BackingField;
        }
        public bool get_Interactable()
        {
            if(this.button != 0)
            {
                    return (bool)this;
            }
            
            return (bool)this;
        }
        public void set_Interactable(bool value)
        {
            this.button.interactable = value;
        }
        public SLC.Minigames.ImageQuiz.ImageQuizDisplayLetter.TileStatus get_CurrentTileStatus()
        {
        
        }
        private void set_CurrentTileStatus(SLC.Minigames.ImageQuiz.ImageQuizDisplayLetter.TileStatus value)
        {
            this.<CurrentTileStatus>k__BackingField = value;
        }
        private void Start()
        {
            UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  1058047776, method:  new IntPtr(1058022752));
            this.button.m_OnClick.AddListener(call:  162246656);
        }
        private void OnDestroy()
        {
            UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  1058176160, method:  new IntPtr(1058022752));
            this.button.m_OnClick.RemoveListener(call:  162246656);
        }
        public void Initialize(int indexInWord)
        {
            this.buttonIndex = indexInWord;
            this.SetLetter(letterString:  System.String.alignConst);
            this.SetTileStatus(state:  0, dontUpdateVisual:  false);
        }
        private void OnClick()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static SLC.Minigames.ImageQuiz.ImageQuizUIController MonoSingleton<SLC.Minigames.ImageQuiz.ImageQuizUIController>::get_Instance().__il2cppRuntimeField_14.EraseLetter(letterIndex:  this.buttonIndex);
        }
        public void SetLetter(string letterString)
        {
            var val_1;
            this._letter = letterString;
            val_1 = 0;
            goto label_0;
            label_5:
            val_1 = 1;
            label_0:
            if(val_1 < this.letterLabel[val_1])
            {
                goto label_5;
            }
        
        }
        private void SetTileStatus(SLC.Minigames.ImageQuiz.ImageQuizDisplayLetter.TileStatus state, bool dontUpdateVisual = False)
        {
            var val_2;
            var val_3;
            var val_4;
            this.<CurrentTileStatus>k__BackingField = state;
            if(dontUpdateVisual != false)
            {
                    return;
            }
            
            val_2 = this;
            if(state == 2)
            {
                goto label_1;
            }
            
            if(state == 1)
            {
                goto label_2;
            }
            
            if(state != 0)
            {
                    return;
            }
            
            val_3 = 0;
            goto label_3;
            label_1:
            val_3 = 1;
            label_3:
            this.SetTileVisible(state:  true);
            val_4 = 0;
            goto label_5;
            label_2:
            this.SetTileVisible(state:  true);
            val_4 = 1;
            label_5:
            this.button.interactable = true;
        }
        private void SetTileVisible(bool state)
        {
            float val_5;
            var val_6;
            var val_7;
            UnityEngine.GameObject val_1 = this.tileContainer.gameObject;
            val_5 = this.tileContainer;
            val_5.SetActive(value:  state);
            if(state == false)
            {
                    return;
            }
            
            if((this.<CurrentTileStatus>k__BackingField) == 0)
            {
                goto label_3;
            }
            
            if((this.<CurrentTileStatus>k__BackingField) == 2)
            {
                goto label_4;
            }
            
            if((this.<CurrentTileStatus>k__BackingField) != 1)
            {
                    return;
            }
            
            UnityEngine.Color val_2 = UnityEngine.Color.white;
            this.backgroundImage.color = new UnityEngine.Color() {a = ???};
            val_6 = 1;
            goto label_8;
            label_3:
            UnityEngine.Color val_3 = UnityEngine.Color.white;
            this.backgroundImage.color = new UnityEngine.Color() {a = ???};
            val_6 = 0;
            label_8:
            this.unconfirmedTile.SetActive(value:  false);
            val_7 = 0;
            goto label_12;
            label_4:
            UnityEngine.Color val_4 = new UnityEngine.Color(r:  null, g:  null, b:  null, a:  null);
            this.backgroundImage.color = new UnityEngine.Color() {r = val_4.r, g = val_4.g, b = val_4.b, a = val_5};
            this.unconfirmedTile.SetActive(value:  false);
            val_7 = 1;
            label_12:
            this.confirmedTile.SetActive(value:  true);
        }
        public void PlayAnimation(SLC.Minigames.ImageQuiz.ImageQuizDisplayLetter.TileAnimation anim, float animationDelay = 0)
        {
            float val_13;
            float val_14;
            DG.Tweening.Sequence val_34;
            DG.Tweening.Sequence val_35;
            DG.Tweening.TweenCallback val_36;
            var val_37;
            float val_38;
            if(this.tileAnimationSequence != 0)
            {
                    DG.Tweening.TweenExtensions.Kill(t:  this.tileAnimationSequence, complete:  false);
            }
            
            this.<IsAnimating>k__BackingField = true;
            this.button.interactable = false;
            if(anim < 2)
            {
                goto label_3;
            }
            
            if(anim == 2)
            {
                goto label_4;
            }
            
            if(anim != 3)
            {
                    return;
            }
            
            this.<CurrentTileStatus>k__BackingField = 2;
            val_34 = 0;
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            this.tileAnimationSequence = 0;
            UnityEngine.Vector3 val_2 = new UnityEngine.Vector3(x:  animationDelay, y:  null, z:  null);
            DG.Tweening.Tweener val_3 = DG.Tweening.ShortcutExtensions.DOPunchScale(target:  this.tileContainer, punch:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, duration:  animationDelay, vibrato:  1050253722, elasticity:  null);
            DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.Insert(s:  0, atPosition:  animationDelay, t:  R2);
            val_35 = this.tileAnimationSequence;
            val_36 = null;
            val_37 = 1152921514255913952;
            goto label_8;
            label_3:
            if(anim != 1)
            {
                    0 = 1;
            }
            
            if(anim == 1)
            {
                    0 = 2;
            }
            
            this.SetTileStatus(state:  2, dontUpdateVisual:  false);
            UnityEngine.Vector3 val_5 = new UnityEngine.Vector3(x:  animationDelay, y:  null, z:  null);
            this.tileContainer.localScale = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
            UnityEngine.Vector2 val_6 = new UnityEngine.Vector2(x:  animationDelay, y:  null);
            this.tileContainer.anchoredPosition = new UnityEngine.Vector2() {x = val_6.x, y = val_6.y};
            DG.Tweening.Sequence val_7 = DG.Tweening.DOTween.Sequence();
            this.tileAnimationSequence = 0;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.one;
            DG.Tweening.Tweener val_9 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.tileContainer, endValue:  new UnityEngine.Vector3(), duration:  val_8.x);
            val_38 = 1152921509932985248;
            object val_10 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.tileContainer, ease:  30);
            DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.Insert(s:  0, atPosition:  val_8.x, t:  R2);
            val_34 = this.tileAnimationSequence;
            UnityEngine.Vector2 val_12 = UnityEngine.Vector2.zero;
            DG.Tweening.Tweener val_15 = DG.Tweening.ShortcutExtensions46.DOAnchorPos(target:  this.tileContainer, endValue:  new UnityEngine.Vector2() {x = val_13, y = val_14}, duration:  val_12.x, snapping:  true);
            object val_16 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.tileContainer, ease:  12);
            DG.Tweening.Sequence val_17 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_34, atPosition:  val_12.x, t:  R2);
            if(anim == 1)
            {
                    DG.Tweening.Tweener val_18 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.backgroundImage, endValue:  val_12.x, duration:  val_12.y);
                object val_19 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.backgroundImage, ease:  1);
                DG.Tweening.Sequence val_20 = DG.Tweening.TweenSettingsExtensions.Insert(s:  this.tileAnimationSequence, atPosition:  val_12.x, t:  R2);
            }
            
            val_36 = null;
            val_36 = new DG.Tweening.TweenCallback(object:  1059207680, method:  new IntPtr(1059132384));
            object val_22 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  this.tileAnimationSequence, action:  190734336);
            twelvegigs.Autopilot.AutopilotManager val_23 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            PlayGameSpecificSound(id:  1059166176, clipIndex:  0, volumeScale:  val_12.x);
            return;
            label_4:
            DG.Tweening.Sequence val_24 = DG.Tweening.DOTween.Sequence();
            this.tileAnimationSequence = 0;
            UnityEngine.Vector2 val_25 = new UnityEngine.Vector2(x:  animationDelay, y:  null);
            val_38 = 15820;
            val_38 = 1036831949;
            DG.Tweening.Tweener val_26 = DG.Tweening.ShortcutExtensions46.DOAnchorPos(target:  this.tileContainer, endValue:  new UnityEngine.Vector2() {x = val_25.x, y = val_25.y}, duration:  animationDelay, snapping:  true);
            val_34 = 1152921509932985248;
            object val_27 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.tileContainer, ease:  5);
            DG.Tweening.Sequence val_28 = DG.Tweening.TweenSettingsExtensions.Insert(s:  0, atPosition:  animationDelay, t:  R2);
            DG.Tweening.Tweener val_29 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.backgroundImage, endValue:  animationDelay, duration:  null);
            object val_30 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.backgroundImage, ease:  1);
            DG.Tweening.Sequence val_31 = DG.Tweening.TweenSettingsExtensions.Insert(s:  this.tileAnimationSequence, atPosition:  animationDelay, t:  R2);
            val_35 = this.tileAnimationSequence;
            val_36 = null;
            val_37 = 1152921514255964224;
            label_8:
            val_36 = new DG.Tweening.TweenCallback(object:  1059207680, method:  new IntPtr(1059182656));
            object val_33 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  val_35, action:  190734336);
        }
        private void OnAnimationComplete()
        {
            float val_2;
            float val_3;
            UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
            this.tileContainer.anchoredPosition = new UnityEngine.Vector2() {x = val_2, y = val_3};
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.one;
            this.tileContainer.localScale = new UnityEngine.Vector3();
            this.<IsAnimating>k__BackingField = false;
            this.button.interactable = ((this.<CurrentTileStatus>k__BackingField) - 1) >> 5;
        }
        public ImageQuizDisplayLetter()
        {
            this._letter = System.String.alignConst;
        }
        private void <PlayAnimation>b__31_0()
        {
            this.SetTileStatus(state:  0, dontUpdateVisual:  false);
            this.OnAnimationComplete();
        }
    
    }

}
