# SortRace

A simple benchmarking application built to measure and compare the performance of various sorting algorithms when processing an array of $N$ integers.

This repository contains the source code created as an assignment for **Algorithms** course to empirically verify time complexities and observe how theoretical efficiencies translate to practical runtime execution.

---

## 🚀 Features

* **Side-by-Side Comparison:** Evaluates multiple sorting algorithms on identical integer datasets.
* **Configurable Input Size ($N$):** Scales array sizes dynamically to analyze algorithm performance across different dataset magnitudes.
* **Precise Benchmarking:** Uses C#'s `System.Diagnostics.Stopwatch` for precise microsecond/millisecond execution time tracking.

---

## 📊 Implemented Algorithms

The benchmark includes the following sorting techniques:

| Algorithm | Average Time Complexity | Worst Case |
| :--- | :--- | :--- |
| **Bubble Sort** | $\mathcal{O}(n^2)$ | $\mathcal{O}(n^2)$ |
| **Selection Sort** | $\mathcal{O}(n^2)$ | $\mathcal{O}(n^2)$ |
| **Insertion Sort** | $\mathcal{O}(n^2)$ | $\mathcal{O}(n^2)$ |
| **Shell Sort** | $\mathcal{O}(n \log^2 n)$ | $\mathcal{O}(n^2)$ |
| **Heap Sort** | $\mathcal{O}(n \log n)$ | $\mathcal{O}(n \log n)$ |
| **Quick Sort** | $\mathcal{O}(n \log n)$ | $\mathcal{O}(n^2)$ |
| **Bucket Sort** | $\mathcal{O}(n + k)$ | $\mathcal{O}(n^2)$ |

---

## 🛠️ Getting Started

### Prerequisites

* [.NET SDK 6.0](https://dotnet.microsoft.com/) or higher.

### Running the Application

1. **Clone the repository:**
   ```bash
   git clone https://github.com/words10/SortRace
   cd SortRace
   ```

2. **Compile and run:**
   ```bash
   dotnet build --configuration Release
   dotnet run -c Release
   ```

---

## 📝 License

This repository is maintained for educational purposes as part of university coursework.
