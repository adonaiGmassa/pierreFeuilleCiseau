const CHOIX = ['pierre', 'Feuille', 'ciseaux'];
const CHOIX_ADVERSAIRE  = CHOIX[Math.floor(Math.random() * CHOIX.length)];
let TextResultat = '';


function play(CHOIX_JOUEUR) {
    
    if (CHOIX_JOUEUR === CHOIX_ADVERSAIRE) {
        TextResultat = `Égalité! Vous avez choisi ${CHOIX_JOUEUR} et l'ordinateur aussi.`;
    } 
    else {
        if (
            (CHOIX_JOUEUR === 'pierre' && CHOIX_ADVERSAIRE === 'ciseaux') ||
            (CHOIX_JOUEUR === 'Feuille' && CHOIX_ADVERSAIRE === 'pierre') ||
            (CHOIX_JOUEUR === 'ciseaux' && CHOIX_ADVERSAIRE === 'Feuille')
        ) 
        {
            TextResultat = `Vous avez gagné! Vous avez choisi ${CHOIX_JOUEUR} et l'ordinateur a choisi ${ CHOIX_ADVERSAIRE}.`;
        } 
        else 
        {
            TextResultat = `Vous avez perdu! Vous avez choisi ${CHOIX_JOUEUR} et l'ordinateur a choisi ${ CHOIX_ADVERSAIRE}.`;
        }
        document.getElementById('TextResultat').innerText = TextResultat;
    }
}
