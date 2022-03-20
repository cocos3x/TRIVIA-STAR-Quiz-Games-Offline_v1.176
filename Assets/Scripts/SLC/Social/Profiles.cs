using UnityEngine;

namespace SLC.Social
{
    public class Profiles : Dictionary<int, SLC.Social.Profile>
    {
        // Methods
        public void Update(System.Collections.Generic.List<object> profiles, EncodableModel.TemplateModel fromModel = 0)
        {
            var val_3;
            var val_8;
            var val_9;
            List.Enumerator<T> val_1 = GetEnumerator();
            label_13:
            if(MoveNext() == false)
            {
                goto label_2;
            }
            
            val_8 = val_3;
            val_8 = 0;
            string val_4 = val_8.Item[-13068784];
            val_9 = 0;
            SLC.Social.Profile val_5 = new SLC.Social.Profile();
            Decode(jasonObject:  0, sourceModel:  fromModel);
            if((this.ContainsKey(key:  1179403647)) == false)
            {
                goto label_10;
            }
            
            System.TimeType val_7 = this.Item[1179403647];
            if(this != 0)
            {
                goto label_13;
            }
            
            goto label_13;
            label_10:
            this.Add(key:  1179403647, value:  440360960);
            goto label_13;
            label_2:
            Dispose();
        }
        public void AddProfile(int id, SLC.Social.Profile toAdd)
        {
            var val_4;
            var val_5;
            val_4 = this;
            val_5 = 35635929;
            if(toAdd == 0)
            {
                    return;
            }
            
            if((val_4.ContainsKey(key:  id)) != false)
            {
                    System.TimeType val_2 = val_4.Item[id];
                if(val_4 != 0)
            {
                goto typeof(SLC.Social.Profiles).__il2cppRuntimeField_F4;
            }
            
            }
            else
            {
                    this.Add(key:  id, value:  toAdd);
            }
        
        }
        public void RemoveKnownProfile(int id)
        {
            bool val_1 = this.Remove(key:  id);
        }
        public Profiles()
        {
        
        }
    
    }

}
