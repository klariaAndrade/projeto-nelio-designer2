using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Simple_Move : MonoBehaviour
{
   [SerializeField]
   private float SpeedFactor = 1f;

    void Start()
    {
       
    }

    void Update()
    {
        float So = transform.position.x;
        float S = So + SpeedFactor * Time.deltaTime; 
        transform.position = new Vector3(transform.position.x + 0.1f, transform.position.y, transform.position.z);

    }
}
