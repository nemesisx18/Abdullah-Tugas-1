using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Char
{
    public abstract class BaseCharacter : MonoBehaviour
    {
        protected float speed = 2;

        public abstract void Move(float _xPos, float _yPos);
    }
}
