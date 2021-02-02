using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject Road, Player;
    public void StartGame()
    {
        SceneManager.LoadScene("Game");
        RoadMove.isCrashed = false;
        MainCarMove.isCrashed = false;
        EnemyMove.isCrashed = false;
        EnemyGenerate.isCrashed = false;
        Score.isCrashed = false;
        EnemyGenerate.TimeOfGeneration = 1f;
        EnemyMove.speed = 10f;
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
