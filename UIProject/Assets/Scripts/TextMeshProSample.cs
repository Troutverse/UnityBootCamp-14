using UnityEngine;
using TMPro;
public class TextMeshProSample : MonoBehaviour
{
    //TMP�� ����ϴ� UI ������Ʈ
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
