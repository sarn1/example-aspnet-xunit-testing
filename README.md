# example-aspnet-xunit-testing
https://teamtreehouse.com/library/xunitnet-unit-test-framework
https://xunit.github.io/docs/getting-started-desktop.html

- Install `xUnit` via Nuget
- Install `xUnit.Runner.VisualStudio` Nuget
- Click `add new project > search for xunit > xunit test project`
- Create the test, see `PointTests.cs`
- Add `TreehouseDefense` as a depedencies.
- Run test by going to `Test > Run All Test` or CTRL+R + A
- [Fact()] = attribute for xUnit unit testing framework that says that the method is a unit test.

```csharp
// Fill out MapTests.OnMapTest to test that Map.OnMap returns true when passed a point that is on the map.
using Xunit;

namespace TreehouseDefense.Tests
{
    public class MapTests
    {
        [Fact]
        public void OnMapTest()
        {
            var point = new Point(1,2);
            var map = new Map(5,5);
            
            if (map.OnMap(point))
            Assert.True(true, "Pass");
        }
    }
}

```

- Xunit runs each test randomly so you can't rely on the order of each method.
- For Xunit, the constructor is run each time a test method is runned, so the `_map3x3`, `_pathLocations3`, and `_path3` are reset each time.
```csharp
    public class PathTest
    {
        private Map _map3x3;
        private MapLocation[] _pathLocations3;
        private Path _path3;
        public PathTest()
        {
            _map3x3 = new Map(3, 3);

            _pathLocations3 = new MapLocation[]
            {
                new MapLocation(0, 1, _map3x3),
                new MapLocation(1, 1, _map3x3),
                new MapLocation(2, 1, _map3x3),
            };

            _path3 = new Path(_pathLocations3);
        }

        [Fact]
        public void MapLocationIsOnPath()
        {

            var target = _path3;
            Assert.True(target.IsOnPath(new MapLocation(0,1,_map3x3)));
        }

        public void MapLocationIsNotOnPath()
        {
            var target = _path3;
            Assert.False(target.IsOnPath(new MapLocation(3, 3, _map3x3)));
        }
    }
```
- CTRL+RR - simular to multiple cursors on a variable

```csharp


public class Calculator
{
    public double Result;

    public Calculator(double number)
    {
        Result = number;
    }     

    public void Add(double number)
    {
        Result += number;
    }

    public void Subtract(double number)
    {
        Result -= number;
    }
}


public class CalculatorTests
{
    [Fact]
    public void Initialization()
    {
        var expected = 1.1;
        var target = new Calculator(1.1);
        Assert.Equal(expected, target.Result, 1);
    }

    [Fact]
    public void BasicSubtract()
    {
        var target = new Calculator(3.3);
        target.Subtract(2.2);
        var expected = 1.1;
        Assert.Equal(expected, target.Result, 1);
    }
    
    [Fact]
    public void BasicAdd()
    {
        var target = new Calculator(1.1);
        target.Add(2.2);
        var expected = 3.3;
        Assert.Equal(expected, target.Result, 1);
    }
}


```
- The purpose of mock is to provide a super simplified version of the dependencies in order to test, nothing more.
