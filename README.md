# Tagger

Tagger is a Visual Studio 2003 VB.NET Pocket PC WinForms app for lasertag match scoring and timing. frmMain hosts a Scores tab with six named teams whose +/- buttons change integer scores, and a Clocks tab with two independent Start/Stop/Reset clocks (the 1-second timer is declared but not wired). The solution describes it as an application used for many different Lasertag tasks; File → Exit ends the process. The `.vbdproj` (ProductVersion 7.10.3077) targets Pocket PC, outputs a WinExe deployed to `\Program Files\Tagger`, and references Compact Framework System, Data, Drawing, Windows.Forms, and XML assemblies.

**Source last updated:** 2004-10-05 · **Language:** VB.NET · **Target:** .NET Compact Framework 1.0 / Pocket PC · **Output:** Pocket PC WinForms WinExe

## Solution structure

| Project | Language | Type | Purpose |
|---------|----------|------|---------|
| `Tagger` | VB.NET | Pocket PC WinForms WinExe | Lasertag scoreboard (six teams) and dual clocks; deploys to `\Program Files\Tagger` |

## How to open

Open `Tagger.sln` in Visual Studio .NET 2003 with Smart Device Extensions (Pocket PC). Later Visual Studio versions do not load `.vbdproj` device projects.

## Requirements

- Visual Studio 2005

## Attribution and provenance

Working copy from my Historical Dev folder `Tagger`. Assembly attributes (title, description, company, product, copyright) are empty Visual Studio template defaults. Solution format 8.00 / project ProductVersion 7.10.3077. Solution description: "An application used for many different Lasertag tasks."

## License

MIT. Copyright (c) 2026 VaderConsulting, for Dave Robinson's code. See `LICENSE`.
