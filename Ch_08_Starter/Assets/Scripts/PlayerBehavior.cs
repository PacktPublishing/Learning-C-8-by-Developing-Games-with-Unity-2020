using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour 
 {
   public float moveSpeed = 10f;
   public float rotateSpeed = 75f;
 
   private float vInput;
   private float hInput;
 
    // 1
         private Rigidbody _rb;
 
    // 2
         void Start()
         {
             // 3
             _rb = GetComponent<Rigidbody>();
         }
 
     void Update()
     {
       vInput = Input.GetAxis("Vertical") * moveSpeed;
       hInput = Input.GetAxis("Horizontal") * rotateSpeed;
    

       /* 4
       this.transform.Translate(Vector3.forward * vInput * 
       Time.deltaTime);
       this.transform.Rotate(Vector3.up * hInput * Time.deltaTime);
       */
     }

     // 1
void FixedUpdate()
{
        // 2
        Vector3 rotation = Vector3.up * hInput;

        // 3
        Quaternion angleRot = Quaternion.Euler(rotation * Time.fixedDeltaTime);

        // 4
        _rb.MovePosition(this.transform.position + this.transform.forward * vInput * Time.fixedDeltaTime);

        // 5
        _rb.MoveRotation(_rb.rotation * angleRot);
}
 } 
