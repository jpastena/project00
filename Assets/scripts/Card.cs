using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PJ {
    [CreateAssetMenu(menuName = "Card")]
    public class Card : ScriptableObject {
        public string cardName;
        public Sprite cardSprite;
        public CardType cartType;
        public string cardText;
    }
}
