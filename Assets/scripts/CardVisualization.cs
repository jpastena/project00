using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace PJ {
    public class CardVisualization : MonoBehaviour {

        public Card card;

        public Text title;
        public Image art;
        public Text type;
        public Text text;

        public void loadCard(Card card) {
            if (card == null) return;
            this.card = card;
            title.text = card.cardName;
            art.sprite = card.cardSprite;
            type.text = card.cartType.typeName;
            text.text = card.cardText;
        }

        // Use this for initialization
        void Start() {
            loadCard(card);
        }

        // Update is called once per frame
        void Update() {

        }
    }
}
