using UnityEngine;

namespace RestaurantRivals
{
    public class RESRestaurantContent : MonoBehaviour
    {
        // Fields
        private int levelId;
        private RestaurantRivals.RESRestaurantObject[] objects;
        private UnityEngine.CanvasGroup[] customers;
        private UnityEngine.UI.GraphicRaycaster graphicRaycaster;
        private RestaurantRivals.RaidXSpotButton[] raidXButtons;
        private System.Collections.Generic.Queue<DG.Tweening.Sequence> animationQueue;
        private bool animationInProgress;
        private int <NumObjectsActive>k__BackingField;
        private int <NumCustomerStagesActive>k__BackingField;
        
        // Properties
        public int NumObjectsActive { get; set; }
        public int NumCustomerStagesActive { get; set; }
        public int ForestId { get; }
        public RestaurantRivals.RaidXSpotButton[] RaidXButtons { get; }
        public UnityEngine.UI.GraphicRaycaster RaidRaycaster { get; }
        public RestaurantRivals.RESRestaurantObject[] Objects { get; }
        
        // Methods
        public int get_NumObjectsActive()
        {
            return (int)this.<NumObjectsActive>k__BackingField;
        }
        private void set_NumObjectsActive(int value)
        {
            this.<NumObjectsActive>k__BackingField = value;
        }
        public int get_NumCustomerStagesActive()
        {
            return (int)this.<NumCustomerStagesActive>k__BackingField;
        }
        private void set_NumCustomerStagesActive(int value)
        {
            this.<NumCustomerStagesActive>k__BackingField = value;
        }
        public int get_ForestId()
        {
            return (int)this.levelId;
        }
        public RestaurantRivals.RaidXSpotButton[] get_RaidXButtons()
        {
        
        }
        public UnityEngine.UI.GraphicRaycaster get_RaidRaycaster()
        {
        
        }
        public RestaurantRivals.RESRestaurantObject[] get_Objects()
        {
        
        }
        public System.Collections.Generic.List<UnityEngine.Transform> AddGrowth(int addGrowth = 1)
        {
            bool val_9;
            UnityEngine.CanvasGroup[] val_10;
            int val_11;
            int val_10 = addGrowth;
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            int val_11 = this.<NumObjectsActive>k__BackingField;
            int val_3 = val_11 + val_10;
            if(val_11 < val_3)
            {
                    do
            {
                val_9 = 0;
                if(this.animationInProgress != true)
            {
                    int val_8 = this.<NumObjectsActive>k__BackingField;
                val_8 = val_11 - val_8;
                val_9 = val_8 >> 5;
            }
            
                DG.Tweening.Sequence val_4 = this.PlayGrowTreeAnimation(treeID:  val_11, delayGrowth:  val_9);
                DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  621800736);
                RestaurantRivals.RESRestaurantObject val_9 = this.objects[val_11];
                Add(item:  this.objects[this.<NumObjectsActive>k__BackingField][0].origin);
                val_10 = val_10 - 1;
                val_11 = val_11 + 1;
            }
            while(null != 0);
            
            }
            
            this.AddAnimationSequence(nextSequence:  0);
            val_10 = this.customers;
            float val_12 = (float)S0;
            val_12 = (float)val_3 / val_12;
            val_12 = val_12 * (float)(float)val_3;
            int val_6 = UnityEngine.Mathf.FloorToInt(f:  val_12);
            val_11 = this.<NumCustomerStagesActive>k__BackingField;
            if(val_6 > val_11)
            {
                    val_10 = val_6;
                do
            {
                DG.Tweening.Sequence val_7 = this.PlayNewForestItemSequence(itemID:  val_11);
                this.AddAnimationSequence(nextSequence:  621800736);
                val_11 = val_11 + 1;
            }
            while(val_10 != val_11);
            
                this.<NumCustomerStagesActive>k__BackingField = val_10;
            }
            
