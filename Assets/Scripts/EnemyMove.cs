using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public static float speed = 10f;
    private float z;
    private Vector3 vec = new Vector3(0, 0, 1);
    public static bool isCrashed = false;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isCrashed == false)
        {
            transform.Translate(-vec * speed * Time.deltaTime);
        }

        z = transform.position.z;
        if(z < -8)
        {
            Destroy(gameObject);
        }
    }
}
