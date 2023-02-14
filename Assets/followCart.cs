using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followCart : MonoBehaviour
{

    public GameObject followObj;
    public GameObject dollySystem;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        followObj.transform.position = this.transform.position;
    }
}
