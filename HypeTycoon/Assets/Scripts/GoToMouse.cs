using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToMouse : MonoBehaviour {
 
    
    private Vector3 target;
 
    void Start () {
        target = transform.position;
    }
     
    void Update () {
        if (Input.GetMouseButtonDown(0)) {
            target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            target.z = transform.position.z;
            target.x = target.x + 1;
            target.y = target.y + 1;
        }

        transform.position = target;
    }    
}

