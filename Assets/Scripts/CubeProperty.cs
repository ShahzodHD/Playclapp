using UnityEngine;

public class CubeProperty : MonoBehaviour
{
    private void Update()
    {
        Movement();
        Faded();
    }
    private void Movement()
    {
        transform.position = Vector3.MoveTowards(transform.position, ReadInput.singleton.finalDistance, ReadInput.singleton.speed * Time.deltaTime);
    }
    private void Faded()
    {
        if (transform.position == ReadInput.singleton.finalDistance)
        {
            Destroy(gameObject);
        }
    }
}
