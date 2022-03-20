using UnityEngine;

namespace WordForest
{
    public class WFOEventIconListPanel : MonoBehaviour
    {
        // Fields
        private const float REFRESH_INTERVAL = 4;
        private float refreshTimer;
        protected UnityEngine.GameObject buttonParentContainer;
        protected WordForest.WFOMiniEventButton buttonAttackMadness;
        protected WordForest.WFOMiniEventButton buttonRaidMadness;
        protected WordForest.WFOMiniEventButton buttonForestMaster;
        protected WordForest.WFOMiniEventButton buttonLightningLevels;
        protected WordForest.WFOMiniEventButton buttonWildWord;
        protected WordForest.WFOMiniEventButton buttonIslandParadise;
        protected WordForest.WFOMiniEventButton buttonWordHunt;
        private System.Collections.Generic.Dictionary<string, WordForest.WFOMiniEventButton> buttonList;
        private static System.Collections.Generic.Dictionary<string, bool> isButtonTypeShown;
        
        // Methods
        private WordForest.WFOMiniEventButton GetButtonPrefab(string eventId)
        {
            WordForest.WFOMiniEventButton val_9;
            var val_10;
            uint val_1 = _PrivateImplementationDetails_.ComputeStringHash(s:  eventId);
            if(val_1 > 2902602938)
            {
                goto label_1;
            }
            
            if(val_1 > 999457290)
            {
                goto label_2;
            }
            
            if(val_1 == 145907821)
            {
                goto label_3;
            }
            
            val_9 = 0;
            if(val_1 != 999457290)
            {
                    return;
            }
            
            if((System.String.op_Equality(a:  eventId, b:  -1549997168)) == true)
            {
                    val_9 = this.buttonAttackMadness;
            }
            
            return;
            label_1:
            if(val_1 > 3244402182)
            {
                goto label_6;
            }
            
            if(val_1 == 3165936380)
            {
                goto label_7;
            }
            
            val_9 = 0;
            if(val_1 != 3244402182)
            {
                    return;
            }
            
            if((System.String.op_Equality(a:  eventId, b:  -1425319472)) == true)
            {
                    val_9 = this.buttonForestMaster;
            }
            
            return;
            label_2:
            if(val_1 == 2902602938)
            {
                goto label_10;
            }
            
            val_9 = 0;
            if(val_1 != 1751534916)
            {
                    return;
            }
            
            val_10 = "HotNSpicy";
            goto label_12;
            label_6:
            if(val_1 == 3671570374)
            {
                goto label_13;
            }
            
            val_9 = 0;
            if(val_1 != 4210228650)
            {
                    return;
            }
            
            if((System.String.op_Equality(a:  eventId, b:  -1266462304)) == true)
            {
                    val_9 = this.buttonLightningLevels;
            }
            
            return;
            label_3:
            val_10 = "IslandParadiseSymbol";
            label_12:
            if((System.String.op_Equality(a:  eventId, b:  -1266461296)) == true)
            {
                    val_9 = this.buttonIslandParadise;
            }
            
            return;
            label_7:
            if((System.String.op_Equality(a:  eventId, b:  -1298909328)) == true)
            {
                    val_9 = this.buttonWordHunt;
            }
            
            return;
            label_10:
            if((System.String.op_Equality(a:  eventId, b:  -1280644912)) == true)
            {
                    val_9 = this.buttonWildWord;
            }
            
            return;
            label_13:
            if((System.String.op_Equality(a:  eventId, b:  -1298907488)) == true)
            {
                    val_9 = this.buttonRaidMadness;
            }
        
        }
        private void Awake()
        {
            NotificationCenter val_1 = NotificationCenter.DefaultCenter;
            0.AddObserver(observer:  272537312, name:  -1649709888);
            NotificationCenter val_2 = NotificationCenter.DefaultCenter;
            0.AddObserver(observer:  272537312, name:  -1649709760);
            NotificationCenter val_3 = NotificationCenter.DefaultCenter;
            0.AddObserver(observer:  272537312, name:  -1383203024);
        }
        private void OnDestroy()
        {
            NotificationCenter val_1 = NotificationCenter.DefaultCenter;
            0.RemoveObserver(observer:  272649312, name:  -1649709888);
            NotificationCenter val_2 = NotificationCenter.DefaultCenter;
            0.RemoveObserver(observer:  272649312, name:  -1649709760);
            NotificationCenter val_3 = NotificationCenter.DefaultCenter;
            0.RemoveObserver(observer:  272649312, name:  -1383203024);
        }
        private void OnEnable()
        {
            this.UpdateDisplay();
        }
        private void Update()
        {
            float val_1 = UnityEngine.Time.deltaTime;
            uint val_2 = 0;
            val_2 = this.refreshTimer + val_2;
            this.refreshTimer = val_2;
            if()
            {
                    return;
            }
            
            this.Refresh();
            this.refreshTimer = 0f;
        }
        private void Refresh()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            CheckAndRequestServerEvents();
        }
        private void OnGameEventDataReceived()
        {
            this.UpdateDisplay();
        }
        private void OnGameEventControllerUpdate()
        {
            this.UpdateDisplay();
        }
        private void OnGameEventHandlerProgress()
        {
            this.UpdateDisplay();
        }
        private void UpdateDisplay()
        {
            var val_46;
            UnityEngine.Object val_49;
            var val_50;
            UnityEngine.GameObject val_2 = this.buttonParentContainer.gameObject;
            if(WordGameEventsController.EventsEnabled == false)
            {
                goto label_5;
            }
            
            this.buttonParentContainer.SetActive(value:  true);
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_46 = 0;
            System.Collections.Generic.List<WGEventHandler> val_4 = GetOrderedEventHandlers();
            object val_5 = new System.Object();
            Sort(comparer:  405483520);
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_33 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            Dictionary.Enumerator<TKey, TValue> val_34 = GetEnumerator();
            label_62:
            if(0.MoveNext() == false)
            {
                goto label_51;
            }
            
            if(new System.Object() != 0)
            {
                    typeof(WFOEventIconListPanel.<>c__DisplayClass21_0).__il2cppRuntimeField_8 = ???;
            }
            else
            {
                    mem[8] = ???;
                val_49 = mem[8];
            }
            
            if(val_49 != 0)
            {
                goto label_56;
            }
            
            Add(item:  0);
            goto label_62;
            label_56:
            System.Predicate<ZooTile> val_39 = new System.Predicate<ZooTile>(object:  405590016, method:  new IntPtr(273447200));
            if((FindIndex(match:  8040448)) != 1)
            {
                goto label_62;
            }
            
            Add(item:  0);
            goto label_62;
            label_5:
            this.buttonParentContainer.SetActive(value:  false);
            return;
            label_51:
            0.Dispose();
            val_50 = 4;
            var val_46 =  - 4;
        }
        public WFOEventIconListPanel()
        {
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            this.buttonList = null;
        }
        private static WFOEventIconListPanel()
        {
            System.Collections.Generic.Dictionary<System.Type, System.Boolean> val_1 = new System.Collections.Generic.Dictionary<System.Type, System.Boolean>();
            WordForest.WFOEventIconListPanel.isButtonTypeShown = null;
        }
    
    }

}
