using UnityEngine;

public class EnemyPathFinding : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 1f;

    private Rigidbody2D rb;

    private Vector2 moveDirection;

    private void Awake()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveDirection * (moveSpeed * Time.deltaTime));
    }

    public void MoveTo(Vector2 targetPos)
    {
        moveDirection = targetPos;
    }
}
