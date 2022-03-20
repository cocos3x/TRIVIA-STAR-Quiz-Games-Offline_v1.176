using UnityEngine;
public class WordFillFTUXManager : MonoSingleton<WordFillFTUXManager>
{
    // Fields
    private UnityEngine.UI.Text FTUXText;
    private UnityEngine.GameObject FTUXHand;
    private bool <ftux>k__BackingField;
    private float x1;
    private float x2;
    private float x3;
    private float y1;
    private float y2;
    private float y3;
    private float curveTime;
    private const float curveEnd = 1.3;
    private const float curveFade = 0.4;
    private bool animatingCurve;
    private string[] ftuxMessages;
    private int[] ftuxLetterPos;
    private int ftuxPhase;
    
    // Properties
    public bool ftux { get; set; }
    
    // Methods
    public bool get_ftux()
    {
        return (bool)this.<ftux>k__BackingField;
    }
    protected void set_ftux(bool value)
    {
        this.<ftux>k__BackingField = value;
    }
    private void Update()
    {
        float val_16;
        float val_17;
        var val_18;
        var val_19;
        if((this.<ftux>k__BackingField) == false)
        {
                this.<ftux>k__BackingField = this;
            this.EndFTUX();
        }
        
        if(this.animatingCurve == false)
        {
                return;
        }
        
        float val_14 = this.curveTime;
        float val_1 = UnityEngine.Time.deltaTime;
        uint val_15 = 0;
        val_14 = val_14 + val_15;
        this.curveTime = val_14;
        val_15 = val_14 / 1.3f;
        float val_3 = UnityEngine.Mathf.Min(a:  UnityEngine.Mathf.Max(a:  val_15, b:  null), b:  null);
        float val_16 = val_15;
        float val_4 = 1f - val_16;
        float val_5 = val_4 + val_4;
        val_4 = val_4 * val_4;
        val_5 = val_16 * val_5;
        val_16 = val_16 * val_16;
        float val_6 = val_5 * this.y2;
        float val_7 = this.x2 * val_5;
        UnityEngine.Transform val_8 = this.FTUXHand.transform;
        UnityEngine.Vector3 val_9 = new UnityEngine.Vector3(x:  val_16, y:  this.y3);
        this.FTUXHand.position = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
        if(this.FTUXHand < 0)
        {
                val_17 = 1f;
            val_5 = this.curveTime + this.curveTime;
            val_18 = val_17 - this.curveTime;
            val_19 = val_5 + val_17;
        }
        
        if(this.FTUXHand > 0)
        {
                float val_10 = 1.3f - this.curveTime;
            val_17 = 1f;
            val_10 = val_10 + val_10;
            val_16 = this.curveTime + val_17;
            val_19 = val_10 + val_17;
            val_18 = val_16 + (-1.3f);
        }
        
        UnityEngine.Transform val_11 = this.FTUXHand.transform;
        UnityEngine.Vector3 val_12 = new UnityEngine.Vector3(x:  val_16, y:  this.y3, z:  val_17);
        this.FTUXHand.localScale = new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z};
        object val_13 = this.FTUXHand.GetComponent<System.Object>();
        PluginExtension.SetColorAlpha(graphic:  this.FTUXHand, a:  val_16);
        if(this.FTUXHand > 0)
        {
                this.FTUXHand = 52429;
            this.curveTime = -0.4f;
        }
    
    }
    public void EndFTUX()
    {
        this.<ftux>k__BackingField = false;
        this.enabled = false;
        this.FTUXText.enabled = false;
        this.HideHand();
    }
    public void SetLevel(int lev)
    {
        int val_1;
        if(lev == 1)
        {
            goto label_0;
        }
        
        if(lev != 0)
        {
            goto label_1;
        }
        
        this.<ftux>k__BackingField = true;
        val_1 = 0;
        goto label_2;
        label_0:
        this.<ftux>k__BackingField = true;
        val_1 = 3;
        label_2:
        this.ftuxPhase = val_1;
        this.enabled = true;
        return;
        label_1:
        this.EndFTUX();
    }
    public bool IsFtuxLevel(int lev)
    {
        if(lev < 2)
        {
                0 = 1;
        }
        
        return true;
    }
    public int GetFtuxLevelSize(int lev)
    {
        return 6;
    }
    public float GetFtuxLevelTime(int lev)
    {
        return (float)S0;
    }
    public SLC.Minigames.WordFill.WordFillLevel GetFtuxLevel(int lev)
    {
        SLC.Minigames.WordFill.WordFillFtuxLevel val_1 = new SLC.Minigames.WordFill.WordFillFtuxLevel(lev:  lev);
    }
    public string GetFtuxLevelCategory(int lev)
    {
        if(lev == 0)
        {
                "Birds" = "Colors";
        }
    
    }
    public void FtuxProceed()
    {
        if((this.<ftux>k__BackingField) == false)
        {
                return;
        }
        
        int val_5 = this.ftuxPhase;
        val_5 = val_5 + 1;
        this.ftuxPhase = val_5;
        UnityEngine.GameObject val_1 = this.FTUXText.gameObject;
        this.FTUXText.SetActive(value:  false);
        this.HideHand();
        if(this.ftuxPhase < this)
        {
                twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static SLC.Minigames.WordFill.WordFillUIController MonoSingleton<SLC.Minigames.WordFill.WordFillUIController>::get_Instance().__il2cppRuntimeField_5E = 1;
            System.Collections.IEnumerator val_3 = this.ShowFTUXElements();
            UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  -1729630736);
            return;
        }
        
        this.EndFTUX();
    }
    public string RequiredFtuxAnswer()
    {
        if((this.<ftux>k__BackingField) == false)
        {
                return;
        }
        
        if(this.ftuxPhase == 2)
        {
                return;
        }
        
        if(this.ftuxPhase == 1)
        {
                return;
        }
        
        if(this.ftuxPhase != 4)
        {
                "HOW" = 0;
        }
    
    }
    private System.Collections.IEnumerator ShowFTUXElements()
    {
        object val_1 = new System.Object();
        typeof(WordFillFTUXManager.<ShowFTUXElements>d__29).__il2cppRuntimeField_8 = 0;
        typeof(WordFillFTUXManager.<ShowFTUXElements>d__29).__il2cppRuntimeField_10 = this;
    }
    public void ShowHand(UnityEngine.Transform one, UnityEngine.Transform two, UnityEngine.Transform three)
    {
        float val_2;
        float val_4;
        float val_6;
        float val_8;
        float val_10;
        float val_12;
        UnityEngine.Vector3 val_1 = position;
        this.x1 = val_2;
        UnityEngine.Vector3 val_3 = position;
        this.x2 = val_4;
        UnityEngine.Vector3 val_5 = position;
        this.x3 = val_6;
        UnityEngine.Vector3 val_7 = position;
        this.y1 = val_8;
        UnityEngine.Vector3 val_9 = position;
        this.y2 = val_10;
        UnityEngine.Vector3 val_11 = position;
        this.y3 = val_12;
        UnityEngine.Transform val_13 = this.FTUXHand.transform;
        UnityEngine.Vector3 val_14 = position;
        this.FTUXHand.position = new UnityEngine.Vector3();
        this.FTUXHand.SetActive(value:  true);
        this.animatingCurve = true;
        this.curveTime = -0.4f;
    }
    public void HideHand()
    {
        this.FTUXHand.SetActive(value:  false);
        this.animatingCurve = false;
    }
    public WordFillFTUXManager()
    {
        typeof(System.String[]).__il2cppRuntimeField_10 = "";
        typeof(System.String[]).__il2cppRuntimeField_14 = "Find words that match the theme";
        typeof(System.String[]).__il2cppRuntimeField_18 = "Complete levels by finding every word";
        typeof(System.String[]).__il2cppRuntimeField_1C = "";
        typeof(System.String[]).__il2cppRuntimeField_20 = "Extra words award more time!";
        this.ftuxMessages = null;
        this.ftuxLetterPos = null;
    }

}
