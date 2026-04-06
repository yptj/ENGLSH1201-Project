using UnityEngine;

public class CatPatrol : MonoBehaviour
{
    public Transform pointA;
    public Transform pointB;
    public float speed = 2f;

    private Transform target;

    void Start()
    {
        target = pointA;   // 先往左走
        FaceLeft();
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

        if (Vector2.Distance(transform.position, target.position) < 0.05f)
        {
            if (target == pointA)
            {
                target = pointB;
                FaceRight();
            }
            else
            {
                target = pointA;
                FaceLeft();
            }
        }
    }

    void FaceRight()
    {
        transform.localScale = new Vector3(-Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);
    }

    void FaceLeft()
    {
        transform.localScale = new Vector3(Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);
    }
}