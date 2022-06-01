using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class havucoluştur : MonoBehaviour
{

    public GameObject havuc;
    int kontrol=0;

   

    void Start()
    {
        do
        {
            GameObject newhavuc = Instantiate(havuc,new Vector3(Random.Range(55.5f, 58.5f), Random.Range(10.3f,11), Random.Range(-310, -100)), Quaternion.EulerAngles(-90,0,0));
            kontrol += 1;
        } while (kontrol<35);

        do
        {
            GameObject newhavuc = Instantiate(havuc, new Vector3(Random.Range(56.16f, 57.5f), Random.Range(10.3f, 11), Random.Range(-99, -84)), Quaternion.EulerAngles(-90, 0, 0));
            kontrol += 1;
        } while (kontrol < 40);

        do
        {
            GameObject newhavuc = Instantiate(havuc, new Vector3(Random.Range(57.12f, 58.44f), Random.Range(10.3f, 11), Random.Range(-70, -45)), Quaternion.EulerAngles(-90, 0, 0));
            kontrol += 1;
        } while (kontrol < 50);

        do { 
        GameObject newhavuc = Instantiate(havuc, new Vector3(Random.Range(55.5f, 58.5f), Random.Range(10.3f, 11), Random.Range(-44, 16)), Quaternion.EulerAngles(-90, 0, 0));
        kontrol += 1;
    } while (kontrol<65);
    
    }

    

    void Update()
    {
        
    }
}
