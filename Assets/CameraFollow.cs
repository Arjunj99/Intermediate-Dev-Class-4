using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public  Transform target;
    Vector3 offsetVector;



    // Start is called before the first frame update
    void Start()
    {
        offsetVector = this.transform.position - target.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = target.position + offsetVector;
        //newPos.x = this.transform.position.x;
        //newPos.y = this.transform.position.y;
        // transform.



        Vector3 moveVector = this.transform.position - newPos;
        moveVector *= 0.75f;
        newPos += moveVector;
        this.transform.position = newPos;
        // this.transform.position = Vector3.Lerp(this.transform.position, newPos, 0.2f);
        
        
        
        //this.transform.LookAt(target);
    }
}
