using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawningRevised : MonoBehaviour
{
    float XSpawnValue;
    float YSpawnValue;
    public GameObject fruit;

    public SpawningRevised(float XSpawnValue, float YSpawnValue){
        this.XSpawnValue = XSpawnValue; // "this" refers to the class, "Dot.XSpawnValue" refers to the class variable declared, XSpawnValue refers to constructor parameter
        this.YSpawnValue = YSpawnValue;
    }

    public void spawn(float XSpawnValue, float YSpawnValue)
    {
        Debug.Log("X Value is: " + XSpawnValue);
        Debug.Log("Y Value is: " + YSpawnValue);
        Instantiate(fruit).transform.position = new Vector3(XSpawnValue, YSpawnValue, 0);

    }
    void Start()
    {
        //GenerateXY.generateXY();
        spawn();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
