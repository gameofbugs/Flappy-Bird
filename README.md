# 🐦 Flappy Bird — Test Your Reflexes in 3 Modes

> **Tap to flap, dodge the pipes, survive as long as possible — now with 3 difficulty modes for every skill level.**

![Platform](https://img.shields.io/badge/Platform-Android-3DDC84?style=flat&logo=android&logoColor=white)
![Engine](https://img.shields.io/badge/Engine-Unity-000000?style=flat&logo=unity&logoColor=white)
![Language](https://img.shields.io/badge/Language-C%23-239120?style=flat&logo=csharp&logoColor=white)
![Status](https://img.shields.io/badge/Status-Shipped-brightgreen?style=flat)

---

## 🎮 Play It

[![Play on itch.io](https://img.shields.io/badge/Play_on-itch.io-FA5C5C?style=flat&logo=itch.io&logoColor=white)](https://gameofbugsofficial.itch.io/flappy-bird)

---

## 📖 About

A classic arcade-style challenge with a twist. This version of Flappy Bird lets you choose from three difficulty modes to match your skill level — whether you want a casual flap or a serious test of reflexes, there's a mode for you.

Your goal is simple: survive as long as possible and beat your high score. The pipes won't make it easy.

---

## 🎮 Difficulty Modes

| Mode | Pipe Speed | Gap Size | For |
|------|-----------|----------|-----|
| 🟢 Easy | Normal | Fair | Warming up |
| 🟡 Medium | Faster | Tighter | A real challenge |
| 🔴 Hard | High speed | Minimal | True flappy masters |

---

## 🕹️ Controls

| Input | Action |
|-------|--------|
| Tap / Click / Spacebar | Flap |

---

## 🔧 What I Built

- **3-Mode Difficulty System** — single ScriptableObject-driven config controlling pipe speed, gap size, and spawn rate per mode; swapped at runtime from the menu
- **Procedural Pipe Spawner** — pipes spawn at randomized heights with configurable gap sizes, despawn off-screen to keep memory clean
- **Score & High Score System** — session score tracked in real time, personal best persisted with PlayerPrefs across sessions
- **Physics-Based Bird Controller** — Rigidbody2D gravity with tap-to-impulse input, tuned per difficulty for fair feel
- **Quick Restart Flow** — instant restart without reloading the scene for fast-paced sessions

---

## 🧠 What I Learned

- Designing a **difficulty config system** that's data-driven rather than hardcoded — easy to tune without touching gameplay logic
- Tuning **Unity physics feel** on mobile — getting tap-to-flap to feel responsive without being floaty or too punishing
- **Procedural spawning with object pooling** concepts to keep performance smooth on Android
- Persisting high scores with **PlayerPrefs** across game sessions

---

## ⚙️ Tech

| Tool | Use |
|------|-----|
| Unity | Game engine |
| C# | All game logic |
| PlayerPrefs | High score persistence |
| Rigidbody2D | Bird physics |

---

## 🚀 Run Locally

1. Clone: `git clone https://github.com/gameofbugs/Flappy-Bird`
2. Open in Unity Hub
3. Open `MainMenu` scene and press Play

---

## 👤 About

Built solo by **Manoj S** — one of 7 shipped Android Unity games.
More projects: [gameofbugsofficial.itch.io](https://gameofbugsofficial.itch.io)
