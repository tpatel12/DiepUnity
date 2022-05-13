using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Gun //: MonoBehaviour
{
    public float fireTimer = 0;

    public float cost;
    public float bulletSpeed;
    public float damage;
    public float fireRate;
    public float angle;
    public int bullets;

    public Gun child1;
    public Gun child2;
    

    public Gun(float bs, float dm, float fr, float an, int b, int c) {
        bulletSpeed = bs;
        damage = dm;
        fireRate = fr;
        angle = an;
        bullets = b;
        cost = c;

    }

    


}
