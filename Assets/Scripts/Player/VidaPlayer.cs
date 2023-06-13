using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaPlayer : MonoBehaviour
{
    public int vida;
    public int vidaMax = 5;
    public SpriteRenderer playerSr;
    public PlayerController playerController;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        vida = vidaMax;
        Animator animator = GetComponent<Animator>();
    }

    public void LevaDano (int amount){
         vida -= amount;
        if(vida <= 0)
       {
        vida = 0;
        animator.SetTrigger("death");
       // playerSr.enabled = false;
      //  playerController.enabled = false;
         //Die();
       }     
    }
    /* private void Die()
    {
    animator.SetTrigger("death");
    }*/

   
}