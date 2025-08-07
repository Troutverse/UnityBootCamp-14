using UnityEngine;
using UnityEngine.UI;

class Player
{
    public int HP;
    public int ATK;
    public int DEX;

    public Player()
    {
        HP = 100;
        ATK = 20;
        DEX = 10;
    }
}

public class UnitStat : MonoBehaviour
{
    Player player = new Player();
    public Text StatsText;
    void Start()
    { 
        UpdateStats();       
    }

    void UpdateStats()
    {
        StatsText.text = $"Mega Stats\nHP : {player.HP}\nATK : {player.ATK}\nDEX : {player.DEX}";
    }
}
