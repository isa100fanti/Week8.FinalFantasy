﻿using FinalFantasy.Core.Entities;
using FinalFantasy.Core.Repository;
using FinalFantasy.RepositoryM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy
{
    public class Gaming
    {
        //qua andrò a richiamare vari metodi
        private static IRepositoryGiocatore repoGioc = new RepositoryGiocatoreM();
        //MENU INIZIALE DI GESTIONE DELL'UTENTE
        public static Giocatore MenuIniziale()
        {
            Giocatore g1 = new Giocatore();

            Console.WriteLine("1. Login");
            Console.WriteLine("2. Registrati");
            Console.WriteLine("3. Esci");
            int scelta = Int32.Parse(Console.ReadLine());
            switch(scelta)
            {
                case 1:
                    Console.WriteLine("Inserisci nick");
                    string nick = Console.ReadLine();
                    
                    repoGioc.Login(nick);
                    MenuGiocatore(g1);
                    break;
                case 2:
                    repoGioc.Registrazione();
                    MenuGiocatore(g1);
                    break;
                case 3:
                    Console.WriteLine("Alla prossima partita!");
                    return null;
                    break;
            }
            
            return g1;

            //login registraz e esci
        }

        //MENU PRINCIPALE DI INIZIO PARTITA
        public static bool MenuGiocatore(Giocatore giocatore)
        {
            //ALL'INTERNO DI QUESTO MENU VADO A GESTIRE LE OPERAZIONI
            //INIZIALE DI CREAZIONE PARTITA

            //un utente può avere + eroi
            //sulla base della scelta gli mostri le armi corrispondenti(gia presenti nel mock o db)


            //GIOCA
            //CREAZIONE EROE e scelta arma
            //SCELTA EROE
            //ELIMINARE EROE
            return true;
        }

        public static void Partita(Eroe eroeScelto)
        {
            //METODO ALL'INTERNO DEL QUALE VADO A GESTIRE 
            //LA LOGICA RELATIVA AD UNA PARTITA
        }

        public static void Battaglia(Eroe eroeScelto, Mostro mostroSorteggiato)
        {
            //ALL'INTERNO DI QUESTO METODO VENGONO GESTITE LE CASISTICHE DI 
            //VITTORIA-PERDITA DELL'EROE
            //LA BATTAGLIA SI RIPETE FINCHE' L'EROE NON UCCIDE IL MOSTRO O VICEVERSA
        }

        public static bool SceltaTurno(Eroe eroe, Mostro mostro)
        {
            //METODO CHE CHIEDE ALL'UTENTE QUALE MOSSA ESEGUIRE
            //LOTTA O FUGA
            return true;
        }
    }
}
