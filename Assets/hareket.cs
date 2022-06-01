using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hareket : MonoBehaviour
{
    float hiz = 10;
    bool ziplama;
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "havuc")
        {
            audioSource.Play();

        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag=="yol")
        {
            ziplama = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
               transform.Translate(0, 0, hiz * Time.deltaTime);

          if (Input.GetKey(KeyCode.D)&&transform.position.x<58.5f)
        {
            transform.Translate(hiz * Time.deltaTime, 0, 0);
        }
          if (Input.GetKey(KeyCode.A)&&transform.position.x>55.26f)
        {
            transform.Translate(-hiz * Time.deltaTime, 0, 0);
        }
        
          
        if (Input.GetKey(KeyCode.Space)&&ziplama)
        {
            ziplama = false;

            GetComponent<Rigidbody>().AddForce(0,200f, 0);
            
        }
    }
}
