using UnityEngine;
public class BookEconInfo
{
    // Fields
    public BookRarity Rarity;
    public int LibraryValue;
    public int GoldenAppleCost;
    public int FreeBookChance;
    
    // Methods
    public BookEconInfo(BookRarity rarity, int libraryValue, int goldenAppleCost, int freeBookChance)
    {
        this.Rarity = rarity;
        this.LibraryValue = libraryValue;
        this.GoldenAppleCost = goldenAppleCost;
        this.FreeBookChance = freeBookChance;
    }

}
