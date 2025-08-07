using UnityEngine;
using TMPro;
public class TextMeshProSample : MonoBehaviour
{
    //TMP를 사용하는 UI 컴포넌트
    public TextMeshProUGUI textUI;

    private void Start()
    {
        textUI.text = "<size=150%>I can`t speak Korean</size> <s>sibal</s>";
    }

    public void SetText(bool warning)
    {
        if (warning)
        {
            textUI.text = "<color=red><p><Warnning></p></color>";
        }
        else
        {
            textUI.text = "None";
        }
    }
}
