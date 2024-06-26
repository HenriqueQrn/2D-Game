using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour
{
    private PlayerControls playerControls;
    private Animator myAnimator;

    private void Awake(){
        myAnimator = GetComponent<Animator>();
        playerControls = new PlayerControls();
    }

    private void OnEnable() {
        playerControls.Enable();
    }
    
    void Start() {
        playerControls.Combat.Attack.started += _ => Attack();        
    }

    private void Attack() {
        myAnimator.SetTrigger("Attack");
    }

}
