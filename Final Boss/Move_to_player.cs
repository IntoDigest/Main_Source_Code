using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_to_player : MonoBehaviour
{
    public GameObject player;

    public float speed;

    private Vector3 playerpos;
    private Vector3 objpos;
    void Update(){
        
        float real_speed = speed * Time.deltaTime;

        playerpos = player.transform.position;
        objpos = transform.position;

        transform.position = Vector3.MoveTowards(objpos, playerpos, real_speed);

    }
}
