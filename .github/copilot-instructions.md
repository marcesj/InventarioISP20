# Copilot instructions for InventarioISP20

## Build, run, and test commands

Use the solution root (`InventarioISP20.sln`) for most commands.

```powershell
# Restore dependencies
dotnet restore .\InventarioISP20.sln

# Build all projects
dotnet build .\InventarioISP20.sln

# Run the WinForms app
dotnet run --project .\Desktop\Desktop.csproj
```

There is currently no test project in this repository, so `dotnet test` runs but does not execute test cases.  
Add test command guidance for single-test execution after a test project is introduced.

## High-level architecture

- This is a single-project .NET Windows Forms application (`Desktop`), targeting `net8.0-windows`.
- Startup flow: `Program.Main()` initializes WinForms and opens `MenuPrincipalView`.
- UI is form-centric: each screen is a `Form` split across partial classes:
  - `Views\*.Designer.cs` for generated UI layout/control wiring
  - `Views\*.cs` for behavior/event handlers
- `MenuPrincipalView` is the navigation hub. Menu item click handlers instantiate and show child forms (e.g., `ArticulosView`).
- `FontAwesome.Sharp` is used for icon-enabled controls (`IconButton`, `IconMenuItem`) in the main menu form.

## Key repository conventions

- Keep partial form class namespaces consistent between `*.cs` and `*.Designer.cs`; mismatches break form compilation.
- Do not hand-edit generated UI blocks inside `InitializeComponent()` unless unavoidable; prefer changes through the WinForms Designer.
- Follow existing event-handler wiring pattern: handlers are attached in designer files (`Control.Click += Handler`) and implemented in the form code-behind.
- Preserve the current Spanish UI/control naming style (`MenuPrincipalView`, `SubMenuArticulos`, `BtnSaludo`) when adding new menu items or forms.
- New navigable screens should be opened from `MenuPrincipalView` via click handlers that create and `Show()` the form, matching the current flow.

- ## Mandatory instructions
- Hablar en español