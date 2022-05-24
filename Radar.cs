using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radar : MonoBehaviour
{
    [SerializeField] List<Enemy> enemiesInRange;
    void Start()
    {
        enemiesInRange = new List<Enemy>();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(!other.gameObject.TryGetComponent<Enemy>(out Enemy enemy)) return;
        Debug.Log("Enemy in Range");
        enemiesInRange.Add(enemy);
        
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if(!other.gameObject.TryGetComponent<Enemy>(out Enemy enemy)) return;
        Debug.Log("Enemy left Range");
        enemiesInRange.Remove(enemy);
    }


}
