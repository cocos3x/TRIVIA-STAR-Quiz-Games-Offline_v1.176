using UnityEngine;

namespace WordForest
{
    public class WFOForestListPopup : MonoBehaviour
    {
        // Fields
        private UnityEngine.Transform mainContentGroup;
        private UnityEngine.CanvasGroup backgroundGroup;
        private UnityEngine.UI.Button closeButton;
        private UnityEngine.Transform forestItemParent;
        private WordForest.WFOForestListItem forestItemPrefab;
        private UnityEngine.UI.ScrollRect scrollView;
        private UnityEngine.Texture[] forestIcons;
        private System.Collections.Generic.List<WordForest.WFOForestListItem> forestList;
        private bool unlockingNewForest;
        private int currentForestID;
        private System.Action TweenInCompleteCallback;
        private System.Action TweenOutBeginCallback;
        
        // Methods
        private void Start()
        {
            UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  292835552, method:  new IntPtr(292810528));
            this.closeButton.m_OnClick.AddListener(call:  162246656);
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            WordForest.WFOPlayer val_3 = WordForest.WFOPlayer.Instance;
            int val_5 = 19;
            val_5 = val_5 - 1;
            this.currentForestID = val_5;
            this.GenerateForestList();
            DG.Tweening.Sequence val_4 = this.ScrollToForest(index:  this.currentForestID, instant:  true);
            this.TweenIn();
        }
        private void OnDisable()
        {
            System.Action val_1 = new System.Action(object:  292956768, method:  new IntPtr(292931744));
            DeviceKeypressManager.RemoveBackAction(backAction:  7454720);
        }
        public void SetUnlockNewForest()
        {
            this.unlockingNewForest = true;
        }
        public void SetOnTweenInCompleteCallback(System.Action callback)
        {
            System.Action val_2 = this.TweenInCompleteCallback;
            System.Delegate val_1 = System.Delegate.Combine(a:  val_2 = this.TweenInCompleteCallback, b:  callback);
            if(val_2 != 0)
            {
                    if(null == null)
            {
                goto label_2;
            }
            
            }
            
            val_2 = 0;
            label_2:
            this.TweenInCompleteCallback = val_2;
        }
        public void SetOnTweenOutBeginCallback(System.Action callback)
        {
            System.Action val_2 = this.TweenOutBeginCallback;
            System.Delegate val_1 = System.Delegate.Combine(a:  val_2 = this.TweenOutBeginCallback, b:  callback);
            if(val_2 != 0)
            {
                    if(null == null)
            {
                goto label_2;
            }
            
            }
            
            val_2 = 0;
            label_2:
            this.TweenOutBeginCallback = val_2;
        }
        private void GenerateForestList()
        {
            WordForest.WFOForestListPopup val_11 = this;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.forestList = null;
            WordForest.WFOGameEcon val_2 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
            var val_11 = mem[1152921512491413460] + 12;
            if((val_11 - 1) < 0)
            {
                    return;
            }
            
            var val_4 = val_11 + 3;
            val_11 = val_11 + (val_11 << 1);
            var val_5 = val_11 << 3;
            do
            {
                int val_6 = val_4 - 4;
                object val_7 = UnityEngine.Object.Instantiate<System.Object>(original:  this.forestItemPrefab, parent:  this.forestItemParent);
                if((mem[1152921512491413460] + 12) <= val_6)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                System.Action val_8 = new System.Action(object:  293485664, method:  new IntPtr(292810528));
                this.forestItemPrefab.SetForestInfo(forestIndex:  val_6, forestData:  new WordForest.WFOForestData() {level = mem[1152921512491413460] + 8 + ((mem[1152921512491413460] + 12 + (mem[1152921512491413460] + 12) << 1) << 3) + -8, forestName = mem[1152921512491413460] + 8 + ((mem[1152921512491413460] + 12 + (mem[1152921512491413460] + 12) << 1) << 3) + -4, initialCost = mem[1152921512491413460] + 8 + ((mem[1152921512491413460] + 12 + (mem[1152921512491413460] + 12) << 1) << 3), costIncrease = mem[1152921512491413460] + 8 + ((mem[1152921512491413460] + 12 + (mem[1152921512491413460] + 12) << 1) << 3) + 4, stages = mem[1152921512491413460] + 8 + ((mem[1152921512491413460] + 12 + (mem[1152921512491413460] + 12) << 1) << 3) + 8, bgType = mem[1152921512491413460] + 8 + ((mem[1152921512491413460] + 12 + (mem[1152921512491413460] + 12) << 1) << 3) + 12}, onItemClicked:  null, forestTexture:  null);
                val_11 = val_11;
                if(val_6 < mem[1152921513490267280])
            {
                    this.forestItemPrefab.SetCompleted();
            }
            else
            {
                    if(val_6 == mem[1152921513490267280])
            {
                    this.forestItemPrefab.SetCurrent();
            }
            else
            {
                    this.forestItemPrefab.SetLocked();
            }
            
            }
            
                Insert(index:  0, item:  this.forestItemPrefab);
                var val_9 = val_4 - 1;
                val_5 = val_5 - 24;
            }
            while((val_4 - 5) > 1);
        
        }
        private DG.Tweening.Sequence ScrollToForest(int index, bool instant = True)
        {
            var val_5 = 0;
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            val_5 = val_5 - 1;
            if(instant != false)
            {
                    this.scrollView.verticalNormalizedPosition = (float)index;
                return;
            }
            
            DG.Tweening.Tweener val_3 = DG.Tweening.ShortcutExtensions46.DOVerticalNormalizedPos(target:  this.scrollView, endValue:  (float)index, duration:  null, snapping:  (float)index / (float)val_5);
            DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.scrollView);
        }
        private void TweenIn()
        {
            var val_9;
            if(this.mainContentGroup != 0)
            {
                    if(null != null)
            {
                    val_9 = 0;
            }
            
            }
            else
            {
                    val_9 = 0;
            }
            
            UnityEngine.Rect val_1 = rect;
            float val_2 = width;
            UnityEngine.Vector3 val_3 = new UnityEngine.Vector3(x:  val_2, y:  val_1.m_YMin, z:  val_1.m_Width);
            this.mainContentGroup.localPosition = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
            this.backgroundGroup.alpha = val_2;
            DG.Tweening.Tweener val_4 = DG.Tweening.ShortcutExtensions.DOLocalMoveX(target:  this.mainContentGroup, endValue:  val_2, duration:  val_1.m_YMin, snapping:  false);
            object val_5 = DG.Tweening.TweenSettingsExtensions.SetDelay<System.Object>(t:  this.mainContentGroup, delay:  val_2);
            DG.Tweening.TweenCallback val_6 = new DG.Tweening.TweenCallback(object:  293792608, method:  new IntPtr(293763488));
            object val_7 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  this.mainContentGroup, action:  190734336);
            DG.Tweening.Tweener val_8 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.backgroundGroup, endValue:  val_2, duration:  val_1.m_YMin);
        }
        private void OnTweenInComplete()
        {
            if(this.TweenInCompleteCallback != 0)
            {
                    this.TweenInCompleteCallback.Invoke();
            }
            
            if(this.unlockingNewForest != false)
            {
                    this.DoUnlockNewForestSequence();
                this.unlockingNewForest = false;
            }
            
            System.Action val_1 = new System.Action(object:  293929184, method:  new IntPtr(292931744));
            DeviceKeypressManager.AddBackAction(backAction:  7454720);
        }
        private void DoUnlockNewForestSequence()
        {
            DG.Tweening.TweenCallback val_14;
            var val_15;
            DG.Tweening.TweenCallback val_17;
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            int val_2 = this.currentForestID + 1;
            this.currentForestID = val_2;
            DG.Tweening.Sequence val_3 = this.ScrollToForest(index:  val_2, instant:  false);
            DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  294055520);
            if(0 <= this.currentForestID)
            {
                    var val_14 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_14 = val_14 + (this.currentForestID << 2);
            DG.Tweening.Sequence val_5 = (0 + (this.currentForestID) << 2) + 16.DoUnlockSequence();
            DG.Tweening.Tween val_16 = (0 + (this.currentForestID) << 2) + 16;
            DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  val_16);
            int val_15 = this.currentForestID;
            val_15 = val_15 - 1;
            if(0 <= val_15)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_16 = val_16 + (val_15 << 2);
            DG.Tweening.TweenCallback val_7 = new DG.Tweening.TweenCallback(object:  ((0 + (this.currentForestID) << 2) + 16 + ((this.currentForestID - 1)) << 2) + 16, method:  new IntPtr(294029472));
            DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  0, callback:  190734336);
            DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  0, interval:  null);
            val_14 = null;
            val_14 = new DG.Tweening.TweenCallback(object:  294055520, method:  new IntPtr(292810528));
            DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  0, callback:  190734336);
            val_15 = null;
            val_15 = null;
            val_17 = WFOForestListPopup.<>c.<>9__21_0;
            if(val_17 == 0)
            {
                    val_17 = null;
                val_17 = new DG.Tweening.TweenCallback(object:  WFOForestListPopup.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(294030496));
                WFOForestListPopup.<>c.<>9__21_0 = val_17;
            }
            
            DG.Tweening.Sequence val_13 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  0, callback:  190734336);
        }
        private void OnAndroidBackButtonPressed()
        {
            this.OnCloseButtonClicked();
        }
        private void OnCloseButtonClicked()
        {
            var val_7;
            if(this.TweenOutBeginCallback != 0)
            {
                    this.TweenOutBeginCallback.Invoke();
            }
            
            if(this.mainContentGroup != 0)
            {
                    if(null != null)
            {
                    val_7 = 0;
            }
            
            }
            else
            {
                    val_7 = 0;
            }
            
            UnityEngine.Rect val_1 = rect;
            float val_2 = width;
            DG.Tweening.Tweener val_3 = DG.Tweening.ShortcutExtensions.DOLocalMoveX(target:  this.mainContentGroup, endValue:  val_2, duration:  val_1.m_YMin, snapping:  true);
            DG.Tweening.TweenCallback val_4 = new DG.Tweening.TweenCallback(object:  294305120, method:  new IntPtr(294276000));
            object val_5 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  this.mainContentGroup, action:  190734336);
            DG.Tweening.Tweener val_6 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.backgroundGroup, endValue:  val_2, duration:  val_1.m_YMin);
        }
        public WFOForestListPopup()
        {
        
        }
        private void <OnCloseButtonClicked>b__23_0()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            SLCWindow.CloseWindow(window:  294545504, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        }
    
    }

}
