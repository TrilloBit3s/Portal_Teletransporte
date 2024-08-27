using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ALendaDoDragaoProject
{
    public class Teleportador : MonoBehaviour
    {
        [SerializeField] private Transform entradaPortalSpawnPoint;
        [SerializeField] private Transform saidaPortalSpawnPoint;

        private void OnTriggerEnter(Collider collisionInfo)
        {
            if (collisionInfo.CompareTag("EntrarPortal"))
            {
                if (collisionInfo.gameObject.name == "EntradaPortal")
                {
                    TeleportTo(entradaPortalSpawnPoint);
                }
            }
            else if (collisionInfo.CompareTag("SairPortal"))
            {
                if (collisionInfo.gameObject.name == "SaidaPortal")
                {
                    TeleportTo(saidaPortalSpawnPoint);
                }
            }
        }

        private void TeleportTo(Transform spawnPoint)
        {
            //if (spawnPoint != null)
            //{
                transform.position = spawnPoint.position;
            //}
        }
    }
}

/*
//script antigo
using UnityEngine;

namespace ALendaDoDragaoProject
{
    public class Portals : MonoBehaviour
    {       
        // Portals settings Obs:   
        //    Crie duas Tags, "EnterPortal" e "ExitPortal".
        //    Estas Tags ficarão nos colisores da parede onde será feito o teleporte.
        //        
        //    Nos colisores coloque os nomes de 
        //                                        "EntradaPortal_1" e tag "EnterPortal".
        //                                        "SaidaPortal_1"     e tag "ExitPortal".
        //    
        //    Colocar um script de "Scrolling Texture" na parede do portal.
        //    
        //    exemplo de objetos na Hierarchy:
        //                                    EntradaPortal_1		   Tag "EnterPortal"
        //                                    SaidaPortal_1            Tag "ExitPortal"
        //                                    Spawn_EntradaPortal_1  apenas gameObject vazio com gizmo referencia de posição de chegada.
        //                                    Spawn_SaidaPortal_1	   apenas gameObject vazio com gizmo referencia	de posição de ida.
        //    
        //    coloque os "Spawn" mais próximos ao chão caso nao queira que ele pule, pois o player saira do centro do Gizmos.                                	
    
        void OnTriggerStay(Collider collisionInfo3)
        {
            if(collisionInfo3.gameObject.CompareTag("EnterPortal"))
            {
                if(collisionInfo3.gameObject.name == "EntradaPortal_1")
                {
                    transform.position = GameObject.Find("Spawn_EntradaPortal_1").transform.position;
                }
            }
            
            if(collisionInfo3.gameObject.CompareTag("ExitPortal"))
            {	
                if(collisionInfo3.gameObject.name == "SaidaPortal_1")
                {
                    transform.position = GameObject.Find("Spawn_SaidaPortal_1").transform.position;
                }
            }
        }
    }
}
*/