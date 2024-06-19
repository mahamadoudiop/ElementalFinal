using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
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
        private int pointsRestants;


        private List<Ennemi> enemies = new List<Ennemi>();
        private Image picEnnemi1;
        private Image picEnnemi2;
        private Image picEnnemi3;
        private int score = 0; // Ajouter une variable pour le score
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
            this.DoubleBuffered = true;
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
                Text = "Score: " + score,
                AutoSize = true,
                Location = new Point(10, 10),
                ForeColor = Color.Black,
                BackColor = Color.Transparent,
                Font = new Font("Arial", 10)
            };


            this.Controls.Add(lblScore);

            picEnnemi1 = Properties.Resources.ennemi_1;
            picEnnemi2 = Properties.Resources.ennemi_2;
            picEnnemi3 = Properties.Resources.ennemi_3;

            enemies.Add(new Ennemi(10, 5, tileWidth, tileHeight, picEnnemi1, labyrinthe));
            enemies.Add(new Ennemi(15, 8, tileWidth, tileHeight, picEnnemi2, labyrinthe));
            enemies.Add(new Ennemi(5, 10, tileWidth, tileHeight, picEnnemi3, labyrinthe));

            AjouterPoints(); // Ajouter les points
            AjouterEnnemis();

        }

        private void CompterPointsRestants()
        {
            pointsRestants = 0;
            for (int i = 0; i < labyrinthe.GetLength(0); i++)
            {
                for (int j = 0; j < labyrinthe.GetLength(1); j++)
                {
                    if (labyrinthe[i, j] == '.')
                    {
                        pointsRestants++;
                    }
                }
            }
        }

        private void AjouterEnnemis()
        {
            foreach (var ennemi in enemies)
            {
                pnlLabyrinthe.Controls.Add(ennemi.PictureBox);
                ennemi.PictureBox.BringToFront();
            }
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
            foreach (var ennemi in enemies)
            {
                ennemi.PictureBox.BringToFront();
            }
        }

        private void pnlLabyrinthe_Resize(object sender, EventArgs e)
        {
            UpdateTileSize();
            picPersonage.BringToFront();
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
            frmPause formPause = new frmPause();
            formPause.Show();
        }



        private void frmJeu_Load(object sender, EventArgs e)
        {
            pnlLabyrinthe.Invalidate(); // Forcer le redessin initial
        }

        private void DeplacerPersonage(int deltaX, int deltaY)
        {
            int XActuel = picPersonage.Location.X;
            int YActuel = picPersonage.Location.Y;

            int newX = XActuel + deltaX;
            int newY = YActuel + deltaY;

            // Vérifier les limites du panel et les collisions avec les murs
            if (newX >= 0 && newX + tileWidth <= pnlLabyrinthe.Width &&
                newY >= 0 && newY + tileHeight <= pnlLabyrinthe.Height)
            {
                int gridX = newX / tileWidth;
                int gridY = newY / tileHeight;

                if (gridX >= 0 && gridX < labyrintheColonnes && gridY >= 0 && gridY < labyrintheLignes && labyrinthe[gridY, gridX] != 'W')
                {
                    if (labyrinthe[gridY, gridX] == '.')
                    {
                        score += 1;
                        lblScore.Text = "Score: " + score;
                        labyrinthe[gridY, gridX] = ' ';

                        foreach (Control control in pnlLabyrinthe.Controls)
                        {
                            if (control is PictureBox && control.Location == new Point(gridX * tileWidth, gridY * tileHeight))
                            {
                                pnlLabyrinthe.Controls.Remove(control);
                                control.Dispose();
                                break;
                            }
                        }

                        // Mettre à jour les points restants
                        pointsRestants--;

                        // Vérifier si tous les points ont été collectés
                        if (pointsRestants == 0)
                        {
                            // Ouvrir le formulaire de fin de partie
                            frmPartieTerminer frmPartieTerminer = new frmPartieTerminer(score);
                            frmPartieTerminer.ShowDialog();
                            this.Close(); // Fermer le formulaire de jeu actuel
                        }
                    }
                    picPersonage.Location = new Point(newX, newY);
                }
            }
        }

        private void frmJeu_KeyDown(object sender, KeyEventArgs e)
        {
            int deltaX = 0;
            int deltaY = 0;

            switch (e.KeyCode)
            {
                case Keys.D:
                    picPersonage.Image = Perso_Droite;
                    deltaX = tileWidth; // Déplacement vers la droite
                    break;
                case Keys.Q:
                    picPersonage.Image = Perso_Gauche;
                    deltaX = -tileWidth; // Déplacement vers la gauche
                    break;
                case Keys.Z:
                    picPersonage.Image = Perso_Haut;
                    deltaY = -tileHeight; // Déplacement vers le haut
                    break;
                case Keys.S:
                    picPersonage.Image = Perso_Bas;
                    deltaY = tileHeight; // Déplacement vers le bas
                    break;
            }

            DeplacerPersonage(deltaX, deltaY);

            foreach (var ennemi in enemies)
            {
                //Logique de mouvement des ennemis (par exemple aléatoire)
                Random random = new Random();
                int direction = random.Next(4); // 0:droite, 1: gauche, 2: haut, 3: bas

                switch (direction)
                {
                    case 0:
                        ennemi.DeplacementEnnemis(1, 0);
                        break;
                    case 1:
                        ennemi.DeplacementEnnemis(-1, 0);
                        break;
                    case 2:
                        ennemi.DeplacementEnnemis(0, -1);
                        break;
                    case 3:
                        ennemi.DeplacementEnnemis(0, 1);
                        break;
                }
            }
        }

        private void frmJeu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

       

        
    }
    public class Ennemi
    {
        public PictureBox PictureBox { get; private set; }
        private int tileWidth;
        private int tileHeight;
        private char[,] labyrinthe;

        public Ennemi(int x, int y, int width, int height, Image image, char[,] labyrinthe)
        {
            PictureBox = new PictureBox
            {
                Image = image,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Size = new Size(width, height),
                Location = new Point(x * width, y * height),
                BackColor = Color.Transparent
            };

            tileWidth = width;
            tileHeight = height;
            this.labyrinthe = labyrinthe;
        }

        public void DeplacementEnnemis(int deltaX, int deltaY)
        {
            int newX = PictureBox.Location.X + (deltaX * tileWidth);
            int newY = PictureBox.Location.Y + (deltaY * tileHeight);

            int gridX = newX / tileWidth;
            int gridY = newY / tileHeight;

            if (gridX >= 0 && gridX < labyrinthe.GetLength(1) && gridY >= 0 && gridY < labyrinthe.GetLength(0) && labyrinthe[gridY, gridX] != 'W')
            {
                PictureBox.Location = new Point(newX, newY);
                PictureBox.BringToFront();
            }
        }
    }

}
