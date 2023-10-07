using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookingToBall : MonoBehaviour
{

    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Kalenin topa donuk bir bicimde olmasini sagliyor.
        transform.LookAt(player.transform.position);
    }
}
