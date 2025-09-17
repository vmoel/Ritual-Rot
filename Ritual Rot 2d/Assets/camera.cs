using UnityEngine;

public class camera : MonoBehaviour
{
    private Vector3 offset = new Vector3(0f, 0f, -10f);
    private float tiden = 0.25f;
    private Vector3 hastighed = Vector3.zero;
    [SerializeField] private Transform target;
    // Update is called once per frame
    void Update()
    {
        Vector3 targetPosition = target.position + offset;
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref hastighed, tiden);
        
    }
}
