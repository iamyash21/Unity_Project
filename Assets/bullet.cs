using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    // Start is called before the first frame update


    float speed = 5; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        
        transform.Translate(Vector3.up*speed * Time.deltaTime);

        if (transform.position.y > 6)
        {
            Destroy(gameObject);
        }

    }
}
