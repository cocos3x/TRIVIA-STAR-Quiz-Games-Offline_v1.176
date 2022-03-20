using UnityEngine;

namespace SLC.Minigames.Just2Emojis
{
    public class Just2EmojisAnswer : MonoBehaviour
    {
        // Fields
        public string letter;
        public int index;
        public TMPro.TMP_Text myText;
        public UnityEngine.UI.Image myImage;
        public bool isHinted;
        private UnityEngine.UI.Button myButton;
        
        // Methods
        private void Awake()
        {
            UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  1035643376, method:  new IntPtr(1035618352));
            this.myButton.m_OnClick.AddListener(call:  162246656);
        }
        private void OnClick()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            AnswerClicked(answer:  1035763568);
        }
        public void Fill(string letter)
        {
            this.letter = letter;
            this.myText.enableAutoSizing = false;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            this.myText.fontSize = FindBestAnswerFontSize();
        }
        public void Empty()
        {
            this.letter = System.String.alignConst;
        }
        public override string ToString()
        {
            string val_1 = System.String.Format(format:  1036120624, arg0:  this.letter, arg1:  13152256);
        }
        public Just2EmojisAnswer()
        {
        
        }
    
    }

}
