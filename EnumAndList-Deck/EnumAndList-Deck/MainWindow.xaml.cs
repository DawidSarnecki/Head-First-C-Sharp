using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EnumAndList_Deck
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Card card = new Card(Suit.Spades, Value.Ace);
            MessageBox.Show(card.Name);
            
            //this it the same :
            card = new Card((Suit)0, (Value)1);
            MessageBox.Show(card.Name);


            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                card = new Card((Suit)random.Next(4), (Value)random.Next(1, 14)); 
                MessageBox.Show(card.Name);
            }

            // overloaded method random.next()
            //int numberBetween0and3 = random.Next(4);
            //int numberBetween1and13 = random.Next(1, 14);
            //int numberAnyNumber = random.Next();

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            string myCards = "";
            List<Card> myRandomCards = new List<Card>(){
               new Card((Suit)random.Next(4), (Value)random.Next(1, 14)),
               new Card((Suit)random.Next(4), (Value)random.Next(1, 14)),
               new Card((Suit)random.Next(4), (Value)random.Next(1, 14)),
               new Card((Suit)random.Next(4), (Value)random.Next(1, 14)),
               new Card((Suit)random.Next(4), (Value)random.Next(1, 14))
            };

            // this is the same:
            for (int i = 0; i < 5; i++)
            {
                myRandomCards.Add(new Card((Suit)random.Next(4), (Value)random.Next(1, 14)));
            }

            foreach (Card card in myRandomCards)
            {
                myCards += "\n " + card.Name;
            }
            MessageBox.Show(myCards);
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            string deck = "";
            Card card;
            List<Card> myRandomCards = new List<Card>();
            Random random = new Random();

            // some eror? while checking if the card is exitsts yet
            while (myRandomCards.Count <= 52)
            {
                card = new Card((Suit)random.Next(4), (Value)random.Next(1, 14));
                if (card != myRandomCards
                    .Where(c => c.Name == card.Name && c.Suit == card.Suit)
                    .FirstOrDefault())
                {
                    myRandomCards.Add(card);
                }
            }

            foreach (Card c in myRandomCards)
            {
                deck += "\n " + c.Name;
            }
            MessageBox.Show(deck);
            MessageBox.Show(myRandomCards.Count.ToString());
        }
    }
}
