using UnityEngine;

public class CompassArrow : MonoBehaviour
{
    // Fixed world direction (north in world coordinates)
    public Vector3 worldDirection = Vector3.forward;

    void Update()
    {
        // Flatten the direction so arrow stays horizontal
        Vector3 flatDirection = new Vector3(worldDirection.x, 0, worldDirection.z).normalized;

        // Rotate the arrow to point in that world direction
        transform.rotation = Quaternion.LookRotation(flatDirection, Vector3.up);
    }
}
