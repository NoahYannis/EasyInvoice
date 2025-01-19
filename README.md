# EasyInvoiceBlazor

**EasyInvoiceBlazor** ist eine moderne Webanwendung, die es erm�glicht, Buchungen zu verwalten und daraus Rechnungen zu erstellen. Die Anwendung wurde mit [Blazor](https://dotnet.microsoft.com/apps/aspnet/web-apps/blazor) und .NET 9 entwickelt und bietet eine intuitive Benutzeroberfl�che sowie nahtlose Cloud-Integration.

## Features

- **Buchungsmanagement:**
  - Buchungen erstellen, bearbeiten und l�schen.
  - �bersichtliche Darstellung aller Buchungen.
 
![image](https://github.com/user-attachments/assets/211037b8-f413-4562-bf03-eb6c684da4f7)
![image](https://github.com/user-attachments/assets/f48fa812-339e-47ea-b4d6-c93887f45ccf)



- **Rechnungs�bersicht:**
  - Basierend auf den Buchungen k�nnen Rechnungen generiert und angezeigt werden.
![image](https://github.com/user-attachments/assets/e0ee4889-5910-4147-be2d-22298e8840d4)


- **Technologien:**
  - Entwickelt mit Blazor und .NET 9.
  - Gehostet auf Azure.
  - Docker-Unterst�tzung.

## Voraussetzungen

Um das Projekt lokal auszuf�hren, ben�tigen Sie entweder:

- [.NET 9 SDK](https://dotnet.microsoft.com/download)
- [Docker](https://www.docker.com/)

## Installation

### 1. Repository klonen
```bash
git clone https://github.com/NoahYannis/EasyInvoiceBlazor.git
cd EasyInvoiceBlazor
```

### 2. Abh�ngigkeiten wiederherstellen

```bash
dotnet restore
```

### 3. Anwendung starten

F�hren Sie die Anwendung lokal aus:

```bash
dotnet run --project EasyInvoiceBlazor
```

Die Anwendung ist unter `http://localhost:7241` verf�gbar.

### 4. Docker verwenden (optional)

Erstellen und starten Sie einen Docker-Container:

```bash
docker build -t easyinvoiceblazor .
docker run -d -p 8080:80 easyinvoiceblazor
```

Die Anwendung ist dann unter `http://localhost:8080` verf�gbar.
