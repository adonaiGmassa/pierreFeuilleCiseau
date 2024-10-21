#Librairies utilisée
import random
import sys
import pygame

# Initialisation de Pygame
pygame.init()

# Dimensions de la fenêtre
largeur, hauteur = 800, 600
ecran = pygame.display.set_mode((largeur, hauteur))
pygame.display.set_caption("Pierre, Feuille, Ciseau")

# Couleurs
blanc = (255, 255, 255)
noir = (0, 0, 0)
