using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using Unity.VisualScripting;
using UnityEngine;

public class ThrowableObject : MonoBehaviour
{
    public bool IsBomba = false;

    void OnEnable()
    {
        GameManager.allObjects.Add(this);
    }

    void OnDisable()
    {
        GameManager.allObjects.Remove(this);
    }

    void OnMouseDown()
    {
        if(Time.timeScale != 0){
            if (IsBomba)
            {
                Debug.Log("You die");
                GameManager.GameOver();
            }else{
                GameManager.score++;
            }
            Destroy(gameObject);
        }
    }

    void Update()
    {
        
        if (transform.position.y <= -7)
        {
            if(!IsBomba){
                GameManager.lives--;
            }
            
            Destroy(gameObject);
        }
    }

}
