using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explotion : MonoBehaviour
{
    [SerializeField] private GameObject particle;
    [SerializeField] private GameObject explosion;
    [SerializeField] private string tag;
    [SerializeField] private string enemy;
    public GameObject player;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == tag)
        {
            explosion = Instantiate(particle, transform.position, transform.rotation);
            Destroy(explosion, 2f);
            if (tag == "Object")
            {
                Destroy(player);
            }
            else
            {
                if (collision.collider.tag == enemy)
                {
                    Destroy(collision.collider);
                }
            }
        }
    }
}
