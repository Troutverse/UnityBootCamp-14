using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private SliderController sliderController;
    [SerializeField] private Button CreateMageBt;
    [SerializeField] private TMP_Text SizeText;

    [SerializeField] private Board board;
    [SerializeField] private Player _player;
    private void Start()
    {
        sliderController.SliderValueChange += SetSlideValue;
        CreateMageBt.onClick.AddListener(CreateMage);
    }

    private void SetSlideValue(float value)
    {
        SizeText.text = value.ToString();
        board.Size = (int)value;
    }
    
    private void CreateMage()
    {
        board.Initialze();
        board.Spawn();
        _player.Initialze(1, 1, board);
    }
}