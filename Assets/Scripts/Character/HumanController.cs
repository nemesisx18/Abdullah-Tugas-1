using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Char
{
    public class HumanController : BaseCharacter, IClickable
    {
        [SerializeField] private Transform endArea;

        GameManager game;

        public override void Move(float _xPos, float _yPos)
        {
            transform.Translate(new Vector2(_xPos, _yPos) * speed * Time.deltaTime);
        }

        private void Start()
        {
            game = GameManager.instance;
        }

        private void Update()
        {
            Move(0, -1);

            if (transform.position.y < endArea.position.y)
            {
                game.destroyQty++;
                Destroy(gameObject);
            }

            if (Input.GetMouseButtonDown(0))
            {
                Tap(transform);
            }
        }

        public void Tap(Transform _transform)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction);

            if (hit.transform == _transform)
            {
                Debug.Log("hapus" + _transform);
                game.isLose = true;
                game.destroyQty++;
            }
        }
    }
}
