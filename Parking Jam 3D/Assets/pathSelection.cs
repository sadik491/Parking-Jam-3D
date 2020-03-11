using UnityEngine;

public class pathSelection : MonoBehaviour
{
    public FlwPolice flwPolice;
    public void OnTriggerEnter(Collider other)
    {
        flwPolice.enabled = true;
        Debug.Log("Run");
    }

}
