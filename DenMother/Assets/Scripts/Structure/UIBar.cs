using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;

namespace Structure
{
    public class UIBar : MonoBehaviour
    {
        [SerializeField] private Color maxColor;
        [SerializeField] private Color minColor;
        [SerializeField] private Image uiFill;
        public int YOffset;

        public GameManager Manager;

        // Use this for initialization
        void Start()
        {
        }

        // Update is called once per frame
        void Update()
        {
            // if (Input.GetButton("Interact"))
            {
                uiFill.color = BlendColors(minColor, maxColor, Manager.FoodLevel);
                uiFill.fillAmount = Manager.FoodLevel;
//                transform.Translate((Manager.Mother.transform.position - transform.position) + Vector3.up * YOffset);
            }
        }

        public static Color BlendColors(Color startColor, Color endColor, float ratio)
        {
            return new Color(Mathf.Lerp(startColor.r, endColor.r, ratio),
                             Mathf.Lerp(startColor.g, endColor.g, ratio),
                             Mathf.Lerp(startColor.b, endColor.b, ratio),
                             Mathf.Lerp(startColor.a, endColor.a, ratio)
            );
        }
    }
}