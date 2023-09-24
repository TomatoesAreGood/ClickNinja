using System.Collections;
using System.Collections.Generic;
using UnityEditor.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : MonoBehaviour
{ 
    public static int score;
    public static float time;
    public static int lives;
    public static bool backwardsTime = false;

    [SerializeField] public TimeText timeText;
    [SerializeField] public ScoreText scoreText;
    [SerializeField] public LivesText livesText;

    public static List<ThrowableObject> allObjects;
    public SpawnAndThrow spawnAndThrow;
    public static GameObject gameObj;
    public static bool IsGameOver;
    
    private void Awake()
    {
        allObjects = new List<ThrowableObject>();
        gameObj = gameObject;
        score = 0;
        if(backwardsTime){
            time = 60;
        }else{
            time = 0;
        }
    }
    

    private void Update()
    {   
        if (backwardsTime){
            time -= Time.deltaTime;
        }else{
            time += Time.deltaTime;
        }

        timeText.UpdateTime(time);
        scoreText.UpdateScore(score);
        livesText.UpdateLives(lives);
        
        List<ThrowableObject>destroyedFruit = new List<ThrowableObject>();
        if(Time.timeScale != 0){
            foreach (var obj in allObjects){
                if(Blade.circleCollider.IsTouching(obj.GetComponent<CircleCollider2D>())){
                    destroyedFruit.Add(obj);
                }
            }
        }
        foreach (var obj in destroyedFruit){
            if (obj.IsBomba){
                GameOver();
            }else{
                score++;
            }
            Destroy(obj.gameObject);
        }

        if(lives <= 0){
            GameOver();
        }
        if (backwardsTime){
            if(time <= 0){
                GameOver();
            }
        }

        if (!IsGameOver)
        {
            if (allObjects.Count < 3)
            {
               spawnAndThrow.spawnNthrow();
            }
        }
        
    }

    public static void GameOver()
    {
        IsGameOver = true;
        List<ThrowableObject>destroyedFruit = new List<ThrowableObject>();
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