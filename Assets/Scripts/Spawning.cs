using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawning : MonoBehaviour
{
    public static GameObject prefab;
    public static Vector3 a;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public static void Spawn()
    {
        float randomXSpawn = UnityEngine.Random.Range(-9.0f, 10.0f);
        float randomYSpawn = -6.5f;
        if (randomXSpawn >= 7)
        {
            float randomXVector = UnityEngine.Random.Range(randomXSpawn - 3.0f, randomXSpawn);
            Vector3 vectorOfThrow = new Vector3(randomXVector, 0, 0);
            Vector3 vectorOfSpawn = new Vector3(randomXSpawn, randomYSpawn, 0);
            a = vectorOfThrow - vectorOfSpawn;
        }
        else if (randomXSpawn <= -7)
        {
            float randomXVector = UnityEngine.Random.Range(randomXSpawn, randomXSpawn + 3.0f);
            Vector3 vectorOfThrow = new Vector3(randomXVector, 0, 0);
            Vector3 vectorOfSpawn = new Vector3(randomXSpawn, randomYSpawn, 0);
            a = vectorOfThrow - vectorOfSpawn;
        }
        else
        {
            float randomXVector = UnityEngine.Random.Range(randomXSpawn - 3.0f, randomXSpawn + 3.0f);
            Vector3 vectorOfThrow = new Vector3(randomXVector, 0, 0);
            Vector3 vectorOfSpawn = new Vector3(randomXSpawn, randomYSpawn, 0);
            a = vectorOfThrow - vectorOfSpawn;
        }

        Instantiate(prefab).transform.position = new Vector3(randomXSpawn, randomYSpawn, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
