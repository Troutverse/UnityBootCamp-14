using UnityEngine;

public class BackGround : MonoBehaviour
{
    public Material material;

    public float ScrollSpeed = 0.2f;

    private void Update()
    {
        Vector2 dir = Vector2.up;
        material.mainTextureOffset += dir * ScrollSpeed * Time.deltaTime;
    }
}
