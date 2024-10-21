#Librairies utilisée
import random
import sys
import pygame

# Initialisation de Pygame
#pygame.init()

# Dimensions de la fenêtre
largeur, hauteur = 800, 600
# ecran = pygame.display.set_mode((largeur, hauteur))
#pygame.display.set_caption("Pierre, Feuille, Ciseau")

# Couleurs
blanc = (255, 255, 255)
noir = (0, 0, 0)

def jeu():

    CHOIX=["pierre","feuille","ciseau"]
    MANCHE = 3
    vitoireJoueur=0
    vitoireAdversaire=0


    for i in range(1,MANCHE+1):

        CHOIX_JOUEUR=input("Choisissez pierre, feuille ou ciseau: ").lower()
        CHOIX_ADVESAIRE = random.choice(CHOIX)
         
        if(CHOIX_JOUEUR==CHOIX_ADVESAIRE):
            print("L'ordinateur a choisi: "+CHOIX_ADVESAIRE)
            print("Egalite")
        
        else:

            if  (CHOIX_JOUEUR == "pierre" and CHOIX_ADVESAIRE == "ciseau") or \
            (CHOIX_JOUEUR == "feuille" and CHOIX_ADVESAIRE == "pierre") or \
            (CHOIX_JOUEUR == "ciseau" and CHOIX_ADVESAIRE == "feuille"):
                print("L'ordinateur a choisi: "+CHOIX_ADVESAIRE)
                print("Vous avez gagné cette manche")
                vitoireJoueur = vitoireJoueur + 1

            else:
                print("L'ordinateur a choisi: "+CHOIX_ADVESAIRE)
                print("Vous avez perdu cette manche ")
                vitoireAdversaire = vitoireAdversaire + 1
                 
    if(vitoireAdversaire == vitoireJoueur):
        print("Aucun joueur n'a gagner")
    else:
        if(vitoireJoueur > vitoireAdversaire):
            print ("Vous avez gagne cette partie")
        else:
            print ("Votre advesaire a gagne cette partie")
              

jeu()