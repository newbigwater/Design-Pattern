# Repository Guidelines

## Workflow Reference
For detailed execution steps, checklists, and documentation workflow, see [`WORKFLOW.md`](D:\20. Areas\Design-Pattern\WORKFLOW.md).

If any rule in `WORKFLOW.md` conflicts with `AGENTS.md`, `AGENTS.md` takes precedence.

## Project Structure & Module Organization
`src/` contains the Visual Studio solution [`_buildAll.sln`](D:\20. Areas\Design-Pattern\src\_buildAll.sln) and the C# projects. Pattern examples are grouped by category: `01. Creational Pattern/`, `02. Structural Pattern/`, and `03. Behavioral Pattern/`. The console entry point lives in `src/app/`. Unit tests are centralized in `src/unitTest/` and mirror the same pattern-based folder structure. Repository documentation lives in `doc/`, while reusable note templates and references live under `00. System/`.

Initial learning material is expected under a pattern-specific `Version 01/` folder, for example `src/01. Creational Pattern/AbstractFactory/Version 01/`. When improving a pattern, create `Version 02/`, `Version 03/`, and later folders as needed. Each version must be self-contained: if the same class exists in multiple versions, create a separate file in each version folder and do not introduce cross-version file dependencies.

## Agent Responsibilities
When the user provides a pattern folder, treat it as the baseline learning version, review it first, then deliver:

- Incremental improvement versions starting from `Version 02/`.
- One structural change per version when the refactor is substantial.
- Matching documentation under `doc/` describing the staged improvements.
- Matching MSTest coverage under `src/unitTest/`.

Do not skip intermediate design steps when a change can be explained as a sequence of smaller improvements.

## Build, Test, and Development Commands
Run commands from the repository root unless noted.

- `msbuild src\\_buildAll.sln /p:Configuration=Debug` builds all projects in Debug.
- `msbuild src\\_buildAll.sln /p:Configuration=Release` builds optimized binaries.
- `vstest.console.exe src\\unitTest\\bin\\Debug\\unitTest.dll` runs the MSTest suite after a Debug build.
- `devenv src\\_buildAll.sln` opens the full solution in Visual Studio for local development.

If package restore errors appear, restore missing `packages/` dependencies in Visual Studio before rebuilding.

## Coding Style & Naming Conventions
Use 4-space indentation and standard C# brace placement. Follow the existing naming style in this repository:

- Types: PascalCase with pattern prefixes such as `Adapter_PrintBanner_Ver1`.
- Private fields: leading underscore, for example `_banner`.
- Test methods: descriptive PascalCase with underscores, for example `Adapter_Ver3_Throws_On_Null_Adaptee`.
- Keep new files inside the matching pattern folder and namespace.

Preserve the existing `#region` structure in source files when editing older classes.

## Testing Guidelines
Tests use MSTest (`Microsoft.VisualStudio.TestTools.UnitTesting`) targeting .NET Framework 4.8. Add tests in `src/unitTest/<pattern group>/` alongside the related partial test class. Cover happy-path behavior and edge cases such as null inputs or invalid state. Prefer one assertion theme per test and name tests after the behavior being verified.

When multiple version folders exist for one pattern, add or extend tests so each version can be validated independently.

## Commit & Pull Request Guidelines
Recent commits use short, imperative summaries such as `Refactor pattern docs to unified format` and `Normalize angle-bracket notation in docs and template`. Keep commit subjects concise and action-oriented.

Pull requests should include:

- A short summary of the pattern or documentation change.
- Linked issue or rationale for the change.
- Test results when code changes are included.
- Screenshots only when Markdown attachments or rendered docs materially changed.
