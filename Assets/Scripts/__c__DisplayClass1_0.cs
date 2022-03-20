using UnityEngine;
private sealed class WPTPetJournalEntry.<>c__DisplayClass1_0
{
    // Fields
    public WordPets.WordPet wdPet;
    
    // Methods
    public WPTPetJournalEntry.<>c__DisplayClass1_0()
    {
    
    }
    internal bool <ScrollCellIndex>b__0(WordPets.PetData pData)
    {
        WordPets.WordPetType val_1 = this.wdPet.type;
        val_1 = pData.type - val_1;
        val_1 = val_1 >> 5;
        return (bool)val_1;
    }

}
