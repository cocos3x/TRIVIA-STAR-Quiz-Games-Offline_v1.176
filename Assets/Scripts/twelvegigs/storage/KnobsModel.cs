using UnityEngine;

namespace twelvegigs.storage
{
    public class KnobsModel
    {
        // Methods
        private object IsDynamicKnob(string knobId)
        {
            string val_1 = UnityEngine.PlayerPrefs.GetString(key:  knobId, defaultValue:  null);
            if(knobId == null)
            {
                    return;
            }
            
            if((System.String.op_Inequality(a:  knobId, b:  1098586544)) == false)
            {
                    return;
            }
            
            return MiniJSON.Json.Deserialize(json:  knobId);
        }
        public twelvegigs.storage.JsonDictionary getUpdatePromptConfiguration()
        {
            object val_1 = IsDynamicKnob(knobId:  1140549680);
            if("update_prompt" != 0)
            {
                    twelvegigs.storage.JsonDictionary val_2 = new twelvegigs.storage.JsonDictionary(parsedDictionary:  "update_prompt");
                return;
            }
            
            twelvegigs.storage.JsonDictionary val_3 = new twelvegigs.storage.JsonDictionary();
        }
        public System.Collections.IDictionary getGenericNofications()
        {
            object val_1 = IsDynamicKnob(knobId:  1140661776);
            twelvegigs.storage.JsonDictionary val_2 = new twelvegigs.storage.JsonDictionary();
        }
        public System.Collections.IDictionary getSalesLogic()
        {
            object val_1 = IsDynamicKnob(knobId:  1140773888);
            twelvegigs.storage.JsonDictionary val_2 = new twelvegigs.storage.JsonDictionary();
        }
        public System.Collections.IDictionary getInstallRecapture()
        {
            object val_1 = IsDynamicKnob(knobId:  1140885984);
            twelvegigs.storage.JsonDictionary val_2 = new twelvegigs.storage.JsonDictionary();
        }
        public twelvegigs.storage.JsonDictionary getGameplayKnobs()
        {
            object val_1 = IsDynamicKnob(knobId:  1140998096);
            if("gameplay" != 0)
            {
                    twelvegigs.storage.JsonDictionary val_2 = new twelvegigs.storage.JsonDictionary(parsedDictionary:  "gameplay");
                return;
            }
            
            twelvegigs.storage.JsonDictionary val_3 = new twelvegigs.storage.JsonDictionary();
        }
        public twelvegigs.storage.JsonDictionary getWordGameplayKnobs()
        {
            object val_1 = IsDynamicKnob(knobId:  1141110192);
            if("word_gameplay" != 0)
            {
                    twelvegigs.storage.JsonDictionary val_2 = new twelvegigs.storage.JsonDictionary(parsedDictionary:  "word_gameplay");
                return;
            }
            
            twelvegigs.storage.JsonDictionary val_3 = new twelvegigs.storage.JsonDictionary();
        }
        public twelvegigs.storage.JsonDictionary getSudokuGameplayKnobs()
        {
            object val_1 = IsDynamicKnob(knobId:  1141222288);
            if("sudoku_gameplay" != 0)
            {
                    twelvegigs.storage.JsonDictionary val_2 = new twelvegigs.storage.JsonDictionary(parsedDictionary:  "sudoku_gameplay");
                return;
            }
            
            twelvegigs.storage.JsonDictionary val_3 = new twelvegigs.storage.JsonDictionary();
        }
        public twelvegigs.storage.JsonDictionary getWordPetsGameplayKnobs()
        {
            object val_1 = IsDynamicKnob(knobId:  1141334400);
            if("wordpets_gameplay" != 0)
            {
                    twelvegigs.storage.JsonDictionary val_2 = new twelvegigs.storage.JsonDictionary(parsedDictionary:  "wordpets_gameplay");
                return;
            }
            
            twelvegigs.storage.JsonDictionary val_3 = new twelvegigs.storage.JsonDictionary();
        }
        public twelvegigs.storage.JsonDictionary getMinigameKnobs()
        {
            object val_1 = IsDynamicKnob(knobId:  1141446512);
            if("minigame_data" != 0)
            {
                    twelvegigs.storage.JsonDictionary val_2 = new twelvegigs.storage.JsonDictionary(parsedDictionary:  "minigame_data");
                return;
            }
            
            twelvegigs.storage.JsonDictionary val_3 = new twelvegigs.storage.JsonDictionary();
        }
        public KnobsModel()
        {
        
        }
    
    }

}
