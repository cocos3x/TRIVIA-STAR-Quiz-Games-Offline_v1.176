using UnityEngine;
public class StoreConfig : ScriptableObject
{
    // Fields
    public GameCurrencyTheme CurrencyTheme;
    public float MostPopularPackPrice;
    protected float ScratchCardPriceThreshold;
    protected string[] purchasePackages;
    public ProductDetails id_credits1;
    public ProductDetails id_credits199;
    public ProductDetails id_credits2;
    public ProductDetails id_credits3;
    public ProductDetails id_credits4;
    public ProductDetails id_credits5;
    public ProductDetails id_credits6;
    public ProductDetails id_credits7;
    public ProductDetails id_credits8;
    public ProductDetails id_credits9;
    public ProductDetails id_credits10;
    public ProductDetails id_removeAds1;
    public ProductDetails id_removeAds2;
    public ProductDetails id_removeAds3;
    public ProductDetails id_removeAds4;
    public ProductDetails id_removeAds5;
    public ProductDetails id_waterfall_0;
    public ProductDetails id_waterfall_1;
    public ProductDetails id_waterfall_2;
    public ProductDetails id_waterfall_3;
    public ProductDetails id_waterfall_4;
    public ProductDetails id_waterfall_5;
    public ProductDetails id_waterfall_6;
    public ProductDetails id_waterfall_7;
    public ProductDetails id_golden_ticket_subscription;
    public ProductDetails id_silver_ticket_subscription;
    public string golden_ticket_ios_override;
    public string silver_ticket_ios_override;
    public ProductDetails id_starter_pack;
    public ProductDetails id_starter_dice_pack;
    public ProductDetails id_fomo_pack;
    public ProductDetails id_piggy_bank_nonbuyer;
    public ProductDetails id_piggy_bank_lapse1;
    public ProductDetails id_piggy_bank_lapse2;
    public ProductDetails id_piggy_bank_lapse3;
    public ProductDetails id_piggy_bank_tier0;
    public ProductDetails id_piggy_bank_tier1;
    public ProductDetails id_piggy_bank_tier2;
    public ProductDetails id_piggy_bank_tier3;
    public ProductDetails id_piggy_bank_tier4;
    public ProductDetails id_piggy_bank_tier5;
    public ProductDetails id_super_bundle_nonbuyer;
    public ProductDetails id_super_bundle_lapse1;
    public ProductDetails id_super_bundle_lapse2;
    public ProductDetails id_super_bundle_lapse3;
    public ProductDetails id_gems1;
    public ProductDetails id_gems2;
    public ProductDetails id_gems3;
    public ProductDetails id_gems4;
    public ProductDetails id_gems5;
    public ProductDetails id_gems6;
    public ProductDetails id_pets_food1;
    public ProductDetails id_pets_food2;
    public ProductDetails id_pets_food3;
    public ProductDetails id_pets_food4;
    public ProductDetails id_pets_food5;
    public ProductDetails id_pets_food6;
    public ProductDetails id_pets_food7;
    public ProductDetails id_dice_roll1;
    public ProductDetails id_dice_roll2;
    public ProductDetails id_dice_roll3;
    public ProductDetails id_bundles0;
    public ProductDetails id_bundles1;
    public ProductDetails id_bundles2;
    public ProductDetails id_bundles3;
    public ProductDetails id_bundles4;
    public ProductDetails id_bundles5;
    public ProductDetails id_bundles6;
    public ProductDetails trivia_star_bundle1;
    public ProductDetails id_keyPack1;
    public ProductDetails id_keyPack2;
    public ProductDetails id_keyPack3;
    public ProductDetails id_spins1;
    public ProductDetails id_spins2;
    public ProductDetails id_spins3;
    public ProductDetails id_spins4;
    public ProductDetails id_spins5;
    public ProductDetails id_spins6;
    public ProductDetails restaurant_rivals_ooc_bundle;
    public ProductDetails restaurant_rivals_oos_free1;
    public ProductDetails restaurant_rivals_oos_free2;
    public ProductDetails restaurant_rivals_oos_paid1;
    public ProductDetails restaurant_rivals_oos_paid2;
    public ProductDetails restaurant_rivals_oos_paid3;
    public ProductDetails id_piggybank_raid_1;
    public ProductDetails id_piggybank_raid_2;
    public ProductDetails id_piggybank_raid_3;
    public ProductDetails id_piggybank_raid_4;
    public ProductDetails id_piggybank_raid_5;
    public ProductDetails id_season_plus_pass;
    public ProductDetails progressive_sale_1;
    public ProductDetails progressive_sale_2;
    public ProductDetails progressive_sale_3;
    public ProductDetails progressive_sale_4;
    public ProductDetails progressive_sale_5;
    public ProductDetails progressive_sale_6;
    public ProductDetails progressive_sale_7;
    public ProductDetails progressive_sale_8;
    public ProductDetails progressive_sale_9;
    private string[] skus;
    private System.Collections.Generic.Dictionary<ProductDetails.Category, System.Collections.Generic.List<string>> prodSkus;
    private string[] ids;
    private ProductDetails[] prodDetails;
    
