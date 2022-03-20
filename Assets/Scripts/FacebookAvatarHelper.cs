using UnityEngine;
public class FacebookAvatarHelper
{
    // Fields
    protected static System.Collections.Generic.Dictionary<string, twelvegigs.net.ImageRequest> imageRequestsByFbid;
    
    // Methods
    public static void RequestProfilePic(string fbid, System.Action<string, UnityEngine.Texture2D> successCallback, System.Action failureCallback)
    {
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        string val_1 = -1856587856(-1856587856) + fbid + -1856587984(-1856587984);
        string val_2 = -1856587728(-1856587728) + fbid;
        val_8 = null;
        val_8 = null;
        if((FacebookAvatarHelper.imageRequestsByFbid.ContainsKey(key:  fbid)) != false)
        {
                val_9 = null;
            val_9 = null;
            twelvegigs.net.ImageRequest val_4 = FacebookAvatarHelper.imageRequestsByFbid.Item[fbid];
            if((FacebookAvatarHelper.imageRequestsByFbid + 16) != 0)
        {
                val_10 = null;
            val_10 = null;
            twelvegigs.net.ImageRequest val_5 = FacebookAvatarHelper.imageRequestsByFbid.Item[fbid];
            successCallback.Invoke(arg1:  -1856587728, arg2:  FacebookAvatarHelper.imageRequestsByFbid + 132);
            return;
        }
        
        }
        
        twelvegigs.net.ImageRequest val_6 = new twelvegigs.net.ImageRequest(url:  -1856587856, filename:  -1856587728, imgComplete:  successCallback, imgError:  failureCallback, showErrors:  false, destroy:  false, cached:  true, save:  false);
        val_11 = null;
        val_11 = null;
        if((FacebookAvatarHelper.imageRequestsByFbid.ContainsKey(key:  fbid)) != false)
        {
                return;
        }
        
        val_12 = null;
        val_12 = null;
        FacebookAvatarHelper.imageRequestsByFbid.Add(key:  fbid, value:  459423744);
    }
    public FacebookAvatarHelper()
    {
    
    }
    private static FacebookAvatarHelper()
    {
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        FacebookAvatarHelper.imageRequestsByFbid = null;
    }

}
