using UnityEngine;

public class ScaleEnlarger : MonoBehaviour
{
    private const float EqualScaleMultiplier = 1.0f;

    [SerializeField] private float _speed;

    private void Update()
    {
        Vector3 localScale = transform.localScale;
        localScale *= (EqualScaleMultiplier + _speed * Time.deltaTime);
        transform.localScale = localScale;
    }
}
