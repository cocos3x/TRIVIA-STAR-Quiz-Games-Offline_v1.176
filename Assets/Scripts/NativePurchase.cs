using UnityEngine;
public class NativePurchase
{
    // Fields
    private NativePurchaseErrorCode errorCode;
    private string purchaseId;
    private string sku;
    private string packageName;
    private string token;
    private string signature;
    private string stuff;
    private string errorString;
    private string kindleUserId;
    private string originalJson;
    private bool isSubscription;
    private bool isConsumable;
    private bool isPending;
    
    // Properties
    public string Sku { get; set; }
    public string PackageName { get; set; }
    public static string Platform { get; }
    public string PurchaseId { get; set; }
    public string Token { get; set; }
    public string Signature { get; set; }
    public string ErrorString { get; set; }
    public string KindleUserId { get; set; }
    public string OriginalJson { get; set; }
    public NativePurchaseErrorCode ErrorCode { get; set; }
    public string RawError { get; set; }
    public bool IsSubscription { get; }
    public bool IsConsumable { get; }
    public bool IsPending { get; set; }
    
    // Methods
    public string get_Sku()
    {
    
    }
    public void set_Sku(string value)
    {
        this.sku = value;
    }
    public string get_PackageName()
    {
    
    }
    public void set_PackageName(string value)
    {
        this.packageName = value;
    }
    public static string get_Platform()
    {
    
    }
    public string get_PurchaseId()
    {
    
    }
    public void set_PurchaseId(string value)
    {
        this.purchaseId = value;
    }
    public string get_Token()
    {
    
    }
    public void set_Token(string value)
    {
        this.token = value;
    }
    public string get_Signature()
    {
    
    }
    public void set_Signature(string value)
    {
        this.signature = value;
    }
    public string get_ErrorString()
    {
    
    }
    public void set_ErrorString(string value)
    {
        this.token = value;
    }
    public string get_KindleUserId()
    {
    
    }
    public void set_KindleUserId(string value)
    {
        if(value != null)
        {
                this.kindleUserId = value;
            return;
        }
        
        this.kindleUserId = "no_id";
    }
    public string get_OriginalJson()
    {
    
    }
    public void set_OriginalJson(string value)
    {
        this.originalJson = value;
    }
    public NativePurchaseErrorCode get_ErrorCode()
    {
    
    }
    public void set_ErrorCode(NativePurchaseErrorCode value)
    {
        this.errorCode = value;
    }
    public string get_RawError()
    {
    
    }
    public void set_RawError(string value)
    {
        this.errorString = value;
    }
    public bool get_IsSubscription()
    {
        return (bool)this.isSubscription;
    }
    public bool get_IsConsumable()
    {
        return (bool)this.isConsumable;
    }
    public bool get_IsPending()
    {
        return (bool)this.isPending;
    }
    public void set_IsPending(bool value)
    {
        this.isPending = value;
    }
    public NativePurchase()
    {
    
    }
    public NativePurchase(string sku)
    {
        var val_3;
        this.sku = sku;
        AppConfigs val_1 = App.Configuration;
        ProductDetails val_2 = 0.GetProductBySku(sku:  sku);
        if(0 != 0)
        {
                val_3 = 0;
            this.isSubscription = false;
        }
        else
        {
                val_3 = 16;
            this.isSubscription = false;
        }
        
        this.isConsumable = false;
    }
    public NativePurchase(NativePurchaseErrorCode errorCode, string errorString)
    {
        val_1 = new System.Object();
        this.errorString = val_1;
        this.errorCode = errorCode;
    }
    private static NativePurchaseErrorCode setNativePurchaseErrorCodeKindle(string error)
    {
        string val_1 = error.ToUpper();
        if((error.Contains(value:  -1830438160)) == true)
        {
                return;
        }
        
        string val_3 = error.ToUpper();
        if((error.Contains(value:  -1830438064)) == true)
        {
                return;
        }
        
        string val_5 = error.ToUpper();
        if((error.Contains(value:  -1830437952)) == true)
        {
                return;
        }
        
        string val_7 = error.ToUpper();
        if((error.Contains(value:  -1830437872)) == true)
        {
                return;
        }
        
        string val_9 = error.ToUpper();
        if((error.Contains(value:  -1830437776)) == true)
        {
                6 = 0;
        }
    
    }
    private static NativePurchaseErrorCode setNativePurchaseErrorCodeAndroid(string error)
    {
        if((error.Contains(value:  -1830317488)) == true)
        {
                return;
        }
        
        if((error.Contains(value:  -1830317408)) == true)
        {
                return;
        }
        
        if((error.Contains(value:  -1830317328)) == true)
        {
                return;
        }
        
        if((error.Contains(value:  -1830317248)) == true)
        {
                return;
        }
        
        if((error.Contains(value:  1633189168)) == true)
        {
                return;
        }
        
        if((error.Contains(value:  1701898768)) == true)
        {
                return;
        }
        
        if((error.Contains(value:  -1830317168)) == true)
        {
                return;
        }
        
        if((error.Contains(value:  1635357440)) == true)
        {
                return;
        }
        
        if((error.Contains(value:  -1830317088)) == true)
        {
                return;
        }
        
        if((error.Contains(value:  -1830317008)) == true)
        {
                return;
        }
        
        if((error.Contains(value:  -1830316928)) == true)
        {
                return;
        }
        
        if((error.Contains(value:  1635473616)) == true)
        {
                6 = 14;
        }
    
    }
    public static NativePurchaseErrorCode setNavitePurchaseErrorCode(string error)
    {
        var val_3 = 22868918;
        val_3 = 12769584 + val_3;
        if(val_3 == 0)
        {
                mem2[0] = 1;
        }
        
        if((System.String.op_Equality(a:  1726392512, b:  1726392512)) != false)
        {
                return NativePurchase.setNativePurchaseErrorCodeAndroid(error:  error);
        }
        
        if((System.String.op_Equality(a:  1726392512, b:  -1830196656)) == false)
        {
                return;
        }
        
        return NativePurchase.setNativePurchaseErrorCodeKindle(error:  error);
    }
    public void AddStoreSpecificDataForValidation(ref System.Collections.Generic.Dictionary<string, object> postParams)
    {
        System.Collections.Generic.Dictionary<System.String, System.Object> val_5;
        string val_6;
        System.Collections.Generic.Dictionary<System.String, System.Object> val_7;
        string val_8;
        var val_9;
        var val_10;
        var val_5 = 22868682;
        val_5 = 12769820 + val_5;
        if(val_5 == 0)
        {
                mem2[0] = 1;
        }
        
        postParams.Add(key:  -1830076464, value:  1726392512);
        if(val_5 == 0)
        {
                mem2[0] = 1;
        }
        
        if((System.String.op_Equality(a:  1726392512, b:  1726392512)) == false)
        {
            goto label_4;
        }
        
        postParams.Add(key:  -1830072288, value:  this.packageName);
        postParams.Add(key:  -1876049584, value:  this.sku);
        label_22:
        postParams.Add(key:  1339790624, value:  this.token);
        val_5 = postParams;
        val_6 = this.signature;
        val_5.Add(key:  1470913968, value:  val_6);
        val_7 = postParams;
        val_8 = this.originalJson;
        val_9 = public System.Void System.Collections.Generic.Dictionary<System.String, System.Object>::Add(System.String key, System.Object value);
        val_10 = "originalJson";
        goto label_14;
        label_4:
        if((System.String.op_Equality(a:  1726392512, b:  1726393632)) == false)
        {
            goto label_11;
        }
        
        val_5 = postParams;
        val_6 = this.token;
        val_5.Add(key:  -1830051712, value:  val_6);
        val_7 = postParams;
        val_8 = this.purchaseId;
        val_9 = public System.Void System.Collections.Generic.Dictionary<System.String, System.Object>::Add(System.String key, System.Object value);
        val_10 = "purchase_id";
        goto label_14;
        label_11:
        if((System.String.op_Equality(a:  1726392512, b:  -1830196656)) == false)
        {
            goto label_15;
        }
        
        postParams.Add(key:  -1876049584, value:  this.sku);
        val_5 = postParams;
        val_6 = this.kindleUserId;
        val_5.Add(key:  -1830039232, value:  val_6);
        val_7 = postParams;
        val_8 = this.token;
        val_9 = public System.Void System.Collections.Generic.Dictionary<System.String, System.Object>::Add(System.String key, System.Object value);
        val_10 = "purchase_token";
        label_14:
        label_26:
        val_7.Add(key:  -1830035040, value:  val_8);
        return;
        label_15:
        if((System.String.op_Equality(a:  1726392512, b:  -1830034944)) == false)
        {
            goto label_19;
        }
        
        postParams.Add(key:  -1876049584, value:  this.sku);
        if(postParams != 0)
        {
            goto label_22;
        }
        
        goto label_22;
        label_19:
        postParams.Add(key:  -1830072288, value:  this.packageName);
        postParams.Add(key:  -1876049584, value:  this.sku);
        if(postParams != 0)
        {
            goto label_26;
        }
        
        goto label_26;
    }

}
