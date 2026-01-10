using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampy : MonoBehaviour
{
    public float jumpSfactor = 100f;

      void OnTriggerEnter (Collider other)
    {
        print("ok");
        other.GetComponent<Jump>().jumpStrength *= jumpSfactor;
    }

      void OnTriggerExit (Collider other)
    {
        other.GetComponent<Jump>().jumpStrength /= jumpSfactor;
    }
}
