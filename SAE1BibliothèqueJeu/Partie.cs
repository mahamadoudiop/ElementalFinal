namespace SAE1BibliothequeJeu
{

    public class Partie
    {
        private string _pseudoJoueur;
        public Partie(string PseudoJoueur)
        {
            _pseudoJoueur = PseudoJoueur;
        }

        public string PseudoJoueur
        {
            get
            {
                return _pseudoJoueur;
            }
        }
    }

}
