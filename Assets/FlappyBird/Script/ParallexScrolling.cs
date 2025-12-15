using UnityEngine;

public class Ground : MonoBehaviour
{
    public float parallexSpeed;
    private float lenth;
    Vector2 startPos;
    void Start()
    {
        lenth = GetComponent<SpriteRenderer>().bounds.size.x;
        startPos = transform.position;

    }
    void Update()
    {
        transform.Translate(Vector2.left * parallexSpeed * Time.deltaTime);
        if (transform.position.x <= -lenth)
        {
            transform.position += new Vector3(lenth * 3, 0, 0);
        }
    }
}
