using UnityEngine;
using UnityEngine.SceneManagement;

public class ArrowForward : MonoBehaviour
{
    public int NumScene;

    public void ToLocation()
    {
        SceneManager.LoadScene(NumScene);
    }
}