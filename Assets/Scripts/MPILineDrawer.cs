using UnityEngine;
public class MPILineDrawer : MonoSingleton<MPILineDrawer>
{
    // Fields
    private UnityEngine.LineRenderer lineRenderer;
    
    // Methods
    public override void InitMonoSingleton()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        object val_2 = this.GetComponent<System.Object>();
        this.lineRenderer = this;
    }
    public void DrawPath(System.Collections.Generic.List<UnityEngine.Vector3> path)
    {
        this.lineRenderer.widthMultiplier = null;
        this.lineRenderer.positionCount = R7;
        T[] val_1 = path.ToArray();
        this.lineRenderer.SetPositions(positions:  path);
    }
    public void ClearPath()
    {
        this.lineRenderer.positionCount = 0;
    }
    public MPILineDrawer()
    {
    
    }

}