            this.<NumObjectsActive>k__BackingField = val_3;
        }
        public int TotalObjectsToGetCustomer(int customerIndex)
        {
            var val_3;
            RestaurantRivals.RESRestaurantObject[] val_4;
            var val_5;
            UnityEngine.CanvasGroup[] val_6;
            val_3 = 0;
            if(customerIndex < 1)
            {
                    return (int)val_3;
            }
            
            goto label_2;
            label_14:
            val_3 = 1;
            label_2:
            val_4 = this.objects;
            if(val_4 == null)
            {
                goto label_3;
            }
            
            if(val_3 <= true)
            {
                goto label_7;
            }
            
            return (int)val_3;
            label_3:
            if(this.objects == null)
            {
                goto label_6;
            }
            
            val_4 = this.objects;
            if(val_3 <= customerIndex)
            {
                goto label_7;
            }
            
            return (int)val_3;
            label_6:
            val_5 = 0;
            label_7:
            int val_1 = UnityEngine.Mathf.FloorToInt(f:  0f);
            val_6 = this.customers;
            float val_3 = 0f;
            val_3 = 1f / val_3;
            val_3 = val_3 * 1f;
            if((UnityEngine.Mathf.FloorToInt(f:  val_3)) != customerIndex)
            {
                goto label_14;
            }
            
            return (int)val_3;
        }
        public UnityEngine.Transform FixTree(int treeIndex)
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            if(this.animationInProgress != true)
            {
                    int val_4 = this.<NumObjectsActive>k__BackingField;
                val_4 = val_4 - treeIndex;
                0 = val_4 >> 5;
            }
            
