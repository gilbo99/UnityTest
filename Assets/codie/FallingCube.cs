using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingCube : MonoBehaviour
{

    string dont;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
      if(collision.gameObject.tag != "Player" && collision.gameObject.tag != "Floor") 
      {
      
        print("Dont fucking Touch me");
        Destroy(collision.gameObject, 10);
      }
        
    }
}
