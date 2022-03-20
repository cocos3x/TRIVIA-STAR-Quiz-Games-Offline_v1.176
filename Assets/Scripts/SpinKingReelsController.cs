using UnityEngine;
public class SpinKingReelsController : MonoBehaviour
{
    // Fields
    private Scroller[] reels;
    public System.Action<int> OnSpinReelStop;
    private System.Collections.Generic.Queue<SpinKingSymbolItemData> SymbolItemDataArray;
    private SpinKingSlotMachine.SpinKingSymbol[,] ReelData;
    private SpinKingSlotMachine.SpinKingSymbol[,] previousReelData;
    
    // Methods
    private void Start()
    {
        this.GetRealData();
        this.SetPreviousReelData();
        var val_2 = 0;
        do
        {
            this.reels[val_2].Init();
            val_2 = val_2 + 1;
        }
        while(val_2 != 3);
        
        this.InitReelSymbols();
    }
    private void GetRealData()
    {
        var val_1;
        var val_2;
        var val_3;
        var val_3 = 0;
        do
        {
            var val_2 = 0;
            do
        {
            var val_1 = 19695056;
            val_1 = 15949764 + val_1;
            val_1 = null;
            val_1 = null;
            val_2 = mem[SpinKingSlotMachine.<ReelData>k__BackingField + 8];
            val_2 = SpinKingSlotMachine.<ReelData>k__BackingField + 8;
            if(val_2 <= val_3)
        {
                val_2 = mem[SpinKingSlotMachine.<ReelData>k__BackingField + 8];
            val_2 = SpinKingSlotMachine.<ReelData>k__BackingField + 8;
        }
        
            val_2 = (SpinKingSlotMachine.<ReelData>k__BackingField) + (val_2 << 2);
            val_3 = mem[mem[1152921513007420424] + 8];
            val_3 = mem[1152921513007420424] + 8;
            if(val_3 <= val_3)
        {
                val_3 = mem[mem[1152921513007420424] + 8];
            val_3 = mem[1152921513007420424] + 8;
        }
        
            val_2 = val_2 + 1;
            val_3 = mem[1152921513007420424] + (val_3 << 2);
            mem2[0] = (SpinKingSlotMachine.<ReelData>k__BackingField + (SpinKingSlotMachine.<ReelData>k__BackingField + 8) << 2) + 16;
        }
        while(val_2 != 5);
        
            val_3 = val_3 + 1;
        }
        while(val_3 != 3);
    
    }
    private void InitReelSymbols()
    {
        var val_6 = 0;
        do
        {
            var val_4 = 0;
            do
        {
            SpinKingSymbolItemData val_2 = this.GetRESSymbolItemDataObject(symbol:  this.ReelData[new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>()]);
            Add(item:  -189164176);
            val_4 = val_4 + 1;
        }
        while(val_4 != 5);
        
            this.reels[val_6].InitScrollerIteam<System.Object>(data:  80883712);
            val_6 = val_6 + 1;
        }
        while(val_6 != 3);
    
    }
    public void StartSpin()
    {
        this.SetPreviousReelData();
        this.GetRealData();
        System.Collections.IEnumerator val_1 = this.ActualSpinStart();
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  -188970256);
    }
    private void SetPreviousReelData()
    {
        var val_3 = 0;
        do
        {
            var val_2 = 0;
            do
        {
            val_2 = val_2 + 1;
            this.previousReelData[this.ReelData[this]] = this.ReelData[this];
        }
        while(val_2 != 5);
        
            val_3 = val_3 + 1;
        }
        while(val_3 != 3);
    
    }
    private System.Collections.IEnumerator ActualSpinStart()
    {
        object val_1 = new System.Object();
        typeof(SpinKingReelsController.<ActualSpinStart>d__10).__il2cppRuntimeField_8 = 0;
        typeof(SpinKingReelsController.<ActualSpinStart>d__10).__il2cppRuntimeField_10 = this;
    }
    private SpinKingSymbolItemData GetRESSymbolItemDataObject(SpinKingSlotMachine.SpinKingSymbol symbol)
    {
        var val_3;
        if(true >= 1)
        {
                SpinKingSymbolItemData val_1 = this.SymbolItemDataArray.Dequeue();
            val_3 = this.SymbolItemDataArray;
        }
        else
        {
                SpinKingSymbolItemData val_2 = null;
            val_3 = val_2;
            val_2 = new SpinKingSymbolItemData();
        }
        
        typeof(SpinKingSymbolItemData).__il2cppRuntimeField_8 = symbol;
    }
    public void RecycleRESSymbolItemData(SpinKingSymbolItemData itemData)
    {
        this.SymbolItemDataArray.Enqueue(item:  itemData);
    }
    public SpinKingReelsController()
    {
        System.Collections.Generic.Queue<twelvegigs.net.JsonRequest> val_1 = new System.Collections.Generic.Queue<twelvegigs.net.JsonRequest>();
        this.SymbolItemDataArray = null;
        this.ReelData = null;
        this.previousReelData = null;
    }

}
