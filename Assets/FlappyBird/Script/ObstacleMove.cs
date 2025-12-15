
using UnityEngine;

public class ObstacleMove : MonoBehaviour
{
    public Transform obstacleUp;
    public Transform obstacleDown;
    public float speed;
    public Transform score;
    private Rigidbody2D bird;
    private void Start()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if(player!=null)
        {
            bird = player.GetComponent<Rigidbody2D>();
        }
       speed = LevelManager.Instance.currentLevel.obstacleSpeed;
        Gap();
    }
    private void Update()
    {
        if (bird.gravityScale != 0f)
        {
            MoveObstacle();
        }
        if(transform.position.x<=-20f)
        {
            Destroy(gameObject);
        }
    }

    private void MoveObstacle()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
        score.transform.position = transform.position;

    }
    float gapAmount;
   

    private void Gap()
    {
        var level=LevelManager.Instance.currentLevel;
        float gapYMin = level.minGapY;
        float gapYMax = level.maxGapY;


        gapAmount = Random.Range(gapYMin, gapYMax);

        obstacleDown.localPosition = new Vector3(0, -gapAmount, 0);
        obstacleUp.localPosition = new Vector3(0, gapAmount, 0);
    }

}