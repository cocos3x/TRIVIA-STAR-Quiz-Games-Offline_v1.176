using UnityEngine;
public class TRVSpecialCategoriesLevelComplete : MonoBehaviour
{
    // Fields
    private TRVLevelComplete myPopup;
    private UnityEngine.UI.Text descText;
    private UnityEngine.UI.Image fillBar;
    private System.Collections.Generic.List<TRVDynamicSliderTick> sliderTicks;
    private UnityEngine.GameObject specialBarParent;
    private UnityEngine.UI.Button nextLevelButton;
    private UnityEngine.UI.Button continueButton;
    
    // Methods
    public void Init(TRVQuizProgress currentQuiz, TRVLevelComplete lcPopup)
    {
        System.Collections.Generic.IEnumerable<System.Int32> val_29;
        var val_30;
        System.Action<TRVDynamicSliderTick> val_32;
        System.Collections.Generic.IEnumerable<TSource> val_33;
        var val_34;
        var val_35;
        int val_36;
        var val_37;
        System.Func<System.Int32, System.Boolean> val_39;
        var val_40;
        UnityEngine.UI.Text val_41;
        var val_42;
        float val_29 = 5.953529E-38f;
        val_29 = 8231584 + val_29;
        if(val_29 == 0)
        {
                mem2[0] = 1;
        }
        
        if(currentQuiz == 0)
        {
                UnityEngine.GameObject val_1 = this.continueButton.gameObject;
            this.continueButton.SetActive(value:  false);
            UnityEngine.GameObject val_2 = this.specialBarParent.gameObject;
            this.specialBarParent.SetActive(value:  false);
            return;
        }
        
        this.myPopup = lcPopup;
        System.Action val_3 = new System.Action(object:  -420815248, method:  new IntPtr(3874051984));
        lcPopup.playNextLevelAction = null;
        if(currentQuiz.successfullyCompletedQuiz != true)
        {
                UnityEngine.Transform val_5 = this.specialBarParent.transform;
            UnityEngine.Transform val_6 = lcPopup.levelFailureGroup.transform;
            this.specialBarParent.SetParent(p:  lcPopup.levelFailureGroup);
            UnityEngine.Transform val_7 = this.specialBarParent.transform;
            UnityEngine.Transform val_8 = lcPopup.levelFailureProgressBar.transform;
            UnityEngine.Vector3 val_9 = position;
            this.specialBarParent.position = new UnityEngine.Vector3();
        }
        
        UnityEngine.GameObject val_10 = this.specialBarParent.gameObject;
        this.specialBarParent.SetActive(value:  true);
        UnityEngine.GameObject val_11 = lcPopup.progressBarParent.gameObject;
        lcPopup.progressBarParent.SetActive(value:  false);
        if(val_29 == 0)
        {
                mem2[0] = 1;
        }
        
        val_29 = mem[TRVSpecialCategoriesEventHandler.EVENT_TRACKING_ID + 20];
        val_29 = TRVSpecialCategoriesEventHandler.EVENT_TRACKING_ID + 20;
        if(val_29 == 0)
        {
                val_29 = val_29;
        }
        
        Dictionary.KeyCollection<TKey, TValue> val_12 = val_29.Keys;
        int val_13 = System.Linq.Enumerable.Max(source:  val_29);
        val_30 = null;
        val_30 = null;
        val_32 = TRVSpecialCategoriesLevelComplete.<>c.<>9__7_0;
        if(val_32 == 0)
        {
                val_32 = null;
            val_32 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  TRVSpecialCategoriesLevelComplete.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3874081680));
            TRVSpecialCategoriesLevelComplete.<>c.<>9__7_0 = val_32;
        }
        
        this.sliderTicks.ForEach(action:  7401472);
        val_33 = val_29;
        if(val_33 == 0)
        {
                val_33 = val_29;
        }
        
        Dictionary.KeyCollection<TKey, TValue> val_15 = val_33.Keys;
        System.Collections.Generic.List<TSource> val_16 = System.Linq.Enumerable.ToList<System.Int32>(source:  val_33);
        val_34 = 4;
        goto label_32;
        label_42:
        if(this >= val_33)
        {
            goto label_34;
        }
        
        if(val_33 <= this)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_35 = mem[TRVSpecialCategoriesEventHandler.EVENT_TRACKING_ID + 20 + 12];
        val_35 = TRVSpecialCategoriesEventHandler.EVENT_TRACKING_ID + 20 + 12;
        if(val_35 <= this)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_35 = mem[TRVSpecialCategoriesEventHandler.EVENT_TRACKING_ID + 20 + 12];
            val_35 = TRVSpecialCategoriesEventHandler.EVENT_TRACKING_ID + 20 + 12;
        }
        
        val_36 = TRVSpecialCategoriesEventHandler.EVENT_TRACKING_ID + 20 + 8 + 16;
        if(val_35 <= this)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_36 = mem[TRVSpecialCategoriesEventHandler.EVENT_TRACKING_ID + 20 + 8 + 16];
            val_36 = TRVSpecialCategoriesEventHandler.EVENT_TRACKING_ID + 20 + 8 + 16;
        }
        
        public static System.Collections.Generic.List<TSource> System.Linq.Enumerable::ToList<System.Int32>(System.Collections.Generic.IEnumerable<TSource> source).__il2cppRuntimeField_10.Init(myValue:  TRVSpecialCategoriesEventHandler.EVENT_TRACKING_ID + 20 + 8 + 16, maxValue:  val_13, myDisplayAmount:  val_29.Item[val_36], lastTickOffset:  0, isComplete:  false);
        val_34 = 5;
        label_32:
        if(1 < (TRVSpecialCategoriesEventHandler.EVENT_TRACKING_ID + 20 + 12))
        {
            goto label_42;
        }
        
        label_34:
        val_37 = null;
        val_37 = null;
        float val_30 = 5.952744E-38f;
        val_30 = 8232984 + val_30;
        val_39 = TRVSpecialCategoriesLevelComplete.<>c.<>9__7_1;
        if(val_39 == 0)
        {
                val_39 = null;
            val_39 = new System.Func<System.Int32, System.Boolean>(object:  TRVSpecialCategoriesLevelComplete.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3874092944));
            TRVSpecialCategoriesLevelComplete.<>c.<>9__7_1 = val_39;
        }
        
        int val_19 = System.Linq.Enumerable.FirstOrDefault<System.Int32>(source:  val_33, predicate:  7720960);
        val_40 = val_19;
        if(val_19 == 0)
        {
                if((TRVSpecialCategoriesEventHandler.EVENT_TRACKING_ID + 20 + 12) == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            var val_31 = TRVSpecialCategoriesEventHandler.EVENT_TRACKING_ID + 20 + 8;
            val_31 = val_31 + (((TRVSpecialCategoriesEventHandler.EVENT_TRACKING_ID + 20 + 12) - 1) << 2);
            val_40 = mem[(TRVSpecialCategoriesEventHandler.EVENT_TRACKING_ID + 20 + 8 + ((TRVSpecialCategoriesEventHandler.EVENT_TRACKING_ID + 20 + 12 - 1)) << 2) + 16];
            val_40 = (TRVSpecialCategoriesEventHandler.EVENT_TRACKING_ID + 20 + 8 + ((TRVSpecialCategoriesEventHandler.EVENT_TRACKING_ID + 20 + 12 - 1)) << 2) + 16;
        }
        
        if(val_30 == 0)
        {
                mem2[0] = 1;
        }
        
        if((TRVSpecialCategoriesEventHandler.EVENT_TRACKING_ID + 20 + 12) == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_32 = TRVSpecialCategoriesEventHandler.EVENT_TRACKING_ID + 20 + 8;
        val_32 = val_32 + (((TRVSpecialCategoriesEventHandler.EVENT_TRACKING_ID + 20 + 12) - 1) << 2);
        float val_33 = (float)(TRVSpecialCategoriesEventHandler.EVENT_TRACKING_ID + 20 + 8 + ((TRVSpecialCategoriesEventHandler.EVENT_TRACKING_ID + 20 + 12 - 1)) << 2) + 16;
        val_33 = ((float)TRVSpecialCategoriesEventHandler.EVENT_TRACKING_ID + 36) / val_33;
        this.fillBar.fillAmount = val_33;
        if(val_30 == 0)
        {
                mem2[0] = 1;
        }
        
        UnityEngine.GameObject val_22 = this.nextLevelButton.gameObject;
        if((TRVSpecialCategoriesEventHandler.EVENT_TRACKING_ID + 36) == val_13)
        {
                this.nextLevelButton.SetActive(value:  false);
            UnityEngine.GameObject val_23 = this.continueButton.gameObject;
            this.continueButton.SetActive(value:  true);
            UnityEngine.Events.UnityAction val_24 = new UnityEngine.Events.UnityAction(object:  -420815248, method:  new IntPtr(3874114448));
            this.continueButton.m_OnClick.AddListener(call:  162246656);
            val_41 = this.descText;
            if(val_30 == 0)
        {
                mem2[0] = 1;
        }
        
            val_42 = "Category {0} Event Complete!";
            string val_25 = System.String.Format(format:  -420847728, arg0:  TRVSpecialCategoriesEventHandler.EVENT_TRACKING_ID + 32);
        }
        else
        {
                this.nextLevelButton.SetActive(value:  true);
            UnityEngine.GameObject val_26 = this.continueButton.gameObject;
            this.continueButton.SetActive(value:  false);
            if(val_30 == 0)
        {
                mem2[0] = 1;
        }
        
            val_41 = this.descText;
            val_42 = "Complete {0} level{1} for the next reward!";
            if((val_40 - (TRVSpecialCategoriesEventHandler.EVENT_TRACKING_ID + 36)) > 1)
        {
                "" = "s";
        }
        
            string val_28 = System.String.Format(format:  -420839408, arg0:  13152256, arg1:  1357768992);
        }
        
        if(val_41 != 0)
        {
                return;
        }
    
    }
    private void OnStartNextLevel()
    {
        var val_2;
        var val_2 = 27392583;
        val_2 = 8234308 + val_2;
        if(val_2 == 0)
        {
                mem2[0] = 1;
        }
        
        val_2 = null;
        val_2 = null;
        TRVMainController.noAnswerSelectedCharacter = 2;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        InitSpecialCategories();
    }
    private void OnContinueClicked()
    {
        this.myPopup.Close(showAd:  false, load:  true);
    }
    public TRVSpecialCategoriesLevelComplete()
    {
    
    }

}
