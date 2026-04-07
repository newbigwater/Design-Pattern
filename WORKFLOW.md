# Workflow Guide

## Scope
This file defines practical working steps for recurring tasks in this repository.

## Priority
- `AGENTS.md` defines repository-level rules.
- If this file conflicts with `AGENTS.md`, follow `AGENTS.md`.

## Documentation Workflow
Apply this when creating or rewriting pattern documents under `doc/`.

## Versioned Improvement Workflow
Apply this when the user provides a source folder such as `src/<category>/<pattern>/Version 01/`.

### 1) Baseline Review
- Treat `Version 01/` as the original learning baseline.
- Review the code before changing anything and identify improvement points in small, explainable steps.

### 2) Version Creation Rule
- Start improvements at `Version 02/`.
- Create a new version folder for each meaningful improvement step.
- If a structural change is large, split it into multiple versions instead of combining it into one jump.

### 3) Version Isolation Rule
- Keep each version folder self-contained.
- Duplicate same-named files per version when needed.
- Do not reference source files across `Version 01/`, `Version 02/`, and later folders.

### 1) Standard Document Structure
Use the following top-level structure:
1. Pattern overview
2. Example domain description
3. Per-version analysis
4. Version differences

### 2) Per-version Analysis Format
For each version section, include both:
- `Pseudo Code`
- `PlantUML`

Recommended order:
- `### 3.x VerN - <summary>`
- `#### Pseudo Code`
- `#### PlantUML`

Document each improvement version from `Version 01` through the latest version, and explain what changed in that step and why it was separated from the next step.

### 3) Language and Notation Rules
- Write explanatory prose in Korean.
- When writing generic notation like `<T>` in prose, use backticks: `` `<T>` ``.
- Keep code identifiers as-is (class names, method names, namespaces).

### 4) README Synchronization Rule
Whenever a new document is added under `doc/`:
- Add or update the corresponding list entry in repository root `README.md`.
- Keep links grouped by pattern category (Creational / Structural / Behavioral).

### 5) MOC Synchronization Rule
When a new pattern document is added:
- Update `doc/_MOC_.md` if category-level links changed.
- Update category `_MOC_.md` in the matching folder.

## Test Workflow
- Add or update MSTest suites in `src/unitTest/` for the pattern under review.
- Ensure tests cover each version independently when multiple version folders exist.
- Include regression-oriented assertions for the specific improvement introduced in each new version.

## Commit Workflow
- Keep commit messages short and imperative.
- Do not include author attribution text such as "created by AI agent".
- Stage only intended files when unrelated local changes exist.

## Pre-push Checklist
- Baseline `Version 01/` was reviewed before adding later versions.
- Each improvement step has its own version folder when the change is structurally meaningful.
- Version folders are self-contained with no cross-version source dependency.
- Document follows the 1~4 structure above.
- Version sections include both pseudo code and PlantUML.
- Documentation explains the reason for each version split.
- Test suite covers the added or updated versions.
- README index is updated for new docs.
- No unintended workspace/editor metadata is staged.
