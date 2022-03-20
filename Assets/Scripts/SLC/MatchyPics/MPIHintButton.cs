using UnityEngine;

namespace SLC.MatchyPics
{
    public class MPIHintButton : MonoBehaviour
    {
        // Fields
        public SLC.MatchyPics.MPIHintButton.HintType hintType;
        public UnityEngine.UI.Text costText;
        public UnityEngine.UI.Button button;
        
        // Methods
        public void Awake()
        {
            UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  775076064, method:  new IntPtr(775051040));
            this.button.m_OnClick.AddListener(call:  162246656);
        }
        public void Start()
        {
            string val_2 = this.HintCost().ToString();
            if(this.costText != 0)
            {
                    return;
            }
        
        }
        public void OnClickButton()
        {
            if(this.hintType == 0)
            {
                goto label_1;
            }
            
            if(this.hintType == 2)
            {
                goto label_2;
            }
            
            if(this.hintType != 1)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            OnChangeImageSet();
            return;
            label_1:
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            OnClickShuffle();
            return;
            label_2:
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            OnClickHint();
        }
        private int HintCost()
        {
            var val_7;
            if(this.hintType == 0)
            {
                goto label_1;
            }
            
            if(this.hintType == 2)
            {
                goto label_2;
            }
            
            val_7 = 0;
            if(this.hintType != 1)
            {
                    return (int)val_7;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            goto label_15;
            label_1:
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            goto label_15;
            label_2:
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            label_15:
            val_7 = mem[(public static SLC.MatchyPics.MPIDataController MonoSingleton<SLC.MatchyPics.MPIDataController>::get_Instance().__il2cppRuntimeField_C + 12 + 12)];
            val_7 = (public static SLC.MatchyPics.MPIDataController MonoSingleton<SLC.MatchyPics.MPIDataController>::get_Instance().__il2cppRuntimeField_C + 12 + 12);
            return (int)val_7;
        }
        public MPIHintButton()
        {
        
        }
    
    }

}
