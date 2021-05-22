# Gradebook
This demo program is a console program, which takes values to a list and counts the average, highest value and lowest value of those numbers.<br/>
Values are saved in a .txt file.<br/>
In addition, letter grade of the average is displayed to the user.
---

## How to run?
```cmd
# Run the program
dotnet run -p src\GradeBook\GradeBook.csproj
```

---

## Unit tests
```cmd
# Run unit tests for the program
dotnet test
```

---

## Troubleshoot
If `dotnet build` fails due to missing nuget packages, it might be caused by an issue in nuget sources.<br/>
In this case, the nuget source needs to be added before `dotnet build`.
```cmd
# Add nuget source
dotnet nuget add source --name nuget.org https://api.nuget.org/v3/index.json

# Restore the projects
dotnet restore --no-cache
```
