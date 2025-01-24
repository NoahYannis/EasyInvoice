# EasyInvoice

**EasyInvoice** ist eine moderne Webanwendung, die es ermöglicht, Buchungen zu verwalten und daraus Rechnungen zu erstellen. Die Anwendung wurde mit [Blazor](https://dotnet.microsoft.com/apps/aspnet/web-apps/blazor) und .NET 9 im Rahmen eines Berufsschulprojekts entwickelt.

![image](https://github.com/user-attachments/assets/66530b52-ede9-4231-add1-5e0be0624e2f)
![image](https://github.com/user-attachments/assets/d83bb867-b398-4f4f-82b5-652c31d42606)


## Features

- **Buchungsmanagement:**
  - Buchungen erstellen, bearbeiten und löschen.
  - Übersichtliche Darstellung aller Buchungen.
 

- **Rechnungsübersicht:**
  - Basierend auf den Buchungen können Rechnungen generiert und angezeigt werden.


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
git clone https://github.com/NoahYannis/EasyInvoice.git
cd EasyInvoice
```


### 3. Anwendung starten

Führen Sie die Anwendung lokal aus:

```bash
dotnet run --project EasyInvoice
```

Die Anwendung ist unter `http://localhost:7276` verfügbar.

### 4. Docker verwenden (optional)

Das Docker-Package ist hier verfügbar: https://github.com/NoahYannis/EasyInvoice/pkgs/container/easyinvoice
