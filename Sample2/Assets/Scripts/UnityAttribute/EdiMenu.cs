using UnityEngine;
// ������ ��� ���¿��� Update, OnEnable, OnDisable�� ������ ���� �� �� �ֽ��ϴ�.
// Play�� ������ �ʾƵ� Editor ���� Update ���� ������ ��ɵ��� ���� �غ� �� �ֽ��ϴ�.
// [ExecuteInEditMode]
public class EdiMenu : MonoBehaviour
{   
    private void Update()
    {
        if (!Application.isPlaying)
        {
            Vector3 Pos = transform.position;
            Pos.y = 0;
            transform.position = Pos;
            Debug.Log("Editor Test.. �� ��ũ��Ʈ�� �� ������Ʈ�� Y���� 0���� �����˴ϴ�.");
        }
    }
    
}