            DG.Tweening.Sequence val_2 = this.PlayGrowTreeAnimation(treeID:  treeIndex, delayGrowth:  0);
            DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  622557216);
            RestaurantRivals.RESRestaurantObject val_5 = this.objects[treeIndex];
            this.AddAnimationSequence(nextSequence:  0);
        }
        public void AddAnimationSequence(DG.Tweening.Sequence nextSequence)
        {
            DG.Tweening.TweenCallback val_1 = new DG.Tweening.TweenCallback(object:  622723488, method:  new IntPtr(622694368));
            object val_2 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  nextSequence, action:  190734336);
            if(this.animationInProgress != false)
            {
                    object val_3 = DG.Tweening.TweenExtensions.Pause<System.Object>(t:  nextSequence);
                this.animationQueue.Enqueue(item:  nextSequence);
                return;
            }
            
            this.animationInProgress = true;
        }
        public void Initialize(RestaurantRivals.Map restaurantMap)
        {
            var val_17;
            var val_18;
            var val_19;
            var val_20;
            this.<NumObjectsActive>k__BackingField = 0;
            this.<NumCustomerStagesActive>k__BackingField = 0;
            System.Collections.Generic.List<RestaurantRivals.MapItem> val_1 = restaurantMap.GetRestaurantData();
            val_17 = restaurantMap.StarCollected;
            goto label_3;
            label_10:
            RestaurantRivals.RESRestaurantObject val_17 = this.objects[val_17];
            UnityEngine.GameObject val_2 = val_17.gameObject;
            UnityEngine.Object.Destroy(obj:  val_17);
            val_17 = val_17 + 1;
            label_3:
            if(val_17 < val_17)
            {
                goto label_10;
            }
            
            val_18 = 858993459;
            goto label_11;
            label_18:
            UnityEngine.CanvasGroup val_18 = this.customers[val_18];
            UnityEngine.GameObject val_3 = val_18.gameObject;
            UnityEngine.Object.Destroy(obj:  val_18);
            val_18 = 858993460;
            label_11:
            if(val_18 < val_18)
            {
                goto label_18;
            }
            
            System.Collections.Generic.List<TSource> val_4 = System.Linq.Enumerable.ToList<System.Object>(source:  this.objects);
            System.Collections.Generic.List<T> val_5 = this.objects.GetRange(index:  0, count:  restaurantMap.StarCollected);
            T[] val_6 = this.objects.ToArray();
            this.objects = this.objects;
            System.Collections.Generic.List<TSource> val_7 = System.Linq.Enumerable.ToList<System.Object>(source:  this.customers);
            System.Collections.Generic.List<T> val_8 = this.customers.GetRange(index:  0, count:  858993459);
            T[] val_9 = this.customers.ToArray();
            this.customers = this.customers;
            int val_10 = restaurantMap.CurrentRestaurantStage(includeDamagedObjects:  true);
            this.<NumObjectsActive>k__BackingField = val_10;
            float val_19 = (float)restaurantMap.StarCollected;
            val_19 = (float)val_10 / val_19;
            val_19 = val_19 * (8.589935E+08f);
            int val_11 = UnityEngine.Mathf.FloorToInt(f:  val_19);
            this.<NumCustomerStagesActive>k__BackingField = val_11;
            val_19 = 4;
            goto label_26;
            label_35:
            if(val_10 >= val_11)
            {
                goto label_28;
            }
            
            if(restaurantMap.StarCollected <= val_10)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            DG.Tweening.Sequence val_12 = this.objects[0].SetObjectState(state:  val_10 + 16, instant:  true, delayGrowth:  false);
            val_19 = 5;
            label_26:
            if(1 < restaurantMap.StarCollected)
            {
                goto label_35;
            }
            
            goto label_40;
            label_28:
            CompanyDevices val_13 = CompanyDevices.Instance;
            if(0.CompanyDevice() != false)
            {
                    UnityEngine.Debug.LogWarning(message:  623141216);
            }
            
            label_40:
            val_20 = 0;
            goto label_43;
            label_48:
            if(val_20 < (this.<NumCustomerStagesActive>k__BackingField))
            {
                    0 = 1f;
            }
            
            UnityEngine.CanvasGroup val_21 = this.customers[val_20];
            val_21.alpha = val_19;
            val_20 = 1;
            label_43:
            if(val_20 < val_21)
            {
                goto label_48;
            }
            
            UnityEngine.GameObject val_15 = this.gameObject;
            T[] val_16 = this.GetComponentsInChildren<System.Object>();
            this.raidXButtons = this;
            this.ToggleRaidXSpots(isVisible:  false);
        }
        public void ToggleRaidXSpots(bool isVisible)
        {
            RestaurantRivals.RaidXSpotButton[] val_2;
            var val_3;
            val_2 = this.raidXButtons;
            if(val_2 == null)
            {
                    return;
            }
            
            val_3 = 0;
            goto label_1;
            label_7:
            RestaurantRivals.RaidXSpotButton val_2 = this.raidXButtons[val_3];
            UnityEngine.GameObject val_1 = val_2.gameObject;
            val_2.SetActive(value:  isVisible);
            val_2 = this.raidXButtons;
            val_3 = 1;
            label_1:
            if(val_3 < val_2)
            {
                goto label_7;
            }
        
        }
        public System.Collections.Generic.List<RestaurantRivals.RaidXSpotButton> PickRaidSpotButtons()
        {
            int val_5;
            System.Collections.Generic.List<ZooTile> val_1 = new System.Collections.Generic.List<ZooTile>(collection:  this.raidXButtons);
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            var val_5 = 4;
            do
            {
                if(null != 0)
            {
                    val_5 = UnityEngine.Random.Range(min:  0, max:  1094062064);
            }
            else
            {
                    val_5 = UnityEngine.Random.Range(min:  0, max:  1094062064);
            }
            
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
                Add(item:  (System.Collections.Generic.List<T>.__il2cppRuntimeField_name + (val_4) << 2) + 16);
                RemoveAt(index:  val_5);
                val_5 = val_5 - 1;
            }
            while(null != 0);
        
        }
        public void ToggleNextItemSilhouette(bool isOn)
        {
            if((this.<NumObjectsActive>k__BackingField) == this)
            {
                    return;
            }
            
            this.objects[this.<NumObjectsActive>k__BackingField].ToggleSilhouette(isOn:  isOn);
        }
        private void PlayNextSequence()
        {
            if(true >= 1)
            {
                    DG.Tweening.Sequence val_1 = this.animationQueue.Dequeue();
                object val_2 = DG.Tweening.TweenExtensions.Play<System.Object>(t:  this.animationQueue);
                return;
            }
            
            this.animationInProgress = false;
        }
        private DG.Tweening.Sequence PlayGrowTreeAnimation(int treeID, bool delayGrowth = False)
        {
            DG.Tweening.Sequence val_1 = this.objects[treeID].SetObjectState(state:  1, instant:  false, delayGrowth:  delayGrowth);
        }
        private DG.Tweening.Sequence PlayNewForestItemSequence(int itemID)
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_2 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  0, interval:  null);
            UnityEngine.CanvasGroup val_6 = this.customers[itemID];
            DG.Tweening.Tweener val_3 = DG.Tweening.ShortcutExtensions46.DOFade(target:  val_6, endValue:  null, duration:  null);
            DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  val_6);
            DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  0, interval:  null);
        }
        public void ShowItems(bool show)
        {
            var val_3;
            var val_4;
            val_3 = 0;
            goto label_0;
            label_6:
            RestaurantRivals.RESRestaurantObject val_3 = this.objects[val_3];
            UnityEngine.GameObject val_1 = val_3.gameObject;
            val_3.SetActive(value:  show);
            val_3 = 1;
            label_0:
            if(val_3 < val_3)
            {
                goto label_6;
            }
            
            val_4 = 0;
            goto label_7;
            label_13:
            UnityEngine.CanvasGroup val_4 = this.customers[val_4];
            UnityEngine.GameObject val_2 = val_4.gameObject;
            val_4.SetActive(value:  show);
            val_4 = 1;
            label_7:
            if(val_4 < val_4)
            {
                goto label_13;
            }
        
        }
        public RESRestaurantContent()
        {
            System.Collections.Generic.Queue<twelvegigs.net.JsonRequest> val_1 = new System.Collections.Generic.Queue<twelvegigs.net.JsonRequest>();
            this.animationQueue = null;
        }
    
    }

}
