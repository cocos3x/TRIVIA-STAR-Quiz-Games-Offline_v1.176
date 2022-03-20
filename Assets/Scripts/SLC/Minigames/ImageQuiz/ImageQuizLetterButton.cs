using UnityEngine;

namespace SLC.Minigames.ImageQuiz
{
    public class ImageQuizLetterButton : MonoBehaviour
    {
        // Fields
        private UnityEngine.UI.Button button;
        private string _letter;
        private SLC.Minigames.ImageQuiz.ImageQuizLetterButton.HighlightState <CurrentHighlightState>k__BackingField;
        private UnityEngine.UI.Image spriteDefault;
        private UnityEngine.UI.Image spriteHighlighted;
        private UnityEngine.UI.Text letterLabel;
        private bool <IsUsed>k__BackingField;
        private UnityEngine.RectTransform rectTransform;
        private DG.Tweening.Tweener buttonTweener;
        
        // Properties
        public string Letter { get; }
        public SLC.Minigames.ImageQuiz.ImageQuizLetterButton.HighlightState CurrentHighlightState { get; set; }
        public bool IsUsed { get; set; }
        public bool Interactable { get; set; }
        
        // Methods
        public string get_Letter()
        {
        
        }
        public SLC.Minigames.ImageQuiz.ImageQuizLetterButton.HighlightState get_CurrentHighlightState()
        {
        
        }
        private void set_CurrentHighlightState(SLC.Minigames.ImageQuiz.ImageQuizLetterButton.HighlightState value)
        {
            this.<CurrentHighlightState>k__BackingField = value;
        }
        public bool get_IsUsed()
        {
            return (bool)this.<IsUsed>k__BackingField;
        }
        private void set_IsUsed(bool value)
        {
            this.<IsUsed>k__BackingField = value;
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
        private void Awake()
        {
            UnityEngine.RectTransform val_3;
            UnityEngine.GameObject val_1 = this.gameObject;
            val_3 = this;
            UnityEngine.Transform val_2 = this.transform;
            if(val_3 != 0)
            {
                    if(null == null)
            {
                goto label_3;
            }
            
            }
            
            val_3 = 0;
            label_3:
            this.rectTransform = val_3;
        }
        private void Start()
        {
            UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  1070633600, method:  new IntPtr(1070608576));
            this.button.m_OnClick.AddListener(call:  162246656);
            this.SetHighlight(state:  0);
        }
        private void OnDestroy()
        {
            UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  1070761984, method:  new IntPtr(1070608576));
            this.button.m_OnClick.RemoveListener(call:  162246656);
        }
        public void ToggleButtonVisibility(bool isVisible)
        {
            var val_11;
            DG.Tweening.TweenCallback val_12;
            UnityEngine.Transform val_13;
            val_11 = 0;
            this.button.interactable = isVisible;
            this.<IsUsed>k__BackingField = isVisible ^ 1;
            if(this.buttonTweener != 0)
            {
                    val_11 = 0;
                DG.Tweening.TweenExtensions.Kill(t:  this.buttonTweener, complete:  false);
            }
            
            if(isVisible != false)
            {
                    this.SetHighlight(state:  0);
                UnityEngine.GameObject val_2 = this.gameObject;
                this.SetActive(value:  true);
                val_12 = 0;
                UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
                this.rectTransform.localScale = new UnityEngine.Vector3();
                UnityEngine.Vector3 val_4 = UnityEngine.Vector3.one;
                val_13 = this.rectTransform;
                DG.Tweening.Tweener val_5 = DG.Tweening.ShortcutExtensions.DOScale(target:  val_13, endValue:  new UnityEngine.Vector3(), duration:  val_4.x);
            }
            else
            {
                    UnityEngine.Vector3 val_6 = UnityEngine.Vector3.one;
                this.rectTransform.localScale = new UnityEngine.Vector3();
                UnityEngine.Vector3 val_7 = UnityEngine.Vector3.zero;
                DG.Tweening.Tweener val_8 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.rectTransform, endValue:  new UnityEngine.Vector3(), duration:  val_7.x);
                val_12 = null;
                val_12 = new DG.Tweening.TweenCallback(object:  1070907776, method:  new IntPtr(1070882752));
                val_13 = this.rectTransform;
                object val_10 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  val_13, action:  190734336);
            }
            
            this.buttonTweener = val_13;
        }
        private void OnClick()
        {
            this.ToggleButtonVisibility(isVisible:  false);
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static SLC.Minigames.ImageQuiz.ImageQuizUIController MonoSingleton<SLC.Minigames.ImageQuiz.ImageQuizUIController>::get_Instance().__il2cppRuntimeField_14.AddInput(inputLetter:  this._letter, originatingButton:  1071048448);
        }
        public void SetHighlight(SLC.Minigames.ImageQuiz.ImageQuizLetterButton.HighlightState state)
        {
            var val_4;
            this.<CurrentHighlightState>k__BackingField = state;
            UnityEngine.GameObject val_1 = this.spriteHighlighted.gameObject;
            if(state == 1)
            {
                    this.spriteHighlighted.SetActive(value:  true);
                UnityEngine.GameObject val_2 = this.spriteDefault.gameObject;
                val_4 = 0;
            }
            else
            {
                    this.spriteHighlighted.SetActive(value:  false);
                UnityEngine.GameObject val_3 = this.spriteDefault.gameObject;
                val_4 = 1;
            }
            
            this.spriteDefault.SetActive(value:  true);
        }
        public void SetLetter(string letterString)
        {
            this._letter = letterString;
        }
        public ImageQuizLetterButton()
        {
            this._letter = System.String.alignConst;
        }
        private void <ToggleButtonVisibility>b__24_0()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            this.SetActive(value:  false);
        }
    
    }

}
