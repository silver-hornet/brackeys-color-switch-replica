using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] SpriteRenderer sr;
    [SerializeField] float jumpForce = 10f;
    [SerializeField] string currentColor;
    [SerializeField] Color colorCyan;
    [SerializeField] Color colorYellow;
    [SerializeField] Color colorMagenta;
    [SerializeField] Color colorPink;

    void Start()
    {
        SetRandomColor();
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump") || Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * jumpForce;
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        //if (collision.CompareTag)
    }

    void SetRandomColor()
    {
        int index = Random.Range(0, 3);

        switch (index)
        {
            case 0:
                currentColor = "Cyan";
                sr.color = colorCyan;
                break;
            case 1:
                currentColor = "Yellow";
                sr.color = colorYellow;
                break;
            case 2:
                currentColor = "Magenta";
                sr.color = colorMagenta;
                break;
            case 3:
                currentColor = "Pink";
                sr.color = colorPink;
                break;
        }
    }
}