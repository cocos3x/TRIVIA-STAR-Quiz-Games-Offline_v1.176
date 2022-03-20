using UnityEngine;

namespace SLC.Social.Leagues
{
    public class LeaguesTutorial_Window : MonoBehaviour
    {
        // Fields
        private UnityEngine.GameObject[] pages;
        private UnityEngine.UI.Button blockerButton;
        private UnityEngine.UI.Button bgButton;
        private int currPageIndex;
        
        // Methods
        private void Start()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((-747685408) == 0)
            {
                    UnityEngine.GameObject val_3 = this.gameObject;
                SLCWindow.CloseWindow(window:  883250224, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
                return;
            }
            
            this.AdvancePage();
        }
        public void AdvancePage()
        {
            float val_12;
            float val_13;
            float val_16;
            float val_17;
            float val_20;
            float val_21;
            float val_24;
            float val_25;
            int val_29;
            var val_30;
            UnityEngine.Events.UnityAction val_31;
            ButtonClickedEvent val_32;
            var val_33;
            object val_1 = new System.Object();
            typeof(LeaguesTutorial_Window.<>c__DisplayClass5_0).__il2cppRuntimeField_C = this;
            if(this.currPageIndex != 1)
            {
                    this.pages[this.currPageIndex].SetActive(value:  false);
                twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                public static SLC.Social.Leagues.LeaguesUIManager MonoSingleton<SLC.Social.Leagues.LeaguesUIManager>::get_Instance().__il2cppRuntimeField_24.UnhighlightCurrent();
                val_29 = this.currPageIndex;
            }
            else
            {
                    val_29 = 0;
            }
            
            int val_3 = val_29 + 1;
            this.currPageIndex = val_3;
            if(val_3 >= val_29)
            {
                goto label_12;
            }
            
            this.pages[this.currPageIndex].SetActive(value:  true);
            twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            UnityEngine.GameObject val_32 = this.pages[this.currPageIndex];
            UnityEngine.Transform val_5 = val_32.transform;
            UnityEngine.Transform val_6 = public static SLC.Social.Leagues.LeaguesUIManager MonoSingleton<SLC.Social.Leagues.LeaguesUIManager>::get_Instance().__il2cppRuntimeField_24.HighlightByIndex(index:  this.currPageIndex, stage:  val_32, disableButton:  false);
            val_30 = public static SLC.Social.Leagues.LeaguesUIManager MonoSingleton<SLC.Social.Leagues.LeaguesUIManager>::get_Instance().__il2cppRuntimeField_24;
            if(val_30 == null)
            {
                goto label_24;
            }
            
            val_30 = 0;
            val_31 = val_1;
            typeof(LeaguesTutorial_Window.<>c__DisplayClass5_0).__il2cppRuntimeField_8 = val_30;
            goto label_25;
            label_12:
            UnityEngine.GameObject val_7 = this.gameObject;
            SLCWindow.CloseWindow(window:  883622320, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
            return;
            label_24:
            val_31 = val_1;
            typeof(LeaguesTutorial_Window.<>c__DisplayClass5_0).__il2cppRuntimeField_8 = val_30;
            label_25:
            val_30.SetAsFirstSibling();
            UnityEngine.Transform val_8 = this.blockerButton.transform;
            UnityEngine.GameObject val_33 = this.pages[this.currPageIndex];
            UnityEngine.Transform val_9 = val_33.transform;
            this.blockerButton.SetParent(p:  val_33);
            object val_10 = this.blockerButton.GetComponent<System.Object>();
            UnityEngine.Vector2 val_11 = anchorMin;
            this.blockerButton.anchorMin = new UnityEngine.Vector2() {x = val_12, y = val_13};
            object val_14 = this.blockerButton.GetComponent<System.Object>();
            UnityEngine.Vector2 val_15 = anchorMax;
            this.blockerButton.anchorMax = new UnityEngine.Vector2() {x = val_16, y = val_17};
            object val_18 = this.blockerButton.GetComponent<System.Object>();
            UnityEngine.Vector2 val_19 = anchoredPosition;
            this.blockerButton.anchoredPosition = new UnityEngine.Vector2() {x = val_20, y = val_21};
            object val_22 = this.blockerButton.GetComponent<System.Object>();
            UnityEngine.Vector2 val_23 = pivot;
            this.blockerButton.pivot = new UnityEngine.Vector2() {x = val_24, y = val_25};
            object val_26 = this.blockerButton.GetComponent<System.Object>();
            UnityEngine.Vector2 val_27 = sizeDelta;
            this.blockerButton.sizeDelta = new UnityEngine.Vector2();
            this.blockerButton.m_OnClick.RemoveAllListeners();
            if((this.currPageIndex <= 5) && ((52 & (1 << this.currPageIndex)) == 0))
            {
                    val_32 = this.blockerButton.m_OnClick;
                val_31 = null;
                val_31 = new UnityEngine.Events.UnityAction(object:  445579264, method:  new IntPtr(883579888));
                val_32.AddListener(call:  162246656);
                val_33 = 0;
            }
            else
            {
                    val_32 = null;
                val_32 = new UnityEngine.Events.UnityAction(object:  883622320, method:  new IntPtr(883593200));
                this.blockerButton.m_OnClick.AddListener(call:  162246656);
                val_33 = 1;
            }
            
            this.bgButton.interactable = true;
        }
        public void Skip()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static SLC.Social.Leagues.LeaguesUIManager MonoSingleton<SLC.Social.Leagues.LeaguesUIManager>::get_Instance().__il2cppRuntimeField_24.UnhighlightCurrent();
            UnityEngine.GameObject val_2 = this.gameObject;
            SLCWindow.CloseWindow(window:  883992368, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        }
        private void Close()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            SLCWindow.CloseWindow(window:  884104368, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        }
        public LeaguesTutorial_Window()
        {
            this.currPageIndex = 0;
        }
    
    }

}
