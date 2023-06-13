using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    // Start is called before the first frame update


    public GameObject perfab;
    [SerializeField]
    float m_speed = 2.5f;
    [SerializeField]
    float m_sspeed = 15.5f;

    GameObject something;


    public float M_speed = 5f;
    private float fireable;
    public float fire_rate = 1;

    GameObject containers;
    public GameObject pre;

    public float life = 3;








  
    void Start()
    {
        //transform.position =  Vector3.zero;

        something = new GameObject("Nothing");
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(m_speed*Time.deltaTime,m_speed*Time.deltaTime , 0);
        //transform.Translate(new Vector3(1, 1, 0) * Time.deltaTime);

        movment();
        fire();





    }


    void movment()
    {

        transform.Translate(new Vector3(Input.GetAxis("Horizontal"), 0, 0) * m_speed * Time.deltaTime);
        transform.Translate(new Vector3(0, Input.GetAxis("Vertical"), 0) * m_sspeed * Time.deltaTime);

        if (transform.position.y > 5)
        {
            transform.position = new Vector3(transform.position.x, 5, transform.position.z);
        }

        if (transform.position.y < -4.5)
        {
            transform.position = new Vector3(transform.position.x, -5, transform.position.z);
        }

        if (transform.position.x > 14)
        {
            transform.position = new Vector3(-15, transform.position.y, transform.position.z);
        }

        if (transform.position.x < -15)
        {
            transform.position = new Vector3(14, transform.position.y, transform.position.z);
        }



    }


    void fire()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //var fireK =  Instantiate(perfab, this.gameObject.transform.position, Quaternion.identity, something.transform);
            //fireK.transform.SetParent(something.transform);


            Instantiate(perfab, this.gameObject.transform.position, Quaternion.identity, something.transform);
        }



    }



    public void Reducehealth()
    {
        life--;
        Debug.Log(" player health = " + life);
        if (life == 0)
        {
            Destroy(this.gameObject);
        }

    }


}
