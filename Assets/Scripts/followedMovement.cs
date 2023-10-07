using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Kaleyle ayni hizada hareket eden ve gorunmeyen topun kodu.
public class followedMovement : MonoBehaviour
{
    float timeCounter = 0;

    float speed;
    float width;
    float height;
    // Start is called before the first frame update
    void Start()
    {
        speed = 3.2F;
        width = 3.0F;
        height = 3.0F;
    }

    // Update is called once per frame
    void Update()
    {
        timeCounter += Time.deltaTime * speed;

        float x = Mathf.Cos(timeCounter) * width;
        //float y = Mathf.Sin(timeCounter) * height;
        //float x = 5;
        float y = 0;
        float z = Mathf.Sin(timeCounter) * height; ;

        transform.position = new Vector3(x, y, z);
    }
}
