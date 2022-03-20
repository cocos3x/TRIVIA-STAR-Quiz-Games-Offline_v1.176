using UnityEngine;

namespace WordForest
{
    public class WFONewsPopup : MonoBehaviour
    {
        // Fields
        private UnityEngine.UI.Button closeButton;
        private WordForest.WFONewsListItem prefabNewsListItem;
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
            val_11 = 0;
            System.Collections.Generic.List<WordForest.NewsArticle> val_2 = public static WordForest.RaidAttackManager MonoSingleton<WordForest.RaidAttackManager>::get_Instance().__il2cppRuntimeField_14.NewsArticles;
            val_12 = 0;
            val_11 = 0;
            twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Collections.Generic.List<WordForest.NewsArticle> val_10 = public static WordForest.RaidAttackManager MonoSingleton<WordForest.RaidAttackManager>::get_Instance().__il2cppRuntimeField_14.NewsArticles;
            return (int)val_11;
        }
        public static System.DateTime get_LastSeenNewsTimestamp()
        {
            var val_10;
            string val_1 = UnityEngine.PlayerPrefs.GetString(key:  334624384, defaultValue:  null);
            if((System.String.IsNullOrEmpty(value:  334624384)) != true)
            {
                    System.DateTime val_3 = Newtonsoft.Json.JsonConvert.DeserializeObject<System.DateTime>(value:  334636464);
                System.Nullable<System.DateTime> val_6 = new System.Nullable<System.DateTime>(value:  new System.DateTime() {dateData = 1152921513531405952});
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
            UnityEngine.PlayerPrefs.SetString(key:  334624384, value:  9904128);
        }
        private void Start()
        {
            UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  334881712, method:  new IntPtr(334856688));
            this.closeButton.m_OnClick.AddListener(call:  162246656);
            this.Initialize();
        }
        private void CloseWindow()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            SLCWindow.CloseWindow(window:  335001904, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static WordForest.RaidAttackManager MonoSingleton<WordForest.RaidAttackManager>::get_Instance().__il2cppRuntimeField_1C.Notify(note:  5, data:  0);
        }
        private void Initialize()
        {
            var val_5;
            System.Comparison<WordForest.NewsArticle> val_7;
            WordForest.NewsArticle val_8;
            var val_9;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Collections.Generic.List<WordForest.NewsArticle> val_2 = public static WordForest.RaidAttackManager MonoSingleton<WordForest.RaidAttackManager>::get_Instance().__il2cppRuntimeField_14.NewsArticles;
            val_5 = null;
            val_5 = null;
            val_7 = WFONewsPopup.<>c.<>9__11_0;
            if(val_7 == 0)
            {
                    val_7 = null;
                val_7 = new System.Comparison<WordForest.NewsArticle>(object:  WFONewsPopup.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(335089904));
                WFONewsPopup.<>c.<>9__11_0 = val_7;
            }
            
            public static WordForest.RaidAttackManager MonoSingleton<WordForest.RaidAttackManager>::get_Instance().__il2cppRuntimeField_14.Sort(comparison:  7933952);
            val_7 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_9 = mem[public static WordForest.RaidAttackManager MonoSingleton<WordForest.RaidAttackManager>::get_Instance().__il2cppRuntimeField_14 + 8 + 16];
            val_9 = public static WordForest.RaidAttackManager MonoSingleton<WordForest.RaidAttackManager>::get_Instance().__il2cppRuntimeField_14 + 8 + 16;
            if(val_9 == 0)
            {
                goto label_13;
            }
            
            if(val_7 != 1)
            {
                goto label_14;
            }
            
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_9 = mem[public static WordForest.RaidAttackManager MonoSingleton<WordForest.RaidAttackManager>::get_Instance().__il2cppRuntimeField_14 + 8 + 16];
            val_9 = public static WordForest.RaidAttackManager MonoSingleton<WordForest.RaidAttackManager>::get_Instance().__il2cppRuntimeField_14 + 8 + 16;
            if(val_9 == 0)
            {
                goto label_16;
            }
            
            WordForest.WFONewsPopup.LastSeenNewsTimestamp = new System.DateTime() {dateData = public static WordForest.RaidAttackManager MonoSingleton<WordForest.RaidAttackManager>::get_Instance().__il2cppRuntimeField_14 + 8 + 16 + 16};
            label_14:
            object val_4 = UnityEngine.Object.Instantiate<System.Object>(original:  this.prefabNewsListItem, parent:  this.scrollRect.m_Content);
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_8 = mem[public static WordForest.RaidAttackManager MonoSingleton<WordForest.RaidAttackManager>::get_Instance().__il2cppRuntimeField_14 + 8 + 16];
            val_8 = public static WordForest.RaidAttackManager MonoSingleton<WordForest.RaidAttackManager>::get_Instance().__il2cppRuntimeField_14 + 8 + 16;
            this.prefabNewsListItem.Initialize(data:  val_8);
            val_7 = 1;
            label_13:
            var val_5 = 4 + 1;
            var val_6 = 4 - 3;
            return;
            label_16:
        }
        public WFONewsPopup()
        {
        
        }
    
    }

}
