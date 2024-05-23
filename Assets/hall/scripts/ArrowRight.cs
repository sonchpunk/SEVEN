using UnityEngine.SceneManagement;
using UnityEngine;

public class ArrowRight : MonoBehaviour
{
    public int NumScene;

    public void ToLocation()
    {
        SceneManager.LoadScene(NumScene);
    }
}
