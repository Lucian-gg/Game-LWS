using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    public float _speed;
    SpriteRenderer _sprite;

    void Start()
    {
        _sprite = GetComponent<SpriteRenderer>();
    }


    void FixedUpdate()
    {
        if (Input.GetAxis("Vertical") != 0)
        {
            transform.position = transform.position + new Vector3(0, Input.GetAxis("Vertical") * _speed * Time.deltaTime, 0);
        }

        if (Input.GetAxis("Horizontal") != 0)
        {

          transform.position = transform.position + new Vector3(Input.GetAxis("Horizontal") * _speed * Time.deltaTime, 0, 0);
        
          if (Input.GetAxis("Horizontal") >= 0)
          {
              if (_sprite.flipX == true) _sprite.flipX = false;//Putting this checking buttons is way better imo.
          }
        
          if (Input.GetAxis("Horizontal") <= 0)
          {
              if (_sprite.flipX == false) _sprite.flipX = true;
          }

        }
    }
}
