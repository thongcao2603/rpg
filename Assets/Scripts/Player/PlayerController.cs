using UnityEngine;


public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 1f;

    private Rigidbody2D rd;

    private Vector3 direction;

    private SpriteRenderer spriteRenderer;
    private Animator myAnimator;

    private void Awake()
    {

        rd = this.GetComponent<Rigidbody2D>();
        spriteRenderer = this.GetComponent<SpriteRenderer>();
        myAnimator = this.GetComponent<Animator>();
    }



    private void Update()
    {
        direction = MoveDirection(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
    }

    private void FixedUpdate()
    {
        AdjustPlayerFacingDirection();
        Move();
    }

    private void Move()
    {
        if (direction != Vector3.zero)
        {
            this.transform.position += direction * moveSpeed * Time.deltaTime;
            myAnimator.SetBool("isWalking", true);
        }
        else
        {
            myAnimator.SetBool("isWalking", false);
        }
    }

    private Vector3 MoveDirection(float _moveHorizontal, float _moveVertical)
    {
        return new Vector3(_moveHorizontal, _moveVertical, 0);
    }

    private void AdjustPlayerFacingDirection()
    {
        Vector3 mousePos = Input.mousePosition;
        Vector3 playerScreenPoint = Camera.main.WorldToScreenPoint(transform.position);
        if (mousePos.x > playerScreenPoint.x)
        {
            spriteRenderer.flipX = false;
        }
        else if (mousePos.x < playerScreenPoint.x)
        {
            spriteRenderer.flipX = true;
        }
    }

}
