using UnityEngine;

public class ItemTester : MonoBehaviour
{
    public SOMaker somaker;
    void Start()
    {
        Debug.Log(somaker.description);
    }
    public void LevelUp()
    {
        somaker.level++;
        Debug.Log("Level Up");
    }
}