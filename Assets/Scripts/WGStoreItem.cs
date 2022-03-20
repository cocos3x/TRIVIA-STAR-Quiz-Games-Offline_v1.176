using UnityEngine;
public class WGStoreItem : MyButton
{
    // Fields
    protected UnityEngine.UI.Text coinsAmount;
    protected UnityEngine.UI.VerticalLayoutGroup amountGroupLayout;
    protected int amountGroupLayout_paddingLeft;
    protected int amountGroupLayout_paddingBottom;
    protected float amountGroupLayout_spacing;
    protected UnityEngine.UI.Text bonusAmount;
    protected UnityEngine.GameObject bonusGroup;
    protected UnityEngine.UI.Text price;
    protected UnityEngine.UI.Image coinsImg;
    protected bool setCoinNativeSize;
    protected UnityEngine.Sprite[] coinLevelSprites;
    protected UnityEngine.GameObject mostPopular;
    protected UnityEngine.GameObject bestValue;
    protected UnityEngine.GameObject noAdsIcon;
    protected UGUINetworkedButton networkedButton;
    protected UnityEngine.Sprite altBuyButtonSprite;
    protected UnityEngine.UI.Image buyButtonBaseImage;
    protected UnityEngine.UI.Image buyButtonBaseImageOverlay;
    protected UnityEngine.GameObject bonusRewardGroup;
    protected UnityEngine.UI.Text bonusRewardText;
    protected UnityEngine.Sprite noAdsForeverSprite;
    protected PurchaseModel purchasePack;
    protected IStoreUI storeUIView;
    
    // Properties
    public string PackID { get; }
    
