using UnityEngine;

namespace WordForest
{
    public class WFOManagerGameplayUI : MonoSingleton<WordForest.WFOManagerGameplayUI>
    {
        // Fields
        private WordForest.WFOGameAcornStatView acornStatView;
        private CoinCurrencyStatView coinStatView;
        private WordForest.WFOShieldStatView shieldStatView;
        private EventButtonPanel eventButtonPanelTab;
        private ExtraWordGameplayIcon extraWordGameplayIcon;
        private WordForest.WFOAcornGameBalanceParticle acornParticleSystem;
        private UnityEngine.Transform acornParticlesContainer;
        private WordRegion wordRegion;
        
        // Properties
        public WordForest.WFOGameAcornStatView AcornStatView { get; }
        public CoinCurrencyStatView CoinStatView { get; }
        public WordForest.WFOShieldStatView ShieldStatView { get; }
        public EventButtonPanel EventButtonPanelTab { get; }
        
        // Methods
        public WordForest.WFOGameAcornStatView get_AcornStatView()
        {
        
        }
        public CoinCurrencyStatView get_CoinStatView()
        {
        
        }
        public WordForest.WFOShieldStatView get_ShieldStatView()
        {
        
        }
        public EventButtonPanel get_EventButtonPanelTab()
        {
        
        }
        private void Start()
        {
            NotificationCenter val_1 = NotificationCenter.DefaultCenter;
            0.AddObserver(observer:  314977312, name:  313547152);
            WordRegion val_2 = WordRegion.instance;
            this.wordRegion = 0;
            System.Action val_3 = new System.Action(object:  314977312, method:  new IntPtr(314952288));
            DeviceKeypressManager.AddBackAction(backAction:  7454720);
        }
        private void OnDestroy()
        {
            NotificationCenter val_1 = NotificationCenter.DefaultCenter;
            0.RemoveObserver(observer:  315089312, name:  313547152);
        }
        private void OnDisable()
        {
            System.Action val_1 = new System.Action(object:  315201312, method:  new IntPtr(314952288));
            DeviceKeypressManager.RemoveBackAction(backAction:  7454720);
        }
        private void OnPlayerMoveUpdated()
        {
            var val_8;
            val_8 = 1152921512824079744;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_3 = public static WordForest.WFOManagerGameplay MonoSingleton<WordForest.WFOManagerGameplay>::get_Instance().__il2cppRuntimeField_C.Dequeue();
            Dictionary.Enumerator<TKey, TValue> val_4 = 0.GetEnumerator();
            val_8 = 1152921512923313824;
            label_12:
            if(0.MoveNext() == false)
            {
                goto label_11;
            }
            
            System.Collections.IEnumerator val_6 = this.PlayAcornParticles(wordIndex:  0, slotIndices:  0);
            UnityEngine.Coroutine val_7 = this.StartCoroutine(routine:  315314336);
            goto label_12;
            label_11:
            0.Dispose();
        }
        private void OnAndroidBackButtonPressed()
        {
            var val_6;
            var val_7;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(PlayingChallenge != false)
            {
                    GameBehavior val_4 = App.getBehavior;
                val_6 = 0;
                val_7 = 1179403647;
            }
            else
            {
                    GameBehavior val_5 = App.getBehavior;
                val_6 = 0;
                val_7 = 1179403647;
            }
        
        }
        public System.Collections.IEnumerator PlayAcornParticles(int wordIndex, System.Collections.Generic.List<int> slotIndices)
        {
            typeof(WFOManagerGameplayUI.<PlayAcornParticles>d__21).__il2cppRuntimeField_8 = 0;
            if(new System.Object() != 0)
            {
                    typeof(WFOManagerGameplayUI.<PlayAcornParticles>d__21).__il2cppRuntimeField_10 = wordIndex;
                typeof(WFOManagerGameplayUI.<PlayAcornParticles>d__21).__il2cppRuntimeField_14 = this;
            }
            else
            {
                    mem[20] = this;
                mem[16] = wordIndex;
            }
            
            typeof(WFOManagerGameplayUI.<PlayAcornParticles>d__21).__il2cppRuntimeField_18 = slotIndices;
        }
        public WFOManagerGameplayUI()
        {
        
        }
    
    }

}
