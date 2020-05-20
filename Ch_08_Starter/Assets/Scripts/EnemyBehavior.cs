using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour 
 {
     // 1
     void OnTriggerEnter(Collider other)
     {
         //2 
         if(other.name == "Player")
         {
             Debug.Log("Player detected - attack!");
         }
     }
 
     // 3
     void OnTriggerExit(Collider other)
     {
         // 4
         if(other.name == "Player")
         {
             Debug.Log("Player out of range, resume patrol");
         }
     }
 } 
