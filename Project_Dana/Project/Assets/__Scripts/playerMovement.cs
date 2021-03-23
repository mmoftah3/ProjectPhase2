using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    //declaring variables
    public float moveSpeed = 5f; 
    public SpriteRenderer spriteRenderer;
    public Sprite Walking;
    public Sprite Standing;
    Sprite Current;
    public bool isGrounded = false;
    public  GameObject shield;

    //start method
    void Start(){
     
        StartCoroutine(WaiterWalk());
        shield.SetActive(false);

    }//end of the start method
    
    //update method
    void Update()
    {
        Jump(); 
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movement * Time.deltaTime * moveSpeed; 
        
    }//end of update method

    //jump method
    void Jump()
    {
        //making player jump if space is pressed
        if (Input.GetButtonDown("Jump") && isGrounded == true){
            //change image to jumping one when we have the image
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 5f), ForceMode2D.Impulse); 
            

        }//end of if statement
    }//end of jump method

    IEnumerator WaiterWalk() {
       Current = spriteRenderer.sprite;  
        while(Current.name != "GuyWithGun" ){
            yield return new WaitForSeconds(0.5f);   
            //changing image to walking
            ChangeSpriteWalk();
            //wait one sec then change back
            yield return new WaitForSeconds(0.5f);       
            ChangeSpriteStand();
            Current = spriteRenderer.sprite;
        }
    }//end of waiter method

    //methods to change sprites images
    void ChangeSpriteWalk() {
        spriteRenderer.sprite = Walking; 
    }

    void ChangeSpriteStand() {
        spriteRenderer.sprite = Standing; 
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag =="Ground")
        {

        }
        //To collect gems
        if(collision.gameObject.tag == "Gems")
        {
            Destroy(collision.gameObject);
            //Add score
        }
        if(collision.gameObject.tag == "Box")
        {
            shield.SetActive(true);
        }
        
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground")
        {

        }

    }
}//end of class
