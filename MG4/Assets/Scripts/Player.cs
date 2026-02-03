
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public delegate void IntDelegator(int score);
    public event IntDelegator PointsChanged;
    public delegate void Delegator();
    public event Delegator Ender;
    public event Delegator Jump;

    [SerializeField] public int _jumpHeight;
    [SerializeField] public GameObject _prefab;
    [SerializeField] private float _timer;
    public int _score;
    private bool _end;
    
    // Start is called before the first frame update
    void Start()
    {
        

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Pipe")
        {
            
            _end = true;
            Ender?.Invoke();
        }
        else
        {
            Debug.Log("+1");
            _score += 1;
            PointsChanged?.Invoke(_score);
        }
    }

    // Update is called once per frame
    void Update()
    {
        _timer -= Time.deltaTime;

        if (_timer <= 0 && !_end)
        {
            
            Vector2 spawnLocation = new Vector2(12, Random.Range(-1.3f, 2f));
            Instantiate(_prefab, spawnLocation, Quaternion.identity);
            _timer = 5;
        }
        if (Input.GetKeyDown(KeyCode.Space) && !_end)
        {
        
            gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.up * _jumpHeight;
            Jump?.Invoke();
        }

    }
}
