using UnityEngine;

namespace SLC.Social.Leagues
{
    public class LeaguesUICreateGuildView : MonoBehaviour
    {
        // Fields
        private bool editClubMode;
        private UnityEngine.UI.Text clubImageLabel;
        private UnityEngine.UI.Image clubImage;
        private UnityEngine.UI.Text nameInputLabel;
        private UnityEngine.UI.InputField nameInputField;
        private UnityEngine.UI.InputField mottoInputField;
        private UnityEngine.UI.Text vipReqLabel;
        private UnityEngine.UI.Dropdown vipReqDropdown;
        private UnityEngine.UI.Text inviteOnlyLabel;
        private UnityEngine.UI.Dropdown inviteOnlyDropDown;
        private UnityEngine.UI.Button createClubButton;
        private UnityEngine.UI.Text createClubCostText;
        public System.Action<string> showMessageFlyout;
        private int clubImageId;
        private string clubName;
        private string clubMotto;
        private bool clubInviteReq;
        private decimal clubReqAmount;
        
        // Methods
        private void Start()
        {
            this.PopulateVipReqOptions();
            this.PopulateInviteOnlyOptions();
            SLC.Social.AvatarConfig val_1 = SLC.Social.Leagues.LeaguesUIManager.guildAvatarHandler;
            UnityEngine.Sprite val_2 = GetAvatarSpriteByID(id:  0);
            this.clubImage.sprite = 442916864;
            if(this.editClubMode == true)
            {
                    this.editClubMode = this;
                this.PopulateCurrentClubData();
            }
            
            UnityEngine.Events.UnityAction<UnityEngine.UI.LayoutRebuilder> val_3 = new UnityEngine.Events.UnityAction<UnityEngine.UI.LayoutRebuilder>(object:  850447120, method:  new IntPtr(850379088));
            this.nameInputField.m_OnEndEdit.AddListener(call:  162353152);
            if(this.mottoInputField != 0)
            {
                    UnityEngine.Events.UnityAction<UnityEngine.UI.LayoutRebuilder> val_5 = new UnityEngine.Events.UnityAction<UnityEngine.UI.LayoutRebuilder>(object:  850447120, method:  new IntPtr(850392400));
                this.mottoInputField.m_OnEndEdit.AddListener(call:  162353152);
            }
            
            UnityEngine.Events.UnityAction<System.Int32> val_6 = new UnityEngine.Events.UnityAction<System.Int32>(object:  850447120, method:  new IntPtr(850401616));
            this.vipReqDropdown.m_OnValueChanged.AddListener(call:  162353152);
            UnityEngine.Events.UnityAction<System.Int32> val_7 = new UnityEngine.Events.UnityAction<System.Int32>(object:  850447120, method:  new IntPtr(850412880));
            this.inviteOnlyDropDown.m_OnValueChanged.AddListener(call:  162353152);
            UnityEngine.Events.UnityAction val_8 = new UnityEngine.Events.UnityAction(object:  850447120, method:  new IntPtr(850422096));
            this.createClubButton.m_OnClick.AddListener(call:  162246656);
            NotificationCenter val_9 = NotificationCenter.DefaultCenter;
            0.AddObserver(observer:  850447120, name:  -1606468768);
        }
        private void OnClubNameChanged(string _nameImputString)
        {
            this.clubName = _nameImputString;
            this.SubmitClubEdit();
        }
        private void OnClubMottoChanged(string _mottoInputChanged)
        {
            this.clubMotto = _mottoInputChanged;
            this.SubmitClubEdit();
        }
        public void OnClubImageChanged()
        {
            SLC.Social.AvatarConfig val_1 = SLC.Social.Leagues.LeaguesUIManager.guildAvatarHandler;
            this.clubImageId = GetIDByAvatarSprite(sprite:  this.clubImage.m_Sprite, randomIfNotFound:  false);
            this.SubmitClubEdit();
        }
        private void OnClubReqChanged(int _valueSelected)
        {
            var val_4;
            var val_4 = 24483665;
            val_4 = 11152156 + val_4;
            if(val_4 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_4 = null;
            val_4 = null;
            System.Decimal[] val_1 = SLC.Social.Leagues.LeaguesEconomy.RequirementOptions + (this.vipReqDropdown.m_Value << 4);
            int val_2 = System.Decimal.ToInt32(d:  new System.Decimal() {flags = mem[R7 + (0)], hi = mem[R7 + (4)], lo = mem[R7 + (8)], mid = (SLC.Social.Leagues.LeaguesEconomy.RequirementOptions + (this.vipReqDropdown.m_Value) << 4) + 28});
            decimal val_3 = System.Decimal.op_Implicit(value:  850969088);
            this.SubmitClubEdit();
        }
        private void OnClubInviteChange(int _valueSelected)
        {
            this.clubInviteReq = System.Convert.ToBoolean(value:  this.inviteOnlyDropDown.m_Value);
            this.SubmitClubEdit();
        }
        private void OnEnable()
        {
            if(this.editClubMode != false)
            {
                    this.PopulateCurrentClubData();
            }
            else
            {
                    GameEcon val_1 = App.getGameEcon;
                string val_2 = ToString(format:  null);
                this.createClubButton.interactable = true;
            }
            
            this.OnLocalize();
        }
        private void OnLocalize()
        {
            string val_1 = Localization.Localize(key:  851321904, defaultValue:  851321808, useSingularKey:  false);
            string val_2 = System.String.Format(format:  -1170848192, arg0:  851321904);
            string val_3 = Localization.Localize(key:  851330288, defaultValue:  851330192, useSingularKey:  false);
            string val_4 = System.String.Format(format:  -1170848192, arg0:  851330288);
            string val_5 = Localization.Localize(key:  851334576, defaultValue:  851334480, useSingularKey:  false);
            string val_6 = System.String.Format(format:  -1170848192, arg0:  851334576);
            string val_7 = Localization.Localize(key:  851338880, defaultValue:  851338784, useSingularKey:  false);
            string val_8 = System.String.Format(format:  -1170848192, arg0:  851338880);
            if(this.inviteOnlyLabel == 0)
            {
                
            }
        
        }
        private void PopulateCurrentClubData()
        {
            SLC.Social.Leagues.LeaguesDataController val_1 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Leagues.Guild val_2 = MyGuild;
            if(null == 0)
            {
                    return;
            }
            
            SLC.Social.AvatarConfig val_3 = SLC.Social.Leagues.LeaguesUIManager.guildAvatarHandler;
            SLC.Social.Leagues.LeaguesDataController val_4 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Leagues.Guild val_5 = MyGuild;
            UnityEngine.Sprite val_6 = GetAvatarSpriteByID(id:  -523368192);
            this.clubImage.sprite = 442916864;
            SLC.Social.Leagues.LeaguesDataController val_7 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Leagues.Guild val_8 = this.clubImage.MyGuild;
            this.clubImageId = this.clubImage;
            SLC.Social.Leagues.LeaguesDataController val_9 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Leagues.Guild val_10 = this.clubImage.MyGuild;
            this.clubName = this.clubImage;
            SLC.Social.Leagues.LeaguesDataController val_11 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Leagues.Guild val_12 = this.clubImage.MyGuild;
            this.nameInputField.text = this.clubImage;
            if(this.mottoInputField != 0)
            {
                    SLC.Social.Leagues.LeaguesDataController val_14 = SLC.Social.Leagues.LeaguesManager.DAO;
                SLC.Social.Leagues.Guild val_15 = MyGuild;
                this.clubMotto = SLC.Social.Leagues.LeaguesManager.__il2cppRuntimeField_byval_arg;
                SLC.Social.Leagues.LeaguesDataController val_16 = SLC.Social.Leagues.LeaguesManager.DAO;
                SLC.Social.Leagues.Guild val_17 = SLC.Social.Leagues.LeaguesManager.__il2cppRuntimeField_byval_arg.MyGuild;
                this.mottoInputField.text = SLC.Social.Leagues.LeaguesManager.__il2cppRuntimeField_byval_arg + 16;
            }
            
            SLC.Social.Leagues.LeaguesDataController val_18 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Leagues.Guild val_19 = MyGuild;
            decimal val_20 = System.Decimal.op_Implicit(value:  851512080);
            this.vipReqDropdown.value = SLC.Social.Leagues.LeaguesEconomy.GetIndexOfRequirementOption(req:  new System.Decimal());
            SLC.Social.Leagues.LeaguesDataController val_22 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Leagues.Guild val_23 = this.vipReqDropdown.MyGuild;
            decimal val_24 = System.Decimal.op_Implicit(value:  851512064);
            this.vipReqDropdown.RefreshShownValue();
            SLC.Social.Leagues.LeaguesDataController val_25 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Leagues.Guild val_26 = this.vipReqDropdown.MyGuild;
            this.inviteOnlyDropDown.value = this.vipReqDropdown;
            SLC.Social.Leagues.LeaguesDataController val_27 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Leagues.Guild val_28 = MyGuild;
            this.clubInviteReq = SLC.Social.Leagues.LeaguesManager.__il2cppRuntimeField_castClass;
            this.inviteOnlyDropDown.RefreshShownValue();
        }
        public void SubmitClubEdit()
        {
            string val_6;
            if(this.editClubMode == false)
            {
                    return;
            }
            
            SLC.Social.Leagues.LeaguesDataController val_1 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Leagues.Guild val_2 = MyGuild;
            val_6 = this.clubName;
            if(((System.String.op_Equality(a:  val_6, b:  -523372288)) != false) && ((System.String.op_Equality(a:  this.clubMotto, b:  SLC.Social.Leagues.LeaguesManager.__il2cppRuntimeField_byval_arg)) != false))
            {
                    if(SLC.Social.Leagues.LeaguesManager.__il2cppRuntimeField_castClass != 0)
            {
                    SLC.Social.Leagues.LeaguesManager.__il2cppRuntimeField_castClass = 1;
            }
            
                if(this.clubInviteReq == true)
            {
                    this.clubInviteReq = 1;
            }
            
                if(1 == 1)
            {
                    int val_5 = System.Decimal.ToInt32(d:  new System.Decimal() {flags = mem[this.clubReqAmount + (0)], hi = mem[this.clubReqAmount + (4)], lo = mem[this.clubReqAmount + (8)], mid = mem[this.clubReqAmount + (12)]});
                return;
            }
            
            }
            
            this.CreateClubButtonPressed();
        }
        private void PopulateVipReqOptions()
        {
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            Dropdown.OptionData val_11;
            System.Collections.Generic.List<OptionData> val_1 = this.vipReqDropdown.options;
            this.vipReqDropdown.Clear();
            var val_5 = 24486569;
            val_5 = 11149252 + val_5;
            if(val_5 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_7 = null;
            val_7 = null;
            val_8 = 0;
            goto label_8;
            label_15:
            System.Collections.Generic.List<OptionData> val_2 = this.vipReqDropdown.options;
            if(val_8 != 0)
            {
                    string val_3 = SB.ToString();
                if(SB != 0)
            {
                    val_10 = SB;
            }
            
                val_11 = null;
            }
            else
            {
                    string val_4 = Localization.Localize(key:  851782576, defaultValue:  851782496, useSingularKey:  false);
                val_10 = "none_upper";
                val_11 = null;
            }
            
            val_11 = new Dropdown.OptionData(text:  851782576);
            this.vipReqDropdown.Add(item:  203567104);
            val_9 = SB + 16;
            val_8 = 1;
            label_8:
            if(val_8 < (SLC.Social.Leagues.LeaguesEconomy.RequirementOptions + 12))
            {
                goto label_15;
            }
            
            this.vipReqDropdown.value = 0;
            this.vipReqDropdown.RefreshShownValue();
        }
        private void PopulateInviteOnlyOptions()
        {
            System.Collections.Generic.List<OptionData> val_1 = this.inviteOnlyDropDown.options;
            string val_2 = Localization.Localize(key:  851924368, defaultValue:  851924480, useSingularKey:  false);
            Dropdown.OptionData val_3 = new Dropdown.OptionData(text:  851924368);
            this.inviteOnlyDropDown.set_Item(index:  0, value:  203567104);
            System.Collections.Generic.List<OptionData> val_4 = this.inviteOnlyDropDown.options;
            string val_5 = Localization.Localize(key:  851338880, defaultValue:  851338784, useSingularKey:  false);
            Dropdown.OptionData val_6 = new Dropdown.OptionData(text:  851338880);
            this.inviteOnlyDropDown.set_Item(index:  1, value:  203567104);
            this.inviteOnlyDropDown.RefreshShownValue();
        }
        private void CreateClubButtonPressed()
        {
            var val_27;
            var val_28;
            int val_29;
            int val_30;
            int val_31;
            var val_32;
            var val_33;
            if(this.editClubMode == false)
            {
                goto label_1;
            }
            
            if((System.String.IsNullOrEmpty(value:  this.clubName)) == false)
            {
                goto label_2;
            }
            
            if(this.showMessageFlyout == 0)
            {
                    return;
            }
            
            string val_2 = Localization.Localize(key:  852066400, defaultValue:  852066288, useSingularKey:  false);
            this.showMessageFlyout.Invoke(obj:  852066400);
            return;
            label_1:
            Player val_3 = App.Player;
            var val_4 = 0 + 64;
            val_27 = 52;
            val_28 = null;
            val_28 = null;
            val_30 = mem[(0 + 64) + (4)];
            val_29 = mem[(0 + 64) + (0)];
            val_27 = val_27;
            val_31 = null;
            val_31 = val_29;
            val_30 = val_30;
            val_29 = val_31;
            val_27 = val_27;
            if((System.Decimal.op_LessThan(d1:  new System.Decimal() {flags = 52, hi = val_29, lo = val_30, mid = mem[(0 + 64) + (8)]}, d2:  new System.Decimal() {flags = SLC.Social.Leagues.LeaguesEconomy.CostToCreate, lo = SLC.Social.Leagues.LeaguesEconomy.CostToCreate.__il2cppRuntimeField_8, mid = SLC.Social.Leagues.LeaguesEconomy.CostToCreate.__il2cppRuntimeField_C})) == false)
            {
                goto label_11;
            }
            
            var val_28 = 24472165;
            val_28 = 11153896 + val_28;
            if(val_28 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_32 = null;
            val_32 = null;
            PurchaseProxy.currentPurchasePoint = 21;
            twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_7 = ShowUGUIMonolith<System.Object>(showNext:  false);
            Init(outOfCredits:  true, onCloseAction:  0);
            return;
            label_2:
            SLC.Social.Leagues.LeaguesDataController val_8 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Leagues.Guild val_9 = MyGuild;
            typeof(SLC.Social.Leagues.LeaguesManager).__il2cppRuntimeField_C = this.clubImageId;
            SLC.Social.Leagues.LeaguesDataController val_10 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Leagues.Guild val_11 = MyGuild;
            typeof(SLC.Social.Leagues.LeaguesManager).__il2cppRuntimeField_8 = this.clubName;
            SLC.Social.Leagues.LeaguesDataController val_12 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Leagues.Guild val_13 = MyGuild;
            typeof(SLC.Social.Leagues.LeaguesManager).__il2cppRuntimeField_10 = this.clubMotto;
            SLC.Social.Leagues.LeaguesDataController val_14 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Leagues.Guild val_15 = MyGuild;
            typeof(SLC.Social.Leagues.LeaguesManager).__il2cppRuntimeField_24 = this.clubInviteReq;
            SLC.Social.Leagues.LeaguesDataController val_16 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Leagues.Guild val_17 = MyGuild;
            int val_18 = System.Decimal.ToInt32(d:  new System.Decimal() {flags = this.clubReqAmount, hi = R7, lo = 441638912, mid = R8});
            typeof(SLC.Social.Leagues.LeaguesManager).__il2cppRuntimeField_28 = val_18;
            SLC.Social.Leagues.LeaguesDataController val_19 = SLC.Social.Leagues.LeaguesManager.DAO;
            System.Action<System.Boolean> val_20 = new System.Action<System.Boolean>(object:  852133520, method:  new IntPtr(852075728));
            val_18.UpdateMyGuildInfo(resultAction:  7401472);
            return;
            label_11:
            this.createClubButton.interactable = false;
            SLC.Social.Leagues.LeaguesDataController val_21 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.AvatarConfig val_22 = SLC.Social.Leagues.LeaguesUIManager.guildAvatarHandler;
            var val_29 = 24480873;
            val_29 = 11154948 + val_29;
            if(val_29 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_33 = null;
            val_33 = null;
            System.Decimal[] val_25 = SLC.Social.Leagues.LeaguesEconomy.RequirementOptions + (this.vipReqDropdown.m_Value << 4);
            SLC.Social.Leagues.Guild val_27 = PurchaseGuild(guildIconIndex:  GetIDByAvatarSprite(sprite:  this.clubImage.m_Sprite, randomIfNotFound:  true), guildName:  this.clubName, motto:  this.clubMotto, requiresInvite:  System.Convert.ToBoolean(value:  this.inviteOnlyDropDown.m_Value), vipLevelRequired:  System.Decimal.ToInt32(d:  new System.Decimal() {flags = (SLC.Social.Leagues.LeaguesEconomy.RequirementOptions + (this.vipReqDropdown.m_Value) << 4) + 16, hi = (SLC.Social.Leagues.LeaguesEconomy.RequirementOptions + (this.vipReqDropdown.m_Value) << 4) + 20, lo = (SLC.Social.Leagues.LeaguesEconomy.RequirementOptions + (this.vipReqDropdown.m_Value) << 4).Length, mid = (SLC.Social.Leagues.LeaguesEconomy.RequirementOptions + (this.vipReqDropdown.m_Value) << 4) + 28}));
            if(null == 0)
            {
                    return;
            }
            
            this.nameInputField.text = System.String.alignConst;
        }
        public LeaguesUICreateGuildView()
        {
            this.clubImageId = 0;
            this.clubName = "";
            this.clubMotto = "";
        }
        private void <CreateClubButtonPressed>b__30_0(bool result)
        {
            if(this.showMessageFlyout == 0)
            {
                    return;
            }
            
            string val_1 = Localization.Localize(key:  852386864, defaultValue:  852386768, useSingularKey:  false);
            this.showMessageFlyout.Invoke(obj:  852386864);
        }
    
    }

}
