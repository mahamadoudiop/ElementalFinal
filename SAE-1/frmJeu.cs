using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SAE1BibliothequeJeu;

namespace SAE_1
{
    public partial class frmJeu : Form
    {
        private Partie NouvellePartie;

        private Point pacManPosition;
        private Color pacManColor;
        private PictureBox picPersonage;
        private Image Perso_Droite;
        private Image Perso_Gauche;
        private Image Perso_Haut;
        private Image Perso_Bas;
        private const int labyrintheLignes = 17; // Nombre de lignes du labyrinthe
        private const int labyrintheColonnes = 31; // Nombre de colonnes du labyrinthe
        private const int tileWidth = 20; // Largeur de chaque tuile du labyrinthe
        private const int tileHeight = 20; // Hauteur de chaque tuile du labyrinthe
        private char[,] labyrinthe = {
            { 'W', 'W', 'W', 'W', 'W', 'W', 'W', 'W', 'W', 'W', 'W', 'W', 'W', 'W', 'W', 'W', 'W', 'W', 'W', 'W', 'W', 'W', 'W', 'W', 'W', 'W', 'W', 'W', 'W', 'W', 'W' },
            { 'W', '.', '.', '.', 'W', '.', '.', '.', '.', 'W', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', 'W' },
            { 'W', 'W', 'W', '.', 'W', '.', 'W', 'W', 'W', 'W', 'W', '.', 'W', 'W', 'W', '.', 'W', 'W', 'W', '.', 'W', 'W', 'W', '.', 'W', 'W', 'W', '.', 'W', '.', 'W' },
            { 'W', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', 'W' },
            { 'W', '.', 'W', 'W', 'W', 'W', 'W', '.', 'W', 'W', 'W', 'W', 'W', '.', 'W', 'W', 'W', 'W', 'W', '.', 'W', 'W', 'W', 'W', 'W', '.', 'W', 'W', 'W', 'W', 'W' },
            { '|', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '|' },
            { 'W', 'W', 'W', 'W', 'W', '.', 'W', 'W', 'W', 'W', 'W', '.', 'W', 'W', 'W', 'W', 'W', '.', 'W', 'W', 'W', 'W', 'W', 'W', 'W', '.', 'W', 'W', 'W', 'W', 'W' },
            { 'W', '.', '.', '.', 'W', '.', '.', '.', '.', '.', '.', '.', 'W', '.', '.', '.', '.', '.', '.', '.', '.', 'W', '.', '.', '.', '.', '.', 'W', '.', '.', 'W' },
            { 'W', '.', 'W', 'W', 'W', 'W', '.', 'W', 'W', 'W', 'W', 'W', 'W', 'W', 'W', 'W', '.', 'W', 'W', '.', 'W', 'W', 'W', '.', 'W', '.', 'W', 'W', 'W', '.', 'W' },
            { 'W', '.', '.', '.', '.', '.', '.', '.', '.', 'W', '.', '.', '.', '.', '.', '.', '.', 'W', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', 'W' },
            { 'W', 'W', 'W', '.', 'W', 'W', 'W', 'W', '.', 'W', '.', 'W', 'W', 'W', 'W', 'W', 'W', 'W', 'W', '.', 'W', 'W', 'W', 'W', '.', '.', 'W', 'W', 'W', '.', 'W' },
            { 'W', '.', '.', '.', 'W', '.', '.', '.', '.', '.', '.', '.', 'W', '.', '.', '.', '.', 'W', '.', '.', '.', '.', '.', 'W', '.', '.', '.', '.', '.', '.', 'W' },
            { 'W', '.', 'W', 'W', 'W', 'W', 'W', 'W', 'W', '.', 'W', 'W', 'W', 'W', 'W', 'W', '.', 'W', 'W', 'W', 'W', 'W', 'W', 'W', 'W', 'W', 'W', 'W', 'W', '.', 'W' },
            { 'W', '.', '.', '.', 'W', '.', '.', '.', '.', '.', 'W', '.', '.', '.', '.', 'W', '.', '.', '.', '.', '.', '.', 'W', '.', '.', '.', '.', '.', '.', '.', 'W' },
            { 'W', '.', 'W', '.', 'W', '.', 'W', 'W', 'W', '.', 'W', '.', 'W', 'W', 'W', 'W', '.', 'W', 'W', '.', 'W', 'W', 'W', '.', 'W', 'W', 'W', 'W', '.', 'W', 'W' },
            { 'W', '.', 'W', '.', '.', '.', 'W', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', 'W', '.', '.', '.', '.', '.', '.', 'W', '.', '.', '.', '.', '.', 'W' },
            { 'W', 'W', 'W', 'W', 'W', 'W', 'W', 'W', 'W', 'W', 'W', 'W', 'W', 'W', 'W', 'W', 'W', 'W', 'W', 'W', 'W', 'W', 'W', 'W', 'W', 'W', 'W', 'W', 'W', 'W', 'W' }
        };

        public frmJeu(Partie P)
        {
            InitializeComponent();
            pnlLabyrinthe.Resize += new EventHandler(pnlLabyrinthe_Resize);
            this.KeyPreview = true;
            KeyDown += new KeyEventHandler(frmJeu_KeyDown); // Ajout du gestionnaire d'événements pour les touches

            pacManPosition = new Point(1 * tileWidth, 1 * tileHeight); // Position initiale de Pac-Man
            pacManColor = Color.Yellow; // Couleur de Pac-Man

            NouvellePartie = P;
            lblPseudo.Text = P.PseudoJoueur;

            Perso_Droite = Properties.Resources.PersoVersDroite;
            Perso_Gauche = Properties.Resources.PersoVersGauche;
            Perso_Haut = Properties.Resources.PersoVersHaut;
            Perso_Bas = Properties.Resources.PersoVersBas;
            picPersonage = new PictureBox
            {
                Image = Perso_Droite,
                SizeMode = PictureBoxSizeMode.Zoom,
                Size = new Size(tileWidth, tileHeight),
                Location = new Point(1 * tileWidth, 1 * tileHeight), // Position initiale de Pac-Man
                BackColor = Color.Transparent
            };
            pnlLabyrinthe.Controls.Add(picPersonage); // Ajouter Pac-Man au panel
        }



        private void pnlLabyrinthe_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            RedessinerLabyrinthe(g);
        }

        private void pnlLabyrinthe_Resize(object sender, EventArgs e)
        {
            pnlLabyrinthe.Invalidate(); // Forcer le redessin lorsque le panel est redimensionné
        }

        private void RedessinerLabyrinthe(Graphics g)
        {
            // Calculer la taille des tuiles en fonction de la taille du Panel
            int tileWidth = pnlLabyrinthe.Width / labyrintheColonnes;
            int tileHeight = pnlLabyrinthe.Height / labyrintheLignes;

            for (int i = 0; i < labyrinthe.GetLength(0); i++)
            {
                for (int j = 0; j < labyrinthe.GetLength(1); j++)
                {
                    switch (labyrinthe[i, j])
                    {
                        case 'W':
                            g.FillRectangle(Brushes.Black, j * tileWidth, i * tileHeight, tileWidth, tileHeight);
                            break;
                        case '.':
                            g.FillRectangle(Brushes.CadetBlue, j * tileWidth, i * tileHeight, tileWidth, tileHeight);
                            g.FillEllipse(Brushes.Yellow, j * tileWidth + tileWidth / 4, i * tileHeight + tileHeight / 4, tileWidth / 2, tileHeight / 2);
                            break;
                        case '|':
                            g.FillRectangle(Brushes.LightBlue, j * tileWidth, i * tileHeight, tileWidth, tileHeight);
                            break;
                    }
                }
            }

            // Dessiner Pac-Man
            g.FillEllipse(new SolidBrush(pacManColor), pacManPosition.X, pacManPosition.Y, tileWidth, tileHeight);
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            FormPause formPause = new FormPause();
            formPause.Show();
        }



        private void frmJeu_Load(object sender, EventArgs e)
        {
            pnlLabyrinthe.Invalidate(); // Forcer le redessin initial
        }

        private void DeplacerPersonage(int variationX, int variationY)
        {
            int newX = picPersonage.Location.X / tileWidth + variationX;
            int newY = picPersonage.Location.Y / tileHeight + variationY;
            if (newX >= 0 && newX < labyrintheColonnes && newY >= 0 && newY < labyrintheLignes && labyrinthe[newY, newX] != 'W')
            {
                picPersonage.Location = new Point(newX * tileWidth, newY * tileHeight);
            }
        }

            private void frmJeu_KeyDown(object sender, KeyEventArgs e)
        {
            Point newPosition = pacManPosition;

            switch (e.KeyCode)
            {
                case Keys.Z:
                    picPersonage.Image = Perso_Haut;
                    DeplacerPersonage(0, -1);               
                    break;
                case Keys.S:
                    picPersonage.Image = Perso_Bas;
                    DeplacerPersonage(0, 1);                  
                    break;
                case Keys.Q:
                    picPersonage.Image = Perso_Gauche;
                    DeplacerPersonage(-1, 0);
                    break;
                case Keys.D:
                    picPersonage.Image = Perso_Droite;
                    DeplacerPersonage(1, 0);                    
                     break;
            }         
        }

        private void frmJeu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
