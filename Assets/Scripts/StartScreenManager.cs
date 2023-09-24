using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScreenManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void StartClassical()
    {
        SceneManager.LoadScene("GamePlay");
        GameManager.IsGameOver = false;

        GameManager.backwardsTime = true;
        GameManager.lives = 3;

        GameManager.allObjects = new List<ThrowableObject>(0);
    }
    public void StartHardcore()
    {
        SceneManager.LoadScene("GamePlay");
        GameManager.IsGameOver = false;

        GameManager.lives = 1;
        GameManager.allObjects = new List<ThrowableObject>(0);

    }
    public void StartSurvival()
    {
        SceneManager.LoadScene("GamePlay");
        GameManager.IsGameOver = false;

        GameManager.lives = 3;
        GameManager.allObjects = new List<ThrowableObject>(0);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
