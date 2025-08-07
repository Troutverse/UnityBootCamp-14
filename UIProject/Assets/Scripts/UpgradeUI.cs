using System;
using UnityEngine;
using UnityEngine.UI;
public class UpgradeUI : MonoBehaviour
{
    public Button button;
    public Text message;
    public Text icon_text;

    public UnitInventory inventory;

    private string[] materials = {"100 ��� + Ruby", "100 ��� + Ruby", "200 ��� + Sapphire + MagicRock", "�ִ� ��ȭ �Ϸ�"};

    private int upgrade = 0;
    private int max_Level => materials.Length - 1;

    private void Start()
    {
        button.onClick.AddListener(OnUpgradeBtnClick);
        // AddListener�� ����Ƽ�� UI�� �̺�Ʈ�� ����� �������ִ� �ڵ�
        // ������ �� �ִ� ���� ���°� ������ �־ �� ���´�� ��������� �Ѵ�
        // �ٸ� ���·� ���� ��� (�Ű������� �ٸ� ���)��� delegate�� Ȱ��
        // ����Ƽ �ν����Ϳ��� Ȯ�� ��� �˼� ����
        UpdateUI();
    }
    // ��ư Ŭ���� ȣ�� �� �޼ҵ� ����
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