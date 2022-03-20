using UnityEngine;
public class WordDropController : MonoBehaviour
{
    // Fields
    private UnityEngine.GameObject wordScoop;
    private UnityEngine.RectTransform wordScoopArea;
    public UnityEngine.Transform killTransform;
    private UnityEngine.Transform dropHolder;
    private UnityEngine.Sprite[] scoopSprites;
    private RandomSet randomSet;
    private int counter;
    private string[] myWords;
    private float timer;
    private float nextTime;
    private bool hasStarted;
    private WordDropFTUXManager ftuxManager;
    private int ftuxCounter;
    
    // Methods
    public void BeginDrops()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.String[] val_2 = GetNextLevelData();
        this.myWords = public static WordDropManager MonoSingleton<WordDropManager>::get_Instance();
        this.randomSet.addIntRange(lowest:  0, highest:  (public static WordDropManager MonoSingleton<WordDropManager>::get_Instance().__il2cppRuntimeField_C - 1));
        this.timer = 0f;
        this.nextTime = 5f;
        this.hasStarted = true;
    }
    public void ResetDrops()
    {
        this.ftuxCounter = 0;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.String[] val_2 = GetNextLevelData();
        this.counter = 0;
        this.myWords = public static WordDropManager MonoSingleton<WordDropManager>::get_Instance();
        this.nextTime = 5f;
        this.randomSet.clear();
        this.randomSet.addIntRange(lowest:  0, highest:  this.randomSet - 1);
    }
    private void Update()
    {
        if(this.hasStarted == false)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        float val_2 = UnityEngine.Time.deltaTime;
        uint val_13 = 0;
        val_13 = this.timer + val_13;
        this.timer = val_13;
        if(this.ftuxManager.ftux == false)
        {
            goto label_8;
        }
        
        this.CreateWordScoop();
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        float val_4 = LevelSpeed;
        uint val_14 = 2554377744;
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_14 = val_14 * 0.5f;
        float val_7 = UnityEngine.Random.Range(min:  LevelSpeed, max:  null);
        label_33:
        this.nextTime = val_14;
        goto label_32;
        label_8:
        if(this.ftuxManager.ftux == false)
        {
            goto label_15;
        }
        
        label_32:
        int val_15 = this.counter;
        this.timer = 0f;
        val_15 = val_15 + 1;
        this.counter = val_15;
        if(val_15 < 4)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.String[] val_9 = GetNextLevelData();
        this.counter = 0;
        this.myWords = public static WordDropManager MonoSingleton<WordDropManager>::get_Instance();
        this.randomSet.reset();
        return;
        label_15:
        twelvegigs.Autopilot.AutopilotManager val_10 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        twelvegigs.Autopilot.AutopilotManager val_11 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        SecondLevelFTUX();
        this.CreateIncorrectFTUXScoop();
        goto label_33;
    }
    public void CreateIncorrectFTUXScoop()
    {
        UnityEngine.Rect val_2 = rect;
        float val_3 = xMin;
        UnityEngine.Rect val_4 = rect;
        float val_6 = UnityEngine.Random.Range(min:  xMax, max:  val_4.m_YMin);
        UnityEngine.Transform val_7 = this.wordScoopArea.transform;
        UnityEngine.Vector3 val_8 = position;
        UnityEngine.Vector3 val_10 = new UnityEngine.Vector3(x:  val_8.x, y:  val_8.y, z:  val_8.z);
        UnityEngine.Quaternion val_11 = UnityEngine.Quaternion.identity;
        UnityEngine.GameObject val_12 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.wordScoop, position:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, rotation:  new UnityEngine.Quaternion(), parent:  this.dropHolder);
        object val_13 = this.wordScoop.GetComponent<System.Object>();
        twelvegigs.Autopilot.AutopilotManager val_14 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UnityEngine.Sprite val_18 = this.scoopSprites[UnityEngine.Random.Range(min:  0, max:  0)];
        this.wordScoop.SetScoop(newSpeed:  LevelSpeed, newWord:  -1740589552, status:  this.myWords[0], newSprite:  0);
        string val_16 = -1739950448(-1739950448) + this.myWords[0];
        UnityEngine.Debug.Log(message:  -1739950448);
    }
    public void CreateCorrectFTUXScoop()
    {
        int val_17 = this.ftuxCounter;
        val_17 = val_17 + 1;
        this.ftuxCounter = val_17;
        UnityEngine.Rect val_2 = rect;
        float val_3 = xMin;
        UnityEngine.Rect val_4 = rect;
        float val_6 = UnityEngine.Random.Range(min:  xMax, max:  val_4.m_YMin);
        UnityEngine.Transform val_7 = this.wordScoopArea.transform;
        UnityEngine.Vector3 val_8 = position;
        UnityEngine.Vector3 val_10 = new UnityEngine.Vector3(x:  val_8.x, y:  val_8.y, z:  val_8.z);
        UnityEngine.Quaternion val_11 = UnityEngine.Quaternion.identity;
        UnityEngine.GameObject val_12 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.wordScoop, position:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, rotation:  new UnityEngine.Quaternion(), parent:  this.dropHolder);
        object val_13 = this.wordScoop.GetComponent<System.Object>();
        twelvegigs.Autopilot.AutopilotManager val_14 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UnityEngine.Sprite val_19 = this.scoopSprites[UnityEngine.Random.Range(min:  0, max:  0)];
        if(this.ftuxCounter != 0)
        {
                this.ftuxCounter = 1;
        }
        
        this.wordScoop.SetScoop(newSpeed:  LevelSpeed, newWord:  -1740589552, status:  this.myWords[this.ftuxCounter], newSprite:  1);
        string val_16 = -1739477888(-1739477888) + this.myWords[this.ftuxCounter];
        UnityEngine.Debug.Log(message:  -1739477888);
    }
    public void CreateWordScoop()
    {
        int val_2 = this.randomSet.roll(unweighted:  false);
        UnityEngine.Rect val_3 = rect;
        float val_4 = xMin;
        UnityEngine.Rect val_5 = rect;
        float val_7 = UnityEngine.Random.Range(min:  xMax, max:  val_5.m_YMin);
        UnityEngine.Transform val_8 = this.wordScoopArea.transform;
        UnityEngine.Vector3 val_9 = position;
        UnityEngine.Vector3 val_11 = new UnityEngine.Vector3(x:  val_9.x, y:  val_9.y, z:  val_9.z);
        UnityEngine.Quaternion val_12 = UnityEngine.Quaternion.identity;
        UnityEngine.GameObject val_13 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.wordScoop, position:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, rotation:  new UnityEngine.Quaternion(), parent:  this.dropHolder);
        object val_14 = this.wordScoop.GetComponent<System.Object>();
        twelvegigs.Autopilot.AutopilotManager val_15 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UnityEngine.Sprite val_18 = this.scoopSprites[UnityEngine.Random.Range(min:  0, max:  0)];
        if(val_2 != 0)
        {
                val_2 = 1;
        }
        
        this.wordScoop.SetScoop(newSpeed:  LevelSpeed, newWord:  -1740589552, status:  this.myWords[val_2], newSprite:  1);
    }
    public WordDropController()
    {
        this.randomSet = new RandomSet();
    }

}
