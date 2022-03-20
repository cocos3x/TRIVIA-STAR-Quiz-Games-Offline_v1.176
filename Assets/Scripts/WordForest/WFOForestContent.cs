using UnityEngine;

namespace WordForest
{
    public class WFOForestContent : MonoBehaviour
    {
        // Fields
        private int forestId;
        private string forestName;
        private UnityEngine.UI.Image darkOverlay;
        private WordForest.WFOTree[] trees;
        private UnityEngine.UI.Image[] forestItems;
        private int currentGrowth;
        private int maxGrowth;
        private int numTreesActive;
        private int numItemsActive;
        private UnityEngine.UI.Image cloneItem;
        private WordForest.RaidXSpotButton[] raidXButtons;
        private UnityEngine.Transform shadowParent;
        private System.Collections.Generic.Queue<DG.Tweening.Sequence> animationQueue;
        private bool animationInProgress;
        
        // Properties
        public int ForestId { get; }
        public string ForestName { get; }
        public WordForest.RaidXSpotButton[] RaidXButtons { get; }
        public WordForest.WFOTree[] Trees { get; }
        
        // Methods
        public int get_ForestId()
        {
            return (int)this.forestId;
        }
        public string get_ForestName()
        {
        
        }
        public WordForest.RaidXSpotButton[] get_RaidXButtons()
        {
        
        }
        public WordForest.WFOTree[] get_Trees()
        {
        
        }
        public System.Collections.Generic.List<UnityEngine.Transform> AddGrowth(int addGrowth = 1)
        {
            WordForest.WFOTree[] val_9;
            int val_10;
            WordForest.WFOTree[] val_11;
            bool val_12;
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            val_9 = this.trees;
            int val_8 = this.currentGrowth;
            val_10 = this.maxGrowth;
            val_8 = val_8 + addGrowth;
            float val_9 = (float)val_10;
            val_9 = (float)val_8 / val_9;
            val_9 = val_9 * (float)val_8;
            int val_3 = UnityEngine.Mathf.FloorToInt(f:  val_9);
            val_11 = this.trees;
            if(val_3 > val_3)
            {
                    return;
            }
            
            int val_12 = this.numTreesActive;
            if(val_12 < val_3)
            {
                    val_10 = 1152921511045563888;
                do
            {
                val_12 = 0;
                if(this.animationInProgress != true)
            {
                    int val_10 = this.numTreesActive;
                val_10 = val_12 - val_10;
                val_12 = val_10 >> 5;
            }
            
                DG.Tweening.Sequence val_4 = this.PlayGrowTreeAnimation(treeID:  val_12, delayGrowth:  val_12);
                DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  287919216);
                WordForest.WFOTree val_11 = this.trees[val_12];
                Add(item:  this.trees[this.numTreesActive][0].growScaler);
                val_12 = val_12 + 1;
            }
            while(val_3 != val_12);
            
            }
            
            this.AddAnimationSequence(nextSequence:  0);
            val_9 = this.maxGrowth;
            float val_13 = (float)val_9;
            val_13 = (float)val_8 / val_13;
            val_13 = val_13 * (float)(float)val_8;
            int val_6 = UnityEngine.Mathf.FloorToInt(f:  val_13);
            val_11 = this.numItemsActive;
            if(val_6 > val_11)
            {
                    val_9 = val_6;
                do
            {
                DG.Tweening.Sequence val_7 = this.PlayNewForestItemSequence(itemID:  val_11);
                this.AddAnimationSequence(nextSequence:  287919216);
                val_11 = val_11 + 1;
            }
            while(val_9 != val_11);
            
                this.numItemsActive = val_9;
            }
            
            this.numTreesActive = val_3;
            this.currentGrowth = val_8;
        }
        public UnityEngine.Transform FixTree(int treeIndex)
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            if(this.animationInProgress != true)
            {
                    int val_4 = this.numTreesActive;
                val_4 = val_4 - treeIndex;
                0 = val_4 >> 5;
            }
            
