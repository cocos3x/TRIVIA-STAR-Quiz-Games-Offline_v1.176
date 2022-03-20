using UnityEngine;

namespace SLC.MatchyPics
{
    public class MPIFeatureMenu : WGFeatureMenu
    {
        // Fields
        private UnityEngine.Sprite quitIcon;
        private UnityEngine.UI.Image homeImage;
        
        // Methods
        protected override void SetupMenuItems()
        {
            var val_6;
            GameBehavior val_1 = App.getBehavior;
            if(0 == 1)
            {
                    this.homeImage.sprite = this.quitIcon;
            }
            
            bool val_2 = AdsManager.ShowAdsControlMenuItem();
            UnityEngine.Transform val_3 = this.homeImage.parent;
            UnityEngine.GameObject val_4 = this.homeImage.gameObject;
            val_6 = this.homeImage;
            val_6.SetActive(value:  val_2);
            if(val_2 == false)
            {
                    return;
            }
            
            this.SetupAdControl();
        }
        public MPIFeatureMenu()
        {
        
        }
    
    }

}
