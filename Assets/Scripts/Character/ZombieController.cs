using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Char
{
    public class ZombieController : BaseCharacter, IClickable
    {
        [SerializeField] private Transform endArea;

        GameManager game;

        private void Awake()
        {
            game = GameManager.instance;
        }

        public override void Move(float _xPos, float _yPos)
        {
            transform.Translate(new Vector2(_xPos, _yPos) * speed * Time.deltaTime);
        }

        private void Update()
        {
            Move(Mathf.PingPong(Time.time, 0.5f), -1);

            if (transform.position.y < endArea.position.y)
            {
                game.destroyQty++;
                game.health--;
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
                Destroy(gameObject);
                game.point++;
                game.destroyQty++;
            }
        }
    }

}
