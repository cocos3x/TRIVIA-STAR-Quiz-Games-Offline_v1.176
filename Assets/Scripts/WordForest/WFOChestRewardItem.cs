using UnityEngine;

namespace WordForest
{
    public class WFOChestRewardItem : MonoBehaviour
    {
        // Fields
        private UnityEngine.UI.Image rewardIcon;
        private UnityEngine.UI.Text rewardLabel;
        private UnityEngine.CanvasGroup rootCanvasGroup;
        private UnityEngine.RectTransform groupUnlocked;
        private UnityEngine.RectTransform groupLocked;
        private UnityEngine.Sprite spriteAcorn;
        private UnityEngine.Sprite spriteCoin;
        private UnityEngine.Sprite spriteAcornMultiplier;
        private UnityEngine.UI.Text progressText;
        private UnityEngine.UI.Slider progressBar;
        private WordForest.WFORewardData rewardData;
        
        // Methods
        public void Initialize(WordForest.WFORewardData rData)
        {
            UnityEngine.Sprite val_2;
            int val_3;
            WordForest.WFORewardType val_4;
            UnityEngine.UI.Text val_5;
            var val_6;
            var val_7;
            val_2 = rData.id;
            val_3 = rData.transformToId;
            val_4 = rData.rewardType;
            val_3 = rData.transformToId;
            this.rewardData = rData;
            mem[1152921513481258888] = val_4;
            mem[1152921513481258892] = rData.amount.flags;
            mem[1152921513481258896] = rData.amount.hi;
            mem[1152921513481258900] = rData.amount.lo;
            mem[1152921513481258904] = rData.amount.mid;
            mem[1152921513481258908] = val_3;
            if(val_4 == 3)
            {
                goto label_1;
            }
            
            if(val_4 == 2)
            {
                goto label_2;
            }
            
            if(val_4 != 1)
            {
                    return;
            }
            
            val_4 = this.rewardIcon;
            val_2 = this.spriteAcorn;
            goto label_4;
            label_1:
            val_4 = this.rewardIcon;
            val_2 = this.spriteAcornMultiplier;
            val_4.sprite = val_2;
            val_5 = this.rewardLabel;
            val_6 = null;
            val_7 = "x{0}";
            goto label_6;
            label_2:
            val_4 = this.rewardIcon;
            val_2 = this.spriteCoin;
            label_4:
            val_4.sprite = val_2;
            val_5 = this.rewardLabel;
            val_6 = null;
            val_7 = "+{0}";
            label_6:
            string val_1 = System.String.Format(format:  2128510224, arg0:  10170368);
        }
        public void SetLockStatus()
        {
            UnityEngine.GameObject val_1 = this.groupLocked.gameObject;
            this.groupLocked.SetActive(value:  true);
            UnityEngine.GameObject val_2 = this.groupUnlocked.gameObject;
            this.groupUnlocked.SetActive(value:  false);
            this.rootCanvasGroup.alpha = null;
        }
        public void SetProgress(int currentAmount, int targetAmount)
        {
            string val_1 = System.String.Format(format:  1629069648, arg0:  13152256, arg1:  13152256);
            float val_2 = (float)targetAmount;
            val_2 = (float)currentAmount / val_2;
            if(currentAmount < 1)
            {
                    1f = 0.5f;
            }
            
            this.rootCanvasGroup.alpha = 0.5f;
        }
        public WFOChestRewardItem()
        {
        
        }
    
    }

}
