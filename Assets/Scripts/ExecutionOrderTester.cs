using UnityEngine;
public class ExecutionOrderTester : MonoBehaviour
{
    // Fields
    public bool doLog;
    public bool doLogAwake;
    public bool doLogOnEnable;
    public bool doLogStart;
    public bool doLogFixedUpdate;
    public bool doLogUpdate;
    public bool doLogLateUpdate;
    public bool doLogOnBecameVisible;
    public bool doLogOnBecameInvisible;
    public bool doLogOnDisable;
    public bool doLogOnDestroy;
    private bool useErrors;
    
    // Methods
    private void Awake()
    {
        if(this.doLog == true)
        {
                this.doLog = this.doLogAwake;
        }
        
        if(this.doLog == false)
        {
                return;
        }
        
        R4.Log(message:  -2034173136);
    }
    private void OnEnable()
    {
        if(this.doLog == true)
        {
                this.doLog = this.doLogOnEnable;
        }
        
        if(this.doLog == false)
        {
                return;
        }
        
        R4.Log(message:  -2034061008);
    }
    private void Start()
    {
        if(this.doLog == true)
        {
                this.doLog = this.doLogStart;
        }
        
        if(this.doLog == false)
        {
                return;
        }
        
        R4.Log(message:  -2033948864);
    }
    private void FixedUpdate()
    {
        if(this.doLog == true)
        {
                this.doLog = this.doLogFixedUpdate;
        }
        
        if(this.doLog == false)
        {
                return;
        }
        
        R4.Log(message:  -2033836736);
    }
    private void Update()
    {
        if(this.doLog == true)
        {
                this.doLog = this.doLogUpdate;
        }
        
        if(this.doLog == false)
        {
                return;
        }
        
        R4.Log(message:  -2033724592);
    }
    private void LateUpdate()
    {
        if(this.doLog == true)
        {
                this.doLog = this.doLogLateUpdate;
        }
        
        if(this.doLog == false)
        {
                return;
        }
        
        R4.Log(message:  -2033612448);
    }
    private void OnBecameVisibile()
    {
        if(this.doLog == true)
        {
                this.doLog = this.doLogOnBecameVisible;
        }
        
        if(this.doLog == false)
        {
                return;
        }
        
        R4.Log(message:  -2033500304);
    }
    private void OnBecameInvisibile()
    {
        if(this.doLog == true)
        {
                this.doLog = this.doLogOnBecameInvisible;
        }
        
        if(this.doLog == false)
        {
                return;
        }
        
        R4.Log(message:  -2033388144);
    }
    private void OnDisable()
    {
        if(this.doLog == true)
        {
                this.doLog = this.doLogOnDisable;
        }
        
        if(this.doLog == false)
        {
                return;
        }
        
        R4.Log(message:  -2033275984);
    }
    private void OnDestroy()
    {
        if(this.doLog == true)
        {
                this.doLog = this.doLogOnDestroy;
        }
        
        if(this.doLog == false)
        {
                return;
        }
        
        R4.Log(message:  -2033163840);
    }
    private void Log(string message)
    {
        string val_6 = message;
        UnityEngine.GameObject val_1 = this.gameObject;
        if((-2033023600) != 0)
        {
                string val_3 = this.name;
            string val_4 = val_6 + 2089622272 + -2033023600(-2033023600);
            val_6 = val_6;
        }
        
        if(this.useErrors != false)
        {
                UnityEngine.Debug.LogError(message:  val_6, context:  -2033023600);
            return;
        }
        
        UnityEngine.Debug.LogWarning(message:  val_6, context:  -2033023600);
    }
    public ExecutionOrderTester()
    {
        this.doLogOnEnable = true;
        this.doLog = true;
        this.doLogOnDisable = true;
    }

}
