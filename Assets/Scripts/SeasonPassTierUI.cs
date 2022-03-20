using UnityEngine;
public class SeasonPassTierUI : MonoBehaviour
{
    // Fields
    public UnityEngine.UI.Image tierIcon;
    public UnityEngine.UI.Text tierText;
    public UnityEngine.GameObject freeTierGO;
    public UnityEngine.GameObject chestTooltip;
    public UnityEngine.Sprite freeTierSprite;
    public System.Collections.Generic.List<UnityEngine.Sprite> tierIconTextures;
    private System.Collections.Generic.List<UnityEngine.Sprite> rewardSprites;
    public UnityEngine.UI.Button passClaimBtn;
    public UnityEngine.UI.Image passIcon;
    public UnityEngine.UI.Text passAmountTxt;
    public UnityEngine.GameObject passCollectedIcon;
    public UnityEngine.GameObject lockIcon;
    public UnityEngine.UI.Button freeClaimBtn;
    public UnityEngine.UI.Image freeIcon;
    public UnityEngine.UI.Text freeAmountTxt;
    public UnityEngine.GameObject freeCollectedIcon;
    private int tierIndex;
    private SeasonPassEcon.Tier tier;
    private UnityEngine.GameObject tooltip;
    private SeasonPassEventHandler eventHandler;
    private UnityEngine.GameObject tierHeader;
    private UnityEngine.GameObject tierDivider;
    private UnityEngine.UI.Image freeTierImage;
    private UnityEngine.UI.Button freeTooltipButton;
    private UnityEngine.UI.Button passTooltipButton;
    private SeasonPassEventPopup _seasonPopupParent;
    
    // Properties
    private SeasonPassEventPopup SeasonPopupParent { get; }
    
