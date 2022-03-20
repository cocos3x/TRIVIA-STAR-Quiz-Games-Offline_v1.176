using UnityEngine;

namespace SLC.Social.Leagues
{
    public class LeaguesWelcome_Window : MonoBehaviour
    {
        // Fields
        private AvatarSlotUGUI[] friendAvatars;
        private UnityEngine.UI.Text descriptionText;
        private UnityEngine.UI.Button skipButton;
        private UnityEngine.UI.Button tourButton;
        
        // Methods
        private void Awake()
        {
            UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  885458224, method:  new IntPtr(885423984));
            this.skipButton.m_OnClick.AddListener(call:  162246656);
            UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  885458224, method:  new IntPtr(885433200));
            this.tourButton.m_OnClick.AddListener(call:  162246656);
        }
        private void onClick_Tour()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_2 = ShowUGUIMonolith<System.Object>(showNext:  true);
            UnityEngine.GameObject val_3 = this.gameObject;
            SLCWindow.CloseWindow(window:  885587632, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        }
        private void onClick_Skip()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            SLCWindow.CloseWindow(window:  885699632, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        }
        private void OnEnable()
        {
            var val_19;
            System.Func<SLC.Social.Profile, System.Boolean> val_21;
            var val_22;
            System.Predicate<SLC.Social.Profile> val_24;
            var val_25;
            SLC.Social.Leagues.LeaguesDataController val_1 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Leagues.Guild val_2 = 0.MyGuild;
            if(0 == 0)
            {
                goto label_4;
            }
            
            string val_3 = Localization.Localize(key:  885787808, defaultValue:  885787632, useSingularKey:  false);
            SLC.Social.Leagues.LeaguesDataController val_4 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Leagues.Guild val_5 = 0.MyGuild;
            string val_6 = System.String.Format(format:  885787808, arg0:  0);
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_7 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            SLC.Social.Leagues.LeaguesDataController val_8 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Leagues.Guild val_9 = 0.MyGuild;
            Dictionary.ValueCollection<TKey, TValue> val_10 = 33453552.Values;
            val_19 = null;
            val_19 = null;
            val_21 = LeaguesWelcome_Window.<>c.<>9__7_0;
            if(val_21 == 0)
            {
                    val_21 = null;
                val_21 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  LeaguesWelcome_Window.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(885793040));
                LeaguesWelcome_Window.<>c.<>9__7_0 = val_21;
            }
            
            System.Linq.IOrderedEnumerable<TSource> val_12 = System.Linq.Enumerable.OrderBy<System.Object, System.Boolean>(source:  33453552, keySelector:  7720960);
            AddRange(collection:  33453552);
            val_22 = null;
            val_22 = null;
            val_24 = LeaguesWelcome_Window.<>c.<>9__7_1;
            if(val_24 == 0)
            {
                    val_24 = null;
                val_24 = new System.Predicate<ZooTile>(object:  LeaguesWelcome_Window.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(885797136));
                LeaguesWelcome_Window.<>c.<>9__7_1 = val_24;
            }
            
            int val_14 = RemoveAll(match:  8040448);
            val_25 = 4;
            goto label_25;
            label_40:
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_25 = 5;
            label_25:
            if((val_25 - 4) < )
            {
                goto label_40;
            }
            
            return;
            label_4:
            UnityEngine.Debug.LogError(message:  885917968, context:  885942080);
            System.Collections.IEnumerator val_18 = this.CloseAfterFrame();
            UnityEngine.Coroutine val_19 = this.StartCoroutine(routine:  885942080);
        }
        private System.Collections.IEnumerator CloseAfterFrame()
        {
            object val_1 = new System.Object();
            typeof(LeaguesWelcome_Window.<CloseAfterFrame>d__8).__il2cppRuntimeField_8 = 0;
            typeof(LeaguesWelcome_Window.<CloseAfterFrame>d__8).__il2cppRuntimeField_10 = this;
        }
        private void Close()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            SLCWindow.CloseWindow(window:  886288960, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        }
        public LeaguesWelcome_Window()
        {
        
        }
    
    }

}