    // Methods
    public string GetSku(string internalId)
    {
        ProductDetails val_1 = this.GetProductByInternalId(internalId:  internalId);
        if(this != 0)
        {
                this = this.CurrencyTheme;
        }
        
        if(this == 0)
        {
                this = 0;
        }
    
    }
    public string GetId(string sku)
    {
        ProductDetails val_1 = this.GetProductBySku(sku:  sku);
        if(this == 0)
        {
                this = 0;
        }
    
    }
    public ProductDetails GetProductByInternalId(string internalId)
    {
        var val_3;
        ProductDetails[] val_1 = this.GetProductDetails();
        var val_3 = 0;
        label_5:
        if(val_3 >= this.CurrencyTheme)
        {
            goto label_1;
        }
        
        val_3 = mem[this.MostPopularPackPrice + 0];
        val_3 = this.MostPopularPackPrice + 0;
        val_3 = val_3 + 1;
        if((this.MostPopularPackPrice + 0 + 8.Equals(value:  internalId)) == false)
        {
            goto label_5;
        }
        
        return;
        label_1:
        val_3 = 0;
    }
    public ProductDetails GetProductBySku(string sku)
    {
        var val_6;
        ProductDetails[] val_1 = this.GetProductDetails();
        var val_6 = 0;
        label_8:
        if(val_6 >= this.CurrencyTheme)
        {
            goto label_2;
        }
        
        val_6 = mem[this.MostPopularPackPrice + 0];
        val_6 = this.MostPopularPackPrice + 0;
        if((this.MostPopularPackPrice + 0 + 12.Equals(value:  sku)) == true)
        {
                return;
        }
        
        if((System.String.op_Equality(a:  this.MostPopularPackPrice + 0 + 12, b:  -1768739600)) == false)
        {
                "word_game_removeAds1" = this.MostPopularPackPrice + 0 + 12;
        }
        
        val_6 = val_6 + 1;
        if(("word_game_removeAds1".Equals(value:  sku)) == false)
        {
            goto label_8;
        }
        
        return;
        label_2:
        val_6 = 0;
        string val_5 = -1768739376(-1768739376) + sku;
        UnityEngine.Debug.LogError(message:  -1768739376);
    }
    public string[] GetSkus()
    {
        var val_4;
        if(R1 != 0)
        {
                return;
        }
        
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        ProductDetails[] val_2 = this.GetProductDetails();
        val_4 = 0;
        goto label_2;
        label_7:
        Add(item:  this.MostPopularPackPrice + 0 + 12);
        val_4 = 1;
        label_2:
        if(val_4 < this.CurrencyTheme)
        {
            goto label_7;
        }
        
        T[] val_3 = ToArray();
        this.skus = null;
    }
    public string[] GetSkusBy(ProductDetails.Category cat)
    {
        StoreConfig val_7;
        var val_8;
        val_7 = this;
        if((this.prodSkus.ContainsKey(key:  cat)) != false)
        {
                System.Collections.Generic.List<System.String> val_2 = this.prodSkus.Item[cat];
            if(this.prodSkus >= 1)
        {
                System.Collections.Generic.List<System.String> val_3 = this.prodSkus.Item[cat];
            val_8 = public T[] System.Collections.Generic.List<System.String>::ToArray();
            return ToArray();
        }
        
        }
        
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_4 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        ProductDetails[] val_5 = this.GetProductDetails();
        val_7 = 0;
        goto label_9;
        label_16:
        if((this.MostPopularPackPrice + 0.isCategory(cat:  cat)) != false)
        {
                Add(item:  this.MostPopularPackPrice + 0 + 12);
        }
        
        val_7 = 1;
        label_9:
        if(val_7 < this.CurrencyTheme)
        {
            goto label_16;
        }
        
        this.prodSkus.Add(key:  cat, value:  80883712);
        val_8 = public T[] System.Collections.Generic.List<System.String>::ToArray();
        return ToArray();
    }
    public string[] GetIds()
    {
        var val_4;
        if(R1 != 0)
        {
                return;
        }
        
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        ProductDetails[] val_2 = this.GetProductDetails();
        val_4 = 0;
        goto label_2;
        label_7:
        Add(item:  this.MostPopularPackPrice + 0 + 8);
        val_4 = 1;
        label_2:
        if(val_4 < this.CurrencyTheme)
        {
            goto label_7;
        }
        
        T[] val_3 = ToArray();
        this.ids = null;
    }
    public ProductDetails[] GetProductDetails()
    {
        StoreConfig val_9;
        var val_10;
        StoreConfig val_11;
        var val_12;
        val_9 = this;
        if(R1 != 0)
        {
                return;
        }
        
        val_10 = 0;
        System.Type val_2 = this.GetType();
        val_11 = val_9;
        goto label_3;
        label_25:
        val_12 = 0;
        val_11 = val_9;
        val_10 = 1;
        label_3:
        if(val_10 < mem[1152921511428770460])
        {
            goto label_25;
        }
        
        T[] val_8 = ToArray();
        this.prodDetails = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
    }
    private void OverrideIOSspecificPackageNames()
    {
    
    }
    public StoreConfig()
    {
        this.MostPopularPackPrice = 19.99f;
        this.ScratchCardPriceThreshold = 9.99f;
        System.Collections.Generic.Dictionary<WordPets.WordPetRarity, System.Collections.Generic.List<WordPets.WordPet>> val_1 = new System.Collections.Generic.Dictionary<WordPets.WordPetRarity, System.Collections.Generic.List<WordPets.WordPet>>();
        this.prodSkus = null;
    }

}
