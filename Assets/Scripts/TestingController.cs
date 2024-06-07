using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class TestingController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float speed = 10;
        float y = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        float x = 10 * Time.deltaTime * speed;

        //transform.rotation = Quaternion.Euler(0,x,0);
       // transform.localRotation = Quaternion.Euler(0, 1,0);
       //transform.rotation = new Quaternion(0,1,0,1);   
        //transform.Translate(0,0,y);
        transform.Rotate(0, x, 0);
    }
}
