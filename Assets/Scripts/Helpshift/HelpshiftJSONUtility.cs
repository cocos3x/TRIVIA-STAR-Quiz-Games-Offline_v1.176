using UnityEngine;

namespace Helpshift
{
    public static class HelpshiftJSONUtility
    {
        // Methods
        public static Helpshift.HelpshiftUser getHelpshiftUser(string serializedJSONHelpshiftUser)
        {
            if(serializedJSONHelpshiftUser != null)
            {
                    object val_1 = Json.Parser.Parse(jsonString:  serializedJSONHelpshiftUser);
            }
            
            string val_2 = 0.Item[-1785499968];
            string val_3 = System.Convert.ToString(value:  0);
            string val_4 = 0.Item[-1931027184];
            string val_5 = System.Convert.ToString(value:  0);
            string val_6 = 0.Item[506038336];
            string val_7 = System.Convert.ToString(value:  0);
            string val_8 = 0.Item[1679334848];
            string val_9 = System.Convert.ToString(value:  0);
            typeof(HelpshiftUser.Builder).__il2cppRuntimeField_8 = 0;
            typeof(HelpshiftUser.Builder).__il2cppRuntimeField_C = 0;
            if(new System.Object() != 0)
            {
                    typeof(HelpshiftUser.Builder).__il2cppRuntimeField_10 = 0;
                typeof(HelpshiftUser.Builder).__il2cppRuntimeField_14 = 0;
                return build();
            }
            
            mem[16] = 0;
            mem[20] = 0;
            return build();
        }
        public static Helpshift.HelpshiftAuthFailureReason getAuthFailureReason(string serializedJSONAuthFailure)
        {
            var val_6;
            var val_7;
            if(serializedJSONAuthFailure == null)
            {
                goto label_2;
            }
            
            object val_1 = Json.Parser.Parse(jsonString:  serializedJSONAuthFailure);
            if(serializedJSONAuthFailure == null)
            {
                goto label_2;
            }
            
            val_6 = serializedJSONAuthFailure;
            goto label_7;
            label_2:
            label_7:
            val_6 = 0;
            string val_2 = val_6.Item[511420096];
            val_7 = 0;
            string val_3 = System.Convert.ToString(value:  0);
            if((Equals(value:  null)) == true)
            {
                    return;
            }
            
            bool val_5 = Equals(value:  null);
            val_7 = 1;
        }
        public static Helpshift.HelpshiftUserAction getUserActionData(string serializedUserActionData)
        {
            if(serializedUserActionData != null)
            {
                    object val_1 = Json.Parser.Parse(jsonString:  serializedUserActionData);
            }
            
            string val_2 = 0.Item[1603923024];
            string val_3 = System.Convert.ToString(value:  0);
            string val_4 = 0.Item[511540400];
            string val_5 = System.Convert.ToString(value:  0);
            object val_6 = new System.Object();
            typeof(Helpshift.HelpshiftUserAction).__il2cppRuntimeField_8 = 0;
            typeof(Helpshift.HelpshiftUserAction).__il2cppRuntimeField_C = 0;
        }
    
    }

}
