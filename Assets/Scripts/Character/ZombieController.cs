using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Char
{
    public class ZombieController : BaseCharacter
    {
        [SerializeField] private Transform endArea;

        public override void Move(float _speed)
        {
            transform.Translate(Vector2.down * _speed * Time.deltaTime);
        }

        private void Update()
        {
            if (canMove)
            {
                Move(speed);
            }

            if (transform.position.y < endArea.position.y)
            {
                canMove = false;
            }

            if (Input.GetMouseButtonDown(0))
            {
                base.Tap(transform);
            }
        }
    }

}
