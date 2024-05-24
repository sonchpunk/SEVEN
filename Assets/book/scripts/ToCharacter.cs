using UnityEngine;
using UnityEngine.SceneManagement;

public class ToCharacter : MonoBehaviour
{
    public int NumScene;
    
        public void ToLocation()
        {
            SceneManager.LoadScene(NumScene);
        }
}
