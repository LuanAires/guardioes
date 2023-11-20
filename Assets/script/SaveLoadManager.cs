using UnityEngine;
using System.IO;


[System.Serializable]
public class PlayerData
{

    //PC
    public string playerName;
    public string race;
    public string classe;

    public float Health;
    public float Energy;
    public float Resistance;
    public int Moedas;
    public int XP;
 
}

public class SaveLoadManager : MonoBehaviour
{
    public PlayerData playerData;
    private string saveFilePath;
    private void Awake()
    {
        
        // Set the save file path based on the application's persistent data path
        saveFilePath = Path.Combine(Application.persistentDataPath, "C:/droidzone/playerdata.json");
    }

    private void Start()
    {
        //LoadPlayerData();
    }

    public bool SavePlayerData()
    {
        // Serialize the player data to JSON format
        string jsonData = JsonUtility.ToJson(playerData);

        // Save the JSON data to the file
        File.WriteAllText(saveFilePath, jsonData);

        Debug.Log("Player data saved to: " + saveFilePath);

        return true;
    }

    public void LoadPlayerData()
    {
        if (File.Exists(saveFilePath))
        {
            // Load the JSON data from the file
            string jsonData = File.ReadAllText(saveFilePath);

            // Deserialize the JSON data back to player data object
            playerData = JsonUtility.FromJson<PlayerData>(jsonData);

            Debug.Log("Player data loaded from: " + saveFilePath);
        }
        else
        {
            // If the save file doesn't exist, create a new player data object
            playerData = new PlayerData();

            Debug.Log("No save file found. New player data created.");
        }
    }
    public void DeletePlayerData()
    {
        if (File.Exists(saveFilePath))
        {
            // Delete the save file
            File.Delete(saveFilePath);

            Debug.Log("Player data deleted: " + saveFilePath);
        }
        else
        {
            Debug.Log("No save file found. Nothing to delete.");
        }
    }
    public bool IsSaveFileExists()
    {
        return File.Exists(saveFilePath);
    }

}
