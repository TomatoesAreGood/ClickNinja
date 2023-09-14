using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Throwing : MonoBehaviour
{
    public Vector3 throwVector;
    public Rigidbody2D rb;
    public GameObject prefab;
    public static int numBombs = 0;
    public Vector3 a;

    private void Awake()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }
    

    private void Throw()
    {
        rb.AddForce(a * 100);
    }
    void OnEnable()
    {
        Throw();
        numBombs++;
        Debug.Log("Bomb number: " + numBombs);

    }

    private IEnumerator OnMouseDown(){
        numBombs--;

        yield return new WaitForSeconds(0.1f);
        Destroy(gameObject);
        
        Debug.Log("Bomb number: "+ numBombs);

    }


    private void Update()
    {

        

        
            }
            
        }
    
    
        
    


   







    
    
    

    
