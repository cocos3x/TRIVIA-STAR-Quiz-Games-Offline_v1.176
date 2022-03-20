using UnityEngine;
public class TRVSpecialCategoriesQuiz : TRVQuizProgress
{
    // Fields
    public bool isPromoQuiz;
    
    // Properties
    public override bool quizLevelsPlayer { get; }
    
    // Methods
    public override bool get_quizLevelsPlayer()
    {
        return false;
    }
    public TRVSpecialCategoriesQuiz(TRVSubCategoryData quizCategoryData, bool isPromo = False)
    {
        mem[1152921512717389204] = quizCategoryData;
        this.isPromoQuiz = isPromo;
        mem[1152921512717389176] = quizCategoryData.subCategory;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(this.isPromoQuiz == true)
        {
                this.isPromoQuiz = 1;
        }
        
        mem[1152921512717389180] = GetNewQuizLength(isPromo:  true);
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        ChestType val_4 = GetChestType();
        mem[1152921512717389220] = public static TRVDataParser MonoSingleton<TRVDataParser>::get_Instance();
        mem[1152921512717389196] = 0;
        mem[1152921512717389184] = new TRVGameplayState();
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(this.isPromoQuiz == true)
        {
                this.isPromoQuiz = 1;
        }
        
        mem[1152921512717389212] = GetNewQuizLevel(isPromo:  true);
    }
    protected override void GetNextQuestion(bool extraLifeQuestion)
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(this.isPromoQuiz == true)
        {
                this.isPromoQuiz = 1;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        QuestionData val_5 = public static TRVDataParser MonoSingleton<TRVDataParser>::get_Instance().__il2cppRuntimeField_28.GetQuestion(myData:  R7, subCat:  SB, desiredDifficulty:  GetNewQuestionDifficulty(quizProgressIndex:  35630029, isPromo:  true), completedThisDifficulty: ref  1152921512717509444);
        mem[1152921512717509380] = public static TRVDataParser MonoSingleton<TRVDataParser>::get_Instance().__il2cppRuntimeField_28;
    }

}
