﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Direction currentDir;
    Vector2 input; 
    bool isMoving = false;
    Vector3 startPos;
    Vector3 endPos;
    float t;

    public Sprite northSprite;
    public Sprite eastSprite;
    public Sprite southSprite;
    public Sprite westSprite;
    public float walkSpeed = 3f;

    // Update is called once per frame
    void Update() {
        if(!isMoving) {
            input = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
            if(Mathf.Abs(input.x) > Mathf.Abs(input.y)) input.y = 0;
            else input.x = 0;

            if(input != Vector2.zero) {
                if(input.x < 0) {
                    currentDir = Direction.West;
                } if (input.x > 0) {
                    currentDir = Direction.East;
                } if (input.y < 0) {
                    currentDir = Direction.South;
                } if (input.y > 0) {
                    currentDir = Direction.North;
                }

                StartCoroutine(Move(transform));
            }
        }
        
    }

    public IEnumerator Move(Transform entity) {
        isMoving = true;
        startPos = entity.position;
        t = 0;

        endPos = new Vector3(startPos.x + System.Math.Sign(input.x), startPos.y + System.Math.Sign(input.y), startPos.z);

        while(t < 1f) {
            t += Time.deltaTime * walkSpeed;
            entity.position = Vector3.Lerp(startPos, endPos, t);

            yield return null;
        }

        isMoving = false;
        yield return 0;
    }
}

enum Direction
{
    North,
    East,
    South,
    West,
}
