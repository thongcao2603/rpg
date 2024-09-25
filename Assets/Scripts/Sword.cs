using System.Collections;
using UnityEngine;

public class Sword : MonoBehaviour
{
    private Animator myAnimator;

    private void Awake()
    {
        myAnimator = this.GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Attack();
            StartCoroutine(ResetAnimation());
        }
    }

    private void Attack()
    {
        myAnimator.SetTrigger("attack");
    }

    private IEnumerator ResetAnimation()
    {
        yield return new WaitForSeconds(1f);
        myAnimator.SetTrigger("swingup");
    }
}
