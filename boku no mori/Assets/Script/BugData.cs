using UnityEngine;

[CreateAssetMenu]
public class BugData : ScriptableObject
{
    public int id;
    public string bugName;
    public Sprite icon;
    public int catchDifficulty;
    public BugSpawnType spawnType;
    public int spawnRate;
    public float speed;
}
