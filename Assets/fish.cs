using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
 public class fish : MonoBehaviour {
     private Vector3 pos1 = new Vector3(0,72,0);
     private Vector3 pos2 = new Vector3(25,72,0);
     public float speed = 10.0f;
 
     void Update() {
         transform.position = Vector3.Lerp (pos1, pos2, (Mathf.Sin(speed * Time.time) + 1.0f) / 2.0f);
     }
 }