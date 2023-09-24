using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : MonoBehaviour
{ 
    public static int score;
    public static float time;
    public static int lives;
    [SerializeField] public TimeText timeText;
    [SerializeField] public ScoreText scoreText;
    [SerializeField] public LivesText livesText;

    public static List<Fruit> allObjects;
    public SpawnAndThrow spawnAndThrow;
    public static GameObject gameObj;
    public static bool IsGameOver;
    
    private void Awake()
    {
        allObjects = new List<Fruit>();
        gameObj = gameObject;
        score = 0;
        lives = 3;
        time = 0;
    }
    

    private void Update()
    {   
        time += Time.deltaTime;
        timeText.UpdateTime(time);
        scoreText.UpdateScore(score);
        livesText.UpdateLives(lives);
        
        if(lives <= 0){
            GameOver();
        }

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
        { 
            Destroy(fruit.gameObject); 
        }
        Destroy(gameObj);
        SceneManager.LoadScene("GameOver");
        
    }
    
    

}