using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace com.SYSUTowerDefence {

    public class MapManager : System.Object {

        private static MapManager _instance;

        private MapManager() {
            
        }

        public static MapManager getInstance(){
            if (_instance == null) {
                _instance = new MapManager();
            }
            return _instance;
        }
            
        private List<List<Vector3>> wayPointListForStages;

        public List<Vector3> getWaypointListWithStage(int stage){
            return wayPointListForStages[stage];
        }
      

    }

}