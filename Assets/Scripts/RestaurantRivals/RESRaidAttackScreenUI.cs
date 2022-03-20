using UnityEngine;

namespace RestaurantRivals
{
    public class RESRaidAttackScreenUI : MonoSingleton<RestaurantRivals.RESRaidAttackScreenUI>
    {
        // Fields
        private static System.Action awakeCommand;
        private PrefabsFromFolder prefabsFolder;
        private RestaurantRivals.RESRaidAttackScreenTransition screenTransition;
        private System.Collections.Generic.Stack<UnityEngine.GameObject> screenStack;
        
        // Methods
        private void Start()
        {
            if(RestaurantRivals.RESRaidAttackScreenUI.awakeCommand != 0)
            {
                    RestaurantRivals.RESRaidAttackScreenUI.awakeCommand.Invoke();
            }
            
            RestaurantRivals.RESRaidAttackScreenUI.awakeCommand = 0;
            System.Action val_1 = new System.Action(object:  603828416, method:  new IntPtr(603803392));
            DeviceKeypressManager.AddBackAction(backAction:  7454720);
        }
        private void OnDisable()
        {
            System.Action val_1 = new System.Action(object:  603940416, method:  new IntPtr(603803392));
            DeviceKeypressManager.RemoveBackAction(backAction:  7454720);
        }
        public static void ShowRaidScreen()
        {
            RestaurantRivals.RESRaidAttackScreenUI.ShowScreen<System.Object>(sceneType:  1);
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_10.FadeOutMusic();
        }
        public static void ShowAttackScreen()
        {
            RestaurantRivals.RESRaidAttackScreenUI.ShowScreen<System.Object>(sceneType:  2);
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_10.FadeOutMusic();
        }
        public static void Exit()
        {
            GameBehavior val_1 = App.getBehavior;
            UnityEngine.AsyncOperation val_2 = UnityEngine.SceneManagement.SceneManager.UnloadSceneAsync(sceneName:  null);
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            FinishSpinConclusion();
            twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_10.Play(type:  0, trackIndex:  0);
        }
        public void BackButtonPressed()
        {
            if((this.screenStack != 0) && (this.screenStack >= 1))
            {
                    twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                System.Action val_2 = new System.Action(object:  604396608, method:  new IntPtr(604370560));
                System.Action val_3 = new System.Action(object:  604396608, method:  new IntPtr(604371584));
                public static RestaurantRivals.RESRaidAttackScreenUI MonoSingleton<RestaurantRivals.RESRaidAttackScreenUI>::get_Instance().__il2cppRuntimeField_10.ExtendCurtains(sceneType:  0, onComplete:  7454720, onMiddle:  7454720);
                return;
            }
            
            WordPets.WPTDataParser val_4 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            if(InterstitialEnabled() != false)
            {
                    WordPets.WPTDataParser val_6 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
                if(rewardVideoCapReached != true)
            {
                    twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                if((ShowInterstitial(context:  2)) != false)
            {
                    twelvegigs.Autopilot.AutopilotManager val_10 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                IsAutoSpin = false;
            }
            
            }
            
            }
            
            RestaurantRivals.RESRaidAttackScreenUI.Exit();
        }
        public void ShowConnectionRequired()
        {
            var val_6;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_2 = ShowUGUIMonolith<System.Object>(showNext:  true);
            string val_3 = Localization.Localize(key:  -1725760224, defaultValue:  -1725760096, useSingularKey:  false);
            string val_4 = Localization.Localize(key:  -1725759984, defaultValue:  -1725759840, useSingularKey:  false);
            typeof(System.Boolean[]).__il2cppRuntimeField_10 = 1;
            string val_5 = Localization.Localize(key:  -1827175552, defaultValue:  -1827401456, useSingularKey:  false);
            typeof(System.String[]).__il2cppRuntimeField_10 = "ok_upper";
            typeof(System.String[]).__il2cppRuntimeField_14 = "NULL";
            val_6 = null;
            val_6 = null;
            SetupMessage(titleTxt:  -1725760224, messageTxt:  -1725759984, shownButtons:  1054454320, buttonTexts:  null, showClose:  false, buttonCallbacks:  0, collectAmount:  new System.Decimal() {flags = System.Decimal.MinusOne}, collectType:  "credits");
        }
        private static void ShowScreen<T>(RestaurantRivals.RaidAttackActionType sceneType)
        {
            mem2[0] = sceneType;
            System.Action val_1 = new System.Action(object:  __RuntimeMethodHiddenParam + 24, method:  __RuntimeMethodHiddenParam + 24 + 8);
            RestaurantRivals.RESRaidAttackScreenUI.awakeCommand = null;
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(522423488 == 0)
            {
                    GameBehavior val_4 = App.getBehavior;
                UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  null, mode:  1);
                return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_7 = public static RestaurantRivals.RESRaidAttackScreenUI MonoSingleton<RestaurantRivals.RESRaidAttackScreenUI>::get_Instance().__il2cppRuntimeField_14.Peek();
            public static RestaurantRivals.RESRaidAttackScreenUI MonoSingleton<RestaurantRivals.RESRaidAttackScreenUI>::get_Instance().__il2cppRuntimeField_14.SetActive(value:  false);
            Invoke();
            RestaurantRivals.RESRaidAttackScreenUI.awakeCommand = 0;
        }
        private void DelayPlayAttackBGM()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_10.Play(type:  0, trackIndex:  1);
        }
        private void DelayPlayRaidBGM()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_10.Play(type:  0, trackIndex:  2);
        }
        public RESRaidAttackScreenUI()
        {
            System.Collections.Generic.Stack<com.adjust.sdk.JSONNode> val_1 = new System.Collections.Generic.Stack<com.adjust.sdk.JSONNode>();
            this.screenStack = null;
        }
        private void <BackButtonPressed>b__9_0()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action val_2 = new System.Action(object:  605082944, method:  new IntPtr(605057920));
            public static RestaurantRivals.RESRaidAttackScreenUI MonoSingleton<RestaurantRivals.RESRaidAttackScreenUI>::get_Instance().__il2cppRuntimeField_10.WithdrawCurtains(delay:  null, showReveal:  false, onComplete:  0);
        }
        private void <BackButtonPressed>b__9_2()
        {
            if(this.screenStack != 0)
            {
                    if(this.screenStack > 0)
            {
                    return;
            }
            
            }
            
            RestaurantRivals.RESRaidAttackScreenUI.Exit();
        }
        private void <BackButtonPressed>b__9_1()
        {
            UnityEngine.GameObject val_1 = this.screenStack.Peek();
            if(this.screenStack != 0)
            {
                    this.screenStack.SetActive(value:  false);
                UnityEngine.GameObject val_3 = this.screenStack.Pop();
            }
            
            if(this.screenStack >= 1)
            {
                    UnityEngine.GameObject val_4 = this.screenStack.Peek();
                this.screenStack.SetActive(value:  true);
            }
            
            WordPets.WPTDataParser val_5 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            if(InterstitialEnabled() == false)
            {
                    return;
            }
            
            WordPets.WPTDataParser val_7 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            if(rewardVideoCapReached == true)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((ShowInterstitial(context:  2)) == false)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_11 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            IsAutoSpin = false;
        }
    
    }

}
