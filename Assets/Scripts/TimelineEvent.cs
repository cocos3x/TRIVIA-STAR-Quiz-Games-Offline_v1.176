using UnityEngine;
public struct TimelineEvent
{
    // Fields
    public TimelineEvent.Type type;
    public MainController.GameModeForTracking gameMode;
    public string word;
    public string levelWord;
    public string levelWords;
    public string language;
    public double stamp;
    public double delta;
    public bool isLevelWord;
    
    // Methods
    public override string ToString()
    {
        typeof(System.Object[]).__il2cppRuntimeField_10 = null;
        typeof(System.Object[]).__il2cppRuntimeField_14 = null;
        typeof(System.Object[]).__il2cppRuntimeField_18 = this.word;
        typeof(System.Object[]).__il2cppRuntimeField_1C = this.levelWord;
        typeof(System.Object[]).__il2cppRuntimeField_20 = null;
        typeof(System.Object[]).__il2cppRuntimeField_24 = this.levelWords;
        typeof(System.Object[]).__il2cppRuntimeField_28 = this.language;
        typeof(System.Object[]).__il2cppRuntimeField_2C = null;
        typeof(System.Object[]).__il2cppRuntimeField_30 = null;
        string val_1 = System.String.Format(format:  73694176, args:  472754880);
    }

}
