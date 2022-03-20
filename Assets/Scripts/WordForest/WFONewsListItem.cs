using UnityEngine;

namespace WordForest
{
    public class WFONewsListItem : MonoBehaviour
    {
        // Fields
        private UnityEngine.UI.Image iconNewsSender;
        private UnityEngine.UI.Image iconNewsType;
        private UnityEngine.UI.Text labelBody;
        private UnityEngine.UI.Text labelTimestamp;
        private UnityEngine.Sprite spriteRefNewsAttack;
        private UnityEngine.Sprite spriteRefNewsRaid;
        private UnityEngine.Sprite spriteRefNewsShield;
        private WordForest.NewsArticle newsData;
        
        // Methods
        public void Initialize(WordForest.NewsArticle data)
        {
            var val_4;
            string val_16;
            UnityEngine.UI.Image val_17;
            UnityEngine.Sprite val_18;
            var val_19;
            var val_20;
            var val_21;
            this.newsData = data;
            System.DateTime val_1 = System.DateTime.UtcNow;
            System.DateTime val_2 = ToUniversalTime();
            System.TimeSpan val_3 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921513531020448}, d2:  new System.DateTime());
            twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            UnityEngine.Sprite val_7 = public static WordForest.RaidAttackManager MonoSingleton<WordForest.RaidAttackManager>::get_Instance().__il2cppRuntimeField_10.GetAvatarSpriteByID(id:  data.sender.avatarId);
            this.iconNewsSender.sprite = public static WordForest.RaidAttackManager MonoSingleton<WordForest.RaidAttackManager>::get_Instance().__il2cppRuntimeField_10;
            val_16 = data.message;
            if((val_16.Contains(value:  249556960)) == false)
            {
                goto label_13;
            }
            
            val_17 = this.iconNewsType;
            val_18 = this.spriteRefNewsShield;
            goto label_17;
            label_13:
            val_16 = data.message;
            if((val_16.Contains(value:  249548608)) == false)
            {
                goto label_16;
            }
            
            val_17 = this.iconNewsType;
            val_18 = this.spriteRefNewsRaid;
            goto label_17;
            label_16:
            if((data.message.Contains(value:  334214272)) == false)
            {
                goto label_19;
            }
            
            val_17 = this.iconNewsType;
            val_18 = this.spriteRefNewsAttack;
            label_17:
            val_17.sprite = val_18;
            label_19:
            double val_11 = val_4.TotalHours;
            if(val_17 < 0)
            {
                    val_19 = "<1h ago";
            }
            else
            {
                    double val_12 = val_4.TotalHours;
                var val_16 = 0;
                if(val_17 < 0)
            {
                    double val_13 = val_4.TotalHours;
                if(val_17 == 0)
            {
                    334238904 = 334238904;
            }
            
                val_20 = null;
                val_21 = "{0}h ago";
            }
            else
            {
                    double val_14 = val_4.TotalDays;
                val_16 = val_16 ^ 2147483648;
                if(val_17 == 0)
            {
                    334238904 = 334238904;
            }
            
                val_20 = null;
                val_21 = "{0}d ago";
            }
            
                string val_15 = System.String.Format(format:  334222752, arg0:  13152256);
                val_19 = val_21;
            }
            
            if(this.labelTimestamp != 0)
            {
                    return;
            }
        
        }
        public WFONewsListItem()
        {
        
        }
    
    }

}
