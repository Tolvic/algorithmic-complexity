# algorithmic-complexity
The challenge outline for this repository can be found [here](https://github.com/makersacademy/course/tree/master/algorithmic_complexity).

## Todo
- [x] Pseudo code
- [x] Set up Environment
  - [x] Set up MVC 5 architecture
  - [x] .gitignore
  - [x] strip out superficial pages
  - [x] Set up routes
- [x] Create a testing class
- [x] Set up results view
- [ ] Test the following functions:
  - [ ] Last
  - [ ] reverse
  - [ ] shuffle
  - [ ] sort

## Testing Function

Pseudo code for how I anticipate this working

```
Test(FunctionToBeTested, StartArraySize, MaxArraySize, incrementSize, NbTimesTestsRepeated){
  results = new Hash
  i = StartArraySize
  n = 1  

  for (n; while n <= NoTimesTestsRepeated; n++){

    results[i] = new Array

    for (i; while i<= MaxArraySize; i += incrementSize){
      testArray = setup(i)

      var startTime = time.now

      FunctionToBeTested(testArray)

      var timeTaken = time.now - startTime

      results[i] << timeTaken

      tearDown()
    }  
  }

  removeUpperLowerBounds()
  averageResults()
  return results;
}

setup(arraySize){
  return array(1... arraySize).shuffle
}

tearDown(){
  # If there is anything that needs tearing down after each test it would be handled here
  # possible clear memory?
}
```

Results Hash will be structured:
```
{
  arraySize[0]{result1, result2, ...},
  arraySize[1]{result1, result2, ...},
  arraySize[2]...
}
```
and will resemble the below prior to averaging or removing upper and lower bounds.


```
Results {
  10 => {
    0.02, 0.03, 0.02
  }
  20 => {
    0.02, 0.03, 0.02
  }
  30 => {
    0.02, 0.03, 0.02
  }
}
```

This looks like it will be useful for setting up the function in c#

https://stackoverflow.com/questions/2082615/pass-method-as-parameter-using-c-sharp

Also, show time in nano seconds

## Contributors
* [Aimée Craig](https://github.com/aimeecraig/)
* [Terry Mace](https://github.com/Tolvic)
