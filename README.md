```
Directory structure:
└── aslamnazeershaikh-moviemanagement/
    ├── README.md
    ├── CODE_OF_CONDUCT.md
    ├── LICENSE.md
    ├── MovieManagement.sln
    ├── SECURITY.md
    ├── .editorconfig
    ├── MovieManagement.Application/
    │   ├── MovieManagement.Application.csproj
    │   └── Interfaces/
    │       └── IMovieRepository.cs
    ├── MovieManagement.Domain/
    │   ├── MovieManagement.Domain.csproj
    │   ├── Entities/
    │   │   └── Movie.cs
    │   └── Enums/
    │       └── Category.cs
    ├── MovieManagement.Infrastructure/
    │   ├── MovieManagement.Infrastructure.csproj
    │   ├── Context/
    │   │   └── AppDbContext.cs
    │   └── Repositories/
    │       └── MovieRepository.cs
    ├── MovieManagement.WebUi/
    │   ├── MovieManagement.WebUi.csproj
    │   ├── Program.cs
    │   ├── appsettings.Development.json
    │   ├── appsettings.json
    │   ├── Components/
    │   │   ├── App.razor
    │   │   ├── Routes.razor
    │   │   ├── _Imports.razor
    │   │   ├── Layout/
    │   │   │   ├── MainLayout.razor
    │   │   │   ├── MainLayout.razor.css
    │   │   │   ├── NavMenu.razor
    │   │   │   └── NavMenu.razor.css
    │   │   └── Pages/
    │   │       ├── Counter.razor
    │   │       ├── Error.razor
    │   │       ├── Home.razor
    │   │       └── Weather.razor
    │   ├── Properties/
    │   │   └── launchSettings.json
    │   └── wwwroot/
    │       ├── app.css
    │       └── lib/
    │           └── bootstrap/
    │               └── dist/
    │                   ├── css/
    │                   │   ├── bootstrap-grid.css
    │                   │   ├── bootstrap-grid.rtl.css
    │                   │   ├── bootstrap-reboot.css
    │                   │   ├── bootstrap-reboot.rtl.css
    │                   │   ├── bootstrap-utilities.css
    │                   │   ├── bootstrap-utilities.rtl.css
    │                   │   ├── bootstrap.css
    │                   │   └── bootstrap.rtl.css
    │                   └── js/
    │                       ├── bootstrap.bundle.js
    │                       ├── bootstrap.esm.js
    │                       └── bootstrap.js
    └── docs/
        ├── Docker Commands/
        │   └── MySQL Container.txt
        └── Screenshot Images/

```