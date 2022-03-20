using UnityEngine;
public class WPTHintPickerPopup : MonoSingleton<WPTHintPickerPopup>
{
    // Fields
    private UnityEngine.UI.Text chooseLetterText;
    private UnityEngine.GameObject confirmGroup;
    private UnityEngine.RectTransform uiAnchor;
    private System.Collections.Generic.List<WordPets.WPTLetterTile> selectedTiles;
    private float bgDimAlpha;
    
    // Properties
    public static bool IsShowing { get; }
    
    // Methods
    public static bool get_IsShowing()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(2119322896 == 0)
        {
                return false;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance()) != 0)
        {
                return ShowingWindow<WordHuntPopup>();
        }
        
        return ShowingWindow<WordHuntPopup>();
    }
    private void OnEnable()
    {
        this.PositionUI();
        this.SetupUiElements();
    }
    private void PositionUI()
    {
        float val_8;
        float val_10;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(2124183120 != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            float val_4 = GetBannerAdHeight();
            val_10 = 2124183120;
        }
        else
        {
                val_10 = 0f;
        }
        
        UnityEngine.Vector2 val_5 = anchoredPosition;
        UnityEngine.Vector2 val_7 = anchoredPosition;
        float val_10 = val_8;
        UnityEngine.Vector2 val_9;
        val_10 = val_10 + val_10;
        val_9 = new UnityEngine.Vector2(x:  val_10, y:  val_7.y);
        this.uiAnchor.anchoredPosition = new UnityEngine.Vector2() {x = val_9.x, y = val_9.y};
    }
    private void SetupUiElements()
    {
        var val_19;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_19 = 0;
        goto label_4;
        label_26:
        if((new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>()) <= val_19)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_3 =  - 4;
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        if(0.HasCrate != true)
        {
                UnityEngine.GameObject val_5 = 0.gameObject;
            UnityEngine.Transform val_6 = 0.transform;
            Add(item:  0);
        }
        
         =  + 1;
        goto label_26;
        label_4:
        twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UnityEngine.Color val_8 = new UnityEngine.Color(r:  mem[1152921513316843644], g:  null, b:  null, a:  null);
        System.Nullable<UnityEngine.Color> val_9 = new System.Nullable<UnityEngine.Color>(value:  new UnityEngine.Color() {r = val_8.r, g = val_8.g, b = val_8.b, a = val_8.r});
        SetOptions(bgColor:  new System.Nullable<UnityEngine.Color>() {HasValue = val_9.HasValue}, fadeInDuration:  mem[1152921513316843644], fadeOutDuration:  null);
        twelvegigs.Autopilot.AutopilotManager val_12 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        twelvegigs.Autopilot.AutopilotManager val_13 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        BlockRaycasts = true;
        Interactable = true;
        twelvegigs.Autopilot.AutopilotManager val_14 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        T[] val_15 = ToArray();
        ShowOverlay(contentToOverlay:  80883712);
        twelvegigs.Autopilot.AutopilotManager val_16 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        typeof(UnityEngine.Transform[]).__il2cppRuntimeField_10 = mem[1152921513316843636];
        twelvegigs.Autopilot.AutopilotManager val_17 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UnityEngine.GameObject val_18 = PickerHintButtonGroup;
        UnityEngine.Transform val_19 = transform;
        typeof(UnityEngine.Transform[]).__il2cppRuntimeField_14 = public static AdsUIController MonoSingleton<AdsUIController>::get_Instance();
        ShowOverlay(contentToOverlay:  -2028557104);
    }
    public void DoPowerupPreview(WordPets.WPTLetterTile clickedTile)
    {
        WPTHintPickerPopup val_5;
        WordPets.WPTLetterTile val_6;
        var val_7;
        val_5 = this;
        val_6 = clickedTile;
        if(true > 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_7 = 0;
        UnityEngine.GameObject val_5 = this.chooseLetterText.gameObject;
        this.chooseLetterText.SetActive(value:  false);
        this.confirmGroup.SetActive(value:  true);
    }
    public void OnCancelClicked()
    {
        var val_4;
        UnityEngine.Sprite val_5;
        System.Collections.Generic.List<WordPets.WPTLetterTile> val_6;
        val_4 = 0;
        goto label_1;
        label_14:
        val_5 = mem[35625621];
        val_6 = this.selectedTiles;
        if(val_6 == 0)
        {
                val_6 = 0;
        }
        
        if(val_4 >= val_5)
        {
            goto label_3;
        }
        
        label_15:
        if(0 <= val_4)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_4 = 0;
        val_4 = val_4 + 0;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_5 = mem[public static WordPets.WPTGameUIController MonoSingleton<WordPets.WPTGameUIController>::get_Instance().__il2cppRuntimeField_60 + 16];
        val_5 = public static WordPets.WPTGameUIController MonoSingleton<WordPets.WPTGameUIController>::get_Instance().__il2cppRuntimeField_60 + 16;
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        (0 + 0) + 16.SwapSprite(newSprite:  val_5, newFont:  public static WordPets.WPTGameUIController MonoSingleton<WordPets.WPTGameUIController>::get_Instance().__il2cppRuntimeField_64 + 16, dontAnimate:  false);
        val_4 = 1;
        label_1:
        val_6 = this.selectedTiles;
        if(val_6 == 0)
        {
            goto label_14;
        }
        
        if(val_4 < ((0 + 0) + 16))
        {
            goto label_15;
        }
        
        label_3:
        val_6.Clear();
        UnityEngine.GameObject val_3 = this.chooseLetterText.gameObject;
        this.chooseLetterText.SetActive(value:  true);
        this.confirmGroup.SetActive(value:  false);
        this.confirmGroup.DisableAllTileOverlays();
    }
    public void OnHintButtonClicked()
    {
        this.OnCancelClicked();
        this.CloseWindow();
    }
    private void CloseWindow()
    {
        this.DisableAllTileOverlays();
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Action val_2 = new System.Action(object:  120586848, method:  new IntPtr(120561824));
        CloseOverlay(onClosed:  7454720);
    }
    private void DisableAllTileOverlays()
    {
        var val_2;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_2 = 0;
    }
    public WPTHintPickerPopup()
    {
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.selectedTiles = null;
        this.bgDimAlpha = 0.5f;
    }
    private void <CloseWindow>b__13_0()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        this.SetActive(value:  false);
    }

}
