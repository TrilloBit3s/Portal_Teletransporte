using System.Collections;
using UnityEngine;

namespace TrilloBit3sIndieGames
{
    public class TP_Spawn : MonoBehaviour
    {
        public Transform pontoDeRespawn; // Referência ao ponto de respawn
        public float tempoDeEspera = 0.1f; // Tempo de espera antes de respawn

        //o colisor OnTriggerEnter causa algum conflito no objeto
        void OnTriggerStay(Collider hit)//OnTriggerEnter ou OnTriggerStay
        {
            if(hit.CompareTag("Player"))
            {    
                StartCoroutine(RespawnComDelay(hit.transform)); // Inicia coroutine com atraso
            }
        }

        IEnumerator RespawnComDelay(Transform jogador)
        {
            yield return new WaitForSeconds(tempoDeEspera); // Aguarda o tempo definido
            Respawn(jogador); // Reposiciona o jogador no ponto de respawn
        }

        void Respawn(Transform jogador)
        {
            jogador.position = pontoDeRespawn.position; // Reposiciona o jogador no ponto de respawn
            jogador.rotation = pontoDeRespawn.rotation; // Opcional: Reposiciona a rotação do jogador
        }
    }
}