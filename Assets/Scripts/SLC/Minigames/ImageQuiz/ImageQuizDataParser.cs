using UnityEngine;

namespace SLC.Minigames.ImageQuiz
{
    public class ImageQuizDataParser
    {
        // Fields
        private const string RESOURCE_PATH = "minigames/ImageQuiz/";
        private const string LEVELDATA_FILENAME = "image_quiz_data";
        private const string LEVELDATA_PP_SAVED = "PP_w4yt_saved";
        private const int LEVELDATA_COLUMNS = 3;
        
        // Methods
        public void Init()
        {
            System.Action<twelvegigs.storage.JsonDictionary> val_1 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  1056391840, method:  new IntPtr(1056365584));
            this.LoadData(filename:  1056367728, ppSaveStr:  1056367632, dataColumns:  3, processDataFunction:  null);
        }
        public void LoadData(string filename, string ppSaveStr, int dataColumns, System.Action<string[]> processDataFunction)
        {
            if((UnityEngine.PlayerPrefs.HasKey(key:  ppSaveStr)) != true)
            {
                    string val_2 = UnityEngine.Application.persistentDataPath;
                string val_3 = System.String.Format(format:  1629069648, arg0:  0, arg1:  filename);
                string val_4 = 1056492128 + filename;
                object val_5 = UnityEngine.Resources.Load<System.Object>(path:  1056492128);
                string val_6 = text;
                System.IO.File.WriteAllText(path:  1629069648, contents:  1056492128);
                UnityEngine.PlayerPrefs.SetInt(key:  ppSaveStr, value:  1);
                bool val_7 = PrefsSerializationManager.SavePlayerPrefs();
            }
            
            this.LoadDataInMemory(filename:  filename, ppSaveStr:  null, dataColumns:  dataColumns, processDataFunction:  processDataFunction, firstLineIsHeader:  true);
        }
        private void LoadDataInMemory(string filename, string ppSaveStr, int dataColumns, System.Action<string[]> processDataFunction, bool firstLineIsHeader = True)
        {
            var val_9;
            string val_1 = UnityEngine.Application.persistentDataPath;
            string val_2 = System.String.Format(format:  1629069648, arg0:  0, arg1:  filename);
            string val_3 = System.IO.File.ReadAllText(path:  1629069648);
            typeof(System.Char[]).__il2cppRuntimeField_10 = Chars[0];
            System.String[] val_5 = Split(separator:  478563824);
            val_9 = firstLineIsHeader | 4;
            bool val_7 =  - 4;
            if(("{0}/{1}") != 0)
            {
                    return;
            }
        
        }
        private string[] CSVLineParser(string fileData)
        {
            var val_6 = 0;
            System.Text.RegularExpressions.Regex val_1 = new System.Text.RegularExpressions.Regex(pattern:  1056758224);
            System.String[] val_2 = Split(input:  fileData);
            if(null != 0)
            {
                    return;
            }
        
        }
        private void ProcessArrayDataToMinigame(string[] data)
        {
            if(true != 3)
            {
                    return;
            }
            
            object val_1 = new System.Object();
            typeof(SLC.Minigames.ImageQuiz.QuizLevelData).__il2cppRuntimeField_8 = data[0];
            typeof(SLC.Minigames.ImageQuiz.QuizLevelData).__il2cppRuntimeField_C = data[1];
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            AddLevel(level:  455217152);
        }
        public ImageQuizDataParser()
        {
        
        }
    
    }

}
