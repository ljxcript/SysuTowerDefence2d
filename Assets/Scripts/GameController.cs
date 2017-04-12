using UnityEngine;
using System.Collections;

namespace com.SYSUTowerDefence {

    public class GameController : MonoBehaviour
    {
        private MapManager mapManager;

        void Awake()
        {
            mapManager = MapManager.getInstance();
        }

        // Use this for initialization
        void Start()
        {
    	    
        }
    	
        // Update is called once per frame
        void Update()
        {
    	
        }
    }

}