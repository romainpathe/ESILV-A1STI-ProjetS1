using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics;

namespace ProjetCS
{
    class Program
    {
        #region MenuManagement

        static void MainMenu(bool error)
        {
            //Affichage du menu principale de l'application
            Console.WriteLine("                                     --------------- Menu principal ---------------");
            Console.WriteLine("                                     |                                            |");
            //Affichage de l'erreur
            if (error == true)
            {
                Console.WriteLine("                                     |        /!\\ Une erreur est survenue         |");
                Console.WriteLine("                                     |   Il faut un chiffre entier entre 1 et 8   |");
                Console.WriteLine("                                     |                                            |");
            }
            //Affichage du reste du menu une fois l'erreur passé
            Console.WriteLine("                                     |   1: Vérifier si un nombre est Armstrong   |");
            Console.WriteLine("                                     |   2: Vérifier si un nombre est réversible  |");
            Console.WriteLine("                                     |   3: Calculer la somme des diviseurs       |");
            Console.WriteLine("                                     |   4: Trouver la bonne année                |");
            Console.WriteLine("                                     |   5: Somme des chiffres d'une puissance    |");
            Console.WriteLine("                                     |   6: Partie B                              |");
            Console.WriteLine("                                     |   7: Partie C                              |");
            Console.WriteLine("                                     |   8: Quitter l'application                 |");
            Console.WriteLine("                                     |                                            |");
            Console.WriteLine("                                     |                                            |");
            Console.WriteLine("                                     |          Quels est votre choix ?           |");
            Console.WriteLine("                                     |                                            |");
            Console.WriteLine("                                     ----------------------------------------------");
            //Récupération du choix dans la variable choix
            bool x = Int32.TryParse(Console.ReadLine(), out int choix);
            //Vérification si la valeur de l'utilisateur est valide ou non
            if (x == true && choix >= 1 && choix <= 8)
            {
                //Action en fonction du choix de l'utilisateur
                switch (choix)
                {
                    case 1:
                        Console.Clear();
                        error = false;
                        NbArmstrong(error);
                        break;
                    case 2:
                        Console.Clear();
                        NbReversible();
                        break;
                    case 3:
                        Console.Clear();
                        SommeDiviseur();
                        break;
                    case 4:
                        Console.Clear();
                        BonneAnnee();
                        break;
                    case 5:
                        Console.Clear();
                        SommePuissance();
                        break;
                    case 6:
                        Console.Clear();
                        error = false;
                        DateMenu(error);
                        break;
                    case 7:
                        Console.Clear();
                        ProjectMenu();
                        break;
                    case 8:
                        Console.Clear();
                        END();
                        break;
                    default:
                        error = true;
                        Console.Clear();
                        MainMenu(error);
                        break;
                }
            }
            //En cas d'erreur dans la valeur de l'utilisateur, Retourne le menu avec une erreur
            else
            { Console.Clear(); error = true; MainMenu(error); }

        }

        static void DateMenu(bool error)
        {
            //Affichage du menu des dates
            Console.WriteLine("                                     --------------- Menu des dates ---------------");
            Console.WriteLine("                                     |                                            |");
            //Affichage de l'erreur
            if (error == true)
            {
                Console.WriteLine("                                     |        /!\\ Une erreur est survenue         |");
                Console.WriteLine("                                     |   Il faut un chiffre entier entre 1 et 7   |");
                Console.WriteLine("                                     |                                            |");
            }
            //Affichage du reste du menu une fois l'erreur passé
            Console.WriteLine("                                     |  1: Calcul de la date du lendemain         |");
            Console.WriteLine("                                     |  2: Calcul du nombre de jours entre 2 dates|");
            Console.WriteLine("                                     |  3: Vérifier si une année est Bissextile   |");
            Console.WriteLine("                                     |  4: Calculer la date de pâques             |");
            Console.WriteLine("                                     |  5: Afficher le calendrier d'une année     |");
            Console.WriteLine("                                     |  6: Méthode innovante avec les dates       |");
            Console.WriteLine("                                     |  7: Menu Principal                         |");
            Console.WriteLine("                                     |                                            |");
            Console.WriteLine("                                     |                                            |");
            Console.WriteLine("                                     |          Quels est votre choix ?           |");
            Console.WriteLine("                                     |                                            |");
            Console.WriteLine("                                     ----------------------------------------------");
            //Récupération du choix dans la variable choix
            bool x = Int32.TryParse(Console.ReadLine(), out int choix);
            //Vérification si la valeur de l'utilisateur est valide ou non
            if (x == true && choix >= 1 && choix <= 7)
            {
                //Action en fonction du choix de l'utilisateur
                switch (choix)
                {
                    case 1:
                        Console.Clear();
                        Lendemain();
                        break;
                    case 2:
                        Console.Clear();
                        NbDayTwoDate();
                        break;
                    case 3:
                        Console.Clear();
                        Bissextile();
                        break;
                    case 4:
                        Console.Clear();
                        PacquesMenu(false);
                        break;
                    case 5:
                        Console.Clear();
                        Calendar();
                        break;
                    case 6:
                        Console.Clear();
                        DateOfWeek();
                        break;
                    case 7:
                        Console.Clear();
                        MainMenu(false);
                        break;
                    default:
                        Console.Clear();
                        DateMenu(true);
                        break;
                }
            }
            //En cas d'erreur dans la valeur de l'utilisateur, Retourne le menu avec une erreur
            else
            { Console.Clear(); DateMenu(true); }

        }

        // Menu pour le choix de la methode de pacques 
        static void PacquesMenu(bool error)
        {
            //Affichage du menu des dates
            Console.WriteLine("                                     --------------- Menu de Pacques --------------");
            Console.WriteLine("                                     |                                            |");
            //Affichage de l'erreur
            if (error == true)
            {
                Console.WriteLine("                                     |        /!\\ Une erreur est survenue         |");
                Console.WriteLine("                                     |   Il faut un chiffre entier entre 1 et 4   |");
                Console.WriteLine("                                     |                                            |");
            }
            //Affichage du reste du menu une fois l'erreur passé
            Console.WriteLine("                                     |  1: Méthode de GAUSS                       |");
            Console.WriteLine("                                     |  2: Méthode de MEEUS                       |");
            Console.WriteLine("                                     |  3: Méthode de CONWAY                      |");
            Console.WriteLine("                                     |  4: Revenir en arriére                     |");
            Console.WriteLine("                                     |                                            |");
            Console.WriteLine("                                     |                                            |");
            Console.WriteLine("                                     |          Quels est votre choix ?           |");
            Console.WriteLine("                                     |                                            |");
            Console.WriteLine("                                     ----------------------------------------------");
            //Récupération du choix dans la variable choix
            bool x = Int32.TryParse(Console.ReadLine(), out int choix);
            //Vérification si la valeur de l'utilisateur est valide ou non
            if (x == true && choix >= 1 && choix <= 4)
            {
                //Action en fonction du choix de l'utilisateur
                switch (choix)
                {
                    case 1:
                        Console.Clear();
                        Pacque(1);
                        break;
                    case 2:
                        Console.Clear();
                        Pacque(2);
                        break;
                    case 3:
                        Console.Clear();
                        Pacque(3);
                        break;
                    case 4:
                        Console.Clear();
                        error = false;
                        DateMenu(error);
                        break;
                    default:
                        error = true;
                        Console.Clear();
                        PacquesMenu(error);
                        break;
                }
            }
            //En cas d'erreur dans la valeur de l'utilisateur, Retourne le menu avec une erreur
            else
            { Console.Clear(); error = true; PacquesMenu(error); }

        }

        static void EndMenu(bool error)
        {
            Console.WriteLine("                                     ----------------- Menu de fin ----------------");
            Console.WriteLine("                                     |                                            |");
            if (error == true)
            {
                Console.WriteLine("                                     |        /!\\ Une erreur est survenue         |");
                Console.WriteLine("                                     |   Il faut un chiffre entier entre 1 et 2   |");
                Console.WriteLine("                                     |                                            |");
            }
            //Console.WriteLine("                                     |   1: Relancer ce programme                 |");
            Console.WriteLine("                                     |   1: Retourné au menu principale           |");
            Console.WriteLine("                                     |   2: Quitter l'application                 |");
            Console.WriteLine("                                     |                                            |");
            Console.WriteLine("                                     |                                            |");
            Console.WriteLine("                                     |          Quels est votre choix ?           |");
            Console.WriteLine("                                     |                                            |");
            Console.WriteLine("                                     ----------------------------------------------");

            //Récupération du choix dans la variable choix
            bool x = Int32.TryParse(Console.ReadLine(), out int choix);
            //Vérification si la valeur de l'utilisateur est valide ou non
            if (x == true && choix >= 1 && choix <= 2)
            {
                //Action en fonction du choix de l'utilisateur
                switch (choix)
                {
                    //case 1:
                    //Console.Clear();
                    //NbArmstrong(error = false);
                    //break;
                    case 1:
                        Console.Clear();
                        error = false;
                        MainMenu(error);
                        break;
                    case 2:
                        Console.Clear();
                        END();
                        break;
                    default:
                        error = true;
                        EndMenu(error);
                        break;
                }
            }
            //En cas d'erreur dans la valeur de l'utilisateur, Retourne le menu avec une erreur
            else
            { Console.Clear(); error = true; EndMenu(error); }
        }