    // Methods
    private SeasonPassEventPopup get_SeasonPopupParent()
    {
        if(this._seasonPopupParent != 0)
        {
                return;
        }
        
        UnityEngine.Transform val_2 = this.transform;
        object val_3 = this.GetComponentInParent<System.Object>();
        this._seasonPopupParent = this;
    }
    public void Awake()
    {
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -1043462528, method:  new IntPtr(3251443904));
        this.passClaimBtn.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  -1043462528, method:  new IntPtr(3251453120));
        this.freeClaimBtn.m_OnClick.AddListener(call:  162246656);
        object val_3 = this.freeIcon.GetComponent<System.Object>();
        this.freeTooltipButton = this.freeIcon;
        object val_4 = this.passIcon.GetComponent<System.Object>();
        this.passTooltipButton = this.passIcon;
        UnityEngine.Events.UnityAction val_5 = new UnityEngine.Events.UnityAction(object:  -1043462528, method:  new IntPtr(3251470528));
        this.freeTooltipButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_6 = new UnityEngine.Events.UnityAction(object:  -1043462528, method:  new IntPtr(3251479744));
        this.passTooltipButton.m_OnClick.AddListener(call:  162246656);
        this.eventHandler = SeasonPassEventHandler.<Instance>k__BackingField;
    }
    private void ScrollCellIndex(int index)
    {
        bool val_2;
        int val_3 = index;
        if(this.eventHandler == 0)
        {
                return;
        }
        
        if(val_3 != 0)
        {
                val_3 = val_3 - 1;
            TierData val_1 = GetTierData(tierIndex:  this.eventHandler);
            this.SetupTierAward(data:  new TierData() {lvlUnlocked = false, passActive = false, freeCollected = false, passCollected = false, currentTier = val_2});
            return;
        }
        
        this.SetHeaderTier();
    }
    public void SetupTierAward(SeasonPassEventHandler.TierData data)
    {
        SeasonPassEcon.Tier val_25;
        SeasonPassEcon.Tier val_26;
        this.Clear();
        this.tierIndex = data.tierIndex;
        mem[1152921512153715152] = data.tier;
        int val_2 = UnityEngine.Mathf.Max(a:  0, b:  data.tierIndex - 1);
        val_2 = (val_2 >> 2) + (val_2 >> 31);
        int val_5 = UnityEngine.Mathf.Min(a:  UnityEngine.Mathf.FloorToInt(f:  (float)val_2), b:  2);
        if(val_5 <= val_5)
        {
                var val_25 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_25 = val_25 + (val_5 << 2);
        this.tierIcon.sprite = (0 + (val_5) << 2) + 16;
        string val_6 = this.tierIndex.ToString();
        if(data.lvlUnlocked < true)
        {
                0 = 1;
        }
        
        if(((uint)(data.lvlUnlocked >> 8) & 255) != 0)
        {
                (uint)(data.lvlUnlocked >> 8) & 255 = 1;
        }
        
        if(((int)data.lvlUnlocked & 255) != 0)
        {
                (int)data.lvlUnlocked & 255 = 1;
        }
        
        UnityEngine.GameObject val_7 = this.passClaimBtn.gameObject;
        this.passClaimBtn.SetActive(value:  true);
        val_25 = this.tier;
        if(this.tier != 0)
        {
            goto label_9;
        }
        
        val_25 = this.tier;
        if(val_25 == 0)
        {
            goto label_25;
        }
        
        label_9:
        RewardIcons val_8 = val_25.GetTierIcon(item:  this.tier.PassItem, amount:  this.tier.AwardPass, isPass:  true);
        if(val_25 <= val_25)
        {
                var val_26 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_26 = val_26 + (val_25 << 2);
        this.passIcon.sprite = (0 + (this.tier) << 2) + 16;
        string val_9 = this.tier.AwardPass.ToString();
        UnityEngine.GameObject val_10 = this.passAmountTxt.gameObject;
        if(data.lvlUnlocked < true)
        {
                0 = 1;
        }
        
        this.passAmountTxt.SetActive(value:  true);
        if(0 != (data.lvlUnlocked >> 24))
        {
                data.lvlUnlocked >> 24 = 1;
        }
        
        this.passCollectedIcon.SetActive(value:  true);
        this.passTooltipButton.enabled = (this.tier.PassItem - 5) >> 5;
        this.lockIcon.SetActive(value:  ((int)(data.lvlUnlocked >> 8) & 255) >> 5);
        UnityEngine.GameObject val_17 = this.freeClaimBtn.gameObject;
        if(((int)data.lvlUnlocked & 255) != 0)
        {
                (int)data.lvlUnlocked & 255 = 1;
        }
        
        UnityEngine.UI.Button val_18 = this.freeClaimBtn >> 5;
        this.freeClaimBtn.SetActive(value:  1 & val_18);
        val_26 = this.tier;
        if(this.tier != 0)
        {
            goto label_24;
        }
        
        val_26 = this.tier;
        if(val_26 == 0)
        {
            goto label_25;
        }
        
        label_24:
        RewardIcons val_20 = val_26.GetTierIcon(item:  this.tier.FreeItem, amount:  this.tier.AwardFree, isPass:  false);
        if(val_26 <= val_26)
        {
                var val_27 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_27 = val_27 + (val_26 << 2);
        this.freeIcon.sprite = (0 + (this.tier) << 2) + 16;
        string val_21 = this.tier.AwardFree.ToString();
        UnityEngine.GameObject val_22 = this.freeAmountTxt.gameObject;
        this.freeAmountTxt.SetActive(value:  val_18);
        if(((int)(data.lvlUnlocked >> 16) & 255) != 0)
        {
                (int)(data.lvlUnlocked >> 16) & 255 = 1;
        }
        
        this.freeCollectedIcon.SetActive(value:  true);
        this.freeTooltipButton.enabled = (this.tier.FreeItem - 5) >> 5;
        if(data.tierIndex == 0)
        {
                this.freeTooltipButton = this;
            this.SetFreeTier();
        }
        
        if((data.currentTier & true) != 0)
        {
                return;
        }
        
        this.AddTierDivider();
        return;
        label_25:
    }
    private void Clear()
    {
        UnityEngine.Transform val_1 = this.transform;
        UnityEngine.Transform val_2 = this.GetChild(index:  0);
        UnityEngine.GameObject val_3 = this.gameObject;
        this.SetActive(value:  true);
        UnityEngine.GameObject val_4 = this.tierText.gameObject;
        this.tierText.SetActive(value:  true);
        this.DestroyTooltip();
        if(this.tierHeader != 0)
        {
                UnityEngine.GameObject val_6 = this.tierHeader.gameObject;
            this.tierHeader.SetActive(value:  false);
        }
        
        if(this.tierDivider != 0)
        {
                UnityEngine.GameObject val_8 = this.tierDivider.gameObject;
            this.tierDivider.SetActive(value:  false);
        }
        
        if(this.freeTierImage == 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_10 = this.freeTierImage.gameObject;
        this.freeTierImage.SetActive(value:  false);
    }
    private void SetFreeTier()
    {
        UnityEngine.UI.LayoutElement val_1 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<UnityEngine.UI.LayoutElement>(gameObject:  this.freeTierGO);
        this.freeTierImage = this.freeTierGO;
        this.freeTierGO.sprite = this.freeTierSprite;
        UnityEngine.GameObject val_2 = this.freeTierImage.gameObject;
        this.freeTierImage.SetActive(value:  true);
        UnityEngine.GameObject val_3 = this.tierText.gameObject;
        this.tierText.SetActive(value:  false);
    }
    private void AddTierDivider()
    {
        UnityEngine.GameObject val_8;
        SeasonPassEventPopup val_1 = this.SeasonPopupParent;
        if((-1042508288) == 0)
        {
                return;
        }
        
        if(this.tierDivider == 0)
        {
                SeasonPassEventPopup val_4 = this.SeasonPopupParent;
            UnityEngine.Transform val_5 = this.transform;
            object val_6 = UnityEngine.Object.Instantiate<System.Object>(original:  this.tierIndex, parent:  -1042508288);
            val_8 = this.tierIndex;
            this.tierDivider = this.tierIndex;
        }
        else
        {
                val_8 = this.tierDivider;
        }
        
        UnityEngine.GameObject val_7 = val_8.gameObject;
        val_8.SetActive(value:  true);
    }
    private void SetHeaderTier()
    {
        UnityEngine.GameObject val_13;
        SeasonPassEventPopup val_1 = this.SeasonPopupParent;
        if((-1042367616) == 0)
        {
                return;
        }
        
        UnityEngine.Transform val_3 = this.transform;
        UnityEngine.Transform val_4 = this.GetChild(index:  0);
        UnityEngine.GameObject val_5 = this.gameObject;
        this.SetActive(value:  false);
        if(this.tierHeader == 0)
        {
                SeasonPassEventPopup val_7 = this.SeasonPopupParent;
            UnityEngine.Transform val_8 = this.transform;
            object val_9 = UnityEngine.Object.Instantiate<System.Object>(original:  this.freeCollectedIcon, parent:  -1042367616);
            val_13 = this.freeCollectedIcon;
            this.tierHeader = this.freeCollectedIcon;
        }
        else
        {
                val_13 = this.tierHeader;
        }
        
        UnityEngine.GameObject val_10 = val_13.gameObject;
        val_13.SetActive(value:  true);
        if(this.tierDivider == 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_12 = this.tierDivider.gameObject;
        this.tierDivider.SetActive(value:  false);
    }
    private SeasonPassTierUI.RewardIcons GetTierIcon(SeasonPassEcon.Item item, int amount, bool isPass)
    {
        if(item > 5)
        {
                this = 5;
            return;
        }
        
        var val_1 = 7798288 + (7798288 + (item) << 2);
        if(item == 5)
        {
                7798288 = 7798288 & ((R8) << 7798288);
            7798288 = 7798288 & (((int)IP) >> 32);
            7798288 = 7798288 & (((IP) << (32-((7798288 & (R8) << 7798288) & ((int)IP) >> 32))) | ((IP) << ((7798288 & (R8) << 7798288) & ((int)IP) >> 32)));
            7798288 = 7798288 & ((R4) << 1);
            7798288 = 7798288 & ((IP) >> ((((7798288 & (R8) << 7798288) & ((int)IP) >> 32) & ((IP) << (32-((7798288 & (R8) << 7798288) & ((int)IP) >> 32))) | ((IP) << ((7798288 & (R8) << 7798288) & ((int)IP) >> 32))) & (R4) << 1));
            7798288 = R4 * 7798288;
        }
        
        if(amount <= 224)
        {
                8 = 7;
        }
        
        if(amount > 199)
        {
                return;
        }
        
        if(amount > 99)
        {
                5 = 6;
        }
    
    }
    private void onClickImage(UnityEngine.GameObject go, bool isPass)
    {
        float val_8;
        float val_15;
        var val_17;
        this.DestroyTooltip();
        UnityEngine.Transform val_1 = go.transform;
        UnityEngine.Transform val_2 = go.parent;
        object val_3 = UnityEngine.Object.Instantiate<System.Object>(original:  this.chestTooltip, parent:  go);
        this.tooltip = this.chestTooltip;
        object val_4 = this.chestTooltip.GetComponentInChildren<System.Object>();
        val_17 = this.chestTooltip;
        if(isPass == true)
        {
                20 = 12;
        }
        
        string val_5 = SeasonPassEventHandler.<Instance>k__BackingField.GetChestContent(itemAward:  this.tier.AwardPass);
        if(isPass != true)
        {
                UnityEngine.Transform val_6 = this.tooltip.transform;
            UnityEngine.Vector3 val_7 = localPosition;
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.left;
            val_8.Scale(scale:  new UnityEngine.Vector3());
            UnityEngine.Transform val_11 = this.tooltip.transform;
            val_17 = 0;
            UnityEngine.Transform val_12 = this.tooltip.GetChild(index:  1);
            UnityEngine.Vector3 val_13 = localPosition;
            UnityEngine.Vector3 val_16 = UnityEngine.Vector3.left;
            val_15.Scale(scale:  new UnityEngine.Vector3());
        }
        
        this.Invoke(methodName:  -1042118464, time:  val_16.x);
    }
    private void OnClickPassClaimBtn()
    {
        UnityEngine.GameObject val_1 = this.passClaimBtn.gameObject;
        this.passClaimBtn.SetActive(value:  false);
        UnityEngine.GameObject val_2 = this.passAmountTxt.gameObject;
        this.passAmountTxt.SetActive(value:  false);
        this.passCollectedIcon.SetActive(value:  true);
        SeasonPassEventPopup val_3 = this.SeasonPopupParent;
        if((-1041949600) == 0)
        {
                return;
        }
        
        SeasonPassEventPopup val_5 = R4.SeasonPopupParent;
        R4.OnRewardClaim(index:  R4 + 76, isPassReward:  true);
    }
    private void OnClickFreeClaimBtn()
    {
        UnityEngine.GameObject val_1 = this.freeClaimBtn.gameObject;
        this.freeClaimBtn.SetActive(value:  false);
        UnityEngine.GameObject val_2 = this.freeAmountTxt.gameObject;
        this.freeAmountTxt.SetActive(value:  false);
        this.freeCollectedIcon.SetActive(value:  true);
        SeasonPassEventPopup val_3 = this.SeasonPopupParent;
        if((-1041813024) == 0)
        {
                return;
        }
        
        SeasonPassEventPopup val_5 = R4.SeasonPopupParent;
        R4.OnRewardClaim(index:  R4 + 76, isPassReward:  false);
    }
    private void DestroyTooltip()
    {
        if(this.tooltip == 0)
        {
                return;
        }
        
        UnityEngine.Object.Destroy(obj:  this.tooltip);
    }
    public SeasonPassTierUI()
    {
    
    }
    private void <Awake>b__29_0()
    {
        UnityEngine.GameObject val_1 = this.freeIcon.gameObject;
        this.onClickImage(go:  this.freeIcon, isPass:  false);
    }
    private void <Awake>b__29_1()
    {
        UnityEngine.GameObject val_1 = this.passIcon.gameObject;
        this.onClickImage(go:  this.passIcon, isPass:  true);
    }

}
