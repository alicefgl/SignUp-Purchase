# SignUp-Purchase

Sito realizzato con ASP.NET MVC

CONSEGNA:
Modificare [il progetto precedente](https://github.com/alicefgl/FORM-dotnetMVC) in questo modo:

 - Il sito deve esporre nella barra di navigazione le pagine: Home, Privacy, SignUp, Purchase, Cart
 - La pagina di SignUp deve contenere un form di registrazione
 - Una volta compilato il form di SignUp l'utente deve essere rimandato ad una pagina di Riepilogo dei dati inseriti (raggiungibile solo tramite metodo HTTP-POST).
 - La pagina di Purchase deve esporre un form in cui l'utente possa inserire: nome del prodotto da acquistare, quantità di interesse.
 - Una volta compilato il form di Purchase l'utente deve essere rimandato alla pagina Cart, in cui comparirà l'elenco dei prodotti inseriti

PROCEDIMENTO:
Sulla base degli esercizi precedenti, ho aggiunto un nuovo form contenente i prodotti (che comporranno poi la classe Prodotti), secondo il quale l'utente può inserire la quantità di prodotti da acquistare tramite due bottoni (+ e -), che modificano il counter stampato inoltre a video.
Questi pulsanti richiamano delle funzioni (una per incrementare il counter ed una per decrementarlo) che modificano il valore della casella di testo readonly relativa all'id che viene passato come parametro richiamando la funzione.

Il model utilizzato è un vettore di classe Prodotto, che contiene il nome del prodotto e la quantità desiderata come suoi attributi.
Il vettore viene compilato in base alle caselle di testo readonly relative ai vari prodotti, inserendo i dati (nome e quantità) di un prodotto per ogni elemento del vettore (la procedura di post viene quindi eseguita ogni volta che si preme un bottone + o - modificando il valore della quantità).

Per stampare il riepilogo dell'ordine, ho creato una nuova View "Cart", contentente un ulteriore form che stampi a video il contenuto del model.
La View "Cart" viene mostrata tramite una procedura di HTTP Post, infatti essa è raggiungibile solamente tramite la pagina di acquisto dei prodotti, e non tramite l'URL del sito (come invece sarebbe stato se si fosse trattato di una procedura di HTTP GET).
La View "Purchase", invece, è raggiungibile tramite la navbar del sito collegandola ad un nav-item, in questo modo:
```
     <li class="nav-item">
                <a class="nav-link text-dark" asp-area="" asp-controller="Home" asp-action="Purchase">Purchase</a>
     </li>
```
