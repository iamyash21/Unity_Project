using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
   public float e_speed = 5;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "MyBullet")
        {
            Destroy(this.gameObject);
            Destroy(other.gameObject);
        }
        else if (other.gameObject.tag == "player" && other.gameObject.TryGetComponent<player>(out player give))
        {
            give.Reducehealth();
        }
            
    }

    void Update()
    {

        transform.Translate(Vector3.down * e_speed * Time.deltaTime);


        if (transform.position.y < -5)
        {
            Destroy(gameObject);
        }

     

    }



    
}

   



    

