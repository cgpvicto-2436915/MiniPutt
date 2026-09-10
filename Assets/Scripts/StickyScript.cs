using UnityEngine;

public class StickyScript : MonoBehaviour

{

    [SerializeField]
    private float force = 2f;
    private void OnTriggerStay(Collider other)
    {
        Rigidbody rb = other.gameObject.GetComponent<Rigidbody>();

        if (rb != null)
        {
            Debug.Log("Force");
            rb.AddForce(-rb.linearVelocity * force);

        }
    }
}
