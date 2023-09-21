using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAndThrow : MonoBehaviour
{
    // Start is called before the first frame update
    float generatedX;
    float generatedY;
    float vectorX;
    float vectorXRight;
    float vectorXLeft;
    float throwForce;
    float spriteDecider;
    Vector3 throwVector;
    public GameObject fruitPrefab;
    public Sprite watermelon;
    public Sprite banana;
    public Sprite bomba;    
    void Start()
    {
        spawnNthrow();
    }

    public void spawnNthrow()
    {
        GameObject fruit = Instantiate(fruitPrefab);
        SpriteRenderer sr = fruit.GetComponent<SpriteRenderer>();
        Rigidbody2D rb = fruit.GetComponent<Rigidbody2D>();
        spriteDecider = UnityEngine.Random.Range(1, 4);

        switch (spriteDecider)
        {
            case 1:
                sr.sprite = watermelon;
                break;
            case 2:
                sr.sprite = banana;
                break;
            case 3:
                sr.sprite = bomba;
                break; 
        }

        //Generation of x,y and vector x coordinates
        generatedX = UnityEngine.Random.Range(-12, 12); ;
        generatedY = -6;    

        //Instantiation of "fruit" gameObject
        fruit.transform.position = new Vector3 (generatedX, generatedY, 0);

        //if statement to determine which direction gameobject should be thrown
        if (fruit.transform.position.x <= -7)
        {
            vectorXRight = UnityEngine.Random.Range(generatedX, generatedX + 2);
            throwVector = new Vector3(vectorXRight, 0f, 0f) - new Vector3(generatedX, generatedY, 0f);
        }
        else if (fruit.transform.position.x >= 7)
        { 
            vectorXLeft = UnityEngine.Random.Range(generatedX, generatedX - 2);
            throwVector = new Vector3(vectorXLeft, 0f, 0f) - new Vector3(generatedX, generatedY, 0f);
        }
        else
        {
            vectorX = UnityEngine.Random.Range(generatedX - 2, generatedX + 2);
            throwVector = new Vector3(vectorX, 0f, 0f) - new Vector3(generatedX, generatedY, 0f);
        }

        //throw vector calculation, throwForce Generation, Add force to gameObject
        throwForce = UnityEngine.Random.Range(0.75f, 1.20f);
        rb.AddForce(throwVector * 100 * throwForce);


    }

    


    // Update is called once per frame
    void Update()
    {

        
    }
}
