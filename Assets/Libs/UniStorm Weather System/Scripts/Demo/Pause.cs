using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UniStorm.CharacterController
{
    public class Pause : MonoBehaviour
    {
        bool FreeLookwCursor = true;

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                FreeLookwCursor = !FreeLookwCursor;
            }

            if (FreeLookwCursor)
            {
                Cursor.lockState = CursorLockMode.Confined;
                Cursor.visible = true;
                GetComponent<UniStormMouseLook>().enabled = true;
            }
            else
            {
              //  Cursor.lockState = CursorLockMode.Locked;
               // Cursor.visible = false;
               // GetComponent<UniStormMouseLook>().enabled = true;
            }
        }
    }
}