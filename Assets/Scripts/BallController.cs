using UnityEngine;

public class BallController : MonoBehaviour
{
    private Rigidbody rb;

    public float moveSpeed;
    public float drag = 1f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.drag = drag;
    }

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Moved)
            {
                // Вычисляем смещение
                Vector2 touchDeltaPosition = touch.deltaPosition;

                // Преобразуем смещение в силу по плоскости XZ
                Vector3 force = new Vector3(touchDeltaPosition.x, 0, touchDeltaPosition.y) * moveSpeed;

                rb.AddForce(force);
            }
        }
    }
}
