using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarbageController : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision){
        if(this.gameObject.name == "GarbageCollector"){
            if(collision.gameObject.name == "Platform1" || collision.gameObject.name == "Platform2"){

            }else{
                Destroy(collision.gameObject);
            }
        }else{
            if(collision.CompareTag("Bullet"))
            {
                Destroy(collision.gameObject);
            }
        }
        
    }
    
}
