
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 1f;
    private Vector2 movement;
    private Rigidbody2D rd;

    private void Awake()
    {

        rd = this.GetComponent<Rigidbody2D>();
    }



    private void Update()
    {

    }

    private void FixedUpdate()
    {

    }

    private void PlayerInput()
    {

    }

}
