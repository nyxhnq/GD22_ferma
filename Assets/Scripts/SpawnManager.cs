using System.Collections;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] GameObject[] animalPrefabs;
    [SerializeField] private float spawnRangeX = 10;
    [SerializeField] private float spawnPosZ = 20;

    [SerializeField] private float startDelay = 2f;
    [SerializeField] private float spawnInterval = 1.5f;

    [SerializeField] private float minSpawnInterval = 1f;
    [SerializeField] private float maxSpawnInterval = 3f;

    void Start()
    {
        //InvokeRepeating("SpawnRandomInterval", startDelay, spawnInterval);

        StartCoroutine(SpawnAnimalWithRandomInterval());    
    }

    private IEnumerator SpawnAnimalWithRandomInterval()
    { 
        yield return new WaitForSeconds(startDelay);

        while (true)
        {
            // Спавн животного
            SpawnRandomInterval();

            //Выбор случайного интервала для следующего спавна
            float randomInterval = Random.Range(minSpawnInterval, maxSpawnInterval);

            //Ожидание перед следующим спавном
            yield return new WaitForSeconds(randomInterval);
        }
    }
    void SpawnRandomInterval()
    {
         int animalIndex = Random.Range(0, animalPrefabs.Length);
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0 , -spawnPosZ);
            Instantiate(animalPrefabs[animalIndex], //префаб животного
                spawnPos, // позиция спавна
                animalPrefabs[animalIndex].transform.rotation); // поворот префаба
    }

}
