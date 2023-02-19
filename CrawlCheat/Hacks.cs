using UnityEngine;

namespace CrawlCheat
{
    internal class Hacks : MonoBehaviour
    {
        private PlayerMovement playerMovement = FindObjectOfType<PlayerMovement>();

        public void OnGUI()
        {
            foreach (Player p in FindObjectsOfType<Player>())
            {
                
                Vector3 pos = new Vector3();
                Vector3 w2s_pos = Camera.current.WorldToScreenPoint(pos);

                Render.DrawBox(w2s_pos.x, w2s_pos.y, 100f, 50f, Color.red, 2f);
                Render.DrawBox(w2s_pos.y, w2s_pos.z, 100f, 50f, Color.blue, 2f);
                Render.DrawBox(w2s_pos.x, w2s_pos.z, 100f, 50f, Color.green, 2f);

            }


        }

        public void Start()
        {
            foreach (PlayerMovement pm in FindObjectsOfType<PlayerMovement>())
                pm.SetSpeedMultiplier(1f);
        }

        public void Update()
        {
            if (Input.GetKeyDown(KeyCode.Delete))
            {
                Loader.Unload();
            }

            
        }
    }
}
