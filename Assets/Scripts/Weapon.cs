﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bullet;
    public AudioClip fireSound;
    public float fireRate;

    // Update is called once per frame
    void Update()
    {
        // if (Input.GetButtonDown("Fire1"))
        // {
        //     Shoot();
        // }
    }

    public void Shoot()
    {
        // if(Time.time > nextFire)
        // {
            // nextFire = Time.time + fireRate;
            Instantiate(bullet, firePoint.position, firePoint.rotation);
            AudioController.audioInstance.PlayOneShot(fireSound);
        // }
        
        // RaycastHit2D hitInfo = Physics2D.Raycast(firePoint.position, firePoint.right);
    }
}
