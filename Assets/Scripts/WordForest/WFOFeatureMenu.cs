using UnityEngine;

namespace WordForest
{
    public class WFOFeatureMenu : WGFeatureMenu
    {
        // Fields
        private UnityEngine.Sprite forestsSprite;
        private UnityEngine.Sprite newsSprite;
        
        // Methods
        protected override void SetupMenuItems()
        {
            this.SetupForestsItem();
            this.SetupNewsItem();
            this.SetupDailyChallenge();
            this.SetupLeaguesItem();
            if(AdsManager.ShowAdsControlMenuItem() != false)
            {
                    this.SetupAdControl();
            }
            
            this.SetupMoreGames();
        }
        protected void SetupForestsItem()
        {
            UnityEngine.Sprite val_14;
            bool val_15;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            GameBehavior val_3 = App.getBehavior;
            WordForest.WFOGameEcon val_4 = WordForest.WFOGameEcon.Instance;
            if(0 >= 786450)
            {
                    0 = 1;
            }
            
            typeof(WGFeatureMenu.FeatureMenuItemConfig).__il2cppRuntimeField_C = 1;
            System.Action val_5 = new System.Action(object:  286462064, method:  new IntPtr(286428656));
            if(new WGFeatureMenu.FeatureMenuItemConfig() != 0)
            {
                    typeof(WGFeatureMenu.FeatureMenuItemConfig).__il2cppRuntimeField_8 = null;
                val_14 = this.forestsSprite;
            }
            else
            {
                    mem[8] = null;
                val_14 = this.forestsSprite;
            }
            
            typeof(WGFeatureMenu.FeatureMenuItemConfig).__il2cppRuntimeField_10 = val_14;
            string val_6 = Localization.Localize(key:  286437968, defaultValue:  286437872, useSingularKey:  false);
            typeof(WGFeatureMenu.FeatureMenuItemConfig).__il2cppRuntimeField_14 = "forests_upper";
            WordForest.WFOGameEcon val_7 = WordForest.WFOGameEcon.Instance;
            typeof(WGFeatureMenu.FeatureMenuItemConfig).__il2cppRuntimeField_18 = 786450;
            val_15 = 1;
            if((AffordableGrowthStages <= 0) && (IsForestChestCollected != false))
            {
                    val_15 = 0;
                if(IsAtMaxGrowth != false)
            {
                    val_15 = IsAtLastForest ^ 1;
            }
            
            }
            
            typeof(WGFeatureMenu.FeatureMenuItemConfig).__il2cppRuntimeField_1C = val_15;
            FeatureMenuItem val_12 = this.getNewItem();
            if(this == 0)
            {
                
            }
        
        }
        private void OnClickForestsItem()
        {
            this.Close();
            GameBehavior val_1 = App.getBehavior;
            if(0 == 0)
            {
                
            }
        
        }
        protected void SetupNewsItem()
        {
            UnityEngine.Sprite val_10;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            GameBehavior val_3 = App.getBehavior;
            WordForest.WFOGameEcon val_4 = WordForest.WFOGameEcon.Instance;
            if(0 >= 786450)
            {
                    0 = 1;
            }
            
            typeof(WGFeatureMenu.FeatureMenuItemConfig).__il2cppRuntimeField_C = 1;
            System.Action val_5 = new System.Action(object:  286703648, method:  new IntPtr(286670256));
            if(new WGFeatureMenu.FeatureMenuItemConfig() != 0)
            {
                    typeof(WGFeatureMenu.FeatureMenuItemConfig).__il2cppRuntimeField_8 = null;
                val_10 = this.newsSprite;
            }
            else
            {
                    mem[8] = null;
                val_10 = this.newsSprite;
            }
            
            typeof(WGFeatureMenu.FeatureMenuItemConfig).__il2cppRuntimeField_10 = val_10;
            string val_6 = Localization.Localize(key:  286679552, defaultValue:  286679472, useSingularKey:  false);
            typeof(WGFeatureMenu.FeatureMenuItemConfig).__il2cppRuntimeField_14 = "news_upper";
            WordForest.WFOGameEcon val_7 = WordForest.WFOGameEcon.Instance;
            typeof(WGFeatureMenu.FeatureMenuItemConfig).__il2cppRuntimeField_18 = 786450;
            if(WordForest.WFONewsPopup.UnseenNewsCount > 0)
            {
                    0 = 1;
            }
            
            typeof(WGFeatureMenu.FeatureMenuItemConfig).__il2cppRuntimeField_1C = 1;
            FeatureMenuItem val_9 = this.getNewItem();
            if(this == 0)
            {
                
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
        protected override void SetupEventsItem()
        {
            var val_12;
            GameBehavior val_2 = App.getBehavior;
            typeof(WGFeatureMenu.FeatureMenuItemConfig).__il2cppRuntimeField_C = 0;
            System.Action val_3 = new System.Action(object:  286935920, method:  new IntPtr(2863778832));
            if(new WGFeatureMenu.FeatureMenuItemConfig() != 0)
            {
                    typeof(WGFeatureMenu.FeatureMenuItemConfig).__il2cppRuntimeField_8 = null;
            }
            else
            {
                    mem[8] = null;
            }
            
            typeof(WGFeatureMenu.FeatureMenuItemConfig).__il2cppRuntimeField_10 = 0;
            string val_4 = Localization.Localize(key:  -1431179168, defaultValue:  -1431179248, useSingularKey:  false);
            twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            string val_7 = GetCurrentEventsCount.ToString();
            string val_8 = System.String.Format(format:  286911840, arg0:  286923884);
            val_12 = "({0})";
            string val_9 = System.String.Format(format:  1592589744, arg0:  -1431179168, arg1:  1098586544);
            typeof(WGFeatureMenu.FeatureMenuItemConfig).__il2cppRuntimeField_14 = "{0} {1}";
            typeof(WGFeatureMenu.FeatureMenuItemConfig).__il2cppRuntimeField_18 = 0;
            FeatureMenuItem val_10 = this.getNewItem();
            if(this != 0)
            {
                    return;
            }
        
        }
        public WFOFeatureMenu()
        {
        
        }
    
    }

}
