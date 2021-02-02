﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour
{
    public GameObject Road, Player;
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Road.GetComponent<RoadMove>().isCrashed = false;
        Player.GetComponent<MainCarMove>().isCrashed = false;
        EnemyMove.isCrashed = false;
        EnemyGenerate.isCrashed = false;
        Score.isCrashed = false;
        EnemyGenerate.TimeOfGeneration = 1f;
        EnemyMove.speed = 10f;
    }
}
