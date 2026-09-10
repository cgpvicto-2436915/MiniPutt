using UnityEngine;

public class BounceScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField]
    private float force = 10f;

    private void OnTriggerEnter(Collider other)
    {
        Rigidbody rb = other.gameObject.GetComponent<Rigidbody>();

        if(rb != null )
        {
            Debug.Log("Force");
            rb.AddForce(Vector3.up * force, ForceMode.Impulse);
            
        }
            
        Debug.Log("Collision avec : " + other.gameObject.name);
    }
}
