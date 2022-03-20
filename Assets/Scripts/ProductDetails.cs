using UnityEngine;
[Serializable]
public class ProductDetails
{
    // Fields
    public string internalId;
    public string sku;
    public ProductDetails.ProductType productType;
    
    // Methods
    public bool isCategory(ProductDetails.Category cat)
    {
        if(cat != 0)
        {
                if(cat != 1)
        {
                return false;
        }
        
            if(this.productType != 2)
        {
                1 = 0;
        }
        
            return (bool)1;
        }
        
        if(this.productType != 2)
        {
                return true;
        }
        
        return false;
    }
    public ProductDetails()
    {
    
    }

}
