using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageZones : MonoBehaviour
{
    void OnTriggerStay2D(Collider2D other)
    {
        RubysController controller = other.GetComponent<RubysController >();

        if (controller != null)
        {
            controller.ChangeHealth(-1);
        }
    }

}
