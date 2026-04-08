# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Commands

```bash
# Build
dotnet build

# Run all tests
dotnet test

# Run a single test class
dotnet test --filter "ClassName=TwoSumTests"

# Run a single test method
dotnet test --filter "ClassName=TwoSumTests&MethodName=Run_ReturnsExpectedResult"

# Run tests with coverage
dotnet test --collect:"XPlat Code Coverage"
```

## Architecture

Two projects in one solution:
- `src/LeetCode.Problems.csproj` — solution implementations, .NET 10, no external dependencies
- `tests/LeetCode.Problems.Tests.csproj` — MSTest test project, 1:1 file mapping to source

## Conventions for Adding New Problems

**Source file** (`src/ProblemName.cs`):
- `public sealed class ProblemName` in namespace `LeetCode.Problems`
- Static entry point method (typically `Run(...)`)
- Nested data structure classes (`ListNode`, `TreeNode`) defined inside the solution class when needed

**Test file** (`tests/ProblemNameTests.cs`):
- `public sealed class ProblemNameTests` with `[TestClass]`
- Use `[DataRow(...)]` for simple inline test cases, or a static `GetTestData()` method returning `IEnumerable<object[]>` with `[DynamicData(nameof(GetTestData))]` for complex inputs
- Use `CollectionAssert.AreEqual()` for array/list comparisons; write custom assertion helpers for tree/linked-list structures
