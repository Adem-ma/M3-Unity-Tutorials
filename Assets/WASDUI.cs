using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WASDUI : MonoBehaviour
{

    [SerializeField]
    private Image wButton;

    [SerializeField]
    private Image aButton;

    [SerializeField]
    private Image sButton;

    [SerializeField]
    private Image dButton;

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.W))
        {
            wButton.color = Color.red;
        }
        else
        {
            wButton.color = Color.white;
        }


        if (Input.GetKey(KeyCode.A))
        {
            aButton.color = Color.red;
        }
        else
        {
            aButton.color = Color.white;
        }

        if (Input.GetKey(KeyCode.S))
        {
            sButton.color = Color.red;;
        }
        else
        {
            sButton.color = Color.white;
        }

        if (Input.GetKey(KeyCode.D))
        {
            dButton.color = Color.red;
        }
        else
        {
            dButton.color = Color.white;
        }

    }
}
