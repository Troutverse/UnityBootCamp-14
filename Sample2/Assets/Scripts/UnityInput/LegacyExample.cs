using UnityEngine;
using UnityEngine.UI;

/* 특정 키를 입력하면 텍스트에 특정 메시지가 나오도록 하는 코드
   
 */
public class LegacyExample : MonoBehaviour
{
    public Text text;
    private void Start()
    {
        text = GetComponentInChildren<Text>(); // 현 오브젝트의 자식으로부터 컴포넌트를 얻어오는 기능
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            text.text = "앙 기모띠";
        }
        if (Input.GetKeyDown(KeyCode.Return)) // Enter Key
        {   
            text.text = "양 금호띠";
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            text.text = ""; 
        }

        foreach (KeyCode key in System.Enum.GetValues(typeof(KeyCode))) 
        {
            if (Input.GetKeyDown(key)) 
            {
               text.text = key.ToString();
            }
        }
    }
}
