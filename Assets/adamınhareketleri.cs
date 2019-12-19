using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class adamınhareketleri : MonoBehaviour
{
    private float yatayDonme;
    private float dikeyDonme;
    public float hizDegeri = 5.0f;
    public float donusDegeri = 50f;
    private float dikeyEksen;
    private float yatayEksen;

    // Start is called before the first frame update
    void Start()
    { 
        
    }

    // Update is called once per frame
    void Update()
    {
        dikeyEksen = Input.GetAxis("Horizontal") * Time.deltaTime * hizDegeri;
        yatayEksen = Input.GetAxis("Vertical") * Time.deltaTime * hizDegeri;
        transform.Translate(dikeyEksen, 0.0f, yatayEksen);
        yatayDonme = Input.GetAxis("Mouse X") * Time.deltaTime * donusDegeri;
        transform.Rotate(0, yatayDonme, 0);


        if (Input.GetKeyDown(KeyCode.Q) == true)
        {
            transform.Translate(0, 100*Time.deltaTime, 0);


        }

    }



    private void OnCollisionEnter(Collision collision)  //otomatik çarptığım nesneyi bulur.
    {

        Debug.Log(collision.gameObject.name);
    }


}
