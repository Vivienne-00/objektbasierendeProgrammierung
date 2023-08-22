Fragen

1. Wie können Felder von Eigenschaften unterschieden werden? Oder anders gefragt: Woran ist bei einer Instanzvariable in C# erkennbar, ob es ein Feld oder eine Eigenschaft ist?

Felder sind einfache Variablen und Eigenschaften können noch valdierung dahinter haben.

2. Worin unterscheidet sich ein backing field von einem normalen Feld?

Das backing field wird nur zum speichern von Daten verwendet innerhalb der Klasse.

3. Wann macht es Sinn, ein read-only Feld zu deklarieren, welches keinen Standardwert zugewiesen erhält?

Wenn man das Feld im Konstruktor initialisiert.
Bsp. Artikel mit einer Artikelnummer.

4. Wann macht es Sinn, ein read-only Feld zu deklarieren, welches einen Standardwert zugewiesen erhält?

Wenn der Wert beim Kompilieren bereits klar ist und während dem Prozess nicht mehr geändert werden muss.

5. Was sind typische Anwendungsfälle für Felder in C#?

Wenn man diesen für mehrere Methoden verwendet.
Speichern von Daten und Zuständen.

6. Was sind typische Anwendungsfälle für Eigenschaften in C#?

Datentypen zum verwenden ausserhalb der Klasse.
Zum Validieren, beim setzen von Werten. 