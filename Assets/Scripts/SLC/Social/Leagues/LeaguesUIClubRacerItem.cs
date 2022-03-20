using UnityEngine;

namespace SLC.Social.Leagues
{
    public class LeaguesUIClubRacerItem : MonoBehaviour
    {
        // Fields
        private UnityEngine.UI.Image guildImage;
        private UnityEngine.GameObject youGroup;
        private UnityEngine.UI.Text rankDisplay;
        
        // Methods
        public void SetupUI(int avatarId, bool yours, int rank, int displayTier)
        {
            SLC.Social.AvatarConfig val_1 = SLC.Social.Leagues.LeaguesUIManager.guildAvatarHandler;
            UnityEngine.Sprite val_2 = GetAvatarSpriteByID(id:  avatarId);
            this.guildImage.sprite = 442916864;
            this.youGroup.SetActive(value:  yours);
            UnityEngine.Transform val_3 = this.transform;
            if(yours != false)
            {
                    this.SetAsLastSibling();
            }
            else
            {
                    this.SetAsFirstSibling();
            }
            
            string val_4 = rank.ToString();
            if(this.rankDisplay != 0)
            {
                    return;
            }
        
        }
        public LeaguesUIClubRacerItem()
        {
        
        }
    
    }

}
