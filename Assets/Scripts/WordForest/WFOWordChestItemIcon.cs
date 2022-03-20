using UnityEngine;

namespace WordForest
{
    public class WFOWordChestItemIcon : MonoBehaviour
    {
        // Fields
        private UnityEngine.CanvasGroup canvasGroup;
        private UnityEngine.UI.Image iconImage;
        private UnityEngine.UI.Text iconLabel;
        private WordForest.WFORewardData itemData;
        private UnityEngine.Sprite refIconAcorn;
        private UnityEngine.Sprite refIconCoin;
        private UnityEngine.Sprite refIconAcornMultiplier;
        private UnityEngine.Sprite refIconShield;
        private UnityEngine.Sprite refIconRaid;
        private UnityEngine.Sprite refIconAttack;
        private UnityEngine.Sprite refIconIslandParadise;
        private System.Collections.Generic.Queue<WordForest.WFORewardData> multiplierAnimQueue;
        private decimal multiplierSuffix;
        
        // Properties
        public WordForest.WFORewardData ItemData { get; }
        public WordForest.WFORewardType ItemType { get; }
        public decimal ItemAmount { get; }
        
        // Methods
        public WordForest.WFORewardData get_ItemData()
        {
            var val_2 = R1 + 36;
            return new WordForest.WFORewardData() {id = 351558512, rewardType = 12, amount = new System.Decimal() {flags = R1 + 24}};
        }
        public WordForest.WFORewardType get_ItemType()
        {
        
        }
        public decimal get_ItemAmount()
        {
            return new System.Decimal() {flags = 351782512, hi = R1 + 32};
        }
        public void Initialize(WordForest.WFORewardData rewardData)
        {
            this.itemData = rewardData;
            mem[1152921513548676108] = rewardData.rewardType;
            mem[1152921513548676112] = rewardData.amount.flags;
            mem[1152921513548676116] = rewardData.amount.hi;
            mem[1152921513548676120] = rewardData.amount.lo;
            mem[1152921513548676124] = rewardData.amount.mid;
            mem[1152921513548676128] = rewardData.transformToId;
            this.UpdateLabel();
            if(this != 1)
            {
                    return;
            }
            
            NotificationCenter val_1 = NotificationCenter.DefaultCenter;
            0.AddObserver(observer:  351894512, name:  282911472);
        }
        public void FadeOff(float duration)
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            UnityEngine.Transform val_2 = this.canvasGroup.transform;
            UnityEngine.Vector3 val_3 = new UnityEngine.Vector3(x:  duration, y:  null, z:  null);
            DG.Tweening.Tweener val_4 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.canvasGroup, endValue:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, duration:  duration);
            DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.canvasGroup);
            DG.Tweening.Tweener val_6 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.canvasGroup, endValue:  duration, duration:  null);
            DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.Join(s:  0, t:  this.canvasGroup);
        }
        public void AddMultiplierToAnimationQueue(WordForest.WFORewardData rewardToAppend)
        {
            if(this.multiplierAnimQueue == 0)
            {
                    rewardToAppend.transformToId = rewardToAppend.transformToId;
            }
            
            this.multiplierAnimQueue.Enqueue(item:  new WordForest.WFORewardData() {id = rewardToAppend.id, rewardType = rewardToAppend.rewardType, amount = new System.Decimal() {flags = rewardToAppend.amount.flags, hi = rewardToAppend.amount.hi, lo = rewardToAppend.amount.lo, mid = rewardToAppend.amount.mid}, transformToId = rewardToAppend.transformToId});
        }
        private void OnAcornMultiplierTrailParticleCompleted()
        {
            var val_2;
            int val_3;
            int val_4;
            int val_5;
            var val_8;
            int val_9;
            int val_10;
            int val_11;
            val_8 = this;
            if(true < 1)
            {
                    return;
            }
            
            WordForest.WFORewardData val_1 = Dequeue();
            if(val_2 == 3)
            {
                    val_2 = mem[val_1.transformToId + 28];
                val_2 = val_1.transformToId + 28;
            }
            
            if(val_2 != 1)
            {
                    return;
            }
            
            val_9 = val_3;
            val_10 = val_4;
            val_11 = mem[val_1.transformToId + 84 + (4)];
            val_10 = val_10;
            val_9 = val_9;
            decimal val_7 = System.Decimal.op_Addition(d1:  new System.Decimal() {flags = 352253264, hi = val_1.transformToId + 84, lo = val_11, mid = mem[val_1.transformToId + 84 + (8)]}, d2:  new System.Decimal() {flags = mem[val_1.transformToId + 84 + (12)], hi = val_9, lo = val_10, mid = val_5});
            val_1.transformToId.UpdateLabel();
        }
        private void UpdateLabel()
        {
            UnityEngine.UI.Image val_7;
            UnityEngine.Sprite val_8;
            UnityEngine.Sprite val_9;
            var val_10;
            var val_12;
            bool val_8 = true;
            val_8 = val_8 - 1;
            if(val_8 <= 6)
            {
                    var val_1 = 7534960 + (7534960 + ((true - 1)) << 2);
                if(val_8 == 6)
            {
                    7534960 + ((true - 1)) << 2 = (7534960 + ((true - 1)) << 2) & ((R8) >> 32);
                7534960 + ((true - 1)) << 2 = (7534960 + ((true - 1)) << 2) & (this >> (7534960 + ((true - 1)) << 2));
                7534960 + ((true - 1)) << 2 = (7534960 + ((true - 1)) << 2) & ((7534960 + ((true - 1)) << 2) >> 1);
                7534960 + ((true - 1)) << 2 = (7534960 + ((true - 1)) << 2) & (((int)IP) >> 1);
                7534960 + ((true - 1)) << 2 = (7534960 + ((true - 1)) << 2) & 176207144;
            }
            
                val_7 = this.iconImage;
                val_8 = this.refIconAcorn;
                "x{0}".__il2cppRuntimeField_10.sprite = "x{0}".__il2cppRuntimeField_4C;
            }
            
            val_10 = null;
            val_10 = null;
            if((System.Decimal.op_GreaterThan(d1:  new System.Decimal() {flags = mem[1152921512608449364], hi = R6, lo = R7, mid = R8}, d2:  new System.Decimal() {flags = System.Decimal.One, mid = System.Decimal.Powers10.__il2cppRuntimeField_20})) != false)
            {
                    val_12 = "+{0} x{1}";
                string val_4 = System.String.Format(format:  352390192, arg0:  10170368, arg1:  10170368);
                val_9 = ;
            }
            
            UnityEngine.GameObject val_7 = "x{0}".__il2cppRuntimeField_14.gameObject;
            "x{0}".__il2cppRuntimeField_14.SetActive(value:  false);
        }
        public WFOWordChestItemIcon()
        {
            System.Collections.Generic.Queue<WordForest.WFORewardData> val_1 = new System.Collections.Generic.Queue<WordForest.WFORewardData>();
            this.multiplierAnimQueue = null;
        }
    
    }

}
