using UnityEngine;

namespace SLC.Minigames
{
    public class MinigameRankSpriteDisplay : MonoBehaviour
    {
        // Fields
        private const string frameWorkBundleName = "minigames_framework";
        private UnityEngine.UI.Image rankImage;
        private SLC.Minigames.MinigameRankSpriteDisplay.RankDisplayType typeOfDisplay;
        
        // Methods
        public void Setup(SLC.Minigames.MinigameLevelRank rank)
        {
            this.DisplaySprite(rank:  rank);
        }
        public void OverrideRankWithFlag()
        {
            WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            UnityEngine.Sprite val_2 = GetSpriteFromBundle(bundleName:  905336192, spriteName:  905336080);
            this.rankImage.sprite = -676860272;
        }
        private void DisplaySprite(SLC.Minigames.MinigameLevelRank rank)
        {
            if(rank.rankLevel > 0)
            {
                    0 = 1;
            }
            
            this.rankImage.enabled = true;
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            mem2[0] = ;
            string val_1 = System.String.Format(format:  905464688, arg0:  446803968, arg1:  rank.rankName);
            WordPets.WPTDataParser val_2 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            UnityEngine.Sprite val_3 = GetSpriteFromBundle(bundleName:  905336192, spriteName:  905464688);
            this.rankImage.sprite = -676860272;
        }
        public MinigameRankSpriteDisplay()
        {
        
        }
    
    }

}
