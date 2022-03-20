using UnityEngine;
public class TRVPromoCategory
{
    // Fields
    public PromoCategoryType promoCategoryType;
    public int entryCost;
    public System.DateTime timeEnd;
    public string subCategoryName;
    public int promoId;
    public string rewardUrl;
    public string iconUrlPath;
    public string iconSpriteName;
    public string questionsDataBlock;
    public string expertCategoryName;
    public int rollWeight;
    public System.Collections.Generic.Dictionary<int, int[]> quizDifficultyOrders;
    public System.Collections.Generic.Dictionary<int, int> quizLenngthLevelUnlocks;
    public System.Collections.Generic.Dictionary<int, int> rewards;
    
    // Properties
    public int RequiredQuizzesToComplete { get; }
    
    // Methods
    public int get_RequiredQuizzesToComplete()
    {
        Dictionary.KeyCollection<TKey, TValue> val_1 = this.rewards.Keys;
        return System.Linq.Enumerable.Max(source:  this.rewards);
    }
    public TRVPromoCategory()
    {
        this.promoId = 0;
    }

}
