using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour{

    public Rigidbody2D myRigidbody;
    public float flapStrngth;
    public Logic logic;
    public bool birdIsAlive;

    // Start is called before the first frame update
    void Start(){
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logic>();
        birdIsAlive = true;
    }

    // Update is called once per frame
    void Update(){
        Debug.Log(birdIsAlive);
        if (Input.GetKeyDown(KeyCode.Space)){
            myRigidbody.velocity = Vector2.up * flapStrngth;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision){
        logic.gameOver();
        birdIsAlive = false;
    }
}

