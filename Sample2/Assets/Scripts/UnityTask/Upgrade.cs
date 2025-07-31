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
        text1.text = $"야만의 몽둥이 (+{WeaponUpgrade})";
        text2.text = $"공격력 : {Damage}";
        text3.text = $"강화 수치 : {EnhancementFigures} / 10";
        text4.text = $"성공 확률 : {Probability}%";
        text6.text = $"총 비용 : {SpendMoney}원";
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
        text5.text = $"Space를 눌러 강화를 시도하세요";
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            int tmp = Random.Range(0, 100);
            if (WeaponUpgrade == 10)
            {
                SettingText();
                text5.text = $"축축 당신은 호구입니다 ㅋㅋ";
            }
            else if (tmp > Probability)
            {
                ReinforcementFailed();
                SettingText();
                text5.text = "강화 실패 ㅠ";  
            }
            else
            {
                ReinforcementSuccess();
                SettingText();
                text5.text = "강화 성공 !";
            }
        }
    }
}
