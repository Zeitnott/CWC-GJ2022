using UnityEngine;

public class Trajectory : MonoBehaviour
{
    [SerializeField] Transform P0;
    [SerializeField] Transform P1;
    [SerializeField] Transform P2;
    [SerializeField] Transform P3;

    [Range(0, 1)] [SerializeField] private float t;
    void Update()
    {
        if (Input.GetKey(KeyCode.A)) 
        {
            t = t - Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            t = t + Time.deltaTime;
        }

        transform.position = Bezier.GetPosition(P0.position, P1.position, P2.position, P3.position, t);
        transform.rotation = Quaternion.LookRotation(Bezier.GetFirstDerivative(P0.position, P1.position, P2.position, P3.position, t));
    }
}
