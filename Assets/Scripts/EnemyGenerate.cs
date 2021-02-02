using System.Collections;
using UnityEngine;

public class EnemyGenerate : MonoBehaviour
{
    public GameObject Enemy, EnemyLeft, EnemyRight;
    public static bool isCrashed = false;
    public static float TimeOfGeneration = 1f;
    //public Transform Left, Center, Right;
    //public Transform[] Positions;
    public Transform Parent;
    private Coroutine generate;

    void Start()
    {
        generate = StartCoroutine("Generate");
    }

    void Update()
    {
        if (isCrashed)
        {
            StopCoroutine(generate);
        }
    }

    IEnumerator Generate()
    {
        while (!isCrashed)
        {
            Spawn();
            yield return new WaitForSeconds(TimeOfGeneration);
        }
    }

    void Spawn()
    {
        int marker = Random.Range(1, 5);
        switch (marker)
        {
            case 1:
                {
                    GameObject EL = Instantiate(EnemyLeft, Parent) as GameObject;
                    break;
                }
            case 2:
                {
                    GameObject E = Instantiate(Enemy, Parent) as GameObject;
                    break;
                }
            case 3:
                {
                    GameObject ER = Instantiate(EnemyRight, Parent) as GameObject;
                    break;
                }
            case 4:
                break;
        }
    }


}
