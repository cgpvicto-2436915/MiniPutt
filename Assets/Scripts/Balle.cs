using UnityEngine;

using UnityEngine.InputSystem;

public class Balle : MonoBehaviour
{
    
    private Rigidbody rb;

    [SerializeField]
    private float force = 10f;

    public InputAction lancerAction;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();

    }
    private void Start()
    {
        lancerAction.Enable();
        lancerAction.performed += Lancer;
    }

    public void Lancer(InputAction.CallbackContext context)
    {

        rb.AddForce(Vector3.right * force, ForceMode.Impulse);
    } 
    private void OnDestroy()
    {
        lancerAction.performed -= Lancer;
        lancerAction.Disable();
    }

}
