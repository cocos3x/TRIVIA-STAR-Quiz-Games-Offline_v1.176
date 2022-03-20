using UnityEngine;

namespace RestaurantRivals
{
    public class RESNewsPopup : MonoBehaviour
    {
        // Fields
        private UnityEngine.UI.Button closeButton;
        private RestaurantRivals.RESNewsListItem prefabNewsListItem;
        private UnityEngine.UI.ScrollRect scrollRect;
        private static System.Nullable<System.DateTime> lastSeenNewsTimestamp;
        
        // Properties
        public static int UnseenNewsCount { get; }
        public static System.DateTime LastSeenNewsTimestamp { get; set; }
        
        // Methods
        public static int get_UnseenNewsCount()
        {
            var val_11;
            var val_12;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Collections.Generic.List<RestaurantRivals.NewsArticle> val_2 = public static RestaurantRivals.RESRaidAttackManager MonoSingleton<RestaurantRivals.RESRaidAttackManager>::get_Instance().__il2cppRuntimeField_14.NewsArticles;
            val_11 = 0;
            val_12 = 0;
            twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Collections.Generic.List<RestaurantRivals.NewsArticle> val_10 = public static RestaurantRivals.RESRaidAttackManager MonoSingleton<RestaurantRivals.RESRaidAttackManager>::get_Instance().__il2cppRuntimeField_14.NewsArticles;
            return (int);
        }
        public static System.DateTime get_LastSeenNewsTimestamp()
        {
            var val_10;
            string val_1 = UnityEngine.PlayerPrefs.GetString(key:  578482208, defaultValue:  null);
            if((System.String.IsNullOrEmpty(value:  578482208)) != true)
            {
                    System.DateTime val_3 = Newtonsoft.Json.JsonConvert.DeserializeObject<System.DateTime>(value:  578494288);
                System.Nullable<System.DateTime> val_6 = new System.Nullable<System.DateTime>(value:  new System.DateTime() {dateData = 1152921513775263776});
            }
            
            val_10 = null;
            val_10 = null;
            System.Nullable<System.DateTime> val_7 = new System.Nullable<System.DateTime>(value:  new System.DateTime() {dateData = System.DateTime.__il2cppRuntimeField_cctor_finished});
            System.DateTime val_8 = 0.Value;
            return new System.DateTime() {dateData = val_8.dateData};
        }
        public static void set_LastSeenNewsTimestamp(System.DateTime value)
        {
            System.Nullable<System.DateTime> val_1 = new System.Nullable<System.DateTime>(value:  new System.DateTime());
            string val_2 = Newtonsoft.Json.JsonConvert.SerializeObject(value:  9904128);
            UnityEngine.PlayerPrefs.SetString(key:  578482208, value:  9904128);
        }
        private void Start()
        {
            UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  578739536, method:  new IntPtr(578714512));
            this.closeButton.m_OnClick.AddListener(call:  162246656);
            this.Initialize();
        }
        private void CloseWindow()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            SLCWindow.CloseWindow(window:  578859728, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static RestaurantRivals.RESRaidAttackManager MonoSingleton<RestaurantRivals.RESRaidAttackManager>::get_Instance().__il2cppRuntimeField_1C.Notify(note:  5, data:  0);
        }
        private void Initialize()
        {
            var val_5;
            System.Comparison<RestaurantRivals.NewsArticle> val_7;
            RestaurantRivals.NewsArticle val_8;
            var val_9;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Collections.Generic.List<RestaurantRivals.NewsArticle> val_2 = public static RestaurantRivals.RESRaidAttackManager MonoSingleton<RestaurantRivals.RESRaidAttackManager>::get_Instance().__il2cppRuntimeField_14.NewsArticles;
            val_5 = null;
            val_5 = null;
            val_7 = RESNewsPopup.<>c.<>9__11_0;
            if(val_7 == 0)
            {
                    val_7 = null;
                val_7 = new System.Comparison<WordForest.NewsArticle>(object:  RESNewsPopup.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(578947728));
                RESNewsPopup.<>c.<>9__11_0 = val_7;
            }
            
            public static RestaurantRivals.RESRaidAttackManager MonoSingleton<RestaurantRivals.RESRaidAttackManager>::get_Instance().__il2cppRuntimeField_14.Sort(comparison:  7933952);
            val_7 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_9 = mem[public static RestaurantRivals.RESRaidAttackManager MonoSingleton<RestaurantRivals.RESRaidAttackManager>::get_Instance().__il2cppRuntimeField_14 + 8 + 16];
            val_9 = public static RestaurantRivals.RESRaidAttackManager MonoSingleton<RestaurantRivals.RESRaidAttackManager>::get_Instance().__il2cppRuntimeField_14 + 8 + 16;
            if(val_9 == 0)
            {
                goto label_13;
            }
            
            if(val_7 != 1)
            {
                goto label_14;
            }
            
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_9 = mem[public static RestaurantRivals.RESRaidAttackManager MonoSingleton<RestaurantRivals.RESRaidAttackManager>::get_Instance().__il2cppRuntimeField_14 + 8 + 16];
            val_9 = public static RestaurantRivals.RESRaidAttackManager MonoSingleton<RestaurantRivals.RESRaidAttackManager>::get_Instance().__il2cppRuntimeField_14 + 8 + 16;
            if(val_9 == 0)
            {
                goto label_16;
            }
            
            RestaurantRivals.RESNewsPopup.LastSeenNewsTimestamp = new System.DateTime() {dateData = public static RestaurantRivals.RESRaidAttackManager MonoSingleton<RestaurantRivals.RESRaidAttackManager>::get_Instance().__il2cppRuntimeField_14 + 8 + 16 + 24};
            label_14:
            object val_4 = UnityEngine.Object.Instantiate<System.Object>(original:  this.prefabNewsListItem, parent:  this.scrollRect.m_Content);
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_8 = mem[public static RestaurantRivals.RESRaidAttackManager MonoSingleton<RestaurantRivals.RESRaidAttackManager>::get_Instance().__il2cppRuntimeField_14 + 8 + 16];
            val_8 = public static RestaurantRivals.RESRaidAttackManager MonoSingleton<RestaurantRivals.RESRaidAttackManager>::get_Instance().__il2cppRuntimeField_14 + 8 + 16;
            this.prefabNewsListItem.Initialize(data:  val_8);
            val_7 = 1;
            label_13:
            var val_5 = 4 + 1;
            var val_6 = 4 - 3;
            return;
            label_16:
        }
        public RESNewsPopup()
        {
        
        }
    
    }

}
