using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.U2D.IK;

public class Blade : MonoBehaviour
{
    public static CircleCollider2D circleCollider;
    private Rigidbody2D rb;
    private Camera cam;
    public Boolean isCutting;
    public GameObject bladeTrail;
    private GameObject currentBladeTrail;

    void Start(){
        rb = GetComponent<Rigidbody2D>();
        cam = Camera.main;
        circleCollider = GetComponent<CircleCollider2D>();
    }


    void Update(){
        if (Input.GetMouseButtonDown(0)){
            isCutting = true;
            currentBladeTrail = Instantiate(bladeTrail, transform);
        }else if(Input.GetMouseButtonUp(0)){
            isCutting = false;
            currentBladeTrail.transform.SetParent(null);
            Destroy(currentBladeTrail.gameObject);
        }
        if (isCutting){
            rb.position = cam.ScreenToWorldPoint(Input.mousePosition);
            transform.position = cam.ScreenToWorldPoint(Input.mousePosition);
            circleCollider.enabled = true;
        }
        Vector3 pos = transform.position;
        pos.z = 0;
        transform.position = pos;
    }

    private void FixedUpdate(){


    }

}
