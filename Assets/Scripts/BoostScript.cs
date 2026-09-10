using UnityEngine;

public class BoostScript : MonoBehaviour
{
    [SerializeField]
    private float force = 10f;

    private void OnTriggerEnter(Collider other)
    {
        Rigidbody rb = other.gameObject.GetComponent<Rigidbody>();

        if (rb != null)
        {
            Debug.Log("Force");
            rb.AddForce(-this.transform.forward * force, ForceMode.VelocityChange);

        }

        Debug.Log("Collision avec : " + other.gameObject.name);
    }
}
