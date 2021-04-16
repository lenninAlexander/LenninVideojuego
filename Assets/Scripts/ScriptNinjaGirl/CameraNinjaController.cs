using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraNinjaController : MonoBehaviour
{
    public GameObject Ninja;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var x = Ninja.transform.position.x + 15;
        var y = Ninja.transform.position.y + 5;
        transform.position = new Vector3(x, y, transform.position.z);
    }
}
