using UnityEngine;
public class TRVSpecialCategoriesManager : MonoSingleton<TRVSpecialCategoriesManager>
{
    // Properties
    private TRVSpecialCategoriesEventHandler SpecialEventHandler { get; }
    private TRVPromoCategoriesHandler PromoHandler { get; }
    
    // Methods
    private TRVSpecialCategoriesEventHandler get_SpecialEventHandler()
    {
    
    }
    private TRVPromoCategoriesHandler get_PromoHandler()
    {
        return MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
    }
    public static bool IsSpecialCategory(string subcategory)
    {
        var val_12;
        var val_13;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_12 = public static TRVSpecialCategoriesManager MonoSingleton<TRVSpecialCategoriesManager>::get_Instance();
        val_13 = 0;
        if((-607046320) == 0)
        {
                return (bool)val_13;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        TRVPromoCategoriesHandler val_4 = PromoHandler;
        if((-607046320) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            TRVPromoCategoriesHandler val_7 = PromoHandler;
            val_13 = 1;
            if((IsActivePromo(subCategoryName:  subcategory)) == true)
        {
                return (bool)val_13;
        }
        
        }
        
        twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        var val_12 = 27394702;
        val_12 = 8235548 + val_12;
        if(val_12 == 0)
        {
                mem2[0] = 1;
        }
        
        val_12 = 1152921504971436032;
        if(TRVSpecialCategoriesEventHandler.EVENT_TRACKING_ID != null)
        {
                twelvegigs.Autopilot.AutopilotManager val_10 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(val_12 == 0)
        {
                mem2[0] = 1;
        }
        
            if((System.String.op_Equality(a:  TRVSpecialCategoriesEventHandler.EVENT_TRACKING_ID + 32, b:  subcategory)) == false)
        {
                val_13 = 0;
        }
        
            return (bool)val_13;
        }
        
        val_13 = 0;
        return (bool)val_13;
    }
    public static bool IsOldSpecialQuiz(TRVQuizProgress progress)
    {
        if(progress == 0)
        {
                return (bool)0;
        }
        
        0 = (((TRVQuizProgress.__il2cppRuntimeField_typeHierarchy + (TRVSpecialCategoriesQuiz.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4 - null)) >> 5;
        return (bool)0;
    }
    public int GetQuizProgress(TRVQuizProgress progress)
    {
        var val_2 = 0;
        if(TRVSpecialCategoriesEventHandler.EVENT_TRACKING_ID == null)
        {
                return (int)val_2;
        }
        
        if((TRVSpecialCategoriesManager.IsOldSpecialQuiz(progress:  progress)) == false)
        {
                return (int)val_2;
        }
        
        val_2 = mem[TRVSpecialCategoriesEventHandler.EVENT_TRACKING_ID + 36];
        val_2 = TRVSpecialCategoriesEventHandler.EVENT_TRACKING_ID + 36;
        return (int)val_2;
    }
    public bool IsRewardReadyToCollect(TRVQuizProgress progress)
    {
        if((TRVSpecialCategoriesManager.IsOldSpecialQuiz(progress:  progress)) == false)
        {
                return false;
        }
        
        if(TRVSpecialCategoriesEventHandler.EVENT_TRACKING_ID == null)
        {
            
        }
    
    }
    public int GetCurrentReward(TRVQuizProgress progress)
    {
        if((TRVSpecialCategoriesManager.IsOldSpecialQuiz(progress:  progress)) == false)
        {
                return 0;
        }
        
        if(TRVSpecialCategoriesEventHandler.EVENT_TRACKING_ID != null)
        {
                return TRVSpecialCategoriesEventHandler.EVENT_TRACKING_ID.getCurrentReward();
        }
        
        return TRVSpecialCategoriesEventHandler.EVENT_TRACKING_ID.getCurrentReward();
    }
    public void CollectReward(TRVQuizProgress progress)
    {
        if((TRVSpecialCategoriesManager.IsOldSpecialQuiz(progress:  progress)) == false)
        {
                return;
        }
        
        TRVSpecialCategoriesEventHandler.EVENT_TRACKING_ID.CollectReward();
    }
    public int GetNewQuizLength(bool isPromo)
    {
        if(isPromo == true)
        {
                return 0;
        }
        
        if(TRVSpecialCategoriesEventHandler.EVENT_TRACKING_ID == null)
        {
                return 0;
        }
        
        return TRVSpecialCategoriesEventHandler.EVENT_TRACKING_ID.GetQuizLength();
    }
    public int GetNewQuizLevel(bool isPromo)
    {
        if(isPromo == true)
        {
                return (int)0;
        }
        
        if(TRVSpecialCategoriesEventHandler.EVENT_TRACKING_ID != null)
        {
                TRVSpecialCategoriesEventHandler.EVENT_TRACKING_ID = mem[TRVSpecialCategoriesEventHandler.EVENT_TRACKING_ID + 36];
            TRVSpecialCategoriesEventHandler.EVENT_TRACKING_ID = TRVSpecialCategoriesEventHandler.EVENT_TRACKING_ID + 36;
            0 = TRVSpecialCategoriesEventHandler.EVENT_TRACKING_ID + 1;
        }
        
        return (int)0;
    }
    public int GetNewQuestionDifficulty(int quizProgressIndex, bool isPromo)
    {
        if(isPromo == true)
        {
                return 0;
        }
        
        if(TRVSpecialCategoriesEventHandler.EVENT_TRACKING_ID == null)
        {
                return 0;
        }
        
        return TRVSpecialCategoriesEventHandler.EVENT_TRACKING_ID.GetQuestionDifficulty(quizProgress:  quizProgressIndex);
    }
    public UnityEngine.Sprite GetPromoSprite(string subCategoryName)
    {
        bool val_1 = this.IsPromoCategory(subCategoryName:  subCategoryName);
        if(val_1 == false)
        {
                return;
        }
        
        TRVPromoCategoriesHandler val_2 = val_1.PromoHandler;
        if(val_1 == true)
        {
                return val_1.GetIcon(subCategoryName:  subCategoryName);
        }
        
        return val_1.GetIcon(subCategoryName:  subCategoryName);
    }
    public bool IsPromoCategory(string subCategoryName)
    {
        TRVPromoCategoriesHandler val_1 = this.PromoHandler;
        if(this != 0)
        {
                return this.IsActivePromo(subCategoryName:  subCategoryName);
        }
        
        return this.IsActivePromo(subCategoryName:  subCategoryName);
    }
    public PromoCategoryType GetPromoType(string subCategoryName)
    {
        bool val_5 = static_value_021FABBB;
        if(val_5 != true)
        {
                val_5 = true;
        }
        
        TRVPromoCategoriesHandler val_1 = this.PromoHandler;
        TRVPromoCategory val_2 = val_5.GetPromoCategory(subCategoryName:  subCategoryName);
        if(val_5 != 0)
        {
                TRVPromoCategoriesHandler val_3 = this.PromoHandler;
            TRVPromoCategory val_4 = val_5.GetPromoCategory(subCategoryName:  subCategoryName);
            if(val_5 != 0)
        {
                return;
        }
        
            return;
        }
        
        UnityEngine.Debug.LogError(message:  -565604144);
    }
    public bool IsSpecialQuiz(string subCategoryName)
    {
        var val_3 = 1;
        if((this.IsPromoCategory(subCategoryName:  subCategoryName)) == true)
        {
                return (bool)val_3;
        }
        
        if(TRVSpecialCategoriesEventHandler.EVENT_TRACKING_ID != null)
        {
                if((System.String.op_Equality(a:  TRVSpecialCategoriesEventHandler.EVENT_TRACKING_ID + 32, b:  subCategoryName)) == false)
        {
                val_3 = 0;
        }
        
            return (bool)val_3;
        }
        
        val_3 = 0;
        return (bool)val_3;
    }
    public System.DateTime GetCategoryEndTime(string subCategoryName)
    {
        var val_5;
        string val_6;
        System.DateTime val_7;
        var val_8;
        bool val_1 = this.IsPromoCategory(subCategoryName:  R2);
        if(val_1 != false)
        {
                TRVPromoCategoriesHandler val_2 = val_1.PromoHandler;
            val_5 = val_1;
            val_6 = R2;
            TRVPromoCategory val_3 = val_5.GetPromoCategory(subCategoryName:  val_6);
            val_7 = mem[val_1 + 16];
            val_7 = val_1 + 16;
        }
        else
        {
                val_5 = 8237572 + 27392678;
            if(val_5 == 0)
        {
                mem2[0] = 1;
        }
        
            if((TRVSpecialCategoriesEventHandler.EVENT_TRACKING_ID != null) && ((System.String.op_Equality(a:  TRVSpecialCategoriesEventHandler.EVENT_TRACKING_ID + 32, b:  R2)) != false))
        {
                if(val_5 == 0)
        {
                mem2[0] = 1;
        }
        
            if(TRVSpecialCategoriesEventHandler.EVENT_TRACKING_ID != null)
        {
                return new System.DateTime() {dateData = 1152921512631441984};
        }
        
            return new System.DateTime() {dateData = 1152921512631441984};
        }
        
            val_8 = null;
            val_8 = null;
            val_7 = System.DateTime.MinValue;
        }
        
        this = val_7;
        return new System.DateTime() {dateData = val_7};
    }
    public void OnCategorySelected(TRVCategorySelectionInfo selectionInfo)
    {
        this.OnCategorySelected(categoryName:  selectionInfo.categoryName);
    }
    public void OnCategorySelected(string categoryName)
    {
        TRVPromoCategoriesHandler val_1 = this.PromoHandler;
        bool val_2 = this.IsActivePromo(subCategoryName:  categoryName);
        if(val_2 == false)
        {
                return;
        }
        
        TRVPromoCategoriesHandler val_3 = val_2.PromoHandler;
        val_2.HandleCategorySelected(categoryName:  R4);
    }
    public void OnQuizComplete(TRVQuizProgress quiz)
    {
        bool val_1 = this.IsPromoCategory(subCategoryName:  quiz.quizCategory);
        if(val_1 == false)
        {
                return;
        }
        
        TRVPromoCategoriesHandler val_2 = val_1.PromoHandler;
        val_1.OnCategoryQuizComplete(quiz:  R4);
    }
    public void OnQuestionComplete(TRVQuizProgress quiz)
    {
        string val_9;
        if((this.IsPromoCategory(subCategoryName:  quiz.quizCategory)) == false)
        {
                return;
        }
        
        int val_2 = quiz.correctAnswers;
        if(val_2 < quiz.correctAnswerRequirement)
        {
                return;
        }
        
        TRVPromoCategoriesHandler val_3 = val_2.PromoHandler;
        val_9 = quiz.quizCategory;
        TRVPromoCategory val_4 = val_2.GetPromoCategory(subCategoryName:  val_9);
        if(val_2 == 0)
        {
                return;
        }
        
        TRVPromoCategoriesHandler val_5 = val_2.PromoHandler;
        val_9 = val_2;
        if((val_9.ShouldShowEndOfQuiz(progress:  quiz)) == false)
        {
                return;
        }
        
        GameBehavior val_7 = App.getBehavior;
        val_9 = 0;
        0.SetupWithPromo(promo:  val_2, hidePaidEntry:  true, returnToCategorySelectOnButtonClose:  false, continueToNextLevel:  false);
    }
    public void OnLevelCompleteRewarded(TRVQuizProgress quiz)
    {
    
    }
    public UnityEngine.Sprite GetQuestionImageFromID(string subCategory, string questionID)
    {
        bool val_1 = this.IsPromoCategory(subCategoryName:  subCategory);
        if(val_1 == false)
        {
                return;
        }
        
        TRVPromoCategoriesHandler val_2 = val_1.PromoHandler;
        if(val_1 == true)
        {
                return val_1.GetQuestionImageFromID(subCategory:  subCategory, questionID:  questionID);
        }
        
        return val_1.GetQuestionImageFromID(subCategory:  subCategory, questionID:  questionID);
    }
    public string GetExpertForSpecialCategory(string subCategory)
    {
        bool val_1 = this.IsPromoCategory(subCategoryName:  subCategory);
        if(val_1 == false)
        {
                return;
        }
        
        TRVPromoCategoriesHandler val_2 = val_1.PromoHandler;
        if(val_1 == true)
        {
                return val_1.GetExpertForSpecialCategory(subCategory:  subCategory);
        }
        
        return val_1.GetExpertForSpecialCategory(subCategory:  subCategory);
    }
    private bool IsPromoQuiz(TRVQuizProgress progress)
    {
        TRVPromoCategoriesHandler val_1 = this.PromoHandler;
        if(this != 0)
        {
                return this.IsActivePromo(subCategoryName:  progress.quizCategory);
        }
        
        return this.IsActivePromo(subCategoryName:  progress.quizCategory);
    }
    public TRVSpecialCategoriesManager()
    {
    
    }

}
