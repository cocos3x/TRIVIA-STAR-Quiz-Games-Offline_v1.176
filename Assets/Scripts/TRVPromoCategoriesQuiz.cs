using UnityEngine;
public class TRVPromoCategoriesQuiz : TRVQuizProgress
{
    // Fields
    public bool isPromoQuiz;
    
    // Properties
    public override bool quizLevelsPlayer { get; }
    
    // Methods
    public override bool get_quizLevelsPlayer()
    {
        return true;
    }
    public TRVPromoCategoriesQuiz(TRVSubCategoryData quizCategoryData, int quizLength, int quizLevel, ChestType chestType, bool isPromo = False)
    {
        float val_2;
        System.Collections.Generic.IEnumerable<TSource> val_3;
        TRVPromoCategoriesQuiz val_15;
        TRVSubCategoryData val_16;
        var val_17;
        var val_18;
        var val_19;
        System.Func<QuestionData, System.Boolean> val_21;
        float val_22;
        var val_23;
        System.Predicate<QuestionData> val_25;
        val_15 = this;
        val_16 = quizCategoryData;
        mem[1152921512615670276] = val_16;
        this.isPromoQuiz = isPromo;
        val_17 = null;
        val_17 = null;
        if(TRVPromoCategoriesHandler.prefs_promo_quiz_completed_key == null)
        {
            goto label_13;
        }
        
        Dictionary.Enumerator<TKey, TValue> val_1 = GetEnumerator();
        val_18 = 0;
        goto label_6;
        label_12:
        val_19 = null;
        val_16 = val_3;
        val_19 = null;
        val_21 = TRVPromoCategoriesQuiz.<>c.<>9__3_0;
        if(val_21 == 0)
        {
                val_21 = null;
            val_21 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  TRVPromoCategoriesQuiz.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3713824800));
            TRVPromoCategoriesQuiz.<>c.<>9__3_0 = val_21;
        }
        
        val_18 = (System.Linq.Enumerable.Count<twelvegigs.storage.JsonDictionary>(source:  val_16, predicate:  7720960)) + val_18;
        label_6:
        if(0.MoveNext() == true)
        {
            goto label_12;
        }
        
        0.Dispose();
        val_15 = val_15;
        if(val_18 < 1)
        {
            goto label_13;
        }
        
        Dictionary.Enumerator<TKey, TValue> val_7 = GetEnumerator();
        val_21 = 1152921512615642144;
        val_22 = 1152921512615643168;
        label_23:
        if(val_2.MoveNext() == false)
        {
            goto label_16;
        }
        
        val_23 = null;
        val_23 = null;
        val_25 = TRVPromoCategoriesQuiz.<>c.<>9__3_1;
        if(val_25 == 0)
        {
                val_25 = null;
            val_25 = new System.Predicate<ZooTile>(object:  TRVPromoCategoriesQuiz.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3713827872));
            TRVPromoCategoriesQuiz.<>c.<>9__3_1 = val_25;
        }
        
        int val_10 = val_3.RemoveAll(match:  8040448);
        goto label_23;
        label_16:
        val_2.Dispose();
        val_15 = val_15;
        label_13:
        mem[1152921512615670248] = quizCategoryData + 8;
        mem[1152921512615670252] = quizLength;
        mem[1152921512615670292] = chestType;
        mem[1152921512615670268] = quizLength;
        mem[1152921512615670284] = quizLevel;
        mem[1152921512615670256] = new TRVGameplayState();
        twelvegigs.Autopilot.AutopilotManager val_12 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Int32[] val_13 = GetQuizDifficultyArray(quizCategory:  mem[1152921512615670248]);
        mem[1152921512615670328] = null;
        System.Array.Copy(sourceArray:  -581136352, destinationArray:  478302960, length:  System.Int32[].__il2cppRuntimeField_namespaze);
        mem[1152921512615670300] = TRVMainController.currentMultiplier;
    }
    protected override void GetNextQuestion(bool extraLifeQuestion)
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        QuestionData val_5 = public static TRVDataParser MonoSingleton<TRVDataParser>::get_Instance().__il2cppRuntimeField_28.GetQuestion(myData:  R7, subCat:  SB, desiredDifficulty:  GetNextQuestionDifficulty(quizProgress:  extraLifeQuestion, quiz:  -580991136), completedThisDifficulty: ref  1152921512615790516);
        mem[1152921512615790452] = public static TRVDataParser MonoSingleton<TRVDataParser>::get_Instance().__il2cppRuntimeField_28;
    }

}
