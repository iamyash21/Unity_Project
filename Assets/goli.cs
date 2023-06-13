using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goli : MonoBehaviour
{
    // Start is called before the first frame update


    public float fireable = 0;
    public float fireRate = 1;
    public GameObject perfab;
    float speed = 5;

    void Update()
    {
        //transform.Translate(Vector3.down* speed * Time.deltaTime);

        if (fireable < Time.time)
        {
            
            Instantiate(perfab, new Vector3(Random.Range(-14,14),5,0) , Quaternion.identity,this.transform);
            fireable = fireRate + Time.time;
        }


        //if (transform.position.y > 6)
        //{
        //  Destroy(gameObject);
        //}

    }


  
}
