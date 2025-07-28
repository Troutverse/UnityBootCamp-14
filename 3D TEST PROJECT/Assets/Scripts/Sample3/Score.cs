using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text text;
    public float score = 0.0f;

    void Update()
    {
        score += Time.deltaTime;
        text.text = $"Á¡¼ö : {(int)score}";
    }
}
