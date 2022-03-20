using UnityEngine;
private sealed class Pan.<EnableLetters>d__29 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public System.Collections.Generic.List<string> tileStrings;
    public System.Collections.Generic.List<int> indexes;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Pan.<EnableLetters>d__29(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_6;
        var val_7;
        if((this.<>1__state) != 1)
        {
                val_6 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_6;
        }
        
            val_6 = 1;
            this.<>1__state = val_6;
            this.<>2__current = 0;
            return (bool)val_6;
        }
        
        this.<>1__state = 0;
        WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        MainController val_2 = MainController.instance;
        val_7 = 2147483648;
        if((0.Equals(value:  -2100450224)) != false)
        {
                GameBehavior val_4 = App.getBehavior;
            val_7 = 0;
        }
        
        val_6 = 0;
        System.Collections.Generic.List<System.Boolean> val_5 = GetAllowedLetters(level:  0, lettersSize:  1094062064, lettersArray:  this.tileStrings, indexes:  this.indexes);
        LineDrawer.instance.allowedPositions = public static WADataParser MonoSingletonSelfGenerating<WADataParser>::get_Instance();
        return (bool)val_6;
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
    
    }
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
    
    }

}
