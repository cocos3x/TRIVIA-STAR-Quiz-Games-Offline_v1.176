using UnityEngine;

namespace SLC.Social
{
    public class AvatarConfig : ScriptableObject
    {
        // Fields
        private UnityEngine.Sprite[] avatarSprites;
        
        // Properties
        public int AvatarSpritesCount { get; }
        
        // Methods
        public int get_AvatarSpritesCount()
        {
            if(this.avatarSprites != null)
            {
                    return (int)this;
            }
            
            return (int)this;
        }
        public UnityEngine.Sprite GetAvatarSpriteByID(int id)
        {
            UnityEngine.Sprite[] val_5;
            var val_7;
            if(id <= 1)
            {
                goto label_1;
            }
            
            val_5 = this.avatarSprites;
            if(true <= id)
            {
                goto label_3;
            }
            
            if(true > id)
            {
                goto label_14;
            }
            
            label_15:
            label_14:
            goto label_6;
            label_1:
            string val_1 = 800505488 + 13152256;
            UnityEngine.Debug.LogWarning(message:  800505488);
            if(this.avatarSprites == null)
            {
                goto label_9;
            }
            
            val_5 = this.avatarSprites;
            val_7 = UnityEngine.Random.Range(min:  0, max:  0);
            goto label_10;
            label_3:
            string val_3 = 800505488 + 13152256;
            UnityEngine.Debug.LogWarning(message:  800505488);
            if(("Returning random Avatar Sprite for: ") != 0)
            {
                goto label_14;
            }
            
            goto label_15;
            label_9:
            val_5 = 12;
            val_7 = UnityEngine.Random.Range(min:  0, max:  0);
            label_10:
            label_6:
            UnityEngine.Sprite val_5 = this.avatarSprites[val_7];
        }
        public int GetIDByAvatarSprite(UnityEngine.Sprite sprite, bool randomIfNotFound = False)
        {
            var val_2 = 0;
            goto label_1;
            label_8:
            UnityEngine.Sprite val_2 = this.avatarSprites[val_2];
            bool val_1 = UnityEngine.Object.op_Equality(x:  sprite, y:  val_2);
            if(val_1 == true)
            {
                    return (int)val_2;
            }
            
            val_2 = 1;
            label_1:
            if(val_2 < val_1)
            {
                goto label_8;
            }
            
            if(randomIfNotFound == false)
            {
                    return (int)val_2;
            }
            
            if(this.avatarSprites != null)
            {
                    return UnityEngine.Random.Range(min:  0, max:  val_2);
            }
            
            return UnityEngine.Random.Range(min:  0, max:  val_2);
        }
        public AvatarConfig()
        {
        
        }
    
    }

}
