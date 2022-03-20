using UnityEngine;

namespace RestaurantRivals
{
    public class RESMapListPopup : MonoSingleton<RestaurantRivals.RESMapListPopup>, IRecyclableScrollRectDataSource
    {
        // Fields
        private UnityEngine.Transform mainContentGroup;
        private UnityEngine.CanvasGroup backgroundGroup;
        private UnityEngine.UI.Button closeButton;
        private UnityEngine.Transform restaurantItemParent;
        private RecyclableScrollRect scrollView;
        private UnityEngine.Texture[] restaurantIcons;
        private bool unlockingNewRestaurant;
        private int currentRestaurantID;
        private System.Action TweenInCompleteCallback;
        private System.Action TweenOutBeginCallback;
        
        // Methods
        private void Start()
        {
            UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  574155776, method:  new IntPtr(572368320));
            this.closeButton.m_OnClick.AddListener(call:  162246656);
            this.scrollView.DataSource = this;
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            int val_3 = CurrentRestaurantID;
            val_3 = val_3 - 1;
            this.currentRestaurantID = val_3;
            UnityEngine.GameObject val_4 = this.closeButton.gameObject;
            this.closeButton.SetActive(value:  this.closeButton >> 5);
            this.TweenIn();
            twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((-1537803328) != 0)
            {
                    twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                public static RestaurantRivals.RESSlotUIManager MonoSingleton<RestaurantRivals.RESSlotUIManager>::get_Instance().__il2cppRuntimeField_18.Hide();
            }
            
            twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((-1255657504) != 0)
            {
                    twelvegigs.Autopilot.AutopilotManager val_11 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                public static RestaurantRivals.RESRestaurantUI MonoSingleton<RestaurantRivals.RESRestaurantUI>::get_Instance().__il2cppRuntimeField_24.Hide();
            }
            
