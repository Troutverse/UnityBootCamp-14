using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
public class PlayerItem
{
    public int Money;
    public int Ruby;
    public int Sapphire;
    public int MagicRock;
    public Dictionary<string, int> PlayerItems;
    
    
    public PlayerItem()
    {
        Money = 1000;
        Ruby = 3;
        Sapphire = 3;
        MagicRock = 3;
        PlayerItems = new Dictionary<string, int> { { "Money", 1000 }, { "Ruby", 3 }, { "Sapphire", 3 }, { "Money", 1000 } };
    }
}

public class UnitInventory : MonoBehaviour
{
    private PlayerItem playerItem;
    public Text ItemText;
    
    private void Start()
    {
        playerItem = new PlayerItem();
        UpdateItem();
    }
    public PlayerItem PlayerItem
    {
        get { return playerItem; }
    }

    public PlayerItem PlayerItems
    {
        get { return PlayerItems; }
    }
    public void UpdateItem()
    {
        ItemText.text = $"Money : {playerItem.Money}\nRuby : {playerItem.Ruby}\nSapphire : {playerItem.Sapphire}\nMagicRock : {playerItem.MagicRock}";
    }

}
