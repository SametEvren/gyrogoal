using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpIt : MonoBehaviour
{
    //float timeCounter = 0;
    //[SerializeField]
    //private Transform _Player;
    //[SerializeField]
    //private Transform _Yon;

    
    //float speed;
    //float width;
    //float height;
    float thrust = 15.0F;

    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        
        //speed = 1;
        //width = 3.0F;
        //height = 3.0F;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 direction = (_Player.position - _Yon.position).normalized;

        //timeCounter += Time.deltaTime * speed;
        //float x = Mathf.Cos(timeCounter) * width;
        //float z = Mathf.Sin(timeCounter) * height;
        //arka arkaya basinca oyun buga giriyor duzelt.
        if (Input.GetKeyDown(KeyCode.A))
        {
            GameObject.Find("Ball").GetComponent<Movement>().enabled = false;
            //rb.velocity = new Vector3(x, 0f, z);
            rb.AddForce(transform.position *thrust, ForceMode.Impulse);
            FindObjectOfType<AudioManager>().Play("Mizrak");
        }


        //if (Input.GetKeyDown(KeyCode.Space))
        //{

        //

        //}
    }
}
