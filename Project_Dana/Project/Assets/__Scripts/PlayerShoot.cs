using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject BulletPrefab;
    public GameObject Player;
    public SpriteRenderer spriteRenderer;
    public Sprite Shooting;
    public Sprite Standing; 
    
    //update method
    void Update()
    {
        // Allow the ship to fire
        if ( Input.GetKeyDown( KeyCode.LeftShift ) ) { 
             StartCoroutine(waiter());
        }
    }

    void ChangeSpriteTo() {
        spriteRenderer.sprite = Shooting; 
    }

    void ChangeSpriteBack() {
        spriteRenderer.sprite = Standing; 
    }

    public void Fire() {
        GameObject bullet = Instantiate(BulletPrefab,Player.transform.position,Quaternion.identity);
    
    }//end of fire method

    IEnumerator waiter() {
        //change the image to gun
        ChangeSpriteTo();

        //fire gun
        Fire();

        //wait one sec then change back
        yield return new WaitForSeconds(1);       
        ChangeSpriteBack();
    }
}
