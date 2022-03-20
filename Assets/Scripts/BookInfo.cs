using UnityEngine;
public class BookInfo
{
    // Fields
    public string SKU;
    public string Title;
    public string Author;
    public BookRarity Rarity;
    public string Collection;
    
    // Methods
    public BookInfo(string sku, string title, string author, BookRarity rarity, string collection)
    {
        val_1 = new System.Object();
        this.SKU = sku;
        this.Title = val_1;
        this.Author = author;
        this.Rarity = rarity;
        this.Collection = collection;
    }
    public override string ToString()
    {
        return Newtonsoft.Json.JsonConvert.SerializeObject(value:  -1716494976, formatting:  0);
    }

}
