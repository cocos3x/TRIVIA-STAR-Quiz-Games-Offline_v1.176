using UnityEngine;

namespace RestaurantRivals
{
    public class RESNameAvatarPopup : MonoBehaviour
    {
        // Fields
        private UnityEngine.UI.Image checfIcon;
        private UnityEngine.UI.Button leftArrowBtn;
        private UnityEngine.UI.Button rightArrowBtn;
        private UnityEngine.UI.InputField nameInput;
        private UnityEngine.UI.Button closeBtn;
        private UnityEngine.UI.Button saveBtn;
        private int avatarSpriteIndes;
        
        // Methods
        private void Awake()
        {
            UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  576779392, method:  new IntPtr(576717504));
            this.closeBtn.m_OnClick.AddListener(call:  162246656);
            UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  576779392, method:  new IntPtr(576726720));
            this.leftArrowBtn.m_OnClick.AddListener(call:  162246656);
            UnityEngine.Events.UnityAction val_3 = new UnityEngine.Events.UnityAction(object:  576779392, method:  new IntPtr(576735936));
            this.rightArrowBtn.m_OnClick.AddListener(call:  162246656);
            UnityEngine.Events.UnityAction val_4 = new UnityEngine.Events.UnityAction(object:  576779392, method:  new IntPtr(576745152));
            this.saveBtn.m_OnClick.AddListener(call:  162246656);
            UnityEngine.Events.UnityAction<UnityEngine.UI.LayoutRebuilder> val_5 = new UnityEngine.Events.UnityAction<UnityEngine.UI.LayoutRebuilder>(object:  576779392, method:  new IntPtr(576754368));
            this.nameInput.m_OnValueChanged.AddListener(call:  162353152);
        }
        private void Start()
        {
            RestaurantRivals.RESPlayer val_1 = RestaurantRivals.RESPlayer.Instance;
            this.avatarSpriteIndes = this;
            this.UpdateAvatarSprite();
            RestaurantRivals.RESPlayer val_2 = RestaurantRivals.RESPlayer.Instance;
            this.nameInput.text = 576944640;
            PluginExtension.SetColorAlpha(graphic:  this.nameInput.m_TextComponent, a:  null);
        }
        private void UpdateAvatarSprite()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            UnityEngine.Sprite val_2 = public static RestaurantRivals.RESRaidAttackManager MonoSingleton<RestaurantRivals.RESRaidAttackManager>::get_Instance().__il2cppRuntimeField_C.GetAvatarSpriteByID(id:  this.avatarSpriteIndes);
            this.checfIcon.sprite = public static RestaurantRivals.RESRaidAttackManager MonoSingleton<RestaurantRivals.RESRaidAttackManager>::get_Instance().__il2cppRuntimeField_C;
        }
        private void SavePlayerInfo()
        {
            string val_17;
            var val_18;
            var val_19;
            var val_20;
            var val_21;
            RestaurantRivals.RESPlayer val_1 = RestaurantRivals.RESPlayer.Instance;
            mem[336] = this.avatarSpriteIndes;
            RestaurantRivals.RESPlayer val_3 = RestaurantRivals.RESPlayer.Instance;
            if((System.String.IsNullOrEmpty(value:  this.nameInput.m_Text)) != false)
            {
                    string val_5 = UnityEngine.Random.Range(min:  1000, max:  10000).ToString();
                string val_6 = System.String.Format(format:  -731651520, arg0:  577193468);
                val_17 = "Guest_{0}";
            }
            else
            {
                    val_17 = this.nameInput.m_Text;
            }
            
            mem2[0] = val_17;
            Player val_7 = App.Player;
            0.SaveState();
            twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            RestaurantRivals.RESPlayer val_9 = RestaurantRivals.RESPlayer.Instance;
            RestaurantRivals.RESPlayer val_10 = RestaurantRivals.RESPlayer.Instance;
            System.Nullable<System.Int32> val_11 = new System.Nullable<System.Int32>(value:  public static RestaurantRivals.RESRaidAttackManager MonoSingleton<RestaurantRivals.RESRaidAttackManager>::get_Instance().__il2cppRuntimeField_150);
            public static RestaurantRivals.RESRaidAttackManager MonoSingleton<RestaurantRivals.RESRaidAttackManager>::get_Instance().__il2cppRuntimeField_18.SetMapProfile(level:  new System.Nullable<System.Int32>() {HasValue = false}, map:  0, stars:  new System.Nullable<System.Int32>() {HasValue = false}, shields:  new System.Nullable<System.Int32>() {HasValue = false}, name:  null, avatarid:  new System.Nullable<System.Int32>() {HasValue = false}, responseCallback:  0);
            val_18 = null;
            val_18 = null;
            val_19 = null;
            val_19 = null;
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_12 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            RestaurantRivals.RESPlayer val_13 = RestaurantRivals.RESPlayer.Instance;
            Add(key:  -1988576736, value:  mem[.ctor() + 340]);
            App.trackerManager.track(eventName:  Events.NAME, data:  78753792);
            val_20 = null;
            val_20 = null;
            if(RestaurantRivals.RESFTUXManager.slotPlayDemoPopup != 0)
            {
                    val_21 = null;
                val_21 = null;
                if(RestaurantRivals.RESFTUXManager.CurrentSlotPlayFTUXType == 3)
            {
                    RestaurantRivals.RESFTUXManager.__il2cppRuntimeField_static_fields.OnSequencyFTUXUsed();
                twelvegigs.Autopilot.AutopilotManager val_15 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                ShowMessageByName(ftuxType:  4);
            }
            
            }
            
            twelvegigs.Autopilot.AutopilotManager val_16 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static RestaurantRivals.RESRaidAttackManager MonoSingleton<RestaurantRivals.RESRaidAttackManager>::get_Instance().__il2cppRuntimeField_1C.Notify(note:  0, data:  0);
        }
        public RESNameAvatarPopup()
        {
        
        }
        private void <Awake>b__7_0()
        {
            this.SavePlayerInfo();
        }
        private void <Awake>b__7_1()
        {
            int val_3 = this.avatarSpriteIndes;
            val_3 = val_3 - 1;
            this.avatarSpriteIndes = val_3;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            int val_2 = public static RestaurantRivals.RESRaidAttackManager MonoSingleton<RestaurantRivals.RESRaidAttackManager>::get_Instance().__il2cppRuntimeField_C.AvatarSpritesCount;
            val_2 = val_2 - 1;
            this.avatarSpriteIndes = val_2;
            this.UpdateAvatarSprite();
        }
        private void <Awake>b__7_2()
        {
            int val_1 = this.avatarSpriteIndes + 1;
            this.avatarSpriteIndes = val_1;
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(val_1 == (public static RestaurantRivals.RESRaidAttackManager MonoSingleton<RestaurantRivals.RESRaidAttackManager>::get_Instance().__il2cppRuntimeField_C.AvatarSpritesCount))
            {
                    this.avatarSpriteIndes = 0;
            }
            
            this.UpdateAvatarSprite();
        }
        private void <Awake>b__7_3()
        {
            this.SavePlayerInfo();
        }
        private void <Awake>b__7_4(string str)
        {
            PluginExtension.SetColorAlpha(graphic:  this.nameInput.m_TextComponent, a:  null);
        }
    
    }

}
