using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieDieDie : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerStay(Collider other)
    {
        other.gameObject.GetComponent<Rigidbody>().AddForce(other.gameObject.transform.up * 100);
    }
}
