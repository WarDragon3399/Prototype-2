using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spwanRangeX = 10;
    private float spwanPosZ = 20;
    private float stratDelay = 5f;
    private float swanInterval = 1.5f;
    public float sideSpawnMinZ;
    public float sideSpawnMaxZ;
    public float sideSpawnX;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", stratDelay, swanInterval);
        InvokeRepeating("SpawnLeftAnimal", stratDelay, swanInterval);
        InvokeRepeating("SpawnRightAnimal", stratDelay, swanInterval);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spwanPos = new Vector3(Random.Range(-spwanRangeX, spwanRangeX), 0, spwanPosZ);
        Instantiate(animalPrefabs[animalIndex], spwanPos, animalPrefabs[animalIndex].transform.rotation);
    }
    void SpawnLeftAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(-sideSpawnX, 0, Random.Range(sideSpawnMinZ, sideSpawnMaxZ));
        Vector3 rotation = new Vector3(0, 90, 0);
        Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.Euler(rotation));
    }
    void SpawnRightAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(sideSpawnX, 0, Random.Range(sideSpawnMinZ, sideSpawnMaxZ));
        Vector3 rotation = new Vector3(0, -90, 0);
        Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.Euler(rotation));
    }
}
