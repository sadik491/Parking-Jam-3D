using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pathSelection : MonoBehaviour
{
    public FlwPolice flwPolice;
    private void OnTriggerEnter(Collider other)
    {
        flwPolice.enabled = true;
    }

}
