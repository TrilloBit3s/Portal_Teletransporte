using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace TrilloBit3sIndieGames
{
    public class TPCena : MonoBehaviour
    {
        public bool invencivel = false;
        public string nomeDaCena;

        void Start()
        {
            StartCoroutine(tempo());    
        }

        void OnTriggerEnter(Collider hit)
        {
            if(hit.tag == "Player")
            {    
                SceneManager.LoadScene(nomeDaCena);
            }
        }

        IEnumerator tempo()
        {
            invencivel = true;
            yield return new WaitForSeconds(1.4f);
            invencivel = false;
        }
    }
}