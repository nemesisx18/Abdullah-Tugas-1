using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Char
{
    public class ZombieController : BaseCharacter
    {
        public override void Move()
        {
            transform.Translate(Vector2.down * Time.deltaTime);
        }

        private void Update()
        {
            Move();
        }
    }

}
