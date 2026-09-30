# Investigación navideña — assets, animación, VFX, audio y licencias

Work Item: #44
Accessed: 2026-09-30. No assets downloaded/incorporated.

| ID | Candidato / creador | Fuente primaria | Licencia/uso verificado | Modificación / APK | Formato/rig | Utilidad | Clasificación |
|---|---|---|---|---|---|---|---|
| AS-001 | Holiday Kit / Kenney | https://kenney.nl/assets/holiday-kit | CC0; Kenney support states commercial use and no attribution required | modification/use in product allowed under CC0; APK inclusion allowed | 3D; page advertises animation | cabins/tree/holiday props as raw material | **ADAPT** |
| AS-002 | Prototype Kit / Kenney | https://kenney.nl/assets/prototype-kit | CC0 | same | 3D, animation/variations | greybox/prototype characters/geometry, not final identity | **ADAPT** |
| AS-003 | UI Pack / Kenney | https://kenney.nl/assets/ui-pack | CC0 | same | 2D UI | prototype HUD only; restyle for identity | **ADAPT** |
| AS-004 | Input Prompts / Kenney | https://kenney.nl/assets/input-prompts | CC0 | same | sprites/sheets/fonts; includes touch/generic prompts | touch onboarding/accessibility | **ADAPT** |
| AS-005 | Impact Sounds / Kenney | https://kenney.nl/assets/impact-sounds | CC0 | same | audio | impacts/destruction prototype | **ADAPT** |
| AS-006 | UI Audio / Kenney | https://kenney.nl/assets/ui-audio | CC0 | same | audio | buttons/feedback | **ADAPT** |
| AS-007 | Music Jingles / Kenney | https://kenney.nl/assets/music-jingles | CC0 | same | audio | result/short stingers; not necessarily Christmas identity | **REFERENCE_ONLY/ADAPT after audition** |
| AS-008 | Snow 02 / Rob Tuytel, Poly Haven | https://polyhaven.com/a/snow_02 | CC0; Poly Haven states commercial use, modification, redistribution and no attribution required | allowed | PBR maps up to high resolution; choose mobile resolution | snow material source | **ADAPT** |
| AS-009 | Coated Pine / Poly Haven authors | https://polyhaven.com/a/coated_pine | CC0 | allowed | PBR texture/maps | workshop/village wood; downsample/mobile material needed | **ADAPT** |
| AS-010 | Mixamo animations / Adobe | https://helpx.adobe.com/creative-cloud/faq/mixamo-faq.html | Adobe FAQ: characters/animations royalty-free for personal/commercial/non-profit incl. video games | use in game allowed; exact raw-file redistribution terms require Adobe terms review before repository distribution | bipedal humanoid auto-rigger/animation library | locomotion/combat prototype/retarget testing | **ADAPT CANDIDATE** |
| AS-011 | Quaternius asset library / Quaternius | https://quaternius.com/ | QAL v1.0 (site license updated 2026-08-28): commercial product use/modification allowed, no attribution; standalone asset redistribution prohibited | product/APK incorporation allowed by license text; raw asset redistribution prohibited | library includes rigged/retargetable characters/animation and modular environments | base characters/animation/nature props; verify each selected pack is under QAL | **ADAPT CANDIDATE** |
| AS-012 | Freesound library | https://freesound.org/help/faq/ | item-dependent Creative Commons licenses | varies per sound | audio | discovery source only | **REFERENCE_ONLY until exact item+license pinned** |
| AS-013 | OpenGameArt | https://opengameart.org/content/faq | item-dependent; site supports CC0/CC-BY/CC-BY-SA/OGA-BY/GPL etc | varies; some licenses impose attribution/share-alike/DRM constraints | varied | discovery source only | **REFERENCE_ONLY until exact item+license pinned** |

## Primary license facts
**VERIFIED FACT:** Kenney support states assets on asset pages are CC0, usable commercially, attribution not required.
**VERIFIED FACT:** Poly Haven states all its assets are CC0 and usable commercially without attribution.
**SOURCE CLAIM (Adobe official FAQ):** Mixamo characters/animations may be used royalty-free in commercial video games; auto-rigger/animation library is bipedal humanoid.
**VERIFIED FACT from Quaternius published license text:** QAL v1.0 grants product use/copy/modify/commercial distribution and forbids standalone asset redistribution.
**VERIFIED FACT:** OGA/Freesound are aggregators/libraries with per-item licensing; a library URL alone never authorizes an arbitrary item.

## Shortlist by category
Characters/rig: Mixamo for temporary rig/animation testing; Quaternius base humanoids if exact pack license confirmed; final Santa/elf visual should be original/customized.
Animation: Mixamo + Quaternius universal animation candidates; validate retarget quality.
Environment: Kenney Holiday Kit for modular prototype props; Poly Haven snow/wood materials; Quaternius nature only after exact pack check.
Weapons/props/obstacles: Kenney Holiday/prototype pieces can be transformed; custom hero props preferred for identity.
VFX: no exact external VFX asset selected in this pass; **UNKNOWN**. Prefer original particle graphs/material effects using CC0 textures where needed.
UI: Kenney UI/Input Prompts for prototype, but visual restyle required.
Audio: Kenney Impact/UI audio safest CC0 shortlist; music identity remains **UNKNOWN**, jingles only temporary/reference.
Fonts/localization: Kenney Fonts CC0 candidate exists, but language glyph coverage for Spanish punctuation must be tested per font.

## Originality strategy
Do not import a complete themed template as final look. Combine geometry/material/animation/audio sources from independent origins, modify proportions/materials/silhouettes, create original Santa/elf/enemy hero assets and establish a project-specific palette/shapes in #45.

## License handling before incorporation
For every selected file: snapshot asset title/version/date, source URL, license text/source, author, attribution if any, downloaded archive hash, included files, modifications, destination, and redistribution restrictions. Mixamo/Quaternius raw-source sharing constraints require repository/distribution review before committing source files.

## UNKNOWN
Exact Santa/elf/enemy asset candidates; final music; VFX pack; Spanish-capable final font; polygon/bone/material counts of candidates until downloaded/inspected; whether repository can contain raw Mixamo/QAL files under their terms.
