using UnityEngine;
using UnityEngine.UI;
using System;

public class RandomItem : EventArgs
{
    public int Number {  get; }
    public string[] ItemList = {"°ñµå", "´ÙÀÌ¾Æ", "´Ù¹Ì¾Æ´Ï", "±¸Âî", "¸¶¶¯Å´", "ÇÁ¶ó´Ù", "°Ë", "ÃÑ", "Ä®", "¿ìÁÖºö"};
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
        ItemListText.text = randomItemData.ItemName + " ´çÃ· ¤º¤º";

        RandomItem?.Invoke(this, randomItemData);
    }
}