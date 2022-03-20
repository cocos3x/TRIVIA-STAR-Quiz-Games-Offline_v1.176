using UnityEngine;

namespace WordPets.LevelEditor
{
    public class WPTLEColInformation : MonoBehaviour
    {
        // Fields
        private WordPets.WPTGameColumn myRow;
        private UnityEngine.UI.Text myText;
        private System.Collections.Generic.List<WordPets.LevelEditor.WPTLEColOption> myOptions;
        private UnityEngine.UI.Toggle reloadToggle;
        
        // Methods
        public void Init()
        {
            var val_1 = 0;
            goto label_1;
            label_7:
            if(true <= val_1)
            {
                    var val_1 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_1 = val_1 + 0;
            (0 + 0) + 16.Init(myData:  this.myRow.<myData>k__BackingField, myInformationParent:  226722768);
            val_1 = 1;
            label_1:
            if(val_1 < ((0 + 0) + 16))
            {
                goto label_7;
            }
        
        }
        private void OnDisable()
        {
            if(this.reloadToggle.m_IsOn == false)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            TestLevel();
        }
        public void SetMyCol(WordPets.WPTGameColumn row)
        {
            var val_3;
            WordPets.ColData val_4;
            this.myRow = row;
            UnityEngine.GameObject val_1 = this.gameObject;
            val_3 = 0;
            this.SetActive(value:  true);
            string val_2 = this.GetColInformation();
            val_4 = this;
            if(this.myText != 0)
            {
                goto label_3;
            }
            
            goto label_3;
            label_9:
            if(this.myText <= val_3)
            {
                    var val_3 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_3 = val_3 + 0;
            val_4 = this.myRow.<myData>k__BackingField;
            (0 + 0) + 16.Init(myData:  val_4, myInformationParent:  226995920);
            val_3 = 1;
            label_3:
            if(val_3 < ((0 + 0) + 16))
            {
                goto label_9;
            }
        
        }
        public string GetColInformation()
        {
            string val_2 = System.Environment.NewLine;
            string val_3 = 227108496 + null;
            System.Text.StringBuilder val_4 = Append(value:  227108496);
            string val_5 = System.Environment.NewLine;
            string val_6 = 0 + 227116832 + 13152256;
            System.Text.StringBuilder val_7 = Append(value:  null);
            string val_8 = System.Environment.NewLine;
            string val_9 = null + 227125120 + this.myRow.<myData>k__BackingField.<letters>k__BackingField(this.myRow.<myData>k__BackingField.<letters>k__BackingField);
            System.Text.StringBuilder val_10 = Append(value:  null);
            string val_11 = System.Environment.NewLine;
            string val_12 = this.myRow.<myData>k__BackingField.<initialPet>k__BackingField.ToString();
            string val_13 = null + 227137520 + 227149607;
            if(new System.Text.StringBuilder() != 0)
            {
                    System.Text.StringBuilder val_14 = Append(value:  null);
                return;
            }
            
            System.Text.StringBuilder val_15 = Append(value:  null);
        }
        public void ModifyColValue(WordPets.LevelEditor.ColOptionType type, string newValue, WordPets.ColData data)
        {
            WordPets.ColData val_11;
            var val_12;
            val_11 = 35636639;
            val_12 = type;
            if(val_12 <= 3)
            {
                    var val_1 = 11619136 + (11619136 + (type) << 2);
                if(val_12 == 3)
            {
                    11619136 = 11619136;
                11619136 = 11619136 & (((int)IP) >> 11619136);
                11619136 = this * 11619136;
            }
            
                this.myRow.<myData>k__BackingField.<letters>k__BackingField = newValue;
                val_11 = this.myRow.<myData>k__BackingField;
                this.myRow.<myData>k__BackingField.<letterData>k__BackingField = newValue;
            }
            
            string val_9 = this.GetColInformation();
            twelvegigs.Autopilot.AutopilotManager val_10 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            CheckDiff();
        }
        public WPTLEColInformation()
        {
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.myOptions = null;
        }
    
    }

}
