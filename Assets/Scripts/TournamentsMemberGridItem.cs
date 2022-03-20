using UnityEngine;
public class TournamentsMemberGridItem : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Button mainButton;
    private UnityEngine.GameObject special_rank_1st;
    private UnityEngine.GameObject special_rank_2nd;
    private UnityEngine.GameObject special_rank_3rd;
    private UnityEngine.UI.Text text_rank;
    private AvatarSlotUGUI memberAvatar;
    private UnityEngine.UI.Text text_memberName;
    private UnityEngine.UI.Text text_winnings;
    private UnityEngine.GameObject reward_group;
    private UnityEngine.GameObject reward_gift;
    private UnityEngine.GameObject reward_gem;
    private UnityEngine.GameObject reward_coin;
    private UnityEngine.GameObject promotion;
    private UnityEngine.GameObject demotion;
    private UnityEngine.GameObject background_me;
    private UnityEngine.GameObject background_others;
    private SLC.Social.Profile profile;
    private System.Action<int> onClickAction;
    private TournamentsMembersListView _ListViewParent;
    
    // Properties
    private TournamentsMembersListView ListViewParent { get; }
    
    // Methods
    private TournamentsMembersListView get_ListViewParent()
    {
        if(this._ListViewParent != 0)
        {
                return;
        }
        
        UnityEngine.Transform val_2 = this.transform;
        object val_3 = this.GetComponentInParent<System.Object>();
        this._ListViewParent = this;
    }
    private void Awake()
    {
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -1667302832, method:  new IntPtr(2627639440));
        this.mainButton.m_OnClick.AddListener(call:  162246656);
    }
    public void UpdateUIFromMember(SLC.Social.Profile memberProfile, int tierIndex, int rankIndex, int rankedWinnings, System.Action<int> clickAction, bool isMe = False)
    {
        int val_38;
        UnityEngine.GameObject val_39;
        UnityEngine.UI.Text val_40;
        bool val_41;
        System.Action<System.Int32> val_42;
        var val_43;
        var val_44;
        bool val_45;
        bool val_46;
        bool val_47;
        UnityEngine.GameObject val_48;
        val_38 = tierIndex;
        UnityEngine.GameObject val_1 = this.gameObject;
        val_39 = this;
        if(memberProfile == 0)
        {
            goto label_2;
        }
        
        this.SetActive(value:  true);
        this.profile = memberProfile;
        int val_2 = rankIndex + 1;
        bool val_3 = UnityEngine.Object.op_Inequality(x:  this.special_rank_1st, y:  0);
        if(val_3 != false)
        {
                this.special_rank_1st.SetActive(value:  val_3 >> 5);
            UnityEngine.GameObject val_5 = this.text_rank.gameObject;
            if(val_2 > 3)
        {
                0 = 1;
        }
        
            this.text_rank.SetActive(value:  true);
        }
        
        if(this.special_rank_2nd != 0)
        {
                this.special_rank_2nd.SetActive(value:  (val_2 - 2) >> 5);
            UnityEngine.GameObject val_9 = this.text_rank.gameObject;
            if(val_2 > 3)
        {
                0 = 1;
        }
        
            this.text_rank.SetActive(value:  true);
        }
        
        if(this.special_rank_3rd == 0)
        {
            goto label_17;
        }
        
        this.special_rank_3rd.SetActive(value:  (val_2 - 3) >> 5);
        val_40 = this;
        UnityEngine.GameObject val_13 = this.text_rank.gameObject;
        if(val_2 > 3)
        {
                0 = 1;
        }
        
        this.text_rank.SetActive(value:  true);
        goto label_21;
        label_2:
        val_41 = 0;
        goto label_22;
        label_17:
        val_40 = this.text_rank;
        label_21:
        string val_14 = val_2.ToString();
        string val_15 = rankedWinnings.ToString();
        val_42 = clickAction;
        val_38 = this.profile;
        this.onClickAction = val_42;
        this.background_me.SetActive(value:  isMe);
        this.background_others.SetActive(value:  isMe ^ 1);
        val_39 = 1152921504908816384;
        val_43 = null;
        val_43 = null;
        if((TournamentsEconomy.rewardIndexByRank + 12) <= rankIndex)
        {
            goto label_33;
        }
        
        val_44 = null;
        val_44 = null;
        System.Int32[] val_17 = TournamentsEconomy.rewardIndexByRank + (val_2 << 2);
        val_42 = val_38;
        System.Int32[][] val_18 = TournamentsEconomy.giftRewardsByTier + (val_42 << 2);
        var val_19 = ((TournamentsEconomy.giftRewardsByTier + (tierIndex) << 2) + 16) + (((TournamentsEconomy.rewardIndexByRank + ((rankIndex + 1)) << 2) + 16) << 2);
        if((((TournamentsEconomy.giftRewardsByTier + (tierIndex) << 2) + 16 + ((TournamentsEconomy.rewardIndexByRank + ((rankIndex + 1)) << 2) + 16) << 2) + 16) > 0)
        {
                0 = 1;
        }
        
        UnityEngine.GameObject val_38 = this.reward_gift;
        val_38.SetActive(value:  true);
        System.Int32[][] val_20 = TournamentsEconomy.gemOrPetFoodRewardsByTier;
        val_38 = val_38 + (val_42 << 2);
        UnityEngine.GameObject val_21 = val_38 + (((TournamentsEconomy.rewardIndexByRank + ((rankIndex + 1)) << 2) + 16) << 2);
        if(val_38 > 0)
        {
                0 = 1;
        }
        
        this.reward_gem.SetActive(value:  true);
        System.Int32[][] val_22 = TournamentsEconomy.coinRewardsByTier + (val_42 << 2);
        var val_23 = ((TournamentsEconomy.coinRewardsByTier + (tierIndex) << 2) + 16) + (((TournamentsEconomy.rewardIndexByRank + ((rankIndex + 1)) << 2) + 16) << 2);
        if((((TournamentsEconomy.coinRewardsByTier + (tierIndex) << 2) + 16 + ((TournamentsEconomy.rewardIndexByRank + ((rankIndex + 1)) << 2) + 16) << 2) + 16) > 0)
        {
                0 = 1;
        }
        
        val_45 = 0;
        this.reward_coin.SetActive(value:  true);
        if(val_42 != 0)
        {
                val_45 = TournamentsEconomy.RankIndexIsPromotion(rankIndex:  rankIndex);
        }
        
        val_46 = 0;
        this.promotion.SetActive(value:  val_45);
        val_38 = this.demotion;
        if((TournamentsEconomy.TierIndexCanDemote(tierIndex:  val_42)) != false)
        {
                val_46 = TournamentsEconomy.RankIndexIsDemotion(rankIndex:  rankIndex);
        }
        
        val_38.SetActive(value:  val_46);
        val_47 = 1;
        if(this.reward_gift.activeSelf != true)
        {
                if(this.reward_gem.activeSelf != true)
        {
                if(this.reward_coin.activeSelf == false)
        {
            goto label_68;
        }
        
        }
        
        }
        
        label_82:
        val_39 = this.reward_group;
        if(val_39 == 0)
        {
                return;
        }
        
        val_48 = this.reward_group;
        goto label_72;
        label_33:
        string val_31 = Ordinal.GetOrdinalFormat(num:  rankIndex);
        string val_32 = System.String.Format(format:  -1667087856, arg0:  rankIndex);
        UnityEngine.Debug.LogError(message:  -1667087856);
        UnityEngine.GameObject val_33 = this.gameObject;
        val_48 = this;
        CompanyDevices val_34 = CompanyDevices.Instance;
        val_47 = 0.CompanyDevice();
        label_72:
        val_41 = val_47;
        label_22:
        this.SetActive(value:  val_41);
        return;
        label_68:
        if(this.promotion.activeSelf == true)
        {
            goto label_82;
        }
        
        bool val_37 = this.demotion.activeSelf;
        goto label_82;
    }
    private void OnClick()
    {
        if(this.onClickAction == 0)
        {
                return;
        }
        
        this.onClickAction.Invoke(obj:  this.profile.ServerId);
    }
    private void ScrollCellIndex(int index)
    {
        TournamentsMembersListView val_1 = this.ListViewParent;
        this.SetupGridItem(memberGridItem:  -1666687968, itemIndex:  index);
    }
    public TournamentsMemberGridItem()
    {
    
    }

}
