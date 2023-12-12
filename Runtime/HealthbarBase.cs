using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace bentendo.healthbars
{
    public class HealthbarBase : MonoBehaviour
    {
        [SerializeField]
        private TMP_Text BarText;
        [SerializeField]
        private Transform Parent;
        [SerializeField]
        private float MaxHP;

        private float HP;

        private void Start()
        {
            HP = MaxHP;
            SetHP(HP);
        }

        public void SetMaxHP(float maxHp)
        {
            MaxHP = maxHp;
            SetHP(HP);
        }

        public void SetHP(float hp)
        {
            var scale = Parent.localScale;
            scale.x = HP / MaxHP;
            HP = hp;

            Parent.localScale = scale;
            BarText.text = Mathf.Round(hp).ToString();
        }
    }
}
