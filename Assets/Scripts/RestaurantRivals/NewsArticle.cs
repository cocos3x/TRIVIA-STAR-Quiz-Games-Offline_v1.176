using UnityEngine;

namespace RestaurantRivals
{
    public class NewsArticle
    {
        // Fields
        public RestaurantRivals.NewsArticle.Sender sender;
        public string action;
        public string amount;
        public System.DateTime time;
        
        // Methods
        public NewsArticle(RestaurantRivals.UserRestaurantProfile _user, RestaurantRivals.RESOffensiveAction _action, System.DateTime _time, decimal _amount)
        {
            System.DateTime val_2;
            int val_4;
            string val_5;
            string val_6;
            if(_user != 0)
            {
                    val_4 = _user.avatarId;
                val_5 = _user.name;
            }
            else
            {
                    val_5 = 2621443;
                val_4 = 0;
            }
            
            object val_1 = new System.Object();
            typeof(NewsArticle.Sender).__il2cppRuntimeField_8 = val_5;
            this.sender = null;
            if(_action == 0)
            {
                goto label_3;
            }
            
            if(_action == 2)
            {
                goto label_4;
            }
            
            if(_action != 1)
            {
                goto label_5;
            }
            
            val_6 = "attack";
            goto label_7;
            label_3:
            val_6 = "stole";
            goto label_7;
            label_4:
            val_6 = "tried";
            label_7:
            this.action = val_6;
            label_5:
            this.time = val_2;
            mem[1152921513792739772] = _amount.flags;
            string val_3 = _amount.hi.ToString();
            this.amount = _amount.hi;
        }
        public NewsArticle()
        {
        
        }
    
    }

}
