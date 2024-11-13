using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PunchShowcase : MonoBehaviour
{
   [SerializeField] Animator animator;

   private bool isPlaying;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isPlaying)
        {
           StartCoroutine("Punch");
        }
        else
        {
            animator.SetBool("Punch",false);
        }
    }

    IEnumerator Punch()
    {
        isPlaying = true;
        animator.SetBool("Punch",true);
        yield return new WaitUntil(() => animator.GetCurrentAnimatorStateInfo(1).IsName("Punch"));
        isPlaying = false;
        animator.SetBool("Punch",false);
        
    }
    
}
