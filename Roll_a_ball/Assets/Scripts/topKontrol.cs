using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class topKontrol : MonoBehaviour
{
    public int hiz = 5;
    public GameObject sayacText;
    public int sayac = 0;

    Rigidbody rigidbody_;
    void Start()
    {
        rigidbody_ = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float yatay = Input.GetAxisRaw("Horizontal");
        float dikey = Input.GetAxisRaw("Vertical");

        Vector3 vector = new Vector3(yatay,0,dikey);

        rigidbody_.AddForce(vector * hiz);

    }

   

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("topEngel"))
        {
            sayac++;
            sayacText.GetComponent<Text>().text= "Sayac: " + sayac;
            other.gameObject.SetActive(false);
        }

    }
}



