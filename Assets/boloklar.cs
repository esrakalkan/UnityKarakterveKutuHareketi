using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boloklar : MonoBehaviour
{
    private float counter = 1;
    private int rado = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        counter -= Time.deltaTime;

        if (counter < 0)
        {
            rado = Random.Range(1, 4);
            counter = 3;
        }

        if (rado == 1)
        {
            transform.position = new Vector3(transform.position.x + 0.01f, transform.position.y, transform.position.z);
        }
        if (rado == 2)
        {
            transform.position = new Vector3(transform.position.x - 0.01f, transform.position.y, transform.position.z);
        }
        if (rado == 3)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 0.01f);
        }
        if (rado == 4)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - 0.01f);
        }
    }
}
