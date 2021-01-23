# Appunti
Semplice applicazione per scrivere testo.

## Funzionalità
 - Topmost (viene mostrata sopra le altre finestre)
 - Salvataggio su file
 - Caricamento da file

## Guida
![UI v1.0.0.4](https://raw.githubusercontent.com/Cutotopo/appunti/main/Immagini/UI.png)

1. Testo: TextBox dove è possibile scrivere il testo da salvare e visualizzare il testo da importare. Accetta anche la pressione del tasto RETURN (Invio) per inserire una nuova linea di testo o quella del tasto TAB per inserire una tabulazione.
2. Caratteri: Numero di caratteri contenuti nel testo inserito o importato.
3. Stato del salvataggio: Se viene mostrato "Non salvato", il file non è stato salvato e il salvataggio automatico sarà disabilitato. Utilizzare questo pulsante per salvare il file e attivare il salvataggio automatico. Verrà mostrato il percorso del file salvato.
4. Stato del salvataggio automatico: Se il file non è stato salvato, questa funzione non sarà disponibile. Ad ogni modifica del file, questa verrà automaticamente scritta sul file senza la necessità di salvare nuovamente il file.
5. Pulsante "primo piano": Questo pulsante permette di mantenere la finestra dell'applicazione sopra altre finestre, finchè la funzione non viene disattivata oppure la finestra viene ridotta a icona. Il pulsante mostra anche lo stato della funzione (attivato o disattivato). Viene modificata la proprietà "Topmost" della finestra corrente.
6. Pulsante "esportazione": Questo pulsante permette di esportare il contenuto della casella Testo su un file (con estensione *.fnotes*). Questo permette di aprire lo stesso file su dispositivi diversi o con altri programmi come il Blocco Note di Microsoft Windows.
7. Pulsante "github": Questo pulsante apre la pagina del repository GitHub dell'applicazione.
8. Pulsante "importazione": Questo pulsante permette di importare il contenuto della casella Testo da un file (con estensione *.fnotes*).

## Requisiti
Microsoft .NET 4.7+ [download](https://dotnet.microsoft.com/download/dotnet-core/)

## Download
[Pagina releases](https://github.com/Cutotopo/appunti/releases)
