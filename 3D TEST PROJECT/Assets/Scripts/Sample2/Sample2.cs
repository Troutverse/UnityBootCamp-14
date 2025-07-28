using UnityEngine;


public enum Projection
{
    Perspective, Orthograhic
}
public enum FieldOfViewAxis
{
    Vertical, Horizontal
}


public class Sample2 : MonoBehaviour
{
    public Projection Projection;
    public FieldOfViewAxis FieldOfViewAxis;
    public int FieldOfView = 20;
    public double Near = 0.3;
    public double Far = 1000;
    public bool Physical_Camera;
}
