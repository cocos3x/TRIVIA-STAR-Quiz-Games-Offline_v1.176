using UnityEngine;

namespace SLC.Social.Leagues
{
    public class LeaguesUIChatView : MonoBehaviour
    {
        // Fields
        private UnityEngine.UI.Text chatTextBlock;
        private UnityEngine.UI.InputField textInput;
        private UnityEngine.UI.Button chatsButton;
        private UnityEngine.UI.Button logsButton;
        private UnityEngine.UI.Button sendButton;
        private UnityEngine.UI.Button retryButton;
        private UnityEngine.Color color_tag;
        private UnityEngine.Color color_text;
        private UnityEngine.Color color_log;
        private UnityEngine.Color color_unsent;
        private string hex_color_tag;
        private string hex_color_text;
        private string hex_color_log;
        private string hex_color_unsent;
        private bool showingChat;
        private bool blockSendMessages;
        private System.Collections.Generic.List<string> unsentMessages;
        private string reusableResult;
        private string reusableString;
        private string[] reusableSplit;
        
        // Methods
        private void Awake()
        {
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.unsentMessages = null;
        }
        private void Start()
        {
            UnityEngine.Color32 val_1 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color() {r = mem[this.color_tag + (0)], g = mem[this.color_tag + (4)], b = mem[this.color_tag + (8)], a = mem[this.color_tag + (12)]});
            string val_2 = MetricSystem.ColorToHex(color:  new UnityEngine.Color32() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.a});
            this.hex_color_tag = val_1.r;
            UnityEngine.Color32 val_3 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color() {r = this.color_text});
            string val_4 = MetricSystem.ColorToHex(color:  new UnityEngine.Color32() {r = val_3.r, g = val_3.g, b = val_3.b, a = val_3.a});
            this.hex_color_text = val_3.r;
            UnityEngine.Color32 val_5 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color() {r = this.color_log});
            string val_6 = MetricSystem.ColorToHex(color:  new UnityEngine.Color32() {r = val_5.r, g = val_5.g, b = val_5.b, a = val_5.a});
            this.hex_color_log = val_5.r;
            UnityEngine.Color32 val_7 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color() {r = this.color_unsent});
            string val_8 = MetricSystem.ColorToHex(color:  new UnityEngine.Color32() {r = val_7.r, g = val_7.g, b = val_7.b, a = val_7.a});
            this.hex_color_unsent = val_7.r;
            NotificationCenter val_9 = NotificationCenter.DefaultCenter;
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            0.AddObserver(observer:  847991888, name:  442544128);
            NotificationCenter val_10 = NotificationCenter.DefaultCenter;
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            0.AddObserver(observer:  847991888, name:  442544128);
            UnityEngine.Events.UnityAction val_11 = new UnityEngine.Events.UnityAction(object:  847991888, method:  new IntPtr(847926928));
            this.chatsButton.m_OnClick.AddListener(call:  162246656);
            UnityEngine.Events.UnityAction val_12 = new UnityEngine.Events.UnityAction(object:  847991888, method:  new IntPtr(847926928));
            this.logsButton.m_OnClick.AddListener(call:  162246656);
            UnityEngine.Events.UnityAction<UnityEngine.UI.LayoutRebuilder> val_13 = new UnityEngine.Events.UnityAction<UnityEngine.UI.LayoutRebuilder>(object:  847991888, method:  new IntPtr(847944336));
            this.textInput.m_OnValueChanged.AddListener(call:  162353152);
            UnityEngine.Events.UnityAction val_14 = new UnityEngine.Events.UnityAction(object:  847991888, method:  new IntPtr(847953552));
            this.sendButton.m_OnClick.AddListener(call:  162246656);
            UnityEngine.Events.UnityAction val_15 = new UnityEngine.Events.UnityAction(object:  847991888, method:  new IntPtr(847962768));
            this.retryButton.m_OnClick.AddListener(call:  162246656);
            this.retryButton.interactable = false;
        }
        private void OnMyGuildChatUpdate()
        {
            this.retryButton.interactable = false;
            this.blockSendMessages = false;
            this.SetTextBlock();
        }
        private void OnMyGuildLogsUpdate()
        {
            this.SetTextBlock();
        }
        private void OnEnable()
        {
            SLC.Social.Leagues.LeaguesDataController val_1 = SLC.Social.Leagues.LeaguesManager.DAO;
            GetGuildChat();
            this.SetTextBlock();
        }
        private void SetTextBlock()
        {
            var val_9;
            if(this.showingChat != false)
            {
                    val_9 = this;
                string val_1 = this.FormatChatMessages();
            }
            else
            {
                    val_9 = this;
                string val_2 = this.FormatLogMessages();
            }
            
            SLC.Social.Leagues.LeaguesDataController val_3 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Leagues.Guild val_4 = MyGuild;
            SLC.Social.Leagues.LeaguesDataController val_5 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Leagues.Guild val_6 = MyGuild;
            SLC.Social.Leagues.LeaguesDataController val_7 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Leagues.Guild val_8 = MyGuild;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            UnityEngine.PlayerPrefs.SetString(key:  848473232, value:  (SLC.Social.Leagues.LeaguesManager.__il2cppRuntimeField_element_size + 8 + ((SLC.Social.Leagues.LeaguesManager.__il2cppRuntimeField_element_size + 12 - 1)) << 2) + 16);
        }
        private string FormatChatMessages()
        {
            System.String[] val_6;
            object val_22;
            var val_23;
            System.String[] val_24;
            string val_25;
            this.reusableResult = "";
            this.reusableString = "";
            val_22 = 1152921505048485888;
            SLC.Social.Leagues.LeaguesDataController val_1 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Leagues.Guild val_2 = MyGuild;
            if(null == 0)
            {
                    return;
            }
            
            SLC.Social.Leagues.LeaguesDataController val_3 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Leagues.Guild val_4 = MyGuild;
            List.Enumerator<T> val_5 = GetEnumerator();
            val_23 = 1152921505085410800;
            goto label_10;
            label_40:
            val_24 = val_6;
            if((val_24.Contains(value:  -2100450224)) != false)
            {
                    typeof(System.Char[]).__il2cppRuntimeField_10 = 124;
                System.String[] val_8 = val_24.Split(separator:  478563824, count:  2);
                this.reusableSplit = val_24;
                val_22 = mem[val_6 + 20];
                val_22 = val_6 + 20;
                string val_9 = val_22.Trim();
                string val_10 = System.String.Format(format:  848593552, arg0:  this.hex_color_log, arg1:  val_22);
                val_25 = "<color=#{0}><i><b>{1}</b></i></color>\n\n";
            }
            else
            {
                    typeof(System.Char[]).__il2cppRuntimeField_10 = 58;
                System.String[] val_11 = val_24.Split(separator:  478563824, count:  2);
                this.reusableSplit = val_24;
                val_22 = this.hex_color_tag;
                val_24 = null;
                typeof(System.Object[]).__il2cppRuntimeField_10 = val_22;
                typeof(System.Object[]).__il2cppRuntimeField_14 = this.reusableSplit[0];
                typeof(System.Object[]).__il2cppRuntimeField_18 = this.hex_color_text;
                typeof(System.Object[]).__il2cppRuntimeField_1C = this.reusableSplit[1];
                string val_12 = System.String.Format(format:  848683824, args:  472754880);
                val_25 = "<color=#{0}>{1}:</color><color=#{2}>{3}</color>\n\n";
            }
            
            this.reusableString = val_25;
            string val_13 = this.reusableResult + 848683824;
            this.reusableResult = this.reusableResult;
            label_10:
            if(MoveNext() == true)
            {
                goto label_40;
            }
            
            Dispose();
            if(848724792 < 1)
            {
                    return;
            }
            
            List.Enumerator<T> val_15 = GetEnumerator();
            val_23 = "<color=#{0}>{1}: </color><color=#{2}>{3}</color>\n\n";
            goto label_44;
            label_62:
            val_22 = val_6;
            val_24 = null;
            typeof(System.Object[]).__il2cppRuntimeField_10 = this.hex_color_tag;
            SLC.Social.Leagues.LeaguesDataController val_16 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Profile val_17 = MyProfile;
            typeof(System.Object[]).__il2cppRuntimeField_14 = SLC.Social.Leagues.LeaguesManager.__il2cppRuntimeField_namespaze;
            typeof(System.Object[]).__il2cppRuntimeField_18 = this.hex_color_unsent;
            typeof(System.Object[]).__il2cppRuntimeField_1C = val_22;
            string val_18 = System.String.Format(format:  848696288, args:  472754880);
            this.reusableString = "<color=#{0}>{1}: </color><color=#{2}>{3}</color>\n\n";
            string val_19 = this.reusableResult + 848696288;
            this.reusableResult = this.reusableResult;
            label_44:
            if(MoveNext() == true)
            {
                goto label_62;
            }
            
            Dispose();
        }
        private string FormatLogMessages()
        {
            System.String[] val_4;
            var val_9;
            string val_10;
            this.reusableResult = "";
            this.reusableString = "";
            SLC.Social.Leagues.LeaguesDataController val_1 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Leagues.Guild val_2 = MyGuild;
            List.Enumerator<T> val_3 = GetEnumerator();
            goto label_6;
            label_27:
            typeof(System.Char[]).__il2cppRuntimeField_10 = 124;
            System.String[] val_5 = val_4.Split(separator:  478563824, count:  2);
            this.reusableSplit = val_4;
            val_9 = null;
            typeof(System.Object[]).__il2cppRuntimeField_10 = this.hex_color_tag;
            typeof(System.Object[]).__il2cppRuntimeField_14 = this.reusableSplit[0];
            typeof(System.Object[]).__il2cppRuntimeField_18 = this.hex_color_text;
            val_10 = this.reusableSplit[1];
            typeof(System.Object[]).__il2cppRuntimeField_1C = val_10;
            string val_6 = System.String.Format(format:  848947728, args:  472754880);
            this.reusableString = "<color=#{0}>{1}</color><color=#{2}>{3}</color>\n";
            string val_7 = this.reusableResult + 848947728;
            this.reusableResult = this.reusableResult;
            label_6:
            if(MoveNext() == true)
            {
                goto label_27;
            }
            
            Dispose();
        }
        private void ToggleChatsLogs()
        {
            bool val_4 = this.showingChat;
            val_4 = val_4 ^ 1;
            this.showingChat = val_4;
            UnityEngine.GameObject val_1 = this.logsButton.gameObject;
            this.logsButton.SetActive(value:  this.logsButton >> 5);
            UnityEngine.GameObject val_3 = this.chatsButton.gameObject;
            if(this.showingChat == true)
            {
                    this.showingChat = 1;
            }
            
            this.chatsButton.SetActive(value:  true);
            this.SetTextBlock();
        }
        private void OnChatTextEntered(string text)
        {
            System.Collections.Generic.List<System.String> val_2;
            UnityEngine.UI.Button val_3;
            var val_4;
            val_2 = 35635744;
            if(this.blockSendMessages == false)
            {
                goto label_3;
            }
            
            val_2 = this.unsentMessages;
            if(this.blockSendMessages < true)
            {
                goto label_3;
            }
            
            val_3 = this.sendButton;
            if(val_3 != 0)
            {
                goto label_5;
            }
            
            goto label_5;
            label_3:
            val_3 = this.sendButton;
            if((System.String.IsNullOrEmpty(value:  text)) == false)
            {
                goto label_7;
            }
            
            label_5:
            val_4 = 0;
            goto label_8;
            label_7:
            val_4 = 1;
            label_8:
            val_3.interactable = true;
        }
        private void SendChatMessage()
        {
            string val_1 = System.Text.RegularExpressions.Regex.Replace(input:  this.textInput.m_Text, pattern:  849537856, replacement:  1098586544);
            this.textInput.text = this.textInput.m_Text;
            if((System.String.IsNullOrEmpty(value:  this.textInput.m_Text)) != false)
            {
                    return;
            }
            
            SLC.Social.Leagues.LeaguesDataController val_3 = SLC.Social.Leagues.LeaguesManager.DAO;
            System.Action<System.Boolean, TRVQuizProgress> val_4 = new System.Action<System.Boolean, TRVQuizProgress>(object:  849595728, method:  new IntPtr(849554320));
            SendChatMessage(message:  this.textInput.m_Text, OnMessagerResponse:  7507968);
            this.unsentMessages.Add(item:  this.textInput.m_Text);
            this.textInput.text = 1098586544;
            this.SetTextBlock();
        }
        private void OnRetryMessage()
        {
            string val_3;
            this.retryButton.interactable = false;
            if(this.retryButton < 1)
            {
                    return;
            }
            
            List.Enumerator<T> val_1 = GetEnumerator();
            label_9:
            if(MoveNext() == false)
            {
                goto label_5;
            }
            
            SLC.Social.Leagues.LeaguesDataController val_4 = SLC.Social.Leagues.LeaguesManager.DAO;
            System.Action<System.Boolean, TRVQuizProgress> val_5 = new System.Action<System.Boolean, TRVQuizProgress>(object:  849760976, method:  new IntPtr(849554320));
            SendChatMessage(message:  val_3, OnMessagerResponse:  7507968);
            goto label_9;
            label_5:
            Dispose();
        }
        private void OnMessageResponse(bool success, string message)
        {
            System.Collections.Generic.List<System.String> val_3;
            System.Collections.Generic.List<System.String> val_4;
            var val_5;
            var val_6;
            val_3 = success;
            val_4 = this.unsentMessages;
            if(val_3 != false)
            {
                    bool val_1 = val_4.Remove(item:  message);
                return;
            }
            
            if(true < 1)
            {
                    return;
            }
            
            val_3 = this.unsentMessages;
            if(val_3 != 0)
            {
                    val_6 = true;
            }
            else
            {
                    val_6 = 0;
                val_5 = 0;
            }
            
            val_4 = -1;
            if(val_5 <= val_4)
            {
                    var val_3 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_3 = val_3 + 4294967292;
            if((System.String.op_Inequality(a:  (0 + 4294967292) + 16, b:  message)) != false)
            {
                    return;
            }
            
            this.retryButton.interactable = true;
            this.blockSendMessages = true;
            this.SetTextBlock();
        }
        public LeaguesUIChatView()
        {
            UnityEngine.Color val_1 = new UnityEngine.Color(r:  null, g:  null, b:  null, a:  null);
            UnityEngine.Color val_2 = new UnityEngine.Color(r:  null, g:  null, b:  null, a:  null);
            UnityEngine.Color val_3 = new UnityEngine.Color(r:  null, g:  null, b:  null, a:  null);
            UnityEngine.Color val_4 = new UnityEngine.Color(r:  null, g:  null, b:  null, a:  null);
            this.hex_color_unsent = "808080ff";
            this.showingChat = true;
            this.reusableResult = "";
            this.reusableString = "";
        }
    
    }

}
