using UnityEngine;


public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 1f;
    private Vector2 movement;
    private Rigidbody2D rd;

    private Vector3 direction;

    private void Awake()
    {

        rd = this.GetComponent<Rigidbody2D>();
    }



    private void Update()
    {
        direction = MoveDirection(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        this.transform.position += direction * moveSpeed * Time.deltaTime;
    }

    private Vector3 MoveDirection(float _moveHorizontal, float _moveVertical)
    {
        return new Vector3(_moveHorizontal, _moveVertical, 0);
    }

}
