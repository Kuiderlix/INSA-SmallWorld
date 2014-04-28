    <center><img src="https://raw.githubusercontent.com/BenjBoug/INSA-SmallWorld/master/Doc/documentation/titre.png" title="SmallWorld"/></center><br /><br />

    <h1 id="but">Principe et But du jeu</h1>

    <p>
        Il s’agit d’un jeu tour-par-tour où chaque joueur dirige un <a href="#peuples">peuple</a>. Le but du jeu est de gérer des
        <a href="#unites">unités</a> sur une carte pour obtenir le plus de points possible à la fin d’un certain nombre de tours.
        Le placement de chaque unité rapporte plus ou moins de points. Les unités d’un joueur peuvent également
        attaquer les unités d’un autre joueur pour détruire des unités (limitant ainsi l’acquisition de points
        de l’adversaire) et occuper une case de la carte. Les points sont cumulés d'un tour à l'autre. 
        Le jeu se déroule sur une carte constituée de différent terrains sur laquelle les unités se déplacent.
    </p>

    <h1 id="regles">Règles du jeu</h1>

    <h2 id="peuples">Les peuples</h2>

    <p>
        Il existe quatres peuple : Gaulois, Viking, Nains et Elfes, ayant des caractéristiques différentes influant
        sur les stratégies de jeu :<br /><br />

        <b>Gaulois:</b><br />
        – Une unité Gauloise rapporte 1 point de plus lorsqu’elle occupe une case du type plaine.<br />
        – Une unité Gauloise n’acquière aucun point sur les cases de type montagne.<br />
        <b>Vikings:</b><br />
        – L’unité Viking a la capacité de se déplacer sur l’eau. L’occupation d’une case eau ne rapporte cependant 
        aucun point.<br />
        – Une unité Viking rapporte 1 point de plus lorsqu’elle occupe une case au bord de l’eau.<br />
        – Une unité Viking n’acquière aucun point sur les cases de type désert.<br />
        <b>Nains:</b><br />
        – Lorsqu’elle se trouve sur une case montagne, une unité Nain a la capacité de se déplacer
        sur n’importe quelle case montage de la carte à condition qu’elle ne soit pas occupée par
        une unité adverse.<br />
        – Une unité Nain rapporte 1 point de plus lorsqu’elle occupe une case de type forêt.<br />
        – Une unité Nain n’acquière aucun point sur les cases de type plaine.<br />
        <b>Elfes:</b><br />
        – Une unité Elfe rapporte 1 point de plus lorsqu’elle occupe une case de type montagne.<br />
        – Une unité Elfe peut se déplacer sans utiliser de point de déplacement quand elle est sur une case de 
        type forêt.<br />
        – Une unité Elfe n’acquière aucun point sur les cases de type forêt.<br />
    </p>

    <h2 id="unites">Les unités</h2>

    <p>
        Chaque joueur débute la partie avec un certain nombre d'unités placées sur la carte de manière automatique.<br /><br />

        Il existe 3 types d'unités :<br />
        – <b>Les unités classique</b> : 2 points de vie, 2 points d'attaque, 1 point de défense, elle gagne 1 point de 
        déplacement par tour<br />
        – <b>Les unités élites</b> : 2 points de vie, 3 points d'attaque, 1 point de défense, elle gagne 2 point de 
        déplacement par tour<br />
        – <b>Les unités blindées</b> : 3 points de vie, 1 points d'attaque, 2 point de défense, elle gagne 1 point de 
        déplacement ptout les deux tours.<br />
    </p>

    <h2 id="carte">La carte du monde</h2>

    <p>
        La carte est une case rectangulaire composée de cases carrées. Il existe cind terrains différents pour les cases : 
        Montagne, Plaine, Désert, Eau, Forêt.<br /><br />

        En début de partie la carte peut soit être créée de manière aléatoire soit être chargée à partir d'une carte créée 
        dans <a href="#editeur">l'éditeur de cartes</a>.<br /><br />

        Il existe 3 types de cartes aléatoires :<br />
        – <b>La carte Démo</b> : 5×5 cases, 10 tours, 5 unités classique, 3 unités élites et 1 unité blindée par joueur<br />
        – <b>La carte Petite</b> : 10×10 cases, 20 tours, 8 unités classique, 4 unités élites et 2 unités blindées par joueur<br />
        – <b>La carte Normale</b> : 15×15 cases, 30 tours, 12 unités classique, 5 unités élites et 3 unités blindées par joueur.<br />
    </p>

    <h2 id="combats">Les combats</h2>

    <p>
        Lorsqu'un joueur tente de déplacer une unité sur une case occupée par une ou plusieurs unités adverses un combat est 
        engagée entre cette unité et l'unité adverse. Le combat est géré de manière automatique par le jeu en fonction des 
        caractéristiques des deux unités. Si l'unité attaquante gagne le combat et qu'il n'y a plus d'unités sur la case elle 
        s'y déplace, s'il reste des unités elle reste sur la case mais perd tout de même 1 point de déplacement.
    </p>

    <h2 id="partie">Déroulement de la partie</h2>

    <h3 id="ouverture">Commencer une partie</h3>

    <p>
        A l'ouverture du jeu aucune partie n'est lancée. La cration d'une nouvelle partie se fait en passant par le menu 
        <em>Fichier->Nouvelle partie</em> ou en utilisant le raccourci clavier <em>Ctrl+N</em>.<br />
    </p>
        <center><img src="https://raw.githubusercontent.com/BenjBoug/INSA-SmallWorld/master/Doc/documentation/nouvelle.png"  title="Fenêtre de création d'une nouvelle partie"/></center><br />
    <p>
        La fenêtre de création d'une nouvelle partie, visible ci-dessus, permet de choisir :<br />
        – Le type de carte, soit une carte aléatoire soit une carte créée à l'aide de <a href="#editeur">l'éditeur de cartes</a><br />
        – Le Nombre de Joueur (de 2 à 4 joueurs)<br />
        – Le Type (Joueur ou Ordinateur), le nom, la couleur et le <a href="#peuples">peuple</a> associés à chaque joueur.<br /><br />

        La validation des paramètres de la partie se fait en appuyant sur le bouton <em>OK</em>. La carte est alors crée et les unités 
        de chaque joueur placés de manière automatique. Le jeu peut alors commencer, la main est donné au premier joueur.
    </p>

    <h3 id="tour">Tour de jeu</h3>

    <p>
        La partie compte un nombre prédéfini de tours qui dépend de la carte choisie. Chaque joueur joue une fois par tour, pendant son tour 
        de jeu le joueur peut déplacer ses unités en fonction de leurs points de déplacement. Pour cela, il lui faut clicker sur la case qui 
        contient les unités qu'il veut déplacer  puis séléctionner les unités  qu'il veut déplacer dans le menu de droite puis enfin 
        séléctionner la case de destination. Après avoir séléctionné les unités qu'il veut déplacer, les cases accessibles pour ces 
        unités sont mise en valeur avec des contours colorés (dégradé du orange au blanc, plus la couleur du contour est proche du orange 
        plus la case est intéressante pour le joueur concerné). Il peut aussi sélectionné des cases contenant des unités énemies afin 
        de voir leurs détails dans le menu de droite, il ne peut cependant ni les sélectionnées ni les déplacer. Pour finir son tour, 
        le joueur doit appuyer sur le bouton <em>Finir tour</em> du menu de gauche pour passer la main au joueur suivant.<br /><br />
        Ci-dessous un apercu de la fenètre au cours d'une partie à 4 joueurs.<br />
    </p>
        <center><img src="https://raw.githubusercontent.com/BenjBoug/INSA-SmallWorld/master/Doc/documentation/fenetre.png" title="Partie en cours"/></center><br />
    
    <h3 id="fin">Fin de partie</h3>
    <p>
        La partie se termine lorsque le nombre de tours prédéfini à été effectué, ou lorsqu’il ne reste qu’un seul joueur sur le plateau.
        Un classement des joueurs est alors effectué et affiché dans une fenêtre telle que celle visible ci-dessous 
        (exemple d'une partie à 3 joueurs).<br /><br />
    </p>
        <center><img src="https://raw.githubusercontent.com/BenjBoug/INSA-SmallWorld/master/Doc/documentation/classement.png" title="Partie en cours"/></center><br />

    <h3 id="sauvegarde">Sauvegarde et chargement</h3>

    <p>
        A tout moment de la partie il est possible de sauvegarder en passant par les menus <em>Fichier->Sauvegarder</em> 
        ou <em>Fichier->Sauvegarder sous...</em> (permettant d'enregistrer dans un fichier différent du fichier ouvert 
        ou du fichier dans lequel vous auriez déjà enregisté) ou en utilisant le raccourci clavier <em>Ctrl+S</em>. 
        Cette sauvegarde pourra ensuite être chargée à tout moment en passant par par le menu <em>Fichier->Ouvrir...</em> 
        ou en utilisant le raccourci clavier <em>Ctrl+O</em>. L'extension des fichier de sauvegarde est <em>.sav</em>.        
    </p>

    <h1 id="autre">Autre fonctionnalités</h1>

    <h2 id="editeur">Editeur de cartes</h2>

    <p>
        En passant par le menu <em>Fichier->Editeur de carte</em> il est possible d'accéder à un éditeur permettant de créer des 
        cartes personnalisées. L'interface de l'éditeur est visible ci-dessous.<br />
    </p>
        <center><img src="https://raw.githubusercontent.com/BenjBoug/INSA-SmallWorld/master/Doc/documentation/editeur.png" title="Editeur de cartes" /></center><br />
    <p>
        Dans la partie supérieure du menu de gauche, il est possible de régler les paramètre de la carte :<br />
        – La taille de la carte (largeur et hauteur, en nombre de cases, comprises en 5 et 30 pour garder des cartes de 
        taille raisonnable)<br />
        – Le nombre de tours (compris entre 5 et 50 pour que la durée des partie reste raisonnable)<br />
        – Le nombre d'<a href="#unites">unités de chaque type</a>. Le nombre total d'unité (tous types confondus) doit
        être compris entre 5 et 50.<br /><br />

        La modification des cases de la carte se fait en clickant sur une case de la carte, le terrain de cette case est 
        alors remplacé par le terrain sélectionné dans la paletter (partie basse du menu de gauche). Il est aussi 
        possible de maintenir le click pour modifier plusieur case à la fois.<br /><br />
        La carte peut être réinitialisée (création d'une nouvelle carte) en passant par le menu <em>Fichier->Nouvelle carte</em> 
        Lors de la création d'une nouvelle carte le terrain par défaut des case est le terrain plaine, de même lors de 
        l'agrandissement d'une carte, les cases ajoutée seront par défaut de terrain plaine.<br />
        A tout moment il est possible d'enregistrer la carte en passant par les menus <em>Fichier->Enregistrer</em> 
        ou <em>Fichier->Enregistrer sous...</em> ou en utilisant le raccourci clavier <em>Ctrl+S</em>. Cette carte pourra 
        ensuite être ouverte dans l'éditeur pour être modifiée en passant par par le menu 
        <em>Fichier->Ouvrir...</em> ou en utilisant le raccourci clavier <em>Ctrl+O</em>. Elle pourra aussi être utilisé 
        au moment de la création d'une nouvelle <a href="#partie">partie</a>. L'extension des fichier de sauvegarde est <em>.sav</em>.        
    </p>

    <h2 id="style">Changement de style</h2>

    <p>
        5 styles différent sont proposé pour l'affichage des différents <a href="#carte">terrains</a> :
    </p>
        <center><table>
        <tr><th>Terrains\Styles</th><th>Par defaut</th><th>Groovy</th><th>Tropical</th><th>Campagne</th><th>Pas de style</th></tr>
        <tr><th>Montagne</th>
            <td><center><img src="https://raw.githubusercontent.com/BenjBoug/INSA-SmallWorld/master/Doc/documentation/default/caseMontagne.png"  title="Case montagne par default" /></center></td>
            <td><center><img src="https://raw.githubusercontent.com/BenjBoug/INSA-SmallWorld/master/Doc/documentation/groovy/caseMontagne.png"  title="Case montagne groovy" /></center></td>
            <td><center><img src="https://raw.githubusercontent.com/BenjBoug/INSA-SmallWorld/master/Doc/documentation/tropical/caseMontagne.png"  title="Case montagne tropical" /></center></td>
            <td><center><img src="https://raw.githubusercontent.com/BenjBoug/INSA-SmallWorld/master/Doc/documentation/campaign/caseMontagne.png"  title="Case montagne campagne" /></center></td>
            <td><center><div style="width:50px;height:50px;background-color:SaddleBrown;" /></center></td>
        </tr>
        <tr><th>Plaine</th>
            <td><center><img src="https://raw.githubusercontent.com/BenjBoug/INSA-SmallWorld/master/Doc/documentation/default/casePlaine.png"  title="Case plaine par default" /></center></td>
            <td><center><img src="https://raw.githubusercontent.com/BenjBoug/INSA-SmallWorld/master/Doc/documentation/groovy/casePlaine.png"  title="Case plaine groovy" /></center></td>
            <td><center><img src="https://raw.githubusercontent.com/BenjBoug/INSA-SmallWorld/master/Doc/documentation/tropical/casePlaine.png"  title="Case plaine tropical" /></center></td>
            <td><center><img src="https://raw.githubusercontent.com/BenjBoug/INSA-SmallWorld/master/Doc/documentation/campaign/casePlaine.png"  title="Case plaine campagne" /></center></td>
            <td><center><div style="width:50px;height:50px;background-color:LightGreen;" /></td>
        </tr>
        <tr><th>Désert</th>
            <td><center><img src="https://raw.githubusercontent.com/BenjBoug/INSA-SmallWorld/master/Doc/documentation/default/caseDesert.png"  title="Case désert par default" /></center></td>
            <td><center><img src="https://raw.githubusercontent.com/BenjBoug/INSA-SmallWorld/master/Doc/documentation/groovy/caseDesert.png"  title="Case désert groovy" /></center></td>
            <td><center><img src="https://raw.githubusercontent.com/BenjBoug/INSA-SmallWorld/master/Doc/documentation/tropical/caseDesert.png"  title="Case désert tropical" /></center></td>
            <td><center><img src="https://raw.githubusercontent.com/BenjBoug/INSA-SmallWorld/master/Doc/documentation/campaign/caseDesert.png"  title="Case désert campagne" /></center></td>
            <td><center><div style="width:50px;height:50px;background-color:LightGoldenrodYellow;" /></td>
        </tr>
        <tr><th>Eau</th>
            <td><center><img src="https://raw.githubusercontent.com/BenjBoug/INSA-SmallWorld/master/Doc/documentation/default/caseEau.png"  title="Case eau par default" /></center></td>
            <td><center><img src="https://raw.githubusercontent.com/BenjBoug/INSA-SmallWorld/master/Doc/documentation/groovy/caseEau.png"  title="Case eau groovy" /></center></td>
            <td><center><img src="https://raw.githubusercontent.com/BenjBoug/INSA-SmallWorld/master/Doc/documentation/tropical/caseEau.png"  title="Case eau tropical" /></center></td>
            <td><center><img src="https://raw.githubusercontent.com/BenjBoug/INSA-SmallWorld/master/Doc/documentation/campaign/caseEau.png"  title="Case eau campagne" /></center></td>
            <td><center><div style="width:50px;height:50px;background-color:LightBlue;" /></td>
        </tr>
        <tr><th>Forêt</th>
            <td><center><img src="https://raw.githubusercontent.com/BenjBoug/INSA-SmallWorld/master/Doc/documentation/default/caseForet.png"  title="Case forêt par default" /></center></td>
            <td><center><img src="https://raw.githubusercontent.com/BenjBoug/INSA-SmallWorld/master/Doc/documentation/groovy/caseForet.png"  title="Case forêt groovy" /></center></td>
            <td><center><img src="https://raw.githubusercontent.com/BenjBoug/INSA-SmallWorld/master/Doc/documentation/tropical/caseForet.png"  title="Case forêt tropical" /></center></td>
            <td><center><img src="https://raw.githubusercontent.com/BenjBoug/INSA-SmallWorld/master/Doc/documentation/campaign/caseForet.png"  title="Case forêt campagne" /></center></td>
            <td><center><div style="width:50px;height:50px;background-color:DarkGreen;" /></td>
        </tr>
        </table></center>
    <p>
        Il est possible de changer de style à tout moment que ce soit dans la fenêtre de jeu ou dans l'éditeur en passant par le menu 
        <em>Options->Affichage->nom du style</em> de la fenêtre pour laquelle vous voulez changer le style.
    </p>

    <h1 id="credit">Crédits</h1>

    <p>
        Cette version de SmallWorld a été dévelopée par<br /><br />

        <b>AMALOU Abderrahmane</b><br />
        &<br />
        <b>BOUGUET Benjamin</b><br /><br />

        dans le cadre du Module Projet de POO/MOO,<br />
        4ème année - Département Informatique à l'INSA de Rennes.
    </p>
