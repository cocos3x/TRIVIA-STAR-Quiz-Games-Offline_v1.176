using UnityEngine;

namespace SLC.Social.Leagues
{
    public class GuildMembers : Dictionary<int, SLC.Social.Profile>
    {
        // Methods
        public void UpdateMembers(System.Collections.Generic.List<object> guildMembers, EncodableModel.TemplateModel fromModel = 0, int excludeId = -1)
        {
            var val_3;
            var val_8;
            var val_9;
            List.Enumerator<T> val_1 = GetEnumerator();
            label_15:
            if(MoveNext() == false)
            {
                goto label_2;
            }
            
            val_8 = val_3;
            val_8 = 0;
            string val_4 = val_8.Item[1624646480];
            val_9 = 0;
            if(excludeId != 1)
            {
                    if( == excludeId)
            {
                goto label_15;
            }
            
            }
            
            SLC.Social.Profile val_5 = new SLC.Social.Profile();
            Decode(jasonObject:  0, sourceModel:  fromModel);
            if((this.ContainsKey(key:  1179403647)) == false)
            {
                goto label_12;
            }
            
            System.TimeType val_7 = this.Item[1179403647];
            if(this != 0)
            {
                goto label_15;
            }
            
            goto label_15;
            label_12:
            this.Add(key:  1179403647, value:  440360960);
            goto label_15;
            label_2:
            Dispose();
        }
        public void UpdateMembers(System.Collections.Generic.List<SLC.Social.Leagues.GuildJoinRequest> requests)
        {
            WordPets.WPTLetterTile val_6;
            List.Enumerator<T> val_1 = GetEnumerator();
            label_10:
            if(MoveNext() == false)
            {
                goto label_2;
            }
            
            if((this.ContainsKey(key:  val_3 + 8 + 8)) == false)
            {
                goto label_5;
            }
            
            System.TimeType val_5 = this.Item[val_3 + 8 + 8];
            if(this != 0)
            {
                goto label_10;
            }
            
            goto label_10;
            label_5:
            val_6 = val_3 + 8;
            if((val_3 + 8) == 0)
            {
                    val_6 = mem[val_3 + 8];
                val_6 = val_3 + 8;
            }
            
            this.Add(key:  val_3 + 8 + 8, value:  val_6);
            goto label_10;
            label_2:
            Dispose();
        }
        public override string ToString()
        {
            string val_1 = Newtonsoft.Json.JsonConvert.SerializeObject(value:  828827520);
            return System.String.Format(format:  828803408, arg0:  828827520);
        }
        public GuildMembers()
        {
        
        }
    
    }

}
