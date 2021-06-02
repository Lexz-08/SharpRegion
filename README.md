## SharpRegion
### Description
A library for creating Regions with round corners for WinForms ui.

### How To Use
```csharp
// Initialize a new instance of type RegionGen, whilst giving it the appropriate parameters.
// This is assuming you are typing this is the source code of an actual form/control with the System.Windows.Forms namespace referenced.
int Radius = 5;
RegionGen rgnGen = new RegionGen(0, 0, Width + 1, Height + 1, Radius);

// Modify the region of your form/control with these events so that it will always update.
Resize += (s, e) =>
{
    Region = rgnGen.CreateRgn();
    Invalidate();
};
SizeChanged += (s, e) =>
{
    Region = rgnGen.CreateRgn();
    Invalidate();
};
Paint += (s, e) =>
{
    Region = rgnGen.CreateRgn();
    Invalidate();
};
```

### Download
[SharpRegion.dll](https://github.com/Lexz-08/SharpRegion/releases/download/sharpregion/SharpRegion.dll)
