using UnityEngine;
using System.Collections;

namespace com.SYSUTowerDefence {

    [System.Serializable]
    public class GameStatusModel : System.Object
    {

        int HP;
        int Exp;

        int wave;
        int time;

        float speed;

        bool paused;

        private static GameStatusModel _instance;

        private GameStatusModel() {
            
        }

        public static GameStatusModel getInstance(){
            if (_instance == null) {
                _instance = new GameStatusModel();

            }
            return _instance;
        }


    }

}

