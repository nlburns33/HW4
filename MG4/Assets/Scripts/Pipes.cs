using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipes : MonoBehaviour
{
    [SerializeField] float _speed;
    [SerializeField] float _lifetime;
    // Start is called before the first frame update
    void Start()
    {
        Locator.Instance.Player.Ender += Destroyer;
    }

    void Destroyer()
    {  
            Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        _lifetime -= Time.deltaTime;
        if (_lifetime < 0)
        {
            Locator.Instance.Player.Ender -= Destroyer;
            Destroy(gameObject);
        }
        transform.Translate(Vector2.left * _speed *  Time.deltaTime);
    }
}
