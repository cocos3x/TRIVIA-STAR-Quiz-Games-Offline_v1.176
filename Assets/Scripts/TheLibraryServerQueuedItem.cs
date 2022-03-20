using UnityEngine;
public class TheLibraryServerQueuedItem
{
    // Fields
    public string[] Skus;
    public bool Purchased;
    
    // Methods
    public TheLibraryServerQueuedItem()
    {
    
    }
    public TheLibraryServerQueuedItem(string sku, bool purchased)
    {
        typeof(System.String[]).__il2cppRuntimeField_10 = sku;
        this.Purchased = purchased;
        this.Skus = null;
    }
    public TheLibraryServerQueuedItem(string[] skus, bool purchased)
    {
        this.Purchased = purchased;
        this.Skus = skus;
    }

}
