using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealtStat : MonoBehaviour
{
    private float Health = 100;
    public void hit(float damage)
    {
        Health -= damage;
        if (Health<=0)
        {
            Debug.Log("Health zero");
        }
        else
        {
            Debug.Log("Current health amount :" + Health);
        }
    }
}
