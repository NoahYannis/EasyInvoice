# EasyInvoice

**EasyInvoice** ist eine moderne Webanwendung, die es ermöglicht, Buchungen zu verwalten und daraus Rechnungen zu erstellen. Die Anwendung wurde mit [Blazor](https://dotnet.microsoft.com/apps/aspnet/web-apps/blazor) und .NET 9 entwickelt und bietet eine intuitive Benutzeroberfläche sowie nahtlose Cloud-Integration.

## Features

- **Buchungsmanagement:**
  - Buchungen erstellen, bearbeiten und löschen.
  - Übersichtliche Darstellung aller Buchungen.
 
![image](https://github.com/user-attachments/assets/211037b8-f413-4562-bf03-eb6c684da4f7)
![image](https://github.com/user-attachments/assets/f48fa812-339e-47ea-b4d6-c93887f45ccf)



- **Rechnungsübersicht:**
  - Basierend auf den Buchungen können Rechnungen generiert und angezeigt werden.
![image](https://github.com/user-attachments/assets/e0ee4889-5910-4147-be2d-22298e8840d4)


- **Technologien:**
  - Entwickelt mit Blazor WebAssembly und .NET 9.
  - Gehostet auf Azure (https://white-sky-0e377e603-preview.westeurope.4.azurestaticapps.net/).
  - Docker-Unterstützung.

## Voraussetzungen

Um das Projekt lokal auszuführen, benötigen Sie entweder:

- [.NET 9 SDK](https://dotnet.microsoft.com/download)
- [Docker](https://www.docker.com/)

## Installation

### 1. Repository klonen
```bash
git clone https://github.com/NoahYannis/EasyInvoiceBlazor.git
cd EasyInvoiceBlazor
```


### 3. Anwendung starten

Führen Sie die Anwendung lokal aus:

```bash
dotnet run --project EasyInvoice
```

Die Anwendung ist unter `http://localhost:7276` verfügbar.

### 4. Docker verwenden (optional)

Erstellen und starten Sie einen Docker-Container:

```bash
docker build -t easyinvoice .
docker run -d -p 8080:80 easyinvoice
```

Die Anwendung ist dann unter `http://localhost:8080` verfügbar.
