using UnityEngine;

namespace twelvegigs.Autopilot
{
    public class TRVAutopilotGameplay : AutopilotGameplay
    {
        // Fields
        private SceneType sceneType;
        private TRVCategorySelection categorySelection;
        
        // Methods
        public override bool IsExecutable()
        {
            var val_37;
            var val_38;
            var val_39;
            var val_40;
            var val_42;
            Player val_1 = App.Player;
            if(0 > mem[1179403871])
            {
                    float val_2 = UnityEngine.Random.value;
                if(0 < 0)
            {
                    return false;
            }
            
            }
            
            if(this.sceneType == 2)
            {
                goto label_6;
            }
            
            if(this.sceneType != 1)
            {
                    return false;
            }
            
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_3 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            label_53:
            label_83:
            Add(item:  1123078912);
            twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            AddInstruction(newInstructions:  80883712, clearPrevious:  true);
            return false;
            label_6:
            val_37 = 1152921504901095424;
            twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_38 = 1152921504765685760;
            if(2119322896 == 0)
            {
                goto label_51;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance().__il2cppRuntimeField_1C) == 0)
            {
                goto label_51;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_10 = public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance().__il2cppRuntimeField_1C.GetComponent<System.Object>();
            this.categorySelection = public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance().__il2cppRuntimeField_1C;
            if((public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance().__il2cppRuntimeField_1C) == 0)
            {
                goto label_30;
            }
            
            UnityEngine.Debug.Log(message:  1123080048);
            T[] val_12 = this.categorySelection.GetComponentsInChildren<System.Object>();
            if(this.categorySelection == 0)
            {
                goto label_34;
            }
            
            val_39 = this.categorySelection;
            val_40 = UnityEngine.Random.Range(min:  0, max:  this.categorySelection.closeButton);
            goto label_35;
            label_30:
            twelvegigs.Autopilot.AutopilotManager val_14 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_15 = public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance().__il2cppRuntimeField_1C.GetComponent<System.Object>();
            if((public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance().__il2cppRuntimeField_1C) == 0)
            {
                goto label_42;
            }
            
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_17 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            if(null != 0)
            {
                goto label_53;
            }
            
            goto label_53;
            label_42:
            twelvegigs.Autopilot.AutopilotManager val_18 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_19 = public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance().__il2cppRuntimeField_1C.GetComponent<System.Object>();
            if((public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance().__il2cppRuntimeField_1C) == 0)
            {
                goto label_51;
            }
            
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_21 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            if(null != 0)
            {
                goto label_53;
            }
            
            goto label_53;
            label_51:
            val_42 = 1152921511548963376;
            twelvegigs.Autopilot.AutopilotManager val_22 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((-1647818192) == 0)
            {
                    return false;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_24 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            twelvegigs.Autopilot.AutopilotManager val_25 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            T[] val_26 = GetComponentsInChildren<System.Object>();
            val_37 = 1152921512479564032;
            val_42 = 0;
            return false;
            label_34:
            val_39 = 12;
            val_40 = UnityEngine.Random.Range(min:  0, max:  0);
            label_35:
            TRVCategorySelection val_32 = this.categorySelection + (val_40 << 2);
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_33 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            string val_34 = (this.categorySelection + (val_31) << 2).rerollButton.name;
            string val_35 = 1123096816 + (this.categorySelection + (val_31) << 2).rerollButton((this.categorySelection + (val_31) << 2).rerollButton);
            UnityEngine.Debug.LogError(message:  1123096816);
            string val_36 = (this.categorySelection + (val_31) << 2).rerollButton.name;
            if(null != 0)
            {
                goto label_83;
            }
            
            goto label_83;
        }
        public override void RunAction()
        {
        
        }
        public override void OnSceneLoaded(SceneType sceneType)
        {
            this.sceneType = sceneType;
        }
        public override void OnSceneUnloaded(SceneType sceneType)
        {
        
        }
        public TRVAutopilotGameplay()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
