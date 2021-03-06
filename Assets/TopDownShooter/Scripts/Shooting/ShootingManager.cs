using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace TopDownShooter.Shooting
{
    public class ShootingManager : MonoBehaviour
    {
        public void Shoot(Vector3 from,Vector3 direction)
        {
            RaycastHit hit;
            bool rayHit  =  Physics.Raycast(transform.position, direction, out hit, Mathf.Infinity);

            Debug.DrawLine(transform.position,transform.position + direction*10,Color.blue,2);
            Debug.DrawRay(transform.position, direction, Color.red, 2);
            if (rayHit == true)
            {
                
                Debug.Log(hit.collider.name);
                var healtStat = hit.collider.GetComponent<HealtStat>();
                if (healtStat!=null)
                {
                    healtStat.hit(5);
                }
            }
        }
    }
}

