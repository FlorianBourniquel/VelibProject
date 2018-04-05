# Readme
## REST and SOAP WS Lab
### ServerSoapVelib
#### Methodes exposées
    List<Ville> GetVille(int deltaSeconde)
    List<string> GetNomStationParVille(string ville, int deltaSeconde);
    Station GetInformationStation (string ville, string station, int deltaSeconde);
Chacune de ces méthodes est implémentée deux fois, la première de manière synchrone et la deuxième de manière asynchrone. De plus dans le cas de l'appel d'une méthode asynchrone, le serveur appel aussi le service JCDecaux de manière asynchrone. 
#### Cache
Le serveur dispose d'un système de cache qui fonctionne de la manière suivante. Lorsqu'un client exécute une requete il doit préciser la limite en seconde depuis laquelle les données n'ont pas été mises à jour. Par exemple avec un paramètre de 60 secondes, le serveur ne renverra aucune donnée n'ayant pas été mise à jour depuis une minute.  
#### Eventing
##### Methodes exposées
    void SubscribeStationEvent(string ville,string stationName, int deltaSeconde);
    void UnsubscribeStationEvent(string ville, string stationName, int deltaSeconde);
    void TriggerUpdate();
Le serveur dispose d'un système d'évènement qui va automatiquement envoyer les informations des stations auxquelles les clients sont abonnés. Cet envoi est déclenché par l'appel de la méthode TriggerUpdate() (voir partie MockTimer).
### MockTimer
#### Liste des commandes
    On {nbsecondes} : declenche le StationUpdate evenement toutes les nbsecondes secondes
    Off : interompt le StationUpdate evenement

Afin de remplacer le potentiel appel webHook de JCDecaux ou un scheduler windows, j'ai créé ce projet console qui permet de déclencher l'envoie des informations des stations auxquelles les clients sont abonnés tous les X temps. Le temps étant paramétrable dans l'application. Cette application permet de tester de manière simple le comportement du serveur et du client lors du déclenchement du broadcast des informations.
### ClientConsole
#### Comment utiliser l'application
  - Taper help une fois l'application lancée pour avoir l'aide
##### Liste des commandes
{deltaSeconde} indique la limite du delta en seconde depuis la derniere mise à jour des données

    ville {deltaSeconde}: Obtenir la liste des villes
    NomStationParVille {NomVille} {deltaSeconde}: Obtenir la liste des noms des stations d'une ville
    InfoStation {NomVille} {NomStation} {deltaSeconde}: Obtenir le nombre de velos disponible dans la station
    InfoStationSub {NomVille} {NomStation} {deltaSeconde}: Obtenir le nombre de velos disponible dans la station tous les X temps
    InfoStationUnSub {NomVille} {NomStation} {deltaSeconde}: Se desinscrire de cet evenement
    quitter : quitter l'application
##### Exemples de commandes
    ville 10
    NomStationParVille Toulouse 10
    InfoStation Toulouse FEUGA 10
    quitter
#### Gestion des exceptions
La gestion des exceptions est presente mais reste basique dans le sens ou l'on se contente de les catch et de les afficher.
### ClientGraphique
#### Comment utiliser l'application
  - Preciser la limite de la derniere mise à jour des données sur le serveur. Defaut : 0
  - Cliquer sur le bouton On/Off pour activer ou non le mode asynchrone
  - Selectionner une ville
  - Selectionner une station
  - Les informations concernant cette station s'affichent
#### Gestion des exceptions
La gestion des exceptions est presente mais reste basique dans le sens ou l'on se contente de les catch et de les afficher.
## TP Events Lib
### EventsLib
Contient l'ensemble des projets de ce tp
## TP Maths Library
### MathsLibrary
Contient l'ensemble des projets de ce tp