using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{

    public Transform projectilePos;
    public Projectile projectile;
    //private int dmg = 1;
 
    // Update is called once per frame
    void Update()
    {
       //get player input
       if(Input.GetMouseButtonDown(1)){
        //spawn a projectile
            Instantiate(projectile,projectilePos.position,projectilePos.rotation);
       }

    }
}
