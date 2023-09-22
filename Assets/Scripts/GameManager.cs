using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{ 
    public static List<Fruit> allObjects;
    public SpawnAndThrow spawnAndThrow;
    public static GameObject gameObj;
    public static bool IsGameOver;
    
    private void Awake()
    {
        allObjects = new List<Fruit>();
        gameObj = this.GetComponent<GameObject>();
    }

    void Update()
    {
        if (!IsGameOver)
        {
            if (allObjects.Count < 2)
            {
                spawnAndThrow.spawnNthrow();
            }
        }
        
    }

    public static void GameOver()
    {
        IsGameOver = true;
        List<Fruit>destroyedFruit = new List<Fruit>();
        foreach (var fruit in allObjects)
        {
            destroyedFruit.Add(fruit);
        }
        foreach(var fruit in destroyedFruit) 
        { Destroy(fruit.gameObject); }
        Destroy(gameObj);
        Debug.Log("Destroyed the thing");
    }
    

}