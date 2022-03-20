using UnityEngine;

namespace WordPets.LevelEditor
{
    public class WPTLEColOption : MonoBehaviour
    {
        // Fields
        private WordPets.LevelEditor.ColOptionType myType;
        private UnityEngine.UI.InputField myInputField;
        private UnityEngine.UI.Text curValue;
        private UnityEngine.UI.Button hasPetButton;
        private UnityEngine.Sprite noPetSprite;
        private UnityEngine.Sprite petSprite;
        private bool hasPet;
        private WordPets.LevelEditor.WPTLEColInformation infoParent;
        private WordPets.ColData data;
        
        // Methods
        public void Init(WordPets.ColData myData, WordPets.LevelEditor.WPTLEColInformation myInformationParent)
        {
            UnityEngine.Events.UnityAction<UnityEngine.UI.LayoutRebuilder> val_14;
            UnityEngine.UI.Button val_15;
            string val_16;
            UnityEngine.UI.Text val_17;
            val_14 = 35636641;
            this.infoParent = myInformationParent;
            this.data = myData;
            bool val_14 = myData.<initialPet>k__BackingField;
            val_14 = val_14 ^ 1;
            this.hasPet = val_14;
            bool val_1 = UnityEngine.Object.op_Inequality(x:  this.hasPetButton, y:  0);
            if(val_1 == true)
            {
                    val_1 = this;
                this.SetPet();
            }
            
            if(this.myInputField != 0)
            {
                    this.myInputField.m_OnEndEdit.RemoveAllListeners();
                val_14 = null;
                val_14 = new UnityEngine.Events.UnityAction<UnityEngine.UI.LayoutRebuilder>(object:  227703536, method:  new IntPtr(227643696));
                this.myInputField.m_OnEndEdit.AddListener(call:  162353152);
            }
            
            val_15 = this.hasPetButton;
            if(val_15 != 0)
            {
                    this.hasPetButton.m_OnClick.RemoveAllListeners();
                val_15 = this.hasPetButton.m_OnClick;
                val_14 = null;
                val_14 = new UnityEngine.Events.UnityAction(object:  227703536, method:  new IntPtr(227665200));
                val_15.AddListener(call:  162246656);
            }
            
            if(this.myType > 3)
            {
                    return;
            }
            
            var val_6 = 11617140 + (11617140 + (this.myType) << 2);
            if(this.myType == 3)
            {
                    11617140 + (this.myType) << 2 = (11617140 + (this.myType) << 2) & ((11617140 + (this.myType) << 2) << (11617140 + (this.myType) << 2));
                11617140 + (this.myType) << 2 = (11617140 + (this.myType) << 2) & ((IP) << (11617140 + (this.myType) << 2 & (11617140 + (this.myType) << 2) << 11617140 + (this.myType) << 2));
                11617140 + (this.myType) << 2 = (11617140 + (this.myType) << 2) & (1152921504765685760 >> (11617140 + (this.myType) << 2));
                11617140 + (this.myType) << 2 = (11617140 + (this.myType) << 2) & (((IP) << (32-(((11617140 + (this.myType) << 2 & (11617140 + (this.myType) << 2) << 11617140 + (this.myType) << 2) & (IP) << (11617140 + (this.myType) << 2 & (11617140 + (this.myType) << 2) << 11617140 + (this.myTy)) | ((IP) << (((11617140 + (this.myType) << 2 & (11617140 + (this.myType) << 2) << 11617140 + (this.myType) << 2) & (IP) << (11617140 + (this.myType) << 2 & (11617140 + (this.myType) << 2) << 11617140 + (this.myTy));
            }
            
            val_16 = myData.<letters>k__BackingField;
            val_17 = this.curValue;
            if(val_17 != 0)
            {
                    return;
            }
        
        }
        public void CheckValue(string newVal)
        {
            float val_10;
            float val_11;
            float val_12;
            float val_13;
            float val_18;
            float val_19;
            float val_20;
            float val_21;
            var val_24;
            var val_25;
            UnityEngine.UI.Image val_26;
            if(this.myType == 0)
            {
                goto label_1;
            }
            
            if((-1) <= 10)
            {
                    if((System.Int32.TryParse(s:  newVal, result: out  int val_1 = 227905900)) == true)
            {
                goto label_7;
            }
            
            }
            
            if(this.myType != 0)
            {
                goto label_5;
            }
            
            label_1:
            if((this.myType.OnlyValidLetters(inputWord:  newVal)) != false)
            {
                    if(newVal.m_stringLength <= 11)
            {
                goto label_7;
            }
            
            }
            
            label_5:
            val_24 = 0;
            DG.Tweening.Sequence val_4 = DG.Tweening.DOTween.Sequence();
            val_25 = 0;
            UnityEngine.UI.Image val_5 = this.myInputField.image;
            val_26 = this.myInputField;
            UnityEngine.Color val_6 = UnityEngine.Color.red;
            goto label_11;
            label_7:
            this.infoParent.ModifyColValue(type:  this.myType, newValue:  newVal, data:  0);
            val_24 = 0;
            DG.Tweening.Sequence val_7 = DG.Tweening.DOTween.Sequence();
            val_25 = 0;
            UnityEngine.UI.Image val_8 = this.myInputField.image;
            val_26 = this.myInputField;
            UnityEngine.Color val_9 = UnityEngine.Color.green;
            label_11:
            DG.Tweening.Tweener val_14 = DG.Tweening.ShortcutExtensions46.DOColor(target:  val_26, endValue:  new UnityEngine.Color() {r = val_10, g = val_11, b = val_12, a = val_13}, duration:  val_9.r);
            DG.Tweening.Sequence val_15 = DG.Tweening.TweenSettingsExtensions.Insert(s:  0, atPosition:  val_9.r, t:  0);
            UnityEngine.UI.Image val_16 = this.myInputField.image;
            UnityEngine.Color val_17 = UnityEngine.Color.white;
            DG.Tweening.Tweener val_22 = DG.Tweening.ShortcutExtensions46.DOColor(target:  this.myInputField, endValue:  new UnityEngine.Color() {r = val_18, g = val_19, b = val_20, a = val_21}, duration:  val_17.r);
            DG.Tweening.Sequence val_23 = DG.Tweening.TweenSettingsExtensions.Insert(s:  0, atPosition:  val_17.r, t:  1038174126);
        }
        public void SetPet()
        {
            this.hasPet = this.hasPet ^ 1;
            UnityEngine.UI.Image val_2 = this.hasPetButton.image;
            if(this.hasPet == true)
            {
                    this.hasPet = this.noPetSprite;
            }
            
            if(this.hasPet == false)
            {
                    this.hasPet = this.petSprite;
            }
            
            this.hasPetButton.sprite = this.hasPet;
            string val_3 = this.hasPet.ToString();
            this.infoParent.ModifyColValue(type:  this.myType, newValue:  228087316, data:  0);
        }
        private bool OnlyValidLetters(string inputWord)
        {
            goto label_1;
            label_7:
            if((System.Char.IsLetter(s:  inputWord, index:  0)) != true)
            {
                    if(inputWord.Chars[0] != ('-'))
            {
                    return true;
            }
            
            }
            
            0 = 1;
            label_1:
            if(0 < inputWord.m_stringLength)
            {
                goto label_7;
            }
            
            return true;
        }
        public void DeleteMe()
        {
            this.infoParent.ModifyColValue(type:  3, newValue:  228324144, data:  this.data);
        }
        public WPTLEColOption()
        {
        
        }
    
    }

}
