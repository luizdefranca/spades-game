using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpadesLib;

namespace SpadesGame
{
    public partial class TableForm : Form
    {
        public String playerName;
        private Player humanPlayer;
        private Player northPlayer;
        private Player eastPlayer;
        private Player westPlayer;
        private Deck deck;
        private List<PictureBox> listImgCard = new List<PictureBox>();
        
        public TableForm()
        {
            InitializeComponent();
            beginGame();


          //  EnterPlayerName();
        }

        //public TableForm(String playerName)
        //{
        //    InitializeComponent();
        //    //playerName = this.playerName;
        //    //System.Console.WriteLine(humanPlayer.Name());
        //    //System.Console.ReadKey();
        //}

        private void TableForm_Load(object sender, EventArgs e)
        {
        }

        public void InitializePlayers()
        {
            humanPlayer = new Player(playerName);
            northPlayer = new Player();
            eastPlayer = new Player();
            westPlayer = new Player();
            
        }

        public void InitializeDeck()
        {
            deck = new Deck();
        }

        public void DistributeCards()
        {
            deck.Shuffle();
            int position = 0;
            
            while (position < 52)
            {
                humanPlayer.Hand().Add(deck.GetCard(position++));
                northPlayer.Hand().Add(deck.GetCard(position++));
                eastPlayer.Hand().Add(deck.GetCard(position++));
                westPlayer.Hand().Add(deck.GetCard(position++));
            }

        }
        
        private void EnterPlayerName()
        {
            UserNameForm userNameForm = new UserNameForm(this);
           
                userNameForm.Show();

            

        }

        private void beginGame()
        {
            imgEastPlayer.Enabled = false;
           
            imgNorthPlayer.Enabled = false;
            imgWestPlayer.Enabled = false;
            imgSouthPlayer1.Enabled = false;
            imgSouthPlayer2.Enabled = false;
            imgSouthPlayer3.Enabled = false;
            imgSouthPlayer4.Enabled = false;
            imgSouthPlayer5.Enabled = false;
            imgSouthPlayer6.Enabled = false;
            imgSouthPlayer7.Enabled = false;
            imgSouthPlayer8.Enabled = false;
            imgSouthPlayer9.Enabled = false;
            imgSouthPlayer10.Enabled = false;
            imgSouthPlayer11.Enabled = false;
            imgSouthPlayer12.Enabled = false;
            imgSouthPlayer13.Enabled = false;
            lblBid.Visible = false;
            upDownBid.Visible = false;
            btnGo.Visible = false;
            
        }

        private void ShowCards()
        {
            for (int position = 0; position < 13; position++)
            {
                Card card = humanPlayer.Hand().GetCardAtPosition(position);
                String cardName = card.ToString();
                Bitmap img = (Bitmap) Properties.Resources.ResourceManager.GetObject(cardName);
                listImgCard[position].Image = img;
            }
        }


        private void FillCards()
        {
            listImgCard.Add(imgSouthPlayer1);
            listImgCard.Add(imgSouthPlayer2);
            listImgCard.Add(imgSouthPlayer3);
            listImgCard.Add(imgSouthPlayer4);
            listImgCard.Add(imgSouthPlayer5);
            listImgCard.Add(imgSouthPlayer6);
            listImgCard.Add(imgSouthPlayer7);
            listImgCard.Add(imgSouthPlayer8);
            listImgCard.Add(imgSouthPlayer9);
            listImgCard.Add(imgSouthPlayer10);
            listImgCard.Add(imgSouthPlayer11);
            listImgCard.Add(imgSouthPlayer12);
            listImgCard.Add(imgSouthPlayer13);
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            playerName = txtName.Text;
            InitializePlayers();
            InitializeDeck();
            DistributeCards();
            FillCards();
            ShowCards();
        }
    }
}
