# PlateauUnity

22/11

Les animations d'attente et de saut ont bien été ajouté.

L'animation d'attente se lance quand le personnage reste en animation idle pendant 10 secondes. 
Le saut se déclenche quand on appuie sur "ESPACE".
J'ai modifié le système de déplacement aussi. Maintenant le perso se déplace quand on appuie sur "E". Il a 2 
destinations différentes qui changent chaque fois que l'on appuie sur "E".

Petit problème que je règlerai plus tard : l'animation de saut se joue bizarrement, comme si le perso était 
attiré vers le sol.

01/12

J'ai réglé le problème avec l'animation de saut, il fallait juste selectionner une option dans les
param de l'anim. J'ai 2 anims de saut, une pour quand on saute sur place et l'autre pour si on saute
en courant.

Question Studio : 

Je pense que je demanderais d'abord comment implanter des modèles/animations dans le logiciel.
Ensuite il me semble important de savoir comment fonctionne leur NavMesh je leur demanderais donc 
tout ce que j'ai besoin de savoir pour bien l'utiliser.
Après, j'aimerais savoir comment lié un modèle avec une animation (donner l'avatar/le squelette du modèle 
à l'anim).
Et enfin, pour pouvoir faire un personnage plus complexe, je demanderais comment faire la communication 
entre les animations afin de bien savoir comment le FSM fonctionne.

Je pense qu'avec les réponses qu'on me donnera, je devrais avoir les bases pour réussir à implanter des modèles
et leur donner vie.