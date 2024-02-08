namespace PO1_Encapsulation
{
    public partial class Form1 : Form
    {
        Personnage joueur = new Personnage(); // creation de l'objet joeur
        Personnage dragon = new Personnage(); // creation de l'objet dragon
        public Form1()
        {

            InitializeComponent();

            joueur.PointDeVie = 10;
            dragon.PointDeVie = joueur.PointDeVie * 3;
            joueur.PointsDePuissance = 1;
            dragon.PointsDePuissance = joueur.PointsDePuissance * 3;

        }
        //creation d'une fonction qui actualise les données dans le form
        private void ActualiserLabel()
        {
            lbl_pointsVieJoueur.Text = " Point de vie :" +
                joueur.PointDeVie.ToString();

            lbl_pointsVieDragon.Text = "Point de vie :" +
                dragon.PointDeVie.ToString();

            lbl_puissanceAttaqueJoueur.Text = " Puissance d'attaque :" +
                joueur.PointsDePuissance.ToString();

            lbl_puissanceAttaqueDragon.Text = " Puissance d'attaque :" +
                dragon.PointsDePuissance.ToString();
        }
        private void btn_attaquer_Click(object sender, EventArgs e)
        {
            dragon.PointDeVie -= joueur.PointsDePuissance;
            TourDragon();
            ActualiserLabel();
        }

        private void btn_seSoigner_Click(object sender, EventArgs e)
        {
            joueur.PointDeVie += 5;
            TourDragon();
            ActualiserLabel();
        }

        private void btn_puissanceAttaque_Click(object sender, EventArgs e)
        {
            joueur.PointsDePuissance += 1;
            TourDragon();
            ActualiserLabel();
        }

        private void TourDragon()
        {
            joueur.PointDeVie -= dragon.PointsDePuissance;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ActualiserLabel();
        }
    }
}