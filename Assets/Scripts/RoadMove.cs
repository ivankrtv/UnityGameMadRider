using UnityEngine;

public class RoadMove : MonoBehaviour
{
    public static float speed = 20f;
    private float tp = 42.3f;
    private float z;
    private Vector3 vec = new Vector3(0, 0, 1);
    public static bool isCrashed = false;


    void Update()
    {
        if (speed >= 0)
        {
            z = transform.position.z;
            if (z > -16.3 && isCrashed == false)
            {
                transform.Translate(-speed * vec * Time.deltaTime);
            }
            else if (isCrashed == false)
            {
                transform.Translate(tp * vec);
            }
        }
    }
}
