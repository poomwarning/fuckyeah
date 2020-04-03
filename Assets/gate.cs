using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gate : MonoBehaviour
{
   [SerializeField]
   GameObject door ;


    void OnTriggerEnter(Collider other) 
    {
      
           door.transform.position += new Vector3(0,4,0);
    
   }
}
