using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disappear : MonoBehaviour
{
    // Start is called before the first frame update
    public static int mCount = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
       
        if (other.gameObject.tag=="Player")
        { 

            mCount++;
            Debug.Log(mCount);
            Destroy(gameObject);
        }
    }
}