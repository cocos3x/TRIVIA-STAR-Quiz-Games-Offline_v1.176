using UnityEngine;
public class HintPickerController : MonoSingleton<HintPickerController>
{
    // Fields
    public static bool IsPickingHint;
    private UnityEngine.GameObject HintPickerGroup;
    private UnityEngine.GameObject closeButton;
    private UnityEngine.UI.Text HintPickerText;
    private UnityEngine.GameObject buttonsGroup;
    private UnityEngine.GameObject gameHintPickerButton;
    private UnityEngine.Sprite tileSpotHighlightDisabled;
    private UnityEngine.GameObject WordRegionGroup;
    private UnityEngine.Canvas wordRegionCanvas;
    private UnityEngine.UI.GraphicRaycaster wordRegionRaycaster;
    private LineWord selectedLine;
    private Cell selectedCell;
    private bool isFreeOne;
    public System.Action<bool> OnPickOverlayStateChanged;
    
    // Properties
    public UnityEngine.GameObject getHintPickerGroup { get; }
    public UnityEngine.UI.Text hintPickerText { get; }
    public UnityEngine.GameObject GameHintPickerButton { get; }
    public UnityEngine.Sprite TileSpotHighlightDisabled { get; }
    
    // Methods
    public UnityEngine.GameObject get_getHintPickerGroup()
    {
    
    }
    public UnityEngine.UI.Text get_hintPickerText()
    {
    
    }
    public UnityEngine.GameObject get_GameHintPickerButton()
    {
    
    }
    public UnityEngine.Sprite get_TileSpotHighlightDisabled()
    {
    
    }
    public void OnHintPickButtonClicked(bool free = False)
    {
        bool val_19;
        var val_21;
        var val_22;
        decimal val_1 = CurrencyController.GetBalance();
        GameEcon val_2 = App.getGameEcon;
        var val_19 = 0;
        val_19 = val_19 + 192;
        bool val_3 = System.Decimal.op_GreaterThanOrEqual(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = 308, hi = mem[(0 + 192) + (0)], lo = mem[(0 + 192) + (4)], mid = mem[(0 + 192) + (8)]});
        if(free != false)
        {
                this.isFreeOne = free;
            this.HintPickerGroup.SetActive(value:  true);
            string val_4 = Localization.Localize(key:  -312829424, defaultValue:  -312829584, useSingularKey:  false);
            UnityEngine.GameObject val_5 = this.HintPickerText.gameObject;
            this.HintPickerText.SetActive(value:  true);
            this.closeButton.SetActive(value:  false);
            UnityEngine.Transform val_6 = this.closeButton.transform;
            UnityEngine.Transform val_7 = this.gameHintPickerButton.transform;
            UnityEngine.Vector3 val_8 = position;
            this.closeButton.position = new UnityEngine.Vector3();
            if(this.wordRegionCanvas == 0)
        {
                object val_10 = this.WordRegionGroup.AddComponent<System.Object>();
            this.wordRegionCanvas = this.WordRegionGroup;
            this.WordRegionGroup.overrideSorting = true;
            this.wordRegionCanvas.sortingLayerName = 2130692544;
            this.wordRegionCanvas.sortingOrder = 2;
        }
        
            object val_11 = this.WordRegionGroup.AddComponent<System.Object>();
            this.wordRegionRaycaster = this.WordRegionGroup;
            val_19 = true;
            this.WordRegionGroup.enabled = true;
            val_21 = null;
            val_21 = null;
            HintPickerController.IsPickingHint = val_19;
            if(this.OnPickOverlayStateChanged == 0)
        {
                return;
        }
        
            this.OnPickOverlayStateChanged.Invoke(obj:  true);
            return;
        }
        
        var val_20 = 21176125;
        val_20 = 14449936 + val_20;
        if(val_20 == 0)
        {
                mem2[0] = 1;
        }
        
        val_22 = null;
        val_22 = null;
        PurchaseProxy.currentPurchasePoint = 8;
        if(WGStarterPackController.featureRelavent != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_14 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_15 = ShowUGUIMonolith<System.Object>(showNext:  false);
            twelvegigs.Autopilot.AutopilotManager val_16 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static WGStarterPackController MonoSingleton<WGStarterPackController>::get_Instance().__il2cppRuntimeField_C = 47;
            return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_17 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_18 = ShowUGUIMonolith<System.Object>(showNext:  false);
        Init(outOfCredits:  true, onCloseAction:  0);
    }
    public void HintCellPicked(LineWord line, Cell cell)
    {
        Cell val_3 = this.selectedCell;
        if(val_3 != 0)
        {
                val_3 = this.selectedCell;
        }
        
        this.selectedLine = line;
        this.selectedCell = cell;
        this.buttonsGroup.SetActive(value:  true);
        this.closeButton.SetActive(value:  false);
        string val_2 = Localization.Localize(key:  -312597392, defaultValue:  -312597504, useSingularKey:  false);
        if(this.HintPickerText == 0)
        {
            
        }
    
    }
    public void OnHintPickConfirmButtonClicked()
    {
        WordRegion val_1 = WordRegion.instance;
        if(this.isFreeOne == true)
        {
                this.isFreeOne = 1;
        }
        
        this.OnHintPickCloseButtonClicked();
    }
    public void OnHintPickCancelButtonClicked()
    {
        bool val_1 = UnityEngine.Object.op_Inequality(x:  this.selectedCell, y:  0);
        this.selectedLine = 0;
        this.selectedCell = 0;
        this.buttonsGroup.SetActive(value:  false);
        this.closeButton.SetActive(value:  false);
        string val_2 = Localization.Localize(key:  -312829424, defaultValue:  -312829584, useSingularKey:  false);
        if(this.HintPickerText == 0)
        {
            
        }
    
    }
    public void OnHintPickCloseButtonClicked()
    {
        var val_4;
        this.OnHintPickCancelButtonClicked();
        this.isFreeOne = false;
        this.HintPickerGroup.SetActive(value:  false);
        if(this.wordRegionRaycaster != 0)
        {
                UnityEngine.Object.Destroy(obj:  this.wordRegionRaycaster);
        }
        
        if(this.wordRegionCanvas != 0)
        {
                UnityEngine.Object.Destroy(obj:  this.wordRegionCanvas);
        }
        
        this.wordRegionRaycaster.enabled = false;
        if(this.wordRegionCanvas != 0)
        {
                UnityEngine.Object.Destroy(obj:  this.wordRegionCanvas);
        }
        
        val_4 = null;
        val_4 = null;
        HintPickerController.IsPickingHint = false;
        if(this.OnPickOverlayStateChanged == 0)
        {
                return;
        }
        
        this.OnPickOverlayStateChanged.Invoke(obj:  false);
    }
    public HintPickerController()
    {
    
    }
    private static HintPickerController()
    {
    
    }

}
