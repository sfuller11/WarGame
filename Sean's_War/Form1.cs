using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sean_s_War
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Queue Player1 = new Queue();
        Queue Player2 = new Queue();

        Deck deck = new Deck();

        private void btnDraw_Click(object sender, EventArgs e)
        {

            for(int i = 0; i < 52; i++)
            {
                Card drawl = deck.DrawCard();
                if (drawl != null)
                { 
                    if(i < 26)
                    {
                        Player1.Enqueue(drawl);
                    }
                    else
                    {
                        Player2.Enqueue(drawl);
                    }

                }
            }

            lblP1Cards.Text = Player1.Count.ToString();
            lblP2Cards.Text = Player2.Count.ToString();

            //if (drawl != null)
            //{
            //    lblTest.Text = drawl.ToString();
            //    Player1.Enqueue(drawl);
            //    Card play = (Card)Player1.Dequeue();
            //    lblTest.Text = play.ToString();
            //}

        }

        private void btnShuffle_Click(object sender, EventArgs e)
        {
            deck.shuffle();
        }

        public void ClearBoard()
        {
            lblWarAlert.Text = "";
            lblP1WarCard.Text = "";
            lblP2WarCard.Text = "";
            lblP1WarCard2.Text = "";
            lblP2WarCard2.Text = "";
        }

        private void btnPLay_Click(object sender, EventArgs e)
        {
            ClearBoard();

            if (Player1.Count == 0)
            {
                lblTest.Text = "Player2 has won the war!";
                return;
            }

            if (Player2.Count == 0)
            {
                lblTest.Text = "Player1 has won the war!";
                return;
            }

            Card p1 = (Card)Player1.Dequeue();
            Card p2 = (Card)Player2.Dequeue();

            lblP1Drawl.Text = p1.ToString();
            lblP2Drawl.Text = p2.ToString();

            if(p1.getValue() > p2.getValue())
            {
                lblTest.Text = "Player1 Wins";
                Player1.Enqueue(p1);
                Player1.Enqueue(p2);
            }
            else if(p2.getValue() > p1.getValue())
            {
                lblTest.Text = "Player2 Wins";
                Player2.Enqueue(p1);
                Player2.Enqueue(p2);
            }
            else if(p1.getValue() == p2.getValue() && Player1.Count >= 4 && Player2.Count >= 4)
            {
                lblWarAlert.Text = "War!";
                Card p1w1 = (Card)Player1.Dequeue();
                Card p1w2 = (Card)Player1.Dequeue();
                Card p1w3 = (Card)Player1.Dequeue();
                Card p1w4 = (Card)Player1.Dequeue();

                lblP1WarCard.Text = p1w4.ToString();

                Card p2w1 = (Card)Player2.Dequeue();
                Card p2w2 = (Card)Player2.Dequeue();
                Card p2w3 = (Card)Player2.Dequeue();
                Card p2w4 = (Card)Player2.Dequeue();

                lblP2WarCard.Text = p2w4.ToString();

                if (p1w4.getValue() > p2w4.getValue())
                {
                    lblTest.Text = "Player1 Wins";
                    Player1.Enqueue(p1);
                    Player1.Enqueue(p2);

                    Player1.Enqueue(p1w1);
                    Player1.Enqueue(p1w2);
                    Player1.Enqueue(p1w3);
                    Player1.Enqueue(p1w4);

                    Player1.Enqueue(p2w1);
                    Player1.Enqueue(p2w2);
                    Player1.Enqueue(p2w3);
                    Player1.Enqueue(p2w4);


                }
                else if (p2w4.getValue() > p1w4.getValue())
                {
                    lblTest.Text = "Player2 Wins";
                    Player2.Enqueue(p1);
                    Player2.Enqueue(p2);

                    Player2.Enqueue(p1w1);
                    Player2.Enqueue(p1w2);
                    Player2.Enqueue(p1w3);
                    Player2.Enqueue(p1w4);

                    Player2.Enqueue(p2w1);
                    Player2.Enqueue(p2w2);
                    Player2.Enqueue(p2w3);
                    Player2.Enqueue(p2w4);
                }
                else if(p1w4.getValue() == p2w4.getValue() && Player1.Count >= 4 && Player2.Count >= 4)
                {
                    lblWarAlert.Text = "Double War!";
                    Card p1w5 = (Card)Player1.Dequeue();
                    Card p1w6 = (Card)Player1.Dequeue();
                    Card p1w7 = (Card)Player1.Dequeue();
                    Card p1w8 = (Card)Player1.Dequeue();

                    lblP1WarCard2.Text = p1w8.ToString();

                    Card p2w5 = (Card)Player2.Dequeue();
                    Card p2w6 = (Card)Player2.Dequeue();
                    Card p2w7 = (Card)Player2.Dequeue();
                    Card p2w8 = (Card)Player2.Dequeue();

                    lblP2WarCard2.Text = p2w8.ToString();

                    if (p1w8.getValue() > p2w8.getValue())
                    {
                        lblTest.Text = "Player1 Wins";
                        Player1.Enqueue(p1);
                        Player1.Enqueue(p2);

                        Player1.Enqueue(p1w1);
                        Player1.Enqueue(p1w2);
                        Player1.Enqueue(p1w3);
                        Player1.Enqueue(p1w4);
                        Player1.Enqueue(p1w5);
                        Player1.Enqueue(p1w6);
                        Player1.Enqueue(p1w7);
                        Player1.Enqueue(p1w8);

                        Player1.Enqueue(p2w1);
                        Player1.Enqueue(p2w2);
                        Player1.Enqueue(p1w3);
                        Player1.Enqueue(p1w4);
                        Player1.Enqueue(p2w5);
                        Player1.Enqueue(p2w6);
                        Player1.Enqueue(p2w7);
                        Player1.Enqueue(p2w8);

                    }
                    if (p2w8.getValue() > p1w8.getValue())
                    {
                        lblTest.Text = "Player2 Wins";
                        Player2.Enqueue(p1);
                        Player2.Enqueue(p2);

                        Player2.Enqueue(p1w1);
                        Player2.Enqueue(p1w2);
                        Player2.Enqueue(p1w3);
                        Player2.Enqueue(p1w4);
                        Player2.Enqueue(p1w5);
                        Player2.Enqueue(p1w6);
                        Player2.Enqueue(p1w7);
                        Player2.Enqueue(p1w8);

                        Player2.Enqueue(p2w1);
                        Player2.Enqueue(p2w2);
                        Player2.Enqueue(p1w3);
                        Player2.Enqueue(p1w4);
                        Player2.Enqueue(p2w5);
                        Player2.Enqueue(p2w6);
                        Player2.Enqueue(p2w7);
                        Player2.Enqueue(p2w8);
                    }   
                }

                else if(p1w4.getValue() == p2w4.getValue() && Player1.Count < 4)
                {
                    lblTest.Text = "Player1 forfeits, player2 has won the war!";
                    while(Player1.Count > 0)
                    {
                        Player2.Enqueue(Player1.Dequeue());
                    }
                }
                else if (p1w4.getValue() == p2w4.getValue() && Player2.Count < 4)
                {
                    lblTest.Text = "Player2 forfeits, player1 has won the war!";
                    while (Player2.Count > 0)
                    {
                        Player1.Enqueue(Player2.Dequeue());
                    }
                }

            }
            else if (p1.getValue() == p2.getValue() && Player1.Count < 4)
            {
                lblTest.Text = "Player1 forfeits, player2 has won the war!";
                while (Player1.Count > 0)
                {
                    Player2.Enqueue(Player1.Dequeue());
                }
            }
            else if (p1.getValue() == p2.getValue() && Player2.Count < 4)
            {
                lblTest.Text = "Player2 forfeits, player1 has won the war!";
                while (Player2.Count > 0)
                {
                    Player1.Enqueue(Player2.Dequeue());
                }
            }

            lblP1Cards.Text = Player1.Count.ToString();
            lblP2Cards.Text = Player2.Count.ToString();
        }
    }
}
