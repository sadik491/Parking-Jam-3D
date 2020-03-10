using UnityEngine;
using PathCreation;

public class FlwPolice : MonoBehaviour
{
    public PathCreator pathCreator;
    public float speed = 5;
    public float distanceTravel;
    
    void Update()
    {
        distanceTravel += speed * Time.deltaTime;
        transform.position = pathCreator.path.GetPointAtDistance(distanceTravel);
        transform.rotation = pathCreator.path.GetRotationAtDistance(distanceTravel);
    }
}
