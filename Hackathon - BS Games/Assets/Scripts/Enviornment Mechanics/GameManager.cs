//Dmitri's Script for Lines 45-117
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{

    private float _timeRemaining;
    private Vector3 scaleChange;
    public GameObject plane;
    public Object Scene;
    public bool restarted = false;
    

    public float TimeRemaining
    {
        get { return _timeRemaining; }
        set { _timeRemaining = value; }
    }

    private int _numCubes;

    public int NumCubes
    {
        get { return _numCubes; }
        set { _numCubes = value; }
    }

    private float _playerHealth;

    public float PlayerHealth
    {
        get { return _playerHealth; }
        set { _playerHealth = value; }
    }

    public int maxHealth = 1;

    private bool isInvulnerable = false;

    public float maxTime = 1 * 120; // In seconds.


    void OnEnable()
    {
        DamagePlayerEvent.OnDamagePlayer += DecrementPlayerHealth;
        TimeRemaining = 120;
        PlayerHealth = maxHealth;
    }

    void OnDisable()
    {
        DamagePlayerEvent.OnDamagePlayer -= DecrementPlayerHealth;
    }
    // Use this for initialization
    void Start()
    {
        TimeRemaining = 120;
        PlayerHealth = maxHealth;
        scaleChange = new Vector3(0.1f, 0.1f, 0.1f);
    }

    // Update is called once per frame
        void Update()
        {
            if(restarted == false)
        {
            TimeRemaining = 120;
            PlayerHealth = maxHealth;
            restarted = true;
        }
            TimeRemaining -= Time.deltaTime;
            if (TimeRemaining <= 0 && plane != null)
            {
                plane.GetComponent<ScaleScript>().StartRising();
            }
        }
        
        private void DecrementPlayerHealth(GameObject player)
        {
            if (isInvulnerable)
            {
                return;
            }

            StartCoroutine(InvulnerableDelay());

            PlayerHealth--;

            if (PlayerHealth <= 0)
            {
                Cursor.visible = true;
                TimeRemaining = 120;
                PlayerHealth = maxHealth;
                SceneManager.LoadScene(Scene.name);
                restarted = false;

            }
        }

        private void Restart()
        {
            Application.LoadLevel(Application.loadedLevel);
            TimeRemaining = 120;
            PlayerHealth = maxHealth;
        }
        private IEnumerator InvulnerableDelay()
        {
            isInvulnerable = true;
            yield return new WaitForSeconds(1.0f);
            isInvulnerable = false;
        }

        public float GetPlayerHealthPercentage()
        {
            return PlayerHealth / (float)maxHealth;
        }
}