        static void END()
        {
            Console.WriteLine("\n\n\n\n\n\n");
            Console.WriteLine("                                     **********************************************");
            Console.WriteLine("                                     *****************  A bientôt  ****************");
            Console.WriteLine("                                     ***********  Application 2020-2021  **********");
            Console.WriteLine("                                     ********  Par Romain Pathé pour ESILV  *******");
            Console.WriteLine("                                     **********************************************");
        }

        #endregion

        #region Other Function
        //Selection d'un intervalle
        static bool SelectInterval(bool error, out int valeurMin, out int valeurMax)
        {
            bool x;
            //Boucle pour la selection de la valeur minimal
            do
            {
                Console.Clear();
                Console.WriteLine("                                     ------------ Séléction d'intervale -----------");
                Console.WriteLine("                                     |                                            |");
                if (error == true)
                {
                    Console.WriteLine("                                     |        /!\\ Une erreur est survenue         |");
                    Console.WriteLine("                                     |   - Il faut des valeurs entiére positive   |");
                    Console.WriteLine("                                     |                                            |");
                }
                Console.WriteLine("                                     |   Saisir la valeur minimal de l'intervale: |");
                Console.WriteLine("                                     |                                            |");
                Console.WriteLine("                                     |   Valeur Minimal: En attente               |");
                Console.WriteLine("                                     |   Valeur Maximal: A suivre                 |");
                Console.WriteLine("                                     |                                            |");
                Console.WriteLine("                                     |                                            |");
                Console.WriteLine("                                     |          Quels est votre choix ?           |");
                Console.WriteLine("                                     |                                            |");
                Console.WriteLine("                                     ----------------------------------------------");
                x = Int32.TryParse(Console.ReadLine(), out valeurMin);
                error = true;
            } while (x == false || valeurMin < 0);

            error = false;
            //Boucle pour la selection de la valeur maximal
            do
            {
                Console.Clear();
                Console.WriteLine("                                     ------------ Séléction d'intervale -----------");
                Console.WriteLine("                                     |                                            |");
                if (error == true)
                {
                    Console.WriteLine("                                     |        /!\\ Une erreur est survenue         |");
                    Console.WriteLine("                                     |   - Il faut des valeurs entiére positive   |");
                    Console.WriteLine("                                     |   - La valeur doit être > à la minimal     |");
                    Console.WriteLine("                                     |                                            |");
                }
                Console.WriteLine("                                     |   Saisir la valeur maximal de l'intervale: |");
                Console.WriteLine("                                     |                                            |");
                Console.WriteLine("                                     |   Valeur Minimal: Fait                     |");
                Console.WriteLine("                                     |   Valeur Maximal: En attente               |");
                Console.WriteLine("                                     |                                            |");
                Console.WriteLine("                                     |                                            |");
                Console.WriteLine("                                     |          Quels est votre choix ?           |");
                Console.WriteLine("                                     |                                            |");
                Console.WriteLine("                                     ----------------------------------------------");
                x = Int32.TryParse(Console.ReadLine(), out valeurMax);
                error = true;
            } while (x == false || valeurMax <= valeurMin);
            return true;
        }
        //Vérification si une année est bis
        static bool LeapYear(int year, out bool bis)
        {
            bis = false;
            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
            {
                bis = true;
            }
            return bis;
        }
        //Saisie d'une date sous la forme a/m/j
        static string EnterDate(out string result)
        {
            result = "";
            int annee, mois, jour = 0;
            bool x, error = false;
            //Saisie de l'année
            do
            {


                Console.WriteLine("                                     -------------- Saisie d'une Date -------------");
                Console.WriteLine("                                     |                                            |");
                //Affichage de l'erreur
                if (error == true)
                {
                    Console.WriteLine("                                     |        /!\\ Une erreur est survenue         |");
                    Console.WriteLine("                                     |     L'année doit être un nombre entier     |");
                    Console.WriteLine("                                     |                                            |");
                }
                //Affichage du reste du menu une fois l'erreur passé
                Console.WriteLine("                                     |   Saisir une année entre (1000 et 9999):   |");
                Console.WriteLine("                                     |                                            |");
                Console.WriteLine("                                     |          Quels est votre année ?           |");
                Console.WriteLine("                                     |                                            |");
                Console.WriteLine("                                     ----------------------------------------------");
                x = Int32.TryParse(Console.ReadLine(), out annee);
                error = true;
                Console.Clear();
            } while (x != true || annee <= 999 || annee > 9999 || annee % 1 != 0);
            //Verification si l'année est bis.
            LeapYear(annee, out bool bis);
            //Création du retour de la fonction
            if (bis) result = "t" + "/";
            else if (!bis) result = "f" + "/";
            result = result + annee + "/";
            Debug.WriteLine(result);
            error = false;
            //Saisie du mois
            do
            {
                Console.WriteLine("                                     -------------- Saisie d'une Date -------------");
                Console.WriteLine("                                     |                                            |");
                //Affichage de l'erreur
                if (error == true)
                {
                    Console.WriteLine("                                     |        /!\\ Une erreur est survenue         |");
                    Console.WriteLine("                                     |     Le mois doit être un nombre entier     |");
                    Console.WriteLine("                                     |                                            |");
                }
                //Affichage du reste du menu une fois l'erreur passé
                Console.WriteLine("                                     |       Saisir un mois entre (1 et 12):      |");
                Console.WriteLine("                                     |                                            |");
                Console.WriteLine("                                     |           Quels est votre mois ?           |");
                Console.WriteLine("                                     |                                            |");
                Console.WriteLine("                                     ----------------------------------------------");
                x = Int32.TryParse(Console.ReadLine(), out mois);
                error = true;
                Console.Clear();
            } while (x != true || mois <= 0 || mois > 12 || mois % 1 != 0);
            //Création du retour de la fonction
            result = result + mois.ToString("00") + "/";
            Debug.WriteLine(result);
            error = false;
            //Saisie des jours
            if (bis && mois.ToString("00") == "02")
            {
                do
                {
                    Console.WriteLine("                                     -------------- Saisie d'une Date -------------");
                    Console.WriteLine("                                     |                                            |");
                    //Affichage de l'erreur
                    if (error == true)
                    {
                        Console.WriteLine("                                     |        /!\\ Une erreur est survenue         |");
                        Console.WriteLine("                                     |     Le jour doit être un nombre entier     |");
                        Console.WriteLine("                                     |                                            |");
                    }
                    //Affichage du reste du menu une fois l'erreur passé
                    Console.WriteLine("                                     |       Saisir un jour entre (1 et 29):      |");
                    Console.WriteLine("                                     |                                            |");
                    Console.WriteLine("                                     |           Quels est votre jour ?           |");
                    Console.WriteLine("                                     |                                            |");
                    Console.WriteLine("                                     ----------------------------------------------");
                    x = Int32.TryParse(Console.ReadLine(), out jour);
                    error = true;
                    Console.Clear();
                } while (x != true || jour <= 0 || jour > 29 || jour % 1 != 0);
            } else if (!bis && mois.ToString("00") == "02")
            {
                do
                {
                    Console.WriteLine("                                     -------------- Saisie d'une Date -------------");
                    Console.WriteLine("                                     |                                            |");
                    //Affichage de l'erreur
                    if (error == true)
                    {
                        Console.WriteLine("                                     |        /!\\ Une erreur est survenue         |");
                        Console.WriteLine("                                     |     Le jour doit être un nombre entier     |");
                        Console.WriteLine("                                     |                                            |");
                    }
                    //Affichage du reste du menu une fois l'erreur passé
                    Console.WriteLine("                                     |       Saisir un jour entre (1 et 28):      |");
                    Console.WriteLine("                                     |                                            |");
                    Console.WriteLine("                                     |           Quels est votre jour ?           |");
                    Console.WriteLine("                                     |                                            |");
                    Console.WriteLine("                                     ----------------------------------------------");
                    x = Int32.TryParse(Console.ReadLine(), out jour);
                    error = true;
                    Console.Clear();
                } while (x != true || jour <= 0 || jour > 28 || jour % 1 != 0);
            }
            else if (!bis && mois.ToString("00") == "02")
            {
                do
                {
                    Console.WriteLine("                                     -------------- Saisie d'une Date -------------");
                    Console.WriteLine("                                     |                                            |");
                    //Affichage de l'erreur
                    if (error == true)
                    {
                        Console.WriteLine("                                     |        /!\\ Une erreur est survenue         |");
                        Console.WriteLine("                                     |     Le jour doit être un nombre entier     |");
                        Console.WriteLine("                                     |                                            |");
                    }
                    //Affichage du reste du menu une fois l'erreur passé
                    Console.WriteLine("                                     |       Saisir un jour entre (1 et 28):      |");
                    Console.WriteLine("                                     |                                            |");
                    Console.WriteLine("                                     |           Quels est votre jour ?           |");
                    Console.WriteLine("                                     |                                            |");
                    Console.WriteLine("                                     ----------------------------------------------");
                    x = Int32.TryParse(Console.ReadLine(), out jour);
                    error = true;
                    Console.Clear();
                } while (x != true || jour <= 0 || jour > 28 || jour % 1 != 0);
            }
            else if (mois.ToString("00") == "01" || mois.ToString("00") == "03" || mois.ToString("00") == "05" || mois.ToString("00") == "07" || mois.ToString("00") == "08" || mois.ToString("00") == "10" || mois.ToString("00") == "12")
            {
                do
                {
                    Console.WriteLine("                                     -------------- Saisie d'une Date -------------");
                    Console.WriteLine("                                     |                                            |");
                    //Affichage de l'erreur
                    if (error == true)
                    {
                        Console.WriteLine("                                     |        /!\\ Une erreur est survenue         |");
                        Console.WriteLine("                                     |     Le jour doit être un nombre entier     |");
                        Console.WriteLine("                                     |                                            |");
                    }
                    //Affichage du reste du menu une fois l'erreur passé
                    Console.WriteLine("                                     |       Saisir un jour entre (1 et 31):      |");
                    Console.WriteLine("                                     |                                            |");
                    Console.WriteLine("                                     |           Quels est votre jour ?           |");
                    Console.WriteLine("                                     |                                            |");
                    Console.WriteLine("                                     ----------------------------------------------");
                    x = Int32.TryParse(Console.ReadLine(), out jour);
                    error = true;
                    Console.Clear();
                } while (x != true || jour <= 0 || jour > 31 || jour % 1 != 0);
            }
            else if (mois.ToString("00") == "04" || mois.ToString("00") == "06" || mois.ToString("00") == "09" || mois.ToString("00") == "11")
            {
                do
                {
                    Console.WriteLine("                                     -------------- Saisie d'une Date -------------");
                    Console.WriteLine("                                     |                                            |");
                    //Affichage de l'erreur
                    if (error == true)
                    {
                        Console.WriteLine("                                     |        /!\\ Une erreur est survenue         |");
                        Console.WriteLine("                                     |     Le jour doit être un nombre entier     |");
                        Console.WriteLine("                                     |                                            |");
                    }
                    //Affichage du reste du menu une fois l'erreur passé
                    Console.WriteLine("                                     |       Saisir un jour entre (1 et 30):      |");
                    Console.WriteLine("                                     |                                            |");
                    Console.WriteLine("                                     |           Quels est votre jour ?           |");
                    Console.WriteLine("                                     |                                            |");
                    Console.WriteLine("                                     ----------------------------------------------");
                    x = Int32.TryParse(Console.ReadLine(), out jour);
                    error = true;
                    Console.Clear();
                } while (x != true || jour <= 0 || jour > 30 || jour % 1 != 0);
            }
            //Gestion des jours pour le retour de la fonction
            result += jour.ToString("00");
            Debug.WriteLine(result);
            return result;

        }
        //Affichage d'un mois du calendrier
        static void DisplayMonth(int DayStart, int NbDay, string MonthName, out int stopday)
        {
            int week = 0, placementday = 0, myweek = 0, myday = 0;
            string[,] month = new string[6, 7];
            //Boucle pour stocker chaque mois
            for (int day = 1; day <= NbDay + DayStart; day++)
            {
                if (day <= DayStart)
                {
                    month[week, placementday] = " .";
                } else if (day - DayStart <= 9)
                {
                    month[week, placementday] = " " + (day - DayStart);
                }
                else
                {
                    month[week, placementday] = Convert.ToString(day - DayStart);
                }
                placementday++;
                if (placementday > 6)
                {
                    week++;
                    placementday = 0;
                }
            }
            //Vérification du jour de fin pour l'ajout des .
            if (placementday != 1 && placementday != 0)
            {
                for (int x = placementday; x < 7; x++)
                {
                    month[week, x] = " .";
                }
            }
            Debug.WriteLine(week);
            //Vérification de la semaine de fin si il manque de .
            if (week == 5 && month[week, 5] != " .")
            {
                for (int x = 1; x < 7; x++)
                {
                    month[week, x] = " .";
                }
            }
            //Affichage du mois
            Console.WriteLine("      " + MonthName);
            //Changement de la couleur
            Console.ForegroundColor = ConsoleColor.Green;
            //Affichage des jours de la semaine
            Console.WriteLine("Lu Ma Me Je Ve Sa Di");
            //Retour a la couleur de base
            Console.ForegroundColor = ConsoleColor.Gray;
            stopday = 0;
            //Affichage de chaque semaine
            foreach (string i in month)
            {
                Console.Write(i + " ");
                if (i == " ." && myweek > 1 && stopday == 0)
                {
                    stopday = myday;
                }
                myday++;
                if (myday >= 7)
                {
                    Console.WriteLine();
                    myweek++;
                    myday = 0;
                }
            }
            stopday = placementday;


        }

