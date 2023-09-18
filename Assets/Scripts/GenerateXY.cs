using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GenerateXY : MonoBehaviour
{
    public GameObject fruit;
    float x;
    float y;

    private void Awake()
    {
        generateXY();
    }

    public void generateXY()
    {
        x = UnityEngine.Random.Range(-12, 11);
        y = UnityEngine.Random.Range(-6, 5);
        SpawningRevised spawnFruitXY = new SpawningRevised(x, y);
        ThrowingRevised throwFruitXY = new ThrowingRevised(x, y);
        Debug.Log("Generated x is: " + x);
        Debug.Log("Generated y is: " + y);
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
