using UnityEngine;
public class AlphabetTile : MonoBehaviour
{
    // Fields
    private UnityEngine.Sprite commonBG;
    private UnityEngine.Sprite uncommonBG;
    private UnityEngine.Sprite rareBG;
    private UnityEngine.Sprite superBG;
    private UnityEngine.Sprite petBG;
    private UnityEngine.UI.Image bgImage;
    private bool matchParentScale;
    private bool useParentLetter;
    private bool useVideoLetter;
    private bool addOnClickAction;
    private Cell parentCell;
    private System.Action prevCellClickedAction;
    
    // Methods
    private void Start()
    {
        if(this.useVideoLetter == false)
        {
                this.useVideoLetter = this.useParentLetter;
            return;
        }
        
        this.Init(showPet:  false);
    }
    private void Setup(Alphabet2Manager.Rarity rarity, UnityEngine.Vector3 cellSize)
    {
        var val_3;
        UnityEngine.Sprite val_4;
        UnityEngine.UI.Image val_5;
        val_3 = this;
        if(rarity <= 3)
        {
                var val_1 = 11002560 + (11002560 + (rarity) << 2);
            if(rarity == 3)
        {
                11002560 = 11002560;
            11002560 = 11002560 & ((R8) << 11002560);
            11002560 = 11002560 & (11002560 >> 32);
            11002560 = 11002560 & ((R8) >> 32);
        }
        
            val_4 = this.commonBG;
            val_5 = this.bgImage;
            val_5.sprite = ;
        }
        
        if(this.matchParentScale == false)
        {
                return;
        }
        
        val_5 = cellSize.z;
        UnityEngine.Transform val_2 = this.transform;
        val_3 = val_3;
        this.localScale = new UnityEngine.Vector3() {x = cellSize.x, y = cellSize.y, z = val_5};
    }
    private void OnDisable()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        bool val_2 = UnityEngine.Object.op_Inequality(x:  -2100700048, y:  0);
        if(val_2 == true)
        {
                val_2 = this.addOnClickAction;
            goto label_5;
        }
        
        return;
        label_5:
        if(this.parentCell == 0)
        {
                return;
        }
        
        this.parentCell.CellClickedAction = this.prevCellClickedAction;
    }
    public void Init(bool showPet = False)
    {
        float val_4;
        float val_5;
        float val_6;
        float val_21;
        float val_22;
        float val_23;
        Cell val_24;
        var val_25;
        System.Action val_27;
        UnityEngine.UI.Image val_28;
        var val_29;
        object val_1 = this.GetComponentInParent<System.Object>();
        this.parentCell = this;
        UnityEngine.Transform val_2 = this.transform;
        UnityEngine.Vector3 val_3 = localScale;
        val_21 = val_4;
        val_22 = val_5;
        val_23 = val_6;
        if(this.parentCell == 0)
        {
            goto label_4;
        }
        
        UnityEngine.Transform val_8 = this.parentCell.letterGroup.transform;
        UnityEngine.Vector3 val_9 = localScale;
        val_21 = val_4;
        val_22 = val_5;
        val_23 = val_6;
        val_24 = this.parentCell;
        if(this.parentCell == 0)
        {
                val_24 = this.parentCell;
        }
        
        this.prevCellClickedAction = this.parentCell.CellClickedAction;
        twelvegigs.Autopilot.AutopilotManager val_10 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        this.parentCell.CellClickedAction = null;
        if(showPet == false)
        {
            goto label_21;
        }
        
        val_24 = 1152921504913981440;
        val_25 = null;
        val_25 = null;
        val_27 = AlphabetTile.<>c.<>9__15_0;
        if(val_27 == 0)
        {
                val_27 = null;
            val_27 = new System.Action(object:  AlphabetTile.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2722611440));
            AlphabetTile.<>c.<>9__15_0 = val_27;
        }
        
        this.parentCell.CellClickedAction = val_27;
        goto label_20;
        label_4:
        if(showPet == false)
        {
            goto label_21;
        }
        
        label_20:
        val_28 = this.bgImage;
        val_28.sprite = this.petBG;
        if(this.matchParentScale == false)
        {
                return;
        }
        
        UnityEngine.Transform val_12 = this.transform;
        this.localScale = new UnityEngine.Vector3() {x = val_21, y = val_22, z = val_23};
        return;
        label_21:
        if(this.useParentLetter == false)
        {
            goto label_26;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_13 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_29 = public static Alphabet2Manager MonoSingleton<Alphabet2Manager>::get_Instance();
        val_28 = this.parentCell.letter;
        goto label_30;
        label_26:
        if(this.useVideoLetter == false)
        {
            goto label_31;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_15 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_29 = public static Alphabet2Manager MonoSingleton<Alphabet2Manager>::get_Instance();
        twelvegigs.Autopilot.AutopilotManager val_16 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        string val_17 = GetCurrentVideoRewardLetter;
        val_28 = public static Alphabet2Manager MonoSingleton<Alphabet2Manager>::get_Instance();
        label_30:
        Rarity val_18 = GetRarity(letter:  -2100700048);
        label_39:
        this.Setup(rarity:  -2100700048, cellSize:  new UnityEngine.Vector3() {x = val_21, y = val_22, z = val_23});
        return;
        label_31:
        twelvegigs.Autopilot.AutopilotManager val_19 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        Rarity val_20 = GetCurrentRarity();
        goto label_39;
    }
    public AlphabetTile()
    {
    
    }

}