    // Methods
    public string get_PackID()
    {
        if(this.purchasePack != 0)
        {
                "unknown" = this.purchasePack.id;
        }
    
    }
    public virtual void Awake()
    {
        UGUINetworkedButton val_6;
        System.Delegate val_7;
        if(this.networkedButton == 0)
        {
                object val_2 = this.GetComponent<System.Object>();
            val_6 = this;
            this.networkedButton = this;
        }
        else
        {
                val_6 = this.networkedButton;
        }
        
        System.Action<System.Boolean> val_3 = new System.Action<System.Boolean>(object:  68512608, method:  typeof(WGStoreItem).__il2cppRuntimeField_100);
        val_7 = this.networkedButton.OnConnectionClick;
        System.Delegate val_4 = System.Delegate.Combine(a:  val_7, b:  7401472);
        if(val_7 != 0)
        {
                if(null == null)
        {
            goto label_7;
        }
        
        }
        
        val_7 = 0;
        label_7:
        this.networkedButton.OnConnectionClick = val_7;
        if(this.noAdsIcon == 0)
        {
                return;
        }
        
        this.noAdsIcon.SetActive(value:  false);
    }
    public virtual void UpdateUI(PurchaseModel pack, int packIndex, int totalPackItems, IStoreUI storeUI)
    {
        int val_8;
        int val_9;
        int val_31;
        WGStoreItem val_69;
        PurchaseModel val_70;
        UnityEngine.Sprite val_71;
        int val_72;
        int val_73;
        float val_74;
        var val_75;
        int val_76;
        val_69 = this;
        val_70 = pack;
        this.purchasePack = val_70;
        this.storeUIView = storeUI;
        if(this.coinsImg != 0)
        {
                this.coinsImg.sprite = 0;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.coinsAmount)) != false)
        {
                this.coinsAmount.alignment = 4;
            if((UnityEngine.Object.op_Implicit(exists:  this.amountGroupLayout)) != false)
        {
                this.amountGroupLayout.spacing = null;
        }
        
            decimal val_4 = 0.Credits;
            GameEcon val_5 = App.getGameEcon;
            string val_6 = ToString(format:  null);
        }
        
        if(val_70 > 0)
        {
                1 = 2;
        }
        
        GameBehavior val_7 = App.getBehavior;
        val_71 = 0;
        val_72 = val_8;
        val_73 = val_9;
        if((UnityEngine.Object.op_Implicit(exists:  this.bonusGroup)) != false)
        {
                UnityEngine.GameObject val_11 = this.bonusGroup.gameObject;
            val_73 = val_73;
            if((System.Decimal.op_GreaterThan(d1:  new System.Decimal() {lo = val_72, mid = val_73}, d2:  new System.Decimal() {flags = System.Decimal.Zero, lo = System.Decimal.Powers10.__il2cppRuntimeField_C, mid = System.Decimal.Powers10.__il2cppRuntimeField_10})) != false)
        {
                GameBehavior val_13 = App.getBehavior;
        }
        
            this.bonusGroup.SetActive(value:  true);
            val_71 = val_71;
            val_69 = val_69;
            val_72 = val_72;
            val_70 = val_70;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  mem[1152921513265475848])) != false)
        {
                GameBehavior val_15 = App.getBehavior;
            if(0 == 0)
        {
                UnityEngine.GameObject val_16 = mem[1152921513265475848].gameObject;
            mem[1152921513265475848].SetActive(value:  System.Decimal.op_GreaterThan(d1:  new System.Decimal() {lo = val_72, mid = val_73}, d2:  new System.Decimal() {flags = System.Decimal.Zero, mid = System.Decimal.Powers10.__il2cppRuntimeField_10}));
            GameBehavior val_18 = App.getBehavior;
            val_71 = 0;
        }
        
        }
        
        val_74 = 1152921504765685760;
        if((UnityEngine.Object.op_Implicit(exists:  mem[1152921513265475900])) != false)
        {
                GameBehavior val_20 = App.getBehavior;
            if(0 != 0)
        {
                val_71 = 1152921504897900544;
            val_73 = 1152921511942590224;
            WGBonusRewardsHandler val_21 = DefaultHandler<WGBonusRewardsHandler>.Instance;
            if((-1254191344) != 0)
        {
                this.coinsAmount.alignment = 1;
            this.amountGroupLayout.spacing = 99.99f;
            UnityEngine.GameObject val_23 = mem[1152921513265475900].gameObject;
            mem[1152921513265475900].SetActive(value:  true);
            WGBonusRewardsHandler val_24 = DefaultHandler<WGBonusRewardsHandler>.Instance;
            int val_25 = GetPointsForPurchase(pack:  val_70);
            GameEcon val_26 = App.getGameEcon;
            string val_27 = val_25.ToString(format:  null);
            WGBonusRewardsHandler val_28 = DefaultHandler<WGBonusRewardsHandler>.Instance;
            decimal val_29 = 0.GetBonusCoins(pack:  -1254191344);
            val_73 = 0;
            decimal val_30 = Credits;
            decimal val_32 = System.Decimal.op_Addition(d1:  new System.Decimal() {flags = 68682128}, d2:  new System.Decimal() {flags = val_31, lo = val_25, mid = val_8});
            GameEcon val_33 = App.getGameEcon;
            string val_34 = ToString(format:  null);
            val_71;
            val_70 = val_70;
            val_74 = 1152921504765685760;
        }
        
        }
        
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  mem[1152921513265475880])) != false)
        {
                mem[1152921513265475880].SetActive(value:  false);
        }
        
        if((pack + 12.Contains(value:  -1801681824)) == false)
        {
            goto label_139;
        }
        
        GameBehavior val_37 = App.getBehavior;
        if(0 != 0)
        {
            goto label_96;
        }
        
        GameEcon val_38 = App.getGameEcon;
        if((pack + 92.Equals(obj:  99.99f)) == false)
        {
            goto label_96;
        }
        
        Player val_40 = App.Player;
        if(0.RemovedAds == false)
        {
            goto label_100;
        }
        
        label_96:
        UnityEngine.GameObject val_42 = this.gameObject;
        this.SetActive(value:  false);
        return;
        label_100:
        if((UnityEngine.Object.op_Implicit(exists:  mem[1152921513265475900])) != false)
        {
                UnityEngine.GameObject val_44 = mem[1152921513265475900].gameObject;
            mem[1152921513265475900].SetActive(value:  false);
        }
        
        if(this.amountGroupLayout != 0)
        {
                this.amountGroupLayout.left = mem[1152921513265475836];
            this.amountGroupLayout.bottom = mem[1152921513265475840];
            this.amountGroupLayout.spacing = 99.99f;
        }
        
        if(this.coinsAmount != 0)
        {
                val_71 = 0;
            UnityEngine.RectTransform val_47 = this.coinsAmount.rectTransform;
            UnityEngine.Vector2 val_48 = new UnityEngine.Vector2(x:  99.99f, y:  null);
            this.coinsAmount.sizeDelta = new UnityEngine.Vector2() {x = val_48.x, y = val_48.y};
            this.coinsAmount.resizeTextMaxSize = 90;
        }
        
        if(mem[1152921513265475848] != 0)
        {
                UnityEngine.GameObject val_50 = mem[1152921513265475848].gameObject;
            mem[1152921513265475848].SetActive(value:  true);
            mem[1152921513265475848].fontSize = 26;
            string val_51 = Localization.Localize(key:  -652536416, defaultValue:  -652536528, useSingularKey:  false);
            val_71 = "no_ads_forever_upper";
        }
        
        if(this.bonusGroup != 0)
        {
                this.bonusGroup.SetActive(value:  true);
        }
        
        if(mem[1152921513265475880] != 0)
        {
                mem[1152921513265475880].SetActive(value:  true);
        }
        
        if(mem[1152921513265475908] != 0)
        {
                val_71 = mem[1152921513265475908];
            this.coinsImg.sprite = val_71;
        }
        
        label_139:
        if((UnityEngine.Object.op_Implicit(exists:  mem[1152921513265475856])) != false)
        {
                string val_56 = val_70.LocalPrice;
            val_71 = val_70;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.coinsImg)) != false)
        {
                if(this.coinsImg.m_Sprite == 0)
        {
                val_73 = mem[1152921513265475868];
            if(totalPackItems >= 1)
        {
                int val_67 = packIndex;
            int val_68 = mem[1152921513265475868] + 12;
            val_67 = val_67 - totalPackItems;
            val_68 = val_67 + val_68;
            val_75 = val_73 + ((UnityEngine.Mathf.Max(a:  val_68, b:  0)) << 2);
        }
        else
        {
                val_76 = packIndex;
            if((mem[1152921513265475868] + 12) <= val_76)
        {
                val_76 = packIndex;
        }
        
            val_75 = val_73 + (val_76 << 2);
        }
        
            val_71 = mem[(mem[1152921513265475868] + (packIndex) << 2) + 16];
            val_71 = (mem[1152921513265475868] + (packIndex) << 2) + 16;
            this.coinsImg.sprite = val_71;
        }
        
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  mem[1152921513265475872])) != false)
        {
                AppConfigs val_61 = App.Configuration;
            if(0 == 0)
        {
                val_71 = (pack + 12.Contains(value:  -1801681824)) ^ 1;
        }
        else
        {
                val_71 = 0;
        }
        
            mem[1152921513265475872].SetActive(value:  false);
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  mem[1152921513265475876])) != false)
        {
                float val_64 = PackagesManager.GetBestValuePackPrice(unfiltered:  0);
            if(mem[1152921513265475876] == 0)
        {
                0 = 1;
        }
        
            mem[1152921513265475876].SetActive(value:  true);
        }
        
        if(mem[1152921513265475888] == 0)
        {
                return;
        }
        
        bool val_66 = UnityEngine.Object.op_Inequality(x:  mem[1152921513265475892], y:  0);
        if(val_66 == false)
        {
                return;
        }
        
        if(val_66 == true)
        {
                9.99f = 49.99f;
        }
        
        if(val_66 == true)
        {
                return;
        }
        
        val_71 = mem[1152921513265475892];
        val_71.sprite = mem[1152921513265475888];
        mem[1152921513265475896].sprite = mem[1152921513265475888];
    }
    protected virtual void HandleConnectionClick(bool result)
    {
        var val_5;
        IStoreUI val_6;
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        val_5 = result;
        val_6 = this.storeUIView;
        if(val_5 == false)
        {
            goto label_1;
        }
        
        if(val_6 == 0)
        {
                return;
        }
        
        val_7 = 0;
        val_7 = val_7 + 1;
        val_8 = val_6;
        goto label_6;
        label_1:
        if(val_6 == 0)
        {
                return;
        }
        
        val_11 = 0;
        val_12 = 0;
        val_11 = val_11 + 1;
        val_13 = (uint)val_11 & 65535;
        val_14 = val_6;
        goto label_11;
        label_6:
        val_10 = mem[(1152921504982990848 + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
        val_9 = val_6;
        goto mem[(1152921504982990848 + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
        label_11:
    }
    public WGStoreItem()
    {
        this.setCoinNativeSize = true;
    }

}
