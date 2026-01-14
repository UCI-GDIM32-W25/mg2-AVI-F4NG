using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    [SerializeField] private GameObject _coinPrefab;
    [SerializeField] private Transform _transform;
    private int _generate;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _generate = Random.Range(0,100);
        if (_generate < 1)
        {
            Instantiate(_coinPrefab, _transform.position, _transform.rotation);
        }
    }
}
