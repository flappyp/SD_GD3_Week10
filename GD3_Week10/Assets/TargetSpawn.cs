using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSpawn : MonoBehaviour
{
    public GameObject[] targetPrefabs;  // Array of target prefabs to spawn
    public int targetIndex;  // Not needed here; use local variable in SpawnTarget
    private float startDelay = 2f;  // Delay before the first target spawns
    private float spawnInterval = 1f;  // Interval between target spawns
    public float spawnY = 1.9f;  // Y position for spawning
    public float spawnX = 51f;  // X position for spawning
    public float spawnZ = 28f;  // Z position for spawning

    // Start is called before the first frame update
    void Start()
    {
        // Repeatedly call the SpawnTarget method after a delay
        InvokeRepeating("SpawnTarget", startDelay, spawnInterval);
    }

    // Method that handles spawning targets
    void SpawnTarget()
    {
        // Select a random target from the array
        int targetIndex = Random.Range(0, targetPrefabs.Length);

        // Define a spawn position using the predefined X, Y, Z coordinates
        Vector3 spawnPosition = new Vector3(spawnX, spawnY, spawnZ);

        // Spawn the selected target prefab at the spawn position with default rotation
        Instantiate(targetPrefabs[targetIndex], spawnPosition, Quaternion.identity);
    }
}
