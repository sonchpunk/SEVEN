using UnityEngine;
using UnityEngine.SceneManagement;

public class pause : MonoBehaviour
{
    [SerializeField] private GameObject Pause;

    private void Start()
    {
        Pause.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pause.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void PauseOff()
    {
        Pause.SetActive(false);
        Time.timeScale = 1;
    }
    
    public void Menu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }
}
