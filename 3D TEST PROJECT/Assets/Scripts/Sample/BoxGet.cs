using UnityEngine;
using UnityEngine.UI;

public class BoxGet : MonoBehaviour
{
    public PlayerController pc;
    public Text text;
    void Start()
    {
        
    }
    void Update()
    {
        text.text = $"Score : {pc.score}";
    }
}
