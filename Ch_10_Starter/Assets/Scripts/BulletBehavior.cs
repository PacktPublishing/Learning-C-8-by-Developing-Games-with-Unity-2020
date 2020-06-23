using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour
 {
     // 1
     public float onscreenDelay = 3f;

     void Start () 
     {
         // 2
         Destroy(this.gameObject, onscreenDelay);
     }
 }
