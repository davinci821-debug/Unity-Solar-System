using UnityEngine;

public class RotateAround : MonoBehaviour
{
    //공전
    public Transform target;
    public float worldSpeed;

    //자전
    public float localSpeed;
    public float localAngle;
   
    void Start()
    {
        transform.eulerAngles = new Vector3(0, localAngle, 0);
    }

   
    void Update()
    {
        if (target != null)
        {
            transform.RotateAround(target.position, Vector3.up, worldSpeed * Time.deltaTime);
        };


        transform.Rotate(Vector3.up * localSpeed * Time.deltaTime);

    }
}
