using UnityEngine;

public class SpawnerCubes : MonoBehaviour
{
    [SerializeField] private GameObject cube;
    [SerializeField] private Transform spawnerPoint;

    private float _timeNextSpawn;
    private void Start()
    {
        _timeNextSpawn = Time.time + ReadInput.singleton.timeSpawn;
    }
    private void Update()
    {
        Spawn();
    }

    private void Spawn()
    {
        if (Time.time > _timeNextSpawn)
        {
            Instantiate(cube, spawnerPoint);
            _timeNextSpawn += ReadInput.singleton.timeSpawn;
        }
    }
}
