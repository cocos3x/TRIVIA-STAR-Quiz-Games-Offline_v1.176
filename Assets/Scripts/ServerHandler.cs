using UnityEngine;
public class ServerHandler : DefaultHandler<ServerHandler>
{
    // Fields
    public const string ONSERVERRESPONDED = "OnServerResponded";
    public const string ONSERVERFAILED = "OnServerFailed";
    private bool inRequest;
    private bool _allowServerConnect;
    private static System.DateTime epocStart;
    private float _lastServerTimeUpate;
    private System.DateTime _serverTime;
    private System.Collections.Generic.List<Award> currentAwards;
    public const string awardKey = "awards_available";
    private System.Collections.Generic.List<MessageParams> _ParsedMessages;
    public const string ONSERVERIMPORTRESPONDED = "OnServerImportResponded";
    public const string ONSERVERIMPORTFAILED = "OnServerImportFailed";
    private static bool initialized;
    private const string missed_msgs_key = "missed_messages";
    
    // Properties
    public bool InRequesting { get; }
    public bool AllowServerConnection { get; }
    public static System.DateTime ServerTime { get; }
    public static int UnixServerTime { get; }
    public static System.Collections.Generic.List<Award> Awards { get; }
    public System.Collections.Generic.List<MessageParams> ParsedMessages { get; }
    
    // Methods
    public bool get_InRequesting()
    {
        return (bool)this.inRequest;
    }
    public bool get_AllowServerConnection()
    {
        return (bool)this._allowServerConnect;
    }
    public static System.DateTime get_ServerTime()
    {
        WGBonusRewardsHandler val_1 = DefaultHandler<WGBonusRewardsHandler>.Instance;
        float val_2 = UnityEngine.Time.unscaledTime;
        WGBonusRewardsHandler val_3 = DefaultHandler<WGBonusRewardsHandler>.Instance;
        float val_4 = 0 - (public static ServerHandler DefaultHandler<ServerHandler>::get_Instance().__il2cppRuntimeField_10);
        System.DateTime val_5 = 0.AddSeconds(value:  null);
        return new System.DateTime() {dateData = val_5.dateData};
    }
    public static int get_UnixServerTime()
    {
        var val_5;
        System.DateTime val_1 = ServerHandler.ServerTime;
        System.TimeSpan val_4 = Subtract(value:  new System.DateTime() {dateData = 1152921511372402232});
        double val_7 = val_5.TotalSeconds;
        if(ServerHandler.__il2cppRuntimeField_cctor_finished == 0)
        {
                2470587952 = 2470587952;
        }
        
        return (int)S0;
    }
    public void RequestDataFlush(bool immediate = False, bool reset = False)
    {
        twelvegigs.net.JsonApiRequester val_24;
        float val_25;
        var val_26;
        var val_27;
        var val_28;
        var val_29;
        System.Action<System.Threading.Tasks.Task, System.Object> val_30;
        var val_31;
        var val_32;
        var val_33;
        var val_34;
        val_24 = this;
        val_25 = immediate;
        var val_24 = 27819010;
        val_24 = 7807048 + val_24;
        if(val_24 == 0)
        {
                mem2[0] = 1;
        }
        
        val_26 = null;
        val_26 = null;
        if(App.networkManager == 0)
        {
                return;
        }
        
        if(this.inRequest != false)
        {
                if(val_25 == false)
        {
                return;
        }
        
        }
        
        if(val_24 == 0)
        {
                mem2[0] = 1;
        }
        
        val_27 = null;
        val_27 = null;
        if(App.networkManager.Reachable() == false)
        {
                return;
        }
        
        Player val_2 = val_24.Player;
        val_28 = 1152921504896356352;
        val_29 = null;
        val_29 = null;
        if((System.String.op_Inequality(a:  -1824252240, b:  DeviceIdPlugin.UNIDENTIFIABLE_ANDROID_DEVICE)) == false)
        {
                return;
        }
        
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_4 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        val_30 = null;
        val_30 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  -1824252240, method:  new IntPtr(2470689008));
        if(val_25 != false)
        {
                Add(key:  -1824277264, value:  8945664);
            val_30 = 0;
        }
        else
        {
                this.inRequest = true;
        }
        
        if(reset != false)
        {
                Add(key:  -1824277168, value:  8945664);
        }
        
        Player val_6 = val_24.Player;
        if((this.Equals(value:  1297836560)) != false)
        {
                val_25 = "/api/users";
            var val_25 = 27819579;
            val_25 = 7807836 + val_25;
            if(val_25 == 0)
        {
                mem2[0] = 1;
        }
        
            val_31 = null;
            val_31 = null;
            object val_8 = App.storageManager.EncodeInitialVersions();
            val_28 = 1152921510535002416;
            Add(key:  -1824276976, value:  App.storageManager);
            Player val_9 = val_24.Player;
            Add(key:  -1824276880, value:  -1824252240);
            Player val_10 = val_24.Player;
            Add(key:  -1824276800, value:  -1824252240);
            Player val_11 = val_24.Player;
            object val_12 = this.GetDeviceProperties();
            Add(key:  -1824276720, value:  -1824252240);
            Add(key:  -1824276608, value:  8945664);
            AddFacebookParameters(parameters: ref  System.Collections.Generic.Dictionary<System.String, System.Object> val_13 = -1824264280);
            val_32 = null;
            val_32 = null;
            val_24 = App.networkManager;
            val_24.DoPost(path:  -1824277072, postBody:  78753792, onCompleteFunction:  7507968, timeout:  20, destroy:  false, immediate:  false, serverType:  0);
            return;
        }
        
        Player val_14 = val_24.Player;
        string val_15 = -1824276512(-1824276512) + -1824279312(-1824279312);
        var val_26 = 27818835;
        val_26 = 7808580 + val_26;
        if(val_26 == 0)
        {
                mem2[0] = 1;
        }
        
        val_33 = null;
        val_33 = null;
        object val_16 = App.storageManager.EncodeInitialVersions();
        Add(key:  -1824276976, value:  App.storageManager);
        Player val_17 = val_24.Player;
        System.Collections.Generic.Dictionary<System.String, System.Object> val_18 = this.Encode();
        Player val_19 = val_24.Player;
        Add(key:  -1824276880, value:  -1824252240);
        Add(key:  -1824276416, value:  -1824252240);
        Player val_20 = val_24.Player;
        val_28 = val_30;
        Add(key:  -1824276800, value:  -1824252240);
        Player val_21 = val_24.Player;
        object val_22 = this.GetDeviceProperties();
        val_24 = 1152921510535002416;
        Add(key:  -1824276720, value:  -1824252240);
        if(null != 0)
        {
                Add(key:  -1824276608, value:  8945664);
        }
        else
        {
                Add(key:  -1824276608, value:  8945664);
        }
        