            DG.Tweening.Sequence val_2 = this.PlayGrowTreeAnimation(treeID:  treeIndex, delayGrowth:  0);
            DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  288231920);
            WordForest.WFOTree val_5 = this.trees[treeIndex];
            this.AddAnimationSequence(nextSequence:  0);
        }
        public void AddAnimationSequence(DG.Tweening.Sequence nextSequence)
        {
            DG.Tweening.TweenCallback val_1 = new DG.Tweening.TweenCallback(object:  288399216, method:  new IntPtr(288369072));
            object val_2 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  nextSequence, action:  190734336);
            if(this.animationInProgress != false)
            {
                    object val_3 = DG.Tweening.TweenExtensions.Pause<System.Object>(t:  nextSequence);
                this.animationQueue.Enqueue(item:  nextSequence);
                return;
            }
            
            this.animationInProgress = true;
        }
        public void Initialize(WordForest.Map forestMap)
        {
            int val_5;
            var val_15;
            var val_16;
            var val_17;
            UnityEngine.Transform val_1 = this.transform;
            UnityEngine.Transform val_2 = this.GetChild(index:  0);
            this.shadowParent = this;
            this.currentGrowth = forestMap.CurrentForestGrowth(includeDamagedTrees:  true);
            WordForest.WFOForestData val_4 = WordForest.WFOGameEconHelper.GetForestEconData(forestId:  288713344);
            this.maxGrowth = val_5;
            float val_15 = (float)val_5;
            val_15 = (float)this.currentGrowth / val_15;
            val_15 = val_15 * (float)(float)this.currentGrowth;
            this.numTreesActive = UnityEngine.Mathf.FloorToInt(f:  val_15);
            System.Collections.Generic.List<WordForest.MapItem> val_7 = val_4.bgType.GetForestData();
            val_15 = val_4.bgType;
            val_16 = 4;
            goto label_7;
            label_16:
            if(val_5 >= val_4.bgType)
            {
                goto label_9;
            }
            
            if((val_4.bgType + 12) <= val_5)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            DG.Tweening.Sequence val_8 = this.trees[0].SetGrowthState(state:  val_4.bgType + 8 + 16 + 16, instant:  true, delayGrowth:  false, shadowParent:  this.shadowParent);
            val_16 = 5;
            label_7:
            if(1 < (val_4.bgType + 12))
            {
                goto label_16;
            }
            
            goto label_21;
            label_9:
            CompanyDevices val_9 = CompanyDevices.Instance;
            val_15 = 0;
            if(val_15.CompanyDevice() != false)
            {
                    UnityEngine.Debug.LogWarning(message:  288618288);
            }
            
            label_21:
            float val_17 = (float)mem[this.forestItems + (8)];
            val_17 = ((float)mem[this.forestItems + (4)]) / val_17;
            val_17 = 0;
            val_17 = val_17 * ((float)mem[this.forestItems + (0)] + 12);
            this.numItemsActive = UnityEngine.Mathf.FloorToInt(f:  val_17);
            goto label_27;
            label_31:
            UnityEngine.UI.Image val_18 = this.forestItems[val_17];
            PluginExtension.SetColorAlpha(graphic:  val_18, a:  0 = 1f);
            val_17 = 1;
            label_27:
            if(val_17 < val_18)
            {
                goto label_31;
            }
            
            UnityEngine.Transform val_12 = this.darkOverlay.transform;
            this.darkOverlay.SetAsLastSibling();
            UnityEngine.GameObject val_13 = this.gameObject;
            T[] val_14 = this.GetComponentsInChildren<System.Object>();
            this.raidXButtons = this;
            this.ToggleRaidXSpots(isVisible:  false);
        }
        public void ToggleRaidXSpots(bool isVisible)
        {
            WordForest.RaidXSpotButton[] val_2;
            var val_3;
            val_2 = this.raidXButtons;
            if(val_2 == null)
            {
                    return;
            }
            
            val_3 = 0;
            goto label_1;
            label_7:
            WordForest.RaidXSpotButton val_2 = this.raidXButtons[val_3];
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
            DG.Tweening.Sequence val_1 = this.trees[treeID].SetGrowthState(state:  1, instant:  false, delayGrowth:  delayGrowth, shadowParent:  this.shadowParent);
        }
        private DG.Tweening.Sequence PlayNewForestItemSequence(int itemID)
        {
            if((new WFOForestContent.<>c__DisplayClass29_0()) != 0)
            {
                    typeof(WFOForestContent.<>c__DisplayClass29_0).__il2cppRuntimeField_8 = this;
            }
            else
            {
                    mem[8] = this;
            }
            
            typeof(WFOForestContent.<>c__DisplayClass29_0).__il2cppRuntimeField_C = itemID;
            DG.Tweening.Sequence val_2 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Tweener val_3 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.darkOverlay, endValue:  null, duration:  null);
            DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.darkOverlay);
            DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  0, interval:  null);
            DG.Tweening.TweenCallback val_6 = new DG.Tweening.TweenCallback(object:  406708224, method:  new IntPtr(289695200));
            DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  0, callback:  190734336);
            DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  0, interval:  null);
            DG.Tweening.Tweener val_9 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.darkOverlay, endValue:  null, duration:  null);
            DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.darkOverlay);
            DG.Tweening.TweenCallback val_11 = new DG.Tweening.TweenCallback(object:  406708224, method:  new IntPtr(289700320));
            DG.Tweening.Sequence val_12 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  0, callback:  190734336);
            UnityEngine.UI.Image val_15 = this.forestItems[typeof(WFOForestContent.<>c__DisplayClass29_0).__il2cppRuntimeField_C];
            DG.Tweening.Tweener val_13 = DG.Tweening.ShortcutExtensions46.DOFade(target:  val_15, endValue:  null, duration:  null);
            DG.Tweening.Sequence val_14 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  val_15);
        }
        public WFOForestContent()
        {
            System.Collections.Generic.Queue<twelvegigs.net.JsonRequest> val_1 = new System.Collections.Generic.Queue<twelvegigs.net.JsonRequest>();
            this.animationQueue = null;
        }
    
    }

}
