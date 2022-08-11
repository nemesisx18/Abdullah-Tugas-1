using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Char
{
    public class HumanController : BaseCharacter
    {
        public override void Move()
        {
            transform.Translate(Vector2.down * Time.deltaTime);
        }
    }
}
