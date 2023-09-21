using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{ 
    public static List<Fruit> fruitList;
    public SpawnAndThrow spawnAndThrow;

    private void Awake()
    {
        fruitList = new List<Fruit>();
    }

    void Update()
    {
        if (GameManager.fruitList.Count < 1)
        {
            spawnAndThrow.spawnNthrow();
        }
    } 
}