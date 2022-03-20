using UnityEngine;
public class TRVCategoryButton : FrameSkipper
{
    // Fields
    private UnityEngine.UI.Image categoryImage;
    private UnityEngine.UI.Text categoryName;
    private UnityEngine.GameObject categoryRankNotification;
    private UnityEngine.UI.Text categoryRank;
    private UnityEngine.UI.Image eventIcon;
    private UnityEngine.UI.Text timeRemaining;
    private UnityEngine.GameObject promoCategoryHighlight;
    private bool showPromoEndTime;
    private System.DateTime endTime;
    public bool animating;
    private string myCat;
    private UnityEngine.UI.Button myButton;
    
    // Properties
    public string getCat { get; }
    public UnityEngine.UI.Button MyButton { get; }
    
    // Methods
    public string get_getCat()
    {
    
    }
    public UnityEngine.UI.Button get_MyButton()
    {
        if(this.myButton != 0)
        {
                return;
        }
        
        object val_2 = this.GetComponent<System.Object>();
        this.myButton = this;
    }
    public void SetCategoryButton(UnityEngine.Sprite image, string name, int rank = 0, UnityEngine.Sprite eventIcon, bool hasEndTime = False, System.DateTime endTime, bool showPromoHighlight = False)
    {
        string val_13;
        var val_14;
        val_13 = name;
        this.myCat = val_13;
        if(image != 0)
        {
                this.categoryImage.sprite = image;
        }
        
        this.categoryImage.preserveAspect = true;
        if((val_13.Contains(value:  -559222368)) != false)
        {
                string val_3 = val_13.Replace(oldValue:  -559222368, newValue:  1098586544);
            val_13 = val_13;
        }
        
        if((System.String.IsNullOrEmpty(value:  val_13)) != false)
        {
                if(this.categoryName != 0)
        {
            goto label_12;
        }
        
        }
        else
        {
                string val_5 = TRVCategorySelection.ToUpperCategory(category:  val_13);
        }
        
        label_12:
        string val_6 = rank.ToString();
        if(rank > 0)
        {
                0 = 1;
        }
        
        this.categoryRankNotification.SetActive(value:  true);
        this.endTime = endTime;
        mem[1152921512637624308] = endTime.dateData;
        this.showPromoEndTime = hasEndTime;
        if(this.timeRemaining != 0)
        {
                UnityEngine.GameObject val_8 = this.timeRemaining.gameObject;
            if(this.showPromoEndTime == true)
        {
                this.showPromoEndTime = 1;
        }
        
            this.timeRemaining.SetActive(value:  true);
            this.UpdateTimeRemaining();
        }
        
        if(this.promoCategoryHighlight != 0)
        {
                this.promoCategoryHighlight.SetActive(value:  showPromoHighlight);
        }
        
        if(eventIcon == 0)
        {
                UnityEngine.GameObject val_11 = this.eventIcon.gameObject;
            val_14 = 0;
        }
        else
        {
                this.eventIcon.sprite = eventIcon;
            UnityEngine.GameObject val_12 = this.eventIcon.gameObject;
            val_14 = 1;
        }
        
        this.eventIcon.SetActive(value:  true);
    }
    public void SetCategoryName(string name)
    {
        string val_3 = name;
        if((val_3.Contains(value:  -559222368)) != false)
        {
                string val_2 = val_3.Replace(oldValue:  -559222368, newValue:  1098586544);
            val_3 = val_3;
        }
        
        if(this.categoryName == 0)
        {
            
        }
    
    }
    protected override void UpdateLogic()
    {
        this.UpdateTimeRemaining();
    }
    private void UpdateTimeRemaining()
    {
        long val_6;
        var val_11;
        if(this.animating != false)
        {
                return;
        }
        
        if(this.showPromoEndTime == false)
        {
                return;
        }
        
        if(this.timeRemaining == 0)
        {
                return;
        }
        
        System.DateTime val_2 = DateTimeCheat.UtcNow;
        System.TimeSpan val_5 = Subtract(value:  new System.DateTime() {dateData = this.endTime});
        string val_8 = val_5._ticks.GetDateString(difference:  new System.TimeSpan() {_ticks = this.endTime});
        UnityEngine.UI.Button val_9 = this.MyButton;
        val_11 = null;
        val_11 = null;
        this.interactable = System.TimeSpan.op_GreaterThan(t1:  new System.TimeSpan() {_ticks = val_6}, t2:  new System.TimeSpan() {_ticks = System.TimeSpan.Zero});
    }
    private string GetDateString(System.TimeSpan difference)
    {
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        val_14 = 1152921504622821376;
        val_15 = null;
        val_15 = null;
        if((System.TimeSpan.op_LessThanOrEqual(t1:  new System.TimeSpan() {_ticks = R2}, t2:  new System.TimeSpan() {_ticks = System.TimeSpan.Zero})) != false)
        {
                return;
        }
        
        val_16 = 0;
        if((???.Days) < 1)
        {
            goto label_5;
        }
        
        int val_3 = ???.Days;
        val_17 = 1152921504619999232;
        val_18 = null;
        int val_4 = ???.Hours;
        val_14 = null;
        int val_5 = ???.Minutes;
        val_19 = null;
        val_20 = "{0}d {1}h {2}m";
        goto label_6;
        label_5:
        val_16 = 0;
        if((???.Hours) < 1)
        {
            goto label_7;
        }
        
        int val_7 = ???.Hours;
        val_17 = 1152921504619999232;
        val_18 = null;
        int val_8 = ???.Minutes;
        val_14 = null;
        int val_9 = ???.Seconds;
        val_19 = null;
        val_20 = "{0}h {1}m {2}s";
        label_6:
        string val_10 = System.String.Format(format:  -1135144144, arg0:  13152256, arg1:  13152256, arg2:  13152256);
        return;
        label_7:
        int val_11 = ???.Minutes;
        int val_12 = ???.Seconds;
        string val_13 = System.String.Format(format:  -1086509984, arg0:  13152256, arg1:  13152256);
    }
    public TRVCategoryButton()
    {
    
    }

}
