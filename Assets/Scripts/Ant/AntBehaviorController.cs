
    using System.Xml.Linq;
    using UnityEngine;

    public class AntBehaviorController : MonoBehaviour
    {

        private Vector2 position;
        public float speed = 1f;
        private float x;
        private float y;
        private SpriteRenderer renderer;
        private float timer;


        private void Awake()
        {
            renderer = GetComponent<SpriteRenderer>();
        }

        private void Start()
        {
            speed = Random.Range(0, 50);
            position = gameObject.transform.position;
            x = Random.Range(-1000, 1000);
            y = Random.Range(-1000, 1000);
        }

        private void Update()
        {
            float step = (speed * Time.deltaTime)/100;
            Vector2 newPosition = new Vector2(position.x + x, position.y + y);
            
            transform.position = Vector2.MoveTowards(transform.position, newPosition, step);

            timer += Time.deltaTime;
            if (timer >= 1)
            {
                timer = 0;
                renderer.flipX = !renderer.flipX;
            }
        }

    }
