# Dependency Injection Examples in C# 🚀  

This repository demonstrates different approaches to **Dependency Injection (DI)** in C#.  
Each example shows how dependencies can be managed, highlighting the benefits and trade-offs of each method.  

---

## 📂 What’s Inside  

1. **Without Dependency Injection**  
   - Dependencies (`Hammer`, `Saw`) are created directly inside the `Builder` class.  
   - Tightly coupled → harder to test and maintain.  

2. **Constructor Injection**  
   - Dependencies are passed through the constructor.  
   - Most common and recommended approach in .NET.  
   - Promotes immutability and testability.  

3. **Setter (Property) Injection**  
   - Dependencies are assigned via public properties.  
   - Useful when dependencies are optional.  
   - Risk of `NullReferenceException` if not set.  

4. **Interface Injection**  
   - Dependencies are injected through methods defined in an interface.  
   - Explicit contract for providing dependencies.  
   - Less common in .NET compared to constructor injection.  

---

## 💡 Why This Matters  

Dependency Injection helps to:  
- Reduce **tight coupling** between classes.  
- Improve **testability** (easy to swap real objects with mocks).  
- Make code more **maintainable and flexible**.  
- Align with **SOLID principles** (especially Dependency Inversion).  

---

## 🛠️ Tech Used  

- **C# (.NET)**  
