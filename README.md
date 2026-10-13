# EscapeRoom3D

Laboratorio **Control de versiones con Git, GitHub, Visual Studio Code y Unity**  
Proyecto progresivo: Escape Room 3D

Docente: Erick Salomon Cespedes Gamarra

## Integrantes

- David
- Kevin Mollo
- Santiago
- Sebastian

### Organización del equipo

| Integrante | Rama principal |
|---|---|
| David | Feature_PlayerMovement |
| Kevin Mollo | Feature_Interaction / Feature_Puzzle |
| Santiago | Feature_Animation |
| Sebastian | Feature_Animation |

## Información del proyecto

- Género: Escape Room en primera persona (3D)
- Motor: Unity 6 (URP)
- Control de versiones: Git + GitHub, trabajado desde VS Code

## Objetivo

Explorar una habitación, resolver un código, abrir un cofre, obtener una llave y abrir la puerta de salida.

## Versión de Unity

6000.5.5f1

## Estrategia de ramas

```
main
└── Dev
    ├── Feature_PlayerMovement
    ├── Feature_Interaction
    ├── Feature_Animation
    └── Feature_Puzzle
```

Se desarrolla en `Feature_*`, se integra primero en `Dev` y solo se pasa a `main` mediante Pull Request.
