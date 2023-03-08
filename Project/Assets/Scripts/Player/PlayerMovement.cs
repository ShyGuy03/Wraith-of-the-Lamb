using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed = 5f;

    public Rigidbody2D rb;

    private SpriteRenderer spriteRend;

    public Animator animator;

    Vector2 movement;
    // Start is called before the first frame update
    void Start(){
        spriteRend = GetComponent<SpriteRenderer>();
    }
    // Update is called once per frame
    void Update(){
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);

    }
    
    private void sortingLayerUpate(){
        spriteRend.sortingOrder = (int)(transform.position.y * -100);
    }
    

    void FixedUpdate(){
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
        sortingLayerUpate();
    }

    public void door(int flag){
        if(flag == 1){
            Physics2D.IgnoreLayerCollision(10,12,true);
        }
        else{
            Physics2D.IgnoreLayerCollision(10,12,false);
        }
    }
}
