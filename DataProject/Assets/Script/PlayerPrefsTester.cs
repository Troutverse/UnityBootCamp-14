using UnityEngine;
// Ű(Key)�� ��(Value)
// Ű(Key)   : ���� �����ϱ� ���� ������, Ű�� ������ �̸��� ������ ��
// ��(Value) : Ű�� ���ؼ� ���� �� �ִ� �������� ��

// Ű�� ���� �� ������ �����Ǵ� �����ʹ� Ű�� �����Ǹ�, ���� ���� ����
// "Ű"�� ���� ���� ��ȸ�ϰ�, �߰��ϰ�, �����ϴ� ������ �ſ� ������ ������ �� ����

// Unity ������ ��� �Ǵ� �ش� ������ ������
// 1. Dictionary<K,V> : C#���� �����Ǵ� ǥ�� �ڷ� ����
// 2. PlayerPrefs : Unity���� �����ϴ� Ű-�� ���� �ý���(Ŭ����)
// 3. JSON : �ܺο��� �ۼ��� json ���ϵ� Ű-���� ���·� �ۼ��� �� ��
// 4. ScriptableObject : ��ü�����δ� ������ �ȵǳ� Dictionary�� ������ ���

// PlayerPrefs
// ������ �����͸� ������ �� ���Ǵ� ������ ���� �ý���
// ������ �����ͳ� ū �뷮�� �䱸�ϴ� ������ ���忡�� ������

// �ַ� ����Ǵ� ��Ȳ : ����, �÷��̾��� ���� ����, ���� ���� ��(�ػ�, ��Ʈ��, ����..)

// ���� : �ﰢ���̰� ������ ���� / �ε忡 ���� ���������� ����
//       �÷��� ������ ���� ���, ���� ���� ���� ���
//       ex) Window -> ������Ʈ�� ���, Mac -> /Library/Preferences/Unity.[company].[projectname].plist (plist ����)
//           IOS -> ios ���� �����, Android -> XML ����(�� ������), WebGL -> �÷����� ������ ������ �´� �����
// ���� : �÷��̰� ������ ������ ���� => ���ȼ��� ����
public class PlayerPrefsTester : MonoBehaviour
{
    public int score;
    public int max_score = 10;
    private void Start()
    {
        score = PlayerPrefs.GetInt("score"); // �ش� Ű�� �������� �ʴ´ٸ� ������ ���� return ��
        PlayerPrefs.SetInt("MaxScore", max_score); // Key = MaxScore, Value = max_score

        PlayerPrefs.Save(); // ��ũ��Ʈ�� ���� ������ ������ ȣ��, ��� �ڵ����� ������ ��
        
        Debug.Log(score);
        Debug.Log(PlayerPrefs.GetInt("MaxScore"));
    }
    public void ResetPrefs()
    {
        PlayerPrefs.DeleteAll();
    }
}
