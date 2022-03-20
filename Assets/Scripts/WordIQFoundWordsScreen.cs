using UnityEngine;
public class WordIQFoundWordsScreen : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Text nLetterWords;
    private UnityEngine.UI.Text wordsFound;
    private UnityEngine.UI.Text[] gridTexts;
    private UGUIPageDisplay pageDisplay;
    private System.Collections.Generic.List<string> foundWords;
    private bool hasInitialized;
    
    // Methods
    private void OnPageChanged(int currentPageIndex)
    {
        UnityEngine.UI.Text[] val_6;
        var val_7;
        var val_8;
        UnityEngine.Events.UnityAction val_9;
        val_6 = this.gridTexts;
        val_7 = 4;
        val_8 = true * currentPageIndex;
        goto label_2;
        label_25:
        object val_1 = new System.Object();
        typeof(WordIQFoundWordsScreen.<>c__DisplayClass6_0).__il2cppRuntimeField_C = this;
        UnityEngine.UI.Text val_6 = this.gridTexts[0];
        UnityEngine.GameObject val_2 = val_6.gameObject;
        if(val_8 < this.foundWords)
        {
                0 = 1;
        }
        
        val_6.SetActive(value:  true);
        val_6 = this.foundWords;
        if(val_8 < val_6)
        {
                UnityEngine.UI.Text val_7 = this.gridTexts[0];
            if(val_6 <= val_8)
        {
                var val_8 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_8 = val_8 + (val_8 << 2);
            UnityEngine.UI.Text val_9 = this.gridTexts[0];
            twelvegigs.Autopilot.WUTAutopilotGameplay val_3 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<twelvegigs.Autopilot.WUTAutopilotGameplay>(child:  val_9);
            (0 + ((true * currentPageIndex)) << 2) + 16.RemoveAllListeners();
            typeof(WordIQFoundWordsScreen.<>c__DisplayClass6_0).__il2cppRuntimeField_8 = this.gridTexts[0];
            val_9 = null;
            val_9 = new UnityEngine.Events.UnityAction(object:  337805312, method:  new IntPtr(3362488000));
            val_9.AddListener(call:  162246656);
        }
        
        val_7 = 5;
        val_8 = val_8 + 1;
        label_2:
        if((val_7 - 4) < val_9)
        {
            goto label_25;
        }
    
    }
    public void Awake()
    {
        this.Init();
    }
    public void ShowFoundWordsList(int numLetters)
    {
        this.Init();
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Collections.Generic.List<System.String> val_2 = GetFoundWords(numLetters:  numLetters);
        this.foundWords = public static WordIQManager MonoSingleton<WordIQManager>::get_Instance();
        Sort();
        string val_3 = Localization.Localize(key:  -933627584, defaultValue:  -931963456, useSingularKey:  false);
        string val_4 = numLetters.ToString();
        string val_5 = System.String.Format(format:  -933627584, arg0:  -931894028);
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        string val_8 = GetPossibleWordsCount(numLetters:  numLetters).ToString();
        string val_9 = System.String.Format(format:  -1222347616, arg0:  13152256, arg1:  -931894032);
        float val_12 = (float)S0;
        val_12 = (float)this.foundWords / val_12;
        this.pageDisplay.numPages = UnityEngine.Mathf.CeilToInt(f:  val_12);
        this.pageDisplay.SetToPage(index:  0, force:  true);
        UnityEngine.GameObject val_11 = this.gameObject;
        this.SetActive(value:  true);
    }
    private void Init()
    {
        System.Action<System.Int32> val_3;
        if(this.hasInitialized != false)
        {
                return;
        }
        
        this.pageDisplay.maxPageDots = 0;
        System.Action<System.Int32> val_1 = new System.Action<System.Int32>(object:  -931695248, method:  new IntPtr(3363247024));
        System.Delegate val_2 = System.Delegate.Combine(a:  this.pageDisplay.PageIndexChanged, b:  7401472);
        val_3 = this.pageDisplay.PageIndexChanged;
        if(val_3 != 0)
        {
                if(null == null)
        {
            goto label_6;
        }
        
        }
        
        val_3 = 0;
        label_6:
        this.pageDisplay.PageIndexChanged = val_3;
        this.hasInitialized = true;
    }
    private void OnClick_Word(string word)
    {
        WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        if((-2078675824) == 0)
        {
                return;
        }
        
        WordPets.WPTDataParser val_3 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        displayDefinition(word:  word, flyout:  true);
    }
    public WordIQFoundWordsScreen()
    {
    
    }

}
