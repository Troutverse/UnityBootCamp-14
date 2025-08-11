using System.Collections;
using UnityEngine;

// Unity LifeCycle ���� ����
// Update�� Ȱ���� ������ �� ȣ�� ������� Ȯ��

public class LifeCycleTester : MonoBehaviour
{
    private int count_per_frame = 0;
    private void Awake()
    {
        Debug.Log("[Awake] ������Ʈ�� ������ �� ���� ����Ǵ� ����");
    }
    private void OnEnable()
    {
        Debug.Log("[OnEnable] ������Ʈ�� Ȱ��ȭ�� ����Ǵ� ����");
    }
    private void Start()
    {
        Debug.Log("[Start] ù ������ ���� ���� ȣ��Ǵ� ����");
        StartCoroutine(CustomCoroutine());
    }
    private void FixedUpdate()
    {
        Debug.Log($"[CPF : {count_per_frame}] [FixedUpdate] ������ ���� ������Ʈ�� ����Ǵ� ����");
    }
    void Update()
    {
        count_per_frame++;
        Debug.Log($"[CPF : {count_per_frame}] [Update] ���� ������ ���� ȣ���� ����Ǵ� ����");
        
        if (count_per_frame == 3)
        {
            Debug.Log($"[CPF : {count_per_frame}] [Test 1] ������Ʈ ��Ȱ��ȭ �۾��� �����մϴ�");
            gameObject.SetActive(false);
        }
        if (count_per_frame == 6)
        {
            Debug.Log($"[CPF : {count_per_frame}] [Test 2] ������Ʈ Ȱ��ȭ �۾��� �����մϴ�");
            gameObject.SetActive(true);
        }
        if (count_per_frame == 9)
        {
            Debug.Log($"[CPF : {count_per_frame}] [Test 3] ������Ʈ �ı� �۾��� �����մϴ�");
            Destroy(gameObject);
        }
    }
    private void LateUpdate()
    {
        Debug.Log($"[CPF : {count_per_frame}] [LateUpdate] ���� ����, ���� ���� ��ó��");
    }
    // yield�� ���� ��� �� ����Ŭ�� ���ƿ��� ������ ����, ���� Update�� ƴ���� ������ ����
    IEnumerator CustomCoroutine()
    {
        Debug.Log($"[CPF : {count_per_frame}] [Coroutine] �ڷ�ƾ�� ���� ���� : StartCoroutine");
        yield return null;
        Debug.Log("[Coroutine] 1 ������ �� �ٽ� ����");
        yield return new WaitForSeconds(1.0f);
        Debug.Log("[Seconds] 1 ���� �ٽ� ����");
        yield return new WaitForFixedUpdate();
        Debug.Log("[FixedUpdate] FixedUpdate�� ������ �ٽ� ����");
        yield return new WaitForEndOfFrame();
        Debug.Log("[End of Frame] �������� ���� ������ �ٽ� ����");
    }
    private void OnDisable()
    {
        Debug.Log("[OnDisable] ������Ʈ ��Ȱ��ȭ");
    }
    private void OnDestroy()
    {
        Debug.Log("[OnDestroy] ������Ʈ �ı�");
        // gameObject.SetActive(true OR false) => ���� �ǵ� �ǹ̰� ���� ���� = �Ұ��� OR ���ǹ�
        // �ڱ� �ڽſ� ���� ���� �۾��� �Ұ���, ��� �ı���
        // ���ο� ���� ������Ʈ�� �����ϴ� ���� ����
    }
}