using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class GameLoad : MonoBehaviour
{
    public InputField InputName;
    public GameObject NewGamePenal;
    [SerializeField]
    class SaveGames
    {
        public int PlayTime;
        public int PlayCount;
        public int SavePoint;
        public string PlayerName;
    }
    private string SaveFilePath;
    void Start()
    {
        SaveFilePath = Path.Combine(Application.persistentDataPath, "GameSave.json");
        Debug.Log(SaveFilePath);
    }
    public void SaveGame()
    {
        SaveGames data = new SaveGames();
        data.PlayTime = 0;
        data.PlayCount = 0;
        data.SavePoint = 0;
        data.PlayerName = InputName.text;
        
        string json = JsonUtility.ToJson(data);

        File.WriteAllText(SaveFilePath, json);
        Debug.Log("Save");
    }
    public void LoadGame()
    {
        if (File.Exists(SaveFilePath))
        {
            string json = File.ReadAllText(SaveFilePath);
            SaveGames data = JsonUtility.FromJson<SaveGames>(json);
            Debug.Log($"플레이 시간: {data.PlayTime}초, 플레이 횟수: {data.PlayCount}회, 저장 지점: {data.SavePoint}, 플레이어 이름: {data.PlayerName}");
        }
    }
    public void NewGame()
    {
        NewGamePenal.SetActive(true);

    }
}
