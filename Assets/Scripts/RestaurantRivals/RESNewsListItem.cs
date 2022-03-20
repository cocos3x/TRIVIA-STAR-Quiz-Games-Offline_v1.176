using UnityEngine;

namespace RestaurantRivals
{
    public class RESNewsListItem : MonoBehaviour
    {
        // Fields
        private UnityEngine.UI.Image iconNewsSender;
        private UnityEngine.UI.Image iconNewsType;
        private UnityEngine.UI.Text infoText;
        private UnityEngine.UI.Text labelTimestamp;
        private UnityEngine.Sprite spriteRefNewsAttack;
        private UnityEngine.Sprite spriteRefNewsRaid;
        private UnityEngine.Sprite spriteRefNewsShield;
        private RestaurantRivals.NewsArticle newsData;
        
        // Methods
        public void Initialize(RestaurantRivals.NewsArticle data)
        {
            var val_4;
            UnityEngine.Sprite val_19;
            var val_20;
            var val_21;
            var val_22;
            var val_23;
            this.newsData = data;
            System.DateTime val_1 = System.DateTime.UtcNow;
            System.DateTime val_2 = ToUniversalTime();
            System.TimeSpan val_3 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921513774870080}, d2:  new System.DateTime());
            twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            UnityEngine.Sprite val_7 = public static RestaurantRivals.RESRaidAttackManager MonoSingleton<RestaurantRivals.RESRaidAttackManager>::get_Instance().__il2cppRuntimeField_C.GetAvatarSpriteByID(id:  data.sender.avatarId);
            val_19 = public static RestaurantRivals.RESRaidAttackManager MonoSingleton<RestaurantRivals.RESRaidAttackManager>::get_Instance().__il2cppRuntimeField_C;
            this.iconNewsSender.sprite = val_19;
            string val_8 = System.String.Format(format:  578022848, arg0:  data.sender.name);
            if((System.String.op_Equality(a:  data.action, b:  249556960)) == false)
            {
                goto label_12;
            }
            
            this.iconNewsType.sprite = this.spriteRefNewsShield;
            label_24:
            val_20 = "tried to attack your restaurant!";
            goto label_14;
            label_12:
            if((System.String.op_Equality(a:  data.action, b:  249548608)) == false)
            {
                goto label_15;
            }
            
            val_19 = this.spriteRefNewsRaid;
            this.iconNewsType.sprite = val_19;
            string val_11 = System.String.Format(format:  578051792, arg0:  data.amount);
            val_20 = "stole {0} from you!";
            label_14:
            string val_12 = 578022848 + 578051792;
            label_22:
            double val_13 = val_4.TotalHours;
            if(this.infoText >= 0)
            {
                goto label_18;
            }
            
            val_21 = "<1h ago";
            goto label_19;
            label_18:
            double val_14 = val_4.TotalHours;
            var val_19 = 0;
            if(this.infoText >= 0)
            {
                goto label_20;
            }
            
            double val_15 = val_4.TotalHours;
            if(this.infoText == 0)
            {
                    578088536 = 578088536;
            }
            
            val_22 = null;
            val_23 = "{0}h ago";
            goto label_21;
            label_15:
            if((System.String.op_Equality(a:  data.action, b:  249556880)) == false)
            {
                goto label_22;
            }
            
            this.iconNewsType.sprite = this.spriteRefNewsAttack;
            goto label_24;
            label_20:
            double val_17 = val_4.TotalDays;
            val_19 = val_19 ^ 2147483648;
            if(this.infoText == 0)
            {
                    578088536 = 578088536;
            }
            
            val_22 = null;
            val_23 = "{0}d ago";
            label_21:
            string val_18 = System.String.Format(format:  334222752, arg0:  13152256);
            val_21 = val_23;
            label_19:
            if(this.labelTimestamp != 0)
            {
                    return;
            }
        
        }
        public RESNewsListItem()
        {
        
        }
    
    }

}
