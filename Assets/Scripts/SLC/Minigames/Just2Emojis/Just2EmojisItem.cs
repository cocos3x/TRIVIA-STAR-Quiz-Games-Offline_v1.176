using UnityEngine;

namespace SLC.Minigames.Just2Emojis
{
    public class Just2EmojisItem : MonoBehaviour
    {
        // Fields
        public bool isHidden;
        public bool isHinted;
        public string letter;
        private UnityEngine.UI.Image myImage;
        private TMPro.TMP_Text label;
        private UnityEngine.UI.Button myButton;
        private UnityEngine.Sprite highlightedSprite;
        private UnityEngine.Sprite unhighlightedSprite;
        private UnityEngine.RectTransform imageRectTransform;
        private float myWidth;
        
        // Methods
        private void Awake()
        {
            UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  1037739280, method:  new IntPtr(1037714256));
            this.myButton.m_OnClick.AddListener(call:  162246656);
        }
        public void SetUp(string letter)
        {
            UnityEngine.Rect val_1 = rect;
            float val_2 = width;
            this.myWidth = ;
            this.letter = letter;
            this.isHinted = false;
        }
        public void Hide()
        {
            this.myImage.enabled = false;
            this.myButton.interactable = false;
            this.isHidden = true;
        }
        public void Show()
        {
            this.myImage.sprite = this.unhighlightedSprite;
            this.myImage.enabled = true;
            this.myButton.interactable = true;
            this.isHidden = false;
        }
        public void Hinted()
        {
            this.Hide();
            this.isHinted = true;
        }
        private void OnClick()
        {
            if(this.isHinted == true)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            LetterClick(item:  R4);
        }
        public override string ToString()
        {
            return System.String.Format(format:  1038493776, arg0:  this.letter);
        }
        public void FTUXHighlight()
        {
            this.myImage.sprite = this.highlightedSprite;
        }
        public void Unhighlight()
        {
            if(this.myImage.m_Sprite != this.highlightedSprite)
            {
                    return;
            }
            
            this.myImage.sprite = this.unhighlightedSprite;
        }
        public Just2EmojisItem()
        {
        
        }
    
    }

}
