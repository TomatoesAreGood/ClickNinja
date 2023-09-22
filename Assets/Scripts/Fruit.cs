using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using Unity.VisualScripting;
using UnityEngine;

public class Fruit : MonoBehaviour
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
        // Update is called once per frame

        void OnMouseDown()
        {
            if (IsBomba)
            {
                Debug.Log("You die");
                GameManager.GameOver();
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
