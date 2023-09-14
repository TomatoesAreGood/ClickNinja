using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject prefab;
    public Vector3 a;

    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (Throwing.numBombs <= 0)
        {
            Debug.Log("Activated");
            int randomXSpawn = UnityEngine.Random.Range(-9, 10);
            int randomYSpawn = UnityEngine.Random.Range(-11, -6);
            int randomXVector = UnityEngine.Random.Range(randomXSpawn - 3, randomXSpawn + 3);
            Vector3 vector = new Vector3(randomXVector, 0, 0);
            Vector3 vector2 = new Vector3(randomXSpawn, randomYSpawn, 0);
            a = vector - vector2;
            Instantiate(prefab).transform.position = new Vector3(randomXSpawn, randomYSpawn, 0);

        }
        if (transform.position.y < -7)
        {
            int randomXSpawn = UnityEngine.Random.Range(-9, 10);
            int randomYSpawn = UnityEngine.Random.Range(-11, -6);
            int randomXVector = UnityEngine.Random.Range(randomXSpawn - 3, randomXSpawn + 3);
            Vector3 vector = new Vector3(randomXVector, 0, 0);
            Vector3 vector2 = new Vector3(randomXSpawn, randomYSpawn, 0);
            a = vector - vector2;
            Instantiate(prefab).transform.position = new Vector3(randomXSpawn, randomYSpawn, 0);
            Destroy(gameObject);
        }
    }
}