using UnityEngine;
using UnityEngine.UI;

/* Ư�� Ű�� �Է��ϸ� �ؽ�Ʈ�� Ư�� �޽����� �������� �ϴ� �ڵ�
   
 */
public class LegacyExample : MonoBehaviour
{
    public Text text;
    private void Start()
    {
        text = GetComponentInChildren<Text>(); // �� ������Ʈ�� �ڽ����κ��� ������Ʈ�� ������ ���
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            text.text = "�� ����";
        }
        if (Input.GetKeyDown(KeyCode.Return)) // Enter Key
        {   
            text.text = "�� ��ȣ��";
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
