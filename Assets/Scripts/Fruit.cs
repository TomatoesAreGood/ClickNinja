using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Fruit : MonoBehaviour
{
    void OnEnable()
    {
        GameManager.fruitList.Add(this);
        Debug.Log(GameManager.fruitList.Count);
    }

    void OnDisable()
    {
        GameManager.fruitList.Remove(this);
        Debug.Log(GameManager.fruitList.Count);
    }

    // Update is called once per frame

    
    void Update()
    {
        if (transform.position.y <= -7)
        {
            Destroy(gameObject);
        }
    }
}
