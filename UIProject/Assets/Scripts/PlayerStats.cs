using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public string Hero = "none";
    public string Sex = "none";
    public string Weapon = "none";

    public string GetStatusString()
    {
        return $"Hero: {Hero}\nSex: {Sex}\nWeapon: {Weapon}";
    }
}
