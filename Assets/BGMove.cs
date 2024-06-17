using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMove : MonoBehaviour
{
    public Transform player; // Kéo và th? player object vào ?ây trong Inspector
    public float parallaxSpeedX = 1; // T?c ?? di chuy?n c?a background theo tr?c X
    public float parallaxSpeedY = 0; // T?c ?? di chuy?n c?a background theo tr?c Y

    private Vector3 lastPlayerPosition; // V? trí cu?i cùng c?a ng??i ch?i

    void Start()
    {
        lastPlayerPosition = player.position;
    }

    void Update()
    {
        // Tính toán s? chênh l?ch gi?a v? trí hi?n t?i c?a ng??i ch?i và v? trí cu?i cùng c?a ng??i ch?i
        float deltaX = player.position.x - lastPlayerPosition.x;
        float deltaY = player.position.y - lastPlayerPosition.y;

        // N?u ng??i ch?i di chuy?n theo tr?c X, di chuy?n background theo tr?c X
        if (deltaX != 0)
        {
            transform.position += new Vector3(deltaX * parallaxSpeedX, 0, 0);
        }

        // N?u ng??i ch?i di chuy?n theo tr?c Y, di chuy?n background theo tr?c Y
        if (deltaY != 0)
        {
            transform.position += new Vector3(0, deltaY * parallaxSpeedY, 0);
        }

        // C?p nh?t v? trí cu?i cùng c?a ng??i ch?i
        lastPlayerPosition = player.position;
    }
}