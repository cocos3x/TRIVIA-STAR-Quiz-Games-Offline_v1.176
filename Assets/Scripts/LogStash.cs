using UnityEngine;
public class LogStash
{
    // Fields
    private const int MaxPerStash = 20;
    private static System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<TrackedEvent>> stashes;
    private static System.Collections.Generic.Dictionary<string, int> indexes;
    
    // Methods
    public static void Stash(string stash, string eventToTrack, System.Collections.Generic.Dictionary<string, string> properties)
    {
        var val_4;
        System.Func<System.Collections.Generic.KeyValuePair<System.String, System.String>, System.String> val_6;
        System.Func<System.Collections.Generic.KeyValuePair<System.String, System.String>, System.Object> val_8;
        val_4 = null;
        val_4 = null;
        val_6 = LogStash.<>c.<>9__3_0;
        if(val_6 == 0)
        {
                val_6 = null;
            val_6 = new System.Func<System.Collections.Generic.KeyValuePair<System.String, System.String>, System.String>(object:  LogStash.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2314813952));
            val_4 = null;
            LogStash.<>c.<>9__3_0 = val_6;
        }
        
        val_4 = null;
        val_8 = LogStash.<>c.<>9__3_1;
        if(val_8 == 0)
        {
                val_8 = null;
            val_8 = new System.Func<System.Collections.Generic.KeyValuePair<System.String, System.String>, System.String>(object:  LogStash.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2314816000));
            LogStash.<>c.<>9__3_1 = val_8;
        }
        
        System.Collections.Generic.Dictionary<TKey, TElement> val_3 = System.Linq.Enumerable.ToDictionary<System.Collections.Generic.KeyValuePair<System.Object, System.Object>, System.Object, System.Object>(source:  properties, keySelector:  7720960, elementSelector:  7720960);
        LogStash.Stash(stash:  stash, eventToTrack:  eventToTrack, properties:  properties);
    }
    public static void Stash(string stash, string eventToTrack, System.Collections.Generic.Dictionary<string, object> properties)
    {
        var val_11;
        var val_12;
        var val_13;
        System.Collections.Generic.Dictionary<System.String, System.Int32> val_14;
        int val_15;
        var val_16;
        val_11 = null;
        val_11 = null;
        if((LogStash.stashes.ContainsKey(key:  stash)) != true)
        {
                val_12 = null;
            val_12 = null;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            LogStash.stashes.Add(key:  stash, value:  80883712);
            LogStash.indexes.Add(key:  stash, value:  0);
        }
        
        val_13 = null;
        val_13 = null;
        System.Collections.Generic.List<TrackedEvent> val_3 = LogStash.stashes.Item[stash];
        val_14 = LogStash.indexes;
        if(val_14 != 0)
        {
                val_15 = val_14.Item[stash];
        }
        else
        {
                val_14 = 0;
            val_15 = 0.Item[stash];
        }
        
        val_15 = val_15 + 1;
        val_14.set_Item(key:  stash, value:  val_15);
        TrackedEvent val_6 = new TrackedEvent(eventName:  eventToTrack, properties:  properties, index:  val_15);
        LogStash.stashes.Insert(index:  0, item:  285089792);
        System.Collections.Generic.List<TrackedEvent> val_7 = LogStash.stashes.Item[stash];
        if((LogStash.stashes + 12) < 21)
        {
                return;
        }
        
        val_16 = null;
        val_16 = null;
        System.Collections.Generic.List<TrackedEvent> val_8 = LogStash.stashes.Item[stash];
        System.Collections.Generic.List<TrackedEvent> val_9 = LogStash.stashes.Item[stash];
        LogStash.stashes.RemoveAt(index:  (LogStash.stashes + 12) - 1);
    }
    public static System.Collections.Generic.List<TrackedEvent> GetStash(string stashKey)
    {
        var val_3;
        var val_4;
        val_3 = null;
        val_3 = null;
        if((LogStash.stashes.ContainsKey(key:  stashKey)) == false)
        {
                return;
        }
        
        val_4 = null;
        val_4 = null;
        System.Collections.Generic.List<TrackedEvent> val_2 = LogStash.stashes.Item[stashKey];
    }
    public static System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<TrackedEvent>> GetEverything()
    {
        null = null;
    }
    public LogStash()
    {
    
    }
    private static LogStash()
    {
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        LogStash.stashes = null;
        System.Collections.Generic.Dictionary<WADPets.WADPet, System.Int32> val_2 = new System.Collections.Generic.Dictionary<WADPets.WADPet, System.Int32>();
        LogStash.indexes = null;
    }

}
