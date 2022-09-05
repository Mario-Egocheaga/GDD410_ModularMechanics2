using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;
    [SerializeField] float timer = .5f;

    private void FixedUpdate()
    {
        timer -= Time.deltaTime;
        if (timer <= 0 && !Pause.paused)
        {
            var position = new Vector3(transform.position.x, Random.Range(-3f, 3f), 0);
            Instantiate(prefab, position, Quaternion.identity);
            timer = .5f;
        }
    }
}
