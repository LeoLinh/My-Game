using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class BackgroundRender : MonoBehaviour
    {

        private Vector3 startPos;
        [SerializeField] public float speed;
        private float singleTextureWidth;
        //public bool isMoving;
        private void Awake()
        {
            startPos = transform.position;
            Sprite sprite = gameObject.GetComponent<SpriteRenderer>().sprite;
            singleTextureWidth = sprite.texture.width / sprite.pixelsPerUnit;
        }

        private void Move()
        {
            transform.position += new Vector3(0,speed * Time.fixedDeltaTime, 0);
        }
        private void FixedUpdate()
        {      
                Move();
                CheckReset();      
        }
        private void CheckReset()
        {
            if(Mathf.Abs(transform.position.y) - singleTextureWidth > 0)
            {
                transform.position = startPos;
            }
        }     
    }
