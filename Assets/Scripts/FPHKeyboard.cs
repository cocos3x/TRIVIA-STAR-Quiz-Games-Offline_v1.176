using UnityEngine;
public class FPHKeyboard : MonoBehaviour
{
    // Fields
    public const char KEY_QUIT = '\x7';
    public const char KEY_BACKSPACE = '\x8';
    private System.Collections.Generic.List<UnityEngine.UI.HorizontalLayoutGroup> keyRows;
    private bool setup;
    private FPHKeyButton keyButtonPrefab;
    private FPHKeyButton keyButtonBackspacePrefab;
    private FPHKeyButton keyButtonQuitPrefab;
    private System.Collections.Generic.Dictionary<char, FPHKeyButton> keyboardKeys;
    public static readonly System.Collections.Generic.List<System.Collections.Generic.List<char>> LettersPerRow;
    
    // Methods
    public static bool IsLetter(char value)
    {
        return System.Char.IsLetter(c:  value);
    }
    public static bool IsVowel(char value)
    {
        char val_1 = value - 97;
        if(val_1 <= '')
        {
                if(1065233 != (1 << val_1))
        {
                return true;
        }
        
        }
        
        char val_2 = value - 65;
        if((val_2 <= '') && ((16657 & (1 << val_2)) == 0))
        {
                return true;
        }
        
        value = value - 85;
        value = value >> 5;
        return (bool)value;
    }
    private void SetupNewKeyboard()
    {
        char val_5;
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        object val_14;
        var val_15;
        if(this.setup == true)
        {
                return;
        }
        
        System.Collections.Generic.Dictionary<System.Char, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.Char, System.Object>();
        this.keyboardKeys = null;
        var val_12 = 0;
        label_31:
        val_10 = null;
        val_10 = null;
        if(val_12 >= (FPHKeyboard.LettersPerRow + 12))
        {
            goto label_5;
        }
        
        val_11 = null;
        val_11 = null;
        if((FPHKeyboard.LettersPerRow + 12) <= val_12)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_10 = FPHKeyboard.LettersPerRow + 8;
        val_10 = val_10 + 0;
        List.Enumerator<T> val_2 = GetEnumerator();
        label_30:
        if(MoveNext() == false)
        {
            goto label_11;
        }
        
        if(new System.Object() != 0)
        {
                typeof(FPHKeyboard.<>c__DisplayClass11_0).__il2cppRuntimeField_C = this;
            val_12 = 1152921504910626824;
            val_13 = val_5;
            typeof(FPHKeyboard.<>c__DisplayClass11_0).__il2cppRuntimeField_8 = val_13;
        }
        else
        {
                mem[12] = this;
            mem[8] = val_5;
            val_12 = 8;
            val_13 = mem[8];
        }
        
        if(val_13 == 8)
        {
                val_14 = mem[this.keyButtonBackspacePrefab];
            val_14 = this.keyButtonBackspacePrefab;
        }
        else
        {
                if(val_12 == 7)
        {
                val_14 = mem[this.keyButtonQuitPrefab];
            val_14 = this.keyButtonQuitPrefab;
        }
        
        }
        
        if(this.keyButtonQuitPrefab <= val_12)
        {
                var val_11 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_11 = val_11 + 0;
        UnityEngine.Transform val_6 = (0 + 0) + 16.transform;
        object val_7 = UnityEngine.Object.Instantiate<System.Object>(original:  val_14, parent:  (0 + 0) + 16);
        val_14.Init(myCharacter:  mem[8], state:  1);
        System.Action val_8 = new System.Action(object:  303779840, method:  new IntPtr(2661771312));
        System.Delegate val_9 = System.Delegate.Combine(a:  this.keyButtonQuitPrefab + 68, b:  7454720);
        val_15 = 0;
        if((this.keyButtonQuitPrefab + 68) != 0)
        {
                if((this.keyButtonQuitPrefab + 68) != null)
        {
            
        }
        else
        {
                val_15 = this.keyButtonQuitPrefab + 68;
        }
        
        }
        
        mem2[0] = val_15;
        this.keyboardKeys.Add(key:  mem[8], value:  val_14);
        goto label_30;
        label_11:
        Dispose();
        val_12 = val_12 + 1;
        if(1 != 1)
        {
                 = 0;
            1 = 1 + ;
        }
        
        if(1 == 1)
        {
                1 = 0;
        }
        
        goto label_31;
        label_5:
        this.setup = true;
    }
    public void OnKeyClicked(char key)
    {
        FPHGameplayController val_1 = FPHGameplayController.Instance;
        OnLetterPressed(letter:  key);
    }
    public void ResetKeyboard()
    {
        if(this.setup == false)
        {
            goto label_1;
        }
        
        Dictionary.Enumerator<TKey, TValue> val_1 = 0.GetEnumerator();
        label_5:
        if(0.MoveNext() == false)
        {
            goto label_3;
        }
        
        0.SetActive();
        goto label_5;
        label_3:
        0.Dispose();
        return;
        label_1:
        this.SetupNewKeyboard();
    }
    public void UpdateKeyboard(FPHGameplayState state)
    {
        char val_3;
        bool val_14;
        if(this.setup == false)
        {
                this.setup = this;
            this.SetupNewKeyboard();
        }
        
        List.Enumerator<T> val_1 = GetEnumerator();
        label_9:
        if(MoveNext() == false)
        {
            goto label_3;
        }
        
        string val_4 = val_3.ToString();
        val_14 = 1;
        if((state.phraseSlotCorrectValue.Contains(value:  -1632783530)) != true)
        {
                string val_6 = state.phraseSlotCorrectValueNormalized;
            string val_7 = val_3.ToString();
            val_14 = state.Contains(value:  -1632783530);
        }
        
        FPHKeyButton val_9 = this.keyboardKeys.Item[val_3];
        this.keyboardKeys.SetPurchased(isCorrectLetter:  val_14);
        goto label_9;
        label_3:
        Dispose();
        List.Enumerator<T> val_10 = GetEnumerator();
        label_16:
        if(MoveNext() == false)
        {
            goto label_11;
        }
        
        if((this.keyboardKeys.ContainsKey(key:  val_3)) == false)
        {
            goto label_16;
        }
        
        FPHKeyButton val_13 = this.keyboardKeys.Item[val_3];
        this.keyboardKeys.SetPowerupRemoved();
        goto label_16;
        label_11:
        Dispose();
        this.UpdateTutorialKeyboard(state:  state);
    }
    private void UpdateTutorialKeyboard(FPHGameplayState state)
    {
        float val_5;
        var val_15;
        var val_16;
        val_15 = this;
        FPHGameplayController val_1 = FPHGameplayController.Instance;
        val_16 = null;
        if(val_16 == 0)
        {
                return;
        }
        
        FPHGameplayController val_2 = FPHGameplayController.Instance;
        val_16 = null;
        if(val_16 == 0)
        {
                return;
        }
        
        FPHKeyButton val_3 = this.keyboardKeys.Item[state.currentTutorialLetter];
        this.keyboardKeys.Play();
        Dictionary.Enumerator<TKey, TValue> val_4 = GetEnumerator();
        val_15 = 1152921511563837232;
        label_25:
        if(0.MoveNext() == false)
        {
            goto label_14;
        }
        
        if((System.Linq.Enumerable.Contains<System.Char>(source:  state.phraseSlotCorrectValue, value:  ' ')) == true)
        {
            goto label_15;
        }
        
        string val_8 = state.phraseSlotCorrectValueNormalized;
        if((System.Linq.Enumerable.Contains<System.Char>(source:  state, value:  ' ')) == false)
        {
            goto label_16;
        }
        
        label_15:
        if(state.currentTutorialLetter != 0)
        {
            goto label_17;
        }
        
        R6 + 60.Play();
        goto label_25;
        label_17:
        R6 + 60.Stop();
        goto label_25;
        label_16:
        R6.SetInactive();
        goto label_25;
        label_14:
        0.Dispose();
        string val_10 = Localization.Localize(key:  -1632637248, defaultValue:  -1632637392, useSingularKey:  false);
        string val_11 = Localization.Localize(key:  -1632637152, defaultValue:  -1632637056, useSingularKey:  false);
        string val_12 = System.String.Format(format:  -1826949520, arg0:  -1632637248, arg1:  -1632637152);
        twelvegigs.Autopilot.AutopilotManager val_13 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_5 = state.currentTutorialLetter;
        string val_14 = System.String.Format(format:  -1826949520, arg0:  9158656);
        UpdateTutorialText(text:  -1826949520);
    }
    public FPHKeyboard()
    {
    
    }
    private static FPHKeyboard()
    {
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        if((new System.Collections.Generic.List<System.Char>()) != 0)
        {
                Add(item:  'Q');
            Add(item:  'W');
            Add(item:  'E');
            Add(item:  'R');
            Add(item:  'T');
            Add(item:  'Y');
            Add(item:  'U');
            Add(item:  'I');
            Add(item:  'O');
        }
        else
        {
                Add(item:  'Q');
            Add(item:  'W');
            Add(item:  'E');
            Add(item:  'R');
            Add(item:  'T');
            Add(item:  'Y');
            Add(item:  'U');
            Add(item:  'I');
            Add(item:  'O');
        }
        
        Add(item:  'P');
        Add(item:  80883712);
        if((new System.Collections.Generic.List<System.Char>()) != 0)
        {
                Add(item:  'A');
            Add(item:  'S');
            Add(item:  'D');
            Add(item:  'F');
            Add(item:  'G');
            Add(item:  'H');
            Add(item:  'J');
            Add(item:  'K');
        }
        else
        {
                Add(item:  'A');
            Add(item:  'S');
            Add(item:  'D');
            Add(item:  'F');
            Add(item:  'G');
            Add(item:  'H');
            Add(item:  'J');
            Add(item:  'K');
        }
        
        Add(item:  'L');
        Add(item:  80883712);
        if((new System.Collections.Generic.List<System.Char>()) != 0)
        {
                Add(item:  '');
            Add(item:  'Z');
            Add(item:  'X');
            Add(item:  'C');
            Add(item:  'V');
            Add(item:  'B');
            Add(item:  'N');
            Add(item:  'M');
        }
        else
        {
                Add(item:  '');
            Add(item:  'Z');
            Add(item:  'X');
            Add(item:  'C');
            Add(item:  'V');
            Add(item:  'B');
            Add(item:  'N');
            Add(item:  'M');
        }
        
        Add(item:  '');
        Add(item:  80883712);
        FPHKeyboard.LettersPerRow = null;
    }

}
