using System;
using UnityEngine;
using UnityEngine.UI;
public class UpgradeUI : MonoBehaviour
{
    public Button button;
    public Text message;
    public Text icon_text;

    public UnitInventory inventory;

    private string[] materials = {"100 골드 + Ruby", "100 골드 + Ruby", "200 골드 + Sapphire + MagicRock", "최대 강화 완료"};

    private int upgrade = 0;
    private int max_Level => materials.Length - 1;

    private void Start()
    {
        button.onClick.AddListener(OnUpgradeBtnClick);
        // AddListener는 유니티의 UI의 이벤트에 기능을 연결해주는 코드
        // 전달할 수 있는 값의 형태가 정해져 있어서 그 형태대로 설계해줘야 한다
        // 다른 형태로 쓰는 경우 (매개변수가 다른 경우)라면 delegate를 활용
        // 유니티 인스펙터에서 확인 결과 알수 없음
        UpdateUI();
    }
    // 버튼 클릭시 호출 할 메소드 설계
    private void OnUpgradeBtnClick() 
    {
        PlayerItem playerItem = inventory.PlayerItem;
        PlayerItem playerItems = inventory.PlayerItems;
        string[] currentmaterial = materials[upgrade].Split(",");
        if (upgrade < max_Level)
        {
            upgrade++;
            foreach (string material in currentmaterial)
            {
                Debug.Log(material);
                switch (material)
                {
                    case "100":
                        playerItem.Money -= 100;
                        break;
                    case "200":
                        playerItem.Money -= 200; 
                        break;
                    case "Ruby":
                        playerItem.Ruby -= 1;
                        break;
                    case "Sapphire":
                        playerItem.Sapphire -= 1;
                        break;
                    case "MagicRock":
                        playerItem.MagicRock -= 1;
                        break;
                }
            }
            inventory.UpdateItem();
            UpdateUI();
        }
    }
    private void UpdateUI()
    {
        message.text = $"{materials[upgrade]}";
        icon_text.text = "Mega +" + upgrade.ToString();

        message.text = materials[upgrade];
    }
}