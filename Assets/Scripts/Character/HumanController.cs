using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Char
{
    
    public class HumanController : BaseCharacter, IRaycastable
    {
        public override void Move()
        {
            transform.Translate(Vector2.down * Time.deltaTime);
        }

        public void Tap()
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                Transform objectHit = hit.transform;
                Debug.Log("tap" + objectHit);
            }
        }

        private void Update()
        {
            Move();
        }
    }
}
