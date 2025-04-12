using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyhit : MonoBehaviour
{
    public GameObject projectilePrefab;
    public Transform firepoint;
    public float progectilespeed = 20f;
    public float firerate = 0.5f;
    private float nextfiretime = 0f;
    //public AnimationClip fireclip;
    //public Animator aniamtor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Animator animator = GetComponent<Animator>(); 
        if (gameObject.CompareTag("Player"))
        {
            if (Input.GetMouseButton(0)&& Time.time > nextfiretime)
            {
                FireProjectile();
                nextfiretime = Time.time + firerate;
            }

        }
        else 
        {
            if(Time.time >= nextfiretime)
            {
                FireProjectile();
                //aniamtor.SetTrigger("alitlefemboylover");
                nextfiretime = Time.time + firerate;
            }
        }
        
    }
    void FireProjectile()
    {
        GameObject projectile = Instantiate(projectilePrefab, firepoint.position, firepoint.rotation);

        Rigidbody rb = projectile.GetComponent<Rigidbody>();
        if(rb != null)
        {
            rb.AddForce(firepoint.forward * progectilespeed, ForceMode.VelocityChange);
        }
    }
}
