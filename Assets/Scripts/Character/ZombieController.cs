using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Char
{
    public abstract class BaseCharacter : MonoBehaviour
    {
        public abstract void Move();
    }

    public class ZombieController : BaseCharacter
    {
        public override void Move()
        {
            transform.Translate(Vector2.down * Time.deltaTime);
        }
    }

}