        #endregion



        #region Partie A

        //Menu pour le choix de la méthode de calcul des nombres Armstrongs
        static void NbArmstrong(bool error)
        {
            //Affichage du menu
            Console.WriteLine("                                     -------------- Nombre Armstrong --------------");
            Console.WriteLine("                                     |                                            |");
            //Affichage de l'erreur
            if (error == true)
            {
                Console.WriteLine("                                     |        /!\\ Une erreur est survenue         |");
                Console.WriteLine("                                     |   Il faut un chiffre entier entre 1 et 3   |");
                Console.WriteLine("                                     |                                            |");
            }
            //Suite de l'affichage du menu
            Console.WriteLine("                                     |   1: Calcul tous les nombres de 1 à 500    |");
            Console.WriteLine("                                     |   2: On utilise les notions (ce.,di.,un.)  |");
            Console.WriteLine("                                     |   3: Revenir en arriére                    |");
            Console.WriteLine("                                     |                                            |");
            Console.WriteLine("                                     |                                            |");
            Console.WriteLine("                                     |          Quels est votre choix ?           |");
            Console.WriteLine("                                     |                                            |");
            Console.WriteLine("                                     ----------------------------------------------");
            //Récupération du choix dans la variable choix
            bool x = Int32.TryParse(Console.ReadLine(), out int choix);
            //Vérification si la valeur de l'utilisateur est valide ou non
            if (x == true && choix >= 1 && choix <= 3)
            {
                //Action en fonction du choix de l'utilisateur
                switch (choix)
                {
                    case 1:
                        Console.Clear();
                        NbArmstrongV1();
                        break;
                    case 2:
                        Console.Clear();
                        NbArmstrongV2();
                        break;
                    case 3:
                        Console.Clear();
                        error = false;
                        MainMenu(error);
                        break;
                    default:
                        error = true;
                        NbArmstrong(error);
                        break;
                }
            }
            //En cas d'erreur dans la valeur de l'utilisateur, Retourne le menu avec une erreur
            else
            { Console.Clear(); error = true; NbArmstrong(error); }
        }
        static void NbArmstrongV1()
        {
            // Affichage du resultat
            Console.WriteLine("                                     -------------- Nombre Armstrong --------------");
            Console.WriteLine("                                     |                                            |");
            Console.WriteLine("                                     |       Vous avez choisit la méthode :       |");
            Console.WriteLine("                                     |     Calcul tous les nombres de 1 à 500     |");
            Console.WriteLine("                                     |                                            |");
            Console.WriteLine("                                     |                                            |");
            Console.WriteLine("                                     |                Résultat:                   |");
            for (int i = 100; i <= 500; i++)
            {
                //Algo afin de verifier si le nombre est armstrong
                int u = i;
                double c = u / 100;
                int centaine = Convert.ToInt32(c);
                u -= (centaine * 100);
                Debug.WriteLine("Centaine: " + centaine);
                double d = u / 10;
                int dizaine = Convert.ToInt32(d);
                u -= (dizaine * 10);
                Debug.WriteLine("Dizaine: " + dizaine);
                int somme = (u * u * u) + (dizaine * dizaine * dizaine) + (centaine * centaine * centaine);
                //affichage si celui si est belle et bien armstrong
                if (somme == i) { Console.WriteLine("                                     |        " + somme + " est un nombre armstrong         |"); }
            }
            Console.WriteLine("                                     |                                            |");
            Console.WriteLine("                                     |                                            |");
            bool error = false;
            EndMenu(error);
        }
        static void NbArmstrongV2()
        {
            //Affichage du résultat
            Console.WriteLine("                                     -------------- Nombre Armstrong --------------");
            Console.WriteLine("                                     |                                            |");
            Console.WriteLine("                                     |       Vous avez choisit la méthode :       |");
            Console.WriteLine("                                     |    On utilise les notions (ce.,di.,un.)    |");
            Console.WriteLine("                                     |                                            |");
            Console.WriteLine("                                     |                                            |");
            Console.WriteLine("                                     |                Résultat:                   |");
            //Algo pour verifier si un nombre est armstrong
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 0; j <= 9; j++)
                {
                    for (int y = 0; y <= 9; y++)
                    {
                        int somme = (y * y * y) + (j * j * j) + (i * i * i);
                        int add = (i * 100) + (j * 10) + (y);
                        //affichage si celui si est belle et bien armstrong
                        if (somme == add) { Console.WriteLine("                                     |        " + somme + " est un nombre armstrong         |"); }
                    }
                }
            }
            //Affichage du reste du resultat
            Console.WriteLine("                                     |                                            |");
            Console.WriteLine("                                     |                                            |");
            bool error = false;
            EndMenu(error);
        }
        static void NbReversible()
        {
            //Définition des variables
            bool error = false;
            int nbReversible = 0, mirroir;
            double nombre, reste, somme;
            //Appelle de la fonction select intervalle pour que l'utilisateur choisisse un intervalle
            SelectInterval(error, out int valeurMin, out int valeurMax);
            //Clear de la console
            Console.Clear();
            Debug.WriteLine(valeurMin);
            Debug.WriteLine(valeurMax);
            //Boucle de calcul
            for (int x = valeurMin; x <= valeurMax; x++)
            {
                mirroir = 0;
                nombre = x;
                Debug.WriteLine("Nombre: " + nombre);
                while (nombre > 0)
                {
                    reste = Math.Floor(nombre % 10);
                    nombre = Math.Floor(nombre / 10);
                    mirroir = mirroir * 10 + (int)reste;
                    Debug.WriteLine("reste: " + reste);
                    Debug.WriteLine("nombre: " + nombre);
                    Debug.WriteLine("mirroir: " + mirroir);
                }
                somme = x + mirroir;
                Debug.WriteLine("Somme: " + somme);
                double d = Math.Floor(somme / 10);
                somme -= (d * 10);
                double u = somme;
                //Vérification si le nombre est réversible
                if (d % 2 != 0 && u % 2 != 0)
                {
                    nbReversible++;
                }
            }

            //Affichage du resultat si pas de nombre reversible
            if (nbReversible == 0)
            {
                Console.WriteLine("                                     -------------- Nombre Réversible -------------");
                Console.WriteLine("                                     |                                            |");
                Console.WriteLine("                                     |                Résultat:                   |");
                Console.WriteLine("                                     |      Il n'y a pas de nombre reversible     |");
                Console.WriteLine("                                     |          dans l'intervale : [{0};{1}]        |", valeurMin, valeurMax);
                Console.WriteLine("                                     |                                            |");
                Console.WriteLine("                                     |                                            |");
                error = false;
                EndMenu(error);
            }
            //affichage du resultat en fonction des nombres reversibles
            else
            {
                Console.WriteLine("                                     -------------- Nombre Réversible -------------");
                Console.WriteLine("                                     |                                            |");
                Console.WriteLine("                                     |                Résultat:                   |");
                Console.WriteLine("                                     |   Il y a un total de {0} nombre reversible   |", nbReversible);
                Console.WriteLine("                                     |          dans l'intervale : [{0};{1}]        |", valeurMin, valeurMax);
                Console.WriteLine("                                     |                                            |");
                Console.WriteLine("                                     |                                            |");
                error = false;
                EndMenu(error);
            }


        }
        static void SommeDiviseur()
        {
            bool x, error = false;
            int chiffre, somme = 0;
            string listeDiviseur = "";
            //Demande la saisie du chiffre
            do
            {
                Console.WriteLine("                                     ------------- Somme des diviseurs ------------");
                Console.WriteLine("                                     |                                            |");
                if (error == true)
                {
                    Console.WriteLine("                                     |        /!\\ Une erreur est survenue         |");
                    Console.WriteLine("                                     | Vous devez entrer un nombre entier positif |");
                    Console.WriteLine("                                     |                                            |");
                }
                Console.WriteLine("                                     |   Saisisez un chiffre (Entier positif):    |");
                Console.WriteLine("                                     |                                            |");
                Console.WriteLine("                                     |                                            |");
                Console.WriteLine("                                     |         Quels est votre chiffre ?          |");
                Console.WriteLine("                                     |                                            |");
                Console.WriteLine("                                     ----------------------------------------------");
                x = Int32.TryParse(Console.ReadLine(), out chiffre);
                error = true;
            } while (x == false && chiffre <= 0);
            Console.Clear();
            Debug.WriteLine(chiffre);

            //Calcul de la somme des diviseurs
            for (int i = 1; i <= chiffre; i++)
            {
                if (chiffre % i == 0)
                {
                    somme += i;
                    listeDiviseur += Convert.ToString(i);
                    Debug.WriteLine(listeDiviseur);
                    if (i != chiffre)
                    {
                        listeDiviseur += ";";
                        Debug.WriteLine(listeDiviseur);
                    }
                }
            }
            //Cacul pour les spaces pour un peu de responsive.
            int listediviseurLength = listeDiviseur.Length;
            decimal length = 43 - listediviseurLength;
            int coté = Convert.ToInt32(Math.Floor(length / 2));
            int space;
            string spacestring = "";
            for (space = 0; space <= coté; space++)
            {
                spacestring += ' ';
            }
            string spacestring2 = "";
            if (listediviseurLength % 2 != 0)
            {
                for (space = 0; space < coté; space++)
                {
                    spacestring2 += ' ';
                }
            } else
            {
                spacestring2 = spacestring;
            }
            //Affichage du résultat
            Console.WriteLine("                                     ------------- Somme des diviseurs ------------");
            Console.WriteLine("                                     |                                            |");
            Console.WriteLine("                                     |                Résultat:                   |");
            Console.WriteLine("                                     |            Liste des diviseurs:            |");
            Console.WriteLine("                                     |{0}{1}{2}|", spacestring, listeDiviseur, spacestring2);
            Console.WriteLine("                                     |            Somme des diviseurs:            |");
            Console.WriteLine("                                     |                    {0}                      |", somme);
            Console.WriteLine("                                     |                                            |");
            Console.WriteLine("                                     |                                            |");
            error = false;
            EndMenu(error);
        }
        static void BonneAnnee()
        {
            // Génération de l'année aléatoire
            Random generateur = new Random();
            int year = generateur.Next(1, 2018);
            //Définition des variables
            int tour = 0, choix;
            bool error = false, y;
            int type = 0;
            string space;
            Debug.WriteLine("Année: " + year);
            //boucle jusqu'as ce que l'utilisateur est la bonne date
            do
            {
                //Boucle pour être sur que l'utilisateur rentre un valeur correcte
                do
                {
                    //Définition des espace necessaire en fonction du nombre de tour
                    if (tour < 10)
                    {
                        space = "  ";
                    }
                    else if (tour >= 10 && tour <= 99)
                    {
                        space = " ";
                    }
                    else
                    {
                        space = "";
                    }
                    //Affichage pour que l'utilisateur choissise un nombre
                    Console.WriteLine("                                     --------------- Année mystéres ---------------");
                    Console.WriteLine("                                     |                                            |");
                    if (error == true)
                    {
                        Console.WriteLine("                                     |        /!\\ Une erreur est survenue         |");
                        Console.WriteLine("                                     | Vous devez entrer un nombre entier positif |");
                        Console.WriteLine("                                     |           Compris entre 1 et 2018          |");
                        Console.WriteLine("                                     |                                            |");
                    }
                    Console.WriteLine("                                     |   Saisisez un chiffre (Entier positif)     |");
                    Console.WriteLine("                                     |           Compris entre 1 et 2018          |");
                    Console.WriteLine("                                     |                                            |");
                    //Affichage du nombre de tour
                    Console.WriteLine("                                     |                Tour numéro:  {0}{1}           |", tour, space);
                    //Affichage en fonction de si le nombre est trop grand ou trop petit
                    if (type == 1)
                    {
                        Console.WriteLine("                                     |          Votre chiffre est trop grand      |");
                    }
                    else if (type == 2)
                    {
                        Console.WriteLine("                                     |          Votre chiffre est trop petit      |");
                    }
                    //Affichage de la question
                    Console.WriteLine("                                     |                                            |");
                    Console.WriteLine("                                     |                                            |");
                    Console.WriteLine("                                     |         Quels est votre chiffre ?          |");
                    Console.WriteLine("                                     |                                            |");
                    Console.WriteLine("                                     ----------------------------------------------");

                    //Récupération du choix dans la variable choix
                    y = Int32.TryParse(Console.ReadLine(), out choix);
                    //Vérification si la valeur de l'utilisateur est valide ou non
                    if (y == false || choix < 1 || choix > 2018)
                    {
                        error = true;
                    }

                    Console.Clear();
                } while (y == true && choix < 1 && choix > 2018);
                //Définition du type afin de savoir le nombre est trop petit ou trop grand pour l'affichage
                if (choix < year)
                {
                    type = 2;
                }
                else if (choix > year)
                {
                    type = 1;
                }
                tour++;
            } while (year != choix);
            //Affichage une fois le nombre trouver !
            Console.WriteLine("                                     --------------- Année mystéres ---------------");
            Console.WriteLine("                                     |                                            |");
            Console.WriteLine("                                     |               Félicitation !               |");
            Console.WriteLine("                                     |   Vous venez de trouver la bonne année !   |");
            Console.WriteLine("                                     |       Vous avez utilisé {0} tours !        {1}|", tour, space);
            Console.WriteLine("                                     |                                            |");
            error = false;
            EndMenu(error);
        }
        static void SommePuissance()
        {
            //Définition des variable
            bool x, error = false;
            int puissance, chiffre, somme = 0;
            //Demande la saisie du chiffre
            do
            {
                Console.WriteLine("                                     ----- Somme des chiffres d'une puissance -----");
                Console.WriteLine("                                     |                                            |");
                if (error == true)
                {
                    Console.WriteLine("                                     |        /!\\ Une erreur est survenue         |");
                    Console.WriteLine("                                     | Vous devez entrer un nombre entier positif |");
                    Console.WriteLine("                                     |                                            |");
                }
                Console.WriteLine("                                     |   Saisisez le chiffre (Entier positif):    |");
                Console.WriteLine("                                     |                                            |");
                Console.WriteLine("                                     |                                            |");
                Console.WriteLine("                                     |         Quels est votre chiffre ?          |");
                Console.WriteLine("                                     |                                            |");
                Console.WriteLine("                                     ----------------------------------------------");
                x = Int32.TryParse(Console.ReadLine(), out chiffre);
                error = true;
            } while (x == false && chiffre <= 0);
            Console.Clear();
            error = false;
            //Demande la saisie de la puissance
            do
            {
                Console.WriteLine("                                     ----- Somme des chiffres d'une puissance -----");
                Console.WriteLine("                                     |                                            |");
                if (error == true)
                {
                    Console.WriteLine("                                     |        /!\\ Une erreur est survenue         |");
                    Console.WriteLine("                                     | Vous devez entrer un nombre entier positif |");
                    Console.WriteLine("                                     |                                            |");
                }
                Console.WriteLine("                                     |  Saisisez la puissance (Entier positif):   |");
                Console.WriteLine("                                     |                                            |");
                Console.WriteLine("                                     |                                            |");
                Console.WriteLine("                                     |        Quels est votre puissance ?         |");
                Console.WriteLine("                                     |                                            |");
                Console.WriteLine("                                     ----------------------------------------------");
                x = Int32.TryParse(Console.ReadLine(), out puissance);
                error = true;
            } while (x == false && puissance <= 0);

            Console.Clear();
            //Calcul de la puissance et et de la somme de ces chiffres
            double power = Math.Pow(chiffre, puissance);
            string powerstring = Convert.ToString(power);
            int power_length = powerstring.Length;
            for (int i = 1; i <= power_length; i++)
            {
                double multiple = Math.Pow(10, (i - 1));
                somme += Convert.ToInt32(Math.Floor(power / multiple) % 10);
            }

            //Affichage du résultat
            Console.WriteLine("                                     ----- Somme des chiffres d'une puissance -----");
            Console.WriteLine("                                     |                                            |");
            Console.WriteLine("                                     |                Résultat:                   |");
            Console.WriteLine("                                     |       Le somme des chiffres de {0}^{1}:       |", chiffre, puissance);
            Console.WriteLine("                                     |              est égale a {0}                |", somme);
            Console.WriteLine("                                     |                                            |");
            Console.WriteLine("                                     |                                            |");
            error = false;
            EndMenu(error);
        }

        #endregion

        #region Partie B
        //Calcul de la date du lendemain
        static void Lendemain()
        {
            //Saisie de la date
            EnterDate(out string date);
            int annee, mois, jour, newjour;
            string newdate = "", olddate;
            bool bis, error;
            //Traitement des donnée de retour de la fonction de saisie de la date
            if (date.Substring(1) == "f") bis = true;
            else bis = false;
            annee = Convert.ToInt32(date.Substring(2, 4));
            mois = Convert.ToInt32(date.Substring(7, 2));
            jour = Convert.ToInt32(date.Substring(10, 2));
            olddate = jour.ToString("00") + "/" + mois.ToString("00") + "/" + annee;
            Debug.WriteLine(annee + "//" + mois.ToString("00") + "//" + jour.ToString("00"));
            newjour = jour + 1;
            //Calcul pour mettre la date du lendemain
            if (newjour >= 32 && mois == 12)
            {
                newdate = "01/01/" + (annee + 1);
            }
            else if (newjour >= 29 && bis == false && mois == 2)
            {
                newdate = "01/" + (mois + 1).ToString("00") + "/" + annee;
            }
            else if (newjour >= 30 && bis == true && mois == 2)
            {
                newdate = "01/" + (mois + 1).ToString("00") + "/" + annee;
            }
            else if (mois == 1 || mois == 3 || mois == 5 || mois == 7 || mois == 8 || mois == 10 || mois == 12)
            {
                if (newjour >= 32) newdate = "01/" + (mois + 1).ToString("00") + "/" + annee;
            }
            else if (mois == 4 || mois == 6 || mois == 9 || mois == 11)
            {
                if (newjour >= 31) newdate = "01/" + (mois + 1).ToString("00") + "/" + annee;
            }
            else
            {
                newdate = newjour.ToString("00") + "/" + mois.ToString("00") + "/" + annee;
            }
            Debug.WriteLine(newdate);
            Console.Clear();
            //Affichage du résultat
            Console.WriteLine("                                     -------------- Date du lendemain -------------");
            Console.WriteLine("                                     |                                            |");
            Console.WriteLine("                                     |         Date que vous avez donnée:         |");
            Console.WriteLine("                                     |                 " + olddate + "                 |");
            Console.WriteLine("                                     |                                            |");
            Console.WriteLine("                                     |            Voici son lendemain:            |");
            Console.WriteLine("                                     |                 " + newdate + "                 |");
            Console.WriteLine("                                     |                                            |");
            error = false;
            EndMenu(error);
        }
        //Nombre de jour entre deux date
        static void NbDayTwoDate()
        {
            //Saisie des deux dates
            Console.WriteLine("\n\n\nMerci de saisir la premiére date avec les étapes qui vont suivre.");
            Thread.Sleep(5000);
            Console.Clear();
            EnterDate(out string date1);
            Console.WriteLine("\n\n\nMerci de saisir la deuxiéme date avec les étapes qui vont suivre.");
            Thread.Sleep(5000);
            Console.Clear();
            EnterDate(out string date2);
            int annee1, mois1, jour1, annee2, mois2, jour2, nbday = 1, jour, mois, annee;
            bool bis;
            //Traitement des valeur de retour
            if (date1.Substring(1) == "f") bis = true;
            else bis = false;
            annee1 = Convert.ToInt32(date1.Substring(2, 4));
            mois1 = Convert.ToInt32(date1.Substring(7, 2));
            jour1 = Convert.ToInt32(date1.Substring(10, 2));
            annee2 = Convert.ToInt32(date2.Substring(2, 4));
            mois2 = Convert.ToInt32(date2.Substring(7, 2));
            jour2 = Convert.ToInt32(date2.Substring(10, 2));
            //Récuperation de la date la plus faible
            if (annee1 < annee2)
            {
                annee = annee1;
                jour = jour1;
                mois = mois1;
                Debug.WriteLine(annee + "/" + mois + "/" + jour);
                Debug.WriteLine(annee2 + "/" + mois2 + "/" + jour2);
            }
            else if (annee1 > annee2)
            {
                annee = annee2;
                jour = jour2;
                mois = mois2;
                annee2 = annee1;
                jour2 = jour1;
                mois2 = mois1;
                Debug.WriteLine(annee + "/" + mois + "/" + jour);
                Debug.WriteLine(annee2 + "/" + mois2 + "/" + jour2);
            }
            else if (mois2 < mois1)
            {
                annee = annee1;
                mois = mois2;
                mois2 = mois1;
                jour = jour2;
                jour2 = jour1;
                Debug.WriteLine(annee + "/" + mois + "/" + jour);
                Debug.WriteLine(annee2 + "/" + mois2 + "/" + jour2);
            }
            else if (mois2 > mois1)
            {
                annee = annee1;
                mois = mois1;
                jour = jour1;
                Debug.WriteLine(annee + "/" + mois + "/" + jour);
                Debug.WriteLine(annee2 + "/" + mois2 + "/" + jour2);
            }
            else if (jour1 < jour2)
            {
                annee = annee1;
                mois = mois1;
                jour = jour1;
                Debug.WriteLine(annee + "/" + mois + "/" + jour);
                Debug.WriteLine(annee2 + "/" + mois2 + "/" + jour2);
            }
            else
            {
                annee = annee1;
                mois = mois1;
                jour = jour2;
                jour2 = jour1;
                Debug.WriteLine(annee + "/" + mois + "/" + jour);
                Debug.WriteLine(annee2 + "/" + mois2 + "/" + jour2);
            }

            //Boucle afin de compté le nombre de jour netre les deux date
            do
            {
                Debug.WriteLine(nbday);
                nbday++;

                if (mois == 12 && jour > 31)
                {
                    annee++;
                    jour = 1;
                    mois = 1;
                    LeapYear(annee, out bis);

                    Debug.WriteLine(nbday);
                    Debug.WriteLine(annee + "/" + mois + "/" + jour);
                    Debug.WriteLine(annee2 + "/" + mois2 + "/" + jour2);
                }
                else if (bis == true && mois == 2 && jour > 29)
                {
                    jour = 1;
                    mois++;

                    Debug.WriteLine(nbday);
                    Debug.WriteLine(annee + "/" + mois + "/" + jour);
                    Debug.WriteLine(annee2 + "/" + mois2 + "/" + jour2);
                }
                else if (bis == false && mois == 2 && jour > 28)
                {
                    jour = 1;
                    mois++;

                    Debug.WriteLine(nbday);
                    Debug.WriteLine(annee + "/" + mois + "/" + jour);
                    Debug.WriteLine(annee2 + "/" + mois2 + "/" + jour2);
                }
                else if (mois == 1 || mois == 3 || mois == 5 || mois == 7 || mois == 8 || mois == 10)
                {
                    if (jour > 31)
                    {
                        jour = 1;
                        mois++;

                        Debug.WriteLine(nbday);
                        Debug.WriteLine(annee + "/" + mois + "/" + jour);
                        Debug.WriteLine(annee2 + "/" + mois2 + "/" + jour2);
                    }
                }
                else if (mois == 4 || mois == 6 || mois == 9 || mois == 11)
                {
                    if (jour > 30)
                    {
                        jour = 1;
                        mois++;

                        Debug.WriteLine(nbday);
                        Debug.WriteLine(annee + "/" + mois + "/" + jour);
                        Debug.WriteLine(annee2 + "/" + mois2 + "/" + jour2);
                    }
                }
                jour++;
            } while (annee < annee2 || jour < jour2 || mois < mois2);



            //Cacul pour les spaces pour un peu de responsive.
            decimal length = 43 - Convert.ToString(nbday).Length;
            int coté = Convert.ToInt32(Math.Floor(length / 2));
            int space;
            string spacestring = "";
            for (space = 0; space <= coté; space++)
            {
                spacestring += ' ';
            }
            string spacestring2 = "";
            if (Convert.ToString(nbday).Length % 2 != 0)
            {
                for (space = 0; space < coté; space++)
                {
                    spacestring2 += ' ';
                }
            }
            else
            {
                spacestring2 = spacestring;
            }
            //Affichage du résultat
            Console.WriteLine("                                     ------- Nombre de jour entre deux date -------");
            Console.WriteLine("                                     |                                            |");
            Console.WriteLine("                                     |                 Résultat:                  |");
            Console.WriteLine("                                     |              Nombre de jour:               |");
            Console.WriteLine("                                     |{0}{1}{2}|", spacestring, nbday, spacestring2);
            Console.WriteLine("                                     |                                            |");
            Console.WriteLine("                                     |               Date de départ:              |");
            Console.WriteLine("                                     |                 {0}                 |", jour1.ToString("00") + "/" + mois1.ToString("00") + "/" + annee1);
            Console.WriteLine("                                     |              Date de d'arrivé:             |");
            Console.WriteLine("                                     |                 {0}                 |", jour2.ToString("00") + "/" + mois2.ToString("00") + "/" + annee2);
            Console.WriteLine("                                     |                                            |");
            Console.WriteLine("                                     |                                            |");
            EndMenu(false);
            Debug.WriteLine(nbday);
        }
        //Verifier si une année est bissextile
        static void Bissextile()
        {

            int annee;
            bool x, error = false;
            //Saisie de l'année
            do
            {
                Console.WriteLine("                                     --------------- Année bissextile -------------");
                Console.WriteLine("                                     |                                            |");
                //Affichage de l'erreur
                if (error == true)
                {
                    Console.WriteLine("                                     |        /!\\ Une erreur est survenue         |");
                    Console.WriteLine("                                     |     L'année doit être un nombre entier     |");
                    Console.WriteLine("                                     |                                            |");
                }
                //Affichage du reste du menu une fois l'erreur passé
                Console.WriteLine("                                     |   Saisir une année entre (1000 et 9999):   |");
                Console.WriteLine("                                     |                                            |");
                Console.WriteLine("                                     |          Quels est votre année ?           |");
                Console.WriteLine("                                     |                                            |");
                Console.WriteLine("                                     ----------------------------------------------");
                x = Int32.TryParse(Console.ReadLine(), out annee);
                error = true;
                Console.Clear();
            } while (x != true || annee <= 999 || annee > 9999 || annee % 1 != 0);
            //Verification si l'année est bis.
            LeapYear(annee, out bool bis);
            //Affichage du résultat
            Console.WriteLine("                                     ------- Nombre de jour entre deux date -------");
            Console.WriteLine("                                     |                                            |");
            Console.WriteLine("                                     |                 Résultat:                  |");
            if (bis == true) Console.WriteLine("                                     |         L'année {0} est bissextile        |", annee);
            if (bis == false) Console.WriteLine("                                     |      L'année {0} n'est pas bissextile     |", annee);
            Console.WriteLine("                                     |                                            |");
            Console.WriteLine("                                     |                                            |");
            error = false;
            EndMenu(error);

        }
        //Calcule de la date de pacque
        static void Pacque(int methode)
        {
            int jour = 0, annee;
            bool error = false, x, mois = false;
            double a;
            do
            {
                Console.WriteLine("                                     --------------- Année de pacques -------------");
                Console.WriteLine("                                     |                                            |");
                //Affichage de l'erreur
                if (error == true)
                {
                    Console.WriteLine("                                     |        /!\\ Une erreur est survenue         |");
                    Console.WriteLine("                                     |     L'année doit être un nombre entier     |");
                    Console.WriteLine("                                     |                                            |");
                }
                //Affichage du reste du menu une fois l'erreur passé
                Console.WriteLine("                                     |   Saisir une année entre (1583 et 9999):   |");
                Console.WriteLine("                                     |                                            |");
                Console.WriteLine("                                     |          Quels est votre année ?           |");
                Console.WriteLine("                                     |                                            |");
                Console.WriteLine("                                     ----------------------------------------------");
                x = Int32.TryParse(Console.ReadLine(), out annee);
                error = true;
                Console.Clear();
            } while (x != true || annee <= 1583 || annee > 9999 || annee % 1 != 0);
            string stringannee = Convert.ToString(annee);
            a = double.Parse(stringannee);

            if (methode == 1)
            {
                //ALGO GAUSS
                double z, b, c, k, p, q, M, N, d, e, H, L;
                z = Math.Floor(a % 19);
                b = Math.Floor(a % 4);
                c = Math.Floor(a % 7);
                k = Math.Floor(a / 100);
                p = Math.Floor(((8 * k) + 13) / 25);
                q = k / 4;
                M = Math.Floor((15 - p - q + k) % 30);
                N = Math.Floor((4 + k - q) % 7);
                d = Math.Floor(((19 * z) + M) % 30);
                e = Math.Floor(((2 * b) + (4 * c) + (6 * d) + N) % 7);
                H = Math.Floor(22 + d + e);
                L = Math.Floor(d + e - 9);
                Debug.WriteLine(z + "/" + b + "/" + c + "/" + k + "/" + p + "/" + q + "/" + M + "/" + N + "/" + d + "/" + e + "/" + H + "/" + L);
                if (H > 31)
                {
                    mois = false;
                    jour = Convert.ToInt32(L);
                }
                else
                {
                    mois = true;
                    jour = Convert.ToInt32(H);
                }
                Debug.WriteLine("GAUSS");
            }
            else if (methode == 2)
            {
                //ALGO MEEUS
                double n, c, u, s, t, p, q, e, b, d, L, h, m, j;
                n = Math.Floor(a % 19);
                c = Math.Floor(a / 100);
                u = Math.Floor(a % 100);
                s = Math.Floor(c / 4);
                t = Math.Floor(c % 4);
                p = Math.Floor((c + 8) / 25);
                q = Math.Floor((c - p + 1) / 3);
                e = Math.Floor(((19 * n) + c - s - q + 15) % 30);
                b = Math.Floor(u / 4);
                d = Math.Floor(u % 4);
                L = Math.Floor(((2 * t) + (2 * b) - e - d + 32) % 7);
                h = Math.Floor((n + (11 * e) + (22 * L)) / 451);
                m = Math.Floor((e + L - (7 * h) + 114) / 31);
                j = Math.Floor((e + L - (7 * h) + 114) % 31);
                if (m == 4)
                {
                    mois = false;
                    jour = Convert.ToInt32(j + 1);
                }
                else
                {
                    mois = true;
                    jour = Convert.ToInt32(j + 1);
                }
                Debug.WriteLine("MEUSS");
            }
            else if (methode == 3)
            {
                //ALGO CONWAY
                double s, t, z, p, jps, jp, g, G, b, r, C, d, h, e, f, R;
                s = Math.Floor(a / 100);
                t = Math.Floor(a % 100);
                z = Math.Floor(t / 4);
                p = Math.Floor(s % 4);
                jps = Math.Floor((9 - (2 * p)) % 7);
                jp = Math.Floor((jps + z + t) % 7);
                g = Math.Floor(a % 19);
                G = Math.Floor(g + 1);
                b = Math.Floor(s / 4);
                r = Math.Floor((8 * (s + 11)) / 25);
                C = Math.Floor(b + r - s);
                d = Math.Floor(((11 * G) + C) % 30);
                d = Math.Floor((d + 30) % 30);
                h = Math.Floor((551 - (19 * d) + G) / 544);
                e = Math.Floor((50 - d - h) % 7);
                f = Math.Floor((e + jp) % 7);
                R = Math.Floor(57 - d - f - h);
                if (R > 31)
                {
                    mois = false;
                    jour = Convert.ToInt32(R - 31);
                }
                else
                {
                    mois = true;
                    jour = Convert.ToInt32(R);
                }
                Debug.WriteLine("CONWAY");
            }
            else Debug.WriteLine("Une erreur est survenue dans l'execution du module de pacque !");

            //Affichage du résultat
            Console.WriteLine("                                     --------------- Date de Pacques --------------");
            Console.WriteLine("                                     |                                            |");
            Console.WriteLine("                                     |                 Résultat:                  |");
            Console.WriteLine("                                     |            Pacques auras lieux:            |");
            if (mois == false) Console.WriteLine("                                     |                Le {0} avril {1}            |", jour, annee);
            else Console.WriteLine("                                     |                Le {0} mars {1}              |", jour, annee);
            Console.WriteLine("                                     |                                            |");
            Console.WriteLine("                                     |                                            |");
            error = false;
            EndMenu(error);


        }
        //Calendrier d'une année
        static void Calendar()
        {
            int annee, day, stopday;
            string[] listmonth = { "JANVIER", "FEVRIER", "MARS", "AVRIL", "MAI", "JUIN", "JUILLET", "AOUT", "SEPTEMBRE", "OCTOBRE", "NOVEMBRE", "DECEMBRE" };
            bool error = false, x;
            //Saisie de l'année du calendrier
            do
            {
                Console.WriteLine("                                     ------------- Année du calendrier ------------");
                Console.WriteLine("                                     |                                            |");
                //Affichage de l'erreur
                if (error == true)
                {
                    Console.WriteLine("                                     |        /!\\ Une erreur est survenue         |");
                    Console.WriteLine("                                     |     L'année doit être un nombre entier     |");
                    Console.WriteLine("                                     |                                            |");
                }
                //Affichage du reste du menu une fois l'erreur passé
                Console.WriteLine("                                     |   Saisir une année entre (1000 et 9999):   |");
                Console.WriteLine("                                     |                                            |");
                Console.WriteLine("                                     |          Quels est votre année ?           |");
                Console.WriteLine("                                     |                                            |");
                Console.WriteLine("                                     ----------------------------------------------");
                x = Int32.TryParse(Console.ReadLine(), out annee);
                error = true;
                Console.Clear();
            } while (x != true || annee <= 999 || annee > 9999 || annee % 1 != 0);
            LeapYear(annee, out bool bis);
            //Saisie du jour de départ du calendrier
            do
            {
                Console.WriteLine("                                     -------------- Jour du Calendrier ------------");
                Console.WriteLine("                                     |                                            |");
                //Affichage de l'erreur
                if (error == true)
                {
                    Console.WriteLine("                                     |        /!\\ Une erreur est survenue         |");
                    Console.WriteLine("                                     |     Le jour doit être un nombre entier     |");
                    Console.WriteLine("                                     |                                            |");
                }
                Console.WriteLine("                                     |            1: Lundi                        |");
                Console.WriteLine("                                     |            2: Mardi                        |");
                Console.WriteLine("                                     |            3: Mercredi                     |");
                Console.WriteLine("                                     |            4: Jeudi                        |");
                Console.WriteLine("                                     |            5: Vendredi                     |");
                Console.WriteLine("                                     |            6: Samedi                       |");
                Console.WriteLine("                                     |            7: Dimanche                     |");
                Console.WriteLine("                                     |                                            |");
                Console.WriteLine("                                     |         Quels est votre jour de départ ?   |");
                Console.WriteLine("                                     |                                            |");
                Console.WriteLine("                                     ----------------------------------------------");
                x = Int32.TryParse(Console.ReadLine(), out day);
                error = true;
                Console.Clear();
            } while (x != true || day <= 0 || day > 7 || day % 1 != 0);
            stopday = day - 1;
            //Boucle pour l'affichage de chaque mois
            for (int i = 1; i <= 12; i++)
            {
                if (i == 1 || i == 3 || i == 5 || i == 7 || i == 8 || i == 10 || i == 12)
                {
                    DisplayMonth(stopday, 31, listmonth[i - 1], out stopday);

                }
                else if (i == 4 || i == 6 || i == 11 || i == 9)
                {
                    DisplayMonth(stopday, 30, listmonth[i - 1], out stopday);

                }
                else
                if (i == 2 && bis == true)
                {
                    DisplayMonth(stopday, 29, listmonth[i - 1], out stopday);

                }
                else
                {
                    DisplayMonth(stopday, 28, listmonth[i - 1], out stopday);

                }
            }

            EndMenu(false);
        }
        //Calcul de la date du jour
        static void DateOfWeek()
        {
            //Entrez de la date
            EnterDate(out string date);
            int x, y, m, d;
            string day, result;
            string[] listmonth = { "janvier", "février", "mars", "avril", "mai", "juin", "juillet", "août", "septembre", "octobre", "novembre", "décembre" };
            y = Convert.ToInt32(date.Substring(2, 4));
            m = Convert.ToInt32(date.Substring(7, 2));
            d = Convert.ToInt32(date.Substring(10, 2));
            if (m < 3)
            {
                x = ((((23 * m) / 9) + d + 4 + y + ((y - 1) / 4) - ((y - 1) / 100) + ((y - 1) / 400)) % 7);
            }
            else
            {
                x = ((((23 * m) / 9) + d + 2 + y + (y / 4) - (y / 100) + (y / 400)) % 7);
            }
            switch (x)
            {
                case 1:
                    day = "Lundi";
                    break;
                case 2:
                    day = "Mardi";
                    break;
                case 3:
                    day = "Mercredi";
                    break;
                case 4:
                    day = "Jeudi";
                    break;
                case 5:
                    day = "Vendredi";
                    break;
                case 6:
                    day = "Samedi";
                    break;
                case 7:
                    day = "Dimanche";
                    break;
                default:
                    day = "Error";
                    break;
            }
            result = day + " " + d + " " + listmonth[m - 1] + " " + y;
            Debug.WriteLine(result);

            decimal length = 44 - result.Length;
            int coté = Convert.ToInt32(Math.Floor(length / 2));
            int space;
            string spacestring = "";
            for (space = 0; space <= coté; space++)
            {
                spacestring += ' ';
            }
            string spacestring2 = "";
            if (result.Length % 2 != 0)
            {
                for (space = 0; space < coté; space++)
                {
                    spacestring2 += ' ';
                }
            }
            else
            {
                spacestring2 = spacestring;
            }


            //Affichage du résultat
            Console.WriteLine("                                     ------------- Jour de la semaine -------------");
            Console.WriteLine("                                     |                                            |");
            Console.WriteLine("                                     |                 Résultat:                  |");
            Console.WriteLine("                                     |     Voici la date que vous avez saisie:    |");
            Console.WriteLine("                                     |{0}{1}{2}|", spacestring, result, spacestring2);
            Console.WriteLine("                                     |                                            |");
            Console.WriteLine("                                     |                                            |");
            EndMenu(false);


        }
        #endregion

        #region Partie C

        static void ProjectMenu()
        {
            bool[] config = { false,false,false,false };
            Console.Clear();
            Console.WriteLine("                                     **********************************************");
            Console.WriteLine("                                     ************     Bienvenue sur     ***********");
            Console.WriteLine("                                     ********* Générateur de mots de passe ********");
            Console.WriteLine("                                     ********  Par Romain Pathé pour ESILV  *******");
            Console.WriteLine("                                     **********************************************");
            Thread.Sleep(5000);
            Console.Clear();
            Project_NbCaract(config, out config, out int NbCaract);
            Console.Clear();
            Project_TypeCaract(1, NbCaract, config, out config);
            Console.Clear();
            Project_TypeCaract(2, NbCaract, config, out config);
            Console.Clear();
            Project_TypeCaract(3, NbCaract, config, out config);
            Console.Clear();
            Project_TypeCaract(4, NbCaract, config, out config);
            Debug.WriteLine(config);
            //Génération du mots de passe
            Random generateur = new Random();
            int a;
            string mdp = "";
            if(config[0] == false && config[1] == false && config[2] == false && config[3] == false)
            {
                config[0] = true;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\n\n\nVotre mots de passe seras composé uniquement de chiffre car vous n'avez séléctionné aucun type !");
                Thread.Sleep(5000);
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            Console.Clear();
            //Génération du mots de passe
            for (int i = 1; i <= NbCaract; i++)
            {
                
                a = generateur.Next(0, 3);
                Debug.WriteLine(i + "///" + config[a]+"///"+ NbCaract);
                if(config[a] == true)
                {
                    if(a == 0)
                    {
                        mdp += generateur.Next(0, 9);
                    }else if(a == 1)
                    {
                        string[] lettre = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
                        mdp += lettre[generateur.Next(0, lettre.Length)];
                    }
                    else if (a == 2)
                    {
                        string[] symbole = { "+", "-", "*", "/", ".", "!", ":", ";", "?", ",", "%", "=", ">", "<" };
                        mdp += symbole[generateur.Next(0, symbole.Length)];
                    }
                    else if (a == 3)
                    {
                        string[] caamb = { "&", "'", "{", "}", "[", "]", "ç", "^", "@", "|", "~", "#" };
                        mdp += caamb[generateur.Next(0, caamb.Length)];
                    }
                }
                else
                {
                    i--;
                }
                Debug.WriteLine(mdp);
            }
            Project_Config(NbCaract, config);
            //Gestion des espaces a de gauche et droite
            decimal length = 40 - mdp.Length;
            int coté = Convert.ToInt32(Math.Floor(length / 2));
            int space;
            string spacestring = "";
            for (space = 0; space <= coté; space++)
            {
                spacestring += ' ';
            }
            string spacestring2 = "";
            if (mdp.Length % 2 != 0)
            {
                for (space = 0; space < coté; space++)
                {
                    spacestring2 += ' ';
                }
            }
            else
            {
                spacestring2 = spacestring;
            }
            Debug.WriteLine(mdp);
            //Affichage du résultat
            Console.WriteLine("                                     ------------------- Resultat -----------------");
            Console.WriteLine("                                     |                                            |");
            Console.WriteLine("                                     |         Voici votre mots de passe:         |");
            Console.WriteLine("                                     | {0}{1}{2} |", spacestring, mdp, spacestring2); ;
            Console.WriteLine("                                     |                                            |");
            Console.WriteLine("                                     |                                            |");
            EndMenu(false);
        }

        static void Project_Config(int NbCaract, bool[] inconfig)
        {
            string SNbCaract, Chiffre = "*  ", Lettre = "*  ", Symbole = "*  ", CaractAmbi = "*  ";
            //Traitement pour le nombre de caractere
            if (NbCaract == 0)
            {
                SNbCaract = "*  ";
            }
            else
            {
                if (Convert.ToInt32(NbCaract) < 10)
                {
                    SNbCaract = NbCaract + "  ";
                }
                else if (Convert.ToInt32(NbCaract) < 100)
                {
                    SNbCaract = NbCaract + " ";
                }
                else
                {
                    SNbCaract = NbCaract + "";
                }
            }
            if(NbCaract != 0)
            {
                if (!inconfig[0])
                {
                    Chiffre = "NON";
                }
                else
                {
                    Chiffre = "OUI";
                }
                if (!inconfig[1])
                {
                    Lettre = "NON";
                }
                else
                {
                    Lettre = "OUI";
                }
                if (!inconfig[2])
                {
                    Symbole = "NON";
                }
                else
                {
                    Symbole = "OUI";
                }
                if (!inconfig[3])
                {
                    CaractAmbi = "NON";
                }
                else
                {
                    CaractAmbi = "OUI";
                }
            }
            //Affichage du menu
            Console.WriteLine("                                     ---------------- Configuration ---------------");
            Console.WriteLine("                                     |                                            |");
            //Suite de l'affichage du menu
            Console.WriteLine("                                     |         - Nombre de caractéres: {0}        |", SNbCaract);
            Console.WriteLine("                                     |         - Chiffre: {0}                     |", Chiffre);
            Console.WriteLine("                                     |         - Lettre: {0}                      |", Lettre);
            Console.WriteLine("                                     |         - Symbole: {0}                     |", Symbole);
            Console.WriteLine("                                     |         - Caract ambigue: {0}              |", CaractAmbi);
            Console.WriteLine("                                     |                                            |");
            Console.WriteLine("                                     |                                            |");
            Console.WriteLine("                                     |          Quels est votre choix ?           |");
            Console.WriteLine("                                     |                                            |");

        }

        static void Project_NbCaract(bool[] inconfig, out bool[] outconfig, out int NbCaract)
        {
            
            bool error = false,x;
            int nb;
            //Boucle pour être sur que c'est une nombre entier
            do
            {
                Project_Config(0, inconfig);
                //Affichage du menu
                Console.WriteLine("                                     ------------ Création Configuration ----------");
                Console.WriteLine("                                     |                                            |");
                Console.WriteLine("                                     | Nombre de caractéres dans le mots de passe |");
                Console.WriteLine("                                     |                                            |");
                //Affichage de l'erreur
                if (error == true)
                {
                    Console.WriteLine("                                     |        /!\\ Une erreur est survenue         |");
                    Console.WriteLine("                                     |   Le nombre de caractére doit être entier  |");
                    Console.WriteLine("                                     |                                            |");
                }
                Console.WriteLine("                                     |       Saisir un nombre entre 6 et 42:      |");
                Console.WriteLine("                                     |                                            |");
                Console.WriteLine("                                     |                                            |");
                Console.WriteLine("                                     |   Quels est votre nombre de caractére ?    |");
                Console.WriteLine("                                     |                                            |");
                Console.WriteLine("                                     ----------------------------------------------");
                x = Int32.TryParse(Console.ReadLine(), out nb);
                error = true;
                Console.Clear();
            } while (x != true || nb <= 5 || nb > 42 || nb % 1 != 0);
            outconfig = inconfig;
            NbCaract = nb;
            Debug.WriteLine(nb);
        }

        static void Project_TypeCaract(int type,int NbCaract,bool[] inconfig, out bool[] outconfig)
        {
            bool error = false, x;
            int choix;
            outconfig = inconfig;
            if (type == 1)
            {
                //Boucle pour être sur qu'il reponde oui ou non
                do
                {
                    //Affichage du menu de configuration
                    Project_Config(NbCaract, inconfig);
                    //Affichage du menu
                    Console.WriteLine("                                     ------------ Création Configuration ----------");
                    Console.WriteLine("                                     |                                            |");
                    Console.WriteLine("                                     |        Chiffre dans le mots de passe       |");
                    Console.WriteLine("                                     |                                            |");
                    //Affichage de l'erreur
                    if (error == true)
                    {
                        Console.WriteLine("                                     |        /!\\ Une erreur est survenue         |");
                        Console.WriteLine("                                     |       Vous devez répondre par 1 ou 2       |");
                        Console.WriteLine("                                     |                                            |");
                    }
                    Console.WriteLine("                                     |                                            |");
                    Console.WriteLine("                                     |    Voulez vous des chiffres dans votre     |");
                    Console.WriteLine("                                     |              mots de passe ?               |");
                    Console.WriteLine("                                     |                   1: OUI                   |");
                    Console.WriteLine("                                     |                   2: NON                   |");
                    Console.WriteLine("                                     |                                            |");
                    Console.WriteLine("                                     ----------------------------------------------");
                    x = Int32.TryParse(Console.ReadLine(), out choix);
                    error = true;
                    Console.Clear();
                } while (x != true || choix < 1 || choix > 2);
                if (choix == 1) outconfig[0] = true;
            }
            else if (type == 2)
            {
                //Boucle pour être sur qu'il reponde oui ou non
                do
                {
                    //Affichage du menu de configuration
                    Project_Config(NbCaract, inconfig);
                    //Affichage du menu
                    Console.WriteLine("                                     ------------ Création Configuration ----------");
                    Console.WriteLine("                                     |                                            |");
                    Console.WriteLine("                                     |        Lettre dans le mots de passe        |");
                    Console.WriteLine("                                     |                                            |");
                    //Affichage de l'erreur
                    if (error == true)
                    {
                        Console.WriteLine("                                     |        /!\\ Une erreur est survenue         |");
                        Console.WriteLine("                                     |       Vous devez répondre par 1 ou 2       |");
                        Console.WriteLine("                                     |                                            |");
                    }
                    Console.WriteLine("                                     |                                            |");
                    Console.WriteLine("                                     |     Voulez vous des lettres dans votre     |");
                    Console.WriteLine("                                     |              mots de passe ?               |");
                    Console.WriteLine("                                     |                   1: OUI                   |");
                    Console.WriteLine("                                     |                   2: NON                   |");
                    Console.WriteLine("                                     |                                            |");
                    Console.WriteLine("                                     ----------------------------------------------");
                    x = Int32.TryParse(Console.ReadLine(), out choix);
                    error = true;
                    Console.Clear();
                } while (x != true || choix < 1 || choix > 2);
                if (choix == 1) outconfig[1] = true;
            }
            else if (type == 3)
            {
                //Boucle pour être sur qu'il reponde oui ou non
                do
                {
                    //Affichage du menu de configuration
                    Project_Config(NbCaract, inconfig);
                    //Affichage du menu
                    Console.WriteLine("                                     ------------ Création Configuration ----------");
                    Console.WriteLine("                                     |                                            |");
                    Console.WriteLine("                                     |        Symbole dans le mots de passe       |");
                    Console.WriteLine("                                     |                                            |");
                    //Affichage de l'erreur
                    if (error == true)
                    {
                        Console.WriteLine("                                     |        /!\\ Une erreur est survenue         |");
                        Console.WriteLine("                                     |       Vous devez répondre par 1 ou 2       |");
                        Console.WriteLine("                                     |                                            |");
                    }
                    Console.WriteLine("                                     |                                            |");
                    Console.WriteLine("                                     |    Voulez vous des symboles dans votre     |");
                    Console.WriteLine("                                     |              mots de passe ?               |");
                    Console.WriteLine("                                     |                   1: OUI                   |");
                    Console.WriteLine("                                     |                   2: NON                   |");
                    Console.WriteLine("                                     |                                            |");
                    Console.WriteLine("                                     ----------------------------------------------");
                    x = Int32.TryParse(Console.ReadLine(), out choix);
                    error = true;
                    Console.Clear();
                } while (x != true || choix < 1 || choix > 2);
                if (choix == 1) outconfig[2] = true;
            }
            else if (type == 4)
            {
                //Boucle pour être sur qu'il reponde oui ou non
                do
                {
                    //Affichage du menu de configuration
                    Project_Config(NbCaract, inconfig);
                    //Affichage du menu
                    Console.WriteLine("                                     ------------ Création Configuration ----------");
                    Console.WriteLine("                                     |                                            |");
                    Console.WriteLine("                                     |  Caractéres ambigue dans le mots de passe  |");
                    Console.WriteLine("                                     |                                            |");
                    //Affichage de l'erreur
                    if (error == true)
                    {
                        Console.WriteLine("                                     |        /!\\ Une erreur est survenue         |");
                        Console.WriteLine("                                     |       Vous devez répondre par 1 ou 2       |");
                        Console.WriteLine("                                     |                                            |");
                    }
                    Console.WriteLine("                                     |                                            |");
                    Console.WriteLine("                                     |  Voulez vous des caractéres ambigue dans   |");
                    Console.WriteLine("                                     |           votre mots de passe ?            |");
                    Console.WriteLine("                                     |                  1: OUI                    |");
                    Console.WriteLine("                                     |                  2: NON                    |");
                    Console.WriteLine("                                     |                                            |");
                    Console.WriteLine("                                     ----------------------------------------------");
                    x = Int32.TryParse(Console.ReadLine(), out choix);
                    error = true;
                    Console.Clear();
                } while (x != true || choix < 1 || choix > 2);
                if (choix == 1) outconfig[3] = true;
            }
            
            Debug.WriteLine(outconfig);
        }


        #endregion


        static void Main()
        {
            Debug.WriteLine("Programme démarré !");
            Console.WriteLine("                                     **********************************************");
            Console.WriteLine("                                     ***************  Bienvenue sur  **************");
            Console.WriteLine("                                     ***********  Application 2020-2021  **********");
            Console.WriteLine("                                     ********  Par Romain Pathé pour ESILV  *******");
            Console.WriteLine("                                     **********************************************");
            Console.WriteLine("\n\n\n\n\n\n");
            bool error = false;
            MainMenu(error);
            Console.ReadKey();
        }
    }
}
