using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect4
{
    class Connect4
    {
        string[ , ] TableauDeJeu = new string[6, 7] { { " ", " ", " ", " ", " ", " ", " " }, { " ", " ", " ", " ", " ", " ", " " }, { " ", " ", " ", " ", " ", " ", " " }, { " ", " ", " ", " ", " ", " ", " " }, { " ", " ", " ", " ", " ", " ", " " }, { " ", " ", " ", " ", " ", " ", " " } };
        string J1 = "X";
        string J2 = "O";
        int nbtour = 0;
        int valx = 0;
        int valy = 0;

        public Connect4()
        {

        }
        /// <summary>
        /// Le jeu Principal
        /// </summary>
        public void Connect4Main()
        {
            Jeu4();
        }
        
        /// <summary>
        /// L'assembleur du jeu de Connect 4
        /// </summary>
        public void Jeu4()
        {
            bool jouer = true;
            bool winner = false;
            while (jouer == true)
            {
                ResetJeu();
                while (winner == false)
                {
                    //tour joueur 1
                    AfficherJeu();
                    Console.WriteLine("Tour du joueur 1");
                    PlacerPion(J1);
                    Vainqueur(J1);
                    
                    //tour joueur 2
                    AfficherJeu();
                    Console.WriteLine("Tour du joueur 2");
                    PlacerPion(J2);
                    Vainqueur(J2);
                }

                Console.WriteLine("Faire une autre partie ?      o|n");
                if (Console.ReadLine() == "n")
                {
                    jouer = false;
                }
            }
        }
        
        /// <summary>
        /// Affiche le jeu
        /// </summary>
        public void AfficherJeu()
        {
            Console.Clear();

            Console.WriteLine(" 1 2 3 4 5 6 7 ");

            for (int i = 0;i < 6;i++)
            {
                Console.Write("|");
                for (int j = 0;j < 7;j++)
                {
                    Console.Write(TableauDeJeu[i,j] + "|");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Choix de case pour mettre les pions
        /// </summary>
        public void PlacerPion(string joueur)
        {
            int ligne = 8;
            bool choix = false;

            while (choix == false)
            {
                
                Console.WriteLine("Choisis une ligne entre 1 et 7 !");
                while (choix == false)
                {
                    int.TryParse(Console.ReadLine(), out ligne);
            
                    ligne = ligne - 1;

                    if (ligne >= 0 & ligne <=6)
                    {
                        if (TableauDeJeu[0,ligne] == J1 && TableauDeJeu[0, ligne] == J2)
                        {

                        }
                        else 
                        {
                            choix = true;
                        } 
                    }
                    else
                    {
                        Console.Clear();
                        AfficherJeu();
                        Console.WriteLine("Une casse LIBRE et entre 1 et 7 ");
                    }
}
                
            }
            
            if (ligne == 0)
            {
                for (int i = 5; i > -1;i--)
                {
                    if (TableauDeJeu[i, 0] == " ")
                    {
                        TableauDeJeu[i, 0] = joueur;
                        valx = 0;
                        valy = i;
                        i = -1;
                        
                    }
                }
            }
            if (ligne == 1)
            {
                for (int i = 5; i > -1; i--)
                {
                    if (TableauDeJeu[i, 1] == " ")
                    {
                        TableauDeJeu[i, 1] = joueur;
                        valx = 1;
                        valy = i;
                        i = -1;
                    }
                }
            }
            if (ligne == 2)
            {
                for (int i = 5; i > -1; i--)
                {
                    if (TableauDeJeu[i, 2] == " ")
                    {
                        TableauDeJeu[i, 2] = joueur;
                        valx = 2;
                        valy = i;
                        i = -1;
                    }
                }
            }
            if (ligne == 3)
            {
                for (int i = 5; i > -1; i--)
                {
                    if (TableauDeJeu[i, 3] == " ")
                    {
                        TableauDeJeu[i, 3] = joueur;
                        valx = 3;
                        valy = i;
                        i = -1;
                    }
                }
            }
            if (ligne == 4)
            {
                for (int i = 5; i >-1; i--)
                {
                    if (TableauDeJeu[i, 4] == " ")
                    {
                        TableauDeJeu[i, 4] = joueur;
                        valx = 4;
                        valy = i;
                        i = -1;
                    }
                }
            }
            if (ligne == 5)
            {
                for (int i = 5; i >-1; i--)
                {
                    if (TableauDeJeu[i, 5] == " ")
                    {
                        TableauDeJeu[i, 5] = joueur;
                        valx = 5;
                        valy = i;
                        i = -1;
                    }
                }
            }
            if (ligne == 6)
            {
                for (int i = 5; i >-1; i--)
                {
                    if (TableauDeJeu[i, 6] == " ")
                    {
                        TableauDeJeu[i, 6] = joueur;
                        valx = 6;
                        valy = i;
                        i = -1;
                    }
                }
            }


        }

        public void Vainqueur(string joueur)
        {
            bool verifH = false;
            bool verifV = false;
            bool verifD = false;

            //vérification horizontale
            while(!verifH)
            {
                bool droite = false;
                bool gauche = false;
                int point = 1;

                int valx2 = valx;
                //droite
                while(!droite)
                {
                    valx2++;

                    if (TableauDeJeu[valy,valx2] == joueur)
                    {
                        point++;

                        if(valx2 == 6)
                        {
                            droite = true;
                        }
                    }
                    else if (TableauDeJeu[valy, valx2] != joueur)
                    {
                        droite= true;
                    }
                }

                //gauche
                valx2 = valx;

                while (!gauche)
                {
                    valx2--;

                    if (TableauDeJeu[valy, valx2] == joueur)
                    {
                        point++;

                        if (valx2 == 0)
                        {
                            gauche = true;
                        }
                    }
                    else if (TableauDeJeu[valy, valx2] != joueur)
                    {
                        gauche = true;
                    }
                }

                //regarde si ont a un gagnant
                if (point >= 4)
                {
                    verifD = true;
                    verifH = true;
                    verifV = true;
                    if (joueur == "X")
                    {
                        Console.WriteLine("Joueur 1 gagne la partie");
                    }
                    else if (joueur == "O")
                    {
                        Console.WriteLine("Joueur 2 gagne la partie");
                    }
                }
                else 
                {
                    verifH = true;
                }
            }
            

            //vérification verticale
            while(!verifV)
            {

            }

            //vérification diagonale
            while(!verifD)
            {

            }



            if (joueur == J1)
            {

            }
            if (joueur == J2)
            {

            }
        }

    /// <summary>
    /// remettre toutes les valeur du tableau à nul
    /// </summary>
        public void ResetJeu()
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    TableauDeJeu[i, j] = " ";
                }
            }
        }
    
    
    
    
    
    
    }
}
