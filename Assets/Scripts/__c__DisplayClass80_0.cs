using UnityEngine;
private sealed class IslandParadiseEventHandler.<>c__DisplayClass80_0
{
    // Fields
    public float buttonProgress;
    public WGEventButtonV2_IslandParadise islandParadiseButton;
    public IslandParadiseEventHandler <>4__this;
    public WGEventButtonV2 eventProgressUI;
    public int initialProgressLabelPoints;
    public int startValue;
    public int points;
    
    // Methods
    public IslandParadiseEventHandler.<>c__DisplayClass80_0()
    {
    
    }
    internal void <PlayPointCollectionSequence>b__0(float x)
    {
        this.buttonProgress = ;
    }
    internal void <PlayPointCollectionSequence>b__1()
    {
        int val_1 = UnityEngine.Mathf.RoundToInt(f:  null);
        string val_2 = val_1.ToString();
        string val_3 = this.<>4__this.ToString();
        string val_4 = System.String.Format(format:  1629069648, arg0:  -1370257692, arg1:  -1370257696);
        int val_6 = val_1;
        val_6 = this.initialProgressLabelPoints - val_6;
        val_6 = val_6 + this.startValue;
        string val_5 = val_6.ToString();
        if(this.eventProgressUI.buttonLabel != 0)
        {
                return;
        }
    
    }
    internal void <PlayPointCollectionSequence>b__2()
    {
        int val_5 = this.startValue;
        val_5 = this.points + val_5;
        string val_1 = val_5.ToString();
        string val_2 = this.<>4__this.ToString();
        string val_3 = System.String.Format(format:  1629069648, arg0:  -1370112924, arg1:  -1370112924);
        int val_6 = this.initialProgressLabelPoints;
        val_6 = val_6 - this.points;
        string val_4 = val_6.ToString();
        if(this.eventProgressUI.buttonLabel != 0)
        {
                return;
        }
    
    }

}
