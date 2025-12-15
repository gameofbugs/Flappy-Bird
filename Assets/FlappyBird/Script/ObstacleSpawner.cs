using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{

    public GameObject obstacle;
    public Transform obstacleSpawnPoint;
    Rigidbody2D bird;

    private void Start()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player != null)
        {
            bird = player.GetComponent<Rigidbody2D>();
        }
    }
    private void Update()
    {
        if (bird.gravityScale != 0f)
        {
            ObstacleSpawnerAndMovement();
        }
    }
    float currentTime;
    float randomY;

    private void ObstacleSpawnerAndMovement()
    {
        randomY = Random.Range(-1.5f,2);
        float timeDuration = LevelManager.Instance.currentLevel.timeDuration;

        currentTime += Time.deltaTime;
        if (currentTime >= timeDuration)
        {
            GameObject Obstacle = Instantiate(obstacle, obstacleSpawnPoint.position, Quaternion.identity);
            Obstacle.transform.position= obstacleSpawnPoint.position+new Vector3(0,randomY,0);
            currentTime = 0;
        }
    }

}
