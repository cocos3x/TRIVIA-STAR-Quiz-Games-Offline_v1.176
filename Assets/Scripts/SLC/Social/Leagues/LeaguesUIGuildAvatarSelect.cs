using UnityEngine;

namespace SLC.Social.Leagues
{
    public class LeaguesUIGuildAvatarSelect : MonoBehaviour
    {
        // Fields
        private UnityEngine.GameObject avatarButtonPrefab;
        private UnityEngine.RectTransform gridTransform;
        private System.Collections.Generic.List<UnityEngine.UI.Image> buttonImages;
        private UnityEngine.UI.Image imageSprite;
        private SLC.Social.Leagues.LeaguesUICreateGuildView editGuildView;
        
        // Properties
        public UnityEngine.UI.Image ImageSpriteToSet { get; set; }
        
        // Methods
        public UnityEngine.UI.Image get_ImageSpriteToSet()
        {
        
        }
        public void set_ImageSpriteToSet(UnityEngine.UI.Image value)
        {
            this.imageSprite = value;
        }
        private void Start()
        {
            int val_9;
            goto label_1;
            label_17:
            object val_1 = new System.Object();
            typeof(LeaguesUIGuildAvatarSelect.<>c__DisplayClass8_0).__il2cppRuntimeField_C = this;
            object val_2 = UnityEngine.Object.Instantiate<System.Object>(original:  this.avatarButtonPrefab, parent:  this.gridTransform);
            string val_3 = ToString();
            string val_4 = -1727467200(-1727467200) + 852764616;
            if(this.avatarButtonPrefab != 0)
            {
                    this.avatarButtonPrefab.name = -1727467200;
            }
            else
            {
                    0.name = -1727467200;
            }
            
            object val_5 = this.avatarButtonPrefab.GetComponent<System.Object>();
            typeof(LeaguesUIGuildAvatarSelect.<>c__DisplayClass8_0).__il2cppRuntimeField_8 = this.avatarButtonPrefab;
            object val_6 = this.avatarButtonPrefab.GetComponent<System.Object>();
            UnityEngine.Events.UnityAction val_7 = new UnityEngine.Events.UnityAction(object:  443342848, method:  new IntPtr(852743440));
            this.avatarButtonPrefab.AddListener(call:  162246656);
            SLC.Social.AvatarConfig val_8 = SLC.Social.Leagues.LeaguesUIManager.guildAvatarHandler;
            UnityEngine.Sprite val_10 = GetAvatarSpriteByID(id:  val_9);
            typeof(LeaguesUIGuildAvatarSelect.<>c__DisplayClass8_0).__il2cppRuntimeField_8.sprite = 442916864;
            0 = val_9 + 1;
            label_1:
            val_9 = 0;
            SLC.Social.AvatarConfig val_11 = SLC.Social.Leagues.LeaguesUIManager.guildAvatarHandler;
            if(0 < AvatarSpritesCount)
            {
                goto label_17;
            }
        
        }
        public void SetSprite(UnityEngine.UI.Image selected)
        {
            this.imageSprite.sprite = selected.m_Sprite;
            if((UnityEngine.Object.op_Implicit(exists:  this.editGuildView)) == false)
            {
                    return;
            }
            
            this.editGuildView.OnClubImageChanged();
        }
        public LeaguesUIGuildAvatarSelect()
        {
        
        }
    
    }

}
