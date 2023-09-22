using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Fruit : MonoBehaviour
{
    public bool IsBomba = false;

    void OnEnable()
    {
        GameManager.fruitList.Add(this);
    }

    void OnDisable()
    { 
            GameManager.fruitList.Remove(this);
        
    }

    // Update is called once per frame

    void OnMouseDown()
    {
        if (IsBomba)
        {
            Debug.Log("You die");

        }
        Destroy(gameObject);
    }
    
    void Update()
    {
        if (transform.position.y <= -7)
        {
            Destroy(gameObject);
        }
    }
}
