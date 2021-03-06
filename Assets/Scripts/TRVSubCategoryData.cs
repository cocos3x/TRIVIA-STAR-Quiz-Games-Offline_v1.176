using UnityEngine;
public class TRVSubCategoryData
{
    // Fields
    public string subCategory;
    public System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<QuestionData>> questionData;
    
    // Methods
    public TRVSubCategoryData(UnityEngine.TextAsset unparsedData, string subCategoryName)
    {
        UnityEngine.TextAsset val_10;
        this.subCategory = "";
        System.Collections.Generic.Dictionary<System.Int32, WordPets.WPTLetterTile> val_1 = new System.Collections.Generic.Dictionary<System.Int32, WordPets.WPTLetterTile>();
        this.questionData = null;
        val_2 = new System.Object();
        string val_3 = unparsedData.text;
        System.String[] val_4 = System.Text.RegularExpressions.Regex.Split(input:  unparsedData, pattern:  -1654395616);
        if(unparsedData != 0)
        {
                val_10 = unparsedData;
        }
        
        if(unparsedData == 0)
        {
                return;
        }
        
        if(unparsedData >= 1)
        {
                UnityEngine.TextAsset val_5 = val_10 + 16;
            var val_10 = 0;
            do
        {
            QuestionData val_6 = new QuestionData(unparsedQuestionData:  158519296);
            if((this.questionData.ContainsKey(key:  QuestionData.__il2cppRuntimeField_byval_arg)) != true)
        {
                System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_8 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.questionData.Add(key:  QuestionData.__il2cppRuntimeField_byval_arg, value:  80883712);
            val_10 = val_10;
        }
        
            System.Collections.Generic.List<QuestionData> val_9 = this.questionData.Item[QuestionData.__il2cppRuntimeField_byval_arg];
            this.questionData.Add(item:  357453824);
            val_10 = val_10 + 1;
        }
        while(val_10 < (unparsedData + 12));
        
        }
        
        this.subCategory = val_2;
    }
    public TRVSubCategoryData(string textBlock, string subCategoryName)
    {
        string val_9;
        this.subCategory = "";
        System.Collections.Generic.Dictionary<System.Int32, WordPets.WPTLetterTile> val_1 = new System.Collections.Generic.Dictionary<System.Int32, WordPets.WPTLetterTile>();
        this.questionData = null;
        val_2 = new System.Object();
        System.String[] val_3 = System.Text.RegularExpressions.Regex.Split(input:  textBlock, pattern:  -1654395616);
        if(textBlock != null)
        {
                val_9 = textBlock;
            textBlock = textBlock.m_firstChar;
        }
        
        if(textBlock == ' ')
        {
                return;
        }
        
        if(textBlock >= '')
        {
                string val_4 = val_9 + 16;
            var val_9 = 0;
            do
        {
            QuestionData val_5 = new QuestionData(unparsedQuestionData:  15388672);
            if((this.questionData.ContainsKey(key:  QuestionData.__il2cppRuntimeField_byval_arg)) != true)
        {
                System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_7 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.questionData.Add(key:  QuestionData.__il2cppRuntimeField_byval_arg, value:  80883712);
            val_9 = val_9;
        }
        
            System.Collections.Generic.List<QuestionData> val_8 = this.questionData.Item[QuestionData.__il2cppRuntimeField_byval_arg];
            this.questionData.Add(item:  357453824);
            val_9 = val_9 + 1;
        }
        while(val_9 < (textBlock + 12));
        
        }
        
        this.subCategory = val_2;
    }

}
