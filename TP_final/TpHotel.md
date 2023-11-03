## TP WPF MVVM

On désire informatiser la gestion des réservations et des séjours pour un l’hôtel avec WPF :

Réaliser une application de gestion des réservations

1) Gestion des Clients 
a.    Affichage de la liste des clients, et détail de chaque client (Réservations, annulations).
b.    Ajout d’un nouveau client 
c.    Suppression de clients. Si je supprime le client => Sa réservation sera supprimée.

2) Gestion des chambres
a.    Création d'une chambre (avec les informations nécéssaires)
b.    On peut supprimer une chambre.

3) Gestion des réservations 
a.    Possibilité d’ajouter une réservation
b.    Possibilité de changer le statut de réservation 
c.    Afficher la liste des réservations 

- Chaque réservation peut avoir un seul client, un nombre d'occupants, une liste de chambres réservées, chaque chambre a un numéro, un statut, un prix

- On sauvegardera les données dans une base de données relationnelles.

- Quand on voudra créer un client, on ne pourra valider sa création (bouton disable) 
tant que les champs ne sont pas remplis et que la longueur du champ téléphone ne dépasse pas 10 caractères.

- Toujours dans la création client, si les champs firstname et lastname sont encadrés 
en rouge quand ils sont pas remplis et vert si c'est le contraire

- Plusieurs vues à créer pour ce projet.

Pour la réalisation du TP, il y aura 2 projets : 

 - Un pour les IHM en WPF MVVM qu'il faudra créer.
 - Le deuxième contiendera la bibliotèque des classes de nos models (DAOHotel) qui vous est fourni.
