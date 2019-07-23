using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{

    [Header("About Wave")]

    [SerializeField]
    float speed = 20f;

    [SerializeField]
    int sinHight = 10;




    // Update is called once per frame
    void FixedUpdate()
    {
        float radian;
        float theta;

        foreach (var boxcube in GameObject_cube.prefabsballs)
        {
            theta = (boxcube.transform.position.z + 1) + Time.time * speed;

            radian = Mathf.Deg2Rad * theta * sinHight;

            float sin = Mathf.Sin(radian);

           boxcube.transform.position = new Vector3(boxcube.transform.position.x, sin, boxcube.transform.position.z);
        }

    }


   
}
