using UnityEngine;
public class AlphabetWordRegion : WordRegionBase
{
    // Fields
    private LineWord lineWordPrefab;
    private Cell cellPrefab;
    private System.Collections.Generic.List<string> words;
    private System.Collections.Generic.List<string> progress;
    
    // Properties
    private LineWord LineWordPrefabLoaded { get; }
    private Cell CellPrefabLoaded { get; }
    
    // Methods
    private LineWord get_LineWordPrefabLoaded()
    {
        if(this.lineWordPrefab != 0)
        {
                return;
        }
        
        WordIQLineAnim val_2 = PrefabLoader.LoadPrefab<WordIQLineAnim>(featureName:  -1571728272);
        this.lineWordPrefab = "LineWord";
    }
    private Cell get_CellPrefabLoaded()
    {
        if(this.cellPrefab != 0)
        {
                return;
        }
        
        WordIQLineAnim val_2 = PrefabLoader.LoadPrefab<WordIQLineAnim>(featureName:  -1571598768);
        this.cellPrefab = "AlphabetCell";
    }
    public void Setup(System.Collections.Generic.List<string> requiredWords, System.Collections.Generic.List<string> progressWords)
    {
        this.words = requiredWords;
        this.progress = progressWords;
        System.Collections.IEnumerator val_1 = this.LoadCoroutine();
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  -1571442192);
    }
    public System.Collections.Generic.List<string> GetLevelProgress(System.Collections.Generic.List<string> savedProgress, System.Collections.Generic.List<string> orderedWordList)
    {
        var val_5;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        List.Enumerator<T> val_2 = GetEnumerator();
        label_14:
        if(MoveNext() == false)
        {
            goto label_2;
        }
        
        object val_4 = new System.Object();
        typeof(AlphabetWordRegion.<>c__DisplayClass9_0).__il2cppRuntimeField_8 = val_5;
        System.Predicate<ZooTile> val_6 = new System.Predicate<ZooTile>(object:  307240960, method:  new IntPtr(2723629488));
        int val_7 = savedProgress.FindIndex(match:  8040448);
        if(val_7 == 1)
        {
            goto label_5;
        }
        
        if(val_7 <= val_7)
        {
                var val_10 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_10 = val_10 + (val_7 << 2);
        string val_8 = (0 + (val_7) << 2) + 16.Remove(startIndex:  0, count:  val_5 + 8);
        Add(item:  (0 + (val_7) << 2) + 16);
        goto label_14;
        label_5:
        string val_9 = 0.CreateString(c:  '0', count:  val_5 + 8);
        Add(item:  0);
        goto label_14;
        label_2:
        Dispose();
    }
    private System.Collections.IEnumerator LoadCoroutine()
    {
        object val_1 = new System.Object();
        typeof(AlphabetWordRegion.<LoadCoroutine>d__10).__il2cppRuntimeField_8 = 0;
        typeof(AlphabetWordRegion.<LoadCoroutine>d__10).__il2cppRuntimeField_10 = this;
    }
    public AlphabetWordRegion()
    {
        this.words = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.progress = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
    }

}
