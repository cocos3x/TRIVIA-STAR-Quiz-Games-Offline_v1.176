using UnityEngine;

namespace WordForest
{
    public class WFORevengePopup : MonoBehaviour
    {
        // Fields
        private UnityEngine.UI.Button closeButton;
        private WordForest.WFORevengeListItem prefabListItem;
        private UnityEngine.UI.ScrollRect scrollRect;
        
        // Methods
        private void Start()
        {
            UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  340065744, method:  new IntPtr(340040720));
            this.closeButton.m_OnClick.AddListener(call:  162246656);
        }
        private void CloseWindow()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            SLCWindow.CloseWindow(window:  340185936, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        }
        public void Initialize(WordForest.UserForestProfile randomUser, System.Collections.Generic.List<WordForest.UserForestProfile> revengeUserList)
        {
            WordForest.UserForestProfile val_5;
            var val_6;
            System.Action<twelvegigs.storage.JsonDictionary> val_7;
            val_5 = randomUser;
            object val_1 = UnityEngine.Object.Instantiate<System.Object>(original:  this.prefabListItem, parent:  this.scrollRect.m_Content);
            val_6 = this.prefabListItem;
            val_7 = null;
            val_7 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  340333952, method:  new IntPtr(340295440));
            val_6.Initialize(data:  val_5, onBtnClicked:  7401472, isRandomTarget:  true, buttonText:  "RANDOM");
            if(revengeUserList == 0)
            {
                    return;
            }
            
            if(val_6 < 1)
            {
                    return;
            }
            
            val_5 = "REVENGE";
            do
            {
                val_6 = 0;
                if(val_6 <= val_6)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                if(2621443 != 0)
            {
                    object val_3 = UnityEngine.Object.Instantiate<System.Object>(original:  this.prefabListItem, parent:  this.scrollRect.m_Content);
                val_7 = this.prefabListItem;
                if(this.prefabListItem <= val_6)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                System.Action<twelvegigs.storage.JsonDictionary> val_4 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  340333952, method:  new IntPtr(340308928));
                val_7.Initialize(data:  0, onBtnClicked:  7401472, isRandomTarget:  false, buttonText:  "REVENGE");
            }
            
                var val_5 = 4 + 1;
            }
            while((4 - 3) < val_7);
        
        }
        private void OnItemRandomClicked(WordForest.UserForestProfile targetForest)
        {
            object val_1 = new System.Object();
            typeof(WFORevengePopup.<>c__DisplayClass6_0).__il2cppRuntimeField_8 = targetForest;
            UnityEngine.GameObject val_2 = this.gameObject;
            SLCWindow.CloseWindow(window:  340483840, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action val_4 = new System.Action(object:  409583616, method:  new IntPtr(340458816));
            ExtendCurtains(sceneType:  0, onComplete:  7454720);
        }
        private void OnItemRevengeClicked(WordForest.UserForestProfile targetForest)
        {
            object val_1 = new System.Object();
            typeof(WFORevengePopup.<>c__DisplayClass7_0).__il2cppRuntimeField_8 = targetForest;
            UnityEngine.GameObject val_2 = this.gameObject;
            SLCWindow.CloseWindow(window:  340605056, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action val_4 = new System.Action(object:  409636864, method:  new IntPtr(340580032));
            ExtendCurtains(sceneType:  0, onComplete:  7454720);
        }
        public WFORevengePopup()
        {
        
        }
    
    }

}
