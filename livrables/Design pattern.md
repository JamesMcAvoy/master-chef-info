Design pattern



Bridge:  utilisé pour faire abstraction du type de l’ingrédient (frais surgeler longue conservation) lors de la réalisation de la recette 

Factory:  utilisé pour l’interface de la base de donnée

Observer:  le maître d’hôtel informe le chef de rang que des clients  sont à placer dans la salle, les clients informent le maître d’hôtel qu’ils sont arrivés, le comptoir des plats préparés informe les serveurs  que les plats sont prêts.

Strategy:  le maître d’hôtel place les clients, les cuisiniers réalisent les recettes

Thread Pool :  le chef de rang attend que les clients aient fait leur choix sur la carte, les serveurs servent simultanément les clients, en cuisine les différentes parties d’un plats sont réalisées en parallèle  

MVC:   cuisine : Model : communication avec la BDD et gestion du stock 
Controller : gestion des threads des différents cuisiniers
	
Salle : Controller : gestion des threads des membre de la salle ( maître d’hôtel, chef de rang, serveurs)  
View : affichage  graphique de la salle et du déroulé d’un service
