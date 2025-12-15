using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager Instance;
    public LevelSelectionUI ui;
    public Level easy;
    public Level medium;
    public Level hard;

    public Level currentLevel {  get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public void Start()
    {
    }
    public void SetLevel(Level level)
    {
        currentLevel = level;
        ui.Play();
    }    
}
