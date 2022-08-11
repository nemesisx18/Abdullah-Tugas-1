using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Char
{
    public abstract class BaseCharacter : MonoBehaviour, IRaycastable
    {
        protected float speed = 2;

        public abstract void Move(float _speed);

        public virtual void Tap(Transform _transform)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction);

            if (hit.transform == _transform)
            {
                Debug.Log(_transform.name);
            }
        }
    }
}
