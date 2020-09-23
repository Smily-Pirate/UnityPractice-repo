
using UnityEngine;

public class SnakeController : MonoBehaviour
{
    public float speed = 3f;
    public float rotationSpeed = 200f;

    float horizonatal = 0f;

    // Update is called once per frame
    void Update()
    {
        horizonatal = Input.GetAxisRaw("Horizontal");
    }

    void FixedUpdate()
    {
        transform.Translate(Vector2.up * speed * Time.fixedDeltaTime, Space.Self);
        transform.Rotate(Vector3.forward * -horizonatal * rotationSpeed * Time.fixedDeltaTime);
    }

    void OnTriggerEnter2D(Collider2D col)
    {

    }
}
