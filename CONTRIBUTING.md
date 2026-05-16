# Contributing to Car Maintenance Tracker

Thank you for your interest in contributing! This document provides guidelines and instructions for contributing to the project.

## 🎯 Code of Conduct

- Be respectful and inclusive
- Provide constructive feedback
- Focus on the code, not the person
- Help others learn and grow

## 🚀 Getting Started

1. **Fork the repository** on GitHub
2. **Clone your fork** locally:
   ```bash
   git clone https://github.com/YOUR-USERNAME/car-maintenance.git
   cd car-maintenance
   ```
3. **Create a feature branch**:
   ```bash
   git checkout -b feature/your-feature-name
   ```
4. **Make your changes** and test thoroughly
5. **Commit with clear messages**:
   ```bash
   git commit -m "feat: add new feature description"
   ```
6. **Push to your fork** and **submit a Pull Request**

## 📝 Commit Message Guidelines

Follow conventional commits format:

```
feat: Add new feature
fix: Fix a bug
docs: Update documentation
style: Code style changes
refactor: Code refactoring
perf: Performance improvements
test: Add tests
chore: Build/dependency updates
```

Example:
```
feat: Add multiple maintenance types tracking
- Add MaintenanceType enum
- Update OilChangeEntry model
- Extend UI to support type selection
```

## 🏗️ Architecture Guidelines

### MVVM Pattern
- **Models**: Data structures (keep simple, no business logic)
- **ViewModels**: Business logic, commands, binding properties
- **Views**: UI only, no code-behind logic except initialization

### Naming Conventions
- **Classes**: `PascalCase` (e.g., `OilChangeViewModel`)
- **Methods**: `PascalCase` (e.g., `AddEntry()`)
- **Properties**: `PascalCase` (e.g., `NewDate`)
- **Private fields**: `_camelCase` (e.g., `_newDate`)
- **Constants**: `UPPER_CASE` (e.g., `OIL_CHANGE_INTERVAL_MILES`)

### Code Style
```csharp
// Good: Clear, readable, follows conventions
public class OilChangeViewModel : BindableObject
{
    private const int OilChangeIntervalMiles = 5000;
    
    private int _newOdometerMiles;
    
    public int NewOdometerMiles
    {
        get => _newOdometerMiles;
        set
        {
            _newOdometerMiles = value;
            OnPropertyChanged();
        }
    }
    
    public ICommand AddCommand => new Command(AddEntry);
    
    private void AddEntry()
    {
        // Implementation
    }
}
```

## 🧪 Testing

- Test on **both iOS and Android** before submitting PR
- Verify functionality on **real devices** when possible
- Test **edge cases** (empty lists, invalid input, etc.)
- Check **data persistence** across app sessions

### Testing Checklist
- [ ] Feature works on Android
- [ ] Feature works on iOS
- [ ] UI is responsive and accessible
- [ ] No console errors or warnings
- [ ] Data persists after app restart
- [ ] Edge cases are handled

## 📱 Platform-Specific Considerations

### Android
- Test on API level 24+ devices
- Verify storage permissions
- Check performance on lower-end devices
- Test with different screen sizes

### iOS
- Test on iOS 14.2+ devices
- Verify safe area handling
- Check gesture recognition
- Test with different orientations

## 📚 Documentation

- Update README.md for user-facing changes
- Add XML documentation comments to public members
- Update QUALITY_ROADMAP.md for planned features
- Include examples for complex features

### Example Documentation
```csharp
/// <summary>
/// Adds a new oil change entry to the collection.
/// </summary>
/// <remarks>
/// This method validates the odometer reading and automatically
/// sets the entry as pending. The NextOilChangeMileage property
/// is updated after insertion.
/// </remarks>
public void AddEntry()
{
    // Implementation
}
```

## 🔍 Code Review Checklist

Before submitting a PR, ensure:

- [ ] Code follows project style guidelines
- [ ] No breaking changes (or documented migrations)
- [ ] New features have appropriate documentation
- [ ] Tests pass on both platforms
- [ ] Performance is acceptable
- [ ] No hardcoded values or secrets
- [ ] Proper error handling is in place
- [ ] UI is responsive on different devices

## 📦 Pull Request Process

1. **Update** your feature branch with latest main:
   ```bash
   git fetch upstream
   git rebase upstream/main
   ```

2. **Create a Pull Request** with:
   - Clear title and description
   - Reference to related issues (e.g., "Fixes #123")
   - List of changes made
   - Testing performed
   - Screenshots (for UI changes)

3. **Respond to feedback** promptly
4. **Merge** once approved by maintainers

### PR Template
```markdown
## Description
Brief description of changes

## Type of Change
- [ ] Bug fix
- [ ] New feature
- [ ] Breaking change
- [ ] Documentation update

## Testing Performed
- [ ] Tested on Android
- [ ] Tested on iOS
- [ ] Tested edge cases
- [ ] Data persistence verified

## Screenshots (if applicable)
[Add screenshots here]

## Related Issues
Fixes #(issue number)
```

## 🚀 Feature Development

### Before Starting
1. Check existing issues and PRs
2. Open an issue to discuss major changes
3. Get feedback from maintainers
4. Create a feature branch

### During Development
1. Make small, focused commits
2. Test frequently on both platforms
3. Keep the code clean and readable
4. Add comments for complex logic

### Before Submitting
1. Run final tests on real devices
2. Review your own code first
3. Update documentation
4. Create a clear PR description

## 🐛 Bug Reporting

If you find a bug, please:

1. **Check existing issues** to avoid duplicates
2. **Provide detailed reproduction steps**:
   ```
   1. Open app
   2. Add an entry with mileage X
   3. Toggle completion status
   4. Observed: [What happened]
   5. Expected: [What should happen]
   ```
3. **Include environment info**:
   - Device (e.g., iPhone 14, Samsung Galaxy S23)
   - OS version (e.g., iOS 16.5, Android 13)
   - App version
4. **Attach logs** if applicable
5. **Provide screenshots** showing the issue

## 📈 Feature Requests

To suggest a feature:

1. **Check existing issues** first
2. **Explain the use case**: Why is this feature needed?
3. **Provide examples**: How would users interact with it?
4. **Discuss implementation**: Any suggestions for how to build it?

## 🎓 Learning Resources

- [.NET MAUI Documentation](https://learn.microsoft.com/en-us/dotnet/maui/)
- [MVVM Pattern Guide](https://learn.microsoft.com/en-us/dotnet/architecture/maui/mvvm)
- [C# Naming Conventions](https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/coding-conventions)
- [Git Workflow Guide](https://git-scm.com/book/en/v2)

## ❓ Questions?

- Open a **GitHub Discussion** for questions
- Check **existing issues** for answers
- Review **code examples** in the repository
- Ask on **Stack Overflow** (tag: dotnet-maui)

## 🙏 Thank You!

Your contributions make this project better. Thank you for being part of the community!

---

**Happy coding! 🚀**
