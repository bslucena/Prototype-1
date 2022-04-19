using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficFlow : MonoBehaviour
{

    private float trafficSpeed = 10.0f; 
   

    // Start is called before the first frame update
    void Start()
    {
       
    }   

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * trafficSpeed * Time.deltaTime);

    }

}
