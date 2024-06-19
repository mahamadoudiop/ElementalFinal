using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
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

        private List<Ennemi> enemies = new List<Enemi>();
        private Image EnemyImage;
        private Image EnemyImage2;
        private Image EnemyImage3;
        private int score; // Ajouter une variable pour le score
        private Label lblScore; // Ajouter un label pour afficher le score
        private PictureBox picPersonage;
        private Image Perso_Droite;
        private Image Perso_Gauche;
        private Image Perso_Haut;
        private Image Perso_Bas;
        private Image picPiece; // Ajouter une variable pour l'image des points
        private const int labyrintheLignes = 17; // Nombre de lignes du labyrinthe
        private const int labyrintheColonnes = 31; // Nombre de colonnes du labyrinthe
        private int tileWidth = 20; // Largeur de chaque tuile du labyrinthe
        private int tileHeight = 20; // Hauteur de chaque tuile du labyrinthe
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



            NouvellePartie = P;
            lblPseudo.Text = P.PseudoJoueur;

            Perso_Droite = Properties.Resources.PersoVersDroite;
            Perso_Gauche = Properties.Resources.PersoVersGauche;
            Perso_Haut = Properties.Resources.PersoVersHaut;
            Perso_Bas = Properties.Resources.PersoVersBas;
            picPiece = Properties.Resources.piece;

            UpdateTileSize();

            picPersonage = new PictureBox
            {
                Image = Perso_Droite,
                SizeMode = PictureBoxSizeMode.Zoom,
                Size = new Size(tileWidth, tileHeight),
                Location = new Point(1 * tileWidth, 1 * tileHeight), // Position initiale de Pac-Man
                BackColor = Color.Transparent
            };
            pnlLabyrinthe.Controls.Add(picPersonage); // Ajouter Pac-Man au panel

            lblScore = new Label
            {
                Text = "Score: 0",
                Location = new Point(10, 10),
                AutoSize = true,
                ForeColor = Color.White,
                BackColor = Color.Black
            };

            this.Controls.Add(lblScore);

            AjouterPoints(); // Ajouter les points
        }

        private void UpdateTileSize()
        {
            tileWidth = pnlLabyrinthe.Width / labyrintheColonnes;
            tileHeight = pnlLabyrinthe.Height / labyrintheLignes;
        }


        private void pnlLabyrinthe_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            RedessinerLabyrinthe(g);
        }

        private void pnlLabyrinthe_Resize(object sender, EventArgs e)
        {
            UpdateTileSize();
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
                            g.FillRectangle(Brushes.Transparent, j * tileWidth, i * tileHeight, tileWidth, tileHeight);
                            g.FillEllipse(Brushes.Yellow, j * tileWidth + tileWidth / 4, i * tileHeight + tileHeight / 4, tileWidth / 2, tileHeight / 2);
                            break;
                        case '|':
                            g.FillRectangle(Brushes.LightBlue, j * tileWidth, i * tileHeight, tileWidth, tileHeight);
                            break;
                    }
                }
            }
        }

        private void AjouterPoints()
        {

            for (int i = 0; i < labyrinthe.GetLength(0); i++)
            {
                for (int j = 0; j < labyrinthe.GetLength(1); j++)
                {
                    if (labyrinthe[i, j] == '.')
                    {
                        PictureBox pointPictureBox = new PictureBox
                        {
                            Image = picPiece,
                            SizeMode = PictureBoxSizeMode.Zoom,
                            Size = new Size(tileWidth, tileHeight),
                            Location = new Point(j * tileWidth, i * tileHeight),
                            BackColor = Color.Transparent
                        };
                        pnlLabyrinthe.Controls.Add(pointPictureBox);
                    }
                }
            }
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
            // Récupérer la position actuelle du personnage
            int currentX = picPersonage.Location.X;
            int currentY = picPersonage.Location.Y;

            // Calculer la nouvelle position désirée
            int newX = currentX + (variationX * tileWidth);
            int newY = currentY + (variationY * tileHeight);

            // Vérifier les limites du labyrinthe visuel
            if (newX >= 0 && newX + tileWidth <= pnlLabyrinthe.Width &&
                newY >= 0 && newY + tileHeight <= pnlLabyrinthe.Height)
            {
                // Convertir les nouvelles coordonnées en indices de la grille
                int gridX = newX / tileWidth;
                int gridY = newY / tileHeight;

                // Vérifier si la case de la grille est accessible (pas un mur)
                if (gridX >= 0 && gridX < labyrintheColonnes && gridY >= 0 && gridY < labyrintheLignes && labyrinthe[gridY, gridX] != 'W')
                {
                    // Mettre à jour la position du personnage
                    picPersonage.Location = new Point(newX, newY);

                    // Vérifier s'il y a un point à cet emplacement
                    if (labyrinthe[gridY, gridX] == '.')
                    {
                        // Augmenter le score
                        score += 1;
                        lblScore.Text = "Score: " + score; // Mettre à jour le label du score

                        // Retirer le point du labyrinthe
                        labyrinthe[gridY, gridX] = ' ';

                        // Retirer le PictureBox du point
                        foreach (Control control in pnlLabyrinthe.Controls)
                        {
                            if (control is PictureBox && control.Location == new Point(gridX * tileWidth, gridY * tileHeight))
                            {
                                pnlLabyrinthe.Controls.Remove(control);
                                control.Dispose();
                                break;
                            }
                        }
                    }
                }
            }

        }

        private void frmJeu_KeyDown(object sender, KeyEventArgs e)
        {


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