        Add(key:  -1824276336, value:  1466317008);
        AddFacebookParameters(parameters: ref  System.Collections.Generic.Dictionary<System.String, System.Object> val_23 = -1824264280);
        val_34 = null;
        val_34 = null;
        App.networkManager.DoPut(path:  -1824276512, postBody:  78753792, onCompleteFunction:  7507968, timeout:  20, destroy:  false, immediate:  val_25);
    }
    public virtual void InjectAdditionalPlayerData(ref System.Collections.Generic.Dictionary<string, object> encodedPlayerData)
    {
        Player val_1 = this.Player;
        encodedPlayerData.Add(key:  -1857215008, value:  -1824136144);
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1929661328) == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Collections.Generic.Dictionary<System.String, System.Int32> val_5 = SerializeUnlockedPets();
        string val_6 = MiniJSON.Json.Serialize(obj:  -1929661328);
        encodedPlayerData.Add(key:  -1824160224, value:  -1929661328);
    }
    private void OnRequestResponse(string method, System.Collections.Generic.Dictionary<string, object> response)
    {
        var val_10;
        var val_11;
        var val_12;
        this.inRequest = false;
        if(response == 0)
        {
            goto label_15;
        }
        
        if((response.ContainsKey(key:  -1824035936)) != false)
        {
                this._allowServerConnect = false;
            UnityEngine.Debug.LogWarning(message:  -1824035840);
        }
        
        if((response.ContainsKey(key:  -1824035680)) == false)
        {
            goto label_15;
        }
        
        object val_3 = response.Item[-1824035680];
        if(response == 0)
        {
            goto label_6;
        }
        
        val_10 = null;
        if(response == 0)
        {
            goto label_8;
        }
        
        val_11 = response;
        goto label_9;
        label_6:
        val_10 = null;
        goto label_10;
        label_8:
        label_10:
        val_11 = 0;
        label_9:
        if(mem[1179403825] == 0)
        {
            goto label_11;
        }
        
        var val_10 = 0;
        label_13:
        if((mem[1179403735] + 0) == val_10)
        {
            goto label_12;
        }
        
        val_10 = val_10 + 1;
        if(((uint)val_10 & 65535) < mem[1179403825])
        {
            goto label_13;
        }
        
        label_11:
        val_12 = val_11;
        goto label_14;
        label_12:
        var val_4 = mem[1179403735] + 0;
        val_11 = val_11 + (((mem[1179403735] + 0) + 4) << 3);
        val_12 = val_11 + 220;
        label_14:
        if(val_11 != 0)
        {
                typeof(System.Char[]).__il2cppRuntimeField_10 = 47;
            System.String[] val_5 = method.Split(separator:  478563824);
            if((System.String.op_Equality(a:  method + 32, b:  -1824035600)) == false)
        {
                return;
        }
        
            this.UpdatedFromServer(serverResponse:  response, forceUpdate:  false);
            NotificationCenter val_7 = NotificationCenter.DefaultCenter;
            val_10 = 0;
            System.Collections.Hashtable val_8 = new System.Collections.Hashtable();
            val_10.PostNotification(aSender:  -1824011424, aName:  -1976323520, aData:  75878400);
            return;
        }
        
        label_15:
        NotificationCenter val_9 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  -1824011424, aName:  -1824035520);
    }
    public void UpdatedFromServer(System.Collections.Generic.Dictionary<string, object> serverResponse, bool forceUpdate = False)
    {
        System.DateTime val_11;
        var val_23;
        var val_29;
        var val_30;
        var val_31;
        var val_32;
        Player val_1 = App.Player;
        val_29 = 0;
        mem[13] = forceUpdate;
        if((serverResponse.ContainsKey(key:  -1824276416)) != false)
        {
                object val_3 = serverResponse.Item[-1824276416];
            val_30 = 0;
            if(serverResponse != 0)
        {
                if(((System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                serverResponse = 0;
        }
        
            val_30 = serverResponse;
        }
        
            this.UpdateUserData(userData:  0);
        }
        
        this.UpdateFeatures(response:  serverResponse);
        var val_29 = 27815607;
        val_29 = 7811808 + val_29;
        if(val_29 == 0)
        {
                mem2[0] = 1;
        }
        
        val_31 = null;
        val_31 = null;
        App.storageManager.OnDataUpdate(response:  serverResponse);
        val_32 = "srv_time";
        if((serverResponse.ContainsKey(key:  -1823911136)) != false)
        {
                object val_5 = serverResponse.Item[-1823911136];
            string val_6 = serverResponse.ToString();
            val_32 = 0;
            decimal val_7 = System.Decimal.Parse(s:  -1823899104);
            System.DateTime val_9 = twelvegigs.storage.JsonDictionary.ConvertToUTC(timestamp:  new System.Decimal() {flags = -1823899112});
            this._serverTime = val_11;
            float val_12 = UnityEngine.Time.unscaledTime;
            this._lastServerTimeUpate = 0f;
            System.DateTime val_13 = System.DateTime.UtcNow;
            System.DateTime val_16 = ServerHandler.ServerTime;
            System.TimeSpan val_19 = Subtract(value:  new System.DateTime() {dateData = 1152921511372882488});
            System.TimeSpan val_22 = Duration();
            double val_25 = val_23.TotalHours;
            CompanyDevices val_26 = CompanyDevices.Instance;
            bool val_27 = 0.CompanyDevice();
        }
        
        Player val_28 = App.Player;
        0.SaveState();
    }
    private void UpdateUserData(System.Collections.IDictionary userData)
    {
        Player val_1 = this.Player;
        this.UpdateData(diff:  userData);
    }
    public static System.Collections.Generic.List<Award> get_Awards()
    {
        WGBonusRewardsHandler val_1 = DefaultHandler<WGBonusRewardsHandler>.Instance;
        if((public static ServerHandler DefaultHandler<ServerHandler>::get_Instance()) != 0)
        {
                return;
        }
    
    }
    public void AddAward(Award award)
    {
        int val_1;
        string val_2;
        string val_3;
        int val_4;
        string val_5;
        string val_6;
        val_1 = award.amount.hi;
        val_2 = award.kind;
        val_3 = award.id;
        val_1 = val_1;
        val_4 = award.amount.flags;
        val_5 = val_3;
        val_6 = val_2;
        if(this.currentAwards == 0)
        {
                val_2 = val_6;
            val_3 = val_5;
            val_1 = val_1;
            val_5 = val_3;
            val_4 = val_4;
            val_6 = val_2;
        }
        
        this.currentAwards.Add(item:  new Award() {id = val_5, kind = val_6, amount = new System.Decimal() {flags = val_4, hi = val_1, lo = award.amount.lo, mid = award.amount.mid}, text = award.text});
        this.SaveCurrent();
    }
    public void RefreshAwards()
    {
        bool val_2;
        int val_3;
        string val_4;
        string val_5;
        int val_6;
        int val_7;
        val_2 = static_value_021FA873;
        if(val_2 != true)
        {
                val_2 = true;
        }
        
        System.Collections.Generic.List<Award> val_1 = this.ParseCurrent();
        if(50331648 < 1)
        {
                return;
        }
        
        var val_5 = 0;
        var val_4 = 0;
        do
        {
            if(50331648 <= val_4)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            var val_3 = 0;
            val_3 = val_3 + val_5;
            var val_2 = val_3 + 16;
            val_7 = mem[(0 + 0) + 36];
            val_7 = (0 + 0) + 36;
            if(mem[1152921511373364064] == 0)
        {
                val_3 = mem[((0 + 0) + 16) + (12)];
            val_7 = val_7;
            val_6 = mem[((0 + 0) + 16) + (8)];
            val_5 = mem[((0 + 0) + 16) + (4)];
            val_4 = mem[((0 + 0) + 16) + (0)];
        }
        
            mem[1152921511373364064].Add(item:  new Award() {id = val_4, kind = val_5, amount = new System.Decimal() {flags = val_6, hi = val_3, lo = (0 + 0) + 32, mid = val_7}, text = (0 + 0) + 40});
            val_4 = val_4 + 1;
            val_5 = val_5 + 28;
        }
        while(val_4 < 50331648);
    
    }
    public void CashOutAward(string id)
    {
        string val_3;
        int val_4;
        int val_5;
        int val_6;
        if((mem[1152921511373481184] + 12) < 1)
        {
                return;
        }
        
        var val_4 = 0;
        var val_5 = 0;
        val_3 = 0;
        val_4 = 0;
        val_5 = 0;
        val_6 = 0;
        label_7:
        if(val_5 >= (mem[1152921511373481184] + 12))
        {
            goto label_4;
        }
        
        if((mem[1152921511373481184] + 12) <= val_5)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_3 = mem[1152921511373481184] + 8;
        val_3 = val_3 + val_4;
        val_3 = mem[(mem[1152921511373481184] + 8 + 0) + 16];
        val_3 = (mem[1152921511373481184] + 8 + 0) + 16;
        val_4 = mem[(mem[1152921511373481184] + 8 + 0) + 28];
        val_4 = (mem[1152921511373481184] + 8 + 0) + 28;
        val_5 = mem[(mem[1152921511373481184] + 8 + 0) + 32];
        val_5 = (mem[1152921511373481184] + 8 + 0) + 32;
        val_6 = mem[(mem[1152921511373481184] + 8 + 0) + 36];
        val_6 = (mem[1152921511373481184] + 8 + 0) + 36;
        val_4 = val_4 + 28;
        val_5 = val_5 + 1;
        if((System.String.op_Equality(a:  id, b:  val_3)) == false)
        {
            goto label_7;
        }
        
        label_4:
        if((mem[1152921511373481184].Contains(item:  new Award() {id = val_3, kind = (mem[1152921511373481184] + 8 + 0) + 20, amount = new System.Decimal() {flags = (mem[1152921511373481184] + 8 + 0) + 24, hi = val_4, lo = val_5, mid = val_6}, text = (mem[1152921511373481184] + 8 + 0) + 40})) == false)
        {
                return;
        }
        
        this.CashAward(current:  new Award() {id = val_3, kind = (mem[1152921511373481184] + 8 + 0) + 20, amount = new System.Decimal() {flags = (mem[1152921511373481184] + 8 + 0) + 24, hi = val_4, lo = val_5, mid = val_6}, text = (mem[1152921511373481184] + 8 + 0) + 40});
    }
    private void CashAward(Award current)
    {
        this.RewardPlayer(theType:  current.kind, amount:  new System.Decimal() {flags = current.amount.flags, hi = current.amount.hi, lo = current.amount.lo, mid = current.amount.mid}, sourceOfReward:  "Award");
        bool val_1 = this.currentAwards.Remove(item:  new Award() {id = current.id, kind = current.kind, amount = new System.Decimal() {flags = current.amount.flags, hi = current.amount.hi, lo = current.amount.lo, mid = current.amount.mid}, text = current.text});
        this.SaveCurrent();
    }
    private void AddFacebookParameters(ref System.Collections.Generic.Dictionary<string, object> parameters)
    {
        string val_1 = UnityEngine.PlayerPrefs.GetString(key:  -1993112272, defaultValue:  1788750208);
        if((System.String.op_Equality(a:  -1993112272, b:  1788750208)) == true)
        {
                return;
        }
        
        if((System.String.op_Equality(a:  -1993112272, b:  -1993112160)) == true)
        {
                return;
        }
        
        string val_4 = UnityEngine.PlayerPrefs.GetString(key:  -1823081984, defaultValue:  1788750208);
        if((System.String.op_Inequality(a:  -1823081984, b:  1788750208)) != false)
        {
                return;
        }
        
        parameters.Add(key:  -1823081856, value:  -1993112272);
        UnityEngine.PlayerPrefs.SetString(key:  -1823081984, value:  -1993112160);
    }
    private void UpdateFeatures(System.Collections.Generic.Dictionary<string, object> response)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = 35629175;
        if(response == 0)
        {
                return;
        }
        
        val_4 = "user";
        if((response.ContainsKey(key:  -1824276416)) == false)
        {
                return;
        }
        
        object val_2 = response.Item[-1824276416];
        val_5 = 0;
        if(response != 0)
        {
                if(((System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                response = 0;
        }
        
            val_5 = response;
        }
        
        this.ProcessAwards(userFromServer:  0);
        this.ProcessMessages(userFromServer:  0);
    }
    public System.Collections.Generic.List<MessageParams> get_ParsedMessages()
    {
    
    }
    private void ProcessMessages(System.Collections.Generic.Dictionary<string, object> userFromServer)
    {
        var val_13;
        var val_14;
        PromptType val_15;
        if((userFromServer.ContainsKey(key:  -1822721264)) == false)
        {
                return;
        }
        
        object val_2 = userFromServer.Item[-1822721264];
        val_13 = 0;
        List.Enumerator<T> val_3 = GetEnumerator();
        label_31:
        if(MoveNext() == false)
        {
            goto label_10;
        }
        
        string val_6 = 0.Item[-1822721168];
        val_14 = 0;
        if(0 != 0)
        {
                if(1179403647 != null)
        {
            
        }
        else
        {
                val_14 = 0;
        }
        
        }
        
        System.Type val_7 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(291106816)});
        string val_8 = 0.Item[-1822721088];
        object val_9 = System.Enum.Parse(enumType:  291106816, value:  null);
        val_15 = 0;
        string val_10 = 0.Item[-1822721008];
        MessageParams val_12 = new MessageParams(message:  null, prompt:  null, localize:  System.Boolean.Parse(value:  null));
        mem[1152921511374085700].Add(item:  291160064);
        goto label_31;
        label_10:
        Dispose();
        ServerHandler.SaveQueuedToPlayerPrefs(queuedMessages:  mem[1152921511374085700]);
    }
    public void HackAGoddamnAward(Award awerd)
    {
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_2 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  -1822603808, value:  awerd.kind);
        Add(key:  -1822603728, value:  10170368);
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_3 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        Add(item:  78753792);
        Add(key:  -1822603648, value:  80883712);
        this.ProcessAwards(userFromServer:  78753792);
    }
    public void HackMultipleGoddamnAwards(System.Collections.Generic.List<Award> awerds)
    {
        WordPets.WPTPetTile val_4;
        var val_9;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        List.Enumerator<T> val_3 = GetEnumerator();
        goto label_2;
        label_6:
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_6 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  -1822603808, value:  val_4);
        val_9 = null;
        Add(key:  -1822603728, value:  10170368);
        Add(item:  78753792);
        label_2:
        if(MoveNext() == true)
        {
            goto label_6;
        }
        
        Dispose();
        Add(key:  -1822603648, value:  80883712);
        this.ProcessAwards(userFromServer:  78753792);
    }
    private void ProcessAwards(System.Collections.Generic.Dictionary<string, object> userFromServer)
    {
        int val_16;
        var val_18;
        var val_23;
        var val_28;
        var val_33;
        var val_42;
        var val_43;
        var val_47;
        var val_48;
        var val_49;
        var val_50;
        var val_51;
        var val_52;
        if((userFromServer.ContainsKey(key:  -1822603648)) == false)
        {
            goto label_2;
        }
        
        object val_2 = userFromServer.Item[-1822603648];
        System.Collections.Generic.List<Award> val_3 = userFromServer.ParseCurrent();
        mem[1152921511374441488] = userFromServer;
        var val_42 = 0;
        val_42 = val_42 + 1;
        val_42 = userFromServer;
        goto label_9;
        label_20:
        val_43 = mem[mem[1179403735] + 0];
        val_43 = mem[1179403735] + 0;
        if(val_43 == null)
        {
            goto label_19;
        }
        
         =  + 1;
        val_43 = (uint) & 65535;
        if(val_43 < mem[1179403825])
        {
            goto label_20;
        }
        
        val_47 = ;
        goto label_21;
        label_19:
        var val_6 = mem[1179403735] + 0;
         =  + (((mem[1179403735] + 0) + 4) << 3);
        val_47 =  + 188;
        label_21:
        if((System.String.op_Equality(a:  null, b:  -1988561632)) == false)
        {
            goto label_23;
        }
        
        GameBehavior val_8 = App.getBehavior;
        val_48 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_28;
        }
        
        var val_44 = 0;
        label_30:
        val_43 = 0;
        if((mem[1179403735] + 0) == null)
        {
            goto label_29;
        }
        
        val_44 = val_44 + 1;
        val_43 = (uint)val_44 & 65535;
        if(val_43 < mem[1179403825])
        {
            goto label_30;
        }
        
        label_28:
        val_49 = ;
        goto label_31;
        label_23:
        if((System.String.op_Equality(a:  null, b:  -1953369568)) == false)
        {
            goto label_32;
        }
        
        AdsManager.HandlePurchase();
        var val_51 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_36;
        }
        
        var val_45 = 0;
        label_38:
        if((mem[1179403735] + 0) == null)
        {
            goto label_37;
        }
        
        val_45 = val_45 + 1;
        if(((uint)val_45 & 65535) < mem[1179403825])
        {
            goto label_38;
        }
        
        label_36:
        val_50 = ;
        goto label_39;
        label_32:
        if((System.String.op_Equality(a:  null, b:  -1930648224)) == false)
        {
            goto label_40;
        }
        
        if(mem[1179403825] == 0)
        {
            goto label_45;
        }
        
        var val_46 = 0;
        label_44:
        if((mem[1179403735] + 0) == null)
        {
            goto label_43;
        }
        
        val_46 = val_46 + 1;
        if(((uint)val_46 & 65535) < mem[1179403825])
        {
            goto label_44;
        }
        
        goto label_45;
        label_29:
        var val_11 = mem[1179403735] + 0;
        val_48 = val_48 + (((mem[1179403735] + 0) + 4) << 3);
        val_49 = val_48 + 188;
        label_31:
        int val_12 = System.Int32.Parse(s:  null);
        var val_48 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_49;
        }
        
        var val_47 = 0;
        label_51:
        val_43 = 0;
        if((mem[1179403735] + 0) == null)
        {
            goto label_50;
        }
        
        val_47 = val_47 + 1;
        val_43 = (uint)val_47 & 65535;
        if(val_43 < mem[1179403825])
        {
            goto label_51;
        }
        
        label_49:
        val_51 = ;
        goto label_52;
        label_50:
        var val_13 = mem[1179403735] + 0;
        val_48 = val_48 + (((mem[1179403735] + 0) + 4) << 3);
        val_51 = val_48 + 188;
        label_52:
        var val_49 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_55;
        }
        
        val_43 = 0;
        label_57:
        if((mem[1179403735] + 0) == null)
        {
            goto label_56;
        }
        
        val_43 = val_43 + 1;
        if(((uint)val_43 & 65535) < mem[1179403825])
        {
            goto label_57;
        }
        
        label_55:
        val_52 = ;
        goto label_58;
        label_56:
        var val_14 = mem[1179403735] + 0;
        val_49 = val_49 + (((mem[1179403735] + 0) + 4) << 3);
        val_52 = val_49 + 188;
        label_58:
        decimal val_15 = System.Decimal.Parse(s:  -1822352184, style:  0);
        System.DateTime val_17 = System.DateTime.Now;
        string val_21 = val_18.Year.ToString();
        typeof(System.Object[]).__il2cppRuntimeField_10 = ;
        typeof(System.Object[]).__il2cppRuntimeField_14 = "-";
        System.DateTime val_22 = System.DateTime.Now;
        string val_26 = val_23.Month.ToString(format:  -1827641632);
        typeof(System.Object[]).__il2cppRuntimeField_18 = ;
        typeof(System.Object[]).__il2cppRuntimeField_1C = "-";
        System.DateTime val_27 = System.DateTime.Now;
        string val_31 = val_28.Day.ToString(format:  -1827641632);
        typeof(System.Object[]).__il2cppRuntimeField_20 = ;
        typeof(System.Object[]).__il2cppRuntimeField_24 = "_";
        System.DateTime val_32 = System.DateTime.Now;
        int val_35 = val_33.Millisecond;
        typeof(System.Object[]).__il2cppRuntimeField_28 = null;
        typeof(System.Object[]).__il2cppRuntimeField_2C = "-";
        string val_37 = UnityEngine.Random.Range(min:  0, max:  999999999).ToString();
        typeof(System.Object[]).__il2cppRuntimeField_30 = ;
        string val_38 = +472754880;
        mem[1152921511374441488].Add(item:  new Award() {id = 472754880, amount = new System.Decimal() {flags = val_16}});
        goto label_93;
        label_40:
        if((System.String.op_Equality(a:  null, b:  -1827757920)) == false)
        {
            goto label_94;
        }
        
        Player val_40 = App.Player;
        if(mem[1179403825] == 0)
        {
            goto label_102;
        }
        
        var val_50 = 0;
        label_101:
        if((mem[1179403735] + 0) == null)
        {
            goto label_100;
        }
        
        val_50 = val_50 + 1;
        if(((uint)val_50 & 65535) < mem[1179403825])
        {
            goto label_101;
        }
        
        goto label_102;
        label_37:
        var val_41 = mem[1179403735] + 0;
        val_51 = val_51 + (((mem[1179403735] + 0) + 4) << 3);
        val_50 = val_51 + 188;
        label_39:
        if(mem[1179403825] == 0)
        {
            goto label_108;
        }
        
        var val_52 = 0;
        label_107:
        if((mem[1179403735] + 0) == null)
        {
            goto label_106;
        }
        
        val_52 = val_52 + 1;
        if(((uint)val_52 & 65535) < mem[1179403825])
        {
            goto label_107;
        }
        
        goto label_108;
    }
    public void ProcessCommand(string cmd)
    {
        var val_26;
        var val_27;
        var val_28;
        var val_29;
        var val_30;
        var val_31;
        var val_32;
        var val_33;
        var val_34;
        var val_35;
        object val_1 = MiniJSON.Json.Deserialize(json:  cmd);
        val_26 = 0;
        if((0.ContainsKey(key:  -1822243920)) != false)
        {
                string val_3 = 0.Item[-1822243920];
            val_26 = 0;
            if(0 != 0)
        {
                if(1179403647 != null)
        {
            
        }
        else
        {
                val_26 = 0;
        }
        
        }
        
        }
        
        val_27 = 0;
        if((0.ContainsKey(key:  -1822243840)) != false)
        {
                string val_5 = 0.Item[-1822243840];
            val_27 = 0;
            if(0 != 0)
        {
                if(1179403647 != null)
        {
            
        }
        else
        {
                val_27 = 0;
        }
        
        }
        
        }
        
        val_28 = "prms";
        val_29 = 0;
        if((0.ContainsKey(key:  -1822243760)) != false)
        {
                string val_7 = 0.Item[-1822243760];
            if(0 != 0)
        {
                val_30 = 0;
        }
        
            val_30 = 0;
            T[] val_8 = val_30.ToArray();
            val_29 = val_30;
        }
        
        var val_26 = 22039422;
        val_26 = 7834288 + val_26;
        System.Type val_9 = System.Type.GetType(typeName:  null);
        val_31 = val_26;
        if(val_26 == 0)
        {
                System.Type val_10 = System.Type.GetType(typeName:  null);
            val_31 = val_26;
            if(val_26 == 0)
        {
                val_31 = 0;
        }
        
        }
        
        System.Reflection.MethodInfo val_11 = val_31.GetMethod(name:  null, bindingAttr:  124);
        System.Type val_12 = System.Type.GetType(typeName:  null);
        val_32 = val_26;
        if(val_26 == 0)
        {
                System.Type val_13 = System.Type.GetType(typeName:  null);
            val_32 = val_26;
            if(val_26 == 0)
        {
                val_32 = 0;
        }
        
        }
        
        System.Reflection.PropertyInfo val_14 = val_32.GetProperty(name:  -1822242656, bindingAttr:  124);
        if((System.Reflection.MethodInfo.op_Inequality(left:  0, right:  0)) != false)
        {
                if(val_31.IsStatic != false)
        {
                object val_17 = val_31.Invoke(obj:  0, parameters:  null);
            return;
        }
        
        }
        
        if((System.Reflection.PropertyInfo.op_Inequality(left:  0, right:  0)) != false)
        {
                object val_19 = val_31.Invoke(obj:  0, parameters:  null);
            return;
        }
        
        var val_27 = 22039002;
        val_27 = 7834708 + val_27;
        System.Type val_20 = System.Type.GetType(typeName:  null);
        val_33 = val_26;
        if(val_26 == 0)
        {
                System.Type val_21 = System.Type.GetType(typeName:  null);
            val_33 = val_26;
        }
        
        System.Type val_22 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(157880320)});
        if(val_33 == 0)
        {
                return;
        }
        
        var val_28 = 22038850;
        val_28 = 7834860 + val_28;
        System.Type val_23 = System.Type.GetType(typeName:  null);
        val_34 = val_26;
        if(val_26 == 0)
        {
                System.Type val_24 = System.Type.GetType(typeName:  null);
            val_34 = val_26;
        }
        
        UnityEngine.Object val_25 = UnityEngine.Object.FindObjectOfType(type:  0);
        if(val_34 != 0)
        {
                val_35 = 0;
        }
        else
        {
                val_35 = 0;
        }
        
        val_35.SendMessage(methodName:  null);
    }
    private System.Collections.Generic.List<Award> ParseCurrent()
    {
        int val_14;
        int val_15;
        int val_16;
        int val_17;
        var val_21;
        var val_22;
        var val_23;
        var val_24;
        string val_25;
        var val_26;
        var val_27;
        var val_28;
        var val_29;
        var val_30;
        var val_31;
        var val_32;
        var val_33;
        var val_34;
        var val_35;
        var val_36;
        var val_37;
        System.Collections.Generic.List<Award> val_1 = new System.Collections.Generic.List<Award>();
        string val_2 = UnityEngine.PlayerPrefs.GetString(key:  -1822125440, defaultValue:  -2141227328);
        object val_3 = MiniJSON.Json.Deserialize(json:  -1822125440);
        string val_26 = "awards_available";
        if(null == 0)
        {
            goto label_2;
        }
        
        var val_25 = 0;
        label_4:
        val_21 = 0;
        if(1179403647 == null)
        {
            goto label_3;
        }
        
        val_25 = val_25 + 1;
        val_21 = (uint)val_25 & 65535;
        if(val_21 < null)
        {
            goto label_4;
        }
        
        label_2:
        val_22 = "awards_available";
        goto label_5;
        label_3:
        var val_4 = 0 + 0;
        val_26 = val_26 + (((0 + 0) + 4) << 3);
        val_22 = val_26 + 188;
        label_5:
        label_84:
        string val_27 = "awards_available";
        if(null == null)
        {
            goto label_7;
        }
        
        val_21 = 0;
        label_9:
        if(1179403647 == null)
        {
            goto label_8;
        }
        
        val_21 = val_21 + 1;
        if(((uint)val_21 & 65535) < null)
        {
            goto label_9;
        }
        
        label_7:
        val_23 = "awards_available";
        goto label_10;
        label_8:
        var val_5 = val_25 + 0;
        val_27 = val_27 + (((0 + 0) + 4) << 3);
        val_23 = val_27 + 188;
        label_10:
        if("awards_available" == 0)
        {
            goto label_11;
        }
        
        string val_29 = "awards_available";
        if(null == null)
        {
            goto label_13;
        }
        
        var val_28 = 0;
        label_15:
        if(1179403647 == null)
        {
            goto label_14;
        }
        
        val_28 = val_28 + 1;
        if(((uint)val_28 & 65535) < null)
        {
            goto label_15;
        }
        
        label_13:
        val_24 = "awards_available";
        goto label_16;
        label_14:
        var val_6 = val_25 + 0;
        val_29 = val_29 + (((0 + 0) + 4) << 3);
        val_24 = val_29 + 196;
        label_16:
        if("awards_available" == 0)
        {
            goto label_17;
        }
        
        val_25 = "awards_available";
        if("awards_available" == 0)
        {
            goto label_18;
        }
        
        val_26 = 0;
        goto label_19;
        label_18:
        label_17:
        val_25 = 0;
        val_26 = 1;
        label_19:
        if(mem[1179403825] == 0)
        {
            goto label_20;
        }
        
        var val_30 = 0;
        label_22:
        if((mem[1179403735] + 0) == null)
        {
            goto label_21;
        }
        
        val_30 = val_30 + 1;
        if(((uint)val_30 & 65535) < mem[1179403825])
        {
            goto label_22;
        }
        
        label_20:
        val_27 = val_25;
        goto label_23;
        label_21:
        var val_7 = mem[1179403735] + 0;
        val_25 = val_25 + (((mem[1179403735] + 0) + 4) << 3);
        val_27 = val_25 + 188;
        label_23:
        if((val_25.Contains(value:  -1822125328)) == false)
        {
            goto label_34;
        }
        
        var val_32 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_28;
        }
        
        var val_31 = 0;
        label_30:
        if((mem[1179403735] + 0) == null)
        {
            goto label_29;
        }
        
        val_31 = val_31 + 1;
        if(((uint)val_31 & 65535) < mem[1179403825])
        {
            goto label_30;
        }
        
        label_28:
        val_28 = val_25;
        goto label_31;
        label_29:
        var val_9 = mem[1179403735] + 0;
        val_32 = val_32 + (((mem[1179403735] + 0) + 4) << 3);
        val_28 = val_32 + 188;
        label_31:
        if((val_25.Contains(value:  -1827757920)) == false)
        {
            goto label_34;
        }
        
        var val_40 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_36;
        }
        
        var val_33 = 0;
        label_38:
        if((mem[1179403735] + 0) == null)
        {
            goto label_37;
        }
        
        val_33 = val_33 + 1;
        if(((uint)val_33 & 65535) < mem[1179403825])
        {
            goto label_38;
        }
        
        label_36:
        val_29 = val_25;
        goto label_39;
        label_34:
        var val_35 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_41;
        }
        
        var val_34 = 0;
        label_43:
        if((mem[1179403735] + 0) == null)
        {
            goto label_42;
        }
        
        val_34 = val_34 + 1;
        if(((uint)val_34 & 65535) < mem[1179403825])
        {
            goto label_43;
        }
        
        label_41:
        val_30 = val_25;
        goto label_44;
        label_42:
        var val_11 = mem[1179403735] + 0;
        val_35 = val_35 + (((mem[1179403735] + 0) + 4) << 3);
        val_30 = val_35 + 188;
        label_44:
        var val_37 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_47;
        }
        
        var val_36 = 0;
        label_49:
        if((mem[1179403735] + 0) == null)
        {
            goto label_48;
        }
        
        val_36 = val_36 + 1;
        if(((uint)val_36 & 65535) < mem[1179403825])
        {
            goto label_49;
        }
        
        label_47:
        val_31 = val_25;
        goto label_50;
        label_48:
        var val_12 = mem[1179403735] + 0;
        val_37 = val_37 + (((mem[1179403735] + 0) + 4) << 3);
        val_31 = val_37 + 188;
        label_50:
        decimal val_13 = System.Decimal.Parse(s:  -1822113284);
        var val_39 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_55;
        }
        
        var val_38 = 0;
        label_57:
        if((mem[1179403735] + 0) == null)
        {
            goto label_56;
        }
        
        val_38 = val_38 + 1;
        if(((uint)val_38 & 65535) < mem[1179403825])
        {
            goto label_57;
        }
        
        label_55:
        val_32 = val_25;
        goto label_58;
        label_56:
        var val_18 = mem[1179403735] + 0;
        val_39 = val_39 + (((mem[1179403735] + 0) + 4) << 3);
        val_32 = val_39 + 188;
        label_58:
        Add(item:  new Award() {amount = new System.Decimal() {flags = val_14, hi = val_15, lo = val_16, mid = val_17}});
        goto label_84;
        label_37:
        var val_19 = mem[1179403735] + 0;
        val_40 = val_40 + (((mem[1179403735] + 0) + 4) << 3);
        val_29 = val_40 + 188;
        label_39:
        if((val_25.Contains(value:  -1827757920)) == false)
        {
            goto label_84;
        }
        
        var val_42 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_66;
        }
        
        var val_41 = 0;
        label_68:
        if((mem[1179403735] + 0) == null)
        {
            goto label_67;
        }
        
        val_41 = val_41 + 1;
        if(((uint)val_41 & 65535) < mem[1179403825])
        {
            goto label_68;
        }
        
        label_66:
        val_33 = val_25;
        goto label_69;
        label_67:
        var val_21 = mem[1179403735] + 0;
        val_42 = val_42 + (((mem[1179403735] + 0) + 4) << 3);
        val_33 = val_42 + 188;
        label_69:
        var val_44 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_72;
        }
        
        var val_43 = 0;
        label_74:
        if((mem[1179403735] + 0) == null)
        {
            goto label_73;
        }
        
        val_43 = val_43 + 1;
        if(((uint)val_43 & 65535) < mem[1179403825])
        {
            goto label_74;
        }
        
        label_72:
        val_34 = val_25;
        goto label_75;
        label_73:
        var val_22 = mem[1179403735] + 0;
        val_44 = val_44 + (((mem[1179403735] + 0) + 4) << 3);
        val_34 = val_44 + 188;
        label_75:
        var val_46 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_78;
        }
        
        var val_45 = 0;
        label_80:
        if((mem[1179403735] + 0) == null)
        {
            goto label_79;
        }
        
        val_45 = val_45 + 1;
        if(((uint)val_45 & 65535) < mem[1179403825])
        {
            goto label_80;
        }
        
        label_78:
        val_35 = val_25;
        goto label_81;
        label_79:
        var val_23 = mem[1179403735] + 0;
        val_46 = val_46 + (((mem[1179403735] + 0) + 4) << 3);
        val_35 = val_46 + 188;
        label_81:
        Add(item:  new Award() {amount = new System.Decimal(), text = val_25});
        goto label_84;
        label_11:
        val_36 = 1152921504619679744;
        if("awards_available" == 0)
        {
            goto label_85;
        }
        
        string val_47 = "awards_available";
        if(null == null)
        {
            goto label_86;
        }
        
        val_21 = 0;
        label_88:
        val_36 = 0;
        if(1179403647 == null)
        {
            goto label_87;
        }
        
        val_21 = val_21 + 1;
        val_36 = (uint)val_21 & 65535;
        if(val_36 < null)
        {
            goto label_88;
        }
        
        label_86:
        val_37 = "awards_available";
        goto label_89;
        label_87:
        var val_24 = val_25 + 0;
        val_47 = val_47 + (((0 + 0) + 4) << 3);
        val_37 = val_47 + 188;
        label_89:
        label_85:
        if(0 == 0)
        {
                return;
        }
    
    }
    private void SaveCurrent()
    {
        WordPets.WPTPetTile val_4;
        WordPets.WPTPetTile val_5;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        List.Enumerator<T> val_2 = GetEnumerator();
        label_7:
        if(MoveNext() == false)
        {
            goto label_2;
        }
        
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_7 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  1624646480, value:  val_4);
        string val_8 = ToString();
        Add(key:  -1822603728, value:  -1821995208);
        Add(key:  -1822603808, value:  val_5);
        Add(item:  78753792);
        goto label_7;
        label_2:
        Dispose();
        string val_9 = MiniJSON.Json.Serialize(obj:  80883712);
        UnityEngine.PlayerPrefs.SetString(key:  -1822125440, value:  80883712);
        bool val_10 = PrefsSerializationManager.SavePlayerPrefs();
    }
    public void importProgress(string supportId, string linkCode)
    {
        var val_6;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        if(null != 0)
        {
                Add(key:  -1821882800, value:  linkCode);
        }
        else
        {
                Add(key:  -1821882800, value:  linkCode);
        }
        
        Add(key:  -1821882704, value:  supportId);
        Player val_2 = this.Player;
        Add(key:  1618311216, value:  -1821857312);
        CompanyDevices val_3 = CompanyDevices.Instance;
        if(0.CompanyDevice() != false)
        {
                Add(key:  -1821882528, value:  -1821882608);
        }
        
        var val_6 = 27789974;
        val_6 = 7836084 + val_6;
        if(val_6 == 0)
        {
                mem2[0] = 1;
        }
        
        val_6 = null;
        val_6 = null;
        System.Action<System.Threading.Tasks.Task, System.Object> val_5 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  -1821857312, method:  new IntPtr(2473084864));
        App.networkManager.DoPost(path:  -1821881408, postBody:  78753792, onCompleteFunction:  7507968, timeout:  20, destroy:  false, immediate:  false, serverType:  0);
    }
    private void OnImportProgressResponse(string method, System.Collections.Generic.Dictionary<string, object> response)
    {
        var val_6 = 35629184;
        if(response != 0)
        {
                val_6 = "success";
            if((response.ContainsKey(key:  1616271776)) != false)
        {
                object val_2 = response.Item[1616271776];
            val_6 = response;
            val_6.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            if(null != 0)
        {
                this.UpdatedFromServer(serverResponse:  response, forceUpdate:  true);
            NotificationCenter val_3 = NotificationCenter.DefaultCenter;
            System.Collections.Hashtable val_4 = new System.Collections.Hashtable();
            0.PostNotification(aSender:  -1821728528, aName:  -1821752928, aData:  75878400);
            return;
        }
        
        }
        
        }
        
        UnityEngine.Debug.Log(message:  -1821752800);
        NotificationCenter val_5 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  -1821728528, aName:  -1821752640);
    }
    protected override void AwakeLogic()
    {
        this.AwakeLogic();
        this.Initialize();
    }
    private void Initialize()
    {
        null = null;
        if(ServerHandler.initialized == true)
        {
                return;
        }
        
        R4.RefreshAwards();
        System.Collections.Generic.List<MessageParams> val_1 = ServerHandler.ExtractMissedMessagesFromPlayerPrefs();
        mem2[0] = R5;
        mem2[0] = 1;
    }
    public void PopFirstMessage()
    {
        if(true < 1)
        {
                return;
        }
        
        this._ParsedMessages.RemoveAt(index:  0);
        ServerHandler.SaveQueuedToPlayerPrefs(queuedMessages:  this._ParsedMessages);
    }
    public static void SaveQueuedToPlayerPrefs(System.Collections.Generic.List<MessageParams> queuedMessages)
    {
        var val_4;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        List.Enumerator<T> val_2 = GetEnumerator();
        label_9:
        if(MoveNext() == false)
        {
            goto label_2;
        }
        
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_5 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  -1822721168, value:  val_4 + 8);
        var val_6 = val_4 + 12;
        UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        mem2[0] = ;
        Add(key:  -1822721088, value:  291106816);
        Add(key:  -1822721008, value:  8945664);
        Add(item:  78753792);
        goto label_9;
        label_2:
        Dispose();
        string val_7 = MiniJSON.Json.Serialize(obj:  80883712);
        UnityEngine.PlayerPrefs.SetString(key:  -1821262544, value:  80883712);
        bool val_8 = PrefsSerializationManager.SavePlayerPrefs();
    }
    public static System.Collections.Generic.List<MessageParams> ExtractMissedMessagesFromPlayerPrefs()
    {
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        PromptType val_18;
        var val_19;
        var val_20;
        var val_21;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        string val_2 = UnityEngine.PlayerPrefs.GetString(key:  -1821262544, defaultValue:  -2141227328);
        object val_3 = MiniJSON.Json.Deserialize(json:  -1821262544);
        string val_16 = "missed_messages";
        if(null == 0)
        {
            goto label_2;
        }
        
        var val_15 = 0;
        label_4:
        val_11 = 0;
        if(1179403647 == null)
        {
            goto label_3;
        }
        
        val_15 = val_15 + 1;
        val_11 = (uint)val_15 & 65535;
        if(val_11 < null)
        {
            goto label_4;
        }
        
        label_2:
        val_12 = "missed_messages";
        goto label_5;
        label_3:
        var val_4 = 0 + 0;
        val_16 = val_16 + (((0 + 0) + 4) << 3);
        val_12 = val_16 + 188;
        label_5:
        label_50:
        string val_17 = "missed_messages";
        if(null == null)
        {
            goto label_7;
        }
        
        val_11 = 0;
        label_9:
        if(1179403647 == null)
        {
            goto label_8;
        }
        
        val_11 = val_11 + 1;
        if(((uint)val_11 & 65535) < null)
        {
            goto label_9;
        }
        
        label_7:
        val_13 = "missed_messages";
        goto label_10;
        label_8:
        var val_5 = val_15 + 0;
        val_17 = val_17 + (((0 + 0) + 4) << 3);
        val_13 = val_17 + 188;
        label_10:
        if("missed_messages" == 0)
        {
            goto label_11;
        }
        
        string val_19 = "missed_messages";
        if(null == null)
        {
            goto label_13;
        }
        
        var val_18 = 0;
        label_15:
        if(1179403647 == null)
        {
            goto label_14;
        }
        
        val_18 = val_18 + 1;
        if(((uint)val_18 & 65535) < null)
        {
            goto label_15;
        }
        
        label_13:
        val_14 = "missed_messages";
        goto label_16;
        label_14:
        var val_6 = val_15 + 0;
        val_19 = val_19 + (((0 + 0) + 4) << 3);
        val_14 = val_19 + 196;
        label_16:
        val_15 = 0;
        if("missed_messages" != 0)
        {
                val_15 = "missed_messages";
            if("missed_messages" == 0)
        {
                val_15 = 0;
        }
        
        }
        
        MessageParams val_7 = new MessageParams();
        var val_21 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_20;
        }
        
        var val_20 = 0;
        label_22:
        if((mem[1179403735] + 0) == null)
        {
            goto label_21;
        }
        
        val_20 = val_20 + 1;
        if(((uint)val_20 & 65535) < mem[1179403825])
        {
            goto label_22;
        }
        
        label_20:
        val_16 = val_15;
        goto label_23;
        label_21:
        var val_8 = mem[1179403735] + 0;
        val_21 = val_21 + (((mem[1179403735] + 0) + 4) << 3);
        val_16 = val_21 + 188;
        label_23:
        typeof(MessageParams).__il2cppRuntimeField_8 = val_15;
        System.Type val_9 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(291106816)});
        var val_23 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_29;
        }
        
        var val_22 = 0;
        label_31:
        if((mem[1179403735] + 0) == null)
        {
            goto label_30;
        }
        
        val_22 = val_22 + 1;
        if(((uint)val_22 & 65535) < mem[1179403825])
        {
            goto label_31;
        }
        
        label_29:
        val_17 = val_15;
        goto label_32;
        label_30:
        var val_10 = mem[1179403735] + 0;
        val_23 = val_23 + (((mem[1179403735] + 0) + 4) << 3);
        val_17 = val_23 + 188;
        label_32:
        object val_11 = System.Enum.Parse(enumType:  291106816, value:  null);
        val_18 = 0;
        typeof(MessageParams).__il2cppRuntimeField_C = ;
        var val_25 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_41;
        }
        
        var val_24 = 0;
        label_43:
        if((mem[1179403735] + 0) == null)
        {
            goto label_42;
        }
        
        val_24 = val_24 + 1;
        if(((uint)val_24 & 65535) < mem[1179403825])
        {
            goto label_43;
        }
        
        label_41:
        val_19 = val_15;
        goto label_44;
        label_42:
        var val_12 = mem[1179403735] + 0;
        val_25 = val_25 + (((mem[1179403735] + 0) + 4) << 3);
        val_19 = val_25 + 188;
        label_44:
        typeof(MessageParams).__il2cppRuntimeField_10 = System.Boolean.Parse(value:  null);
        Add(item:  291160064);
        goto label_50;
        label_11:
        val_20 = 1152921504619679744;
        if("missed_messages" == 0)
        {
            goto label_51;
        }
        
        string val_26 = "missed_messages";
        if(null == null)
        {
            goto label_52;
        }
        
        val_11 = 0;
        label_54:
        val_20 = 0;
        if(1179403647 == null)
        {
            goto label_53;
        }
        
        val_11 = val_11 + 1;
        val_20 = (uint)val_11 & 65535;
        if(val_20 < null)
        {
            goto label_54;
        }
        
        label_52:
        val_21 = "missed_messages";
        goto label_55;
        label_53:
        var val_14 = val_15 + 0;
        val_26 = val_26 + (((0 + 0) + 4) << 3);
        val_21 = val_26 + 188;
        label_55:
        label_51:
        UnityEngine.PlayerPrefs.SetString(key:  -1821262544, value:  -2141227328);
    }
    public ServerHandler()
    {
        this._allowServerConnect = true;
        System.DateTime val_1 = System.DateTime.UtcNow;
        this._serverTime = new System.DateTime();
        System.Collections.Generic.List<Award> val_2 = new System.Collections.Generic.List<Award>();
        this.currentAwards = null;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_3 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this._ParsedMessages = null;
    }
    private static ServerHandler()
    {
        System.DateTime val_1 = new System.DateTime(year:  1970, month:  1, day:  1, hour:  0, minute:  0, second:  0, kind:  1);
        ServerHandler.missed_msgs_key = val_1.dateData;
        ServerHandler.initialized = 0;
    }

}
