using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAE_1
{
    public partial class FormJeu : Form
    {
        private Point pacManPosition;
        private Color pacManColor;
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

        public FormJeu(string nomjoueur)
        {
            InitializeComponent();
            pnlLabyrinthe.Resize += new EventHandler(pnlLabyrinthe_Resize);
            this.KeyPreview = true;
            KeyDown += new KeyEventHandler(FormJeu_KeyDown); // Ajout du gestionnaire d'événements pour les touches

            pacManPosition = new Point(1 * tileWidth, 1 * tileHeight); // Position initiale de Pac-Man
            pacManColor = Color.Yellow; // Couleur de Pac-Man
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            pnlLabyrinthe.Invalidate(); // Forcer le redessin initial
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

        private void FormJeu_KeyDown(object sender, KeyEventArgs e)
        {
            Point newPosition = pacManPosition;

            switch (e.KeyCode)
            {
                case Keys.Z:
                    newPosition = new Point(pacManPosition.X, pacManPosition.Y - tileHeight);
                    break;
                case Keys.S:
                    newPosition = new Point(pacManPosition.X, pacManPosition.Y + tileHeight);
                    break;
                case Keys.Q:
                    newPosition = new Point(pacManPosition.X - tileWidth, pacManPosition.Y);
                    break;
                case Keys.D:
                    newPosition = new Point(pacManPosition.X + tileWidth, pacManPosition.Y);
                    break;
            }

            // Vérifier si la nouvelle position est valide (ne pas traverser les murs)
            if (IsPositionValid(newPosition))
            {
                pacManPosition = newPosition;
                pnlLabyrinthe.Invalidate(); // Redessiner le labyrinthe avec la nouvelle position de Pac-Man
            }
        }

        private bool IsPositionValid(Point position)
        {
            int col = position.X / tileWidth;
            int row = position.Y / tileHeight;

            if (col < 0 || col >= labyrintheColonnes || row < 0 || row >= labyrintheLignes)
            {
                return false; // En dehors des limites du labyrinthe
            }

            return labyrinthe[row, col] != 'W'; // Retourne true si la position n'est pas un mur
        }

        private void FormJeu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
