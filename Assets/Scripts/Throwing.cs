using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class Throwing : MonoBehaviour
{
    public Vector3 throwVector;
    public Rigidbody2D rb;
    public static GameObject prefab;
    public static int numBombs = 0;
    public Vector3 a;



    private void Awake()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    void OnEnable()
    {
        rb.AddForce(a * 100 * UnityEngine.Random.Range(0.75f, 1.0f));
        numBombs++;
        Debug.Log("Bomb number: " + numBombs);

    }

    void OutOfBounds()
    {

        if (transform.position.y < -7)
        {
            numBombs--;
            Spawning.Spawn();
            Destroy(gameObject);

        }


    }

    private IEnumerator OnMouseDown()
    {
        numBombs--;
        yield return new WaitForSeconds(0.1f);
        Destroy(gameObject);

        Debug.Log("Bomb number: " + numBombs);

    }



    void Update()
    {
        OutOfBounds();
    }



}
