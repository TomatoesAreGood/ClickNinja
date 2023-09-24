using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool isPaused = false;

    public GameObject pauseMenuUI;

    private List<ThrowableObject> pausedObjects;

    // Update is called once per frame

    private void Start(){
        pausedObjects = new List<ThrowableObject>(0);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)){
            if(isPaused){
                Resume();
            }else{
                Pause();
            }
        }
    }

    private void Resume(){
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
        // for (int i = 0; i < pausedObjects.Count; i++){
        //     pausedObjects[i].gameObject.SetActive(true);
        //     GameManager.allObjects.Add(pausedObjects[i]);
        // }
        // foreach(var obj in pausedObjects){
        //     obj.gameObject.SetActive(true);
        //     GameManager.allObjects.Add(obj);
        // }
    }

    private void Pause(){
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
        //  for (int i = 0; i < GameManager.allObjects.Count; i++){
        //     GameManager.allObjects[i].gameObject.SetActive(false);
        //     pausedObjects.Add(GameManager.allObjects[i]);
        // }
        // foreach(var obj in GameManager.allObjects){
        //     obj.gameObject.SetActive(false);
        //     pausedObjects.Add(obj);
        // }
    }
    
    public void LoadMenu(){
        SceneManager.LoadScene("StartScreen");
        Resume();
    }
    public void Quit(){
        Debug.Log("quitted game");
        Application.Quit();
    }
    public void ResumeGame(){
        Resume();
    }
}
