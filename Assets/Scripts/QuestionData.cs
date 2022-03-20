using UnityEngine;
public class QuestionData
{
    // Fields
    private string <questionID>k__BackingField;
    private string <category>k__BackingField;
    private int <difficulty>k__BackingField;
    private string <question>k__BackingField;
    private string <answer>k__BackingField;
    private System.Collections.Generic.List<string> <incorrectAnswers>k__BackingField;
    private string <factoid>k__BackingField;
    public UnityEngine.Sprite imageSp;
    
    // Properties
    public string questionID { get; set; }
    public string category { get; set; }
    public int difficulty { get; set; }
    public string question { get; set; }
    public string answer { get; set; }
    public System.Collections.Generic.List<string> incorrectAnswers { get; set; }
    public string factoid { get; set; }
    
    // Methods
    public string get_questionID()
    {
    
    }
    private void set_questionID(string value)
    {
        this.<questionID>k__BackingField = value;
    }
    public string get_category()
    {
    
    }
    public void set_category(string value)
    {
        this.<category>k__BackingField = value;
    }
    public int get_difficulty()
    {
        return (int)this.<difficulty>k__BackingField;
    }
    private void set_difficulty(int value)
    {
        this.<difficulty>k__BackingField = value;
    }
    public string get_question()
    {
    
    }
    private void set_question(string value)
    {
        this.<question>k__BackingField = value;
    }
    public string get_answer()
    {
    
    }
    private void set_answer(string value)
    {
        this.<answer>k__BackingField = value;
    }
    public System.Collections.Generic.List<string> get_incorrectAnswers()
    {
    
    }
    private void set_incorrectAnswers(System.Collections.Generic.List<string> value)
    {
        this.<incorrectAnswers>k__BackingField = value;
    }
    public string get_factoid()
    {
    
    }
    private void set_factoid(string value)
    {
        this.<factoid>k__BackingField = value;
    }
    public QuestionData(string unparsedQuestionData)
    {
        System.Collections.Generic.List<System.String> val_14;
        var val_15;
        string val_1 = unparsedQuestionData;
        val_1 = new System.Object();
        val_14 = null;
        typeof(System.Char[]).__il2cppRuntimeField_10 = 9;
        System.String[] val_3 = val_1.Split(separator:  478563824);
        if((new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>()) != 0)
        {
                AddRange(collection:  val_1);
        }
        else
        {
                AddRange(collection:  val_1);
        }
        
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        this.<questionID>k__BackingField = null;
        bool val_4 = Remove(item:  List<T>.__il2cppRuntimeField_10);
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        this.<category>k__BackingField = null;
        bool val_5 = Remove(item:  List<T>.__il2cppRuntimeField_10);
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        bool val_7 = System.Int32.TryParse(s:  List<T>.__il2cppRuntimeField_10, result: out  int val_6 = -533873272);
        RemoveAt(index:  0);
        val_15 = 3;
        this.<difficulty>k__BackingField = UnityEngine.Mathf.Min(a:  0, b:  3);
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        this.<question>k__BackingField = null;
        bool val_9 = Remove(item:  List<T>.__il2cppRuntimeField_10);
        this.<incorrectAnswers>k__BackingField = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        goto label_12;
        label_15:
        bool val_11 = Remove(item:  80883712);
        val_14 = this.<incorrectAnswers>k__BackingField;
        val_14.Add(item:  80883712);
        val_15 = 2;
        label_12:
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        if(val_15 != 0)
        {
            goto label_15;
        }
        
        this.<answer>k__BackingField = null;
        bool val_12 = Remove(item:  List<T>.__il2cppRuntimeField_10);
        this.<factoid>k__BackingField = null;
        bool val_13 = Remove(item:  List<T>.__il2cppRuntimeField_10);
    }
    public override string ToString()
    {
        System.Text.StringBuilder val_1 = new System.Text.StringBuilder();
        string val_2 = System.String.Format(format:  -533760944, arg0:  this.<question>k__BackingField);
        System.Text.StringBuilder val_3 = AppendLine(value:  -533760944);
        string val_4 = System.String.Format(format:  -533756752, arg0:  this.<answer>k__BackingField);
        if(val_1 != 0)
        {
                System.Text.StringBuilder val_5 = AppendLine(value:  -533756752);
        }
        else
        {
                System.Text.StringBuilder val_6 = AppendLine(value:  -533756752);
        }
        
        System.Text.StringBuilder val_7 = AppendLine(value:  -533756656);
        string val_8 = PrettyPrint.printJSON(obj:  this.<incorrectAnswers>k__BackingField, types:  false, singleLineOutput:  false);
        if(val_1 != 0)
        {
                System.Text.StringBuilder val_9 = AppendLine(value:  this.<incorrectAnswers>k__BackingField);
        }
        else
        {
                System.Text.StringBuilder val_10 = AppendLine(value:  this.<incorrectAnswers>k__BackingField);
        }
    
    }

}
