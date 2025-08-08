using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class PlayerStatsManager : MonoBehaviour
{
    public TMP_Dropdown HeroDropdown;
    public TMP_Dropdown SexDropdown;
    public TMP_Dropdown WeaponDropdown;

    public Text PlayerStatsText;

    private PlayerStats CurrentPlayerStats;

    void Start()
    {
        CurrentPlayerStats = new PlayerStats();

        UpdateStatusText();


        HeroDropdown.onValueChanged.AddListener(delegate { OnHeroDropdownChanged(); });
        SexDropdown.onValueChanged.AddListener(delegate { OnSexDropdownChanged(); });
        WeaponDropdown.onValueChanged.AddListener(delegate { OnWeaponDropdownChanged(); });
    }


    public void OnHeroDropdownChanged()
    {
        string selectedOption = HeroDropdown.options[HeroDropdown.value].text;
        CurrentPlayerStats.Hero = selectedOption;
        UpdateStatusText();
    }

    public void OnSexDropdownChanged()
    {
        string selectedOption = SexDropdown.options[SexDropdown.value].text;
        CurrentPlayerStats.Sex = selectedOption;
        UpdateStatusText();
    }

    public void OnWeaponDropdownChanged()
    {
        string selectedOption = WeaponDropdown.options[WeaponDropdown.value].text;
        CurrentPlayerStats.Weapon = selectedOption;
        UpdateStatusText();
    }


    private void UpdateStatusText()
    {

        PlayerStatsText.text = CurrentPlayerStats.GetStatusString();
    }
}
