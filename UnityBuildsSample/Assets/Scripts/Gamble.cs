using UnityEngine;
using UnityEngine.UI;
using System;

public class RandomItem : EventArgs
{
    public int Number {  get; }
    public string[] ItemList = {"���", "���̾�", "�ٹ̾ƴ�", "����", "����Ŵ", "�����", "��", "��", "Į", "���ֺ�"};
    public string ItemName;

    public RandomItem(int number)
    {
        Number = number;
        ItemName = ItemList[number];
    }
}

public class Gamble : MonoBehaviour
{
    public event EventHandler<RandomItem> RandomItem;

    public Text NumberText;
    public Text ItemListText;

    public void GetItemButtonClick()
    {
        int randomNumber = UnityEngine.Random.Range(0, 10);

        RandomItem randomItemData = new RandomItem(randomNumber);

        NumberText.text = randomNumber.ToString();
        ItemListText.text = randomItemData.ItemName + " ��÷ ����";

        RandomItem?.Invoke(this, randomItemData);
    }
}