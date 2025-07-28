using UnityEngine;

public class Sample1 : MonoBehaviour
{
    public CustomComponet cc;
    private void Awake()
    {
        cc = GetComponent<CustomComponet>();
    }
}