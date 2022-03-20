using UnityEngine;
public class TRVCategorySelection : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Button closeButton;
    private UnityEngine.UI.Button rerollButton;
    private UnityEngine.UI.Button storeButton;
    private UnityEngine.UI.Button gemStoreButton;
    private UnityEngine.UI.Button lastCategoryButton;
    private UnityEngine.UI.Button earlyUnlockCategoryButton;
    private UnityEngine.UI.Text levelText;
    private UnityEngine.UI.Text quizLengthText;
    private UnityEngine.UI.Text rerollCostText;
    private UnityEngine.UI.Text headerText;
    private System.Collections.Generic.List<TRVCategoryButton> catButtons;
    private UnityEngine.GameObject rerollCostParent;
    private UnityEngine.GameObject revealParent;
    private UnityEngine.GameObject lastCategoryLockedGroup;
    private UnityEngine.GameObject lastCategoryUnlockedGroup;
    private UnityEngine.GameObject newCategoryGroup;
    private UnityEngine.GameObject nextCategoryGroup;
    private UnityEngine.UI.Text newCategoryText;
    private UnityEngine.UI.Text nextCategoryText;
    private UnityEngine.UI.Text lastCategoryText;
    private UnityEngine.UI.Text lastCategoryCostText;
    private UnityEngine.UI.Button newCategoryButton;
    private UnityEngine.UI.Image crazyCategoryImage;
    private UnityEngine.UI.Image lastCategoryImage;
    private UnityEngine.UI.Image recentCategoryImage;
    private TRVEventButtonLobby eventButton;
    private UnityEngine.RectTransform nextCatTransform;
    private System.Action onStartAction;
    private bool rerollActive;
    private string forcedPlayNowCategory;
    private System.Collections.Generic.List<TRVCategorySelectionInfo> prevInitCategories;
    private System.Collections.Generic.List<TRVCategorySelectionInfo> currentCategories;
    
    // Methods
    public static string ToUpperCategory(string category)
    {
        string val_7 = category;
        System.Text.RegularExpressions.Match val_1 = System.Text.RegularExpressions.Regex.Match(input:  val_7 = category, pattern:  -553588512);
        string val_2 = val_7.Value;
        if((System.String.IsNullOrEmpty(value:  val_7)) != true)
        {
                string val_4 = val_7.Replace(oldValue:  val_7, newValue:  -553588416);
            val_7 = val_7;
        }
        
        string val_5 = val_7.ToUpper();
        if((System.String.IsNullOrEmpty(value:  val_7)) != false)
        {
                return;
        }
        
        if(val_7 != null)
        {
                return val_7.Replace(oldValue:  -553588416, newValue:  val_7);
        }
        
        return val_7.Replace(oldValue:  -553588416, newValue:  val_7);
    }
    public void Init(System.Collections.Generic.List<TRVCategorySelectionInfo> selectedCategorys, bool animate, bool canReroll)
    {
        var val_62;
        var val_63;
        var val_64;
        System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Int32>, System.Boolean> val_66;
        var val_67;
        System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Int32>, System.Boolean> val_69;
        var val_70;
        System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Int32>, System.Boolean> val_72;
        var val_73;
        System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Int32>, System.Int32> val_75;
        object val_1 = new System.Object();
        if(val_1 != 0)
        {
                typeof(TRVCategorySelection.<>c__DisplayClass33_0).__il2cppRuntimeField_8 = this;
        }
        else
        {
                mem[8] = this;
        }
        
        typeof(TRVCategorySelection.<>c__DisplayClass33_0).__il2cppRuntimeField_C = animate;
        this.eventButton.UpdateDisplay();
        this.closeButton.m_OnClick.RemoveAllListeners();
        this.rerollButton.m_OnClick.RemoveAllListeners();
        this.storeButton.m_OnClick.RemoveAllListeners();
        UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  -553286096, method:  new IntPtr(3741536016));
        this.storeButton.m_OnClick.AddListener(call:  162246656);
        this.gemStoreButton.m_OnClick.RemoveAllListeners();
        UnityEngine.Events.UnityAction val_3 = new UnityEngine.Events.UnityAction(object:  356282368, method:  new IntPtr(3741553424));
        this.gemStoreButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_4 = new UnityEngine.Events.UnityAction(object:  -553286096, method:  new IntPtr(3741562640));
        this.closeButton.m_OnClick.AddListener(call:  162246656);
        this.prevInitCategories = selectedCategorys;
        System.Collections.Generic.List<ZooTile> val_5 = new System.Collections.Generic.List<ZooTile>(collection:  selectedCategorys);
        this.currentCategories = null;
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        string val_8 = System.String.Format(format:  -553398512, arg0:  13152256);
        string val_9 = Localization.Localize(key:  -1672741904, defaultValue:  2127161280, useSingularKey:  false);
        Player val_10 = App.Player;
        string val_11 = System.String.Format(format:  -1672741904, arg0:  13152256);
        WordForest.WFOGameEcon val_12 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        string val_13 = ToString();
        GameBehavior val_14 = App.getBehavior;
        if(0 < TRVMainController.getRerollFTUXLEVEL)
        {
                string val_16 = Localization.Localize(key:  -1510799952, defaultValue:  -1510800032, useSingularKey:  false);
            val_62 = "free_upper";
            val_63 = 1152921504892043264;
        }
        else
        {
                val_63 = 1152921504892043264;
            WordForest.WFOGameEcon val_17 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
            string val_18 = ToString();
            val_62 = 1152921512476916180;
        }
        
        UnityEngine.GameObject val_19 = this.crazyCategoryImage.gameObject;
        this.crazyCategoryImage.SetActive(value:  false);
        UnityEngine.GameObject val_20 = this.rerollCostParent.gameObject;
        this.rerollCostParent.SetActive(value:  true);
        UnityEngine.GameObject val_21 = this.revealParent.gameObject;
        this.revealParent.SetActive(value:  false);
        this.rerollButton.interactable = true;
        this.rerollActive = canReroll;
        System.Action val_22 = new System.Action(object:  356282368, method:  new IntPtr(3741597552));
        this.onStartAction = null;
        Player val_23 = App.Player;
        if(0 != 1)
        {
            goto label_48;
        }
        
        UnityEngine.GameObject val_24 = this.newCategoryGroup.gameObject;
        this.newCategoryGroup.SetActive(value:  false);
        UnityEngine.GameObject val_25 = this.nextCategoryGroup.gameObject;
        this.nextCategoryGroup.SetActive(value:  false);
        UnityEngine.GameObject val_26 = this.nextCatTransform.gameObject;
        this.nextCatTransform.SetActive(value:  false);
        goto label_118;
        label_48:
        if(this.canDisplayPlayCategoryNowButton() == false)
        {
            goto label_56;
        }
        
        object val_28 = new System.Object();
        typeof(TRVCategorySelection.<>c__DisplayClass33_2).__il2cppRuntimeField_C = val_1;
        UnityEngine.GameObject val_29 = this.newCategoryGroup.gameObject;
        this.newCategoryGroup.SetActive(value:  true);
        UnityEngine.GameObject val_30 = this.nextCategoryGroup.gameObject;
        this.nextCategoryGroup.SetActive(value:  false);
        if((System.String.IsNullOrEmpty(value:  this.forcedPlayNowCategory)) == false)
        {
            goto label_62;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_32 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Collections.Generic.Dictionary<System.String, System.Int32> val_33 = CategoryUnlockLevels;
        val_64 = null;
        val_64 = null;
        val_66 = TRVCategorySelection.<>c.<>9__33_4;
        if(val_66 == 0)
        {
                val_66 = null;
            val_66 = new System.Func<System.Collections.Generic.KeyValuePair<TRVPickerGameButton, System.Int32>, System.Boolean>(object:  TRVCategorySelection.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3741623152));
            TRVCategorySelection.<>c.<>9__33_4 = val_66;
        }
        
        System.Collections.Generic.KeyValuePair<System.Object, System.Int32> val_35 = System.Linq.Enumerable.First<System.Collections.Generic.KeyValuePair<System.Object, System.Int32>>(source:  -553298144, predicate:  -1484293744);
        goto label_71;
        label_56:
        UnityEngine.GameObject val_36 = this.newCategoryGroup.gameObject;
        this.newCategoryGroup.SetActive(value:  false);
        UnityEngine.GameObject val_37 = this.nextCategoryGroup.gameObject;
        this.nextCategoryGroup.SetActive(value:  true);
        twelvegigs.Autopilot.AutopilotManager val_38 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Collections.Generic.Dictionary<System.String, System.Int32> val_39 = CategoryUnlockLevels;
        val_67 = null;
        val_67 = null;
        val_69 = TRVCategorySelection.<>c.<>9__33_2;
        if(val_69 == 0)
        {
                val_69 = null;
            val_69 = new System.Func<System.Collections.Generic.KeyValuePair<TRVPickerGameButton, System.Int32>, System.Boolean>(object:  TRVCategorySelection.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3741633392));
            TRVCategorySelection.<>c.<>9__33_2 = val_69;
        }
        
        if((System.Linq.Enumerable.Any<System.Collections.Generic.KeyValuePair<System.String, System.Int32>>(source:  -1484293744, predicate:  7720960)) != false)
        {
                object val_42 = new System.Object();
            twelvegigs.Autopilot.AutopilotManager val_43 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Collections.Generic.Dictionary<System.String, System.Int32> val_44 = CategoryUnlockLevels;
            val_70 = null;
            val_70 = null;
            val_72 = TRVCategorySelection.<>c.<>9__33_6;
            if(val_72 == 0)
        {
                val_72 = null;
            val_72 = new System.Func<System.Collections.Generic.KeyValuePair<TRVPickerGameButton, System.Int32>, System.Boolean>(object:  TRVCategorySelection.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3741635440));
            TRVCategorySelection.<>c.<>9__33_6 = val_72;
        }
        
            System.Collections.Generic.IEnumerable<TSource> val_46 = System.Linq.Enumerable.Where<System.Collections.Generic.KeyValuePair<System.Object, System.Int32>>(source:  -1484293744, predicate:  7720960);
            val_73 = null;
            val_73 = null;
            val_75 = TRVCategorySelection.<>c.<>9__33_7;
            if(val_75 == 0)
        {
                val_75 = null;
            val_75 = new System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Int32>, System.Int32>(object:  TRVCategorySelection.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3741637488));
            TRVCategorySelection.<>c.<>9__33_7 = val_75;
        }
        
            System.Collections.Generic.KeyValuePair<System.String, System.Int32> val_48 = MoreLinq.MinBy<System.Collections.Generic.KeyValuePair<System.String, System.Int32>, System.Int32>(source:  -553298144, selector:  -1484293744);
            typeof(TRVCategorySelection.<>c__DisplayClass33_3).__il2cppRuntimeField_8 = GetQuizLength();
            string val_49 = Localization.Localize(key:  -553323520, defaultValue:  -553323664, useSingularKey:  false);
            string val_50 = TRVCategorySelection.ToUpperCategory(category:  typeof(TRVCategorySelection.<>c__DisplayClass33_3).__il2cppRuntimeField_8);
            twelvegigs.Autopilot.AutopilotManager val_51 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Collections.Generic.Dictionary<System.String, System.Int32> val_52 = CategoryUnlockLevels;
            int val_53 = Item[typeof(TRVCategorySelection.<>c__DisplayClass33_3).__il2cppRuntimeField_8];
            string val_54 = System.String.Format(format:  -553323520, arg0:  typeof(TRVCategorySelection.<>c__DisplayClass33_3).__il2cppRuntimeField_8, arg1:  13152256);
            UnityEngine.Transform val_55 = this.earlyUnlockCategoryButton.transform;
            UnityEngine.Transform val_56 = this.earlyUnlockCategoryButton.parent;
            UnityEngine.GameObject val_57 = this.earlyUnlockCategoryButton.gameObject;
            Player val_58 = App.Player;
            WordForest.WFOGameEcon val_59 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
            this.earlyUnlockCategoryButton.SetActive(value:  GameEcon.IsEnabledAndLevelMet(playerLevel:  0, knobValue:  mem[1152921512476916252]));
            UnityEngine.Events.UnityAction val_61 = new UnityEngine.Events.UnityAction(object:  356442112, method:  new IntPtr(3741656176));
            this.earlyUnlockCategoryButton.m_OnClick.AddListener(call:  162246656);
        }
    
    }
    private bool canDisplayPlayCategoryNowButton()
    {
        string val_9;
        var val_14;
        var val_15;
        System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Int32>, System.Boolean> val_17;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Collections.Generic.Dictionary<System.String, System.Int32> val_2 = CategoryUnlockLevels;
        Player val_3 = App.Player;
        val_14 = 0;
        if((ContainsValue(value:  0)) == false)
        {
                return (bool)val_14;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Collections.Generic.Dictionary<System.String, System.Int32> val_6 = CategoryUnlockLevels;
        val_15 = null;
        val_15 = null;
        val_17 = TRVCategorySelection.<>c.<>9__34_0;
        if(val_17 == 0)
        {
                val_17 = null;
            val_17 = new System.Func<System.Collections.Generic.KeyValuePair<TRVPickerGameButton, System.Int32>, System.Boolean>(object:  TRVCategorySelection.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3741917680));
            TRVCategorySelection.<>c.<>9__34_0 = val_17;
        }
        
        System.Collections.Generic.KeyValuePair<System.Object, System.Int32> val_8 = System.Linq.Enumerable.FirstOrDefault<System.Collections.Generic.KeyValuePair<System.Object, System.Int32>>(source:  -553036640, predicate:  -1484293744);
        twelvegigs.Autopilot.AutopilotManager val_10 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((IsValidSubCategory(cat:  val_9)) == false)
        {
                return (bool)val_14;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_12 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_14 = (public static TRVDataParser MonoSingleton<TRVDataParser>::get_Instance().__il2cppRuntimeField_28 + 24.Contains(item:  val_9)) ^ 1;
        return (bool)val_14;
    }
    private void OnEnable()
    {
        if(this.onStartAction != 0)
        {
                this.onStartAction.Invoke();
        }
        
        this.onStartAction = 0;
    }
    private void Start()
    {
        System.Action val_1 = new System.Action(object:  -552792400, method:  new IntPtr(3741562640));
        DeviceKeypressManager.AddBackAction(backAction:  7454720);
    }
    private void OnDisable()
    {
        System.Action val_1 = new System.Action(object:  -552680400, method:  new IntPtr(3741562640));
        DeviceKeypressManager.RemoveBackAction(backAction:  7454720);
    }
    private System.Collections.IEnumerator animateCategorySelection(TRVCategorySelectionInfo selectedCat, System.Collections.Generic.List<string> incCats, TRVCategoryButton thisCatButton)
    {
        typeof(TRVCategorySelection.<animateCategorySelection>d__38).__il2cppRuntimeField_8 = 0;
        if(new System.Object() != 0)
        {
                typeof(TRVCategorySelection.<animateCategorySelection>d__38).__il2cppRuntimeField_10 = this;
            typeof(TRVCategorySelection.<animateCategorySelection>d__38).__il2cppRuntimeField_14 = selectedCat;
            typeof(TRVCategorySelection.<animateCategorySelection>d__38).__il2cppRuntimeField_1C = incCats;
        }
        else
        {
                mem[16] = this;
            mem[20] = selectedCat;
            mem[28] = incCats;
        }
        
        typeof(TRVCategorySelection.<animateCategorySelection>d__38).__il2cppRuntimeField_18 = thisCatButton;
    }
    private void PlayLastCategoryPlayed(TRVCategorySelectionInfo cat)
    {
        this.PlayCategory(cat:  cat);
    }
    private void PlayEarlyUnlockCategory(TRVCategorySelectionInfo cat)
    {
        this.PlayCategory(cat:  cat);
    }
    private void PlayCategoryFromAnimation(TRVCategorySelectionInfo cat)
    {
        this.PlayCategory(cat:  cat);
    }
    private void PlayCategoryFromInit(TRVCategorySelectionInfo cat)
    {
        this.PlayCategory(cat:  cat);
    }
    private void PlayCategory(TRVCategorySelectionInfo cat)
    {
        var val_7;
        if((TRVSpecialCategoriesManager.IsSpecialCategory(subcategory:  cat.categoryName)) != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            OnCategorySelected(selectionInfo:  cat);
            UnityEngine.GameObject val_3 = this.gameObject;
            SLCWindow.CloseWindow(window:  -551938560, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
            return;
        }
        
        CPlayerPrefs.SetString(key:  -551962768, val:  cat.categoryName);
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_C.PlayGameSpecificSound(id:  -551962672, clipIndex:  0);
        UnityEngine.GameObject val_5 = this.gameObject;
        SLCWindow.CloseWindow(window:  -551938560, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        var val_7 = 23387043;
        val_7 = 12239848 + val_7;
        if(val_7 == 0)
        {
                mem2[0] = 1;
        }
        
        val_7 = null;
        val_7 = null;
        TRVMainController.noAnswerSelectedCharacter = 0;
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        OnCategorySelected(selectedSubCat:  cat, selectedPrimaryCat:  1098586544);
        CPlayerPrefs.Save();
    }
    private void SetupLastCategoryButton(bool rolling)
    {
        var val_17;
        var val_18;
        var val_19;
        UnityEngine.UI.Button val_20;
        bool val_21;
        var val_22;
        val_17 = rolling;
        Player val_1 = App.Player;
        val_18 = 0;
        if(val_18 == 1)
        {
            goto label_13;
        }
        
        string val_2 = CPlayerPrefs.GetString(key:  -551962768, defaultValue:  1098586544);
        if((System.String.IsNullOrEmpty(value:  -551962768)) == true)
        {
            goto label_13;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_18 = public static TRVDataParser MonoSingleton<TRVDataParser>::get_Instance();
        string val_5 = CPlayerPrefs.GetString(key:  -551962768, defaultValue:  1098586544);
        if((IsValidSubCategory(cat:  -551962768)) == false)
        {
            goto label_13;
        }
        
        this.lastCategoryLockedGroup.SetActive(value:  false);
        this.lastCategoryUnlockedGroup.SetActive(value:  true);
        this.lastCategoryButton.m_OnClick.RemoveAllListeners();
        UnityEngine.Events.UnityAction val_7 = new UnityEngine.Events.UnityAction(object:  -551748736, method:  new IntPtr(3743153600));
        this.lastCategoryButton.m_OnClick.AddListener(call:  162246656);
        twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        string val_9 = CPlayerPrefs.GetString(key:  -551962768);
        UnityEngine.Sprite val_10 = GetCategoryIcon(category:  -551962768);
        this.lastCategoryImage.sprite = -612557856;
        string val_11 = CPlayerPrefs.GetString(key:  -551962768);
        string val_12 = TRVCategorySelection.ToUpperCategory(category:  -551962768);
        val_19 = "lstCatPlayed";
        val_20 = this.lastCategoryButton;
        if(val_17 == false)
        {
            goto label_28;
        }
        
        val_21 = 0;
        goto label_29;
        label_13:
        this.lastCategoryLockedGroup.SetActive(value:  true);
        this.lastCategoryUnlockedGroup.SetActive(value:  false);
        this.lastCategoryButton.interactable = false;
        UnityEngine.GameObject val_13 = this.lastCategoryButton.gameObject;
        this.lastCategoryButton.SetActive(value:  false);
        return;
        label_28:
        val_20.interactable = true;
        val_17 = 1152921504963342336;
        val_22 = null;
        val_22 = null;
        val_20 = TRVCategorySelection.<>c.<>9__44_0;
        if(val_20 == 0)
        {
                val_20 = null;
            val_20 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  TRVCategorySelection.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3743191488));
            TRVCategorySelection.<>c.<>9__44_0 = val_20;
        }
        
        val_21 = (System.Linq.Enumerable.Any<MessageTypeSubscribers>(source:  this.currentCategories, predicate:  7720960)) ^ 1;
        label_29:
        this.lastCategoryButton.interactable = val_21;
    }
    private void PressLastCategoryButton()
    {
        TRVCategorySelection val_18;
        var val_19;
        var val_20;
        System.Func<TRVCategorySelectionInfo, System.Boolean> val_22;
        val_18 = this;
        Player val_1 = App.Player;
        if(0 == 1)
        {
                return;
        }
        
        val_19 = 1152921504882458624;
        string val_2 = CPlayerPrefs.GetString(key:  -551962768, defaultValue:  1098586544);
        if((System.String.IsNullOrEmpty(value:  -551962768)) == true)
        {
                return;
        }
        
        val_20 = null;
        val_20 = null;
        val_22 = TRVCategorySelection.<>c.<>9__45_0;
        if(val_22 == 0)
        {
                val_22 = null;
            val_22 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  TRVCategorySelection.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3743372096));
            val_19 = val_19;
            val_18 = val_18;
            TRVCategorySelection.<>c.<>9__45_0 = val_22;
        }
        
        if((System.Linq.Enumerable.Any<MessageTypeSubscribers>(source:  this.currentCategories, predicate:  7720960)) == true)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        string val_7 = CPlayerPrefs.GetString(key:  -551962768, defaultValue:  1098586544);
        val_22 = "lstCatPlayed";
        if((IsValidSubCategory(cat:  -551962768)) == false)
        {
                return;
        }
        
        Player val_9 = App.Player;
        WordForest.WFOGameEcon val_10 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        if(0 < mem[1152921512476916212])
        {
                this.OpenGemStore(tpp:  99);
            return;
        }
        
        Player val_11 = App.Player;
        WordForest.WFOGameEcon val_12 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        0.AddGems(amount:  0 - mem[1152921512476916212], source:  -551594176, subsource:  null);
        NotificationCenter val_14 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  -551570080, aName:  -1618809792);
        TRVCategorySelectionInfo val_15 = new TRVCategorySelectionInfo();
        string val_16 = CPlayerPrefs.GetString(key:  -551962768);
        typeof(TRVCategorySelectionInfo).__il2cppRuntimeField_8 = "lstCatPlayed";
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_17 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        typeof(TRVCategorySelectionInfo).__il2cppRuntimeField_C = null;
        this.PlayCategory(cat:  356761600);
    }
    public void OnReroll()
    {
        System.Action val_1 = new System.Action(object:  -551451936, method:  new IntPtr(3743489312));
        System.Action val_2 = new System.Action(object:  -551451936, method:  new IntPtr(3743490336));
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        RerollCategory(onRerollSuccess:  7454720, onRerollFailed:  7454720);
    }
    private System.Collections.IEnumerator CheckCrazyCategories()
    {
        object val_1 = new System.Object();
        typeof(TRVCategorySelection.<CheckCrazyCategories>d__47).__il2cppRuntimeField_8 = 0;
        typeof(TRVCategorySelection.<CheckCrazyCategories>d__47).__il2cppRuntimeField_10 = this;
    }
    private void OnRevealComplete()
    {
        var val_3;
        List.Enumerator<T> val_1 = GetEnumerator();
        label_9:
        if(MoveNext() == false)
        {
            goto label_2;
        }
        
        object val_4 = val_3.GetComponent<System.Object>();
        val_3.interactable = true;
        UnityEngine.GameObject val_5 = this.rerollCostParent.gameObject;
        this.rerollCostParent.SetActive(value:  true);
        UnityEngine.GameObject val_6 = this.revealParent.gameObject;
        this.revealParent.SetActive(value:  false);
        goto label_9;
        label_2:
        Dispose();
        string val_7 = Localization.Localize(key:  -551236448, defaultValue:  -551236576, useSingularKey:  false);
        if(this.rerollActive == true)
        {
                this.rerollActive = 1;
        }
        
        this.rerollButton.interactable = true;
        this.SetupLastCategoryButton(rolling:  false);
    }
    public void UpdateCategoryUnlockButton(string category)
    {
        object val_1 = new System.Object();
        typeof(TRVCategorySelection.<>c__DisplayClass49_0).__il2cppRuntimeField_8 = this;
        this.forcedPlayNowCategory = category;
        UnityEngine.Vector2 val_2 = sizeDelta;
        UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  val_2.x, y:  val_2.y);
        this.nextCatTransform.sizeDelta = new UnityEngine.Vector2() {x = val_4.x, y = val_4.y};
        UnityEngine.GameObject val_5 = this.newCategoryGroup.gameObject;
        this.newCategoryGroup.SetActive(value:  true);
        UnityEngine.GameObject val_6 = this.nextCategoryGroup.gameObject;
        this.nextCategoryGroup.SetActive(value:  false);
        string val_7 = TRVCategorySelection.ToUpperCategory(category:  category);
        twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UnityEngine.Sprite val_9 = GetCategoryIcon(category:  category);
        this.recentCategoryImage.sprite = -612557856;
        this.newCategoryButton.m_OnClick.RemoveAllListeners();
        typeof(TRVCategorySelection.<>c__DisplayClass49_0).__il2cppRuntimeField_C = new TRVCategorySelectionInfo();
        typeof(TRVCategorySelectionInfo).__il2cppRuntimeField_8 = category;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_11 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        typeof(TRVCategorySelectionInfo).__il2cppRuntimeField_C = null;
        this.newCategoryButton.m_OnClick.RemoveAllListeners();
        UnityEngine.Events.UnityAction val_12 = new UnityEngine.Events.UnityAction(object:  356708352, method:  new IntPtr(3743920784));
        this.newCategoryButton.m_OnClick.AddListener(call:  162246656);
    }
    private bool CanReroll()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        return true;
    }
    private void OpenStore()
    {
        var val_5;
        var val_6;
        System.Action val_8;
        var val_5 = 23381341;
        val_5 = 12244720 + val_5;
        if(val_5 == 0)
        {
                mem2[0] = 1;
        }
        
        val_5 = null;
        val_5 = null;
        PurchaseProxy.currentPurchasePoint = 86;
        GameBehavior val_1 = App.getBehavior;
        val_6 = null;
        val_6 = null;
        val_8 = TRVCategorySelection.<>c.<>9__51_0;
        if(val_8 == 0)
        {
                val_8 = null;
            val_8 = new System.Action(object:  TRVCategorySelection.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3744194960));
            TRVCategorySelection.<>c.<>9__51_0 = val_8;
        }
        
        0.Init(outOfCredits:  false, onCloseAction:  7454720);
        UnityEngine.GameObject val_4 = this.gameObject;
        SLCWindow.CloseWindow(window:  -550747312, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void OpenGemStore(TrackerPurchasePoints tpp = 86)
    {
        var val_6;
        var val_7;
        System.Action val_9;
        var val_6 = 23383245;
        val_6 = 12242816 + val_6;
        if(val_6 == 0)
        {
                mem2[0] = 1;
        }
        
        val_6 = null;
        val_6 = null;
        PurchaseProxy.currentPurchasePoint = tpp;
        string val_1 = Localization.Localize(key:  -1687442544, defaultValue:  -1687442624, useSingularKey:  false);
        GameStoreManager.StoreCategoryFocus = "gems_upper";
        GameBehavior val_2 = App.getBehavior;
        val_7 = null;
        val_7 = null;
        val_9 = TRVCategorySelection.<>c.<>9__52_0;
        if(val_9 == 0)
        {
                val_9 = null;
            val_9 = new System.Action(object:  TRVCategorySelection.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3744312080));
            TRVCategorySelection.<>c.<>9__52_0 = val_9;
        }
        
        0.Init(outOfCredits:  false, onCloseAction:  7454720);
        UnityEngine.GameObject val_5 = this.gameObject;
        SLCWindow.CloseWindow(window:  -550630192, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    public void OnHomeButtonPressed()
    {
        var val_5;
        System.Action val_7;
        GameBehavior val_1 = App.getBehavior;
        val_5 = null;
        val_5 = null;
        val_7 = TRVCategorySelection.<>c.<>9__53_0;
        if(val_7 == 0)
        {
                val_7 = null;
            val_7 = new System.Action(object:  TRVCategorySelection.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3744429200));
            TRVCategorySelection.<>c.<>9__53_0 = val_7;
        }
        
        mem[96] = val_7;
        UnityEngine.GameObject val_4 = this.gameObject;
        SLCWindow.CloseWindow(window:  -550513072, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    public void OnCloseButtonPressed()
    {
        GameBehavior val_1 = App.getBehavior;
        UnityEngine.GameObject val_2 = this.gameObject;
        SLCWindow.CloseWindow(window:  -550401072, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void Close()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -550289072, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    public TRVCategorySelection()
    {
    
    }
    private void <OnReroll>b__46_0()
    {
        var val_5;
        System.Func<TRVCategorySelectionInfo, System.String> val_7;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_5 = null;
        val_5 = null;
        val_7 = TRVCategorySelection.<>c.<>9__46_2;
        if(val_7 == 0)
        {
                val_7 = null;
            val_7 = new System.Func<ZooTile, System.String>(object:  TRVCategorySelection.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3744882320));
            TRVCategorySelection.<>c.<>9__46_2 = val_7;
        }
        
        System.Collections.Generic.IEnumerable<TResult> val_3 = System.Linq.Enumerable.Select<System.Object, System.Object>(source:  this.prevInitCategories, selector:  7720960);
        System.Collections.Generic.List<TSource> val_4 = System.Linq.Enumerable.ToList<System.Object>(source:  this.prevInitCategories);
        Init(currentlySelectedCategores:  this.prevInitCategories, fromReroll:  true);
    }
    private void <OnReroll>b__46_1()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -549941808, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }

}
