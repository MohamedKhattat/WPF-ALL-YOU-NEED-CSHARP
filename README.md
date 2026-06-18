# WPF — All You Need (C# Reference & Samples)

> A curated, hands-on collection of WPF samples used to learn the framework's architecture — built on top of Microsoft's official WPF-Samples.

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET%208-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![WPF](https://img.shields.io/badge/WPF-0C54C2?style=for-the-badge&logo=windows&logoColor=white)
![XAML](https://img.shields.io/badge/XAML-0C54C2?style=for-the-badge&logo=microsoft&logoColor=white)
![Visual Studio](https://img.shields.io/badge/Visual%20Studio%202022-5C2D91?style=for-the-badge&logo=visual-studio&logoColor=white)

## Overview

This repository is a **reference and study collection for Windows Presentation Foundation (WPF) in C#**. It is **adapted from Microsoft's official [WPF-Samples](https://github.com/microsoft/WPF-Samples)** — the canonical samples that demonstrate WPF API usage patterns and popular features — retargeted to **.NET 8.0**.

I assembled and worked through these samples to get familiar with the **WPF architecture** (the visual/logical trees, data binding, routed events, dependency properties, styling and templating, the dispatcher/threading model, and resource management) in the context of building a **fiscal cash-register desktop application**. Alongside the Microsoft samples, the root also contains a small original UI sketch — `archivage.xaml` — a French-language data-archiving window (audit trails, cash data, pre-purge export) prototyped for that project.

> **Attribution & honesty:** The vast majority of the sample code here is **Microsoft's WPF-Samples**, not original work. This repo is a personal learning fork/reference — a place to read, build, and experiment with proven WPF patterns. Credit for the samples belongs to the Microsoft WPF team. See [`LICENSE`](LICENSE) (MIT, © Microsoft).

## What's Inside

The samples are organized by WPF concept area. Each folder typically contains one or more self-contained, buildable projects.

### Core framework concepts
- **Getting Started** — Hello World, layout (simple/complex/dynamic), multi-page apps, the first-WPF-app walkthrough
- **Elements** — element properties, sizing, margins, visibility, focus visual styles, context menus
- **Element Tree** — overriding the logical tree, searching for elements
- **Events** — routed events, custom routed events, finding the source element, attaching handlers
- **Input and Commands** — routed commands, `ICommandSource`, editing commands, mouse/keyboard/touch input, focus handling
- **Properties** — dependency properties, callbacks, custom classes with DPs, restoring default values

### UI, data & visuals
- **Data Binding** — value conversion, validation, collection/master-detail binding, `CollectionViewSource`, grouping, LINQ, data templating, data triggers
- **Styles & Templates** — styling intro, content/control templates, event triggers, alternating item appearance
- **Resources** — application/merged/defined resources
- **Graphics** — 2D transforms, brushes, geometries, bitmap encoders/decoders, effects, image views, matrices
- **Animation** — keyframe, path, per-frame, opacity, property and custom animations, timing and key splines
- **Visual Layer** — `DrawingVisual`, `CompositionTarget`, visual hit-testing
- **Documents** — flow & fixed documents, annotations, spell checking

### Application & platform
- **Application Management** — shutdown, single-instance detection, command-line args, unhandled-exception handling, skinned apps
- **Windows** — dialogs, message boxes, custom/non-rectangular windows, notification icon, window state & activation, wizard
- **Threading** — the `Dispatcher`, single-threaded apps, multi-threaded web browser
- **Clipboard** — clipboard viewer/spy
- **Drag and Drop** — data formats, events, objects, text & thumb operations
- **Speech and Media** — media gallery, speech synthesis/recognition
- **Accessibility** — UI Automation patterns (find/insert/select text, focus tracking, highlighter, window move)
- **Globalization and Localization** — flow direction, BAML localization, multi-language formatting, LTR/RTL
- **PerMonitorDPI** — per-monitor DPI awareness, image/text scaling, WinForms host
- **Migration and Interoperability** — hosting Win32/WinForms in WPF and vice-versa, ActiveX, property mapping
- **Compatibility** — `AppContext` quirks / compatibility switches

### Tools & full demos
- **Tools** — `BamlReflector`, `LocBaml`
- **Sample Applications** — larger end-to-end demos: `ExpenseIt`, `DataBindingDemo`, `CustomComboBox`, `CalculatorDemo`, `GraphingCalculatorDemo`, `PhotoStoreDemo`, `PhotoViewerDemo`, `StickyNotesDemo`, `SlidePuzzleDemo`, `HtmlToXamlDemo`, and more

### Original work
- **`archivage.xaml` / `archivage.xaml.cs`** — a small French-language WPF window prototyped for the fiscal cash-register project (data-type selection, date range, archive/export actions). Demonstrates `DockPanel` layout, styles, `ComboBox`, and `DatePicker`.

## Tech Stack

| Layer | Technology |
|-------|------------|
| Language | C# |
| UI framework | WPF (Windows Presentation Foundation) |
| Markup | XAML |
| Target framework | .NET 8.0 (`net8.0-windows`); SDK-style projects |
| SDK pinning | `global.json` (supports .NET 6/7/8 and .NET 9 preview tooling) |
| IDE / build | Visual Studio 2022 · `dotnet build` · `msbuild` |
| OS | Windows |

## Getting Started

```bash
# Clone
git clone https://github.com/MohamedKhattat/WPF-ALL-YOU-NEED-CSHARP.git
cd WPF-ALL-YOU-NEED-CSHARP
```

- Open **`WPFSamples.sln`** in **Visual Studio 2022** and build, **or**
- Navigate into any sample folder and run `dotnet build` / `dotnet run` on its `.csproj`.

**Notes**
- Requires the **.NET 8 SDK** (later SDKs work via the `global.json` roll-forward).
- `WPFSamples.msbuild.sln` contains projects that build only with **MSBuild / Visual Studio** (they include C++ code, which `dotnet build` does not support).
- Most samples are self-contained and can be built independently.

## Notes

- This is a **learning and reference repository**, not a single shippable application. Individual samples illustrate specific WPF concepts and may intentionally trade off best practices to keep each example focused.
- For the authoritative, continuously-updated source, see Microsoft's upstream [WPF-Samples](https://github.com/microsoft/WPF-Samples) and the open-source [WPF runtime](https://github.com/dotnet/wpf).
- Samples are provided as-is to demonstrate WPF programming models and feature APIs.

## License

Released under the **MIT License**. Unless otherwise noted, the samples originate from Microsoft's WPF-Samples and remain under their original MIT license (© Microsoft). See [`LICENSE`](LICENSE).

---
<p align="center">Built by <b>Mohamed Habib Khattat</b> — <a href="https://github.com/MohamedKhattat">GitHub</a> · <a href="https://www.linkedin.com/in/mohamed-habib-khattat-2b206a173">LinkedIn</a></p>
