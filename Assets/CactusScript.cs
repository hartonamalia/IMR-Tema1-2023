using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CactusScript : MonoBehaviour
{

    private Animator cAnimator;
    public Transform otherCharacter;
    public float attackDistance = 0.01f;

    // Start is called before the first frame update
    void Start()
    {
        cAnimator = GetComponent<Animator>();
        if(cAnimator!=null)
        {
            cAnimator.SetTrigger("Idle");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(cAnimator!=null)
        {
            if(Vector3.Distance(transform.position, otherCharacter.position) < attackDistance)
            {
                cAnimator.SetTrigger("Attack");
            }
            if (Vector3.Distance(transform.position, otherCharacter.position) > attackDistance)
            {
                cAnimator.SetTrigger("Idle");
            }
        }
    }
}
