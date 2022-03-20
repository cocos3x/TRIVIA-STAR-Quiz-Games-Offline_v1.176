using UnityEngine;

namespace RestaurantRivals
{
    public class RESEventIconListPanel : MonoBehaviour
    {
        // Fields
        protected UnityEngine.GameObject buttonParentContainer;
        protected RestaurantRivals.RESEventButton buttonAttackMadness;
        protected RestaurantRivals.RESEventButton buttonRaidMadness;
        protected RestaurantRivals.RESEventButton buttonHotSpicySymbols;
        protected RestaurantRivals.RESEventButton buttonRestaurantMaster;
        private System.Collections.Generic.Dictionary<string, RestaurantRivals.RESEventButton> buttonList;
        private static System.Collections.Generic.Dictionary<string, bool> isButtonTypeShown;
        
        // Methods
        private RestaurantRivals.RESEventButton GetButtonPrefab(string eventId)
        {
            RestaurantRivals.RESEventButton val_5;
            var val_6;
            if((System.String.op_Equality(a:  eventId, b:  -1549997168)) != false)
            {
                    val_5 = this.buttonAttackMadness;
            }
            else
            {
                    if((System.String.op_Equality(a:  eventId, b:  -1298907488)) != false)
            {
                    val_5 = this.buttonRaidMadness;
            }
            else
            {
                    val_6 = 0;
                if((System.String.op_Equality(a:  eventId, b:  -1298907680)) != false)
            {
                    val_5 = this.buttonHotSpicySymbols;
            }
            else
            {
                    if((System.String.op_Equality(a:  eventId, b:  -1298908384)) == false)
            {
                    return;
            }
            
                val_5 = this.buttonRestaurantMaster;
            }
            
            }
            
            }
            
            val_6 = mem[this.buttonRestaurantMaster];
        }
        private void Awake()
        {
            NotificationCenter val_1 = NotificationCenter.DefaultCenter;
            0.AddObserver(observer:  531382960, name:  -1649709888);
            NotificationCenter val_2 = NotificationCenter.DefaultCenter;
            0.AddObserver(observer:  531382960, name:  -1649709760);
        }
        private void OnDestroy()
        {
            NotificationCenter val_1 = NotificationCenter.DefaultCenter;
            0.RemoveObserver(observer:  531494960, name:  -1649709888);
            NotificationCenter val_2 = NotificationCenter.DefaultCenter;
            0.RemoveObserver(observer:  531494960, name:  -1649709760);
        }
        private void OnEnable()
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
            twelvegigs.sweepstakes.Distribution val_21;
            var val_31;
            var val_32;
            var val_35;
            if(WordGameEventsController.EventsEnabled == false)
            {
                goto label_3;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Collections.Generic.List<WGEventHandler> val_4 = GetOrderedEventHandlers();
            val_31 = public static WordGameEventsController MonoSingleton<WordGameEventsController>::get_Instance();
            object val_5 = new System.Object();
            Sort(comparer:  423641088);
            val_32 = 4;
            var val_16 =  - 4;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_17 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            Dictionary.Enumerator<TKey, TValue> val_18 = GetEnumerator();
            label_40:
            if(0.MoveNext() == false)
            {
                goto label_35;
            }
            
            object val_22 = new System.Object();
            typeof(RESEventIconListPanel.<>c__DisplayClass13_0).__il2cppRuntimeField_8 = val_21;
            System.Predicate<ZooTile> val_23 = new System.Predicate<ZooTile>(object:  423747584, method:  new IntPtr(531941488));
            if((FindIndex(match:  8040448)) != 1)
            {
                goto label_40;
            }
            
            Add(item:  typeof(RESEventIconListPanel.<>c__DisplayClass13_0).__il2cppRuntimeField_8);
            goto label_40;
            label_3:
            UnityEngine.GameObject val_25 = this.buttonParentContainer.gameObject;
            this.buttonParentContainer.SetActive(value:  false);
            return;
            label_35:
            0.Dispose();
            val_35 = 0;
        }
        public RESEventIconListPanel()
        {
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            this.buttonList = null;
        }
        private static RESEventIconListPanel()
        {
            System.Collections.Generic.Dictionary<System.Type, System.Boolean> val_1 = new System.Collections.Generic.Dictionary<System.Type, System.Boolean>();
            RestaurantRivals.RESEventIconListPanel.isButtonTypeShown = null;
        }
    
    }

}
