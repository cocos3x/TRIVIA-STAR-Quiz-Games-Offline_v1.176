using UnityEngine;

namespace RestaurantRivals
{
    public class RESFeatureMenu : WGFeatureMenu
    {
        // Fields
        private UnityEngine.Sprite playSprite;
        private UnityEngine.Sprite restaurantSprite;
        private UnityEngine.Sprite buySprite;
        private UnityEngine.Sprite newsSprite;
        private UnityEngine.Sprite mapSprite;
        
        // Methods
        protected override void SetupMenuItems()
        {
            this.SetupPlayItem();
            this.SetupRestaurantItem();
            this.SetupBuyItem();
            this.SetupNewsItem();
            this.SetupMapItem();
            bool val_1 = AdsManager.ShowAdsControlMenuItem();
            this.SetupMoreGames();
        }
        protected void SetupPlayItem()
        {
            System.Action val_4;
            typeof(RESFeatureMenu.RESFeatureMenuItemConfig).__il2cppRuntimeField_C = 1;
            val_4 = null;
            val_4 = new System.Action(object:  546055792, method:  new IntPtr(546022496));
            if(new WGFeatureMenu.FeatureMenuItemConfig() != 0)
            {
                    typeof(RESFeatureMenu.RESFeatureMenuItemConfig).__il2cppRuntimeField_8 = val_4;
            }
            else
            {
                    mem[8] = val_4;
                val_4 = this.playSprite;
                mem[16] = val_4;
                mem[20] = "Play";
                mem[24] = 1;
            }
            
            typeof(RESFeatureMenu.RESFeatureMenuItemConfig).__il2cppRuntimeField_1C = 1;
            FeatureMenuItem val_3 = this.getNewItem();
            if(this == 0)
            {
                
            }
        
        }
        private void OnClickPlayItem()
        {
            var val_5 = 1152921504892043264;
            GameBehavior val_1 = App.getBehavior;
            UnityEngine.SceneManagement.Scene val_2 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
            string val_3 = val_2.m_Handle.name;
            if(0 == 2)
            {
                    this.Close();
                return;
            }
            
            GameBehavior val_4 = App.getBehavior;
        }
        protected void SetupRestaurantItem()
        {
            var val_15;
            typeof(RESFeatureMenu.RESFeatureMenuItemConfig).__il2cppRuntimeField_C = 1;
            System.Action val_2 = new System.Action(object:  546297296, method:  new IntPtr(546263984));
            if(new WGFeatureMenu.FeatureMenuItemConfig() != 0)
            {
                    typeof(RESFeatureMenu.RESFeatureMenuItemConfig).__il2cppRuntimeField_8 = null;
            }
            else
            {
                    mem[8] = null;
                mem[16] = this.restaurantSprite;
                mem[20] = "RESTAURANT";
                mem[24] = 1;
            }
            
            typeof(RESFeatureMenu.RESFeatureMenuItemConfig).__il2cppRuntimeField_1C = 1;
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(CurrentForestContainsDamagedTrees == false)
            {
                goto label_7;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            int val_7 = GetCurrentNumOfDamagedRestaurantItems();
            goto label_11;
            label_7:
            twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_15 = 0;
            if(GetNumOfCanBuyRestaurantItems() < 1)
            {
                goto label_15;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_10 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            label_11:
            string val_12 = GetNumOfCanBuyRestaurantItems().ToString();
            val_15;
            label_15:
            typeof(RESFeatureMenu.RESFeatureMenuItemConfig).__il2cppRuntimeField_24 = val_15;
            FeatureMenuItem val_13 = this.getNewItem();
            if(this != 0)
            {
                    return;
            }
        
        }
        private void OnClickRestaurantItem()
        {
            var val_5 = 1152921504892043264;
            GameBehavior val_1 = App.getBehavior;
            UnityEngine.SceneManagement.Scene val_2 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
            string val_3 = val_2.m_Handle.name;
            if(0 == 5)
            {
                    this.Close();
                return;
            }
            
            GameBehavior val_4 = App.getBehavior;
        }
        protected void SetupBuyItem()
        {
            System.Action val_4;
            typeof(RESFeatureMenu.RESFeatureMenuItemConfig).__il2cppRuntimeField_C = 1;
            val_4 = null;
            val_4 = new System.Action(object:  546538816, method:  new IntPtr(546505488));
            if(new WGFeatureMenu.FeatureMenuItemConfig() != 0)
            {
                    typeof(RESFeatureMenu.RESFeatureMenuItemConfig).__il2cppRuntimeField_8 = val_4;
            }
            else
            {
                    mem[8] = val_4;
                val_4 = this.buySprite;
                mem[16] = val_4;
                mem[20] = "BUY COINS & SPINS";
                mem[24] = 1;
            }
            
            typeof(RESFeatureMenu.RESFeatureMenuItemConfig).__il2cppRuntimeField_1C = 1;
            FeatureMenuItem val_3 = this.getNewItem();
            if(this == 0)
            {
                
            }
        
        }
        private void OnClickBuyItem()
        {
            GameBehavior val_1 = App.getBehavior;
            this.Close();
        }
        protected void SetupMapItem()
        {
            System.Action val_4;
            typeof(RESFeatureMenu.RESFeatureMenuItemConfig).__il2cppRuntimeField_C = 1;
            val_4 = null;
            val_4 = new System.Action(object:  546780304, method:  new IntPtr(546747008));
            if(new WGFeatureMenu.FeatureMenuItemConfig() != 0)
            {
                    typeof(RESFeatureMenu.RESFeatureMenuItemConfig).__il2cppRuntimeField_8 = val_4;
            }
            else
            {
                    mem[8] = val_4;
                val_4 = this.mapSprite;
                mem[16] = val_4;
                mem[20] = "MAP";
                mem[24] = 1;
            }
            
            typeof(RESFeatureMenu.RESFeatureMenuItemConfig).__il2cppRuntimeField_1C = 1;
            FeatureMenuItem val_3 = this.getNewItem();
            if(this == 0)
            {
                
            }
        
        }
        protected override void SetupAdControl()
        {
            WGFeatureMenu.FeatureMenuItemConfig val_1 = new WGFeatureMenu.FeatureMenuItemConfig();
            typeof(RESFeatureMenu.RESFeatureMenuItemConfig).__il2cppRuntimeField_C = 1;
            System.Action val_2 = new System.Action(object:  546900496, method:  new IntPtr(2865188576));
            if(val_1 != 0)
            {
                    typeof(RESFeatureMenu.RESFeatureMenuItemConfig).__il2cppRuntimeField_8 = null;
            }
            else
            {
                    mem[8] = null;
            }
            
            typeof(RESFeatureMenu.RESFeatureMenuItemConfig).__il2cppRuntimeField_10 = null;
            string val_3 = Localization.Localize(key:  -1429769408, defaultValue:  -1429769504, useSingularKey:  false);
            if(val_1 != 0)
            {
                    typeof(RESFeatureMenu.RESFeatureMenuItemConfig).__il2cppRuntimeField_14 = "ads_control_upper";
                typeof(RESFeatureMenu.RESFeatureMenuItemConfig).__il2cppRuntimeField_18 = 0;
            }
            else
            {
                    mem[20] = "ads_control_upper";
                mem[24] = 0;
            }
            
            typeof(RESFeatureMenu.RESFeatureMenuItemConfig).__il2cppRuntimeField_1C = 1;
            FeatureMenuItem val_4 = this.getNewItem();
            if(this == 0)
            {
                
            }
        
        }
        private void OnClickMapItem()
        {
            GameBehavior val_1 = App.getBehavior;
            this.Close();
        }
        protected void SetupNewsItem()
        {
            var val_9;
            var val_10;
            var val_11;
            typeof(RESFeatureMenu.RESFeatureMenuItemConfig).__il2cppRuntimeField_C = 1;
            System.Action val_2 = new System.Action(object:  547134848, method:  new IntPtr(547101520));
            if(new WGFeatureMenu.FeatureMenuItemConfig() != 0)
            {
                    typeof(RESFeatureMenu.RESFeatureMenuItemConfig).__il2cppRuntimeField_8 = null;
                val_9 = 1152921505031553052;
                if(RestaurantRivals.RESNewsPopup.UnseenNewsCount > 0)
            {
                    val_10 = 1;
            }
            
                typeof(RESFeatureMenu.RESFeatureMenuItemConfig).__il2cppRuntimeField_1C = 1;
            }
            else
            {
                    mem[8] = null;
                mem[16] = this.newsSprite;
                mem[20] = "RESTAURANT NEWS";
                mem[24] = 1;
                if(RestaurantRivals.RESNewsPopup.UnseenNewsCount > 0)
            {
                    val_10 = 1;
            }
            
                val_9 = 28;
                mem[28] = 1;
            }
            
            mem[28] = 1;
            val_11 = 0;
            if(RestaurantRivals.RESNewsPopup.UnseenNewsCount >= 1)
            {
                    string val_7 = RestaurantRivals.RESNewsPopup.UnseenNewsCount.ToString();
                val_11;
            }
            
            typeof(RESFeatureMenu.RESFeatureMenuItemConfig).__il2cppRuntimeField_24 = val_11;
            FeatureMenuItem val_8 = this.getNewItem();
            if(this != 0)
            {
                    return;
            }
        
        }
        private void OnClickNewsItem()
        {
            this.Close();
            GameBehavior val_1 = App.getBehavior;
            if(0 == 0)
            {
                
            }
        
        }
        public RESFeatureMenu()
        {
        
        }
    
    }

}
