using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class moneysCollect : MonoBehaviour
{


    private int Coin = 0;

    public Text output;

    public AudioSource source;
    public AudioClip clip;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Coin")
        {
            Coin++;
            output.text = Coin.ToString();
            Destroy(other.gameObject);
            source.PlayOneShot(clip);
        }
    }
}
