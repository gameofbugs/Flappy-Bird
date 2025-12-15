using UnityEngine;


[CreateAssetMenu(fileName = "New LevelData", menuName = "Game/Level Data")]
public class Level : ScriptableObject
{
    public float minGapY;
    public float maxGapY;
    public float timeDuration;
    public float obstacleSpeed;
}

