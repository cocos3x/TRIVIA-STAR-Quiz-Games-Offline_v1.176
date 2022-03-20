using UnityEngine;
public class AlphabetBoxItem : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Text rarityLabel;
    private Cell cell;
    private readonly UnityEngine.Color[] colors;
    private Alphabet2Manager.Rarity myRarity;
    
    // Properties
    public Cell GetCell { get; }
    public UnityEngine.GameObject GetRarityLabel { get; }
    
    // Methods
    public Cell get_GetCell()
    {
    
    }
    public UnityEngine.GameObject get_GetRarityLabel()
    {
        if(this.rarityLabel != 0)
        {
                return this.rarityLabel.gameObject;
        }
        
        return this.rarityLabel.gameObject;
    }
    public void Setup(string letter)
    {
        Alphabet2Manager.Rarity val_4;
        UnityEngine.UI.Text val_5;
        UnityEngine.Color val_6;
        UnityEngine.Color val_7;
        UnityEngine.Color val_8;
        UnityEngine.Color val_9;
        this.cell.letter = letter;
        this.cell.SetAndShowText();
        this.cell.letterGroup.SetActive(value:  false);
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_4 = public static Alphabet2Manager MonoSingleton<Alphabet2Manager>::get_Instance();
        Rarity val_2 = GetRarity(letter:  letter);
        this.myRarity = val_4;
        if(val_4 > 3)
        {
                return;
        }
        
        var val_3 = 10999536 + mem[198133936];
        if(val_4 == 3)
        {
                mem[198133936] = mem[198133936] & (mem[198133936] << mem[198133936]);
            mem[198133936] = mem[198133936] & (mem[198133936] << 1);
            mem2[0] = ((mem[198133936] & (mem[198133936]) << mem[198133936]) & ((mem[198133936] & (mem[198133936]) << mem[198133936])) << 1) + ((mem[198133936] & (mem[198133936]) << mem[198133936]) & ((mem[198133936] & (mem[198133936]) << mem[198133936])) << 1);
        }
        
        val_5 = this.rarityLabel;
        val_6 = this.colors[0];
        val_7 = this.colors[0];
        val_8 = this.colors[0];
        val_9 = this.colors[0];
    }
    public AlphabetBoxItem()
    {
        UnityEngine.Color val_1 = new UnityEngine.Color(r:  null, g:  null, b:  null);
        UnityEngine.Color val_2 = new UnityEngine.Color(r:  null, g:  null, b:  null);
        UnityEngine.Color val_3 = new UnityEngine.Color(r:  null, g:  null, b:  null);
        UnityEngine.Color val_4 = new UnityEngine.Color(r:  null, g:  null, b:  null);
        this.colors = null;
    }

}
