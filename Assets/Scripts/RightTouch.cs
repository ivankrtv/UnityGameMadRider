using UnityEngine;
using UnityEngine.EventSystems;

public class RightTouch : MonoBehaviour//, IPointerDownHandler
{
    public GameObject Player;
    private float x;
    public float speed = 10f;
    public bool isCrashed = false;
    private Vector3 vec = new Vector3(1, 0, 0);

    private void OnMouseDrag()
    {
        x = Player.transform.position.x;
        if (x < 2 && isCrashed == false)
        {
            Player.transform.Translate(vec * speed * Time.deltaTime);
        }
    }
}