            twelvegigs.Autopilot.AutopilotManager val_12 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((-1255657504) == 0)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_14 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            HideNamePopup();
        }
        private void OnDisable()
        {
            System.Action val_1 = new System.Action(object:  574285184, method:  new IntPtr(574260160));
            DeviceKeypressManager.RemoveBackAction(backAction:  7454720);
        }
        public void SetUnlockNewRestaurant()
        {
            this.unlockingNewRestaurant = true;
        }
        public UnityEngine.Texture GetLevelTexture(int level)
        {
            UnityEngine.Texture[] val_2;
            var val_3;
            val_2 = this.restaurantIcons;
            val_3 = level - 1;
            if(val_3 >= this)
            {
                    val_2 = this.restaurantIcons;
                val_3 = level;
            }
            
            UnityEngine.Texture val_1 = this.restaurantIcons[val_3];
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
            DG.Tweening.TweenCallback val_6 = new DG.Tweening.TweenCallback(object:  575128832, method:  new IntPtr(575099712));
            object val_7 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  this.mainContentGroup, action:  190734336);
            DG.Tweening.Tweener val_8 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.backgroundGroup, endValue:  val_2, duration:  val_1.m_YMin);
        }
        private void OnTweenInComplete()
        {
            if(this.TweenInCompleteCallback != 0)
            {
                    this.TweenInCompleteCallback.Invoke();
            }
            
            if(this.unlockingNewRestaurant != false)
            {
                    this.DoUnlockNewRestaurantSequence();
                this.unlockingNewRestaurant = false;
            }
            
            System.Action val_1 = new System.Action(object:  575265408, method:  new IntPtr(574260160));
            DeviceKeypressManager.AddBackAction(backAction:  7454720);
        }
        private void DoUnlockNewRestaurantSequence()
        {
            var val_14;
            object val_1 = new System.Object();
            typeof(RESMapListPopup.<>c__DisplayClass18_0).__il2cppRuntimeField_10 = this;
            val_14 = 0;
            DG.Tweening.Sequence val_2 = DG.Tweening.DOTween.Sequence();
            typeof(RESMapListPopup.<>c__DisplayClass18_0).__il2cppRuntimeField_8 = 0;
            ICell val_3 = this.scrollView.FindCellByIndex(Id:  this.currentRestaurantID);
            if(this.scrollView != 0)
            {
                    if(((RecyclableScrollRect.__il2cppRuntimeField_typeHierarchy + (RestaurantRivals.RESMapListItem.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
            {
                    this.scrollView = 0;
            }
            
                val_14 = this.scrollView;
            }
            
            typeof(RESMapListPopup.<>c__DisplayClass18_0).__il2cppRuntimeField_C = val_14;
            DG.Tweening.TweenCallback val_4 = new DG.Tweening.TweenCallback(object:  425664512, method:  new IntPtr(575361600));
            DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  0, callback:  190734336);
            DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  0, interval:  null);
            if(this.currentRestaurantID != 0)
            {
                    DG.Tweening.Sequence val_7 = this.scrollView.ScrollByAmountCell(amountCell:  null, duration:  null, ease:  -1082130432);
                DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.scrollView);
            }
            
            DG.Tweening.TweenCallback val_9 = new DG.Tweening.TweenCallback(object:  425664512, method:  new IntPtr(575366720));
            DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  0, callback:  190734336);
            DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  0, interval:  null);
            DG.Tweening.TweenCallback val_12 = new DG.Tweening.TweenCallback(object:  575391744, method:  new IntPtr(572368320));
            DG.Tweening.Sequence val_13 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  0, callback:  190734336);
        }
        private void OnAndroidBackButtonPressed()
        {
            this.OnCloseButtonClicked();
        }
        public void OnCloseButtonClicked()
        {
            var val_16;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((-1537803328) != 0)
            {
                    twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                public static RestaurantRivals.RESSlotUIManager MonoSingleton<RestaurantRivals.RESSlotUIManager>::get_Instance().__il2cppRuntimeField_18.Show();
            }
            
            twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((-1255657504) != 0)
            {
                    twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                public static RestaurantRivals.RESRestaurantUI MonoSingleton<RestaurantRivals.RESRestaurantUI>::get_Instance().__il2cppRuntimeField_24.Show();
            }
            
            twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((-1255657504) != 0)
            {
                    twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                ShowNamePopup();
            }
            
            if(this.TweenOutBeginCallback != 0)
            {
                    this.TweenOutBeginCallback.Invoke();
            }
            
            if(this.mainContentGroup != 0)
            {
                    if(null != null)
            {
                    val_16 = 0;
            }
            
            }
            else
            {
                    val_16 = 0;
            }
            
            UnityEngine.Rect val_10 = rect;
            float val_11 = width;
            DG.Tweening.Tweener val_12 = DG.Tweening.ShortcutExtensions.DOLocalMoveX(target:  this.mainContentGroup, endValue:  val_11, duration:  val_10.m_YMin, snapping:  true);
            DG.Tweening.TweenCallback val_13 = new DG.Tweening.TweenCallback(object:  575641344, method:  new IntPtr(575612224));
            object val_14 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  this.mainContentGroup, action:  190734336);
            DG.Tweening.Tweener val_15 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.backgroundGroup, endValue:  val_11, duration:  val_10.m_YMin);
        }
        public int GetItemCount()
        {
            System.Collections.Generic.List<RestaurantRivals.RESLevelDef> val_1 = RestaurantRivals.RESGameEcon.LevelDefs;
            if(0 != 0)
            {
                    return 0;
            }
            
            return 0;
        }
        public void SetCell(ICell cell, int index)
        {
            var val_3;
            var val_4;
            var val_5;
            int val_3 = index;
            System.Collections.Generic.List<RestaurantRivals.RESLevelDef> val_1 = RestaurantRivals.RESGameEcon.LevelDefs;
            val_3 = 0;
            val_4 = this.GetItemCount();
            val_3 = val_4 + (~val_3);
            if(0 <= val_3)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_4 = 0;
            val_4 = val_4 + (val_3 << 2);
            if(cell != 0)
            {
                    val_3 = 1152921505032404992;
                val_5 = null;
                val_5 = null;
                if(((ICell.__il2cppRuntimeField_typeHierarchy + (RestaurantRivals.RESMapListItem.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != val_5)
            {
                    cell = 0;
            }
            
            }
            
            0.SetForestInfo(levelData:  (0 + ((val_2 + ~(index))) << 2) + 16);
        }
        public int GetStartPos()
        {
            var val_6;
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            int val_3 = CurrentRestaurantID;
            val_6 = this.GetItemCount() - val_3;
            int val_4 = val_3.GetItemCount();
            if(val_6 > val_4)
            {
                    int val_5 = val_4.GetItemCount();
                val_6 = val_5;
            }
            
            val_5 = val_6 & (~(val_6 >> 31));
            return (int)val_5;
        }
        public RESMapListPopup()
        {
        
        }
        private void <OnCloseButtonClicked>b__20_0()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            SLCWindow.CloseWindow(window:  576226944, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        }
    
    }

}
