# RazorHAT Template for One-Click Railway Deployments

# Installation 📋

Click the button

# Troubleshooting 🐛

1. Railway's Docker build fails to on `dotnet restore`
   A: Make sure you have the `NIXPACKS_CSHARP_SDK_VERSION` set in your Railway Environment variables (see the editor under '`Settings`').  For this build, I'm using: `NIXPACKS_CSHARP_SDK_VERSION=7.0`
2. Railway mysteriously says your deployment cannot be found...
   A: Make sure your `PORT` enviroment variable is set.  Railway does not (at this time) warn you about this...  e.g.: `PORT=3000`.

# Tech Stack 💻

|    Technology    |                                    Purpose |
|:----------------:|-------------------------------------------:|
|       HTMX       |                               AJAX replacement |
|      DasyUI      |                         Easy Tailwind UI Components |
|     AlpineJS     |                                   reactive Javascript variables in the DOM |
| Insight.Database |                  Dapper and Entity Framework replacement |
|   TailwindCSS    |                                    CSS API |
|   Lego    |                                    Create your own Web Components |


