using UnityEngine;

namespace twelvegigs.Autopilot
{
    public class WADAutopilotGameplay : AutopilotGameplay
    {
        // Fields
        private Pan pan;
        private UnityEngine.Camera panCamera;
        private bool onGameScene;
        
        // Methods
        public void Start()
        {
            mem[1152921514320495276] = 130;
        }
        public override bool IsExecutable()
        {
            if(this.onGameScene == false)
            {
                    return false;
            }
            
            Player val_1 = App.Player;
            if(0 <= mem[1179403871])
            {
                    return this.IsPanEnabled();
            }
            
            float val_2 = UnityEngine.Random.value;
            if(0 >= 0)
            {
                    return this.IsPanEnabled();
            }
            
            return false;
        }
        public override void RunAction()
        {
            WordRegion val_1 = WordRegion.instance;
            if(0 == 0)
            {
                    return;
            }
            
            WordRegion val_3 = WordRegion.instance;
            if(0 == 0)
            {
                
            }
        
        }
        public override void OnSceneLoaded(SceneType sceneType)
        {
            SceneType val_1 = sceneType - 2;
            val_1 = val_1 >> 5;
            this.onGameScene = val_1;
            this.pan = Pan.tappingAllowed;
            UnityEngine.Transform val_2 = Pan.tappingAllowed.transform;
            UnityEngine.Camera val_3 = twelvegigs.Autopilot.AutopilotTools.GetCamera(go:  Pan.tappingAllowed);
            this.panCamera = Pan.tappingAllowed;
            35639779 = 1152921504885600256;
            MainController val_4 = MainController.instance;
            if((UnityEngine.Object.op_Implicit(exists:  0)) == false)
            {
                    return;
            }
            
            MainController val_6 = MainController.instance;
            UnityEngine.Events.UnityAction val_7 = new UnityEngine.Events.UnityAction(object:  1124054816, method:  new IntPtr(1124029792));
            1.AddListener(call:  162246656);
        }
        public override void OnSceneUnloaded(SceneType sceneType)
        {
            this.pan = 0;
            this.panCamera = 0;
            if(this.onGameScene == false)
            {
                    return;
            }
            
            MainController val_1 = MainController.instance;
            UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  1124175008, method:  new IntPtr(1124029792));
            1.RemoveListener(call:  162246656);
        }
        public void HandleLevelComplete()
        {
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            ClearIgnore();
            Player val_2 = App.Player;
            if(0 > mem[1179403871])
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(PlayingChallenge != false)
            {
                    return;
            }
            
            GameplayMode val_5 = PlayingLevel.CurrentGameplayMode;
            if(0 == 4)
            {
                    twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                val_15 = 0;
                if((public static CategoryPacksManager MonoSingleton<CategoryPacksManager>::get_Instance().__il2cppRuntimeField_2C) != 0)
            {
                    val_16 = 1;
            }
            
            }
            else
            {
                    Player val_7 = App.Player;
                val_16 = ChapterBookLogic.ShowChapterComplete(playerLevel:  0);
                Player val_9 = App.Player;
                val_15 = ChapterBookLogic.ShowBookComplete(playerLevel:  0);
            }
            
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_11 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            if(val_15 != false)
            {
                    Add(item:  1124267104);
                Add(item:  1124267232);
                twelvegigs.Autopilot.AutopilotManager val_12 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                AddIgnore(button:  1124267376, clearPrevious:  true);
            }
            else
            {
                    if(val_16 != false)
            {
                    val_17 = public System.Void System.Collections.Generic.List<System.String>::Add(System.String item);
                val_18 = "ChapterClear_collect_button";
            }
            else
            {
                    val_17 = public System.Void System.Collections.Generic.List<System.String>::Add(System.String item);
                val_18 = "click_to_continue";
            }
            
                Add(item:  1124267632);
            }
            
            Add(item:  1124267104);
            twelvegigs.Autopilot.AutopilotManager val_13 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            AddIgnore(button:  1124267376, clearPrevious:  false);
            twelvegigs.Autopilot.AutopilotManager val_14 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            AddInstruction(newInstructions:  80883712, clearPrevious:  true);
        }
        private bool IsPanEnabled()
        {
            if(this.pan == 0)
            {
                    return (bool)0;
            }
            
            UnityEngine.GameObject val_2 = this.pan.gameObject;
            UnityEngine.Vector3 val_3 = position;
            0 = twelvegigs.Autopilot.AutopilotTools.RaycastOnPosition(target:  this.pan, worldPos:  new UnityEngine.Vector3(), camera:  this.panCamera);
            return (bool)0;
        }
        public WADAutopilotGameplay()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
