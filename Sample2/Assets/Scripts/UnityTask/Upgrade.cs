using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;
public class Upgrade : MonoBehaviour
{
    public Text text1;
    public Text text2;
    public Text text3;
    public Text text4;
    public Text text5;
    public Text text6;

    public int WeaponUpgrade = 0;
    public int Damage = 50;
    public int EnhancementFigures = 0;
    public int Probability = 100;
    double[] Money = {1, 10, 100, 1000, 10000, 100000,1000000,10000000,100000000,1000000000 };
    double SpendMoney = 0;
    void SettingText()
    {
        text1.text = $"�߸��� ������ (+{WeaponUpgrade})";
        text2.text = $"���ݷ� : {Damage}";
        text3.text = $"��ȭ ��ġ : {EnhancementFigures} / 10";
        text4.text = $"���� Ȯ�� : {Probability}%";
        text6.text = $"�� ��� : {SpendMoney}��";
    }
    void ReinforcementFailed ()
    {
        SpendMoney += Money[WeaponUpgrade];
        WeaponUpgrade--;
        Damage -= 5;
        EnhancementFigures--;
        Probability += 10;
    }
    void ReinforcementSuccess () 
    {
        SpendMoney += Money[WeaponUpgrade];
        WeaponUpgrade++;
        Damage += 5;
        EnhancementFigures++;
        Probability -= 10;
    }
    void Start()
    {
        SettingText();
        text5.text = $"Space�� ���� ��ȭ�� �õ��ϼ���";
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            int tmp = Random.Range(0, 100);
            if (WeaponUpgrade == 10)
            {
                SettingText();
                text5.text = $"���� ����� ȣ���Դϴ� ����";
            }
            else if (tmp > Probability)
            {
                ReinforcementFailed();
                SettingText();
                text5.text = "��ȭ ���� ��";  
            }
            else
            {
                ReinforcementSuccess();
                SettingText();
                text5.text = "��ȭ ���� !";
            }
        }
    }
}
