
using System.IO;
using UnityEngine;


public class SavePlayersData : MonoBehaviour
{
    public int Score, record = 0;
    public GameObject HardController;

    public void Save(int _Score)
    {
        PlayerPrefs.SetInt("RecordScore", Score);
        PlayerPrefs.Save();
    }

    public int Load()
    {
        if (PlayerPrefs.HasKey("RecordScore"))
        {
            record = PlayerPrefs.GetInt("RecordScore");
        }
        return record;
    }

    public void analys()
    {
        record = Load();
        Score = HardController.GetComponent<Score>().score;
        if(Score > record)
        {
            Save(Score);
            record = Score;
        }
    }
}
